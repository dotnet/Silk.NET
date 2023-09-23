// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagGLOBALOPT_RO_FLAGS")]
    public enum GlobalOptRoFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"StaModalloopRemoveTouchMessages\"")]
        [NativeName("Name", "COMGLB_STA_MODALLOOP_REMOVE_TOUCH_MESSAGES")]
        ComglbStaModalloopRemoveTouchMessages = 0x1,
        [Obsolete("Deprecated in favour of \"StaModalloopSharedQueueRemoveInputMessages\"")]
        [NativeName("Name", "COMGLB_STA_MODALLOOP_SHARED_QUEUE_REMOVE_INPUT_MESSAGES")]
        ComglbStaModalloopSharedQueueRemoveInputMessages = 0x2,
        [Obsolete("Deprecated in favour of \"StaModalloopSharedQueueDonotRemoveInputMessages\"")]
        [NativeName("Name", "COMGLB_STA_MODALLOOP_SHARED_QUEUE_DONOT_REMOVE_INPUT_MESSAGES")]
        ComglbStaModalloopSharedQueueDonotRemoveInputMessages = 0x4,
        [Obsolete("Deprecated in favour of \"FastRundown\"")]
        [NativeName("Name", "COMGLB_FAST_RUNDOWN")]
        ComglbFastRundown = 0x8,
        [Obsolete("Deprecated in favour of \"Reserved1\"")]
        [NativeName("Name", "COMGLB_RESERVED1")]
        ComglbReserved1 = 0x10,
        [Obsolete("Deprecated in favour of \"Reserved2\"")]
        [NativeName("Name", "COMGLB_RESERVED2")]
        ComglbReserved2 = 0x20,
        [Obsolete("Deprecated in favour of \"Reserved3\"")]
        [NativeName("Name", "COMGLB_RESERVED3")]
        ComglbReserved3 = 0x40,
        [Obsolete("Deprecated in favour of \"StaModalloopSharedQueueReorderPointerMessages\"")]
        [NativeName("Name", "COMGLB_STA_MODALLOOP_SHARED_QUEUE_REORDER_POINTER_MESSAGES")]
        ComglbStaModalloopSharedQueueReorderPointerMessages = 0x80,
        [Obsolete("Deprecated in favour of \"Reserved4\"")]
        [NativeName("Name", "COMGLB_RESERVED4")]
        ComglbReserved4 = 0x100,
        [Obsolete("Deprecated in favour of \"Reserved5\"")]
        [NativeName("Name", "COMGLB_RESERVED5")]
        ComglbReserved5 = 0x200,
        [Obsolete("Deprecated in favour of \"Reserved6\"")]
        [NativeName("Name", "COMGLB_RESERVED6")]
        ComglbReserved6 = 0x400,
        [NativeName("Name", "COMGLB_STA_MODALLOOP_REMOVE_TOUCH_MESSAGES")]
        StaModalloopRemoveTouchMessages = 0x1,
        [NativeName("Name", "COMGLB_STA_MODALLOOP_SHARED_QUEUE_REMOVE_INPUT_MESSAGES")]
        StaModalloopSharedQueueRemoveInputMessages = 0x2,
        [NativeName("Name", "COMGLB_STA_MODALLOOP_SHARED_QUEUE_DONOT_REMOVE_INPUT_MESSAGES")]
        StaModalloopSharedQueueDonotRemoveInputMessages = 0x4,
        [NativeName("Name", "COMGLB_FAST_RUNDOWN")]
        FastRundown = 0x8,
        [NativeName("Name", "COMGLB_RESERVED1")]
        Reserved1 = 0x10,
        [NativeName("Name", "COMGLB_RESERVED2")]
        Reserved2 = 0x20,
        [NativeName("Name", "COMGLB_RESERVED3")]
        Reserved3 = 0x40,
        [NativeName("Name", "COMGLB_STA_MODALLOOP_SHARED_QUEUE_REORDER_POINTER_MESSAGES")]
        StaModalloopSharedQueueReorderPointerMessages = 0x80,
        [NativeName("Name", "COMGLB_RESERVED4")]
        Reserved4 = 0x100,
        [NativeName("Name", "COMGLB_RESERVED5")]
        Reserved5 = 0x200,
        [NativeName("Name", "COMGLB_RESERVED6")]
        Reserved6 = 0x400,
    }
}
