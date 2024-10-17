using UnityEngine;

namespace OldFeatherCape
{
    internal class StatusEffectsConfig
    {
        private string unityEffectsName;
        private string name;
        private string tooltip;

        //raise skills
        private Skills.SkillType raiseSkill;
        private float raiseSkillModifier = 0f;

        //attack
        private HitData.DamageTypes percentDamageModifier;

        //stamina
        private float staminaOverTime = 0f;
        private float staminaOverTimeDuration = 0f;
        private float staminaDrainPerSec = 0f;
        private float runStaminaDrainModifier = 0f;
        private float jumpStaminaUseModifier = 0f;
        private float attackStaminaUseModifier = 0f;
        private float blockStaminaUseModifier = 0f;
        private float dodgeStaminaUseModifier = 0f;
        private float swimStaminaUseModifier = 0f;
        private float homeItemStaminaUseModifier = 0f;
        private float sneakStaminaUseModifier = 0f;
        private float runStaminaUseModifier = 0f;

        //regen
        private float healthRegenMultiplier = 1f;
        private float staminaRegenMultiplier = 1f;
        private float eitrRegenMultiplier = 1f;

        public StatusEffectsConfig(string _unityEffectsName, string _name, string _tooltip) 
        {
            unityEffectsName = _unityEffectsName;
            name = _name;
            tooltip = _tooltip;
        }

        //Raise the level of a skill
        public void SESkillConfig(Skills.SkillType _raiseSkill, float _raiseSkillModifier)
        {
            raiseSkill = _raiseSkill;
            raiseSkillModifier = _raiseSkillModifier;
        }

        //Modify attack power
        public void SEAttackConfig(float _bluntModifier = 0f, float _slashModifier = 0f, float _pierceModifier = 0f, float _chopModifier = 0f, float _pickaxeModifier = 0f,
                                    float _fireModifier = 0f, float _frostModifier = 0f, float _lightningModifier = 0f, float _poisonModifier = 0f, float _spiritModifier = 0f)
        {
            if (_bluntModifier != 0f) { percentDamageModifier.m_blunt = _bluntModifier; }
            if (_slashModifier != 0f) { percentDamageModifier.m_slash = _slashModifier; }
            if (_pierceModifier != 0f) { percentDamageModifier.m_pierce = _pierceModifier; }
            if (_chopModifier != 0f) { percentDamageModifier.m_chop = _chopModifier; }
            if (_pickaxeModifier != 0f) { percentDamageModifier.m_pickaxe = _pickaxeModifier; }
            if (_fireModifier != 0f) { percentDamageModifier.m_fire = _fireModifier; }
            if (_frostModifier != 0f) { percentDamageModifier.m_frost = _frostModifier; }
            if (_lightningModifier != 0f) { percentDamageModifier.m_lightning = _lightningModifier; }
            if (_poisonModifier != 0f) { percentDamageModifier.m_poison = _poisonModifier; }
            if (_spiritModifier != 0f) { percentDamageModifier.m_spirit = _spiritModifier; }
        }

        //Add stamina based modifiers
        public void SEStaminaConfig(float _staminaOverTime, float _staminaOverTimeDuration, float _staminaDrainPerSec, float _runStaminaDrainModifier,
                                    float _jumpStaminaUseModifier, float _attackStaminaUseModifier, float _blockStaminaUseModifier, float _dodgeStaminaUseModifier,
                                    float _swimStaminaUseModifier, float _homeItemStaminaUseModifier, float _sneakStaminaUseModifier, float _runStaminaUseModifier)
        {
            staminaOverTime = _staminaOverTime;
            staminaOverTimeDuration = _staminaOverTimeDuration;
            staminaDrainPerSec = _staminaDrainPerSec;
            runStaminaDrainModifier = _runStaminaDrainModifier;
            jumpStaminaUseModifier = _jumpStaminaUseModifier;
            attackStaminaUseModifier = _attackStaminaUseModifier;
            blockStaminaUseModifier = _blockStaminaUseModifier;
            dodgeStaminaUseModifier = _dodgeStaminaUseModifier;
            swimStaminaUseModifier = _swimStaminaUseModifier;
            homeItemStaminaUseModifier = _homeItemStaminaUseModifier;
            sneakStaminaUseModifier = _sneakStaminaUseModifier;
            runStaminaUseModifier = _runStaminaUseModifier;
        }

        //Modify the base regen rate for health, stamina and eitr
        public void SERegenConfig(float _healthRegenMultiplier, float _staminaRegenMultiplier, float _eitrRegenMultiplier)
        {
            healthRegenMultiplier += _healthRegenMultiplier;
            staminaRegenMultiplier += _staminaRegenMultiplier;
            eitrRegenMultiplier += _eitrRegenMultiplier;
        }

        public SE_Stats getSetEffects()
        {
            SE_Stats setEffects = ScriptableObject.CreateInstance<SE_Stats>();
            ((UnityEngine.Object)setEffects).name = unityEffectsName;
            setEffects.m_name = name;
            setEffects.m_tooltip = tooltip;
            //raise skill
            if (raiseSkillModifier != 0f)
            {
                setEffects.m_raiseSkill = raiseSkill;
                setEffects.m_raiseSkillModifier = raiseSkillModifier;
            }
            //attack
            setEffects.m_percentigeDamageModifiers = percentDamageModifier;
            //stamina
            if (staminaOverTime != 0f) { setEffects.m_staminaOverTime = staminaOverTime; }
            if (staminaOverTimeDuration != 0f) { setEffects.m_staminaOverTimeDuration = staminaOverTimeDuration; }
            if (staminaDrainPerSec != 0f) { setEffects.m_staminaDrainPerSec = staminaDrainPerSec; }
            if (runStaminaDrainModifier != 0f) { setEffects.m_runStaminaDrainModifier = runStaminaDrainModifier; }
            if (jumpStaminaUseModifier != 0f) { setEffects.m_jumpStaminaUseModifier = jumpStaminaUseModifier; }
            if (attackStaminaUseModifier != 0f) { setEffects.m_attackStaminaUseModifier = attackStaminaUseModifier; }
            if (blockStaminaUseModifier != 0f) { setEffects.m_blockStaminaUseModifier = blockStaminaUseModifier; }
            if (dodgeStaminaUseModifier != 0f) { setEffects.m_dodgeStaminaUseModifier = dodgeStaminaUseModifier; }
            if (swimStaminaUseModifier != 0f) { setEffects.m_swimStaminaUseModifier = swimStaminaUseModifier; }
            if (homeItemStaminaUseModifier != 0f) { setEffects.m_homeItemStaminaUseModifier = homeItemStaminaUseModifier; }
            if (sneakStaminaUseModifier != 0f) { setEffects.m_sneakStaminaUseModifier = sneakStaminaUseModifier; }
            if (runStaminaUseModifier != 0f) { setEffects.m_runStaminaUseModifier = runStaminaUseModifier; }
            //regen
            if (healthRegenMultiplier != 1f) { setEffects.m_healthRegenMultiplier = healthRegenMultiplier; }
            if (staminaRegenMultiplier != 1f) { setEffects.m_staminaRegenMultiplier = staminaRegenMultiplier; }
            if (eitrRegenMultiplier != 1f) { setEffects.m_eitrRegenMultiplier = eitrRegenMultiplier; }
            return setEffects;
        }
    }
}
