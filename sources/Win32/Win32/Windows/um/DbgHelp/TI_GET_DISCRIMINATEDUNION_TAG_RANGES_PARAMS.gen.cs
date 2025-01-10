// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TI_GET_DISCRIMINATEDUNION_TAG_RANGES_PARAMS
{
    [NativeTypeName("ULONG")]
    public uint Count;

    [NativeTypeName("ULONG")]
    public uint Start;

    [NativeTypeName("DISCRIMINATEDUNION_TAG_VALUE[1]")]
    public _Range_e__FixedBuffer Range;

    public partial struct _Range_e__FixedBuffer
    {
        public DISCRIMINATEDUNION_TAG_VALUE e0;

        [UnscopedRef]
        public ref DISCRIMINATEDUNION_TAG_VALUE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<DISCRIMINATEDUNION_TAG_VALUE> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
