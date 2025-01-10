// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_DEVICE_DESCRIPTOR
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;
    public byte DeviceType;
    public byte DeviceTypeModifier;

    [NativeTypeName("BOOLEAN")]
    public byte RemovableMedia;

    [NativeTypeName("BOOLEAN")]
    public byte CommandQueueing;

    [NativeTypeName("DWORD")]
    public uint VendorIdOffset;

    [NativeTypeName("DWORD")]
    public uint ProductIdOffset;

    [NativeTypeName("DWORD")]
    public uint ProductRevisionOffset;

    [NativeTypeName("DWORD")]
    public uint SerialNumberOffset;
    public STORAGE_BUS_TYPE BusType;

    [NativeTypeName("DWORD")]
    public uint RawPropertiesLength;

    [NativeTypeName("BYTE[1]")]
    public _RawDeviceProperties_e__FixedBuffer RawDeviceProperties;

    public partial struct _RawDeviceProperties_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
