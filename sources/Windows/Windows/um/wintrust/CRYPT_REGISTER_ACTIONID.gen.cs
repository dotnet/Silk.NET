// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_REGISTER_ACTIONID.xml' path='doc/member[@name="CRYPT_REGISTER_ACTIONID"]/*'/>
public partial struct CRYPT_REGISTER_ACTIONID
{
    /// <include file='CRYPT_REGISTER_ACTIONID.xml' path='doc/member[@name="CRYPT_REGISTER_ACTIONID.cbStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    /// <include file='CRYPT_REGISTER_ACTIONID.xml' path='doc/member[@name="CRYPT_REGISTER_ACTIONID.sInitProvider"]/*'/>
    public CRYPT_TRUST_REG_ENTRY sInitProvider;
    /// <include file='CRYPT_REGISTER_ACTIONID.xml' path='doc/member[@name="CRYPT_REGISTER_ACTIONID.sObjectProvider"]/*'/>
    public CRYPT_TRUST_REG_ENTRY sObjectProvider;
    /// <include file='CRYPT_REGISTER_ACTIONID.xml' path='doc/member[@name="CRYPT_REGISTER_ACTIONID.sSignatureProvider"]/*'/>
    public CRYPT_TRUST_REG_ENTRY sSignatureProvider;
    /// <include file='CRYPT_REGISTER_ACTIONID.xml' path='doc/member[@name="CRYPT_REGISTER_ACTIONID.sCertificateProvider"]/*'/>
    public CRYPT_TRUST_REG_ENTRY sCertificateProvider;
    /// <include file='CRYPT_REGISTER_ACTIONID.xml' path='doc/member[@name="CRYPT_REGISTER_ACTIONID.sCertificatePolicyProvider"]/*'/>
    public CRYPT_TRUST_REG_ENTRY sCertificatePolicyProvider;
    /// <include file='CRYPT_REGISTER_ACTIONID.xml' path='doc/member[@name="CRYPT_REGISTER_ACTIONID.sFinalPolicyProvider"]/*'/>
    public CRYPT_TRUST_REG_ENTRY sFinalPolicyProvider;
    /// <include file='CRYPT_REGISTER_ACTIONID.xml' path='doc/member[@name="CRYPT_REGISTER_ACTIONID.sTestPolicyProvider"]/*'/>
    public CRYPT_TRUST_REG_ENTRY sTestPolicyProvider;
    /// <include file='CRYPT_REGISTER_ACTIONID.xml' path='doc/member[@name="CRYPT_REGISTER_ACTIONID.sCleanupProvider"]/*'/>
    public CRYPT_TRUST_REG_ENTRY sCleanupProvider;
}