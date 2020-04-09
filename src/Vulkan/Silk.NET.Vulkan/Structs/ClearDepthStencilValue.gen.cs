// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct ClearDepthStencilValue
    {
        public ClearDepthStencilValue
        (
            float depth = default,
            uint stencil = default
        )
        {
           Depth = depth;
           Stencil = stencil;
        }

/// <summary></summary>
        public float Depth;
/// <summary></summary>
        public uint Stencil;
    }
}
