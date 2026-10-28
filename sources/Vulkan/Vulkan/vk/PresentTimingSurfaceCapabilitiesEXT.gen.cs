// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPresentTimingSurfaceCapabilitiesEXT")]
public unsafe partial struct PresentTimingSurfaceCapabilitiesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PresentTimingSurfaceCapabilitiesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("presentTimingSupported")]
    public MaybeBool<uint> PresentTimingSupported;

    [NativeName("presentAtAbsoluteTimeSupported")]
    public MaybeBool<uint> PresentAtAbsoluteTimeSupported;

    [NativeName("presentAtRelativeTimeSupported")]
    public MaybeBool<uint> PresentAtRelativeTimeSupported;

    [NativeName("presentStageQueries")]
    public PresentStageFlagsEXT PresentStageQueries;

    public PresentTimingSurfaceCapabilitiesEXT() { }
}
