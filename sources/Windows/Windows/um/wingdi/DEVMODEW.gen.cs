// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW"]/*'/>
public unsafe partial struct DEVMODEW
{
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmDeviceName"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort dmDeviceName[32];
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmSpecVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort dmSpecVersion;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmDriverVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort dmDriverVersion;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmSize"]/*'/>
    [NativeTypeName("WORD")]
    public ushort dmSize;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmDriverExtra"]/*'/>
    [NativeTypeName("WORD")]
    public ushort dmDriverExtra;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmFields"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dmFields;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.Anonymous1"]/*'/>
    [NativeTypeName("__AnonymousRecord_wingdi_L2259_C5")]
    public _Anonymous1_e__Union Anonymous1;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmColor"]/*'/>
    public short dmColor;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmDuplex"]/*'/>
    public short dmDuplex;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmYResolution"]/*'/>
    public short dmYResolution;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmTTOption"]/*'/>
    public short dmTTOption;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmCollate"]/*'/>
    public short dmCollate;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmFormName"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort dmFormName[32];
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmLogPixels"]/*'/>
    [NativeTypeName("WORD")]
    public ushort dmLogPixels;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmBitsPerPel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dmBitsPerPel;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmPelsWidth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dmPelsWidth;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmPelsHeight"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dmPelsHeight;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.Anonymous2"]/*'/>
    [NativeTypeName("__AnonymousRecord_wingdi_L2288_C5")]
    public _Anonymous2_e__Union Anonymous2;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmDisplayFrequency"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dmDisplayFrequency;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmICMMethod"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dmICMMethod;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmICMIntent"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dmICMIntent;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmMediaType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dmMediaType;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmDitherType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dmDitherType;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmReserved1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dmReserved1;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmReserved2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dmReserved2;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmPanningWidth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dmPanningWidth;
    /// <include file='DEVMODEW.xml' path='doc/member[@name="DEVMODEW.dmPanningHeight"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dmPanningHeight;
    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmOrientation"]/*'/>
    [UnscopedRef]
    public ref short dmOrientation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous1.dmOrientation;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperSize"]/*'/>
    [UnscopedRef]
    public ref short dmPaperSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous1.dmPaperSize;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperLength"]/*'/>
    [UnscopedRef]
    public ref short dmPaperLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous1.dmPaperLength;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperWidth"]/*'/>
    [UnscopedRef]
    public ref short dmPaperWidth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous1.dmPaperWidth;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmScale"]/*'/>
    [UnscopedRef]
    public ref short dmScale
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous1.dmScale;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmCopies"]/*'/>
    [UnscopedRef]
    public ref short dmCopies
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous1.dmCopies;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmDefaultSource"]/*'/>
    [UnscopedRef]
    public ref short dmDefaultSource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous1.dmDefaultSource;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPrintQuality"]/*'/>
    [UnscopedRef]
    public ref short dmPrintQuality
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous1.dmPrintQuality;
        }
    }

    /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmPosition"]/*'/>
    [UnscopedRef]
    public ref POINTL dmPosition
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous2.dmPosition;
        }
    }

    /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmDisplayOrientation"]/*'/>
    [UnscopedRef]
    public ref uint dmDisplayOrientation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous2.dmDisplayOrientation;
        }
    }

    /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmDisplayFixedOutput"]/*'/>
    [UnscopedRef]
    public ref uint dmDisplayFixedOutput
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous2.dmDisplayFixedOutput;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dmDisplayFlags"]/*'/>
    [UnscopedRef]
    public ref uint dmDisplayFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dmDisplayFlags;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dmNup"]/*'/>
    [UnscopedRef]
    public ref uint dmNup
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dmNup;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Anonymous1"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wingdi_L2261_C7")]
        public _Anonymous1_e__Struct Anonymous1;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Anonymous2"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wingdi_L2272_C7")]
        public _Anonymous2_e__Struct Anonymous2;
        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct"]/*'/>
        public partial struct _Anonymous1_e__Struct
        {
            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmOrientation"]/*'/>
            public short dmOrientation;
            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperSize"]/*'/>
            public short dmPaperSize;
            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperLength"]/*'/>
            public short dmPaperLength;
            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperWidth"]/*'/>
            public short dmPaperWidth;
            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmScale"]/*'/>
            public short dmScale;
            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmCopies"]/*'/>
            public short dmCopies;
            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmDefaultSource"]/*'/>
            public short dmDefaultSource;
            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPrintQuality"]/*'/>
            public short dmPrintQuality;
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct"]/*'/>
        public partial struct _Anonymous2_e__Struct
        {
            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmPosition"]/*'/>
            public POINTL dmPosition;
            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmDisplayOrientation"]/*'/>
            [NativeTypeName("DWORD")]
            public uint dmDisplayOrientation;
            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmDisplayFixedOutput"]/*'/>
            [NativeTypeName("DWORD")]
            public uint dmDisplayFixedOutput;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dmDisplayFlags"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dmDisplayFlags;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dmNup"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dmNup;
    }
}