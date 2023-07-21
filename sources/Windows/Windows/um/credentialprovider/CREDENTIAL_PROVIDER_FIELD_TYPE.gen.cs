// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CREDENTIAL_PROVIDER_FIELD_TYPE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_TYPE"]/*' />
public enum CREDENTIAL_PROVIDER_FIELD_TYPE
{
    /// <include file='CREDENTIAL_PROVIDER_FIELD_TYPE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_TYPE.CPFT_INVALID"]/*' />
    CPFT_INVALID = 0,

    /// <include file='CREDENTIAL_PROVIDER_FIELD_TYPE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_TYPE.CPFT_LARGE_TEXT"]/*' />
    CPFT_LARGE_TEXT = (CPFT_INVALID + 1),

    /// <include file='CREDENTIAL_PROVIDER_FIELD_TYPE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_TYPE.CPFT_SMALL_TEXT"]/*' />
    CPFT_SMALL_TEXT = (CPFT_LARGE_TEXT + 1),

    /// <include file='CREDENTIAL_PROVIDER_FIELD_TYPE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_TYPE.CPFT_COMMAND_LINK"]/*' />
    CPFT_COMMAND_LINK = (CPFT_SMALL_TEXT + 1),

    /// <include file='CREDENTIAL_PROVIDER_FIELD_TYPE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_TYPE.CPFT_EDIT_TEXT"]/*' />
    CPFT_EDIT_TEXT = (CPFT_COMMAND_LINK + 1),

    /// <include file='CREDENTIAL_PROVIDER_FIELD_TYPE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_TYPE.CPFT_PASSWORD_TEXT"]/*' />
    CPFT_PASSWORD_TEXT = (CPFT_EDIT_TEXT + 1),

    /// <include file='CREDENTIAL_PROVIDER_FIELD_TYPE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_TYPE.CPFT_TILE_IMAGE"]/*' />
    CPFT_TILE_IMAGE = (CPFT_PASSWORD_TEXT + 1),

    /// <include file='CREDENTIAL_PROVIDER_FIELD_TYPE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_TYPE.CPFT_CHECKBOX"]/*' />
    CPFT_CHECKBOX = (CPFT_TILE_IMAGE + 1),

    /// <include file='CREDENTIAL_PROVIDER_FIELD_TYPE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_TYPE.CPFT_COMBOBOX"]/*' />
    CPFT_COMBOBOX = (CPFT_CHECKBOX + 1),

    /// <include file='CREDENTIAL_PROVIDER_FIELD_TYPE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_TYPE.CPFT_SUBMIT_BUTTON"]/*' />
    CPFT_SUBMIT_BUTTON = (CPFT_COMBOBOX + 1),
}
