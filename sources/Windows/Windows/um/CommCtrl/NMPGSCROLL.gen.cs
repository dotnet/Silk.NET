// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='NMPGSCROLL.xml' path='doc/member[@name="NMPGSCROLL"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct NMPGSCROLL
{
    /// <include file='NMPGSCROLL.xml' path='doc/member[@name="NMPGSCROLL.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMPGSCROLL.xml' path='doc/member[@name="NMPGSCROLL.fwKeys"]/*' />
    [NativeTypeName("WORD")]
    public ushort fwKeys;

    /// <include file='NMPGSCROLL.xml' path='doc/member[@name="NMPGSCROLL.rcParent"]/*' />
    public RECT rcParent;

    /// <include file='NMPGSCROLL.xml' path='doc/member[@name="NMPGSCROLL.iDir"]/*' />
    public int iDir;

    /// <include file='NMPGSCROLL.xml' path='doc/member[@name="NMPGSCROLL.iXpos"]/*' />
    public int iXpos;

    /// <include file='NMPGSCROLL.xml' path='doc/member[@name="NMPGSCROLL.iYpos"]/*' />
    public int iYpos;

    /// <include file='NMPGSCROLL.xml' path='doc/member[@name="NMPGSCROLL.iScroll"]/*' />
    public int iScroll;
}
