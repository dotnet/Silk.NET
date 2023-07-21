// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CREDENTIAL_PROVIDER_FIELD_STATE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_STATE"]/*' />
public enum CREDENTIAL_PROVIDER_FIELD_STATE
{
    /// <include file='CREDENTIAL_PROVIDER_FIELD_STATE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_STATE.CPFS_HIDDEN"]/*' />
    CPFS_HIDDEN = 0,

    /// <include file='CREDENTIAL_PROVIDER_FIELD_STATE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_STATE.CPFS_DISPLAY_IN_SELECTED_TILE"]/*' />
    CPFS_DISPLAY_IN_SELECTED_TILE = (CPFS_HIDDEN + 1),

    /// <include file='CREDENTIAL_PROVIDER_FIELD_STATE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_STATE.CPFS_DISPLAY_IN_DESELECTED_TILE"]/*' />
    CPFS_DISPLAY_IN_DESELECTED_TILE = (CPFS_DISPLAY_IN_SELECTED_TILE + 1),

    /// <include file='CREDENTIAL_PROVIDER_FIELD_STATE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_STATE.CPFS_DISPLAY_IN_BOTH"]/*' />
    CPFS_DISPLAY_IN_BOTH = (CPFS_DISPLAY_IN_DESELECTED_TILE + 1),
}
