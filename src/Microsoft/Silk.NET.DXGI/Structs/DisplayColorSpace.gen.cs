// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
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
        [NativeName("Type", "FLOAT[8][2]")]
        [NativeName("Type.Name", "FLOAT[8][2]")]
        [NativeName("Name", "PrimaryCoordinates")]
        public fixed float PrimaryCoordinates[16];
        [NativeName("Type", "FLOAT[16][2]")]
        [NativeName("Type.Name", "FLOAT[16][2]")]
        [NativeName("Name", "WhitePoints")]
        public fixed float WhitePoints[32];
    }
}
