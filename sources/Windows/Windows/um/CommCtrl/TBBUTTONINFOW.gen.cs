// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TBBUTTONINFOW.xml' path='doc/member[@name="TBBUTTONINFOW"]/*'/>
public unsafe partial struct TBBUTTONINFOW
{
    /// <include file='TBBUTTONINFOW.xml' path='doc/member[@name="TBBUTTONINFOW.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='TBBUTTONINFOW.xml' path='doc/member[@name="TBBUTTONINFOW.dwMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMask;
    /// <include file='TBBUTTONINFOW.xml' path='doc/member[@name="TBBUTTONINFOW.idCommand"]/*'/>
    public int idCommand;
    /// <include file='TBBUTTONINFOW.xml' path='doc/member[@name="TBBUTTONINFOW.iImage"]/*'/>
    public int iImage;
    /// <include file='TBBUTTONINFOW.xml' path='doc/member[@name="TBBUTTONINFOW.fsState"]/*'/>
    public byte fsState;
    /// <include file='TBBUTTONINFOW.xml' path='doc/member[@name="TBBUTTONINFOW.fsStyle"]/*'/>
    public byte fsStyle;
    /// <include file='TBBUTTONINFOW.xml' path='doc/member[@name="TBBUTTONINFOW.cx"]/*'/>
    [NativeTypeName("WORD")]
    public ushort cx;
    /// <include file='TBBUTTONINFOW.xml' path='doc/member[@name="TBBUTTONINFOW.lParam"]/*'/>
    [NativeTypeName("DWORD_PTR")]
    public nuint lParam;
    /// <include file='TBBUTTONINFOW.xml' path='doc/member[@name="TBBUTTONINFOW.pszText"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;
    /// <include file='TBBUTTONINFOW.xml' path='doc/member[@name="TBBUTTONINFOW.cchText"]/*'/>
    public int cchText;
}