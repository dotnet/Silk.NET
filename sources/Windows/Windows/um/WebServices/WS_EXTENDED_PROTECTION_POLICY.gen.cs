// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_EXTENDED_PROTECTION_POLICY.xml' path='doc/member[@name="WS_EXTENDED_PROTECTION_POLICY"]/*' />
public enum WS_EXTENDED_PROTECTION_POLICY
{
    /// <include file='WS_EXTENDED_PROTECTION_POLICY.xml' path='doc/member[@name="WS_EXTENDED_PROTECTION_POLICY.WS_EXTENDED_PROTECTION_POLICY_NEVER"]/*' />
    WS_EXTENDED_PROTECTION_POLICY_NEVER = 1,

    /// <include file='WS_EXTENDED_PROTECTION_POLICY.xml' path='doc/member[@name="WS_EXTENDED_PROTECTION_POLICY.WS_EXTENDED_PROTECTION_POLICY_WHEN_SUPPORTED"]/*' />
    WS_EXTENDED_PROTECTION_POLICY_WHEN_SUPPORTED = 2,

    /// <include file='WS_EXTENDED_PROTECTION_POLICY.xml' path='doc/member[@name="WS_EXTENDED_PROTECTION_POLICY.WS_EXTENDED_PROTECTION_POLICY_ALWAYS"]/*' />
    WS_EXTENDED_PROTECTION_POLICY_ALWAYS = 3,
}
