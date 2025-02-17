﻿namespace BossMod.Autorotation;

public sealed class ClassBRDUtility(RotationModuleManager manager, Actor player) : RoleRangedUtility(manager, player)
{
    public enum Track { WardensPaean = SharedTrack.Count, Troubadour, NaturesMinne }

    public static readonly ActionID IDLimitBreak3 = ActionID.MakeSpell(BRD.AID.SagittariusArrow);

    public enum TroubOption { None, Use87, Use88 }

    public static RotationModuleDefinition Definition()
    {
        var res = new RotationModuleDefinition("Utility: BRD", "Cooldown Planner support for Utility Actions.\nNOTE: This is NOT a rotation preset! All Utility modules are STRICTLY for cooldown-planning usage.", "Utility for planner", "veyn", RotationModuleQuality.Excellent, BitMask.Build((int)Class.BRD), 100);
        DefineShared(res, IDLimitBreak3);

        DefineSimpleConfig(res, Track.WardensPaean, "WardensPaean", "Dispel", -10, BRD.AID.WardensPaean, 30);

        res.Define(Track.Troubadour).As<TroubOption>("Troubadour", "Troub", 500)
            .AddOption(TroubOption.None, "None", "Do not use automatically")
            .AddOption(TroubOption.Use87, "Use", "Use Troubadour", 120, 15, ActionTargets.Self, 62, 87)
            .AddOption(TroubOption.Use88, "Use88", "Use Troubadour", 90, 15, ActionTargets.Self, 88)
            .AddAssociatedActions(BRD.AID.Troubadour);

        DefineSimpleConfig(res, Track.NaturesMinne, "NaturesMinne", "Minne", 400, BRD.AID.NaturesMinne, 15);

        return res;
    }

    public override void Execute(StrategyValues strategy, ref Actor? primaryTarget, float estimatedAnimLockDelay, bool isMoving)
    {
        ExecuteShared(strategy, IDLimitBreak3, primaryTarget);
        ExecuteSimple(strategy.Option(Track.WardensPaean), BRD.AID.WardensPaean, Player);
        ExecuteSimple(strategy.Option(Track.NaturesMinne), BRD.AID.NaturesMinne, Player);

        var troub = strategy.Option(Track.Troubadour);
        if (troub.As<TroubOption>() != TroubOption.None)
            Hints.ActionsToExecute.Push(ActionID.MakeSpell(BRD.AID.Troubadour), Player, troub.Priority(), troub.Value.ExpireIn);
    }
}
