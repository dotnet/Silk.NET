// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISCDLGSTRUCTW.xml' path='doc/member[@name="DISCDLGSTRUCTW"]/*'/>
public unsafe partial struct DISCDLGSTRUCTW
{
    /// <include file='DISCDLGSTRUCTW.xml' path='doc/member[@name="DISCDLGSTRUCTW.cbStructure"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStructure;
    /// <include file='DISCDLGSTRUCTW.xml' path='doc/member[@name="DISCDLGSTRUCTW.hwndOwner"]/*'/>
    public HWND hwndOwner;
    /// <include file='DISCDLGSTRUCTW.xml' path='doc/member[@name="DISCDLGSTRUCTW.lpLocalName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpLocalName;
    /// <include file='DISCDLGSTRUCTW.xml' path='doc/member[@name="DISCDLGSTRUCTW.lpRemoteName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpRemoteName;
    /// <include file='DISCDLGSTRUCTW.xml' path='doc/member[@name="DISCDLGSTRUCTW.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}