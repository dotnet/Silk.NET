// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3D_OMAC")]
    public unsafe partial struct D3DOMac
    {
        [NativeName("Type", "BYTE [16]")]
        [NativeName("Type.Name", "BYTE [16]")]
        [NativeName("Name", "Omac")]
        public fixed byte Omac[16];
    }
}
