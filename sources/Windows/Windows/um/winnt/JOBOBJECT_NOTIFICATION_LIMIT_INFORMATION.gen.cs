// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION
{
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION.IoReadBytesLimit"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong IoReadBytesLimit;
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION.IoWriteBytesLimit"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong IoWriteBytesLimit;
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION.PerJobUserTimeLimit"]/*'/>
    public LARGE_INTEGER PerJobUserTimeLimit;
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION.JobMemoryLimit"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong JobMemoryLimit;
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION.RateControlTolerance"]/*'/>
    public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance;
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION.RateControlToleranceInterval"]/*'/>
    public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL RateControlToleranceInterval;
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION.LimitFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LimitFlags;
}