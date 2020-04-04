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
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct PerformanceValueDataINTEL
    {
        public PerformanceValueDataINTEL
        (
            uint value32 = default,
            ulong value64 = default,
            float valueFloat = default,
            Bool32 valueBool = default,
            byte* valueString = default
        )
        {
           Value32 = value32;
           Value64 = value64;
           ValueFloat = valueFloat;
           ValueBool = valueBool;
           ValueString = valueString;
        }

/// <summary></summary>
        [FieldOffset(0)]
        public uint Value32;
/// <summary></summary>
        [FieldOffset(0)]
        public ulong Value64;
/// <summary></summary>
        [FieldOffset(0)]
        public float ValueFloat;
/// <summary></summary>
        [FieldOffset(0)]
        public Bool32 ValueBool;
/// <summary></summary>
        [FieldOffset(0)]
        public byte* ValueString;
    }
}
