// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoDecodeAV1ReferenceInfo")]
public partial struct StdVideoDecodeAv1ReferenceInfo
{
    [NativeName("flags")]
    public StdVideoDecodeAv1ReferenceInfoFlags Flags;

    [NativeName("frame_type")]
    public byte FrameType;

    [NativeName("RefFrameSignBias")]
    public byte RefFrameSignBias;

    [NativeName("OrderHint")]
    public byte OrderHint;

    [NativeName("SavedOrderHints")]
    public StdVideoDecodeAv1ReferenceInfoSavedOrderHints SavedOrderHints;
}
