// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPGRAMMARSTATE.xml' path='doc/member[@name="SPGRAMMARSTATE"]/*' />
public enum SPGRAMMARSTATE
{
    /// <include file='SPGRAMMARSTATE.xml' path='doc/member[@name="SPGRAMMARSTATE.SPGS_DISABLED"]/*' />
    SPGS_DISABLED = 0,

    /// <include file='SPGRAMMARSTATE.xml' path='doc/member[@name="SPGRAMMARSTATE.SPGS_ENABLED"]/*' />
    SPGS_ENABLED = 1,

    /// <include file='SPGRAMMARSTATE.xml' path='doc/member[@name="SPGRAMMARSTATE.SPGS_EXCLUSIVE"]/*' />
    SPGS_EXCLUSIVE = 3,
}
