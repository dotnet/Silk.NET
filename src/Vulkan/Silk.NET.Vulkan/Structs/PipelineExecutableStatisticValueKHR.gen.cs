// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "VkPipelineExecutableStatisticValueKHR")]
    public unsafe partial struct PipelineExecutableStatisticValueKHR
    {
        public PipelineExecutableStatisticValueKHR
        (
            Bool32 b32 = default,
            long i64 = default,
            ulong u64 = default,
            double f64 = default
        )
        {
            B32 = b32;
            I64 = i64;
            U64 = u64;
            F64 = f64;
        }

/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "b32")]
        public Bool32 B32;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "int64_t")]
        [NativeName("Type.Name", "int64_t")]
        [NativeName("Name", "i64")]
        public long I64;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "u64")]
        public ulong U64;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "f64")]
        public double F64;
    }
}
