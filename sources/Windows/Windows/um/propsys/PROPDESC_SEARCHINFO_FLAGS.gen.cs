// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='PROPDESC_SEARCHINFO_FLAGS.xml' path='doc/member[@name="PROPDESC_SEARCHINFO_FLAGS"]/*' />
[Flags]
public enum PROPDESC_SEARCHINFO_FLAGS
{
    /// <include file='PROPDESC_SEARCHINFO_FLAGS.xml' path='doc/member[@name="PROPDESC_SEARCHINFO_FLAGS.PDSIF_DEFAULT"]/*' />
    PDSIF_DEFAULT = 0,

    /// <include file='PROPDESC_SEARCHINFO_FLAGS.xml' path='doc/member[@name="PROPDESC_SEARCHINFO_FLAGS.PDSIF_ININVERTEDINDEX"]/*' />
    PDSIF_ININVERTEDINDEX = 0x1,

    /// <include file='PROPDESC_SEARCHINFO_FLAGS.xml' path='doc/member[@name="PROPDESC_SEARCHINFO_FLAGS.PDSIF_ISCOLUMN"]/*' />
    PDSIF_ISCOLUMN = 0x2,

    /// <include file='PROPDESC_SEARCHINFO_FLAGS.xml' path='doc/member[@name="PROPDESC_SEARCHINFO_FLAGS.PDSIF_ISCOLUMNSPARSE"]/*' />
    PDSIF_ISCOLUMNSPARSE = 0x4,

    /// <include file='PROPDESC_SEARCHINFO_FLAGS.xml' path='doc/member[@name="PROPDESC_SEARCHINFO_FLAGS.PDSIF_ALWAYSINCLUDE"]/*' />
    PDSIF_ALWAYSINCLUDE = 0x8,

    /// <include file='PROPDESC_SEARCHINFO_FLAGS.xml' path='doc/member[@name="PROPDESC_SEARCHINFO_FLAGS.PDSIF_USEFORTYPEAHEAD"]/*' />
    PDSIF_USEFORTYPEAHEAD = 0x10,
}
