// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PROCESS_INFORMATION_CLASS.xml' path='doc/member[@name="PROCESS_INFORMATION_CLASS"]/*'/>
public enum PROCESS_INFORMATION_CLASS
{
    /// <include file='PROCESS_INFORMATION_CLASS.xml' path='doc/member[@name="PROCESS_INFORMATION_CLASS.ProcessMemoryPriority"]/*'/>
    ProcessMemoryPriority,
    /// <include file='PROCESS_INFORMATION_CLASS.xml' path='doc/member[@name="PROCESS_INFORMATION_CLASS.ProcessMemoryExhaustionInfo"]/*'/>
    ProcessMemoryExhaustionInfo,
    /// <include file='PROCESS_INFORMATION_CLASS.xml' path='doc/member[@name="PROCESS_INFORMATION_CLASS.ProcessAppMemoryInfo"]/*'/>
    ProcessAppMemoryInfo,
    /// <include file='PROCESS_INFORMATION_CLASS.xml' path='doc/member[@name="PROCESS_INFORMATION_CLASS.ProcessInPrivateInfo"]/*'/>
    ProcessInPrivateInfo,
    /// <include file='PROCESS_INFORMATION_CLASS.xml' path='doc/member[@name="PROCESS_INFORMATION_CLASS.ProcessPowerThrottling"]/*'/>
    ProcessPowerThrottling,
    /// <include file='PROCESS_INFORMATION_CLASS.xml' path='doc/member[@name="PROCESS_INFORMATION_CLASS.ProcessReservedValue1"]/*'/>
    ProcessReservedValue1,
    /// <include file='PROCESS_INFORMATION_CLASS.xml' path='doc/member[@name="PROCESS_INFORMATION_CLASS.ProcessTelemetryCoverageInfo"]/*'/>
    ProcessTelemetryCoverageInfo,
    /// <include file='PROCESS_INFORMATION_CLASS.xml' path='doc/member[@name="PROCESS_INFORMATION_CLASS.ProcessProtectionLevelInfo"]/*'/>
    ProcessProtectionLevelInfo,
    /// <include file='PROCESS_INFORMATION_CLASS.xml' path='doc/member[@name="PROCESS_INFORMATION_CLASS.ProcessLeapSecondInfo"]/*'/>
    ProcessLeapSecondInfo,
    /// <include file='PROCESS_INFORMATION_CLASS.xml' path='doc/member[@name="PROCESS_INFORMATION_CLASS.ProcessMachineTypeInfo"]/*'/>
    ProcessMachineTypeInfo,
    /// <include file='PROCESS_INFORMATION_CLASS.xml' path='doc/member[@name="PROCESS_INFORMATION_CLASS.ProcessInformationClassMax"]/*'/>
    ProcessInformationClassMax,
}