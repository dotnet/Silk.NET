// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS
{
    /// <include file='CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS.CPCFO_NONE"]/*'/>
    CPCFO_NONE = 0,
    /// <include file='CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS.CPCFO_ENABLE_PASSWORD_REVEAL"]/*'/>
    CPCFO_ENABLE_PASSWORD_REVEAL = 0x1,
    /// <include file='CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS.CPCFO_IS_EMAIL_ADDRESS"]/*'/>
    CPCFO_IS_EMAIL_ADDRESS = 0x2,
    /// <include file='CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS.CPCFO_ENABLE_TOUCH_KEYBOARD_AUTO_INVOKE"]/*'/>
    CPCFO_ENABLE_TOUCH_KEYBOARD_AUTO_INVOKE = 0x4,
    /// <include file='CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS.CPCFO_NUMBERS_ONLY"]/*'/>
    CPCFO_NUMBERS_ONLY = 0x8,
    /// <include file='CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS.CPCFO_SHOW_ENGLISH_KEYBOARD"]/*'/>
    CPCFO_SHOW_ENGLISH_KEYBOARD = 0x10,
}