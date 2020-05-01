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
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct PerformanceCounterResultKHR
    {
        public PerformanceCounterResultKHR
        (
            int int32 = default,
            long int64 = default,
            uint uint32 = default,
            ulong uint64 = default,
            float float32 = default,
            double float64 = default
        )
        {
           Int32 = int32;
           Int64 = int64;
           Uint32 = uint32;
           Uint64 = uint64;
           Float32 = float32;
           Float64 = float64;
        }

/// <summary></summary>
        [FieldOffset(0)]
        public int Int32;
/// <summary></summary>
        [FieldOffset(0)]
        public long Int64;
/// <summary></summary>
        [FieldOffset(0)]
        public uint Uint32;
/// <summary></summary>
        [FieldOffset(0)]
        public ulong Uint64;
/// <summary></summary>
        [FieldOffset(0)]
        public float Float32;
/// <summary></summary>
        [FieldOffset(0)]
        public double Float64;
    }
}
