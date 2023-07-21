// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TBBUTTONINFOA.xml' path='doc/member[@name="TBBUTTONINFOA"]/*' />
public unsafe partial struct TBBUTTONINFOA
{
    /// <include file='TBBUTTONINFOA.xml' path='doc/member[@name="TBBUTTONINFOA.cbSize"]/*' />
    public uint cbSize;

    /// <include file='TBBUTTONINFOA.xml' path='doc/member[@name="TBBUTTONINFOA.dwMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMask;

    /// <include file='TBBUTTONINFOA.xml' path='doc/member[@name="TBBUTTONINFOA.idCommand"]/*' />
    public int idCommand;

    /// <include file='TBBUTTONINFOA.xml' path='doc/member[@name="TBBUTTONINFOA.iImage"]/*' />
    public int iImage;

    /// <include file='TBBUTTONINFOA.xml' path='doc/member[@name="TBBUTTONINFOA.fsState"]/*' />
    public byte fsState;

    /// <include file='TBBUTTONINFOA.xml' path='doc/member[@name="TBBUTTONINFOA.fsStyle"]/*' />
    public byte fsStyle;

    /// <include file='TBBUTTONINFOA.xml' path='doc/member[@name="TBBUTTONINFOA.cx"]/*' />
    [NativeTypeName("WORD")]
    public ushort cx;

    /// <include file='TBBUTTONINFOA.xml' path='doc/member[@name="TBBUTTONINFOA.lParam"]/*' />
    [NativeTypeName("DWORD_PTR")]
    public nuint lParam;

    /// <include file='TBBUTTONINFOA.xml' path='doc/member[@name="TBBUTTONINFOA.pszText"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszText;

    /// <include file='TBBUTTONINFOA.xml' path='doc/member[@name="TBBUTTONINFOA.cchText"]/*' />
    public int cchText;
}
