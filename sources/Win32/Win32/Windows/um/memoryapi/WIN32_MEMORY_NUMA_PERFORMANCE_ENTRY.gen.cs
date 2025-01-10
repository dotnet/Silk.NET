// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/memoryapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct WIN32_MEMORY_NUMA_PERFORMANCE_ENTRY
{
    [NativeTypeName("ULONG")]
    public uint InitiatorNodeNumber;

    [NativeTypeName("ULONG")]
    public uint TargetNodeNumber;

    [NativeTypeName("UCHAR")]
    public byte DataType;

    [NativeTypeName("__AnonymousRecord_memoryapi_L1200_C5")]
    public _Flags_e__Struct Flags;

    [NativeTypeName("ULONGLONG")]
    public ulong MinTransferSizeInBytes;

    [NativeTypeName("ULONGLONG")]
    public ulong EntryValue;

    public partial struct _Flags_e__Struct
    {
        public byte _bitfield;

        [NativeTypeName("UCHAR : 1")]
        public byte MinTransferSizeToAchieveValues
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (byte)(_bitfield & 0x1u); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u)); }
        }

        [NativeTypeName("UCHAR : 1")]
        public byte NonSequentialTransfers
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (byte)((_bitfield >> 1) & 0x1u); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (byte)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1)); }
        }

        [NativeTypeName("UCHAR : 6")]
        public byte Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (byte)((_bitfield >> 2) & 0x3Fu); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (byte)((_bitfield & ~(0x3Fu << 2)) | ((value & 0x3Fu) << 2)); }
        }
    }
}
