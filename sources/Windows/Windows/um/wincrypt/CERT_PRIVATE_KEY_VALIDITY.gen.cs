// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_PRIVATE_KEY_VALIDITY.xml' path='doc/member[@name="CERT_PRIVATE_KEY_VALIDITY"]/*'/>
public partial struct CERT_PRIVATE_KEY_VALIDITY
{
    /// <include file='CERT_PRIVATE_KEY_VALIDITY.xml' path='doc/member[@name="CERT_PRIVATE_KEY_VALIDITY.NotBefore"]/*'/>
    public FILETIME NotBefore;
    /// <include file='CERT_PRIVATE_KEY_VALIDITY.xml' path='doc/member[@name="CERT_PRIVATE_KEY_VALIDITY.NotAfter"]/*'/>
    public FILETIME NotAfter;
}