﻿using Action.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Action.War
{
    /// <summary>
    /// 策略型武将
    /// </summary>
    public class CombatStrategyUnit : CombatUnit
    {
        /// <summary>
        /// 技能施放概率
        /// </summary>
        public float SkillChance { get; set; }

        public CombatStrategyUnit(CombatMilitary military) : base(military) { }

        public override BattleAction SkillStrike()
        {
            // 可以释放技能
            var rng = new Random();
            if (rng.NextDouble() > SkillChance)
                return null;

            var effects = _skill.Cast(this);
            if (effects == null)
                return null;

            var ba = new BattleAction();
            ba.UnitSID = this.BattleID;
            ba.Type = BattleActionType.Cast; // 攻击
            ba.Param = SkillID; // 策略攻击
            ba.Effects.AddRange(effects);
            return ba;
        }
    }
}
