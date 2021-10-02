// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoH264MemMgmtControlOp")]
    public enum StdVideoH264MemMgmtControlOp : int
    {
        [NativeName("Name", "std_video_h264_mem_mgmt_control_op_end")]
        StdVideoH264MemMgmtControlOpEnd = 0x0,
        [NativeName("Name", "std_video_h264_mem_mgmt_control_op_unmark_short_term")]
        StdVideoH264MemMgmtControlOpUnmarkShortTerm = 0x1,
        [NativeName("Name", "std_video_h264_mem_mgmt_control_op_unmark_long_term")]
        StdVideoH264MemMgmtControlOpUnmarkLongTerm = 0x2,
        [NativeName("Name", "std_video_h264_mem_mgmt_control_op_mark_long_term")]
        StdVideoH264MemMgmtControlOpMarkLongTerm = 0x3,
        [NativeName("Name", "std_video_h264_mem_mgmt_control_op_set_max_long_term_index")]
        StdVideoH264MemMgmtControlOpSetMaxLongTermIndex = 0x4,
        [NativeName("Name", "std_video_h264_mem_mgmt_control_op_unmark_all")]
        StdVideoH264MemMgmtControlOpUnmarkAll = 0x5,
        [NativeName("Name", "std_video_h264_mem_mgmt_control_op_mark_current_as_long_term")]
        StdVideoH264MemMgmtControlOpMarkCurrentAsLongTerm = 0x6,
        [NativeName("Name", "std_video_h264_mem_mgmt_control_op_invalid")]
        StdVideoH264MemMgmtControlOpInvalid = 0x7FFFFFFF,
    }
}
