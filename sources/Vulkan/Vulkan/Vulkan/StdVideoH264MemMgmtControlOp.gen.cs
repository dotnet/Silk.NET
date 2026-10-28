// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264MemMgmtControlOp")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH264MemMgmtControlOp : uint
{
    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_END")]
    [SupportedApiProfile("vulkan")]
    End = 0,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_SHORT_TERM")]
    [SupportedApiProfile("vulkan")]
    UnmarkShortTerm = 1,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_LONG_TERM")]
    [SupportedApiProfile("vulkan")]
    UnmarkLongTerm = 2,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_LONG_TERM")]
    [SupportedApiProfile("vulkan")]
    MarkLongTerm = 3,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_SET_MAX_LONG_TERM_INDEX")]
    [SupportedApiProfile("vulkan")]
    SetMaxLongTermIndex = 4,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_ALL")]
    [SupportedApiProfile("vulkan")]
    UnmarkAll = 5,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_CURRENT_AS_LONG_TERM")]
    [SupportedApiProfile("vulkan")]
    MarkCurrentAsLongTerm = 6,
}
