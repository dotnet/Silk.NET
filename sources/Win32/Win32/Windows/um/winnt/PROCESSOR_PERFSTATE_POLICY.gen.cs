// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PROCESSOR_PERFSTATE_POLICY
{
    [NativeTypeName("DWORD")]
    public uint Revision;
    public byte MaxThrottle;
    public byte MinThrottle;
    public byte BusyAdjThreshold;

    [NativeTypeName("__AnonymousRecord_winnt_L19009_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD")]
    public uint TimeCheck;

    [NativeTypeName("DWORD")]
    public uint IncreaseTime;

    [NativeTypeName("DWORD")]
    public uint DecreaseTime;

    [NativeTypeName("DWORD")]
    public uint IncreasePercent;

    [NativeTypeName("DWORD")]
    public uint DecreasePercent;

    [UnscopedRef]
    public ref byte Spare
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Spare; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._Flags_e__Union Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Flags; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public byte Spare;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L19011_C9")]
        public _Flags_e__Union Flags;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Flags_e__Union
        {
            [FieldOffset(0)]
            public byte AsBYTE;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_winnt_L19013_C13")]
            public _Anonymous_e__Struct Anonymous;
            public byte NoDomainAccounting
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return Anonymous.NoDomainAccounting; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { Anonymous.NoDomainAccounting = value; }
            }
            public byte IncreasePolicy
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return Anonymous.IncreasePolicy; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { Anonymous.IncreasePolicy = value; }
            }
            public byte DecreasePolicy
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return Anonymous.DecreasePolicy; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { Anonymous.DecreasePolicy = value; }
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
                public byte NoDomainAccounting
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get { return (byte)(_bitfield & 0x1u); }
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set { _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u)); }
                }

                [NativeTypeName("byte : 2")]
                public byte IncreasePolicy
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get { return (byte)((_bitfield >> 1) & 0x3u); }
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set { _bitfield = (byte)((_bitfield & ~(0x3u << 1)) | ((value & 0x3u) << 1)); }
                }

                [NativeTypeName("byte : 2")]
                public byte DecreasePolicy
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get { return (byte)((_bitfield >> 3) & 0x3u); }
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set { _bitfield = (byte)((_bitfield & ~(0x3u << 3)) | ((value & 0x3u) << 3)); }
                }

                [NativeTypeName("byte : 3")]
                public byte Reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get { return (byte)((_bitfield >> 5) & 0x7u); }
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set { _bitfield = (byte)((_bitfield & ~(0x7u << 5)) | ((value & 0x7u) << 5)); }
                }
            }
        }
    }
}
