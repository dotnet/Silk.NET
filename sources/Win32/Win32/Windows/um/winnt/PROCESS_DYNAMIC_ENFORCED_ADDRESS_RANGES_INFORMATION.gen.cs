// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION
{
    [NativeTypeName("WORD")]
    public ushort NumberOfRanges;

    [NativeTypeName("WORD")]
    public ushort Reserved;

    [NativeTypeName("DWORD")]
    public uint Reserved2;

    [NativeTypeName("PPROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE")]
    public PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE* Ranges;
}
