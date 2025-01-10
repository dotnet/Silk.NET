// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PERSISTENT_RESERVE_COMMAND
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("__AnonymousRecord_winioctl_L5955_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref _Anonymous_e__Union._PR_IN_e__Struct PR_IN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.PR_IN; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._PR_OUT_e__Struct PR_OUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.PR_OUT; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L5957_C9")]
        public _PR_IN_e__Struct PR_IN;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L5974_C9")]
        public _PR_OUT_e__Struct PR_OUT;

        public partial struct _PR_IN_e__Struct
        {
            public byte _bitfield;

            [NativeTypeName("byte : 5")]
            public byte ServiceAction
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (byte)(_bitfield & 0x1Fu); }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (byte)((_bitfield & ~0x1Fu) | (value & 0x1Fu)); }
            }

            [NativeTypeName("byte : 3")]
            public byte Reserved1
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (byte)((_bitfield >> 5) & 0x7u); }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (byte)((_bitfield & ~(0x7u << 5)) | ((value & 0x7u) << 5)); }
            }

            [NativeTypeName("WORD")]
            public ushort AllocationLength;
        }

        public partial struct _PR_OUT_e__Struct
        {
            public byte _bitfield1;

            [NativeTypeName("byte : 5")]
            public byte ServiceAction
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (byte)(_bitfield1 & 0x1Fu); }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield1 = (byte)((_bitfield1 & ~0x1Fu) | (value & 0x1Fu)); }
            }

            [NativeTypeName("byte : 3")]
            public byte Reserved1
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (byte)((_bitfield1 >> 5) & 0x7u); }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield1 = (byte)((_bitfield1 & ~(0x7u << 5)) | ((value & 0x7u) << 5)); }
            }
            public byte _bitfield2;

            [NativeTypeName("byte : 4")]
            public byte Type
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (byte)(_bitfield2 & 0xFu); }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield2 = (byte)((_bitfield2 & ~0xFu) | (value & 0xFu)); }
            }

            [NativeTypeName("byte : 4")]
            public byte Scope
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (byte)((_bitfield2 >> 4) & 0xFu); }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield2 = (byte)((_bitfield2 & ~(0xFu << 4)) | ((value & 0xFu) << 4)); }
            }

            [NativeTypeName("BYTE[0]")]
            public _ParameterList_e__FixedBuffer ParameterList;

            public partial struct _ParameterList_e__FixedBuffer
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
    }
}
