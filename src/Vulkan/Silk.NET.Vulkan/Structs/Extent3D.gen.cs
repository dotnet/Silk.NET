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
    public unsafe struct Extent3D
    {
        public Extent3D
        (
            uint width = default,
            uint height = default,
            uint depth = default
        )
        {
           Width = width;
           Height = height;
           Depth = depth;
        }

/// <summary></summary>
        public uint Width;
/// <summary></summary>
        public uint Height;
/// <summary></summary>
        public uint Depth;
    }
}
