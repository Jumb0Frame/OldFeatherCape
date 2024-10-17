using Jotunn.Configs;

namespace ModifiedAskSet
{
    internal class OldFeatherCape
    {
        private string name;
        private string description;
        private string craftStation;
        private string repairStation;
        private int stationLvl;
        private RequirementConfig requirementConfig1 = null;
        private RequirementConfig requirementConfig2 = null;
        private RequirementConfig requirementConfig3 = null;
        private RequirementConfig requirementConfig4 = null;

        public RecipeConfig(string _name, string _desc, string _craft, string _repair, int _stationLvl, RequirementConfig _req1)
        {
            name = _name;
            description = _desc;
            craftStation = _craft;
            repairStation = _repair;
            stationLvl = _stationLvl;

            requirementConfig1 = _req1;
        }

        public RecipeConfig(string _name, string _desc, string _craft, string _repair, int _stationLvl, RequirementConfig _req1, RequirementConfig _req2)
        {
            name = _name;
            description = _desc;
            craftStation = _craft;
            repairStation = _repair;
            stationLvl = _stationLvl;

            requirementConfig1 = _req1;
            requirementConfig2 = _req2;
        }

        public RecipeConfig(string _name, string _desc, string _craft, string _repair, int _stationLvl, RequirementConfig _req1, RequirementConfig _req2, RequirementConfig _req3)
        {
            name = _name;
            description = _desc;
            craftStation = _craft;
            repairStation = _repair;
            stationLvl = _stationLvl;

            requirementConfig1 = _req1;
            requirementConfig2 = _req2;
            requirementConfig3 = _req3;
        }

        public RecipeConfig(string _name, string _desc, string _craft, string _repair, int _stationLvl, RequirementConfig _req1, RequirementConfig _req2, RequirementConfig _req3, RequirementConfig _req4) 
        { 
            name = _name;
            description = _desc;
            craftStation = _craft;
            repairStation = _repair;
            stationLvl = _stationLvl;

            requirementConfig1 = _req1;
            requirementConfig2 = _req2;
            requirementConfig3 = _req3;
            requirementConfig4 = _req4;
        }



        public ItemConfig GetRecipeConfig()
        {
            ItemConfig config = new ItemConfig();
            config.Name = name;
            config.Description = description;
            config.CraftingStation = craftStation;
            config.RepairStation = repairStation;
            config.MinStationLevel = stationLvl;
            config.AddRequirement(requirementConfig1);
            if (requirementConfig2 != null) config.AddRequirement(requirementConfig2);
            if (requirementConfig3 != null) config.AddRequirement(requirementConfig3);
            if (requirementConfig4 != null) config.AddRequirement(requirementConfig4);
            return config;
        }
    }
}
