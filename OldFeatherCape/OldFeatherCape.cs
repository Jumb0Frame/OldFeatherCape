using BepInEx;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;

namespace OldFeatherCape
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Minor)]
    internal class OldFeatherCape : BaseUnityPlugin
    {
        public const string PluginGUID = "com.jotunn.OldFeatherCape";
        public const string PluginName = "OldFeatherCape";
        public const string PluginVersion = "1.0.0";

        private void Awake()
        {
            // Jotunn comes with its own Logger class to provide a consistent Log style for all mods using it
            Jotunn.Logger.LogInfo("OldFeatherCape has landed");
            
            // To learn more about Jotunn's features, go to
            // https://valheim-modding.github.io/Jotunn/tutorials/overview.html
        }
    }
}

