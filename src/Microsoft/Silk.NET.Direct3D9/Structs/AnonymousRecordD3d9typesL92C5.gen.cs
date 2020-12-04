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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d9types_L92_C5")]
    public unsafe partial struct AnonymousRecordD3d9typesL92C5
    {
        [FieldOffset(0)]
        [NativeName("Type", "float [4][4]")]
        [NativeName("Type.Name", "float [4][4]")]
        [NativeName("Name", "m")]
        public fixed float M[16];
    }
}
