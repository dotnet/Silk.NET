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
    public unsafe struct SpecializationMapEntry
    {
        public SpecializationMapEntry
        (
            uint constantID = default,
            uint offset = default,
            UIntPtr size = default
        )
        {
           ConstantID = constantID;
           Offset = offset;
           Size = size;
        }

/// <summary></summary>
        public uint ConstantID;
/// <summary></summary>
        public uint Offset;
/// <summary></summary>
        public UIntPtr Size;
    }
}
