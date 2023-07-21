// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NSTCCUSTOMDRAW.xml' path='doc/member[@name="NSTCCUSTOMDRAW"]/*' />
public unsafe partial struct NSTCCUSTOMDRAW
{
    /// <include file='NSTCCUSTOMDRAW.xml' path='doc/member[@name="NSTCCUSTOMDRAW.psi"]/*' />
    public IShellItem* psi;

    /// <include file='NSTCCUSTOMDRAW.xml' path='doc/member[@name="NSTCCUSTOMDRAW.uItemState"]/*' />
    public uint uItemState;

    /// <include file='NSTCCUSTOMDRAW.xml' path='doc/member[@name="NSTCCUSTOMDRAW.nstcis"]/*' />
    [NativeTypeName("NSTCITEMSTATE")]
    public uint nstcis;

    /// <include file='NSTCCUSTOMDRAW.xml' path='doc/member[@name="NSTCCUSTOMDRAW.pszText"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pszText;

    /// <include file='NSTCCUSTOMDRAW.xml' path='doc/member[@name="NSTCCUSTOMDRAW.iImage"]/*' />
    public int iImage;

    /// <include file='NSTCCUSTOMDRAW.xml' path='doc/member[@name="NSTCCUSTOMDRAW.himl"]/*' />
    public HIMAGELIST himl;

    /// <include file='NSTCCUSTOMDRAW.xml' path='doc/member[@name="NSTCCUSTOMDRAW.iLevel"]/*' />
    public int iLevel;

    /// <include file='NSTCCUSTOMDRAW.xml' path='doc/member[@name="NSTCCUSTOMDRAW.iIndent"]/*' />
    public int iIndent;
}
