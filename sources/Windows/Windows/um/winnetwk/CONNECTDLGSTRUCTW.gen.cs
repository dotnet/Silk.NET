// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CONNECTDLGSTRUCTW.xml' path='doc/member[@name="CONNECTDLGSTRUCTW"]/*'/>
public unsafe partial struct CONNECTDLGSTRUCTW
{
    /// <include file='CONNECTDLGSTRUCTW.xml' path='doc/member[@name="CONNECTDLGSTRUCTW.cbStructure"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStructure;
    /// <include file='CONNECTDLGSTRUCTW.xml' path='doc/member[@name="CONNECTDLGSTRUCTW.hwndOwner"]/*'/>
    public HWND hwndOwner;
    /// <include file='CONNECTDLGSTRUCTW.xml' path='doc/member[@name="CONNECTDLGSTRUCTW.lpConnRes"]/*'/>
    [NativeTypeName("LPNETRESOURCEW")]
    public NETRESOURCEW* lpConnRes;
    /// <include file='CONNECTDLGSTRUCTW.xml' path='doc/member[@name="CONNECTDLGSTRUCTW.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='CONNECTDLGSTRUCTW.xml' path='doc/member[@name="CONNECTDLGSTRUCTW.dwDevNum"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDevNum;
}