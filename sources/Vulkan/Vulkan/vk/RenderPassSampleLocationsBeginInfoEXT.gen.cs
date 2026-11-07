// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRenderPassSampleLocationsBeginInfoEXT")]
public unsafe partial struct RenderPassSampleLocationsBeginInfoEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.RenderPassSampleLocationsBeginInfoEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("attachmentInitialSampleLocationsCount")]
    public uint AttachmentInitialSampleLocationsCount;

    [NativeName("pAttachmentInitialSampleLocations")]
    public AttachmentSampleLocationsEXT* PAttachmentInitialSampleLocations;

    [NativeName("postSubpassSampleLocationsCount")]
    public uint PostSubpassSampleLocationsCount;

    [NativeName("pPostSubpassSampleLocations")]
    public SubpassSampleLocationsEXT* PPostSubpassSampleLocations;

    public RenderPassSampleLocationsBeginInfoEXT() { }
}
