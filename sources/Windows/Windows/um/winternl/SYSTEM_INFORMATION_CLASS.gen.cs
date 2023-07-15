// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SYSTEM_INFORMATION_CLASS.xml' path='doc/member[@name="SYSTEM_INFORMATION_CLASS"]/*'/>
public enum SYSTEM_INFORMATION_CLASS
{
    /// <include file='SYSTEM_INFORMATION_CLASS.xml' path='doc/member[@name="SYSTEM_INFORMATION_CLASS.SystemBasicInformation"]/*'/>
    SystemBasicInformation = 0,
    /// <include file='SYSTEM_INFORMATION_CLASS.xml' path='doc/member[@name="SYSTEM_INFORMATION_CLASS.SystemPerformanceInformation"]/*'/>
    SystemPerformanceInformation = 2,
    /// <include file='SYSTEM_INFORMATION_CLASS.xml' path='doc/member[@name="SYSTEM_INFORMATION_CLASS.SystemTimeOfDayInformation"]/*'/>
    SystemTimeOfDayInformation = 3,
    /// <include file='SYSTEM_INFORMATION_CLASS.xml' path='doc/member[@name="SYSTEM_INFORMATION_CLASS.SystemProcessInformation"]/*'/>
    SystemProcessInformation = 5,
    /// <include file='SYSTEM_INFORMATION_CLASS.xml' path='doc/member[@name="SYSTEM_INFORMATION_CLASS.SystemProcessorPerformanceInformation"]/*'/>
    SystemProcessorPerformanceInformation = 8,
    /// <include file='SYSTEM_INFORMATION_CLASS.xml' path='doc/member[@name="SYSTEM_INFORMATION_CLASS.SystemInterruptInformation"]/*'/>
    SystemInterruptInformation = 23,
    /// <include file='SYSTEM_INFORMATION_CLASS.xml' path='doc/member[@name="SYSTEM_INFORMATION_CLASS.SystemExceptionInformation"]/*'/>
    SystemExceptionInformation = 33,
    /// <include file='SYSTEM_INFORMATION_CLASS.xml' path='doc/member[@name="SYSTEM_INFORMATION_CLASS.SystemRegistryQuotaInformation"]/*'/>
    SystemRegistryQuotaInformation = 37,
    /// <include file='SYSTEM_INFORMATION_CLASS.xml' path='doc/member[@name="SYSTEM_INFORMATION_CLASS.SystemLookasideInformation"]/*'/>
    SystemLookasideInformation = 45,
    /// <include file='SYSTEM_INFORMATION_CLASS.xml' path='doc/member[@name="SYSTEM_INFORMATION_CLASS.SystemCodeIntegrityInformation"]/*'/>
    SystemCodeIntegrityInformation = 103,
    /// <include file='SYSTEM_INFORMATION_CLASS.xml' path='doc/member[@name="SYSTEM_INFORMATION_CLASS.SystemPolicyInformation"]/*'/>
    SystemPolicyInformation = 134,
}