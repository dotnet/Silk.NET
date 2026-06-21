// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1LoopRestoration")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoAv1LoopRestoration
{
    [NativeName("FrameRestorationType")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1LoopRestorationFrameRestorationType FrameRestorationType;

    [NativeName("LoopRestorationSize")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1LoopRestorationLoopRestorationSize LoopRestorationSize;
}
