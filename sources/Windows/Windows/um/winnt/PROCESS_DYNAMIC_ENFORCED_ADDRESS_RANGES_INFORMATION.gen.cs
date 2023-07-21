// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.xml' path='doc/member[@name="PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION"]/*' />
public unsafe partial struct PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION
{
    /// <include file='PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.xml' path='doc/member[@name="PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.NumberOfRanges"]/*' />
    [NativeTypeName("WORD")]
    public ushort NumberOfRanges;

    /// <include file='PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.xml' path='doc/member[@name="PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.Reserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved;

    /// <include file='PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.xml' path='doc/member[@name="PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.Reserved2"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved2;

    /// <include file='PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.xml' path='doc/member[@name="PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.Ranges"]/*' />
    [NativeTypeName("PPROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE")]
    public PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE* Ranges;
}
