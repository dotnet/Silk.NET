// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceImageProcessing2PropertiesQCOM")]
public unsafe partial struct PhysicalDeviceImageProcessing2PropertiesQCOM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceImageProcessing2PropertiesQCOM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxBlockMatchWindow")]
    public Extent2D MaxBlockMatchWindow;

    public PhysicalDeviceImageProcessing2PropertiesQCOM() { }
}
