// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d11shadertracing_L226_C5")]
    public unsafe partial struct AnonymousRecordD3d11shadertracingL226C5
    {
        public AnonymousRecordD3d11shadertracingL226C5
        (
            ushort? index1D = null
        ) : this()
        {
            if (index1D is not null)
            {
                Index1D = index1D.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "Index1D")]
        public ushort Index1D;
        [FieldOffset(0)]
        [NativeName("Type", "UINT16 [2]")]
        [NativeName("Type.Name", "UINT16 [2]")]
        [NativeName("Name", "Index2D")]
        public fixed ushort Index2D[2];
    }
}
