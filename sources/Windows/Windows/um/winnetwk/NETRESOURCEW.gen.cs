// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NETRESOURCEW.xml' path='doc/member[@name="NETRESOURCEW"]/*'/>
public unsafe partial struct NETRESOURCEW
{
    /// <include file='NETRESOURCEW.xml' path='doc/member[@name="NETRESOURCEW.dwScope"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwScope;
    /// <include file='NETRESOURCEW.xml' path='doc/member[@name="NETRESOURCEW.dwType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwType;
    /// <include file='NETRESOURCEW.xml' path='doc/member[@name="NETRESOURCEW.dwDisplayType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDisplayType;
    /// <include file='NETRESOURCEW.xml' path='doc/member[@name="NETRESOURCEW.dwUsage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwUsage;
    /// <include file='NETRESOURCEW.xml' path='doc/member[@name="NETRESOURCEW.lpLocalName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpLocalName;
    /// <include file='NETRESOURCEW.xml' path='doc/member[@name="NETRESOURCEW.lpRemoteName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpRemoteName;
    /// <include file='NETRESOURCEW.xml' path='doc/member[@name="NETRESOURCEW.lpComment"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpComment;
    /// <include file='NETRESOURCEW.xml' path='doc/member[@name="NETRESOURCEW.lpProvider"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpProvider;
}