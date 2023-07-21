// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MF_CROSS_ORIGIN_POLICY.xml' path='doc/member[@name="MF_CROSS_ORIGIN_POLICY"]/*' />
public enum MF_CROSS_ORIGIN_POLICY
{
    /// <include file='MF_CROSS_ORIGIN_POLICY.xml' path='doc/member[@name="MF_CROSS_ORIGIN_POLICY.MF_CROSS_ORIGIN_POLICY_NONE"]/*' />
    MF_CROSS_ORIGIN_POLICY_NONE = 0,

    /// <include file='MF_CROSS_ORIGIN_POLICY.xml' path='doc/member[@name="MF_CROSS_ORIGIN_POLICY.MF_CROSS_ORIGIN_POLICY_ANONYMOUS"]/*' />
    MF_CROSS_ORIGIN_POLICY_ANONYMOUS = 1,

    /// <include file='MF_CROSS_ORIGIN_POLICY.xml' path='doc/member[@name="MF_CROSS_ORIGIN_POLICY.MF_CROSS_ORIGIN_POLICY_USE_CREDENTIALS"]/*' />
    MF_CROSS_ORIGIN_POLICY_USE_CREDENTIALS = 2,
}
