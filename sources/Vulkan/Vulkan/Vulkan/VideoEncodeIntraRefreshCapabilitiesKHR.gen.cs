// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoEncodeIntraRefreshCapabilitiesKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkVideoEncodeIntraRefreshModeFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeIntraRefreshModeFlagsKHR IntraRefreshModes;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxIntraRefreshCycleDuration;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxIntraRefreshActiveReferencePictures;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public uint PartitionIndependentIntraRefreshRegions;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public uint NonRectangularIntraRefreshRegions;
}
