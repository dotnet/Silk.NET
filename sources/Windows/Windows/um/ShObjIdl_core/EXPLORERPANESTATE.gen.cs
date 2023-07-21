// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='EXPLORERPANESTATE.xml' path='doc/member[@name="EXPLORERPANESTATE"]/*' />
[Flags]
public enum EXPLORERPANESTATE
{
    /// <include file='EXPLORERPANESTATE.xml' path='doc/member[@name="EXPLORERPANESTATE.EPS_DONTCARE"]/*' />
    EPS_DONTCARE = 0,

    /// <include file='EXPLORERPANESTATE.xml' path='doc/member[@name="EXPLORERPANESTATE.EPS_DEFAULT_ON"]/*' />
    EPS_DEFAULT_ON = 0x1,

    /// <include file='EXPLORERPANESTATE.xml' path='doc/member[@name="EXPLORERPANESTATE.EPS_DEFAULT_OFF"]/*' />
    EPS_DEFAULT_OFF = 0x2,

    /// <include file='EXPLORERPANESTATE.xml' path='doc/member[@name="EXPLORERPANESTATE.EPS_STATEMASK"]/*' />
    EPS_STATEMASK = 0xffff,

    /// <include file='EXPLORERPANESTATE.xml' path='doc/member[@name="EXPLORERPANESTATE.EPS_INITIALSTATE"]/*' />
    EPS_INITIALSTATE = 0x10000,

    /// <include file='EXPLORERPANESTATE.xml' path='doc/member[@name="EXPLORERPANESTATE.EPS_FORCE"]/*' />
    EPS_FORCE = 0x20000,
}
