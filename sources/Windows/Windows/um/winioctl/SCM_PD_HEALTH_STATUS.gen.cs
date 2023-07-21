// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SCM_PD_HEALTH_STATUS.xml' path='doc/member[@name="SCM_PD_HEALTH_STATUS"]/*' />
public enum SCM_PD_HEALTH_STATUS
{
    /// <include file='SCM_PD_HEALTH_STATUS.xml' path='doc/member[@name="SCM_PD_HEALTH_STATUS.ScmPhysicalDeviceHealth_Unknown"]/*' />
    ScmPhysicalDeviceHealth_Unknown = 0,

    /// <include file='SCM_PD_HEALTH_STATUS.xml' path='doc/member[@name="SCM_PD_HEALTH_STATUS.ScmPhysicalDeviceHealth_Unhealthy"]/*' />
    ScmPhysicalDeviceHealth_Unhealthy,

    /// <include file='SCM_PD_HEALTH_STATUS.xml' path='doc/member[@name="SCM_PD_HEALTH_STATUS.ScmPhysicalDeviceHealth_Warning"]/*' />
    ScmPhysicalDeviceHealth_Warning,

    /// <include file='SCM_PD_HEALTH_STATUS.xml' path='doc/member[@name="SCM_PD_HEALTH_STATUS.ScmPhysicalDeviceHealth_Healthy"]/*' />
    ScmPhysicalDeviceHealth_Healthy,

    /// <include file='SCM_PD_HEALTH_STATUS.xml' path='doc/member[@name="SCM_PD_HEALTH_STATUS.ScmPhysicalDeviceHealth_Max"]/*' />
    ScmPhysicalDeviceHealth_Max,
}
