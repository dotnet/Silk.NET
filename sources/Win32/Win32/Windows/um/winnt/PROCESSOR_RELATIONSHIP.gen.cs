// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PROCESSOR_RELATIONSHIP
{
    public byte Flags;
    public byte EfficiencyClass;

    [NativeTypeName("BYTE[20]")]
    public _Reserved_e__FixedBuffer Reserved;

    [NativeTypeName("WORD")]
    public ushort GroupCount;

    [NativeTypeName("GROUP_AFFINITY[1]")]
    public _GroupMask_e__FixedBuffer GroupMask;

    [InlineArray(20)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }

    public partial struct _GroupMask_e__FixedBuffer
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
        public Span<GROUP_AFFINITY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
