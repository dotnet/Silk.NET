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

namespace Silk.NET.Direct3D12
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L2582_C5")]
    public unsafe partial struct ClearValueUnion
    {
        public ClearValueUnion
        (
            DepthStencilValue? depthStencil = null
        ) : this()
        {
            if (depthStencil is not null)
            {
                DepthStencil = depthStencil.Value;
            }
        }

        [FieldOffset(0)]
        [NativeName("Type", "FLOAT [4]")]
        [NativeName("Type.Name", "FLOAT [4]")]
        [NativeName("Name", "Color")]
        public fixed float Color[4];

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_DEPTH_STENCIL_VALUE")]
        [NativeName("Type.Name", "D3D12_DEPTH_STENCIL_VALUE")]
        [NativeName("Name", "DepthStencil")]
        public DepthStencilValue DepthStencil;
    }
}
