// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PERF_BIN
{
    [NativeTypeName("DWORD")]
    public uint NumberOfBins;

    [NativeTypeName("DWORD")]
    public uint TypeOfBin;

    [NativeTypeName("BIN_RANGE[1]")]
    public _BinsRanges_e__FixedBuffer BinsRanges;

    public partial struct _BinsRanges_e__FixedBuffer
    {
        public BIN_RANGE e0;

        [UnscopedRef]
        public ref BIN_RANGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<BIN_RANGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
