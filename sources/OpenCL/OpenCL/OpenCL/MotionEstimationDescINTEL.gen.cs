// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_motion_estimation_desc_intel")]
public partial struct MotionEstimationDescINTEL
{
    [NativeName("mb_block_type")]
    public uint MbBlockType;

    [NativeName("subpixel_mode")]
    public uint SubpixelMode;

    [NativeName("sad_adjust_mode")]
    public uint SadAdjustMode;

    [NativeName("search_path_type")]
    public uint SearchPathType;
}
