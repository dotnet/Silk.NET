// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='KF_REDIRECTION_CAPABILITIES.xml' path='doc/member[@name="KF_REDIRECTION_CAPABILITIES"]/*' />
public enum KF_REDIRECTION_CAPABILITIES
{
    /// <include file='KF_REDIRECTION_CAPABILITIES.xml' path='doc/member[@name="KF_REDIRECTION_CAPABILITIES.KF_REDIRECTION_CAPABILITIES_ALLOW_ALL"]/*' />
    KF_REDIRECTION_CAPABILITIES_ALLOW_ALL = 0xff,

    /// <include file='KF_REDIRECTION_CAPABILITIES.xml' path='doc/member[@name="KF_REDIRECTION_CAPABILITIES.KF_REDIRECTION_CAPABILITIES_REDIRECTABLE"]/*' />
    KF_REDIRECTION_CAPABILITIES_REDIRECTABLE = 0x1,

    /// <include file='KF_REDIRECTION_CAPABILITIES.xml' path='doc/member[@name="KF_REDIRECTION_CAPABILITIES.KF_REDIRECTION_CAPABILITIES_DENY_ALL"]/*' />
    KF_REDIRECTION_CAPABILITIES_DENY_ALL = 0xfff00,

    /// <include file='KF_REDIRECTION_CAPABILITIES.xml' path='doc/member[@name="KF_REDIRECTION_CAPABILITIES.KF_REDIRECTION_CAPABILITIES_DENY_POLICY_REDIRECTED"]/*' />
    KF_REDIRECTION_CAPABILITIES_DENY_POLICY_REDIRECTED = 0x100,

    /// <include file='KF_REDIRECTION_CAPABILITIES.xml' path='doc/member[@name="KF_REDIRECTION_CAPABILITIES.KF_REDIRECTION_CAPABILITIES_DENY_POLICY"]/*' />
    KF_REDIRECTION_CAPABILITIES_DENY_POLICY = 0x200,

    /// <include file='KF_REDIRECTION_CAPABILITIES.xml' path='doc/member[@name="KF_REDIRECTION_CAPABILITIES.KF_REDIRECTION_CAPABILITIES_DENY_PERMISSIONS"]/*' />
    KF_REDIRECTION_CAPABILITIES_DENY_PERMISSIONS = 0x400,
}
