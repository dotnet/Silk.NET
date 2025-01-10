// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_MINIPORT_DESCRIPTOR
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;
    public STORAGE_PORT_CODE_SET Portdriver;

    [NativeTypeName("BOOLEAN")]
    public byte LUNResetSupported;

    [NativeTypeName("BOOLEAN")]
    public byte TargetResetSupported;

    [NativeTypeName("WORD")]
    public ushort IoTimeoutValue;

    [NativeTypeName("BOOLEAN")]
    public byte ExtraIoInfoSupported;

    [NativeTypeName("__AnonymousRecord_winioctl_L1483_C5")]
    public _Flags_e__Union Flags;

    [NativeTypeName("BYTE[2]")]
    public _Reserved0_e__FixedBuffer Reserved0;

    [NativeTypeName("DWORD")]
    public uint Reserved1;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Flags_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L1484_C9")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        public byte AsBYTE;
        public byte LogicalPoFxForDisk
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return Anonymous.LogicalPoFxForDisk; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Anonymous.LogicalPoFxForDisk = value; }
        }
        public byte ForwardIo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return Anonymous.ForwardIo; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Anonymous.ForwardIo = value; }
        }
        public byte Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return Anonymous.Reserved; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Anonymous.Reserved = value; }
        }

        public partial struct _Anonymous_e__Struct
        {
            public byte _bitfield;

            [NativeTypeName("byte : 1")]
            public byte LogicalPoFxForDisk
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (byte)(_bitfield & 0x1u); }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u)); }
            }

            [NativeTypeName("byte : 1")]
            public byte ForwardIo
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (byte)((_bitfield >> 1) & 0x1u); }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (byte)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1)); }
            }

            [NativeTypeName("byte : 6")]
            public byte Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (byte)((_bitfield >> 2) & 0x3Fu); }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (byte)((_bitfield & ~(0x3Fu << 2)) | ((value & 0x3Fu) << 2)); }
            }
        }
    }

    [InlineArray(2)]
    public partial struct _Reserved0_e__FixedBuffer
    {
        public byte e0;
    }
}
