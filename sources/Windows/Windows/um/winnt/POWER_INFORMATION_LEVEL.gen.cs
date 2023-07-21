// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL"]/*' />
public enum POWER_INFORMATION_LEVEL
{
    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemPowerPolicyAc"]/*' />
    SystemPowerPolicyAc,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemPowerPolicyDc"]/*' />
    SystemPowerPolicyDc,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.VerifySystemPolicyAc"]/*' />
    VerifySystemPolicyAc,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.VerifySystemPolicyDc"]/*' />
    VerifySystemPolicyDc,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemPowerCapabilities"]/*' />
    SystemPowerCapabilities,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemBatteryState"]/*' />
    SystemBatteryState,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemPowerStateHandler"]/*' />
    SystemPowerStateHandler,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ProcessorStateHandler"]/*' />
    ProcessorStateHandler,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemPowerPolicyCurrent"]/*' />
    SystemPowerPolicyCurrent,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.AdministratorPowerPolicy"]/*' />
    AdministratorPowerPolicy,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemReserveHiberFile"]/*' />
    SystemReserveHiberFile,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ProcessorInformation"]/*' />
    ProcessorInformation,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemPowerInformation"]/*' />
    SystemPowerInformation,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ProcessorStateHandler2"]/*' />
    ProcessorStateHandler2,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.LastWakeTime"]/*' />
    LastWakeTime,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.LastSleepTime"]/*' />
    LastSleepTime,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemExecutionState"]/*' />
    SystemExecutionState,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemPowerStateNotifyHandler"]/*' />
    SystemPowerStateNotifyHandler,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ProcessorPowerPolicyAc"]/*' />
    ProcessorPowerPolicyAc,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ProcessorPowerPolicyDc"]/*' />
    ProcessorPowerPolicyDc,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.VerifyProcessorPowerPolicyAc"]/*' />
    VerifyProcessorPowerPolicyAc,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.VerifyProcessorPowerPolicyDc"]/*' />
    VerifyProcessorPowerPolicyDc,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ProcessorPowerPolicyCurrent"]/*' />
    ProcessorPowerPolicyCurrent,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemPowerStateLogging"]/*' />
    SystemPowerStateLogging,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemPowerLoggingEntry"]/*' />
    SystemPowerLoggingEntry,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SetPowerSettingValue"]/*' />
    SetPowerSettingValue,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.NotifyUserPowerSetting"]/*' />
    NotifyUserPowerSetting,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.PowerInformationLevelUnused0"]/*' />
    PowerInformationLevelUnused0,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemMonitorHiberBootPowerOff"]/*' />
    SystemMonitorHiberBootPowerOff,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemVideoState"]/*' />
    SystemVideoState,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.TraceApplicationPowerMessage"]/*' />
    TraceApplicationPowerMessage,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.TraceApplicationPowerMessageEnd"]/*' />
    TraceApplicationPowerMessageEnd,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ProcessorPerfStates"]/*' />
    ProcessorPerfStates,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ProcessorIdleStates"]/*' />
    ProcessorIdleStates,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ProcessorCap"]/*' />
    ProcessorCap,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemWakeSource"]/*' />
    SystemWakeSource,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemHiberFileInformation"]/*' />
    SystemHiberFileInformation,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.TraceServicePowerMessage"]/*' />
    TraceServicePowerMessage,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ProcessorLoad"]/*' />
    ProcessorLoad,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.PowerShutdownNotification"]/*' />
    PowerShutdownNotification,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.MonitorCapabilities"]/*' />
    MonitorCapabilities,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SessionPowerInit"]/*' />
    SessionPowerInit,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SessionDisplayState"]/*' />
    SessionDisplayState,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.PowerRequestCreate"]/*' />
    PowerRequestCreate,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.PowerRequestAction"]/*' />
    PowerRequestAction,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.GetPowerRequestList"]/*' />
    GetPowerRequestList,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ProcessorInformationEx"]/*' />
    ProcessorInformationEx,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.NotifyUserModeLegacyPowerEvent"]/*' />
    NotifyUserModeLegacyPowerEvent,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.GroupPark"]/*' />
    GroupPark,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ProcessorIdleDomains"]/*' />
    ProcessorIdleDomains,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.WakeTimerList"]/*' />
    WakeTimerList,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemHiberFileSize"]/*' />
    SystemHiberFileSize,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ProcessorIdleStatesHv"]/*' />
    ProcessorIdleStatesHv,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ProcessorPerfStatesHv"]/*' />
    ProcessorPerfStatesHv,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ProcessorPerfCapHv"]/*' />
    ProcessorPerfCapHv,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ProcessorSetIdle"]/*' />
    ProcessorSetIdle,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.LogicalProcessorIdling"]/*' />
    LogicalProcessorIdling,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.UserPresence"]/*' />
    UserPresence,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.PowerSettingNotificationName"]/*' />
    PowerSettingNotificationName,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.GetPowerSettingValue"]/*' />
    GetPowerSettingValue,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.IdleResiliency"]/*' />
    IdleResiliency,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SessionRITState"]/*' />
    SessionRITState,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SessionConnectNotification"]/*' />
    SessionConnectNotification,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SessionPowerCleanup"]/*' />
    SessionPowerCleanup,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SessionLockState"]/*' />
    SessionLockState,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemHiberbootState"]/*' />
    SystemHiberbootState,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.PlatformInformation"]/*' />
    PlatformInformation,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.PdcInvocation"]/*' />
    PdcInvocation,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.MonitorInvocation"]/*' />
    MonitorInvocation,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.FirmwareTableInformationRegistered"]/*' />
    FirmwareTableInformationRegistered,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SetShutdownSelectedTime"]/*' />
    SetShutdownSelectedTime,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SuspendResumeInvocation"]/*' />
    SuspendResumeInvocation,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.PlmPowerRequestCreate"]/*' />
    PlmPowerRequestCreate,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ScreenOff"]/*' />
    ScreenOff,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.CsDeviceNotification"]/*' />
    CsDeviceNotification,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.PlatformRole"]/*' />
    PlatformRole,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.LastResumePerformance"]/*' />
    LastResumePerformance,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.DisplayBurst"]/*' />
    DisplayBurst,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ExitLatencySamplingPercentage"]/*' />
    ExitLatencySamplingPercentage,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.RegisterSpmPowerSettings"]/*' />
    RegisterSpmPowerSettings,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.PlatformIdleStates"]/*' />
    PlatformIdleStates,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ProcessorIdleVeto"]/*' />
    ProcessorIdleVeto,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.PlatformIdleVeto"]/*' />
    PlatformIdleVeto,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemBatteryStatePrecise"]/*' />
    SystemBatteryStatePrecise,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ThermalEvent"]/*' />
    ThermalEvent,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.PowerRequestActionInternal"]/*' />
    PowerRequestActionInternal,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.BatteryDeviceState"]/*' />
    BatteryDeviceState,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.PowerInformationInternal"]/*' />
    PowerInformationInternal,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.ThermalStandby"]/*' />
    ThermalStandby,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SystemHiberFileType"]/*' />
    SystemHiberFileType,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.PhysicalPowerButtonPress"]/*' />
    PhysicalPowerButtonPress,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.QueryPotentialDripsConstraint"]/*' />
    QueryPotentialDripsConstraint,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.EnergyTrackerCreate"]/*' />
    EnergyTrackerCreate,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.EnergyTrackerQuery"]/*' />
    EnergyTrackerQuery,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.UpdateBlackBoxRecorder"]/*' />
    UpdateBlackBoxRecorder,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SessionAllowExternalDmaDevices"]/*' />
    SessionAllowExternalDmaDevices,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.SendSuspendResumeNotification"]/*' />
    SendSuspendResumeNotification,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.BlackBoxRecorderDirectAccessBuffer"]/*' />
    BlackBoxRecorderDirectAccessBuffer,

    /// <include file='POWER_INFORMATION_LEVEL.xml' path='doc/member[@name="POWER_INFORMATION_LEVEL.PowerInformationLevelMaximum"]/*' />
    PowerInformationLevelMaximum,
}
