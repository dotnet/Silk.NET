// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum GLOBALOPT_RO_FLAGS
{
    COMGLB_STA_MODALLOOP_REMOVE_TOUCH_MESSAGES = 0x1,
    COMGLB_STA_MODALLOOP_SHARED_QUEUE_REMOVE_INPUT_MESSAGES = 0x2,
    COMGLB_STA_MODALLOOP_SHARED_QUEUE_DONOT_REMOVE_INPUT_MESSAGES = 0x4,
    COMGLB_FAST_RUNDOWN = 0x8,
    COMGLB_RESERVED1 = 0x10,
    COMGLB_RESERVED2 = 0x20,
    COMGLB_RESERVED3 = 0x40,
    COMGLB_STA_MODALLOOP_SHARED_QUEUE_REORDER_POINTER_MESSAGES = 0x80,
    COMGLB_RESERVED4 = 0x100,
    COMGLB_RESERVED5 = 0x200,
    COMGLB_RESERVED6 = 0x400,
}
