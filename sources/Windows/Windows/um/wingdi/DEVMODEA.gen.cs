// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA"]/*' />
public unsafe partial struct DEVMODEA
{
    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmDeviceName"]/*' />
    [NativeTypeName("BYTE[32]")]
    public fixed byte dmDeviceName[32];

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmSpecVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort dmSpecVersion;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmDriverVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort dmDriverVersion;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmSize"]/*' />
    [NativeTypeName("WORD")]
    public ushort dmSize;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmDriverExtra"]/*' />
    [NativeTypeName("WORD")]
    public ushort dmDriverExtra;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmFields"]/*' />
    [NativeTypeName("DWORD")]
    public uint dmFields;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.Anonymous1"]/*' />
    [NativeTypeName("__AnonymousRecord_wingdi_L2205_C5")]
    public _Anonymous1_e__Union Anonymous1;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmColor"]/*' />
    public short dmColor;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmDuplex"]/*' />
    public short dmDuplex;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmYResolution"]/*' />
    public short dmYResolution;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmTTOption"]/*' />
    public short dmTTOption;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmCollate"]/*' />
    public short dmCollate;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmFormName"]/*' />
    [NativeTypeName("BYTE[32]")]
    public fixed byte dmFormName[32];

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmLogPixels"]/*' />
    [NativeTypeName("WORD")]
    public ushort dmLogPixels;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmBitsPerPel"]/*' />
    [NativeTypeName("DWORD")]
    public uint dmBitsPerPel;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmPelsWidth"]/*' />
    [NativeTypeName("DWORD")]
    public uint dmPelsWidth;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmPelsHeight"]/*' />
    [NativeTypeName("DWORD")]
    public uint dmPelsHeight;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.Anonymous2"]/*' />
    [NativeTypeName("__AnonymousRecord_wingdi_L2234_C5")]
    public _Anonymous2_e__Union Anonymous2;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmDisplayFrequency"]/*' />
    [NativeTypeName("DWORD")]
    public uint dmDisplayFrequency;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmICMMethod"]/*' />
    [NativeTypeName("DWORD")]
    public uint dmICMMethod;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmICMIntent"]/*' />
    [NativeTypeName("DWORD")]
    public uint dmICMIntent;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmMediaType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dmMediaType;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmDitherType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dmDitherType;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmReserved1"]/*' />
    [NativeTypeName("DWORD")]
    public uint dmReserved1;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmReserved2"]/*' />
    [NativeTypeName("DWORD")]
    public uint dmReserved2;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmPanningWidth"]/*' />
    [NativeTypeName("DWORD")]
    public uint dmPanningWidth;

    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmPanningHeight"]/*' />
    [NativeTypeName("DWORD")]
    public uint dmPanningHeight;

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmOrientation"]/*' />
    [UnscopedRef]
    public ref short dmOrientation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous1.dmOrientation;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperSize"]/*' />
    [UnscopedRef]
    public ref short dmPaperSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous1.dmPaperSize;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperLength"]/*' />
    [UnscopedRef]
    public ref short dmPaperLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous1.dmPaperLength;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperWidth"]/*' />
    [UnscopedRef]
    public ref short dmPaperWidth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous1.dmPaperWidth;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmScale"]/*' />
    [UnscopedRef]
    public ref short dmScale
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous1.dmScale;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmCopies"]/*' />
    [UnscopedRef]
    public ref short dmCopies
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous1.dmCopies;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmDefaultSource"]/*' />
    [UnscopedRef]
    public ref short dmDefaultSource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous1.dmDefaultSource;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPrintQuality"]/*' />
    [UnscopedRef]
    public ref short dmPrintQuality
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous1.dmPrintQuality;
        }
    }

    /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmPosition"]/*' />
    [UnscopedRef]
    public ref POINTL dmPosition
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous2.dmPosition;
        }
    }

    /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmDisplayOrientation"]/*' />
    [UnscopedRef]
    public ref uint dmDisplayOrientation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous2.dmDisplayOrientation;
        }
    }

    /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmDisplayFixedOutput"]/*' />
    [UnscopedRef]
    public ref uint dmDisplayFixedOutput
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous2.dmDisplayFixedOutput;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dmDisplayFlags"]/*' />
    [UnscopedRef]
    public ref uint dmDisplayFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dmDisplayFlags;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dmNup"]/*' />
    [UnscopedRef]
    public ref uint dmNup
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dmNup;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Anonymous1"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wingdi_L2207_C7")]
        public _Anonymous1_e__Struct Anonymous1;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Anonymous2"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wingdi_L2218_C7")]
        public _Anonymous2_e__Struct Anonymous2;

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct"]/*' />
        public partial struct _Anonymous1_e__Struct
        {
            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmOrientation"]/*' />
            public short dmOrientation;

            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperSize"]/*' />
            public short dmPaperSize;

            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperLength"]/*' />
            public short dmPaperLength;

            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperWidth"]/*' />
            public short dmPaperWidth;

            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmScale"]/*' />
            public short dmScale;

            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmCopies"]/*' />
            public short dmCopies;

            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmDefaultSource"]/*' />
            public short dmDefaultSource;

            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPrintQuality"]/*' />
            public short dmPrintQuality;
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct"]/*' />
        public partial struct _Anonymous2_e__Struct
        {
            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmPosition"]/*' />
            public POINTL dmPosition;

            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmDisplayOrientation"]/*' />
            [NativeTypeName("DWORD")]
            public uint dmDisplayOrientation;

            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmDisplayFixedOutput"]/*' />
            [NativeTypeName("DWORD")]
            public uint dmDisplayFixedOutput;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dmDisplayFlags"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dmDisplayFlags;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dmNup"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dmNup;
    }
}
