// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON"]/*' />
public enum SCM_PD_OPERATIONAL_STATUS_REASON
{
    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_Unknown"]/*' />
    ScmPhysicalDeviceOpReason_Unknown = 0,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_Media"]/*' />
    ScmPhysicalDeviceOpReason_Media,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_ThresholdExceeded"]/*' />
    ScmPhysicalDeviceOpReason_ThresholdExceeded,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_LostData"]/*' />
    ScmPhysicalDeviceOpReason_LostData,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_EnergySource"]/*' />
    ScmPhysicalDeviceOpReason_EnergySource,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_Configuration"]/*' />
    ScmPhysicalDeviceOpReason_Configuration,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_DeviceController"]/*' />
    ScmPhysicalDeviceOpReason_DeviceController,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_MediaController"]/*' />
    ScmPhysicalDeviceOpReason_MediaController,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_Component"]/*' />
    ScmPhysicalDeviceOpReason_Component,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_BackgroundOperation"]/*' />
    ScmPhysicalDeviceOpReason_BackgroundOperation,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_InvalidFirmware"]/*' />
    ScmPhysicalDeviceOpReason_InvalidFirmware,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_HealthCheck"]/*' />
    ScmPhysicalDeviceOpReason_HealthCheck,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_LostDataPersistence"]/*' />
    ScmPhysicalDeviceOpReason_LostDataPersistence,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_DisabledByPlatform"]/*' />
    ScmPhysicalDeviceOpReason_DisabledByPlatform,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_PermanentError"]/*' />
    ScmPhysicalDeviceOpReason_PermanentError,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_LostWritePersistence"]/*' />
    ScmPhysicalDeviceOpReason_LostWritePersistence,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_FatalError"]/*' />
    ScmPhysicalDeviceOpReason_FatalError,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_DataPersistenceLossImminent"]/*' />
    ScmPhysicalDeviceOpReason_DataPersistenceLossImminent,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_WritePersistenceLossImminent"]/*' />
    ScmPhysicalDeviceOpReason_WritePersistenceLossImminent,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_MediaRemainingSpareBlock"]/*' />
    ScmPhysicalDeviceOpReason_MediaRemainingSpareBlock,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_PerformanceDegradation"]/*' />
    ScmPhysicalDeviceOpReason_PerformanceDegradation,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_ExcessiveTemperature"]/*' />
    ScmPhysicalDeviceOpReason_ExcessiveTemperature,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_InternalFailure"]/*' />
    ScmPhysicalDeviceOpReason_InternalFailure,

    /// <include file='SCM_PD_OPERATIONAL_STATUS_REASON.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS_REASON.ScmPhysicalDeviceOpReason_Max"]/*' />
    ScmPhysicalDeviceOpReason_Max,
}
