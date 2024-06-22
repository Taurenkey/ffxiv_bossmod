//namespace BossMod;

//public static class PlanDefinitions
//{
//    public static readonly Dictionary<Class, ClassData> Classes = new()
//    {
//        [Class.PLD] = DefinePLD(),
//        [Class.GNB] = DefineGNB(),

//        [Class.DNC] = DefineDNC(),

//        [Class.MNK] = DefineMNK(),
//        [Class.RPR] = DefineRPR(),
//        [Class.SAM] = DefineSAM()
//    };

//    private static ClassData DefinePLD()
//    {
//        var c = new ClassData(typeof(PLD.AID));
//        c.CooldownTracks.Add(new("Sentinel", ActionID.MakeSpell(PLD.AID.Sentinel), 38));
//        c.CooldownTracks.Add(new("Rampart", ActionID.MakeSpell(PLD.AID.Rampart), 8));
//        c.CooldownTracks.Add(new("HallowedGround", ActionID.MakeSpell(PLD.AID.HallowedGround), 30));
//        c.CooldownTracks.Add(new("Sheltron", ActionID.MakeSpell(PLD.AID.Sheltron), 35));
//        c.CooldownTracks.Add(new("ArmsLength", ActionID.MakeSpell(PLD.AID.ArmsLength), 32));
//        c.CooldownTracks.Add(new("Reprisal", ActionID.MakeSpell(PLD.AID.Reprisal), 22));
//        return c;
//    }

//    private static ClassData DefineMNK()
//    {
//        var c = new ClassData(typeof(MNK.AID));
//        c.CooldownTracks.Add(new("Feint", ActionID.MakeSpell(MNK.AID.Feint), 22));
//        c.CooldownTracks.Add(new("ArmsL", ActionID.MakeSpell(MNK.AID.ArmsLength), 32));
//        c.CooldownTracks.Add(new("RoE", ActionID.MakeSpell(MNK.AID.RiddleOfEarth), 64));
//        c.CooldownTracks.Add(new("Mantra", ActionID.MakeSpell(MNK.AID.Mantra), 42));
//        c.StrategyTracks.Add(new("Dash", typeof(MNK.Rotation.Strategy.DashStrategy)));
//        c.StrategyTracks.Add(new("TrueN", typeof(CommonRotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("DF", typeof(CommonRotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("Demo", typeof(CommonRotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("Nadi", typeof(MNK.Rotation.Strategy.NadiChoice)));
//        c.StrategyTracks.Add(new("RoF", typeof(MNK.Rotation.Strategy.FireStrategy)));
//        c.StrategyTracks.Add(new("RoW", typeof(CommonRotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("BH", typeof(CommonRotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("TFC", typeof(CommonRotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("Meditate", typeof(CommonRotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("PB", typeof(CommonRotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("PB1", typeof(MNK.Rotation.Strategy.FormChoice)));
//        c.StrategyTracks.Add(new("PB2", typeof(MNK.Rotation.Strategy.FormChoice)));
//        c.StrategyTracks.Add(new("PB3", typeof(MNK.Rotation.Strategy.FormChoice)));
//        c.StrategyTracks.Add(new("FS", typeof(MNK.Rotation.Strategy.FormShiftStrategy)));
//        c.StrategyTracks.Add(new("FSForm", typeof(MNK.Rotation.Strategy.FormChoice)));
//        c.StrategyTracks.Add(new("Blitz", typeof(MNK.Rotation.Strategy.BlitzStrategy)));
//        c.StrategyTracks.Add(new("DK", typeof(MNK.Rotation.Strategy.DragonKickStrategy)));
//        c.StrategyTracks.Add(new("SSS", typeof(CommonRotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("Potion", typeof(CommonRotation.Strategy.OffensiveAbilityUse)));
//        return c;
//    }

//    private static ClassData DefineDNC()
//    {
//        var c = new ClassData(typeof(DNC.AID));
//        c.CooldownTracks.Add(new("Samba", ActionID.MakeSpell(DNC.AID.ShieldSamba), 56));
//        c.CooldownTracks.Add(new("Waltz", ActionID.MakeSpell(DNC.AID.CuringWaltz), 52));
//        c.CooldownTracks.Add(new("Improv", ActionID.MakeSpell(DNC.AID.Improvisation), 80));
//        c.CooldownTracks.Add(new("ArmsL", ActionID.MakeSpell(BRD.AID.ArmsLength), 32));
//        c.CooldownTracks.Add(new("Sprint", ActionDefinitions.IDSprint, 1));
//        c.StrategyTracks.Add(new("Gauge", typeof(CommonRotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("Feather", typeof(CommonRotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("TechStep", typeof(CommonRotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("StdStep", typeof(CommonRotation.Strategy.OffensiveAbilityUse)));
//        return c;
//    }

//    private static ClassData DefineRPR()
//    {
//        var c = new ClassData(typeof(RPR.AID));
//        c.CooldownTracks.Add(new("ACrest", ActionID.MakeSpell(RPR.AID.ArcaneCrest), 40));
//        c.CooldownTracks.Add(new("Feint", ActionID.MakeSpell(RPR.AID.Feint), 22));
//        c.CooldownTracks.Add(new("ArmsL", ActionID.MakeSpell(RPR.AID.ArmsLength), 32));
//        c.CooldownTracks.Add(new("Sprint", ActionDefinitions.IDSprint, 1));
//        c.StrategyTracks.Add(new("Gauge", typeof(RPR.Rotation.Strategy.GaugeUse)));
//        c.StrategyTracks.Add(new("SOUL", typeof(RPR.Rotation.Strategy.BloodstalkUse)));
//        c.StrategyTracks.Add(new("SS", typeof(RPR.Rotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("TrN", typeof(RPR.Rotation.Strategy.TrueNorthUse)));
//        c.StrategyTracks.Add(new("ENSH", typeof(RPR.Rotation.Strategy.EnshroudUse)));
//        c.StrategyTracks.Add(new("ARC", typeof(RPR.Rotation.Strategy.ArcaneCircleUse)));
//        c.StrategyTracks.Add(new("Glut", typeof(RPR.Rotation.Strategy.GluttonyUse), 60));
//        c.StrategyTracks.Add(new("Potion", typeof(RPR.Rotation.Strategy.PotionUse), 270));
//        c.StrategyTracks.Add(new("spec", typeof(RPR.Rotation.Strategy.SpecialAction)));
//        return c;
//    }

//    private static ClassData DefineSAM()
//    {
//        var c = new ClassData(typeof(SAM.AID));
//        c.CooldownTracks.Add(new("ThirdEye", ActionID.MakeSpell(SAM.AID.ThirdEye), 6));
//        c.CooldownTracks.Add(new("Feint", ActionID.MakeSpell(SAM.AID.Feint), 22));
//        c.CooldownTracks.Add(new("ArmsL", ActionID.MakeSpell(SAM.AID.ArmsLength), 32));
//        c.CooldownTracks.Add(new("Sprint", ActionDefinitions.IDSprint, 1));
//        c.StrategyTracks.Add(new("TrueN", typeof(CommonRotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("Cast", typeof(CommonRotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("Higanbana", typeof(SAM.Rotation.Strategy.HiganbanaUse)));
//        c.StrategyTracks.Add(new("Meikyo", typeof(SAM.Rotation.Strategy.MeikyoUse)));
//        c.StrategyTracks.Add(new("Dash", typeof(SAM.Rotation.Strategy.DashUse)));
//        c.StrategyTracks.Add(new("Enpi", typeof(SAM.Rotation.Strategy.EnpiUse)));
//        c.StrategyTracks.Add(new("Kenki", typeof(SAM.Rotation.Strategy.KenkiUse)));
//        return c;
//    }

//    private static ClassData DefineGNB()
//    {
//        var c = new ClassData(typeof(GNB.AID));
//        c.CooldownTracks.Add(new("Nebula", ActionID.MakeSpell(GNB.AID.Nebula), 38));
//        c.CooldownTracks.Add(new("Rampart", ActionID.MakeSpell(GNB.AID.Rampart), 8));
//        c.CooldownTracks.Add(new("Camoufl", ActionID.MakeSpell(GNB.AID.Camouflage), 6));
//        c.CooldownTracks.Add(new("Bolide", ActionID.MakeSpell(GNB.AID.Superbolide), 50));
//        c.CooldownTracks.Add(new("HOC", new[] { (ActionID.MakeSpell(GNB.AID.HeartOfCorundum), 82), (ActionID.MakeSpell(GNB.AID.HeartOfStone), 68) }));
//        c.CooldownTracks.Add(new("Aurora", ActionID.MakeSpell(GNB.AID.Aurora), 45));
//        c.CooldownTracks.Add(new("ArmsL", ActionID.MakeSpell(GNB.AID.ArmsLength), 32));
//        c.CooldownTracks.Add(new("Reprisal", ActionID.MakeSpell(GNB.AID.Reprisal), 22));
//        c.CooldownTracks.Add(new("HoL", ActionID.MakeSpell(GNB.AID.HeartOfLight), 64));
//        c.CooldownTracks.Add(new("Taunt", ActionID.MakeSpell(GNB.AID.Provoke), 15));
//        c.CooldownTracks.Add(new("Shirk", ActionID.MakeSpell(GNB.AID.Shirk), 48));
//        c.CooldownTracks.Add(new("Sprint", ActionDefinitions.IDSprint, 1));
//        c.StrategyTracks.Add(new("Gauge", typeof(GNB.Rotation.Strategy.GaugeUse)));
//        c.StrategyTracks.Add(new("Potion", typeof(GNB.Rotation.Strategy.PotionUse), 270));
//        c.StrategyTracks.Add(new("NoM", typeof(GNB.Rotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("Fest", typeof(GNB.Rotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("Gnash", typeof(GNB.Rotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("Zone", typeof(GNB.Rotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("BowS", typeof(GNB.Rotation.Strategy.OffensiveAbilityUse)));
//        c.StrategyTracks.Add(new("RD", typeof(GNB.Rotation.Strategy.RoughDivideUse)));
//        c.StrategyTracks.Add(new("Special", typeof(GNB.Rotation.Strategy.SpecialAction)));
//        return c;
//    }
//}