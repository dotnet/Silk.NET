// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageCompressionPropertiesEXT")]
public unsafe partial struct ImageCompressionPropertiesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.ImageCompressionPropertiesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("imageCompressionFlags")]
    public ImageCompressionFlagsEXT ImageCompressionFlags;

    [NativeName("imageCompressionFixedRateFlags")]
    public ImageCompressionFixedRateFlagsEXT ImageCompressionFixedRateFlags;

    public ImageCompressionPropertiesEXT() { }
}
