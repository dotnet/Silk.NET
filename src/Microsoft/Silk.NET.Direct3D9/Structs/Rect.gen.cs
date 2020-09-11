// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
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
            int x1 = default,
            int y1 = default,
            int x2 = default,
            int y2 = default
        )
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
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
