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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPerformanceMetricsCounterMETA")]
    public unsafe partial struct PerformanceMetricsCounterMETA
    {
        public PerformanceMetricsCounterMETA
        (
            StructureType? type = StructureType.TypePerformanceMetricsCounterMeta,
            void* next = null,
            PerformanceMetricsCounterFlagsMETA? counterFlags = null,
            PerformanceMetricsCounterUnitMETA? counterUnit = null,
            uint? uintValue = null,
            float? floatValue = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (counterFlags is not null)
            {
                CounterFlags = counterFlags.Value;
            }

            if (counterUnit is not null)
            {
                CounterUnit = counterUnit.Value;
            }

            if (uintValue is not null)
            {
                UintValue = uintValue.Value;
            }

            if (floatValue is not null)
            {
                FloatValue = floatValue.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrPerformanceMetricsCounterFlagsMETA")]
        [NativeName("Type.Name", "XrPerformanceMetricsCounterFlagsMETA")]
        [NativeName("Name", "counterFlags")]
        public PerformanceMetricsCounterFlagsMETA CounterFlags;
/// <summary></summary>
        [NativeName("Type", "XrPerformanceMetricsCounterUnitMETA")]
        [NativeName("Type.Name", "XrPerformanceMetricsCounterUnitMETA")]
        [NativeName("Name", "counterUnit")]
        public PerformanceMetricsCounterUnitMETA CounterUnit;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "uintValue")]
        public uint UintValue;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "floatValue")]
        public float FloatValue;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
