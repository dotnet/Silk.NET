// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NSTCEHITTEST.xml' path='doc/member[@name="NSTCEHITTEST"]/*' />
public enum NSTCEHITTEST
{
    /// <include file='NSTCEHITTEST.xml' path='doc/member[@name="NSTCEHITTEST.NSTCEHT_NOWHERE"]/*' />
    NSTCEHT_NOWHERE = 0x1,

    /// <include file='NSTCEHITTEST.xml' path='doc/member[@name="NSTCEHITTEST.NSTCEHT_ONITEMICON"]/*' />
    NSTCEHT_ONITEMICON = 0x2,

    /// <include file='NSTCEHITTEST.xml' path='doc/member[@name="NSTCEHITTEST.NSTCEHT_ONITEMLABEL"]/*' />
    NSTCEHT_ONITEMLABEL = 0x4,

    /// <include file='NSTCEHITTEST.xml' path='doc/member[@name="NSTCEHITTEST.NSTCEHT_ONITEMINDENT"]/*' />
    NSTCEHT_ONITEMINDENT = 0x8,

    /// <include file='NSTCEHITTEST.xml' path='doc/member[@name="NSTCEHITTEST.NSTCEHT_ONITEMBUTTON"]/*' />
    NSTCEHT_ONITEMBUTTON = 0x10,

    /// <include file='NSTCEHITTEST.xml' path='doc/member[@name="NSTCEHITTEST.NSTCEHT_ONITEMRIGHT"]/*' />
    NSTCEHT_ONITEMRIGHT = 0x20,

    /// <include file='NSTCEHITTEST.xml' path='doc/member[@name="NSTCEHITTEST.NSTCEHT_ONITEMSTATEICON"]/*' />
    NSTCEHT_ONITEMSTATEICON = 0x40,

    /// <include file='NSTCEHITTEST.xml' path='doc/member[@name="NSTCEHITTEST.NSTCEHT_ONITEM"]/*' />
    NSTCEHT_ONITEM = 0x46,

    /// <include file='NSTCEHITTEST.xml' path='doc/member[@name="NSTCEHITTEST.NSTCEHT_ONITEMTABBUTTON"]/*' />
    NSTCEHT_ONITEMTABBUTTON = 0x1000,
}
