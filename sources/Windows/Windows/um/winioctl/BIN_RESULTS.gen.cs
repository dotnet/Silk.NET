// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='BIN_RESULTS.xml' path='doc/member[@name="BIN_RESULTS"]/*' />
public partial struct BIN_RESULTS
{
    /// <include file='BIN_RESULTS.xml' path='doc/member[@name="BIN_RESULTS.NumberOfBins"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfBins;

    /// <include file='BIN_RESULTS.xml' path='doc/member[@name="BIN_RESULTS.BinCounts"]/*' />
    [NativeTypeName("BIN_COUNT[1]")]
    public _BinCounts_e__FixedBuffer BinCounts;

    /// <include file='_BinCounts_e__FixedBuffer.xml' path='doc/member[@name="_BinCounts_e__FixedBuffer"]/*' />
    public partial struct _BinCounts_e__FixedBuffer
    {
        public BIN_COUNT e0;

        [UnscopedRef]
        public ref BIN_COUNT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<BIN_COUNT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
