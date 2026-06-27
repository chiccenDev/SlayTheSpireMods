using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Modding;

namespace ggGoNext.ggGoNextCode
{
    //You're recommended but not required to keep all your code in this package and all your assets in the ggGoNext folder.
    [ModInitializer(nameof(Initialize))]
    public partial class MainFile : Node
    {
        public const string ModId = "ggGoNext"; //At the moment, this is used only for the Logger and harmony names.

        public static MegaCrit.Sts2.Core.Logging.Logger Logger { get; } = new(ModId, MegaCrit.Sts2.Core.Logging.LogType.Generic);

        public static void Initialize()
        {
            //If you want to use scripts defined in your mod for Godot scenes, uncomment the following line.
            //Godot.Bridge.ScriptManagerBridge.LookupScriptsInAssembly(Assembly.GetExecutingAssembly());

            Harmony harmony = new(ModId);

            harmony.PatchAll();
        }
    }
}

/*
 * 
 * GAMEPLAN:
 * 
 * Either make it so FastMode affects the gameover transition
 * Or manually make it so abandon run button instantly takes you to home screen
 * and resets your save.
 * See RunManager.OnEnded (lines 1554 thru 1568, in particular)
 *
 */