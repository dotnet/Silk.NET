// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS"]/*'/>
[Flags]
public enum GLOBALOPT_RO_FLAGS
{
    /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_STA_MODALLOOP_REMOVE_TOUCH_MESSAGES"]/*'/>
    COMGLB_STA_MODALLOOP_REMOVE_TOUCH_MESSAGES = 0x1,
    /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_STA_MODALLOOP_SHARED_QUEUE_REMOVE_INPUT_MESSAGES"]/*'/>
    COMGLB_STA_MODALLOOP_SHARED_QUEUE_REMOVE_INPUT_MESSAGES = 0x2,
    /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_STA_MODALLOOP_SHARED_QUEUE_DONOT_REMOVE_INPUT_MESSAGES"]/*'/>
    COMGLB_STA_MODALLOOP_SHARED_QUEUE_DONOT_REMOVE_INPUT_MESSAGES = 0x4,
    /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_FAST_RUNDOWN"]/*'/>
    COMGLB_FAST_RUNDOWN = 0x8,
    /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_RESERVED1"]/*'/>
    COMGLB_RESERVED1 = 0x10,
    /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_RESERVED2"]/*'/>
    COMGLB_RESERVED2 = 0x20,
    /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_RESERVED3"]/*'/>
    COMGLB_RESERVED3 = 0x40,
    /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_STA_MODALLOOP_SHARED_QUEUE_REORDER_POINTER_MESSAGES"]/*'/>
    COMGLB_STA_MODALLOOP_SHARED_QUEUE_REORDER_POINTER_MESSAGES = 0x80,
    /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_RESERVED4"]/*'/>
    COMGLB_RESERVED4 = 0x100,
    /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_RESERVED5"]/*'/>
    COMGLB_RESERVED5 = 0x200,
    /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_RESERVED6"]/*'/>
    COMGLB_RESERVED6 = 0x400,
}