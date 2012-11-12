﻿using Action.Model;
using Action.Skill;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Action.War
{
    /// <summary>
    /// 战法型武将
    /// </summary>
    public class CombatTacticUnit : CombatUnit
    {
        const int MAX_CHARGE = 100;
        const int CHARGE_PLUS = 25;

        //public CombatTacticUnit(CombatMilitary military)
        //    : base(military)
        //{
        //    _skill = new StrikeThroughSkill();
        //}

        public override BattleAction SkillStrike()
        {
            // 可以释放技能
            if (Charge < 100)
                return null;

            var skill = SkillFactory.Instance.GetSkill(this.SkillID);
            var effects = skill.Cast(this);
            if (effects == null)
                return null;

            var ba = new BattleAction();
            ba.UnitSID = this.BattleID;
            ba.Type = BattleActionType.Cast; // 攻击
            ba.Param = SkillID; // 战法攻击
            ba.Effects.AddRange(effects);
            return ba;
        }
        public override BattleEffect Attacking(CombatUnit target, AttackType attackType, BattleEffectType effectType)
        {
            if (effectType != BattleEffectType.Dodge)
                Charge += CHARGE_PLUS;

            return base.Attacking(target, attackType, effectType);
        }

        protected override void Attacked(BattleEffect effect)
        {
            if (effect.Type != BattleEffectType.Dodge)
                Charge += CHARGE_PLUS;

            base.Attacked(effect);
        }
    }
}
