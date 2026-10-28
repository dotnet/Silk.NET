// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264MemMgmtControlOp")]
public enum StdVideoH264MemMgmtControlOp : uint
{
    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_END")]
    End = 0,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_SHORT_TERM")]
    UnmarkShortTerm = 1,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_LONG_TERM")]
    UnmarkLongTerm = 2,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_LONG_TERM")]
    MarkLongTerm = 3,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_SET_MAX_LONG_TERM_INDEX")]
    SetMaxLongTermIndex = 4,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_ALL")]
    UnmarkAll = 5,

    [NativeName("STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_CURRENT_AS_LONG_TERM")]
    MarkCurrentAsLongTerm = 6,
}
