// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRenderPassSubpassFeedbackCreateInfoEXT")]
public unsafe partial struct RenderPassSubpassFeedbackCreateInfoEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.RenderPassSubpassFeedbackCreateInfoEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("pSubpassFeedback")]
    public RenderPassSubpassFeedbackInfoEXT* PSubpassFeedback;

    public RenderPassSubpassFeedbackCreateInfoEXT() { }
}
