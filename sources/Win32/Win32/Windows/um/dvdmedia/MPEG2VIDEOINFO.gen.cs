// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MPEG2VIDEOINFO
{
    public VIDEOINFOHEADER2 hdr;

    [NativeTypeName("DWORD")]
    public uint dwStartTimeCode;

    [NativeTypeName("DWORD")]
    public uint cbSequenceHeader;

    [NativeTypeName("DWORD")]
    public uint dwProfile;

    [NativeTypeName("DWORD")]
    public uint dwLevel;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD[1]")]
    public _dwSequenceHeader_e__FixedBuffer dwSequenceHeader;

    public partial struct _dwSequenceHeader_e__FixedBuffer
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
