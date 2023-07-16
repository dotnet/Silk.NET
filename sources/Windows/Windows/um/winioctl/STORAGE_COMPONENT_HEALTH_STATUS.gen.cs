// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='STORAGE_COMPONENT_HEALTH_STATUS.xml' path='doc/member[@name="STORAGE_COMPONENT_HEALTH_STATUS"]/*'/>
[SupportedOSPlatform("windows10.0")]
public enum STORAGE_COMPONENT_HEALTH_STATUS
{
    /// <include file='STORAGE_COMPONENT_HEALTH_STATUS.xml' path='doc/member[@name="STORAGE_COMPONENT_HEALTH_STATUS.HealthStatusUnknown"]/*'/>
    HealthStatusUnknown = 0,
    /// <include file='STORAGE_COMPONENT_HEALTH_STATUS.xml' path='doc/member[@name="STORAGE_COMPONENT_HEALTH_STATUS.HealthStatusNormal"]/*'/>
    HealthStatusNormal,
    /// <include file='STORAGE_COMPONENT_HEALTH_STATUS.xml' path='doc/member[@name="STORAGE_COMPONENT_HEALTH_STATUS.HealthStatusThrottled"]/*'/>
    HealthStatusThrottled,
    /// <include file='STORAGE_COMPONENT_HEALTH_STATUS.xml' path='doc/member[@name="STORAGE_COMPONENT_HEALTH_STATUS.HealthStatusWarning"]/*'/>
    HealthStatusWarning,
    /// <include file='STORAGE_COMPONENT_HEALTH_STATUS.xml' path='doc/member[@name="STORAGE_COMPONENT_HEALTH_STATUS.HealthStatusDisabled"]/*'/>
    HealthStatusDisabled,
    /// <include file='STORAGE_COMPONENT_HEALTH_STATUS.xml' path='doc/member[@name="STORAGE_COMPONENT_HEALTH_STATUS.HealthStatusFailed"]/*'/>
    HealthStatusFailed,
}