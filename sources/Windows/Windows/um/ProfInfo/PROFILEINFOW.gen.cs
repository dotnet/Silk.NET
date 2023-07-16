// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ProfInfo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PROFILEINFOW.xml' path='doc/member[@name="PROFILEINFOW"]/*'/>
public unsafe partial struct PROFILEINFOW
{
    /// <include file='PROFILEINFOW.xml' path='doc/member[@name="PROFILEINFOW.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='PROFILEINFOW.xml' path='doc/member[@name="PROFILEINFOW.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='PROFILEINFOW.xml' path='doc/member[@name="PROFILEINFOW.lpUserName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpUserName;
    /// <include file='PROFILEINFOW.xml' path='doc/member[@name="PROFILEINFOW.lpProfilePath"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpProfilePath;
    /// <include file='PROFILEINFOW.xml' path='doc/member[@name="PROFILEINFOW.lpDefaultPath"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpDefaultPath;
    /// <include file='PROFILEINFOW.xml' path='doc/member[@name="PROFILEINFOW.lpServerName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpServerName;
    /// <include file='PROFILEINFOW.xml' path='doc/member[@name="PROFILEINFOW.lpPolicyPath"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpPolicyPath;
    /// <include file='PROFILEINFOW.xml' path='doc/member[@name="PROFILEINFOW.hProfile"]/*'/>
    public HANDLE hProfile;
}