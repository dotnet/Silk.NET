// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYNCMGRITEMFLAGS.xml' path='doc/member[@name="SYNCMGRITEMFLAGS"]/*' />
public enum SYNCMGRITEMFLAGS
{
    /// <include file='SYNCMGRITEMFLAGS.xml' path='doc/member[@name="SYNCMGRITEMFLAGS.SYNCMGRITEM_HASPROPERTIES"]/*' />
    SYNCMGRITEM_HASPROPERTIES = 0x1,

    /// <include file='SYNCMGRITEMFLAGS.xml' path='doc/member[@name="SYNCMGRITEMFLAGS.SYNCMGRITEM_TEMPORARY"]/*' />
    SYNCMGRITEM_TEMPORARY = 0x2,

    /// <include file='SYNCMGRITEMFLAGS.xml' path='doc/member[@name="SYNCMGRITEMFLAGS.SYNCMGRITEM_ROAMINGUSER"]/*' />
    SYNCMGRITEM_ROAMINGUSER = 0x4,

    /// <include file='SYNCMGRITEMFLAGS.xml' path='doc/member[@name="SYNCMGRITEMFLAGS.SYNCMGRITEM_LASTUPDATETIME"]/*' />
    SYNCMGRITEM_LASTUPDATETIME = 0x8,

    /// <include file='SYNCMGRITEMFLAGS.xml' path='doc/member[@name="SYNCMGRITEMFLAGS.SYNCMGRITEM_MAYDELETEITEM"]/*' />
    SYNCMGRITEM_MAYDELETEITEM = 0x10,

    /// <include file='SYNCMGRITEMFLAGS.xml' path='doc/member[@name="SYNCMGRITEMFLAGS.SYNCMGRITEM_HIDDEN"]/*' />
    SYNCMGRITEM_HIDDEN = 0x20,
}
