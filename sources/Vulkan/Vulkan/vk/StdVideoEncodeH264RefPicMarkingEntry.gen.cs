// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH264RefPicMarkingEntry")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeH264RefPicMarkingEntry
{
    [NativeName("memory_management_control_operation")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264MemMgmtControlOp MemoryManagementControlOperation;

    [NativeName("difference_of_pic_nums_minus1")]
    [SupportedApiProfile("vulkan")]
    public ushort DifferenceOfPicNumsMinus1;

    [NativeName("long_term_pic_num")]
    [SupportedApiProfile("vulkan")]
    public ushort LongTermPicNum;

    [NativeName("long_term_frame_idx")]
    [SupportedApiProfile("vulkan")]
    public ushort LongTermFrameIdx;

    [NativeName("max_long_term_frame_idx_plus1")]
    [SupportedApiProfile("vulkan")]
    public ushort MaxLongTermFrameIdxPlus1;
}
