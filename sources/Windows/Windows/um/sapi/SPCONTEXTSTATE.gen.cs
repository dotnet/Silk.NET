// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPCONTEXTSTATE.xml' path='doc/member[@name="SPCONTEXTSTATE"]/*' />
public enum SPCONTEXTSTATE
{
    /// <include file='SPCONTEXTSTATE.xml' path='doc/member[@name="SPCONTEXTSTATE.SPCS_DISABLED"]/*' />
    SPCS_DISABLED = 0,

    /// <include file='SPCONTEXTSTATE.xml' path='doc/member[@name="SPCONTEXTSTATE.SPCS_ENABLED"]/*' />
    SPCS_ENABLED = 1,
}
