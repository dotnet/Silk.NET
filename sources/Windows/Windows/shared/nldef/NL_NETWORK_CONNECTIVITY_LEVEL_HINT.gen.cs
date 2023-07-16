// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='NL_NETWORK_CONNECTIVITY_LEVEL_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_LEVEL_HINT"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public enum NL_NETWORK_CONNECTIVITY_LEVEL_HINT
{
    /// <include file='NL_NETWORK_CONNECTIVITY_LEVEL_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_LEVEL_HINT.NetworkConnectivityLevelHintUnknown"]/*'/>
    NetworkConnectivityLevelHintUnknown = 0,
    /// <include file='NL_NETWORK_CONNECTIVITY_LEVEL_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_LEVEL_HINT.NetworkConnectivityLevelHintNone"]/*'/>
    NetworkConnectivityLevelHintNone,
    /// <include file='NL_NETWORK_CONNECTIVITY_LEVEL_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_LEVEL_HINT.NetworkConnectivityLevelHintLocalAccess"]/*'/>
    NetworkConnectivityLevelHintLocalAccess,
    /// <include file='NL_NETWORK_CONNECTIVITY_LEVEL_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_LEVEL_HINT.NetworkConnectivityLevelHintInternetAccess"]/*'/>
    NetworkConnectivityLevelHintInternetAccess,
    /// <include file='NL_NETWORK_CONNECTIVITY_LEVEL_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_LEVEL_HINT.NetworkConnectivityLevelHintConstrainedInternetAccess"]/*'/>
    NetworkConnectivityLevelHintConstrainedInternetAccess,
    /// <include file='NL_NETWORK_CONNECTIVITY_LEVEL_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_LEVEL_HINT.NetworkConnectivityLevelHintHidden"]/*'/>
    NetworkConnectivityLevelHintHidden,
}