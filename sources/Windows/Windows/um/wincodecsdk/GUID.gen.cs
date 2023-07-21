// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class GUID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatUnknown
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2F, 0x59, 0x5E, 0xA4,
                0x78, 0x90,
                0x7C, 0x4A,
                0xAD,
                0xB5,
                0x4E,
                0xDC,
                0x4F,
                0xD6,
                0x1B,
                0x1F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatIfd
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC6, 0x96, 0x73, 0x53,
                0x8A, 0x2D,
                0xB6, 0x4B,
                0x9B,
                0xF8,
                0x2F,
                0x0A,
                0x8E,
                0x2A,
                0x3A,
                0xDF
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatSubIfd
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x28, 0xE1, 0xA2, 0x58,
                0xB9, 0x2D,
                0x57, 0x4E,
                0xBB,
                0x14,
                0x51,
                0x77,
                0x89,
                0x1E,
                0xD3,
                0x31
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatExif
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x9D, 0x4F, 0x3C, 0x1C,
                0x4A, 0xB8,
                0x7D, 0x46,
                0x94,
                0x93,
                0x36,
                0xCF,
                0xBD,
                0x59,
                0xEA,
                0x57
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatGps
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8A, 0xAB, 0x34, 0x71,
                0x51, 0x93,
                0xAD, 0x44,
                0xAF,
                0x62,
                0x44,
                0x8D,
                0xB6,
                0xB5,
                0x02,
                0xEC
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatInterop
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8E, 0x6F, 0x68, 0xED,
                0x1F, 0x68,
                0x8B, 0x4C,
                0xBD,
                0x41,
                0xA8,
                0xAD,
                0xDB,
                0xF6,
                0xB3,
                0xFC
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatApp0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x28, 0x70, 0x00, 0x79,
                0x8D, 0x26,
                0xD6, 0x45,
                0xA3,
                0xC2,
                0x35,
                0x4E,
                0x6A,
                0x50,
                0x4B,
                0xC9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatApp1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC3, 0xDF, 0xD3, 0x8F,
                0x51, 0xF9,
                0x2B, 0x49,
                0x81,
                0x7F,
                0x69,
                0xC2,
                0xE6,
                0xD9,
                0xA5,
                0xB0
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatApp13
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA2, 0x56, 0x65, 0x32,
                0x02, 0xF5,
                0x54, 0x43,
                0x9C,
                0xC0,
                0x8E,
                0x3F,
                0x48,
                0xEA,
                0xF6,
                0xB5
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatIPTC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x14, 0x09, 0xAB, 0x4F,
                0x29, 0xE1,
                0x87, 0x40,
                0xA1,
                0xD1,
                0xBC,
                0x81,
                0x2D,
                0x45,
                0xA7,
                0xB5
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatIRB
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x66, 0x0D, 0x10, 0x16,
                0x70, 0x85,
                0xB9, 0x4B,
                0xB9,
                0x2D,
                0xFD,
                0xA4,
                0xB2,
                0x3E,
                0xCE,
                0x67
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormat8BIMIPTC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8C, 0x56, 0x10, 0x00,
                0x52, 0x08,
                0x6A, 0x4E,
                0xB1,
                0x91,
                0x5C,
                0x33,
                0xAC,
                0x5B,
                0x04,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormat8BIMResolutionInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5D, 0x30, 0x9F, 0x73,
                0xDB, 0x81,
                0xCB, 0x43,
                0xAC,
                0x5E,
                0x55,
                0x01,
                0x3E,
                0xF9,
                0xF0,
                0x03
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormat8BIMIPTCDigest
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x85, 0x22, 0xA3, 0x1C,
                0xCD, 0x9C,
                0x86, 0x47,
                0x8B,
                0xD8,
                0x79,
                0x53,
                0x9D,
                0xB6,
                0xA0,
                0x06
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatXMP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x38, 0xCC, 0x5A, 0xBB,
                0x16, 0xF2,
                0xEC, 0x4C,
                0xA6,
                0xC5,
                0x5F,
                0x6E,
                0x73,
                0x97,
                0x63,
                0xA9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatThumbnail
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE9, 0xCE, 0x3D, 0x24,
                0x03, 0x87,
                0xEE, 0x40,
                0x8E,
                0xF0,
                0x22,
                0xA6,
                0x00,
                0xB8,
                0x05,
                0x8C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatChunktEXt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x36, 0x89, 0x8D, 0x56,
                0xA9, 0xC0,
                0x23, 0x49,
                0x90,
                0x5D,
                0xDF,
                0x2B,
                0x38,
                0x23,
                0x8F,
                0xBC
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatXMPStruct
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF1, 0x3C, 0x38, 0x22,
                0x17, 0xED,
                0x2E, 0x4E,
                0xAF,
                0x17,
                0xD8,
                0x5B,
                0x8F,
                0x6B,
                0x30,
                0xD0
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatXMPBag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5F, 0xCA, 0x3C, 0x83,
                0xB7, 0xDC,
                0x16, 0x45,
                0x80,
                0x6F,
                0x65,
                0x96,
                0xAB,
                0x26,
                0xDC,
                0xE4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatXMPSeq
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x02, 0xDF, 0xE8, 0x63,
                0x6C, 0xEB,
                0x6C, 0x45,
                0xA2,
                0x24,
                0xB2,
                0x5E,
                0x79,
                0x4F,
                0xD6,
                0x48
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatXMPAlt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x75, 0xA6, 0x08, 0x7B,
                0xAA, 0x91,
                0x1B, 0x48,
                0xA7,
                0x98,
                0x4D,
                0xA9,
                0x49,
                0x08,
                0x61,
                0x3B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatLSD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1E, 0x03, 0x56, 0xE2,
                0x99, 0x62,
                0x29, 0x49,
                0xB9,
                0x8D,
                0x5A,
                0xC8,
                0x84,
                0xAF,
                0xBA,
                0x92
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatIMD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x86, 0xB0, 0x2B, 0xBD,
                0x52, 0x4D,
                0xDD, 0x48,
                0x96,
                0x77,
                0xDB,
                0x48,
                0x3E,
                0x85,
                0xAE,
                0x8F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatGCE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD8, 0xCA, 0x25, 0x2A,
                0xEB, 0xDE,
                0x69, 0x4C,
                0xA7,
                0x88,
                0x0E,
                0xC2,
                0x26,
                0x6D,
                0xCA,
                0xFD
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatAPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC2, 0x3D, 0x04, 0x2E,
                0x67, 0xC9,
                0x05, 0x4E,
                0x87,
                0x5E,
                0x61,
                0x8B,
                0xF6,
                0x7E,
                0x85,
                0xC3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatJpegChrominance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xCF, 0x0D, 0x3D, 0xF7,
                0xC6, 0xCE,
                0x85, 0x4F,
                0x9B,
                0x0E,
                0x1C,
                0x39,
                0x56,
                0xB1,
                0xBE,
                0xF7
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatJpegLuminance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x07, 0x80, 0x90, 0x86,
                0xFC, 0xED,
                0x60, 0x48,
                0x8D,
                0x4B,
                0x4E,
                0xE6,
                0xE8,
                0x3E,
                0x60,
                0x58
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatJpegComment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x33, 0x5F, 0x0E, 0x22,
                0xD3, 0xAF,
                0x4E, 0x47,
                0x9D,
                0x31,
                0x7D,
                0x4F,
                0xE7,
                0x30,
                0xF5,
                0x57
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatGifComment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE0, 0xE0, 0xB6, 0xC4,
                0xB4, 0xCF,
                0xD3, 0x4A,
                0xAB,
                0x33,
                0x9A,
                0xAD,
                0x23,
                0x55,
                0xA3,
                0x4A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatChunkgAMA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA5, 0x35, 0x09, 0xF0,
                0x5D, 0x1D,
                0xD1, 0x4C,
                0x81,
                0xB2,
                0x93,
                0x24,
                0xD7,
                0xEC,
                0xA7,
                0x81
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatChunkbKGD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x71, 0x35, 0x4D, 0xE1,
                0x47, 0x6B,
                0xEA, 0x4D,
                0xB6,
                0x0A,
                0x87,
                0xCE,
                0x0A,
                0x78,
                0xDF,
                0xB7
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatChunkiTXt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x29, 0xC7, 0xBE, 0xC2,
                0x68, 0x0B,
                0x77, 0x4B,
                0xAA,
                0x0E,
                0x62,
                0x95,
                0xA6,
                0xAC,
                0x18,
                0x14
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatChunkcHRM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5B, 0x65, 0xB3, 0x9D,
                0x42, 0x28,
                0xB3, 0x44,
                0x80,
                0x67,
                0x12,
                0xE9,
                0xB3,
                0x75,
                0x55,
                0x6A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatChunkhIST
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDA, 0x82, 0x9A, 0xC5,
                0x74, 0xDB,
                0xA4, 0x48,
                0xBD,
                0x6A,
                0xB6,
                0x9C,
                0x49,
                0x31,
                0xEF,
                0x95
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatChunkiCCP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAB, 0x49, 0x43, 0xEB,
                0x85, 0xB6,
                0x0F, 0x45,
                0x91,
                0xB5,
                0xE8,
                0x02,
                0xE8,
                0x92,
                0x53,
                0x6C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatChunksRGB
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x36, 0xFD, 0x15, 0xC1,
                0x6F, 0xCC,
                0x3F, 0x4E,
                0x83,
                0x63,
                0x52,
                0x4B,
                0x87,
                0xC6,
                0xB0,
                0xD9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatChunktIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2D, 0xAE, 0x00, 0x6B,
                0x4B, 0xE2,
                0x0A, 0x46,
                0x98,
                0xB6,
                0x87,
                0x8B,
                0xD0,
                0x30,
                0x72,
                0xFD
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatDds
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x03, 0x46, 0x06, 0x4A,
                0x33, 0x8C,
                0x60, 0x4E,
                0x9C,
                0x29,
                0x13,
                0x62,
                0x31,
                0x70,
                0x2D,
                0x08
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatHeif
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE1, 0xF3, 0x7E, 0x81,
                0x88, 0x12,
                0xF4, 0x45,
                0xA8,
                0x52,
                0x26,
                0x0D,
                0x9E,
                0x7C,
                0xCE,
                0x83
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatHeifHDR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8A, 0x8D, 0x8B, 0x56,
                0x65, 0x1E,
                0x8C, 0x43,
                0x89,
                0x68,
                0xD6,
                0x0E,
                0x10,
                0x12,
                0xBE,
                0xB9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatWebpANIM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA6, 0xFD, 0xC4, 0x6D,
                0xE6, 0x78,
                0x02, 0x41,
                0xAE,
                0x35,
                0xBC,
                0xFA,
                0x1E,
                0xDC,
                0xC7,
                0x8B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MetadataFormatWebpANMF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xEE, 0x05, 0xC1, 0x43,
                0x3B, 0xB9,
                0xBB, 0x4A,
                0xB0,
                0x03,
                0xA0,
                0x8C,
                0x0D,
                0x87,
                0x04,
                0x71
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
