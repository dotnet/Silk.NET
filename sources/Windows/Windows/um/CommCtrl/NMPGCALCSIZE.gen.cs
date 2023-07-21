// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMPGCALCSIZE.xml' path='doc/member[@name="NMPGCALCSIZE"]/*' />
public partial struct NMPGCALCSIZE
{
    /// <include file='NMPGCALCSIZE.xml' path='doc/member[@name="NMPGCALCSIZE.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMPGCALCSIZE.xml' path='doc/member[@name="NMPGCALCSIZE.dwFlag"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlag;

    /// <include file='NMPGCALCSIZE.xml' path='doc/member[@name="NMPGCALCSIZE.iWidth"]/*' />
    public int iWidth;

    /// <include file='NMPGCALCSIZE.xml' path='doc/member[@name="NMPGCALCSIZE.iHeight"]/*' />
    public int iHeight;
}
