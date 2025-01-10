// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SCM_PD_DEVICE_INFO
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;
    public Guid DeviceGuid;

    [NativeTypeName("DWORD")]
    public uint UnsafeShutdownCount;

    [NativeTypeName("DWORD64")]
    public ulong PersistentMemorySizeInBytes;

    [NativeTypeName("DWORD64")]
    public ulong VolatileMemorySizeInBytes;

    [NativeTypeName("DWORD64")]
    public ulong TotalMemorySizeInBytes;

    [NativeTypeName("DWORD")]
    public uint SlotNumber;

    [NativeTypeName("DWORD")]
    public uint DeviceHandle;

    [NativeTypeName("WORD")]
    public ushort PhysicalId;
    public byte NumberOfFormatInterfaceCodes;

    [NativeTypeName("WORD[8]")]
    public _FormatInterfaceCodes_e__FixedBuffer FormatInterfaceCodes;

    [NativeTypeName("DWORD")]
    public uint VendorId;

    [NativeTypeName("DWORD")]
    public uint ProductId;

    [NativeTypeName("DWORD")]
    public uint SubsystemDeviceId;

    [NativeTypeName("DWORD")]
    public uint SubsystemVendorId;
    public byte ManufacturingLocation;
    public byte ManufacturingWeek;
    public byte ManufacturingYear;

    [NativeTypeName("DWORD")]
    public uint SerialNumber4Byte;

    [NativeTypeName("DWORD")]
    public uint SerialNumberLengthInChars;

    [NativeTypeName("CHAR[1]")]
    public _SerialNumber_e__FixedBuffer SerialNumber;

    [InlineArray(8)]
    public partial struct _FormatInterfaceCodes_e__FixedBuffer
    {
        public ushort e0;
    }

    public partial struct _SerialNumber_e__FixedBuffer
    {
        public sbyte e0;

        [UnscopedRef]
        public ref sbyte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<sbyte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
