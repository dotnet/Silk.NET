// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OPPROGDLGF.xml' path='doc/member[@name="OPPROGDLGF"]/*' />
public enum OPPROGDLGF
{
    /// <include file='OPPROGDLGF.xml' path='doc/member[@name="OPPROGDLGF.OPPROGDLG_DEFAULT"]/*' />
    OPPROGDLG_DEFAULT = 0,

    /// <include file='OPPROGDLGF.xml' path='doc/member[@name="OPPROGDLGF.OPPROGDLG_ENABLEPAUSE"]/*' />
    OPPROGDLG_ENABLEPAUSE = 0x80,

    /// <include file='OPPROGDLGF.xml' path='doc/member[@name="OPPROGDLGF.OPPROGDLG_ALLOWUNDO"]/*' />
    OPPROGDLG_ALLOWUNDO = 0x100,

    /// <include file='OPPROGDLGF.xml' path='doc/member[@name="OPPROGDLGF.OPPROGDLG_DONTDISPLAYSOURCEPATH"]/*' />
    OPPROGDLG_DONTDISPLAYSOURCEPATH = 0x200,

    /// <include file='OPPROGDLGF.xml' path='doc/member[@name="OPPROGDLGF.OPPROGDLG_DONTDISPLAYDESTPATH"]/*' />
    OPPROGDLG_DONTDISPLAYDESTPATH = 0x400,

    /// <include file='OPPROGDLGF.xml' path='doc/member[@name="OPPROGDLGF.OPPROGDLG_NOMULTIDAYESTIMATES"]/*' />
    OPPROGDLG_NOMULTIDAYESTIMATES = 0x800,

    /// <include file='OPPROGDLGF.xml' path='doc/member[@name="OPPROGDLGF.OPPROGDLG_DONTDISPLAYLOCATIONS"]/*' />
    OPPROGDLG_DONTDISPLAYLOCATIONS = 0x1000,
}
