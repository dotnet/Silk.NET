// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Cpl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct NEWCPLINFOW
{
    /// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW.dwHelpContext"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwHelpContext;
    /// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW.lData"]/*'/>
    [NativeTypeName("LONG_PTR")]
    public nint lData;
    /// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW.hIcon"]/*'/>
    public HICON hIcon;
    /// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW.szName"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort szName[32];
    /// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW.szInfo"]/*'/>
    [NativeTypeName("WCHAR[64]")]
    public fixed ushort szInfo[64];
    /// <include file='NEWCPLINFOW.xml' path='doc/member[@name="NEWCPLINFOW.szHelpFile"]/*'/>
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort szHelpFile[128];
}