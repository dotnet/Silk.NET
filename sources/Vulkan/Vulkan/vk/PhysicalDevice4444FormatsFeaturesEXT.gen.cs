// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDevice4444FormatsFeaturesEXT")]
public unsafe partial struct PhysicalDevice4444FormatsFeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDevice4444FormatsFeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("formatA4R4G4B4")]
    public MaybeBool<uint> FormatA4R4G4B4;

    [NativeName("formatA4B4G4R4")]
    public MaybeBool<uint> FormatA4B4G4R4;

    public PhysicalDevice4444FormatsFeaturesEXT() { }
}
