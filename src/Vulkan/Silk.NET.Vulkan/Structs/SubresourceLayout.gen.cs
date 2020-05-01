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
    public unsafe struct SubresourceLayout
    {
        public SubresourceLayout
        (
            ulong offset = default,
            ulong size = default,
            ulong rowPitch = default,
            ulong arrayPitch = default,
            ulong depthPitch = default
        )
        {
           Offset = offset;
           Size = size;
           RowPitch = rowPitch;
           ArrayPitch = arrayPitch;
           DepthPitch = depthPitch;
        }

/// <summary></summary>
        public ulong Offset;
/// <summary></summary>
        public ulong Size;
/// <summary></summary>
        public ulong RowPitch;
/// <summary></summary>
        public ulong ArrayPitch;
/// <summary></summary>
        public ulong DepthPitch;
    }
}
