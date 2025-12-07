// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoDecodeH264ReferenceInfo
{
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeH264ReferenceInfoFlags Flags;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort FrameNum;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort Reserved;

    [NativeTypeName("int32_t[2]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeH264ReferenceInfoPicOrderCnt PicOrderCnt;
}
