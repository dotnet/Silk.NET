// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_HW_FIRMWARE_SLOT_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_SLOT_INFO"]/*'/>
public unsafe partial struct STORAGE_HW_FIRMWARE_SLOT_INFO
{
    /// <include file='STORAGE_HW_FIRMWARE_SLOT_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_SLOT_INFO.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_HW_FIRMWARE_SLOT_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_SLOT_INFO.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_HW_FIRMWARE_SLOT_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_SLOT_INFO.SlotNumber"]/*'/>
    public byte SlotNumber;
    public byte _bitfield;
    /// <include file='STORAGE_HW_FIRMWARE_SLOT_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_SLOT_INFO.ReadOnly"]/*'/>
    [NativeTypeName("byte : 1")]
    public byte ReadOnly
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

    /// <include file='STORAGE_HW_FIRMWARE_SLOT_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_SLOT_INFO.Reserved0"]/*'/>
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

    /// <include file='STORAGE_HW_FIRMWARE_SLOT_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_SLOT_INFO.Reserved1"]/*'/>
    [NativeTypeName("BYTE[6]")]
    public fixed byte Reserved1[6];
    /// <include file='STORAGE_HW_FIRMWARE_SLOT_INFO.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_SLOT_INFO.Revision"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte Revision[16];
}