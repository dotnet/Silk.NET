// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CONNECTDLGSTRUCTA.xml' path='doc/member[@name="CONNECTDLGSTRUCTA"]/*'/>
public unsafe partial struct CONNECTDLGSTRUCTA
{
    /// <include file='CONNECTDLGSTRUCTA.xml' path='doc/member[@name="CONNECTDLGSTRUCTA.cbStructure"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStructure;
    /// <include file='CONNECTDLGSTRUCTA.xml' path='doc/member[@name="CONNECTDLGSTRUCTA.hwndOwner"]/*'/>
    public HWND hwndOwner;
    /// <include file='CONNECTDLGSTRUCTA.xml' path='doc/member[@name="CONNECTDLGSTRUCTA.lpConnRes"]/*'/>
    [NativeTypeName("LPNETRESOURCEA")]
    public NETRESOURCEA* lpConnRes;
    /// <include file='CONNECTDLGSTRUCTA.xml' path='doc/member[@name="CONNECTDLGSTRUCTA.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='CONNECTDLGSTRUCTA.xml' path='doc/member[@name="CONNECTDLGSTRUCTA.dwDevNum"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDevNum;
}