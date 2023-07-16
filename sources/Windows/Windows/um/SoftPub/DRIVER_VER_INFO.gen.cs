// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DRIVER_VER_INFO.xml' path='doc/member[@name="DRIVER_VER_INFO"]/*'/>
public unsafe partial struct DRIVER_VER_INFO
{
    /// <include file='DRIVER_VER_INFO.xml' path='doc/member[@name="DRIVER_VER_INFO.cbStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    /// <include file='DRIVER_VER_INFO.xml' path='doc/member[@name="DRIVER_VER_INFO.dwReserved1"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint dwReserved1;
    /// <include file='DRIVER_VER_INFO.xml' path='doc/member[@name="DRIVER_VER_INFO.dwReserved2"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint dwReserved2;
    /// <include file='DRIVER_VER_INFO.xml' path='doc/member[@name="DRIVER_VER_INFO.dwPlatform"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPlatform;
    /// <include file='DRIVER_VER_INFO.xml' path='doc/member[@name="DRIVER_VER_INFO.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='DRIVER_VER_INFO.xml' path='doc/member[@name="DRIVER_VER_INFO.wszVersion"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort wszVersion[260];
    /// <include file='DRIVER_VER_INFO.xml' path='doc/member[@name="DRIVER_VER_INFO.wszSignedBy"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort wszSignedBy[260];
    /// <include file='DRIVER_VER_INFO.xml' path='doc/member[@name="DRIVER_VER_INFO.pcSignerCertContext"]/*'/>
    [NativeTypeName("PCCERT_CONTEXT")]
    public CERT_CONTEXT* pcSignerCertContext;
    /// <include file='DRIVER_VER_INFO.xml' path='doc/member[@name="DRIVER_VER_INFO.sOSVersionLow"]/*'/>
    public DRIVER_VER_MAJORMINOR sOSVersionLow;
    /// <include file='DRIVER_VER_INFO.xml' path='doc/member[@name="DRIVER_VER_INFO.sOSVersionHigh"]/*'/>
    public DRIVER_VER_MAJORMINOR sOSVersionHigh;
    /// <include file='DRIVER_VER_INFO.xml' path='doc/member[@name="DRIVER_VER_INFO.dwBuildNumberLow"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBuildNumberLow;
    /// <include file='DRIVER_VER_INFO.xml' path='doc/member[@name="DRIVER_VER_INFO.dwBuildNumberHigh"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBuildNumberHigh;
}