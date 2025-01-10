// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_HW_FIRMWARE_INFO
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;
    public byte _bitfield;

    [NativeTypeName("byte : 1")]
    public byte SupportUpgrade
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)(_bitfield & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u)); }
    }

    [NativeTypeName("byte : 7")]
    public byte Reserved0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield >> 1) & 0x7Fu); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~(0x7Fu << 1)) | ((value & 0x7Fu) << 1)); }
    }
    public byte SlotCount;
    public byte ActiveSlot;
    public byte PendingActivateSlot;

    [NativeTypeName("BOOLEAN")]
    public byte FirmwareShared;

    [NativeTypeName("BYTE[3]")]
    public _Reserved_e__FixedBuffer Reserved;

    [NativeTypeName("DWORD")]
    public uint ImagePayloadAlignment;

    [NativeTypeName("DWORD")]
    public uint ImagePayloadMaxSize;

    [NativeTypeName("STORAGE_HW_FIRMWARE_SLOT_INFO[1]")]
    public _Slot_e__FixedBuffer Slot;

    [InlineArray(3)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }

    public partial struct _Slot_e__FixedBuffer
    {
        public STORAGE_HW_FIRMWARE_SLOT_INFO e0;

        [UnscopedRef]
        public ref STORAGE_HW_FIRMWARE_SLOT_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<STORAGE_HW_FIRMWARE_SLOT_INFO> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
