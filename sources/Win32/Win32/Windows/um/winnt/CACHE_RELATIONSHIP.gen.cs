// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CACHE_RELATIONSHIP
{
    public byte Level;
    public byte Associativity;

    [NativeTypeName("WORD")]
    public ushort LineSize;

    [NativeTypeName("DWORD")]
    public uint CacheSize;
    public PROCESSOR_CACHE_TYPE Type;

    [NativeTypeName("BYTE[18]")]
    public _Reserved_e__FixedBuffer Reserved;

    [NativeTypeName("WORD")]
    public ushort GroupCount;

    [NativeTypeName("__AnonymousRecord_winnt_L14030_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref GROUP_AFFINITY GroupMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.GroupMask; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public GROUP_AFFINITY GroupMask;

        [FieldOffset(0)]
        [NativeTypeName("GROUP_AFFINITY[1]")]
        public _GroupMasks_e__FixedBuffer GroupMasks;

        public partial struct _GroupMasks_e__FixedBuffer
        {
            public GROUP_AFFINITY e0;

            [UnscopedRef]
            public ref GROUP_AFFINITY this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return ref Unsafe.Add(ref e0, index); }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<GROUP_AFFINITY> AsSpan(int length) =>
                MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    [InlineArray(18)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
