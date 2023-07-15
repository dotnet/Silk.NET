// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Gdiplus;
public static partial class Gdiplus
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatUndefined
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA9,
                0x3C,
                0x6B,
                0xB9,
                0x28,
                0x07,
                0xD3,
                0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatMemoryBMP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAA,
                0x3C,
                0x6B,
                0xB9,
                0x28,
                0x07,
                0xD3,
                0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatBMP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAB,
                0x3C,
                0x6B,
                0xB9,
                0x28,
                0x07,
                0xD3,
                0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatEMF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAC,
                0x3C,
                0x6B,
                0xB9,
                0x28,
                0x07,
                0xD3,
                0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatWMF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAD,
                0x3C,
                0x6B,
                0xB9,
                0x28,
                0x07,
                0xD3,
                0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatJPEG
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAE,
                0x3C,
                0x6B,
                0xB9,
                0x28,
                0x07,
                0xD3,
                0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatPNG
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAF,
                0x3C,
                0x6B,
                0xB9,
                0x28,
                0x07,
                0xD3,
                0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatGIF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB0,
                0x3C,
                0x6B,
                0xB9,
                0x28,
                0x07,
                0xD3,
                0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatTIFF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB1,
                0x3C,
                0x6B,
                0xB9,
                0x28,
                0x07,
                0xD3,
                0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatEXIF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB2,
                0x3C,
                0x6B,
                0xB9,
                0x28,
                0x07,
                0xD3,
                0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB5,
                0x3C,
                0x6B,
                0xB9,
                0x28,
                0x07,
                0xD3,
                0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatHEIF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB6,
                0x3C,
                0x6B,
                0xB9,
                0x28,
                0x07,
                0xD3,
                0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ImageFormatWEBP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB7,
                0x3C,
                0x6B,
                0xB9,
                0x28,
                0x07,
                0xD3,
                0x11,
                0x9D,
                0x7B,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0xF3,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FrameDimensionTime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6D,
                0xBD,
                0xED,
                0x6A,
                0xB5,
                0x3F,
                0x8A,
                0x41,
                0x83,
                0xA6,
                0x7F,
                0x45,
                0x22,
                0x9D,
                0xC8,
                0x72
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FrameDimensionResolution
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7B,
                0x6F,
                0x23,
                0x84,
                0xD3,
                0x3B,
                0x8F,
                0x42,
                0x8D,
                0xAB,
                0x4E,
                0xA1,
                0x43,
                0x9C,
                0xA3,
                0x15
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FrameDimensionPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x86,
                0xDC,
                0x62,
                0x74,
                0x80,
                0x61,
                0x7E,
                0x4C,
                0x8E,
                0x3F,
                0xEE,
                0x73,
                0x33,
                0xA7,
                0xA4,
                0x83
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FormatIDImageInformation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBE,
                0x6C,
                0x83,
                0xE5,
                0xEF,
                0x5E,
                0x1D,
                0x4F,
                0xAC,
                0xDE,
                0xAE,
                0x4C,
                0x43,
                0xB6,
                0x08,
                0xCE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FormatIDJpegAppHeaders
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0xFD,
                0x4A,
                0x1C,
                0x77,
                0x61,
                0xCF,
                0x43,
                0xAB,
                0xC7,
                0x5F,
                0x51,
                0xAF,
                0x39,
                0xEE,
                0x85
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderCompression
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9D,
                0x73,
                0x9D,
                0xE0,
                0xD4,
                0xCC,
                0xEE,
                0x44,
                0x8E,
                0xBA,
                0x3F,
                0xBF,
                0x8B,
                0xE4,
                0xFC,
                0x58
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderColorDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x55,
                0x70,
                0x08,
                0x66,
                0x66,
                0xAD,
                0x7C,
                0x4C,
                0x9A,
                0x18,
                0x38,
                0xA2,
                0x31,
                0x0B,
                0x83,
                0x37
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderScanMethod
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x61,
                0x26,
                0x4E,
                0x3A,
                0x09,
                0x31,
                0x56,
                0x4E,
                0x85,
                0x36,
                0x42,
                0xC1,
                0x56,
                0xE7,
                0xDC,
                0xFA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x76,
                0x8C,
                0xD1,
                0x24,
                0x4A,
                0x81,
                0xA4,
                0x41,
                0xBF,
                0x53,
                0x1C,
                0x21,
                0x9C,
                0xCC,
                0xF7,
                0x97
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderRenderMethod
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3A,
                0xC5,
                0x42,
                0x6D,
                0x9A,
                0x22,
                0x25,
                0x48,
                0x8B,
                0xB7,
                0x5C,
                0x99,
                0xE2,
                0xB9,
                0xA8,
                0xB8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderQuality
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB5,
                0xE4,
                0x5B,
                0x1D,
                0x4A,
                0xFA,
                0x2D,
                0x45,
                0x9C,
                0xDD,
                0x5D,
                0xB3,
                0x51,
                0x05,
                0xE7,
                0xEB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderTransformation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD1,
                0xB2,
                0x0E,
                0x8D,
                0x8E,
                0xA5,
                0xA8,
                0x4E,
                0xAA,
                0x14,
                0x10,
                0x80,
                0x74,
                0xB7,
                0xB6,
                0xF9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderLuminanceTable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0x3B,
                0xB3,
                0xED,
                0x66,
                0x02,
                0x77,
                0x4A,
                0xB9,
                0x04,
                0x27,
                0x21,
                0x60,
                0x99,
                0xE7,
                0x17
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderChrominanceTable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDC,
                0x55,
                0xE4,
                0xF2,
                0xB3,
                0x09,
                0x16,
                0x43,
                0x82,
                0x60,
                0x67,
                0x6A,
                0xDA,
                0x32,
                0x48,
                0x1C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderSaveFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFC,
                0x66,
                0x22,
                0x29,
                0x40,
                0xAC,
                0xBF,
                0x47,
                0x8C,
                0xFC,
                0xA8,
                0x5B,
                0x89,
                0xA6,
                0x55,
                0xDE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderColorSpace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA0,
                0x62,
                0x7A,
                0xAE,
                0x2C,
                0xEE,
                0xD8,
                0x49,
                0x9D,
                0x07,
                0x1B,
                0xA8,
                0xA9,
                0x27,
                0x59,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderImageItems
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x13,
                0x5E,
                0x87,
                0x63,
                0x1D,
                0x1F,
                0xAB,
                0x45,
                0x91,
                0x95,
                0xA2,
                0x9B,
                0x60,
                0x66,
                0xA6,
                0x50
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EncoderSaveAsCMYK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC9,
                0xBB,
                0x19,
                0xA2,
                0x9D,
                0x0A,
                0x05,
                0x40,
                0xA3,
                0xEE,
                0x3A,
                0x42,
                0x1B,
                0x8B,
                0xB0,
                0x6C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CodecIImageBytes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x23,
                0x18,
                0x5D,
                0x02,
                0x7D,
                0x6C,
                0x7B,
                0x44,
                0xBB,
                0xDB,
                0xA3,
                0xCB,
                0xC3,
                0xDF,
                0xA2,
                0xFC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define PropertyTagTypeByte 1")]
    public const int PropertyTagTypeByte = 1;
    [NativeTypeName("#define PropertyTagTypeASCII 2")]
    public const int PropertyTagTypeASCII = 2;
    [NativeTypeName("#define PropertyTagTypeShort 3")]
    public const int PropertyTagTypeShort = 3;
    [NativeTypeName("#define PropertyTagTypeLong 4")]
    public const int PropertyTagTypeLong = 4;
    [NativeTypeName("#define PropertyTagTypeRational 5")]
    public const int PropertyTagTypeRational = 5;
    [NativeTypeName("#define PropertyTagTypeUndefined 7")]
    public const int PropertyTagTypeUndefined = 7;
    [NativeTypeName("#define PropertyTagTypeSLONG 9")]
    public const int PropertyTagTypeSLONG = 9;
    [NativeTypeName("#define PropertyTagTypeSRational 10")]
    public const int PropertyTagTypeSRational = 10;
    [NativeTypeName("#define PropertyTagExifIFD 0x8769")]
    public const int PropertyTagExifIFD = 0x8769;
    [NativeTypeName("#define PropertyTagGpsIFD 0x8825")]
    public const int PropertyTagGpsIFD = 0x8825;
    [NativeTypeName("#define PropertyTagNewSubfileType 0x00FE")]
    public const int PropertyTagNewSubfileType = 0x00FE;
    [NativeTypeName("#define PropertyTagSubfileType 0x00FF")]
    public const int PropertyTagSubfileType = 0x00FF;
    [NativeTypeName("#define PropertyTagImageWidth 0x0100")]
    public const int PropertyTagImageWidth = 0x0100;
    [NativeTypeName("#define PropertyTagImageHeight 0x0101")]
    public const int PropertyTagImageHeight = 0x0101;
    [NativeTypeName("#define PropertyTagBitsPerSample 0x0102")]
    public const int PropertyTagBitsPerSample = 0x0102;
    [NativeTypeName("#define PropertyTagCompression 0x0103")]
    public const int PropertyTagCompression = 0x0103;
    [NativeTypeName("#define PropertyTagPhotometricInterp 0x0106")]
    public const int PropertyTagPhotometricInterp = 0x0106;
    [NativeTypeName("#define PropertyTagThreshHolding 0x0107")]
    public const int PropertyTagThreshHolding = 0x0107;
    [NativeTypeName("#define PropertyTagCellWidth 0x0108")]
    public const int PropertyTagCellWidth = 0x0108;
    [NativeTypeName("#define PropertyTagCellHeight 0x0109")]
    public const int PropertyTagCellHeight = 0x0109;
    [NativeTypeName("#define PropertyTagFillOrder 0x010A")]
    public const int PropertyTagFillOrder = 0x010A;
    [NativeTypeName("#define PropertyTagDocumentName 0x010D")]
    public const int PropertyTagDocumentName = 0x010D;
    [NativeTypeName("#define PropertyTagImageDescription 0x010E")]
    public const int PropertyTagImageDescription = 0x010E;
    [NativeTypeName("#define PropertyTagEquipMake 0x010F")]
    public const int PropertyTagEquipMake = 0x010F;
    [NativeTypeName("#define PropertyTagEquipModel 0x0110")]
    public const int PropertyTagEquipModel = 0x0110;
    [NativeTypeName("#define PropertyTagStripOffsets 0x0111")]
    public const int PropertyTagStripOffsets = 0x0111;
    [NativeTypeName("#define PropertyTagOrientation 0x0112")]
    public const int PropertyTagOrientation = 0x0112;
    [NativeTypeName("#define PropertyTagSamplesPerPixel 0x0115")]
    public const int PropertyTagSamplesPerPixel = 0x0115;
    [NativeTypeName("#define PropertyTagRowsPerStrip 0x0116")]
    public const int PropertyTagRowsPerStrip = 0x0116;
    [NativeTypeName("#define PropertyTagStripBytesCount 0x0117")]
    public const int PropertyTagStripBytesCount = 0x0117;
    [NativeTypeName("#define PropertyTagMinSampleValue 0x0118")]
    public const int PropertyTagMinSampleValue = 0x0118;
    [NativeTypeName("#define PropertyTagMaxSampleValue 0x0119")]
    public const int PropertyTagMaxSampleValue = 0x0119;
    [NativeTypeName("#define PropertyTagXResolution 0x011A")]
    public const int PropertyTagXResolution = 0x011A;
    [NativeTypeName("#define PropertyTagYResolution 0x011B")]
    public const int PropertyTagYResolution = 0x011B;
    [NativeTypeName("#define PropertyTagPlanarConfig 0x011C")]
    public const int PropertyTagPlanarConfig = 0x011C;
    [NativeTypeName("#define PropertyTagPageName 0x011D")]
    public const int PropertyTagPageName = 0x011D;
    [NativeTypeName("#define PropertyTagXPosition 0x011E")]
    public const int PropertyTagXPosition = 0x011E;
    [NativeTypeName("#define PropertyTagYPosition 0x011F")]
    public const int PropertyTagYPosition = 0x011F;
    [NativeTypeName("#define PropertyTagFreeOffset 0x0120")]
    public const int PropertyTagFreeOffset = 0x0120;
    [NativeTypeName("#define PropertyTagFreeByteCounts 0x0121")]
    public const int PropertyTagFreeByteCounts = 0x0121;
    [NativeTypeName("#define PropertyTagGrayResponseUnit 0x0122")]
    public const int PropertyTagGrayResponseUnit = 0x0122;
    [NativeTypeName("#define PropertyTagGrayResponseCurve 0x0123")]
    public const int PropertyTagGrayResponseCurve = 0x0123;
    [NativeTypeName("#define PropertyTagT4Option 0x0124")]
    public const int PropertyTagT4Option = 0x0124;
    [NativeTypeName("#define PropertyTagT6Option 0x0125")]
    public const int PropertyTagT6Option = 0x0125;
    [NativeTypeName("#define PropertyTagResolutionUnit 0x0128")]
    public const int PropertyTagResolutionUnit = 0x0128;
    [NativeTypeName("#define PropertyTagPageNumber 0x0129")]
    public const int PropertyTagPageNumber = 0x0129;
    [NativeTypeName("#define PropertyTagTransferFuncition 0x012D")]
    public const int PropertyTagTransferFuncition = 0x012D;
    [NativeTypeName("#define PropertyTagSoftwareUsed 0x0131")]
    public const int PropertyTagSoftwareUsed = 0x0131;
    [NativeTypeName("#define PropertyTagDateTime 0x0132")]
    public const int PropertyTagDateTime = 0x0132;
    [NativeTypeName("#define PropertyTagArtist 0x013B")]
    public const int PropertyTagArtist = 0x013B;
    [NativeTypeName("#define PropertyTagHostComputer 0x013C")]
    public const int PropertyTagHostComputer = 0x013C;
    [NativeTypeName("#define PropertyTagPredictor 0x013D")]
    public const int PropertyTagPredictor = 0x013D;
    [NativeTypeName("#define PropertyTagWhitePoint 0x013E")]
    public const int PropertyTagWhitePoint = 0x013E;
    [NativeTypeName("#define PropertyTagPrimaryChromaticities 0x013F")]
    public const int PropertyTagPrimaryChromaticities = 0x013F;
    [NativeTypeName("#define PropertyTagColorMap 0x0140")]
    public const int PropertyTagColorMap = 0x0140;
    [NativeTypeName("#define PropertyTagHalftoneHints 0x0141")]
    public const int PropertyTagHalftoneHints = 0x0141;
    [NativeTypeName("#define PropertyTagTileWidth 0x0142")]
    public const int PropertyTagTileWidth = 0x0142;
    [NativeTypeName("#define PropertyTagTileLength 0x0143")]
    public const int PropertyTagTileLength = 0x0143;
    [NativeTypeName("#define PropertyTagTileOffset 0x0144")]
    public const int PropertyTagTileOffset = 0x0144;
    [NativeTypeName("#define PropertyTagTileByteCounts 0x0145")]
    public const int PropertyTagTileByteCounts = 0x0145;
    [NativeTypeName("#define PropertyTagInkSet 0x014C")]
    public const int PropertyTagInkSet = 0x014C;
    [NativeTypeName("#define PropertyTagInkNames 0x014D")]
    public const int PropertyTagInkNames = 0x014D;
    [NativeTypeName("#define PropertyTagNumberOfInks 0x014E")]
    public const int PropertyTagNumberOfInks = 0x014E;
    [NativeTypeName("#define PropertyTagDotRange 0x0150")]
    public const int PropertyTagDotRange = 0x0150;
    [NativeTypeName("#define PropertyTagTargetPrinter 0x0151")]
    public const int PropertyTagTargetPrinter = 0x0151;
    [NativeTypeName("#define PropertyTagExtraSamples 0x0152")]
    public const int PropertyTagExtraSamples = 0x0152;
    [NativeTypeName("#define PropertyTagSampleFormat 0x0153")]
    public const int PropertyTagSampleFormat = 0x0153;
    [NativeTypeName("#define PropertyTagSMinSampleValue 0x0154")]
    public const int PropertyTagSMinSampleValue = 0x0154;
    [NativeTypeName("#define PropertyTagSMaxSampleValue 0x0155")]
    public const int PropertyTagSMaxSampleValue = 0x0155;
    [NativeTypeName("#define PropertyTagTransferRange 0x0156")]
    public const int PropertyTagTransferRange = 0x0156;
    [NativeTypeName("#define PropertyTagJPEGProc 0x0200")]
    public const int PropertyTagJPEGProc = 0x0200;
    [NativeTypeName("#define PropertyTagJPEGInterFormat 0x0201")]
    public const int PropertyTagJPEGInterFormat = 0x0201;
    [NativeTypeName("#define PropertyTagJPEGInterLength 0x0202")]
    public const int PropertyTagJPEGInterLength = 0x0202;
    [NativeTypeName("#define PropertyTagJPEGRestartInterval 0x0203")]
    public const int PropertyTagJPEGRestartInterval = 0x0203;
    [NativeTypeName("#define PropertyTagJPEGLosslessPredictors 0x0205")]
    public const int PropertyTagJPEGLosslessPredictors = 0x0205;
    [NativeTypeName("#define PropertyTagJPEGPointTransforms 0x0206")]
    public const int PropertyTagJPEGPointTransforms = 0x0206;
    [NativeTypeName("#define PropertyTagJPEGQTables 0x0207")]
    public const int PropertyTagJPEGQTables = 0x0207;
    [NativeTypeName("#define PropertyTagJPEGDCTables 0x0208")]
    public const int PropertyTagJPEGDCTables = 0x0208;
    [NativeTypeName("#define PropertyTagJPEGACTables 0x0209")]
    public const int PropertyTagJPEGACTables = 0x0209;
    [NativeTypeName("#define PropertyTagYCbCrCoefficients 0x0211")]
    public const int PropertyTagYCbCrCoefficients = 0x0211;
    [NativeTypeName("#define PropertyTagYCbCrSubsampling 0x0212")]
    public const int PropertyTagYCbCrSubsampling = 0x0212;
    [NativeTypeName("#define PropertyTagYCbCrPositioning 0x0213")]
    public const int PropertyTagYCbCrPositioning = 0x0213;
    [NativeTypeName("#define PropertyTagREFBlackWhite 0x0214")]
    public const int PropertyTagREFBlackWhite = 0x0214;
    [NativeTypeName("#define PropertyTagICCProfile 0x8773")]
    public const int PropertyTagICCProfile = 0x8773;
    [NativeTypeName("#define PropertyTagGamma 0x0301")]
    public const int PropertyTagGamma = 0x0301;
    [NativeTypeName("#define PropertyTagICCProfileDescriptor 0x0302")]
    public const int PropertyTagICCProfileDescriptor = 0x0302;
    [NativeTypeName("#define PropertyTagSRGBRenderingIntent 0x0303")]
    public const int PropertyTagSRGBRenderingIntent = 0x0303;
    [NativeTypeName("#define PropertyTagImageTitle 0x0320")]
    public const int PropertyTagImageTitle = 0x0320;
    [NativeTypeName("#define PropertyTagCopyright 0x8298")]
    public const int PropertyTagCopyright = 0x8298;
    [NativeTypeName("#define PropertyTagResolutionXUnit 0x5001")]
    public const int PropertyTagResolutionXUnit = 0x5001;
    [NativeTypeName("#define PropertyTagResolutionYUnit 0x5002")]
    public const int PropertyTagResolutionYUnit = 0x5002;
    [NativeTypeName("#define PropertyTagResolutionXLengthUnit 0x5003")]
    public const int PropertyTagResolutionXLengthUnit = 0x5003;
    [NativeTypeName("#define PropertyTagResolutionYLengthUnit 0x5004")]
    public const int PropertyTagResolutionYLengthUnit = 0x5004;
    [NativeTypeName("#define PropertyTagPrintFlags 0x5005")]
    public const int PropertyTagPrintFlags = 0x5005;
    [NativeTypeName("#define PropertyTagPrintFlagsVersion 0x5006")]
    public const int PropertyTagPrintFlagsVersion = 0x5006;
    [NativeTypeName("#define PropertyTagPrintFlagsCrop 0x5007")]
    public const int PropertyTagPrintFlagsCrop = 0x5007;
    [NativeTypeName("#define PropertyTagPrintFlagsBleedWidth 0x5008")]
    public const int PropertyTagPrintFlagsBleedWidth = 0x5008;
    [NativeTypeName("#define PropertyTagPrintFlagsBleedWidthScale 0x5009")]
    public const int PropertyTagPrintFlagsBleedWidthScale = 0x5009;
    [NativeTypeName("#define PropertyTagHalftoneLPI 0x500A")]
    public const int PropertyTagHalftoneLPI = 0x500A;
    [NativeTypeName("#define PropertyTagHalftoneLPIUnit 0x500B")]
    public const int PropertyTagHalftoneLPIUnit = 0x500B;
    [NativeTypeName("#define PropertyTagHalftoneDegree 0x500C")]
    public const int PropertyTagHalftoneDegree = 0x500C;
    [NativeTypeName("#define PropertyTagHalftoneShape 0x500D")]
    public const int PropertyTagHalftoneShape = 0x500D;
    [NativeTypeName("#define PropertyTagHalftoneMisc 0x500E")]
    public const int PropertyTagHalftoneMisc = 0x500E;
    [NativeTypeName("#define PropertyTagHalftoneScreen 0x500F")]
    public const int PropertyTagHalftoneScreen = 0x500F;
    [NativeTypeName("#define PropertyTagJPEGQuality 0x5010")]
    public const int PropertyTagJPEGQuality = 0x5010;
    [NativeTypeName("#define PropertyTagGridSize 0x5011")]
    public const int PropertyTagGridSize = 0x5011;
    [NativeTypeName("#define PropertyTagThumbnailFormat 0x5012")]
    public const int PropertyTagThumbnailFormat = 0x5012;
    [NativeTypeName("#define PropertyTagThumbnailWidth 0x5013")]
    public const int PropertyTagThumbnailWidth = 0x5013;
    [NativeTypeName("#define PropertyTagThumbnailHeight 0x5014")]
    public const int PropertyTagThumbnailHeight = 0x5014;
    [NativeTypeName("#define PropertyTagThumbnailColorDepth 0x5015")]
    public const int PropertyTagThumbnailColorDepth = 0x5015;
    [NativeTypeName("#define PropertyTagThumbnailPlanes 0x5016")]
    public const int PropertyTagThumbnailPlanes = 0x5016;
    [NativeTypeName("#define PropertyTagThumbnailRawBytes 0x5017")]
    public const int PropertyTagThumbnailRawBytes = 0x5017;
    [NativeTypeName("#define PropertyTagThumbnailSize 0x5018")]
    public const int PropertyTagThumbnailSize = 0x5018;
    [NativeTypeName("#define PropertyTagThumbnailCompressedSize 0x5019")]
    public const int PropertyTagThumbnailCompressedSize = 0x5019;
    [NativeTypeName("#define PropertyTagColorTransferFunction 0x501A")]
    public const int PropertyTagColorTransferFunction = 0x501A;
    [NativeTypeName("#define PropertyTagThumbnailData 0x501B")]
    public const int PropertyTagThumbnailData = 0x501B;
    [NativeTypeName("#define PropertyTagThumbnailImageWidth 0x5020")]
    public const int PropertyTagThumbnailImageWidth = 0x5020;
    [NativeTypeName("#define PropertyTagThumbnailImageHeight 0x5021")]
    public const int PropertyTagThumbnailImageHeight = 0x5021;
    [NativeTypeName("#define PropertyTagThumbnailBitsPerSample 0x5022")]
    public const int PropertyTagThumbnailBitsPerSample = 0x5022;
    [NativeTypeName("#define PropertyTagThumbnailCompression 0x5023")]
    public const int PropertyTagThumbnailCompression = 0x5023;
    [NativeTypeName("#define PropertyTagThumbnailPhotometricInterp 0x5024")]
    public const int PropertyTagThumbnailPhotometricInterp = 0x5024;
    [NativeTypeName("#define PropertyTagThumbnailImageDescription 0x5025")]
    public const int PropertyTagThumbnailImageDescription = 0x5025;
    [NativeTypeName("#define PropertyTagThumbnailEquipMake 0x5026")]
    public const int PropertyTagThumbnailEquipMake = 0x5026;
    [NativeTypeName("#define PropertyTagThumbnailEquipModel 0x5027")]
    public const int PropertyTagThumbnailEquipModel = 0x5027;
    [NativeTypeName("#define PropertyTagThumbnailStripOffsets 0x5028")]
    public const int PropertyTagThumbnailStripOffsets = 0x5028;
    [NativeTypeName("#define PropertyTagThumbnailOrientation 0x5029")]
    public const int PropertyTagThumbnailOrientation = 0x5029;
    [NativeTypeName("#define PropertyTagThumbnailSamplesPerPixel 0x502A")]
    public const int PropertyTagThumbnailSamplesPerPixel = 0x502A;
    [NativeTypeName("#define PropertyTagThumbnailRowsPerStrip 0x502B")]
    public const int PropertyTagThumbnailRowsPerStrip = 0x502B;
    [NativeTypeName("#define PropertyTagThumbnailStripBytesCount 0x502C")]
    public const int PropertyTagThumbnailStripBytesCount = 0x502C;
    [NativeTypeName("#define PropertyTagThumbnailResolutionX 0x502D")]
    public const int PropertyTagThumbnailResolutionX = 0x502D;
    [NativeTypeName("#define PropertyTagThumbnailResolutionY 0x502E")]
    public const int PropertyTagThumbnailResolutionY = 0x502E;
    [NativeTypeName("#define PropertyTagThumbnailPlanarConfig 0x502F")]
    public const int PropertyTagThumbnailPlanarConfig = 0x502F;
    [NativeTypeName("#define PropertyTagThumbnailResolutionUnit 0x5030")]
    public const int PropertyTagThumbnailResolutionUnit = 0x5030;
    [NativeTypeName("#define PropertyTagThumbnailTransferFunction 0x5031")]
    public const int PropertyTagThumbnailTransferFunction = 0x5031;
    [NativeTypeName("#define PropertyTagThumbnailSoftwareUsed 0x5032")]
    public const int PropertyTagThumbnailSoftwareUsed = 0x5032;
    [NativeTypeName("#define PropertyTagThumbnailDateTime 0x5033")]
    public const int PropertyTagThumbnailDateTime = 0x5033;
    [NativeTypeName("#define PropertyTagThumbnailArtist 0x5034")]
    public const int PropertyTagThumbnailArtist = 0x5034;
    [NativeTypeName("#define PropertyTagThumbnailWhitePoint 0x5035")]
    public const int PropertyTagThumbnailWhitePoint = 0x5035;
    [NativeTypeName("#define PropertyTagThumbnailPrimaryChromaticities 0x5036")]
    public const int PropertyTagThumbnailPrimaryChromaticities = 0x5036;
    [NativeTypeName("#define PropertyTagThumbnailYCbCrCoefficients 0x5037")]
    public const int PropertyTagThumbnailYCbCrCoefficients = 0x5037;
    [NativeTypeName("#define PropertyTagThumbnailYCbCrSubsampling 0x5038")]
    public const int PropertyTagThumbnailYCbCrSubsampling = 0x5038;
    [NativeTypeName("#define PropertyTagThumbnailYCbCrPositioning 0x5039")]
    public const int PropertyTagThumbnailYCbCrPositioning = 0x5039;
    [NativeTypeName("#define PropertyTagThumbnailRefBlackWhite 0x503A")]
    public const int PropertyTagThumbnailRefBlackWhite = 0x503A;
    [NativeTypeName("#define PropertyTagThumbnailCopyRight 0x503B")]
    public const int PropertyTagThumbnailCopyRight = 0x503B;
    [NativeTypeName("#define PropertyTagLuminanceTable 0x5090")]
    public const int PropertyTagLuminanceTable = 0x5090;
    [NativeTypeName("#define PropertyTagChrominanceTable 0x5091")]
    public const int PropertyTagChrominanceTable = 0x5091;
    [NativeTypeName("#define PropertyTagFrameDelay 0x5100")]
    public const int PropertyTagFrameDelay = 0x5100;
    [NativeTypeName("#define PropertyTagLoopCount 0x5101")]
    public const int PropertyTagLoopCount = 0x5101;
    [NativeTypeName("#define PropertyTagGlobalPalette 0x5102")]
    public const int PropertyTagGlobalPalette = 0x5102;
    [NativeTypeName("#define PropertyTagIndexBackground 0x5103")]
    public const int PropertyTagIndexBackground = 0x5103;
    [NativeTypeName("#define PropertyTagIndexTransparent 0x5104")]
    public const int PropertyTagIndexTransparent = 0x5104;
    [NativeTypeName("#define PropertyTagPixelUnit 0x5110")]
    public const int PropertyTagPixelUnit = 0x5110;
    [NativeTypeName("#define PropertyTagPixelPerUnitX 0x5111")]
    public const int PropertyTagPixelPerUnitX = 0x5111;
    [NativeTypeName("#define PropertyTagPixelPerUnitY 0x5112")]
    public const int PropertyTagPixelPerUnitY = 0x5112;
    [NativeTypeName("#define PropertyTagPaletteHistogram 0x5113")]
    public const int PropertyTagPaletteHistogram = 0x5113;
    [NativeTypeName("#define PropertyTagExifExposureTime 0x829A")]
    public const int PropertyTagExifExposureTime = 0x829A;
    [NativeTypeName("#define PropertyTagExifFNumber 0x829D")]
    public const int PropertyTagExifFNumber = 0x829D;
    [NativeTypeName("#define PropertyTagExifExposureProg 0x8822")]
    public const int PropertyTagExifExposureProg = 0x8822;
    [NativeTypeName("#define PropertyTagExifSpectralSense 0x8824")]
    public const int PropertyTagExifSpectralSense = 0x8824;
    [NativeTypeName("#define PropertyTagExifISOSpeed 0x8827")]
    public const int PropertyTagExifISOSpeed = 0x8827;
    [NativeTypeName("#define PropertyTagExifOECF 0x8828")]
    public const int PropertyTagExifOECF = 0x8828;
    [NativeTypeName("#define PropertyTagExifVer 0x9000")]
    public const int PropertyTagExifVer = 0x9000;
    [NativeTypeName("#define PropertyTagExifDTOrig 0x9003")]
    public const int PropertyTagExifDTOrig = 0x9003;
    [NativeTypeName("#define PropertyTagExifDTDigitized 0x9004")]
    public const int PropertyTagExifDTDigitized = 0x9004;
    [NativeTypeName("#define PropertyTagExifCompConfig 0x9101")]
    public const int PropertyTagExifCompConfig = 0x9101;
    [NativeTypeName("#define PropertyTagExifCompBPP 0x9102")]
    public const int PropertyTagExifCompBPP = 0x9102;
    [NativeTypeName("#define PropertyTagExifShutterSpeed 0x9201")]
    public const int PropertyTagExifShutterSpeed = 0x9201;
    [NativeTypeName("#define PropertyTagExifAperture 0x9202")]
    public const int PropertyTagExifAperture = 0x9202;
    [NativeTypeName("#define PropertyTagExifBrightness 0x9203")]
    public const int PropertyTagExifBrightness = 0x9203;
    [NativeTypeName("#define PropertyTagExifExposureBias 0x9204")]
    public const int PropertyTagExifExposureBias = 0x9204;
    [NativeTypeName("#define PropertyTagExifMaxAperture 0x9205")]
    public const int PropertyTagExifMaxAperture = 0x9205;
    [NativeTypeName("#define PropertyTagExifSubjectDist 0x9206")]
    public const int PropertyTagExifSubjectDist = 0x9206;
    [NativeTypeName("#define PropertyTagExifMeteringMode 0x9207")]
    public const int PropertyTagExifMeteringMode = 0x9207;
    [NativeTypeName("#define PropertyTagExifLightSource 0x9208")]
    public const int PropertyTagExifLightSource = 0x9208;
    [NativeTypeName("#define PropertyTagExifFlash 0x9209")]
    public const int PropertyTagExifFlash = 0x9209;
    [NativeTypeName("#define PropertyTagExifFocalLength 0x920A")]
    public const int PropertyTagExifFocalLength = 0x920A;
    [NativeTypeName("#define PropertyTagExifSubjectArea 0x9214")]
    public const int PropertyTagExifSubjectArea = 0x9214;
    [NativeTypeName("#define PropertyTagExifMakerNote 0x927C")]
    public const int PropertyTagExifMakerNote = 0x927C;
    [NativeTypeName("#define PropertyTagExifUserComment 0x9286")]
    public const int PropertyTagExifUserComment = 0x9286;
    [NativeTypeName("#define PropertyTagExifDTSubsec 0x9290")]
    public const int PropertyTagExifDTSubsec = 0x9290;
    [NativeTypeName("#define PropertyTagExifDTOrigSS 0x9291")]
    public const int PropertyTagExifDTOrigSS = 0x9291;
    [NativeTypeName("#define PropertyTagExifDTDigSS 0x9292")]
    public const int PropertyTagExifDTDigSS = 0x9292;
    [NativeTypeName("#define PropertyTagExifFPXVer 0xA000")]
    public const int PropertyTagExifFPXVer = 0xA000;
    [NativeTypeName("#define PropertyTagExifColorSpace 0xA001")]
    public const int PropertyTagExifColorSpace = 0xA001;
    [NativeTypeName("#define PropertyTagExifPixXDim 0xA002")]
    public const int PropertyTagExifPixXDim = 0xA002;
    [NativeTypeName("#define PropertyTagExifPixYDim 0xA003")]
    public const int PropertyTagExifPixYDim = 0xA003;
    [NativeTypeName("#define PropertyTagExifRelatedWav 0xA004")]
    public const int PropertyTagExifRelatedWav = 0xA004;
    [NativeTypeName("#define PropertyTagExifInterop 0xA005")]
    public const int PropertyTagExifInterop = 0xA005;
    [NativeTypeName("#define PropertyTagExifFlashEnergy 0xA20B")]
    public const int PropertyTagExifFlashEnergy = 0xA20B;
    [NativeTypeName("#define PropertyTagExifSpatialFR 0xA20C")]
    public const int PropertyTagExifSpatialFR = 0xA20C;
    [NativeTypeName("#define PropertyTagExifFocalXRes 0xA20E")]
    public const int PropertyTagExifFocalXRes = 0xA20E;
    [NativeTypeName("#define PropertyTagExifFocalYRes 0xA20F")]
    public const int PropertyTagExifFocalYRes = 0xA20F;
    [NativeTypeName("#define PropertyTagExifFocalResUnit 0xA210")]
    public const int PropertyTagExifFocalResUnit = 0xA210;
    [NativeTypeName("#define PropertyTagExifSubjectLoc 0xA214")]
    public const int PropertyTagExifSubjectLoc = 0xA214;
    [NativeTypeName("#define PropertyTagExifExposureIndex 0xA215")]
    public const int PropertyTagExifExposureIndex = 0xA215;
    [NativeTypeName("#define PropertyTagExifSensingMethod 0xA217")]
    public const int PropertyTagExifSensingMethod = 0xA217;
    [NativeTypeName("#define PropertyTagExifFileSource 0xA300")]
    public const int PropertyTagExifFileSource = 0xA300;
    [NativeTypeName("#define PropertyTagExifSceneType 0xA301")]
    public const int PropertyTagExifSceneType = 0xA301;
    [NativeTypeName("#define PropertyTagExifCfaPattern 0xA302")]
    public const int PropertyTagExifCfaPattern = 0xA302;
    [NativeTypeName("#define PropertyTagExifCustomRendered 0xA401")]
    public const int PropertyTagExifCustomRendered = 0xA401;
    [NativeTypeName("#define PropertyTagExifExposureMode 0xA402")]
    public const int PropertyTagExifExposureMode = 0xA402;
    [NativeTypeName("#define PropertyTagExifWhiteBalance 0xA403")]
    public const int PropertyTagExifWhiteBalance = 0xA403;
    [NativeTypeName("#define PropertyTagExifDigitalZoomRatio 0xA404")]
    public const int PropertyTagExifDigitalZoomRatio = 0xA404;
    [NativeTypeName("#define PropertyTagExifFocalLengthIn35mmFilm 0xA405")]
    public const int PropertyTagExifFocalLengthIn35mmFilm = 0xA405;
    [NativeTypeName("#define PropertyTagExifSceneCaptureType 0xA406")]
    public const int PropertyTagExifSceneCaptureType = 0xA406;
    [NativeTypeName("#define PropertyTagExifGainControl 0xA407")]
    public const int PropertyTagExifGainControl = 0xA407;
    [NativeTypeName("#define PropertyTagExifContrast 0xA408")]
    public const int PropertyTagExifContrast = 0xA408;
    [NativeTypeName("#define PropertyTagExifSaturation 0xA409")]
    public const int PropertyTagExifSaturation = 0xA409;
    [NativeTypeName("#define PropertyTagExifSharpness 0xA40A")]
    public const int PropertyTagExifSharpness = 0xA40A;
    [NativeTypeName("#define PropertyTagExifDeviceSettingDesc 0xA40B")]
    public const int PropertyTagExifDeviceSettingDesc = 0xA40B;
    [NativeTypeName("#define PropertyTagExifSubjectDistanceRange 0xA40C")]
    public const int PropertyTagExifSubjectDistanceRange = 0xA40C;
    [NativeTypeName("#define PropertyTagExifUniqueImageID 0xA420")]
    public const int PropertyTagExifUniqueImageID = 0xA420;
    [NativeTypeName("#define PropertyTagGpsVer 0x0000")]
    public const int PropertyTagGpsVer = 0x0000;
    [NativeTypeName("#define PropertyTagGpsLatitudeRef 0x0001")]
    public const int PropertyTagGpsLatitudeRef = 0x0001;
    [NativeTypeName("#define PropertyTagGpsLatitude 0x0002")]
    public const int PropertyTagGpsLatitude = 0x0002;
    [NativeTypeName("#define PropertyTagGpsLongitudeRef 0x0003")]
    public const int PropertyTagGpsLongitudeRef = 0x0003;
    [NativeTypeName("#define PropertyTagGpsLongitude 0x0004")]
    public const int PropertyTagGpsLongitude = 0x0004;
    [NativeTypeName("#define PropertyTagGpsAltitudeRef 0x0005")]
    public const int PropertyTagGpsAltitudeRef = 0x0005;
    [NativeTypeName("#define PropertyTagGpsAltitude 0x0006")]
    public const int PropertyTagGpsAltitude = 0x0006;
    [NativeTypeName("#define PropertyTagGpsGpsTime 0x0007")]
    public const int PropertyTagGpsGpsTime = 0x0007;
    [NativeTypeName("#define PropertyTagGpsGpsSatellites 0x0008")]
    public const int PropertyTagGpsGpsSatellites = 0x0008;
    [NativeTypeName("#define PropertyTagGpsGpsStatus 0x0009")]
    public const int PropertyTagGpsGpsStatus = 0x0009;
    [NativeTypeName("#define PropertyTagGpsGpsMeasureMode 0x00A")]
    public const int PropertyTagGpsGpsMeasureMode = 0x00A;
    [NativeTypeName("#define PropertyTagGpsGpsDop 0x000B")]
    public const int PropertyTagGpsGpsDop = 0x000B;
    [NativeTypeName("#define PropertyTagGpsSpeedRef 0x000C")]
    public const int PropertyTagGpsSpeedRef = 0x000C;
    [NativeTypeName("#define PropertyTagGpsSpeed 0x000D")]
    public const int PropertyTagGpsSpeed = 0x000D;
    [NativeTypeName("#define PropertyTagGpsTrackRef 0x000E")]
    public const int PropertyTagGpsTrackRef = 0x000E;
    [NativeTypeName("#define PropertyTagGpsTrack 0x000F")]
    public const int PropertyTagGpsTrack = 0x000F;
    [NativeTypeName("#define PropertyTagGpsImgDirRef 0x0010")]
    public const int PropertyTagGpsImgDirRef = 0x0010;
    [NativeTypeName("#define PropertyTagGpsImgDir 0x0011")]
    public const int PropertyTagGpsImgDir = 0x0011;
    [NativeTypeName("#define PropertyTagGpsMapDatum 0x0012")]
    public const int PropertyTagGpsMapDatum = 0x0012;
    [NativeTypeName("#define PropertyTagGpsDestLatRef 0x0013")]
    public const int PropertyTagGpsDestLatRef = 0x0013;
    [NativeTypeName("#define PropertyTagGpsDestLat 0x0014")]
    public const int PropertyTagGpsDestLat = 0x0014;
    [NativeTypeName("#define PropertyTagGpsDestLongRef 0x0015")]
    public const int PropertyTagGpsDestLongRef = 0x0015;
    [NativeTypeName("#define PropertyTagGpsDestLong 0x0016")]
    public const int PropertyTagGpsDestLong = 0x0016;
    [NativeTypeName("#define PropertyTagGpsDestBearRef 0x0017")]
    public const int PropertyTagGpsDestBearRef = 0x0017;
    [NativeTypeName("#define PropertyTagGpsDestBear 0x0018")]
    public const int PropertyTagGpsDestBear = 0x0018;
    [NativeTypeName("#define PropertyTagGpsDestDistRef 0x0019")]
    public const int PropertyTagGpsDestDistRef = 0x0019;
    [NativeTypeName("#define PropertyTagGpsDestDist 0x001A")]
    public const int PropertyTagGpsDestDist = 0x001A;
    [NativeTypeName("#define PropertyTagGpsProcessingMethod 0x001B")]
    public const int PropertyTagGpsProcessingMethod = 0x001B;
    [NativeTypeName("#define PropertyTagGpsAreaInformation 0x001C")]
    public const int PropertyTagGpsAreaInformation = 0x001C;
    [NativeTypeName("#define PropertyTagGpsDate 0x001D")]
    public const int PropertyTagGpsDate = 0x001D;
    [NativeTypeName("#define PropertyTagGpsDifferential 0x001E")]
    public const int PropertyTagGpsDifferential = 0x001E;
}