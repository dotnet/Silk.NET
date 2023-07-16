// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFNetCredentialOptions.xml' path='doc/member[@name="MFNetCredentialOptions"]/*'/>
public enum MFNetCredentialOptions
{
    /// <include file='MFNetCredentialOptions.xml' path='doc/member[@name="MFNetCredentialOptions.MFNET_CREDENTIAL_SAVE"]/*'/>
    MFNET_CREDENTIAL_SAVE = 0x1,
    /// <include file='MFNetCredentialOptions.xml' path='doc/member[@name="MFNetCredentialOptions.MFNET_CREDENTIAL_DONT_CACHE"]/*'/>
    MFNET_CREDENTIAL_DONT_CACHE = 0x2,
    /// <include file='MFNetCredentialOptions.xml' path='doc/member[@name="MFNetCredentialOptions.MFNET_CREDENTIAL_ALLOW_CLEAR_TEXT"]/*'/>
    MFNET_CREDENTIAL_ALLOW_CLEAR_TEXT = 0x4,
}