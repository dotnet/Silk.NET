// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFP_ACQUIRE_USER_CREDENTIAL_EVENT.xml' path='doc/member[@name="MFP_ACQUIRE_USER_CREDENTIAL_EVENT"]/*'/>
public unsafe partial struct MFP_ACQUIRE_USER_CREDENTIAL_EVENT
{
    /// <include file='MFP_ACQUIRE_USER_CREDENTIAL_EVENT.xml' path='doc/member[@name="MFP_ACQUIRE_USER_CREDENTIAL_EVENT.header"]/*'/>
    public MFP_EVENT_HEADER header;
    /// <include file='MFP_ACQUIRE_USER_CREDENTIAL_EVENT.xml' path='doc/member[@name="MFP_ACQUIRE_USER_CREDENTIAL_EVENT.dwUserData"]/*'/>
    [NativeTypeName("DWORD_PTR")]
    public nuint dwUserData;
    /// <include file='MFP_ACQUIRE_USER_CREDENTIAL_EVENT.xml' path='doc/member[@name="MFP_ACQUIRE_USER_CREDENTIAL_EVENT.fProceedWithAuthentication"]/*'/>
    public BOOL fProceedWithAuthentication;
    /// <include file='MFP_ACQUIRE_USER_CREDENTIAL_EVENT.xml' path='doc/member[@name="MFP_ACQUIRE_USER_CREDENTIAL_EVENT.hrAuthenticationStatus"]/*'/>
    public HRESULT hrAuthenticationStatus;
    /// <include file='MFP_ACQUIRE_USER_CREDENTIAL_EVENT.xml' path='doc/member[@name="MFP_ACQUIRE_USER_CREDENTIAL_EVENT.pwszURL"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pwszURL;
    /// <include file='MFP_ACQUIRE_USER_CREDENTIAL_EVENT.xml' path='doc/member[@name="MFP_ACQUIRE_USER_CREDENTIAL_EVENT.pwszSite"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pwszSite;
    /// <include file='MFP_ACQUIRE_USER_CREDENTIAL_EVENT.xml' path='doc/member[@name="MFP_ACQUIRE_USER_CREDENTIAL_EVENT.pwszRealm"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pwszRealm;
    /// <include file='MFP_ACQUIRE_USER_CREDENTIAL_EVENT.xml' path='doc/member[@name="MFP_ACQUIRE_USER_CREDENTIAL_EVENT.pwszPackage"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pwszPackage;
    /// <include file='MFP_ACQUIRE_USER_CREDENTIAL_EVENT.xml' path='doc/member[@name="MFP_ACQUIRE_USER_CREDENTIAL_EVENT.nRetries"]/*'/>
    [NativeTypeName("LONG")]
    public int nRetries;
    /// <include file='MFP_ACQUIRE_USER_CREDENTIAL_EVENT.xml' path='doc/member[@name="MFP_ACQUIRE_USER_CREDENTIAL_EVENT.flags"]/*'/>
    [NativeTypeName("MFP_CREDENTIAL_FLAGS")]
    public uint flags;
    /// <include file='MFP_ACQUIRE_USER_CREDENTIAL_EVENT.xml' path='doc/member[@name="MFP_ACQUIRE_USER_CREDENTIAL_EVENT.pCredential"]/*'/>
    public IMFNetCredential* pCredential;
}