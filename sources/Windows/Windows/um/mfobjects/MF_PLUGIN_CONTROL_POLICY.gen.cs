// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_PLUGIN_CONTROL_POLICY.xml' path='doc/member[@name="MF_PLUGIN_CONTROL_POLICY"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum MF_PLUGIN_CONTROL_POLICY
{
    /// <include file='MF_PLUGIN_CONTROL_POLICY.xml' path='doc/member[@name="MF_PLUGIN_CONTROL_POLICY.MF_PLUGIN_CONTROL_POLICY_USE_ALL_PLUGINS"]/*' />
    MF_PLUGIN_CONTROL_POLICY_USE_ALL_PLUGINS = 0,

    /// <include file='MF_PLUGIN_CONTROL_POLICY.xml' path='doc/member[@name="MF_PLUGIN_CONTROL_POLICY.MF_PLUGIN_CONTROL_POLICY_USE_APPROVED_PLUGINS"]/*' />
    MF_PLUGIN_CONTROL_POLICY_USE_APPROVED_PLUGINS = 1,

    /// <include file='MF_PLUGIN_CONTROL_POLICY.xml' path='doc/member[@name="MF_PLUGIN_CONTROL_POLICY.MF_PLUGIN_CONTROL_POLICY_USE_WEB_PLUGINS"]/*' />
    MF_PLUGIN_CONTROL_POLICY_USE_WEB_PLUGINS = 2,

    /// <include file='MF_PLUGIN_CONTROL_POLICY.xml' path='doc/member[@name="MF_PLUGIN_CONTROL_POLICY.MF_PLUGIN_CONTROL_POLICY_USE_WEB_PLUGINS_EDGEMODE"]/*' />
    MF_PLUGIN_CONTROL_POLICY_USE_WEB_PLUGINS_EDGEMODE = 3,
}
