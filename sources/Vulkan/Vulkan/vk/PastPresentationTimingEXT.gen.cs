// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPastPresentationTimingEXT")]
public unsafe partial struct PastPresentationTimingEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PastPresentationTimingEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("presentId")]
    public ulong PresentId;

    [NativeName("targetTime")]
    public ulong TargetTime;

    [NativeName("presentStageCount")]
    public uint PresentStageCount;

    [NativeName("pPresentStages")]
    public PresentStageTimeEXT* PPresentStages;

    [NativeName("timeDomain")]
    public TimeDomainKHR TimeDomain;

    [NativeName("timeDomainId")]
    public ulong TimeDomainId;

    [NativeName("reportComplete")]
    public MaybeBool<uint> ReportComplete;

    public PastPresentationTimingEXT() { }
}
