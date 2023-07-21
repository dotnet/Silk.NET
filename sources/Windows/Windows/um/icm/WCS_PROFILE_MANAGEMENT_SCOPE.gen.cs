// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WCS_PROFILE_MANAGEMENT_SCOPE.xml' path='doc/member[@name="WCS_PROFILE_MANAGEMENT_SCOPE"]/*' />
public enum WCS_PROFILE_MANAGEMENT_SCOPE
{
    /// <include file='WCS_PROFILE_MANAGEMENT_SCOPE.xml' path='doc/member[@name="WCS_PROFILE_MANAGEMENT_SCOPE.WCS_PROFILE_MANAGEMENT_SCOPE_SYSTEM_WIDE"]/*' />
    WCS_PROFILE_MANAGEMENT_SCOPE_SYSTEM_WIDE,

    /// <include file='WCS_PROFILE_MANAGEMENT_SCOPE.xml' path='doc/member[@name="WCS_PROFILE_MANAGEMENT_SCOPE.WCS_PROFILE_MANAGEMENT_SCOPE_CURRENT_USER"]/*' />
    WCS_PROFILE_MANAGEMENT_SCOPE_CURRENT_USER,
}
