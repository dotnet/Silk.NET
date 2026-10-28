// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAttachmentReference2")]
public unsafe partial struct AttachmentReference2
{
    [NativeName("sType")]
    public StructureType SType = StructureType.AttachmentReference2;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("attachment")]
    public uint Attachment;

    [NativeName("layout")]
    public ImageLayout Layout;

    [NativeName("aspectMask")]
    public ImageAspectFlags AspectMask;

    public AttachmentReference2() { }
}
