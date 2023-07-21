// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DETAILSINFO.xml' path='doc/member[@name="DETAILSINFO"]/*' />
public unsafe partial struct DETAILSINFO
{
    /// <include file='DETAILSINFO.xml' path='doc/member[@name="DETAILSINFO.pidl"]/*' />
    [NativeTypeName("LPCITEMIDLIST")]
    public ITEMIDLIST* pidl;

    /// <include file='DETAILSINFO.xml' path='doc/member[@name="DETAILSINFO.fmt"]/*' />
    public int fmt;

    /// <include file='DETAILSINFO.xml' path='doc/member[@name="DETAILSINFO.cxChar"]/*' />
    public int cxChar;

    /// <include file='DETAILSINFO.xml' path='doc/member[@name="DETAILSINFO.str"]/*' />
    public STRRET str;

    /// <include file='DETAILSINFO.xml' path='doc/member[@name="DETAILSINFO.iImage"]/*' />
    public int iImage;
}
