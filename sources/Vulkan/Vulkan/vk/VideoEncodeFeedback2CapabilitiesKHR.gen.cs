// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeFeedback2CapabilitiesKHR")]
public unsafe partial struct VideoEncodeFeedback2CapabilitiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeFeedback2CapabilitiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxPerPartitionFeedbackEntries")]
    public uint MaxPerPartitionFeedbackEntries;

    [NativeName("supportedPerPartitionEncodeFeedbackFlags")]
    public VideoEncodePerPartitionFeedbackFlagsKHR SupportedPerPartitionEncodeFeedbackFlags;

    public VideoEncodeFeedback2CapabilitiesKHR() { }
}
