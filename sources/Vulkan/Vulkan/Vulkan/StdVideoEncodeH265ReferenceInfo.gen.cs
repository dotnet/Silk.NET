// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH265ReferenceInfo")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeH265ReferenceInfo
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265ReferenceInfoFlags Flags;

    [NativeName("pic_type")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265PictureType PicType;

    [NativeName("PicOrderCntVal")]
    [SupportedApiProfile("vulkan")]
    public int PicOrderCntVal;

    [NativeName("TemporalId")]
    [SupportedApiProfile("vulkan")]
    public byte TemporalId;
}
