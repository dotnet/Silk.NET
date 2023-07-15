// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='APP_MEMORY_INFORMATION.xml' path='doc/member[@name="APP_MEMORY_INFORMATION"]/*'/>
[SupportedOSPlatform("windows10.0.10586.0")]
public partial struct APP_MEMORY_INFORMATION
{
    /// <include file='APP_MEMORY_INFORMATION.xml' path='doc/member[@name="APP_MEMORY_INFORMATION.AvailableCommit"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong AvailableCommit;
    /// <include file='APP_MEMORY_INFORMATION.xml' path='doc/member[@name="APP_MEMORY_INFORMATION.PrivateCommitUsage"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong PrivateCommitUsage;
    /// <include file='APP_MEMORY_INFORMATION.xml' path='doc/member[@name="APP_MEMORY_INFORMATION.PeakPrivateCommitUsage"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong PeakPrivateCommitUsage;
    /// <include file='APP_MEMORY_INFORMATION.xml' path='doc/member[@name="APP_MEMORY_INFORMATION.TotalCommitUsage"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong TotalCommitUsage;
}