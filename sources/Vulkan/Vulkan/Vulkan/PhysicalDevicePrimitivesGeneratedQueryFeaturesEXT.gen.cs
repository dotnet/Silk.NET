// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("EXT", 0)]
[NativeName("VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDevicePrimitivesGeneratedQueryFeaturesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_primitives_generated_query"],
        ImpliesSets = ["VK_EXT_transform_feedback"]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_primitives_generated_query"],
        ImpliesSets = ["VK_EXT_transform_feedback"]
    )]
    public void* PNext;

    [NativeName("primitivesGeneratedQuery")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_primitives_generated_query"],
        ImpliesSets = ["VK_EXT_transform_feedback"]
    )]
    public uint PrimitivesGeneratedQuery;

    [NativeName("primitivesGeneratedQueryWithRasterizerDiscard")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_primitives_generated_query"],
        ImpliesSets = ["VK_EXT_transform_feedback"]
    )]
    public uint PrimitivesGeneratedQueryWithRasterizerDiscard;

    [NativeName("primitivesGeneratedQueryWithNonZeroStreams")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_primitives_generated_query"],
        ImpliesSets = ["VK_EXT_transform_feedback"]
    )]
    public uint PrimitivesGeneratedQueryWithNonZeroStreams;
}
