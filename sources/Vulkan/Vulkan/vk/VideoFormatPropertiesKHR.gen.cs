// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoFormatPropertiesKHR")]
public unsafe partial struct VideoFormatPropertiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoFormatPropertiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("format")]
    public Format Format;

    [NativeName("componentMapping")]
    public ComponentMapping ComponentMapping;

    [NativeName("imageCreateFlags")]
    public ImageCreateFlags ImageCreateFlags;

    [NativeName("imageType")]
    public ImageType ImageType;

    [NativeName("imageTiling")]
    public ImageTiling ImageTiling;

    [NativeName("imageUsageFlags")]
    public ImageUsageFlags ImageUsageFlags;

    public VideoFormatPropertiesKHR() { }
}
