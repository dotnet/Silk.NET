// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_HW_ENDURANCE_INFO
{
    [NativeTypeName("DWORD")]
    public uint ValidFields;

    [NativeTypeName("DWORD")]
    public uint GroupId;

    [NativeTypeName("__AnonymousRecord_winioctl_L3154_C5")]
    public _Flags_e__Struct Flags;

    [NativeTypeName("DWORD")]
    public uint LifePercentage;

    [NativeTypeName("BYTE[16]")]
    public _BytesReadCount_e__FixedBuffer BytesReadCount;

    [NativeTypeName("BYTE[16]")]
    public _ByteWriteCount_e__FixedBuffer ByteWriteCount;

    public partial struct _Flags_e__Struct
    {
        public uint _bitfield;

        [NativeTypeName("DWORD : 1")]
        public uint Shared
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
        }

        [NativeTypeName("DWORD : 31")]
        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 1) & 0x7FFFFFFFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1); }
        }
    }

    [InlineArray(16)]
    public partial struct _BytesReadCount_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _ByteWriteCount_e__FixedBuffer
    {
        public byte e0;
    }
}
