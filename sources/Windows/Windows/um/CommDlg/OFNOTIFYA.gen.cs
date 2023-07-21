// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OFNOTIFYA.xml' path='doc/member[@name="OFNOTIFYA"]/*' />
public unsafe partial struct OFNOTIFYA
{
    /// <include file='OFNOTIFYA.xml' path='doc/member[@name="OFNOTIFYA.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='OFNOTIFYA.xml' path='doc/member[@name="OFNOTIFYA.lpOFN"]/*' />
    [NativeTypeName("LPOPENFILENAMEA")]
    public OPENFILENAMEA* lpOFN;

    /// <include file='OFNOTIFYA.xml' path='doc/member[@name="OFNOTIFYA.pszFile"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszFile;
}
