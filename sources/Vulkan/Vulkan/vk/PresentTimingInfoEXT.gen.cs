// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPresentTimingInfoEXT")]
public unsafe partial struct PresentTimingInfoEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PresentTimingInfoEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public PresentTimingInfoFlagsEXT Flags;

    [NativeName("targetTime")]
    public ulong TargetTime;

    [NativeName("timeDomainId")]
    public ulong TimeDomainId;

    [NativeName("presentStageQueries")]
    public PresentStageFlagsEXT PresentStageQueries;

    [NativeName("targetTimeDomainPresentStage")]
    public PresentStageFlagsEXT TargetTimeDomainPresentStage;

    public PresentTimingInfoEXT() { }
}
