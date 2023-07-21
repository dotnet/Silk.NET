// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SVSIF.xml' path='doc/member[@name="SVSIF"]/*' />
public enum SVSIF
{
    /// <include file='SVSIF.xml' path='doc/member[@name="SVSIF.SVSI_DESELECT"]/*' />
    SVSI_DESELECT = 0,

    /// <include file='SVSIF.xml' path='doc/member[@name="SVSIF.SVSI_SELECT"]/*' />
    SVSI_SELECT = 0x1,

    /// <include file='SVSIF.xml' path='doc/member[@name="SVSIF.SVSI_EDIT"]/*' />
    SVSI_EDIT = 0x3,

    /// <include file='SVSIF.xml' path='doc/member[@name="SVSIF.SVSI_DESELECTOTHERS"]/*' />
    SVSI_DESELECTOTHERS = 0x4,

    /// <include file='SVSIF.xml' path='doc/member[@name="SVSIF.SVSI_ENSUREVISIBLE"]/*' />
    SVSI_ENSUREVISIBLE = 0x8,

    /// <include file='SVSIF.xml' path='doc/member[@name="SVSIF.SVSI_FOCUSED"]/*' />
    SVSI_FOCUSED = 0x10,

    /// <include file='SVSIF.xml' path='doc/member[@name="SVSIF.SVSI_TRANSLATEPT"]/*' />
    SVSI_TRANSLATEPT = 0x20,

    /// <include file='SVSIF.xml' path='doc/member[@name="SVSIF.SVSI_SELECTIONMARK"]/*' />
    SVSI_SELECTIONMARK = 0x40,

    /// <include file='SVSIF.xml' path='doc/member[@name="SVSIF.SVSI_POSITIONITEM"]/*' />
    SVSI_POSITIONITEM = 0x80,

    /// <include file='SVSIF.xml' path='doc/member[@name="SVSIF.SVSI_CHECK"]/*' />
    SVSI_CHECK = 0x100,

    /// <include file='SVSIF.xml' path='doc/member[@name="SVSIF.SVSI_CHECK2"]/*' />
    SVSI_CHECK2 = 0x200,

    /// <include file='SVSIF.xml' path='doc/member[@name="SVSIF.SVSI_KEYBOARDSELECT"]/*' />
    SVSI_KEYBOARDSELECT = 0x401,

    /// <include file='SVSIF.xml' path='doc/member[@name="SVSIF.SVSI_NOTAKEFOCUS"]/*' />
    SVSI_NOTAKEFOCUS = 0x40000000,
}
