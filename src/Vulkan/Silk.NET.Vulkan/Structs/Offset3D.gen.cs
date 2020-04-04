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
    public unsafe struct Offset3D
    {
        public Offset3D
        (
            int x = default,
            int y = default,
            int z = default
        )
        {
           X = x;
           Y = y;
           Z = z;
        }

/// <summary></summary>
        public int X;
/// <summary></summary>
        public int Y;
/// <summary></summary>
        public int Z;
    }
}
