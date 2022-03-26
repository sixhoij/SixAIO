﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SixAIO.Enums
{
    internal enum DashMode
    {
        ToMouse
    }

    internal static class DashHelper
    {
        internal static List<string> ConstructDashModeTable()
        {
            var keyTable = Enum.GetNames(typeof(DashMode)).ToList();
            return keyTable;
        }
    }
}
