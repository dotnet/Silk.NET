// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceOpticalFlowPropertiesNV")]
public unsafe partial struct PhysicalDeviceOpticalFlowPropertiesNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceOpticalFlowPropertiesNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("supportedOutputGridSizes")]
    public OpticalFlowGridSizeFlagsNV SupportedOutputGridSizes;

    [NativeName("supportedHintGridSizes")]
    public OpticalFlowGridSizeFlagsNV SupportedHintGridSizes;

    [NativeName("hintSupported")]
    public MaybeBool<uint> HintSupported;

    [NativeName("costSupported")]
    public MaybeBool<uint> CostSupported;

    [NativeName("bidirectionalFlowSupported")]
    public MaybeBool<uint> BidirectionalFlowSupported;

    [NativeName("globalFlowSupported")]
    public MaybeBool<uint> GlobalFlowSupported;

    [NativeName("minWidth")]
    public uint MinWidth;

    [NativeName("minHeight")]
    public uint MinHeight;

    [NativeName("maxWidth")]
    public uint MaxWidth;

    [NativeName("maxHeight")]
    public uint MaxHeight;

    [NativeName("maxNumRegionsOfInterest")]
    public uint MaxNumRegionsOfInterest;

    public PhysicalDeviceOpticalFlowPropertiesNV() { }
}
