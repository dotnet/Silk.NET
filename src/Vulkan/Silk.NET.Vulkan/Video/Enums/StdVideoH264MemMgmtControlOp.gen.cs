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
        [Obsolete("Deprecated in favour of \"End\"")]
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_END")]
        StdVideoH264MemMgmtControlOpEnd = 0x0,
        [Obsolete("Deprecated in favour of \"UnmarkShortTerm\"")]
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_SHORT_TERM")]
        StdVideoH264MemMgmtControlOpUnmarkShortTerm = 0x1,
        [Obsolete("Deprecated in favour of \"UnmarkLongTerm\"")]
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_LONG_TERM")]
        StdVideoH264MemMgmtControlOpUnmarkLongTerm = 0x2,
        [Obsolete("Deprecated in favour of \"MarkLongTerm\"")]
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_LONG_TERM")]
        StdVideoH264MemMgmtControlOpMarkLongTerm = 0x3,
        [Obsolete("Deprecated in favour of \"SetMaxLongTermIndex\"")]
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_SET_MAX_LONG_TERM_INDEX")]
        StdVideoH264MemMgmtControlOpSetMaxLongTermIndex = 0x4,
        [Obsolete("Deprecated in favour of \"UnmarkAll\"")]
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_ALL")]
        StdVideoH264MemMgmtControlOpUnmarkAll = 0x5,
        [Obsolete("Deprecated in favour of \"MarkCurrentAsLongTerm\"")]
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_CURRENT_AS_LONG_TERM")]
        StdVideoH264MemMgmtControlOpMarkCurrentAsLongTerm = 0x6,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_INVALID")]
        StdVideoH264MemMgmtControlOpInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MAX_ENUM")]
        StdVideoH264MemMgmtControlOpMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_END")]
        End = 0x0,
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_SHORT_TERM")]
        UnmarkShortTerm = 0x1,
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_LONG_TERM")]
        UnmarkLongTerm = 0x2,
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_LONG_TERM")]
        MarkLongTerm = 0x3,
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_SET_MAX_LONG_TERM_INDEX")]
        SetMaxLongTermIndex = 0x4,
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_ALL")]
        UnmarkAll = 0x5,
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_CURRENT_AS_LONG_TERM")]
        MarkCurrentAsLongTerm = 0x6,
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
