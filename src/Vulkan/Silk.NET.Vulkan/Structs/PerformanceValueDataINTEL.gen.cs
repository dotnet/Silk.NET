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
    [NativeName("Name", "VkPerformanceValueDataINTEL")]
    public unsafe partial struct PerformanceValueDataINTEL
    {
        public PerformanceValueDataINTEL
        (
            uint? value32 = null,
            ulong? value64 = null,
            float? valueFloat = null,
            Bool32? valueBool = null,
            byte* valueString = null
        ) : this()
        {
            if (value32 is not null)
            {
                Value32 = value32.Value;
            }

            if (value64 is not null)
            {
                Value64 = value64.Value;
            }

            if (valueFloat is not null)
            {
                ValueFloat = valueFloat.Value;
            }

            if (valueBool is not null)
            {
                ValueBool = valueBool.Value;
            }

            if (valueString is not null)
            {
                ValueString = valueString;
            }
        }

/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "value32")]
        public uint Value32;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "value64")]
        public ulong Value64;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "valueFloat")]
        public float ValueFloat;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "valueBool")]
        public Bool32 ValueBool;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "valueString")]
        public byte* ValueString;
    }
}
