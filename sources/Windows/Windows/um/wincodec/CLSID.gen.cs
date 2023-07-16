// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class CLSID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICImagingFactory1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0xF2,
                0xCA,
                0xCA,
                0x70,
                0x93,
                0x15,
                0x46,
                0xA1,
                0x3B,
                0x9F,
                0x55,
                0x39,
                0xDA,
                0x4C,
                0x0A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICImagingFactory2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE8,
                0x06,
                0x7D,
                0x31,
                0x24,
                0x5F,
                0x3D,
                0x43,
                0xBD,
                0xF7,
                0x79,
                0xCE,
                0x68,
                0xD8,
                0xAB,
                0xC2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngDecoder1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7B,
                0xA1,
                0x9E,
                0x38,
                0x78,
                0x50,
                0xDE,
                0x4C,
                0xB6,
                0xEF,
                0x25,
                0xC1,
                0x51,
                0x75,
                0xC7,
                0x51
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngDecoder2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5B,
                0x94,
                0x18,
                0xE0,
                0x86,
                0xAA,
                0x08,
                0x40,
                0x9B,
                0xD4,
                0x67,
                0x77,
                0xA1,
                0xE4,
                0x0C,
                0x11
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICBmpDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0x20,
                0x46,
                0x6B,
                0xBF,
                0x7C,
                0x0D,
                0x40,
                0x9F,
                0xDB,
                0x81,
                0x3D,
                0xD1,
                0x0F,
                0x27,
                0x78
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICIcoDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0xFC,
                0x1B,
                0xC6,
                0x0F,
                0x2E,
                0xAD,
                0x4A,
                0xA8,
                0xD7,
                0xE0,
                0x6B,
                0xAF,
                0xEB,
                0xCD,
                0xFE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICJpegDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0xA4,
                0x56,
                0x94,
                0x8B,
                0xE8,
                0xEA,
                0x43,
                0x9E,
                0x73,
                0x0B,
                0x2D,
                0x9B,
                0x71,
                0xB1,
                0xCA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICGifDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3C,
                0xDA,
                0x1D,
                0x38,
                0xE9,
                0x9C,
                0x34,
                0x48,
                0xA2,
                0x3E,
                0x1F,
                0x98,
                0xF8,
                0xFC,
                0x52,
                0xBE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICTiffDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD9,
                0x85,
                0x4E,
                0xB5,
                0x23,
                0xFE,
                0x9F,
                0x49,
                0x8B,
                0x88,
                0x6A,
                0xCE,
                0xA7,
                0x13,
                0x75,
                0x2B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICWmpDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x36,
                0xEC,
                0x6C,
                0xA2,
                0x4C,
                0x23,
                0x50,
                0x49,
                0xAE,
                0x16,
                0xE3,
                0x4A,
                0xAC,
                0xE7,
                0x1D,
                0x0D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICDdsDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9F,
                0x69,
                0x53,
                0x90,
                0x41,
                0xA3,
                0x9D,
                0x42,
                0x9E,
                0x90,
                0xEE,
                0x43,
                0x7C,
                0xF8,
                0x0C,
                0x73
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICBmpEncoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB4,
                0x8B,
                0xBE,
                0x69,
                0x6D,
                0xD6,
                0xC8,
                0x47,
                0x86,
                0x5A,
                0xED,
                0x15,
                0x89,
                0x43,
                0x37,
                0x82
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngEncoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x69,
                0x99,
                0x94,
                0x27,
                0x6A,
                0x87,
                0xD7,
                0x41,
                0x94,
                0x47,
                0x56,
                0x8F,
                0x6A,
                0x35,
                0xA4,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICJpegEncoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0xF5,
                0x34,
                0x1A,
                0x5A,
                0x4A,
                0xDC,
                0x46,
                0xB6,
                0x44,
                0x1F,
                0x45,
                0x67,
                0xE7,
                0xA6,
                0x76
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICGifEncoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x98,
                0x55,
                0x4F,
                0x11,
                0x22,
                0x0B,
                0xA0,
                0x40,
                0x86,
                0xA1,
                0xC8,
                0x3E,
                0xA4,
                0x95,
                0xAD,
                0xBD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICTiffEncoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0xBE,
                0x31,
                0x01,
                0x01,
                0x20,
                0x5F,
                0x4C,
                0xA9,
                0xB0,
                0xCC,
                0x88,
                0xFA,
                0xB6,
                0x4C,
                0xE8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICWmpEncoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCB,
                0xE3,
                0x4C,
                0xAC,
                0xC1,
                0xE1,
                0xCD,
                0x44,
                0x82,
                0x15,
                0x5A,
                0x16,
                0x65,
                0x50,
                0x9E,
                0xC2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICDdsEncoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x94,
                0xDE,
                0x1D,
                0xA6,
                0xCE,
                0x66,
                0xC1,
                0x4A,
                0x88,
                0x1B,
                0x71,
                0x68,
                0x05,
                0x88,
                0x89,
                0x5E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICAdngDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0x94,
                0x1D,
                0x98,
                0x9E,
                0x90,
                0xA7,
                0x42,
                0x8F,
                0x5D,
                0xA7,
                0x47,
                0xFF,
                0x05,
                0x2E,
                0xDB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICJpegQualcommPhoneEncoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0x5C,
                0xED,
                0x68,
                0x34,
                0xF5,
                0x79,
                0x49,
                0xB2,
                0xB3,
                0x68,
                0x6A,
                0x12,
                0xB2,
                0xB3,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICHeifDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0A,
                0xA8,
                0xA4,
                0xE9,
                0xFE,
                0x44,
                0xE4,
                0x4D,
                0x89,
                0x71,
                0x71,
                0x50,
                0xB1,
                0x0A,
                0x51,
                0x99
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICHeifEncoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0xCE,
                0xBE,
                0x0D,
                0xB3,
                0x9E,
                0x60,
                0x48,
                0x9C,
                0x6F,
                0xDD,
                0xBE,
                0x86,
                0x63,
                0x45,
                0x75
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICWebpDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x86,
                0xE8,
                0x93,
                0x76,
                0xC9,
                0x51,
                0x70,
                0x40,
                0x84,
                0x19,
                0x9F,
                0x70,
                0x73,
                0x8E,
                0xC8,
                0xFA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICRAWDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0x57,
                0x94,
                0x41,
                0x02,
                0x83,
                0xA6,
                0x44,
                0x94,
                0x45,
                0xAC,
                0x98,
                0xE8,
                0xAF,
                0xA0,
                0x86
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICImagingCategories
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0xD3,
                0xE3,
                0xFA,
                0xA4,
                0xFE,
                0x23,
                0x46,
                0x8C,
                0x75,
                0xC6,
                0xB6,
                0x11,
                0x10,
                0xB6,
                0x81
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICDefaultFormatConverter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDC,
                0x11,
                0x3F,
                0x1A,
                0x14,
                0xB5,
                0x17,
                0x4B,
                0x8C,
                0x5F,
                0x21,
                0x54,
                0x51,
                0x38,
                0x52,
                0xF1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICFormatConverterHighColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x54,
                0xD4,
                0x75,
                0xAC,
                0x37,
                0x9F,
                0xF8,
                0x48,
                0xB9,
                0x72,
                0x4E,
                0x19,
                0xBC,
                0x85,
                0x60,
                0x11
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICFormatConverterNChannel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB2,
                0xAB,
                0x7C,
                0xC1,
                0xA3,
                0xD4,
                0xD7,
                0x47,
                0xA5,
                0x57,
                0x33,
                0x9B,
                0x2E,
                0xFB,
                0xD4,
                0xF1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICFormatConverterWMPhoto
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0x17,
                0xB5,
                0x9C,
                0x00,
                0xD6,
                0xBA,
                0x46,
                0xAB,
                0x77,
                0x77,
                0xBB,
                0x7E,
                0x3A,
                0x00,
                0xD9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPlanarFormatConverter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB8,
                0x32,
                0x41,
                0x18,
                0xF8,
                0x32,
                0x84,
                0x47,
                0x91,
                0x31,
                0xDD,
                0x72,
                0x24,
                0xB2,
                0x34,
                0x38
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}