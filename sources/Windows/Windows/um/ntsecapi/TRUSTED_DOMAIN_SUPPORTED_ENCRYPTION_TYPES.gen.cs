// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TRUSTED_DOMAIN_SUPPORTED_ENCRYPTION_TYPES.xml' path='doc/member[@name="TRUSTED_DOMAIN_SUPPORTED_ENCRYPTION_TYPES"]/*'/>
public partial struct TRUSTED_DOMAIN_SUPPORTED_ENCRYPTION_TYPES
{
    /// <include file='TRUSTED_DOMAIN_SUPPORTED_ENCRYPTION_TYPES.xml' path='doc/member[@name="TRUSTED_DOMAIN_SUPPORTED_ENCRYPTION_TYPES.SupportedEncryptionTypes"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SupportedEncryptionTypes;
}