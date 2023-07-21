// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FFFP_MODE.xml' path='doc/member[@name="FFFP_MODE"]/*' />
public enum FFFP_MODE
{
    /// <include file='FFFP_MODE.xml' path='doc/member[@name="FFFP_MODE.FFFP_EXACTMATCH"]/*' />
    FFFP_EXACTMATCH = 0,

    /// <include file='FFFP_MODE.xml' path='doc/member[@name="FFFP_MODE.FFFP_NEARESTPARENTMATCH"]/*' />
    FFFP_NEARESTPARENTMATCH = (FFFP_EXACTMATCH + 1),
}
