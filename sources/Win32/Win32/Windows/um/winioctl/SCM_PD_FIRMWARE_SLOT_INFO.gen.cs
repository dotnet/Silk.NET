// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SCM_PD_FIRMWARE_SLOT_INFO
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;
    public byte SlotNumber;
    public byte _bitfield;

    [NativeTypeName("byte : 1")]
    public byte ReadOnly
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

    [NativeTypeName("BYTE[6]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    [NativeTypeName("BYTE[32]")]
    public _Revision_e__FixedBuffer Revision;

    [InlineArray(6)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(32)]
    public partial struct _Revision_e__FixedBuffer
    {
        public byte e0;
    }
}
