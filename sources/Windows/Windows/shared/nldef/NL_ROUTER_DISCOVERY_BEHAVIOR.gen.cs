// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NL_ROUTER_DISCOVERY_BEHAVIOR.xml' path='doc/member[@name="NL_ROUTER_DISCOVERY_BEHAVIOR"]/*'/>
public enum NL_ROUTER_DISCOVERY_BEHAVIOR
{
    /// <include file='NL_ROUTER_DISCOVERY_BEHAVIOR.xml' path='doc/member[@name="NL_ROUTER_DISCOVERY_BEHAVIOR.RouterDiscoveryDisabled"]/*'/>
    RouterDiscoveryDisabled = 0,
    /// <include file='NL_ROUTER_DISCOVERY_BEHAVIOR.xml' path='doc/member[@name="NL_ROUTER_DISCOVERY_BEHAVIOR.RouterDiscoveryEnabled"]/*'/>
    RouterDiscoveryEnabled,
    /// <include file='NL_ROUTER_DISCOVERY_BEHAVIOR.xml' path='doc/member[@name="NL_ROUTER_DISCOVERY_BEHAVIOR.RouterDiscoveryDhcp"]/*'/>
    RouterDiscoveryDhcp,
    /// <include file='NL_ROUTER_DISCOVERY_BEHAVIOR.xml' path='doc/member[@name="NL_ROUTER_DISCOVERY_BEHAVIOR.RouterDiscoveryUnchanged"]/*'/>
    RouterDiscoveryUnchanged = -1,
}