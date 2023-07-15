// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct JOBOBJECT_LIMIT_VIOLATION_INFORMATION
{
    /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.LimitFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LimitFlags;
    /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.ViolationLimitFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ViolationLimitFlags;
    /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.IoReadBytes"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong IoReadBytes;
    /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.IoReadBytesLimit"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong IoReadBytesLimit;
    /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.IoWriteBytes"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong IoWriteBytes;
    /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.IoWriteBytesLimit"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong IoWriteBytesLimit;
    /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.PerJobUserTime"]/*'/>
    public LARGE_INTEGER PerJobUserTime;
    /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.PerJobUserTimeLimit"]/*'/>
    public LARGE_INTEGER PerJobUserTimeLimit;
    /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.JobMemory"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong JobMemory;
    /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.JobMemoryLimit"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong JobMemoryLimit;
    /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.RateControlTolerance"]/*'/>
    public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance;
    /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.RateControlToleranceLimit"]/*'/>
    public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlToleranceLimit;
}