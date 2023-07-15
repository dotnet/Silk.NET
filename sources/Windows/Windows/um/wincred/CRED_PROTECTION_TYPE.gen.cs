// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRED_PROTECTION_TYPE.xml' path='doc/member[@name="CRED_PROTECTION_TYPE"]/*'/>
public enum CRED_PROTECTION_TYPE
{
    /// <include file='CRED_PROTECTION_TYPE.xml' path='doc/member[@name="CRED_PROTECTION_TYPE.CredUnprotected"]/*'/>
    CredUnprotected,
    /// <include file='CRED_PROTECTION_TYPE.xml' path='doc/member[@name="CRED_PROTECTION_TYPE.CredUserProtection"]/*'/>
    CredUserProtection,
    /// <include file='CRED_PROTECTION_TYPE.xml' path='doc/member[@name="CRED_PROTECTION_TYPE.CredTrustedProtection"]/*'/>
    CredTrustedProtection,
    /// <include file='CRED_PROTECTION_TYPE.xml' path='doc/member[@name="CRED_PROTECTION_TYPE.CredForSystemProtection"]/*'/>
    CredForSystemProtection,
}