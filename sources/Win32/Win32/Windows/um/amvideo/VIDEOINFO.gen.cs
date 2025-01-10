// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct VIDEOINFO
{
    public RECT rcSource;
    public RECT rcTarget;

    [NativeTypeName("DWORD")]
    public uint dwBitRate;

    [NativeTypeName("DWORD")]
    public uint dwBitErrorRate;

    [NativeTypeName("REFERENCE_TIME")]
    public long AvgTimePerFrame;
    public BITMAPINFOHEADER bmiHeader;

    [NativeTypeName("__AnonymousRecord_amvideo_L319_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public Span<RGBQUAD> bmiColors
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.bmiColors; }
    }

    [UnscopedRef]
    public Span<uint> dwBitMasks
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.dwBitMasks; }
    }

    [UnscopedRef]
    public ref TRUECOLORINFO TrueColorInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.TrueColorInfo; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("RGBQUAD[256]")]
        public _bmiColors_e__FixedBuffer bmiColors;

        [FieldOffset(0)]
        [NativeTypeName("DWORD[3]")]
        public _dwBitMasks_e__FixedBuffer dwBitMasks;

        [FieldOffset(0)]
        public TRUECOLORINFO TrueColorInfo;

        [InlineArray(256)]
        public partial struct _bmiColors_e__FixedBuffer
        {
            public RGBQUAD e0;
        }

        [InlineArray(3)]
        public partial struct _dwBitMasks_e__FixedBuffer
        {
            public uint e0;
        }
    }
}
