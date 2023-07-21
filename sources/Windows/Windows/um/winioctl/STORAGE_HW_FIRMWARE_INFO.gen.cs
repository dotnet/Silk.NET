// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='STORAGE_HW_FIRMWARE_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO"]/*' />
public unsafe partial struct STORAGE_HW_FIRMWARE_INFO
{
    /// <include file='STORAGE_HW_FIRMWARE_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_HW_FIRMWARE_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    public byte _bitfield;

    /// <include file='STORAGE_HW_FIRMWARE_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO.SupportUpgrade"]/*' />
    [NativeTypeName("byte : 1")]
    public byte SupportUpgrade
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)(_bitfield & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u));
        }
    }

    /// <include file='STORAGE_HW_FIRMWARE_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO.Reserved0"]/*' />
    [NativeTypeName("byte : 7")]
    public byte Reserved0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield >> 1) & 0x7Fu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (byte)((_bitfield & ~(0x7Fu << 1)) | ((value & 0x7Fu) << 1));
        }
    }

    /// <include file='STORAGE_HW_FIRMWARE_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO.SlotCount"]/*' />
    public byte SlotCount;

    /// <include file='STORAGE_HW_FIRMWARE_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO.ActiveSlot"]/*' />
    public byte ActiveSlot;

    /// <include file='STORAGE_HW_FIRMWARE_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO.PendingActivateSlot"]/*' />
    public byte PendingActivateSlot;

    /// <include file='STORAGE_HW_FIRMWARE_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO.FirmwareShared"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte FirmwareShared;

    /// <include file='STORAGE_HW_FIRMWARE_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO.Reserved"]/*' />
    [NativeTypeName("BYTE[3]")]
    public fixed byte Reserved[3];

    /// <include file='STORAGE_HW_FIRMWARE_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO.ImagePayloadAlignment"]/*' />
    [NativeTypeName("DWORD")]
    public uint ImagePayloadAlignment;

    /// <include file='STORAGE_HW_FIRMWARE_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO.ImagePayloadMaxSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint ImagePayloadMaxSize;

    /// <include file='STORAGE_HW_FIRMWARE_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO.Slot"]/*' />
    [NativeTypeName("STORAGE_HW_FIRMWARE_SLOT_INFO[1]")]
    public _Slot_e__FixedBuffer Slot;

    /// <include file='_Slot_e__FixedBuffer.xml' path='doc/member[@name="_Slot_e__FixedBuffer"]/*' />
    public partial struct _Slot_e__FixedBuffer
    {
        public STORAGE_HW_FIRMWARE_SLOT_INFO e0;

        [UnscopedRef]
        public ref STORAGE_HW_FIRMWARE_SLOT_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<STORAGE_HW_FIRMWARE_SLOT_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
