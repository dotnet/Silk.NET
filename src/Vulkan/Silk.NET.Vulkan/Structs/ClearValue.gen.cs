// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct ClearValue
    {
        public ClearValue
        (
            ClearColorValue color = default,
            ClearDepthStencilValue depthStencil = default
        )
        {
           Color = color;
           DepthStencil = depthStencil;
        }

/// <summary></summary>
        [FieldOffset(0)]
        public ClearColorValue Color;
/// <summary></summary>
        [FieldOffset(0)]
        public ClearDepthStencilValue DepthStencil;
    }
}
