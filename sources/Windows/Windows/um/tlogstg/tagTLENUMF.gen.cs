// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tlogstg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='tagTLENUMF.xml' path='doc/member[@name="tagTLENUMF"]/*' />
public enum tagTLENUMF
{
    /// <include file='tagTLENUMF.xml' path='doc/member[@name="tagTLENUMF.TLEF_RELATIVE_INCLUDE_CURRENT"]/*' />
    TLEF_RELATIVE_INCLUDE_CURRENT = 0x1,

    /// <include file='tagTLENUMF.xml' path='doc/member[@name="tagTLENUMF.TLEF_RELATIVE_BACK"]/*' />
    TLEF_RELATIVE_BACK = 0x10,

    /// <include file='tagTLENUMF.xml' path='doc/member[@name="tagTLENUMF.TLEF_RELATIVE_FORE"]/*' />
    TLEF_RELATIVE_FORE = 0x20,

    /// <include file='tagTLENUMF.xml' path='doc/member[@name="tagTLENUMF.TLEF_INCLUDE_UNINVOKEABLE"]/*' />
    TLEF_INCLUDE_UNINVOKEABLE = 0x40,

    /// <include file='tagTLENUMF.xml' path='doc/member[@name="tagTLENUMF.TLEF_ABSOLUTE"]/*' />
    TLEF_ABSOLUTE = 0x31,

    /// <include file='tagTLENUMF.xml' path='doc/member[@name="tagTLENUMF.TLEF_EXCLUDE_SUBFRAME_ENTRIES"]/*' />
    TLEF_EXCLUDE_SUBFRAME_ENTRIES = 0x80,

    /// <include file='tagTLENUMF.xml' path='doc/member[@name="tagTLENUMF.TLEF_EXCLUDE_ABOUT_PAGES"]/*' />
    TLEF_EXCLUDE_ABOUT_PAGES = 0x100,
}
