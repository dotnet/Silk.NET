// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
    [NativeName("Name", "VkPipelineExecutableStatisticValueKHR")]
    public unsafe partial struct PipelineExecutableStatisticValueKHR
    {
        public PipelineExecutableStatisticValueKHR
        (
            Bool32? b32 = null,
            long? i64 = null,
            ulong? u64 = null,
            double? f64 = null
        ) : this()
        {
            if (b32 is not null)
            {
                B32 = b32.Value;
            }

            if (i64 is not null)
            {
                I64 = i64.Value;
            }

            if (u64 is not null)
            {
                U64 = u64.Value;
            }

            if (f64 is not null)
            {
                F64 = f64.Value;
            }
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
