// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE"]/*' />
public enum CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE
{
    /// <include file='CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE.CPFIS_NONE"]/*' />
    CPFIS_NONE = 0,

    /// <include file='CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE.CPFIS_READONLY"]/*' />
    CPFIS_READONLY = (CPFIS_NONE + 1),

    /// <include file='CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE.CPFIS_DISABLED"]/*' />
    CPFIS_DISABLED = (CPFIS_READONLY + 1),

    /// <include file='CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE.CPFIS_FOCUSED"]/*' />
    CPFIS_FOCUSED = (CPFIS_DISABLED + 1),
}
