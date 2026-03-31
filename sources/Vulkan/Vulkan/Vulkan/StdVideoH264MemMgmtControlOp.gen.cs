// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264MemMgmtControlOp")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH264MemMgmtControlOp : uint
{
    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_END")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264MemMgmtControlOpEnd = 0,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_SHORT_TERM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264MemMgmtControlOpUnmarkShortTerm = 1,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_LONG_TERM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264MemMgmtControlOpUnmarkLongTerm = 2,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_LONG_TERM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264MemMgmtControlOpMarkLongTerm = 3,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_SET_MAX_LONG_TERM_INDEX")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264MemMgmtControlOpSetMaxLongTermIndex = 4,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_ALL")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264MemMgmtControlOpUnmarkAll = 5,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_CURRENT_AS_LONG_TERM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264MemMgmtControlOpMarkCurrentAsLongTerm = 6,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264MemMgmtControlOpInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264MemMgmtControlOpMaxEnum = 0x7FFFFFFF,
}
