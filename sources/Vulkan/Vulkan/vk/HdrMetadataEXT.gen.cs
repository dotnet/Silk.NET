// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkHdrMetadataEXT")]
public unsafe partial struct HdrMetadataEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.HdrMetadataEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("displayPrimaryRed")]
    public XYColorEXT DisplayPrimaryRed;

    [NativeName("displayPrimaryGreen")]
    public XYColorEXT DisplayPrimaryGreen;

    [NativeName("displayPrimaryBlue")]
    public XYColorEXT DisplayPrimaryBlue;

    [NativeName("whitePoint")]
    public XYColorEXT WhitePoint;

    [NativeName("maxLuminance")]
    public float MaxLuminance;

    [NativeName("minLuminance")]
    public float MinLuminance;

    [NativeName("maxContentLightLevel")]
    public float MaxContentLightLevel;

    [NativeName("maxFrameAverageLightLevel")]
    public float MaxFrameAverageLightLevel;

    public HdrMetadataEXT() { }
}
