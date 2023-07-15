// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA"]/*'/>
public unsafe partial struct ICONINFOEXA
{
    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.fIcon"]/*'/>
    public BOOL fIcon;
    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.xHotspot"]/*'/>
    [NativeTypeName("DWORD")]
    public uint xHotspot;
    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.yHotspot"]/*'/>
    [NativeTypeName("DWORD")]
    public uint yHotspot;
    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.hbmMask"]/*'/>
    public HBITMAP hbmMask;
    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.hbmColor"]/*'/>
    public HBITMAP hbmColor;
    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.wResID"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wResID;
    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.szModName"]/*'/>
    [NativeTypeName("CHAR[260]")]
    public fixed sbyte szModName[260];
    /// <include file='ICONINFOEXA.xml' path='doc/member[@name="ICONINFOEXA.szResName"]/*'/>
    [NativeTypeName("CHAR[260]")]
    public fixed sbyte szResName[260];
}