// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShellScalingApi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PROCESS_DPI_AWARENESS.xml' path='doc/member[@name="PROCESS_DPI_AWARENESS"]/*' />
[SupportedOSPlatform("windows6.3")]
public enum PROCESS_DPI_AWARENESS
{
    /// <include file='PROCESS_DPI_AWARENESS.xml' path='doc/member[@name="PROCESS_DPI_AWARENESS.PROCESS_DPI_UNAWARE"]/*' />
    PROCESS_DPI_UNAWARE = 0,

    /// <include file='PROCESS_DPI_AWARENESS.xml' path='doc/member[@name="PROCESS_DPI_AWARENESS.PROCESS_SYSTEM_DPI_AWARE"]/*' />
    PROCESS_SYSTEM_DPI_AWARE = 1,

    /// <include file='PROCESS_DPI_AWARENESS.xml' path='doc/member[@name="PROCESS_DPI_AWARENESS.PROCESS_PER_MONITOR_DPI_AWARE"]/*' />
    PROCESS_PER_MONITOR_DPI_AWARE = 2,
}
