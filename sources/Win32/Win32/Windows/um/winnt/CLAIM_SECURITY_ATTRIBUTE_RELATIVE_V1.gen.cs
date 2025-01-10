// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public partial struct CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1
{
    [NativeTypeName("DWORD")]
    public uint Name;

    [NativeTypeName("WORD")]
    public ushort ValueType;

    [NativeTypeName("WORD")]
    public ushort Reserved;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint ValueCount;

    [NativeTypeName("__AnonymousRecord_winnt_L12518_C5")]
    public _Values_e__Union Values;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Values_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD[1]")]
        public _pInt64_e__FixedBuffer pInt64;

        [FieldOffset(0)]
        [NativeTypeName("DWORD[1]")]
        public _pUint64_e__FixedBuffer pUint64;

        [FieldOffset(0)]
        [NativeTypeName("DWORD[1]")]
        public _ppString_e__FixedBuffer ppString;

        [FieldOffset(0)]
        [NativeTypeName("DWORD[1]")]
        public _pFqbn_e__FixedBuffer pFqbn;

        [FieldOffset(0)]
        [NativeTypeName("DWORD[1]")]
        public _pOctetString_e__FixedBuffer pOctetString;

        public partial struct _pInt64_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return ref Unsafe.Add(ref e0, index); }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }

        public partial struct _pUint64_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return ref Unsafe.Add(ref e0, index); }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }

        public partial struct _ppString_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return ref Unsafe.Add(ref e0, index); }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }

        public partial struct _pFqbn_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return ref Unsafe.Add(ref e0, index); }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }

        public partial struct _pOctetString_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return ref Unsafe.Add(ref e0, index); }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
