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
    public unsafe struct Viewport
    {
        public Viewport
        (
            float x = default,
            float y = default,
            float width = default,
            float height = default,
            float minDepth = default,
            float maxDepth = default
        )
        {
           X = x;
           Y = y;
           Width = width;
           Height = height;
           MinDepth = minDepth;
           MaxDepth = maxDepth;
        }

/// <summary></summary>
        public float X;
/// <summary></summary>
        public float Y;
/// <summary></summary>
        public float Width;
/// <summary></summary>
        public float Height;
/// <summary></summary>
        public float MinDepth;
/// <summary></summary>
        public float MaxDepth;
    }
}
