// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISCDLGSTRUCTA.xml' path='doc/member[@name="DISCDLGSTRUCTA"]/*'/>
public unsafe partial struct DISCDLGSTRUCTA
{
    /// <include file='DISCDLGSTRUCTA.xml' path='doc/member[@name="DISCDLGSTRUCTA.cbStructure"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStructure;
    /// <include file='DISCDLGSTRUCTA.xml' path='doc/member[@name="DISCDLGSTRUCTA.hwndOwner"]/*'/>
    public HWND hwndOwner;
    /// <include file='DISCDLGSTRUCTA.xml' path='doc/member[@name="DISCDLGSTRUCTA.lpLocalName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpLocalName;
    /// <include file='DISCDLGSTRUCTA.xml' path='doc/member[@name="DISCDLGSTRUCTA.lpRemoteName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpRemoteName;
    /// <include file='DISCDLGSTRUCTA.xml' path='doc/member[@name="DISCDLGSTRUCTA.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}