// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STGC.xml' path='doc/member[@name="STGC"]/*' />
public enum STGC
{
    /// <include file='STGC.xml' path='doc/member[@name="STGC.STGC_DEFAULT"]/*' />
    STGC_DEFAULT = 0,

    /// <include file='STGC.xml' path='doc/member[@name="STGC.STGC_OVERWRITE"]/*' />
    STGC_OVERWRITE = 1,

    /// <include file='STGC.xml' path='doc/member[@name="STGC.STGC_ONLYIFCURRENT"]/*' />
    STGC_ONLYIFCURRENT = 2,

    /// <include file='STGC.xml' path='doc/member[@name="STGC.STGC_DANGEROUSLYCOMMITMERELYTODISKCACHE"]/*' />
    STGC_DANGEROUSLYCOMMITMERELYTODISKCACHE = 4,

    /// <include file='STGC.xml' path='doc/member[@name="STGC.STGC_CONSOLIDATE"]/*' />
    STGC_CONSOLIDATE = 8,
}
