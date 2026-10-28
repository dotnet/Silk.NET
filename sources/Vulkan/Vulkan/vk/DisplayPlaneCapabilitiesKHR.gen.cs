// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDisplayPlaneCapabilitiesKHR")]
public partial struct DisplayPlaneCapabilitiesKHR
{
    [NativeName("supportedAlpha")]
    public DisplayPlaneAlphaFlagsKHR SupportedAlpha;

    [NativeName("minSrcPosition")]
    public Offset2D MinSrcPosition;

    [NativeName("maxSrcPosition")]
    public Offset2D MaxSrcPosition;

    [NativeName("minSrcExtent")]
    public Extent2D MinSrcExtent;

    [NativeName("maxSrcExtent")]
    public Extent2D MaxSrcExtent;

    [NativeName("minDstPosition")]
    public Offset2D MinDstPosition;

    [NativeName("maxDstPosition")]
    public Offset2D MaxDstPosition;

    [NativeName("minDstExtent")]
    public Extent2D MinDstExtent;

    [NativeName("maxDstExtent")]
    public Extent2D MaxDstExtent;
}
