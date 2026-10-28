// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkQueueFamilyDataGraphTOSAPropertiesARM")]
public unsafe partial struct QueueFamilyDataGraphTosaPropertiesARM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.QueueFamilyDataGraphTosaPropertiesARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("profileCount")]
    public uint ProfileCount;

    [NativeName("pProfiles")]
    public DataGraphTosaNameQualityARM* PProfiles;

    [NativeName("extensionCount")]
    public uint ExtensionCount;

    [NativeName("pExtensions")]
    public DataGraphTosaNameQualityARM* PExtensions;

    [NativeName("level")]
    public DataGraphTosaLevelARM Level;

    public QueueFamilyDataGraphTosaPropertiesARM() { }
}
