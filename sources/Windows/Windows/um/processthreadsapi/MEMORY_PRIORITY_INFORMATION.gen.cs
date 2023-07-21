// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MEMORY_PRIORITY_INFORMATION.xml' path='doc/member[@name="MEMORY_PRIORITY_INFORMATION"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct MEMORY_PRIORITY_INFORMATION
{
    /// <include file='MEMORY_PRIORITY_INFORMATION.xml' path='doc/member[@name="MEMORY_PRIORITY_INFORMATION.MemoryPriority"]/*' />
    [NativeTypeName("ULONG")]
    public uint MemoryPriority;
}
