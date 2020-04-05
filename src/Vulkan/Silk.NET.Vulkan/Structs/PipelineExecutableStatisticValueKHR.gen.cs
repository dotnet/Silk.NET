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
    public unsafe struct PipelineExecutableStatisticValueKHR
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
        public Bool32 B32;
/// <summary></summary>
        [FieldOffset(0)]
        public long I64;
/// <summary></summary>
        [FieldOffset(0)]
        public ulong U64;
/// <summary></summary>
        [FieldOffset(0)]
        public double F64;
    }
}
