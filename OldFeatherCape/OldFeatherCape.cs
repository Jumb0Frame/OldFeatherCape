using BepInEx;
using Jotunn.Configs;
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
        public const string PluginGUID = "com.jumb0frame.OldFeatherCape";
        public const string PluginName = "OldFeatherCape";
        public const string PluginVersion = "1.0.2";

        private static StatusEffectsConfig capeSetEffects;
        private static ArmorConfig capeArmorConfig;
        private static RecipeConfig capeRecipeConfig;

        private void Awake()
        {
            // Jotunn comes with its own Logger class to provide a consistent Log style for all mods using it
            Jotunn.Logger.LogInfo("OldFeatherCape has landed");

            //capeSetEffects = new StatusEffectsConfig("Old Feather Cape Set effects", "Jig bump", "I'm feelin' springy");
            capeSetEffects = new StatusEffectsConfig("Old Feather Cape Set effects", "Jig Bump", "Just let me jump all the way to the top of Yggdrasil; and fly back down safely!");
            capeSetEffects.SEStaminaConfig(0f, 0f, 0f, 0f, -0.2f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);

            PrefabManager.OnVanillaPrefabsAvailable += AddOldFeatherCape;

        }

        private void AddOldFeatherCape()
        {
            SE_Stats setEffects = capeSetEffects.getSetEffects();


            setEffects.m_maxMaxFallSpeed = 5f;
            setEffects.m_fallDamageModifier = -1f;

            //+20% jump height
            setEffects.m_jumpModifier = new UnityEngine.Vector3(0f, 0.2f, 0f);

            capeRecipeConfig = new RecipeConfig("Old Feather Cape Config", "Old Feather Cape description config", "piece_magetable", "piece_magetable", 1, new RequirementConfig("Feathers", 10, 2),
                                                new RequirementConfig("ScaleHide", 5, 5), new RequirementConfig("Eitr", 20, 3));
            //capeArmorConfig = new ArmorConfig("Old Feather Cape", "The feather cape, but when it used to be great!", 4, 4f, null, "Feather Cape Set", 1, setEffects, 0f, 1, 1, 1200f, 50f, 0f);
            capeArmorConfig = new ArmorConfig("Old Feather Cape", "The feather cape, but when it used to be great!", 4, 4f, setEffects, null, 0, null, 0f, 1, 1, 1200f, 50f, 0f);
            CustomItem oldFeatherCape = new CustomItem("OldCapeFeather", "CapeFeather", capeRecipeConfig.GetRecipeConfig());
            ItemManager.Instance.AddItem(oldFeatherCape);
            capeArmorConfig.ApplyConfig(oldFeatherCape.ItemDrop);
            
            Jotunn.Logger.LogInfo(oldFeatherCape.ItemDrop.m_itemData.m_shared.m_setStatusEffect.GetTooltipString());

            PrefabManager.OnVanillaPrefabsAvailable -= AddOldFeatherCape;
        }
    }
}

