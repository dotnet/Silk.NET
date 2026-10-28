// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDisplayModeStereoPropertiesNV")]
public unsafe partial struct DisplayModeStereoPropertiesNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DisplayModeStereoPropertiesNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("hdmi3DSupported")]
    public MaybeBool<uint> Hdmi3DSupported;

    public DisplayModeStereoPropertiesNV() { }
}
