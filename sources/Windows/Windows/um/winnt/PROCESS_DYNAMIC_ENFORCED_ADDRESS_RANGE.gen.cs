// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE.xml' path='doc/member[@name="PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE
{
    /// <include file='PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE.xml' path='doc/member[@name="PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE.BaseAddress"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint BaseAddress;

    /// <include file='PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE.xml' path='doc/member[@name="PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE.Size"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint Size;

    /// <include file='PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE.xml' path='doc/member[@name="PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;
}
