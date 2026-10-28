// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkComponentTypeKHR")]
public enum ComponentTypeKHR : uint
{
    [NativeName("VK_COMPONENT_TYPE_FLOAT16_KHR")]
    Float16 = 0,

    [NativeName("VK_COMPONENT_TYPE_FLOAT32_KHR")]
    Float32 = 1,

    [NativeName("VK_COMPONENT_TYPE_FLOAT64_KHR")]
    Float64 = 2,

    [NativeName("VK_COMPONENT_TYPE_SINT8_KHR")]
    Sint8 = 3,

    [NativeName("VK_COMPONENT_TYPE_SINT16_KHR")]
    Sint16 = 4,

    [NativeName("VK_COMPONENT_TYPE_SINT32_KHR")]
    Sint32 = 5,

    [NativeName("VK_COMPONENT_TYPE_SINT64_KHR")]
    Sint64 = 6,

    [NativeName("VK_COMPONENT_TYPE_UINT8_KHR")]
    Uint8 = 7,

    [NativeName("VK_COMPONENT_TYPE_UINT16_KHR")]
    Uint16 = 8,

    [NativeName("VK_COMPONENT_TYPE_UINT32_KHR")]
    Uint32 = 9,

    [NativeName("VK_COMPONENT_TYPE_UINT64_KHR")]
    Uint64 = 10,

    [NativeName("VK_COMPONENT_TYPE_BFLOAT16_KHR")]
    Bfloat16 = 1000141000,

    [NativeName("VK_COMPONENT_TYPE_SINT8_PACKED_NV")]
    Sint8PackedNV = 1000491000,

    [NativeName("VK_COMPONENT_TYPE_UINT8_PACKED_NV")]
    Uint8PackedNV = 1000491001,

    [NativeName("VK_COMPONENT_TYPE_FLOAT8_E4M3_EXT")]
    Float8E4M3EXT = 1000491002,

    [NativeName("VK_COMPONENT_TYPE_FLOAT8_E5M2_EXT")]
    Float8E5M2EXT = 1000491003,

    [NativeName("VK_COMPONENT_TYPE_FLOAT16_NV")]
    Float16NV = Float16,

    [NativeName("VK_COMPONENT_TYPE_FLOAT32_NV")]
    Float32NV = Float32,

    [NativeName("VK_COMPONENT_TYPE_FLOAT64_NV")]
    Float64NV = Float64,

    [NativeName("VK_COMPONENT_TYPE_SINT8_NV")]
    Sint8NV = Sint8,

    [NativeName("VK_COMPONENT_TYPE_SINT16_NV")]
    Sint16NV = Sint16,

    [NativeName("VK_COMPONENT_TYPE_SINT32_NV")]
    Sint32NV = Sint32,

    [NativeName("VK_COMPONENT_TYPE_SINT64_NV")]
    Sint64NV = Sint64,

    [NativeName("VK_COMPONENT_TYPE_UINT8_NV")]
    Uint8NV = Uint8,

    [NativeName("VK_COMPONENT_TYPE_UINT16_NV")]
    Uint16NV = Uint16,

    [NativeName("VK_COMPONENT_TYPE_UINT32_NV")]
    Uint32NV = Uint32,

    [NativeName("VK_COMPONENT_TYPE_UINT64_NV")]
    Uint64NV = Uint64,

    [NativeName("VK_COMPONENT_TYPE_FLOAT_E4M3_NV")]
    FloatE4M3NV = Float8E4M3EXT,

    [NativeName("VK_COMPONENT_TYPE_FLOAT_E5M2_NV")]
    FloatE5M2NV = Float8E5M2EXT,
}
