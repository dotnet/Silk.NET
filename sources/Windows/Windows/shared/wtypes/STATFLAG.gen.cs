// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STATFLAG.xml' path='doc/member[@name="STATFLAG"]/*' />
public enum STATFLAG
{
    /// <include file='STATFLAG.xml' path='doc/member[@name="STATFLAG.STATFLAG_DEFAULT"]/*' />
    STATFLAG_DEFAULT = 0,

    /// <include file='STATFLAG.xml' path='doc/member[@name="STATFLAG.STATFLAG_NONAME"]/*' />
    STATFLAG_NONAME = 1,

    /// <include file='STATFLAG.xml' path='doc/member[@name="STATFLAG.STATFLAG_NOOPEN"]/*' />
    STATFLAG_NOOPEN = 2,
}
