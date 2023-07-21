// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='INSTALLMODE.xml' path='doc/member[@name="INSTALLMODE"]/*' />
public enum INSTALLMODE
{
    /// <include file='INSTALLMODE.xml' path='doc/member[@name="INSTALLMODE.INSTALLMODE_NODETECTION_ANY"]/*' />
    INSTALLMODE_NODETECTION_ANY = -4,

    /// <include file='INSTALLMODE.xml' path='doc/member[@name="INSTALLMODE.INSTALLMODE_NOSOURCERESOLUTION"]/*' />
    INSTALLMODE_NOSOURCERESOLUTION = -3,

    /// <include file='INSTALLMODE.xml' path='doc/member[@name="INSTALLMODE.INSTALLMODE_NODETECTION"]/*' />
    INSTALLMODE_NODETECTION = -2,

    /// <include file='INSTALLMODE.xml' path='doc/member[@name="INSTALLMODE.INSTALLMODE_EXISTING"]/*' />
    INSTALLMODE_EXISTING = -1,

    /// <include file='INSTALLMODE.xml' path='doc/member[@name="INSTALLMODE.INSTALLMODE_DEFAULT"]/*' />
    INSTALLMODE_DEFAULT = 0,
}
