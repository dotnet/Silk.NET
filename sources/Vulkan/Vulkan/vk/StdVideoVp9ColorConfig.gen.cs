// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoVP9ColorConfig")]
public partial struct StdVideoVp9ColorConfig
{
    [NativeName("flags")]
    public StdVideoVp9ColorConfigFlags Flags;

    [NativeName("BitDepth")]
    public byte BitDepth;

    [NativeName("subsampling_x")]
    public byte SubsamplingX;

    [NativeName("subsampling_y")]
    public byte SubsamplingY;

    [NativeName("reserved1")]
    public byte Reserved1;

    [NativeName("color_space")]
    public StdVideoVp9ColorSpace ColorSpace;
}
