﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Client_PC.UI
{
    interface IClickable
    {
        void OnClick();
        Rectangle GetBoundary();
        int Id { get; set; }
        bool Active { get; set; }
        bool ActiveChangeable { get; set; }
        Object Parent { get; set; }
        Tooltip Tooltip { get; set; }
        bool IsOver { get; set; }
    }
}
