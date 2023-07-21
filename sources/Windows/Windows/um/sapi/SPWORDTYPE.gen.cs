// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPWORDTYPE.xml' path='doc/member[@name="SPWORDTYPE"]/*' />
public enum SPWORDTYPE
{
    /// <include file='SPWORDTYPE.xml' path='doc/member[@name="SPWORDTYPE.eWORDTYPE_ADDED"]/*' />
    eWORDTYPE_ADDED = (1 << 0),

    /// <include file='SPWORDTYPE.xml' path='doc/member[@name="SPWORDTYPE.eWORDTYPE_DELETED"]/*' />
    eWORDTYPE_DELETED = (1 << 1),
}
