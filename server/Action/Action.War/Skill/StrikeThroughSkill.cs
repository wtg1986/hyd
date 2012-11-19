﻿using Action.Model;
using Action.War;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Action.Skill
{
    public class StrikeThroughSkill 
    {
        public  int Id
        {
            get { return 111; }
        }

        public  IEnumerable<Vector2> Range
        {
            get
            {
                yield return new Vector2 { X = 1, Y = 0 };
                yield return new Vector2 { X = 2, Y = 0 };
                yield return new Vector2 { X = 3, Y = 0 };
                yield return new Vector2 { X = 4, Y = 0 };
                yield return new Vector2 { X = 5, Y = 0 };
            }
        }

        public  int TargetCount
        {
            get { return 5; }
        }

        public  IEnumerable<BattleEffect> Casting(CombatTacticUnit unit)
        {
            // 根据攻击范围，找攻击目标
            var targets = Range
                .Select(loc => unit.Military.Enemy.GetAliveUnitByPos(unit.Position + loc * unit.Military.Forward))
                .Where(u => u != null)
                .Take(TargetCount);

            //foreach (var target in targets)
            //{
            //    // 计算格挡，暴击
            //    var damageType = Helper.Test(unit.CriticalChance, target.BlockChance, 0);
            //    yield return unit.DoAttack(target, AttackType.Tactic, damageType, DamageRatio);
            //}

            yield return new BattleEffect { UnitSID = unit.BattleID, PlusMP = -unit.Charge };
            unit.Charge = 0;

            var effects =  targets.SelectMany(target =>
            {
                // 计算格挡，暴击
                var damageType = Helper.Test(unit.CriticalChance, target.BlockChance, 0);
                return unit.DoAttack(target, AttackType.Tactic, damageType, DamageRatio);
            });
            foreach (var e in effects)
                yield return e;
        }

        public  float DamageRatio
        {
            get { return 0.8f; }
        }
    }
}