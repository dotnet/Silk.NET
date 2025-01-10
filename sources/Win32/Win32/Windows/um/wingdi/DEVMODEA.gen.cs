// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DEVMODEA
{
    [NativeTypeName("BYTE[32]")]
    public _dmDeviceName_e__FixedBuffer dmDeviceName;

    [NativeTypeName("WORD")]
    public ushort dmSpecVersion;

    [NativeTypeName("WORD")]
    public ushort dmDriverVersion;

    [NativeTypeName("WORD")]
    public ushort dmSize;

    [NativeTypeName("WORD")]
    public ushort dmDriverExtra;

    [NativeTypeName("DWORD")]
    public uint dmFields;

    [NativeTypeName("__AnonymousRecord_wingdi_L2205_C5")]
    public _Anonymous1_e__Union Anonymous1;
    public short dmColor;
    public short dmDuplex;
    public short dmYResolution;
    public short dmTTOption;
    public short dmCollate;

    [NativeTypeName("BYTE[32]")]
    public _dmFormName_e__FixedBuffer dmFormName;

    [NativeTypeName("WORD")]
    public ushort dmLogPixels;

    [NativeTypeName("DWORD")]
    public uint dmBitsPerPel;

    [NativeTypeName("DWORD")]
    public uint dmPelsWidth;

    [NativeTypeName("DWORD")]
    public uint dmPelsHeight;

    [NativeTypeName("__AnonymousRecord_wingdi_L2234_C5")]
    public _Anonymous2_e__Union Anonymous2;

    [NativeTypeName("DWORD")]
    public uint dmDisplayFrequency;

    [NativeTypeName("DWORD")]
    public uint dmICMMethod;

    [NativeTypeName("DWORD")]
    public uint dmICMIntent;

    [NativeTypeName("DWORD")]
    public uint dmMediaType;

    [NativeTypeName("DWORD")]
    public uint dmDitherType;

    [NativeTypeName("DWORD")]
    public uint dmReserved1;

    [NativeTypeName("DWORD")]
    public uint dmReserved2;

    [NativeTypeName("DWORD")]
    public uint dmPanningWidth;

    [NativeTypeName("DWORD")]
    public uint dmPanningHeight;

    [UnscopedRef]
    public ref short dmOrientation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous1.dmOrientation; }
    }

    [UnscopedRef]
    public ref short dmPaperSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous1.dmPaperSize; }
    }

    [UnscopedRef]
    public ref short dmPaperLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous1.dmPaperLength; }
    }

    [UnscopedRef]
    public ref short dmPaperWidth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous1.dmPaperWidth; }
    }

    [UnscopedRef]
    public ref short dmScale
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous1.dmScale; }
    }

    [UnscopedRef]
    public ref short dmCopies
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous1.dmCopies; }
    }

    [UnscopedRef]
    public ref short dmDefaultSource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous1.dmDefaultSource; }
    }

    [UnscopedRef]
    public ref short dmPrintQuality
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous1.dmPrintQuality; }
    }

    [UnscopedRef]
    public ref POINTL dmPosition
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous2.dmPosition; }
    }

    [UnscopedRef]
    public ref uint dmDisplayOrientation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous2.dmDisplayOrientation; }
    }

    [UnscopedRef]
    public ref uint dmDisplayFixedOutput
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous2.dmDisplayFixedOutput; }
    }

    [UnscopedRef]
    public ref uint dmDisplayFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.dmDisplayFlags; }
    }

    [UnscopedRef]
    public ref uint dmNup
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.dmNup; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wingdi_L2207_C7")]
        public _Anonymous1_e__Struct Anonymous1;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wingdi_L2218_C7")]
        public _Anonymous2_e__Struct Anonymous2;

        public partial struct _Anonymous1_e__Struct
        {
            public short dmOrientation;
            public short dmPaperSize;
            public short dmPaperLength;
            public short dmPaperWidth;
            public short dmScale;
            public short dmCopies;
            public short dmDefaultSource;
            public short dmPrintQuality;
        }

        public partial struct _Anonymous2_e__Struct
        {
            public POINTL dmPosition;

            [NativeTypeName("DWORD")]
            public uint dmDisplayOrientation;

            [NativeTypeName("DWORD")]
            public uint dmDisplayFixedOutput;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dmDisplayFlags;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dmNup;
    }

    [InlineArray(32)]
    public partial struct _dmDeviceName_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(32)]
    public partial struct _dmFormName_e__FixedBuffer
    {
        public byte e0;
    }
}
