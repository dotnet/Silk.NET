// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("_cb_qp_offset_list_e__FixedBuffer")]
[InlineArray(6)]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoH265PictureParameterSetCbQpOffsetList
{
    [NativeName("e0")]
    [SupportedApiProfile("vulkan")]
    public sbyte E0;
}
