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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_DISPLAY_COLOR_SPACE")]
    public unsafe partial struct DisplayColorSpace
    {
        [NativeName("Type", "FLOAT [8][2]")]
        [NativeName("Type.Name", "FLOAT [8][2]")]
        [NativeName("Name", "PrimaryCoordinates")]
        public fixed float PrimaryCoordinates[16];
        [NativeName("Type", "FLOAT [16][2]")]
        [NativeName("Type.Name", "FLOAT [16][2]")]
        [NativeName("Name", "WhitePoints")]
        public fixed float WhitePoints[32];
    }
}
