﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUI
{
    public class VisualObject : Touchable<VisualObject>
    {
        VisualObject(int x, int y, int width, int height)
            : base(x, y, width, height)
        {

        }
    }
}
