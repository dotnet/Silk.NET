// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='DLGITEMTEMPLATE.xml' path='doc/member[@name="DLGITEMTEMPLATE"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct DLGITEMTEMPLATE
{
    /// <include file='DLGITEMTEMPLATE.xml' path='doc/member[@name="DLGITEMTEMPLATE.style"]/*'/>
    [NativeTypeName("DWORD")]
    public uint style;
    /// <include file='DLGITEMTEMPLATE.xml' path='doc/member[@name="DLGITEMTEMPLATE.dwExtendedStyle"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwExtendedStyle;
    /// <include file='DLGITEMTEMPLATE.xml' path='doc/member[@name="DLGITEMTEMPLATE.x"]/*'/>
    public short x;
    /// <include file='DLGITEMTEMPLATE.xml' path='doc/member[@name="DLGITEMTEMPLATE.y"]/*'/>
    public short y;
    /// <include file='DLGITEMTEMPLATE.xml' path='doc/member[@name="DLGITEMTEMPLATE.cx"]/*'/>
    public short cx;
    /// <include file='DLGITEMTEMPLATE.xml' path='doc/member[@name="DLGITEMTEMPLATE.cy"]/*'/>
    public short cy;
    /// <include file='DLGITEMTEMPLATE.xml' path='doc/member[@name="DLGITEMTEMPLATE.id"]/*'/>
    [NativeTypeName("WORD")]
    public ushort id;
}