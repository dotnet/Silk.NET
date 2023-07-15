// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='COSERVERINFO.xml' path='doc/member[@name="COSERVERINFO"]/*'/>
public unsafe partial struct COSERVERINFO
{
    /// <include file='COSERVERINFO.xml' path='doc/member[@name="COSERVERINFO.dwReserved1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved1;
    /// <include file='COSERVERINFO.xml' path='doc/member[@name="COSERVERINFO.pwszName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pwszName;
    /// <include file='COSERVERINFO.xml' path='doc/member[@name="COSERVERINFO.pAuthInfo"]/*'/>
    public COAUTHINFO* pAuthInfo;
    /// <include file='COSERVERINFO.xml' path='doc/member[@name="COSERVERINFO.dwReserved2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved2;
}