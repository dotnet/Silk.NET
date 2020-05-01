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
    public unsafe struct Offset2D
    {
        public Offset2D
        (
            int x = default,
            int y = default
        )
        {
           X = x;
           Y = y;
        }

/// <summary></summary>
        public int X;
/// <summary></summary>
        public int Y;
    }
}
