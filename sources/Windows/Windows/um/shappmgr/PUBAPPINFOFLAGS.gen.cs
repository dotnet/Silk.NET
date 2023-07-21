// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PUBAPPINFOFLAGS.xml' path='doc/member[@name="PUBAPPINFOFLAGS"]/*' />
public enum PUBAPPINFOFLAGS
{
    /// <include file='PUBAPPINFOFLAGS.xml' path='doc/member[@name="PUBAPPINFOFLAGS.PAI_SOURCE"]/*' />
    PAI_SOURCE = 0x1,

    /// <include file='PUBAPPINFOFLAGS.xml' path='doc/member[@name="PUBAPPINFOFLAGS.PAI_ASSIGNEDTIME"]/*' />
    PAI_ASSIGNEDTIME = 0x2,

    /// <include file='PUBAPPINFOFLAGS.xml' path='doc/member[@name="PUBAPPINFOFLAGS.PAI_PUBLISHEDTIME"]/*' />
    PAI_PUBLISHEDTIME = 0x4,

    /// <include file='PUBAPPINFOFLAGS.xml' path='doc/member[@name="PUBAPPINFOFLAGS.PAI_SCHEDULEDTIME"]/*' />
    PAI_SCHEDULEDTIME = 0x8,

    /// <include file='PUBAPPINFOFLAGS.xml' path='doc/member[@name="PUBAPPINFOFLAGS.PAI_EXPIRETIME"]/*' />
    PAI_EXPIRETIME = 0x10,
}
