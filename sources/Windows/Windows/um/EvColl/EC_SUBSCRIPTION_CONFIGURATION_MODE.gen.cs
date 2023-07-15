// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EC_SUBSCRIPTION_CONFIGURATION_MODE.xml' path='doc/member[@name="EC_SUBSCRIPTION_CONFIGURATION_MODE"]/*'/>
public enum EC_SUBSCRIPTION_CONFIGURATION_MODE
{
    /// <include file='EC_SUBSCRIPTION_CONFIGURATION_MODE.xml' path='doc/member[@name="EC_SUBSCRIPTION_CONFIGURATION_MODE.EcConfigurationModeNormal"]/*'/>
    EcConfigurationModeNormal = 0,
    /// <include file='EC_SUBSCRIPTION_CONFIGURATION_MODE.xml' path='doc/member[@name="EC_SUBSCRIPTION_CONFIGURATION_MODE.EcConfigurationModeCustom"]/*'/>
    EcConfigurationModeCustom,
    /// <include file='EC_SUBSCRIPTION_CONFIGURATION_MODE.xml' path='doc/member[@name="EC_SUBSCRIPTION_CONFIGURATION_MODE.EcConfigurationModeMinLatency"]/*'/>
    EcConfigurationModeMinLatency,
    /// <include file='EC_SUBSCRIPTION_CONFIGURATION_MODE.xml' path='doc/member[@name="EC_SUBSCRIPTION_CONFIGURATION_MODE.EcConfigurationModeMinBandwidth"]/*'/>
    EcConfigurationModeMinBandwidth,
}