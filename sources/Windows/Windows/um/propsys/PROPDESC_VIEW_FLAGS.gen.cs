// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='PROPDESC_VIEW_FLAGS.xml' path='doc/member[@name="PROPDESC_VIEW_FLAGS"]/*' />
[Flags]
public enum PROPDESC_VIEW_FLAGS
{
    /// <include file='PROPDESC_VIEW_FLAGS.xml' path='doc/member[@name="PROPDESC_VIEW_FLAGS.PDVF_DEFAULT"]/*' />
    PDVF_DEFAULT = 0,

    /// <include file='PROPDESC_VIEW_FLAGS.xml' path='doc/member[@name="PROPDESC_VIEW_FLAGS.PDVF_CENTERALIGN"]/*' />
    PDVF_CENTERALIGN = 0x1,

    /// <include file='PROPDESC_VIEW_FLAGS.xml' path='doc/member[@name="PROPDESC_VIEW_FLAGS.PDVF_RIGHTALIGN"]/*' />
    PDVF_RIGHTALIGN = 0x2,

    /// <include file='PROPDESC_VIEW_FLAGS.xml' path='doc/member[@name="PROPDESC_VIEW_FLAGS.PDVF_BEGINNEWGROUP"]/*' />
    PDVF_BEGINNEWGROUP = 0x4,

    /// <include file='PROPDESC_VIEW_FLAGS.xml' path='doc/member[@name="PROPDESC_VIEW_FLAGS.PDVF_FILLAREA"]/*' />
    PDVF_FILLAREA = 0x8,

    /// <include file='PROPDESC_VIEW_FLAGS.xml' path='doc/member[@name="PROPDESC_VIEW_FLAGS.PDVF_SORTDESCENDING"]/*' />
    PDVF_SORTDESCENDING = 0x10,

    /// <include file='PROPDESC_VIEW_FLAGS.xml' path='doc/member[@name="PROPDESC_VIEW_FLAGS.PDVF_SHOWONLYIFPRESENT"]/*' />
    PDVF_SHOWONLYIFPRESENT = 0x20,

    /// <include file='PROPDESC_VIEW_FLAGS.xml' path='doc/member[@name="PROPDESC_VIEW_FLAGS.PDVF_SHOWBYDEFAULT"]/*' />
    PDVF_SHOWBYDEFAULT = 0x40,

    /// <include file='PROPDESC_VIEW_FLAGS.xml' path='doc/member[@name="PROPDESC_VIEW_FLAGS.PDVF_SHOWINPRIMARYLIST"]/*' />
    PDVF_SHOWINPRIMARYLIST = 0x80,

    /// <include file='PROPDESC_VIEW_FLAGS.xml' path='doc/member[@name="PROPDESC_VIEW_FLAGS.PDVF_SHOWINSECONDARYLIST"]/*' />
    PDVF_SHOWINSECONDARYLIST = 0x100,

    /// <include file='PROPDESC_VIEW_FLAGS.xml' path='doc/member[@name="PROPDESC_VIEW_FLAGS.PDVF_HIDELABEL"]/*' />
    PDVF_HIDELABEL = 0x200,

    /// <include file='PROPDESC_VIEW_FLAGS.xml' path='doc/member[@name="PROPDESC_VIEW_FLAGS.PDVF_HIDDEN"]/*' />
    PDVF_HIDDEN = 0x800,

    /// <include file='PROPDESC_VIEW_FLAGS.xml' path='doc/member[@name="PROPDESC_VIEW_FLAGS.PDVF_CANWRAP"]/*' />
    PDVF_CANWRAP = 0x1000,

    /// <include file='PROPDESC_VIEW_FLAGS.xml' path='doc/member[@name="PROPDESC_VIEW_FLAGS.PDVF_MASK_ALL"]/*' />
    PDVF_MASK_ALL = 0x1bff,
}
