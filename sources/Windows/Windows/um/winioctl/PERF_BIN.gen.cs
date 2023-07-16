// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='PERF_BIN.xml' path='doc/member[@name="PERF_BIN"]/*'/>
public partial struct PERF_BIN
{
    /// <include file='PERF_BIN.xml' path='doc/member[@name="PERF_BIN.NumberOfBins"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfBins;
    /// <include file='PERF_BIN.xml' path='doc/member[@name="PERF_BIN.TypeOfBin"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TypeOfBin;
    /// <include file='PERF_BIN.xml' path='doc/member[@name="PERF_BIN.BinsRanges"]/*'/>
    [NativeTypeName("BIN_RANGE[1]")]
    public _BinsRanges_e__FixedBuffer BinsRanges;
    /// <include file='_BinsRanges_e__FixedBuffer.xml' path='doc/member[@name="_BinsRanges_e__FixedBuffer"]/*'/>
    public partial struct _BinsRanges_e__FixedBuffer
    {
        public BIN_RANGE e0;
        [UnscopedRef]
        public ref BIN_RANGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<BIN_RANGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}