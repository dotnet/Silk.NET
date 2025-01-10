// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SCM_LD_INTERLEAVE_SET_INFO
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint InterleaveSetSize;

    [NativeTypeName("SCM_INTERLEAVED_PD_INFO[1]")]
    public _InterleaveSet_e__FixedBuffer InterleaveSet;

    public partial struct _InterleaveSet_e__FixedBuffer
    {
        public SCM_INTERLEAVED_PD_INFO e0;

        [UnscopedRef]
        public ref SCM_INTERLEAVED_PD_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SCM_INTERLEAVED_PD_INFO> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
