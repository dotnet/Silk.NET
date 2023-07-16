// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ProfInfo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PROFILEINFOA.xml' path='doc/member[@name="PROFILEINFOA"]/*'/>
public unsafe partial struct PROFILEINFOA
{
    /// <include file='PROFILEINFOA.xml' path='doc/member[@name="PROFILEINFOA.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='PROFILEINFOA.xml' path='doc/member[@name="PROFILEINFOA.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='PROFILEINFOA.xml' path='doc/member[@name="PROFILEINFOA.lpUserName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpUserName;
    /// <include file='PROFILEINFOA.xml' path='doc/member[@name="PROFILEINFOA.lpProfilePath"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpProfilePath;
    /// <include file='PROFILEINFOA.xml' path='doc/member[@name="PROFILEINFOA.lpDefaultPath"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpDefaultPath;
    /// <include file='PROFILEINFOA.xml' path='doc/member[@name="PROFILEINFOA.lpServerName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpServerName;
    /// <include file='PROFILEINFOA.xml' path='doc/member[@name="PROFILEINFOA.lpPolicyPath"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpPolicyPath;
    /// <include file='PROFILEINFOA.xml' path='doc/member[@name="PROFILEINFOA.hProfile"]/*'/>
    public HANDLE hProfile;
}