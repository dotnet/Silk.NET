// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SCRIPT_TIMER_TYPE.xml' path='doc/member[@name="SCRIPT_TIMER_TYPE"]/*' />
public enum SCRIPT_TIMER_TYPE
{
    /// <include file='SCRIPT_TIMER_TYPE.xml' path='doc/member[@name="SCRIPT_TIMER_TYPE.STT_TIMEOUT"]/*' />
    STT_TIMEOUT = 0,

    /// <include file='SCRIPT_TIMER_TYPE.xml' path='doc/member[@name="SCRIPT_TIMER_TYPE.STT_INTERVAL"]/*' />
    STT_INTERVAL = 0x1,

    /// <include file='SCRIPT_TIMER_TYPE.xml' path='doc/member[@name="SCRIPT_TIMER_TYPE.STT_IMMEDIATE"]/*' />
    STT_IMMEDIATE = 0x2,

    /// <include file='SCRIPT_TIMER_TYPE.xml' path='doc/member[@name="SCRIPT_TIMER_TYPE.STT_ANIMATION_FRAME"]/*' />
    STT_ANIMATION_FRAME = 0x3,

    /// <include file='SCRIPT_TIMER_TYPE.xml' path='doc/member[@name="SCRIPT_TIMER_TYPE.SCRIPT_TIMER_TYPE_Max"]/*' />
    SCRIPT_TIMER_TYPE_Max = 2147483647,
}
