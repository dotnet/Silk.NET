// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "VkPerformanceCounterResultKHR")]
    public unsafe partial struct PerformanceCounterResultKHR
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
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "int32")]
        public int Int32;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "int64_t")]
        [NativeName("Type.Name", "int64_t")]
        [NativeName("Name", "int64")]
        public long Int64;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "uint32")]
        public uint Uint32;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "uint64")]
        public ulong Uint64;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "float32")]
        public float Float32;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "float64")]
        public double Float64;
    }
}
