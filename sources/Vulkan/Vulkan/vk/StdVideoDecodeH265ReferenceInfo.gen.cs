// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoDecodeH265ReferenceInfo")]
public partial struct StdVideoDecodeH265ReferenceInfo
{
    [NativeName("flags")]
    public StdVideoDecodeH265ReferenceInfoFlags Flags;

    [NativeName("PicOrderCntVal")]
    public int PicOrderCntVal;
}
