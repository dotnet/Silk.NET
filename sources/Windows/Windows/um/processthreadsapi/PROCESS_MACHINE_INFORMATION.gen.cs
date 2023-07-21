// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PROCESS_MACHINE_INFORMATION.xml' path='doc/member[@name="PROCESS_MACHINE_INFORMATION"]/*' />
[SupportedOSPlatform("windows10.0.22621.0")]
public partial struct PROCESS_MACHINE_INFORMATION
{
    /// <include file='PROCESS_MACHINE_INFORMATION.xml' path='doc/member[@name="PROCESS_MACHINE_INFORMATION.ProcessMachine"]/*' />
    public ushort ProcessMachine;

    /// <include file='PROCESS_MACHINE_INFORMATION.xml' path='doc/member[@name="PROCESS_MACHINE_INFORMATION.Res0"]/*' />
    public ushort Res0;

    /// <include file='PROCESS_MACHINE_INFORMATION.xml' path='doc/member[@name="PROCESS_MACHINE_INFORMATION.MachineAttributes"]/*' />
    public MACHINE_ATTRIBUTES MachineAttributes;
}
