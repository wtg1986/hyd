﻿using Action.Model;
using Action.War;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Action.Buff
{
    public interface IBuff
    {
        int Id { get; set; }
        BattleEffect Affect(CombatUnit self, CombatUnit target);
    }
}
