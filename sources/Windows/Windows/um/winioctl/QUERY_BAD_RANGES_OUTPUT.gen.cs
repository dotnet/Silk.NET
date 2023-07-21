// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='QUERY_BAD_RANGES_OUTPUT.xml' path='doc/member[@name="QUERY_BAD_RANGES_OUTPUT"]/*' />
public partial struct QUERY_BAD_RANGES_OUTPUT
{
    /// <include file='QUERY_BAD_RANGES_OUTPUT.xml' path='doc/member[@name="QUERY_BAD_RANGES_OUTPUT.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='QUERY_BAD_RANGES_OUTPUT.xml' path='doc/member[@name="QUERY_BAD_RANGES_OUTPUT.NumBadRanges"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumBadRanges;

    /// <include file='QUERY_BAD_RANGES_OUTPUT.xml' path='doc/member[@name="QUERY_BAD_RANGES_OUTPUT.NextOffsetToLookUp"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong NextOffsetToLookUp;

    /// <include file='QUERY_BAD_RANGES_OUTPUT.xml' path='doc/member[@name="QUERY_BAD_RANGES_OUTPUT.BadRanges"]/*' />
    [NativeTypeName("QUERY_BAD_RANGES_OUTPUT_RANGE[1]")]
    public _BadRanges_e__FixedBuffer BadRanges;

    /// <include file='_BadRanges_e__FixedBuffer.xml' path='doc/member[@name="_BadRanges_e__FixedBuffer"]/*' />
    public partial struct _BadRanges_e__FixedBuffer
    {
        public QUERY_BAD_RANGES_OUTPUT_RANGE e0;

        [UnscopedRef]
        public ref QUERY_BAD_RANGES_OUTPUT_RANGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<QUERY_BAD_RANGES_OUTPUT_RANGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
