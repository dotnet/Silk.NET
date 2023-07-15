// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_SMIME_CAPABILITIES.xml' path='doc/member[@name="CRYPT_SMIME_CAPABILITIES"]/*'/>
public unsafe partial struct CRYPT_SMIME_CAPABILITIES
{
    /// <include file='CRYPT_SMIME_CAPABILITIES.xml' path='doc/member[@name="CRYPT_SMIME_CAPABILITIES.cCapability"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cCapability;
    /// <include file='CRYPT_SMIME_CAPABILITIES.xml' path='doc/member[@name="CRYPT_SMIME_CAPABILITIES.rgCapability"]/*'/>
    [NativeTypeName("PCRYPT_SMIME_CAPABILITY")]
    public CRYPT_SMIME_CAPABILITY* rgCapability;
}