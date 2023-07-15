// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW"]/*'/>
public unsafe partial struct ICONINFOEXW
{
    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.fIcon"]/*'/>
    public BOOL fIcon;
    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.xHotspot"]/*'/>
    [NativeTypeName("DWORD")]
    public uint xHotspot;
    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.yHotspot"]/*'/>
    [NativeTypeName("DWORD")]
    public uint yHotspot;
    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.hbmMask"]/*'/>
    public HBITMAP hbmMask;
    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.hbmColor"]/*'/>
    public HBITMAP hbmColor;
    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.wResID"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wResID;
    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.szModName"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort szModName[260];
    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.szResName"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort szResName[260];
}