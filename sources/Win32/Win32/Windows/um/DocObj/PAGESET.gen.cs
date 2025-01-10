// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PAGESET
{
    [NativeTypeName("ULONG")]
    public uint cbStruct;
    public BOOL fOddPages;
    public BOOL fEvenPages;

    [NativeTypeName("ULONG")]
    public uint cPageRange;

    [NativeTypeName("PAGERANGE[1]")]
    public _rgPages_e__FixedBuffer rgPages;

    public partial struct _rgPages_e__FixedBuffer
    {
        public PAGERANGE e0;

        [UnscopedRef]
        public ref PAGERANGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PAGERANGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
