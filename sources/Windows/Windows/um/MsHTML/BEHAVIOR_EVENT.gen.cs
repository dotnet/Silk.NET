// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BEHAVIOR_EVENT.xml' path='doc/member[@name="BEHAVIOR_EVENT"]/*' />
public enum BEHAVIOR_EVENT
{
    /// <include file='BEHAVIOR_EVENT.xml' path='doc/member[@name="BEHAVIOR_EVENT.BEHAVIOREVENT_FIRST"]/*' />
    BEHAVIOREVENT_FIRST = 0,

    /// <include file='BEHAVIOR_EVENT.xml' path='doc/member[@name="BEHAVIOR_EVENT.BEHAVIOREVENT_CONTENTREADY"]/*' />
    BEHAVIOREVENT_CONTENTREADY = 0,

    /// <include file='BEHAVIOR_EVENT.xml' path='doc/member[@name="BEHAVIOR_EVENT.BEHAVIOREVENT_DOCUMENTREADY"]/*' />
    BEHAVIOREVENT_DOCUMENTREADY = 1,

    /// <include file='BEHAVIOR_EVENT.xml' path='doc/member[@name="BEHAVIOR_EVENT.BEHAVIOREVENT_APPLYSTYLE"]/*' />
    BEHAVIOREVENT_APPLYSTYLE = 2,

    /// <include file='BEHAVIOR_EVENT.xml' path='doc/member[@name="BEHAVIOR_EVENT.BEHAVIOREVENT_DOCUMENTCONTEXTCHANGE"]/*' />
    BEHAVIOREVENT_DOCUMENTCONTEXTCHANGE = 3,

    /// <include file='BEHAVIOR_EVENT.xml' path='doc/member[@name="BEHAVIOR_EVENT.BEHAVIOREVENT_CONTENTSAVE"]/*' />
    BEHAVIOREVENT_CONTENTSAVE = 4,

    /// <include file='BEHAVIOR_EVENT.xml' path='doc/member[@name="BEHAVIOR_EVENT.BEHAVIOREVENT_LAST"]/*' />
    BEHAVIOREVENT_LAST = 4,

    /// <include file='BEHAVIOR_EVENT.xml' path='doc/member[@name="BEHAVIOR_EVENT.BEHAVIOR_EVENT_Max"]/*' />
    BEHAVIOR_EVENT_Max = 2147483647,
}
