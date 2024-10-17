

namespace OldFeatherCape
{
    internal class ArmorConfig
    {
        private string name;
        private string description;

        private int maxQuality = 0;

        private float weight = 0f;

        private StatusEffect equipStatusEffect = null;

        private string setName = null;
        private int setSize = 0;
        private StatusEffect setStatusEffect = null;

        private float movementModifier = 0f;

        private float armor = 0f;
        private float armorPerLvl = 0f;

        private float maxDurability = 0f;
        private float durabilityPerLvl = 0f;

        private float equipTime = 0f;


        public ArmorConfig(string _name, string _desc, int _maxQual, float _weight, StatusEffect _equipeSE, string _setName, int _setSize, StatusEffect _setSE, float _movementMod, float _armor, float _armorPerLvl, float _maxDura, float _duraPerLvl, float _equipTime) 
        { 
            name = _name;
            description = _desc;
            maxQuality = _maxQual;
            weight = _weight;
            equipStatusEffect = _equipeSE;
            setName = _setName;
            setSize = _setSize;
            setStatusEffect = _setSE;
            movementModifier = _movementMod;
            armor = _armor;
            armorPerLvl = _armorPerLvl;
            maxDurability = _maxDura;
            durabilityPerLvl = _duraPerLvl;
            equipTime = _equipTime;
        }

        public  void ApplyConfig(ItemDrop item)
        {
            item.m_itemData.m_shared.m_name = name;
            item.m_itemData.m_shared.m_description = description;
            if (maxQuality > 0) item.m_itemData.m_shared.m_maxQuality = maxQuality;
            if (weight > 0f) item.m_itemData.m_shared.m_weight = weight;
            if (equipStatusEffect != null) item.m_itemData.m_shared.m_equipStatusEffect = equipStatusEffect;
            if (setName != null) item.m_itemData.m_shared.m_setName = setName;
            if (setSize > 0) item.m_itemData.m_shared.m_setSize = setSize;
            if (setStatusEffect != null) item.m_itemData.m_shared.m_setStatusEffect  = setStatusEffect;
            if (movementModifier != 0f) item.m_itemData.m_shared.m_movementModifier = movementModifier;
            if (armor > 0f) item.m_itemData.m_shared.m_armor = armor;
            if (armorPerLvl > 0f) item.m_itemData.m_shared.m_armorPerLevel = armorPerLvl;
            if (maxDurability > 0f) item.m_itemData.m_shared.m_maxDurability = maxDurability;
            if (durabilityPerLvl > 0f) item.m_itemData.m_shared.m_durabilityPerLevel = durabilityPerLvl;
            if (equipTime != 0f) item.m_itemData.m_shared.m_equipDuration = equipTime;
        }
    }
}
