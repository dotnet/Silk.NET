// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_ADAPTER_DESCRIPTOR
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint MaximumTransferLength;

    [NativeTypeName("DWORD")]
    public uint MaximumPhysicalPages;

    [NativeTypeName("DWORD")]
    public uint AlignmentMask;

    [NativeTypeName("BOOLEAN")]
    public byte AdapterUsesPio;

    [NativeTypeName("BOOLEAN")]
    public byte AdapterScansDown;

    [NativeTypeName("BOOLEAN")]
    public byte CommandQueueing;

    [NativeTypeName("BOOLEAN")]
    public byte AcceleratedTransfer;
    public byte BusType;

    [NativeTypeName("WORD")]
    public ushort BusMajorVersion;

    [NativeTypeName("WORD")]
    public ushort BusMinorVersion;
    public byte SrbType;
    public byte AddressType;
}
