// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DRECT")]
    public unsafe partial struct Rect
    {
        public Rect
        (
            int? x1 = null,
            int? y1 = null,
            int? x2 = null,
            int? y2 = null
        ) : this()
        {
            if (x1 is not null)
            {
                X1 = x1.Value;
            }

            if (y1 is not null)
            {
                Y1 = y1.Value;
            }

            if (x2 is not null)
            {
                X2 = x2.Value;
            }

            if (y2 is not null)
            {
                Y2 = y2.Value;
            }
        }


        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "x1")]
        public int X1;

        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "y1")]
        public int Y1;

        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "x2")]
        public int X2;

        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "y2")]
        public int Y2;
    }
}
