// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='HEAP_OPTIMIZE_RESOURCES_INFORMATION.xml' path='doc/member[@name="HEAP_OPTIMIZE_RESOURCES_INFORMATION"]/*' />
[SupportedOSPlatform("windows6.3")]
public partial struct HEAP_OPTIMIZE_RESOURCES_INFORMATION
{
    /// <include file='HEAP_OPTIMIZE_RESOURCES_INFORMATION.xml' path='doc/member[@name="HEAP_OPTIMIZE_RESOURCES_INFORMATION.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='HEAP_OPTIMIZE_RESOURCES_INFORMATION.xml' path='doc/member[@name="HEAP_OPTIMIZE_RESOURCES_INFORMATION.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;
}
