// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
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
            int? int32 = null,
            long? int64 = null,
            uint? uint32 = null,
            ulong? uint64 = null,
            float? float32 = null,
            double? float64 = null
        ) : this()
        {
            if (int32 is not null)
            {
                Int32 = int32.Value;
            }

            if (int64 is not null)
            {
                Int64 = int64.Value;
            }

            if (uint32 is not null)
            {
                Uint32 = uint32.Value;
            }

            if (uint64 is not null)
            {
                Uint64 = uint64.Value;
            }

            if (float32 is not null)
            {
                Float32 = float32.Value;
            }

            if (float64 is not null)
            {
                Float64 = float64.Value;
            }
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
