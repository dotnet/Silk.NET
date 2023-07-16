// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DLGTEMPLATE.xml' path='doc/member[@name="DLGTEMPLATE"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct DLGTEMPLATE
{
    /// <include file='DLGTEMPLATE.xml' path='doc/member[@name="DLGTEMPLATE.style"]/*'/>
    [NativeTypeName("DWORD")]
    public uint style;
    /// <include file='DLGTEMPLATE.xml' path='doc/member[@name="DLGTEMPLATE.dwExtendedStyle"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwExtendedStyle;
    /// <include file='DLGTEMPLATE.xml' path='doc/member[@name="DLGTEMPLATE.cdit"]/*'/>
    [NativeTypeName("WORD")]
    public ushort cdit;
    /// <include file='DLGTEMPLATE.xml' path='doc/member[@name="DLGTEMPLATE.x"]/*'/>
    public short x;
    /// <include file='DLGTEMPLATE.xml' path='doc/member[@name="DLGTEMPLATE.y"]/*'/>
    public short y;
    /// <include file='DLGTEMPLATE.xml' path='doc/member[@name="DLGTEMPLATE.cx"]/*'/>
    public short cx;
    /// <include file='DLGTEMPLATE.xml' path='doc/member[@name="DLGTEMPLATE.cy"]/*'/>
    public short cy;
}