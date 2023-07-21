// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DEFAULTSAVEFOLDERTYPE.xml' path='doc/member[@name="DEFAULTSAVEFOLDERTYPE"]/*' />
public enum DEFAULTSAVEFOLDERTYPE
{
    /// <include file='DEFAULTSAVEFOLDERTYPE.xml' path='doc/member[@name="DEFAULTSAVEFOLDERTYPE.DSFT_DETECT"]/*' />
    DSFT_DETECT = 1,

    /// <include file='DEFAULTSAVEFOLDERTYPE.xml' path='doc/member[@name="DEFAULTSAVEFOLDERTYPE.DSFT_PRIVATE"]/*' />
    DSFT_PRIVATE = (DSFT_DETECT + 1),

    /// <include file='DEFAULTSAVEFOLDERTYPE.xml' path='doc/member[@name="DEFAULTSAVEFOLDERTYPE.DSFT_PUBLIC"]/*' />
    DSFT_PUBLIC = (DSFT_PRIVATE + 1),
}
