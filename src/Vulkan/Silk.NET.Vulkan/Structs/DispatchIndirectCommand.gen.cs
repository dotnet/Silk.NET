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
    public unsafe struct DispatchIndirectCommand
    {
        public DispatchIndirectCommand
        (
            uint x = default,
            uint y = default,
            uint z = default
        )
        {
           X = x;
           Y = y;
           Z = z;
        }

/// <summary></summary>
        public uint X;
/// <summary></summary>
        public uint Y;
/// <summary></summary>
        public uint Z;
    }
}
