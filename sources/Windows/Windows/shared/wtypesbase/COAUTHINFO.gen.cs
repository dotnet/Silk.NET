// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='COAUTHINFO.xml' path='doc/member[@name="COAUTHINFO"]/*'/>
public unsafe partial struct COAUTHINFO
{
    /// <include file='COAUTHINFO.xml' path='doc/member[@name="COAUTHINFO.dwAuthnSvc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAuthnSvc;
    /// <include file='COAUTHINFO.xml' path='doc/member[@name="COAUTHINFO.dwAuthzSvc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAuthzSvc;
    /// <include file='COAUTHINFO.xml' path='doc/member[@name="COAUTHINFO.pwszServerPrincName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pwszServerPrincName;
    /// <include file='COAUTHINFO.xml' path='doc/member[@name="COAUTHINFO.dwAuthnLevel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAuthnLevel;
    /// <include file='COAUTHINFO.xml' path='doc/member[@name="COAUTHINFO.dwImpersonationLevel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwImpersonationLevel;
    /// <include file='COAUTHINFO.xml' path='doc/member[@name="COAUTHINFO.pAuthIdentityData"]/*'/>
    public COAUTHIDENTITY* pAuthIdentityData;
    /// <include file='COAUTHINFO.xml' path='doc/member[@name="COAUTHINFO.dwCapabilities"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCapabilities;
}