// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NEGOTIATE_PACKAGE_PREFIX.xml' path='doc/member[@name="NEGOTIATE_PACKAGE_PREFIX"]/*'/>
public unsafe partial struct NEGOTIATE_PACKAGE_PREFIX
{
    /// <include file='NEGOTIATE_PACKAGE_PREFIX.xml' path='doc/member[@name="NEGOTIATE_PACKAGE_PREFIX.PackageId"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint PackageId;
    /// <include file='NEGOTIATE_PACKAGE_PREFIX.xml' path='doc/member[@name="NEGOTIATE_PACKAGE_PREFIX.PackageDataA"]/*'/>
    [NativeTypeName("PVOID")]
    public void* PackageDataA;
    /// <include file='NEGOTIATE_PACKAGE_PREFIX.xml' path='doc/member[@name="NEGOTIATE_PACKAGE_PREFIX.PackageDataW"]/*'/>
    [NativeTypeName("PVOID")]
    public void* PackageDataW;
    /// <include file='NEGOTIATE_PACKAGE_PREFIX.xml' path='doc/member[@name="NEGOTIATE_PACKAGE_PREFIX.PrefixLen"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint PrefixLen;
    /// <include file='NEGOTIATE_PACKAGE_PREFIX.xml' path='doc/member[@name="NEGOTIATE_PACKAGE_PREFIX.Prefix"]/*'/>
    [NativeTypeName("UCHAR[32]")]
    public fixed byte Prefix[32];
}