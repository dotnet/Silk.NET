// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class CLSID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICUnknownMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC2,
                0x45,
                0x97,
                0x69,
                0x66,
                0x50,
                0x82,
                0x4B,
                0xA8,
                0xE3,
                0xD4,
                0x04,
                0x78,
                0xDB,
                0xEC,
                0x8C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICUnknownMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x86,
                0xCA,
                0x9C,
                0xA0,
                0xBA,
                0x27,
                0x39,
                0x4F,
                0x90,
                0x53,
                0x12,
                0x1F,
                0xA4,
                0xDC,
                0x08,
                0xFC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICApp0MetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA2,
                0x33,
                0xC6,
                0xF3,
                0xC8,
                0x46,
                0x8E,
                0x49,
                0x8F,
                0xBB,
                0xCC,
                0x6F,
                0x72,
                0x1B,
                0xBC,
                0xDE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICApp0MetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0x4B,
                0x32,
                0x43,
                0x8F,
                0xA7,
                0x0F,
                0x48,
                0x91,
                0x11,
                0x96,
                0x38,
                0xAA,
                0xCC,
                0xC8,
                0x32
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICApp1MetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x69,
                0x60,
                0x36,
                0xEE,
                0x32,
                0x18,
                0x0F,
                0x42,
                0xB3,
                0x81,
                0x04,
                0x79,
                0xAD,
                0x06,
                0x6F,
                0x19
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICApp1MetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x13,
                0x35,
                0xE3,
                0xDD,
                0x4E,
                0x77,
                0xCD,
                0x4B,
                0xAE,
                0x79,
                0x02,
                0xF4,
                0xAD,
                0xFE,
                0x62,
                0xFC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICApp13MetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0xA9,
                0x19,
                0x7B,
                0xD6,
                0xA9,
                0xE5,
                0x49,
                0xBD,
                0x45,
                0x02,
                0xC3,
                0x4E,
                0x4E,
                0x4C,
                0xD5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICApp13MetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x50,
                0x3C,
                0x7E,
                0xAA,
                0x4C,
                0x86,
                0x04,
                0x46,
                0xBC,
                0x04,
                0x8B,
                0x0B,
                0x76,
                0xE6,
                0x37,
                0xF6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICIfdMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x56,
                0x46,
                0x91,
                0x8F,
                0x0A,
                0x9D,
                0xB2,
                0x4E,
                0x90,
                0x19,
                0x0B,
                0xF9,
                0x6D,
                0x8A,
                0x9E,
                0xE6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICIfdMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x28,
                0xFC,
                0xEB,
                0xB1,
                0xBD,
                0xC9,
                0xA2,
                0x47,
                0x8D,
                0x33,
                0xB9,
                0x48,
                0x76,
                0x97,
                0x77,
                0xA7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICSubIfdMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x09,
                0x2F,
                0xD4,
                0x50,
                0xD1,
                0xEC,
                0x41,
                0x4B,
                0xB6,
                0x5D,
                0xDA,
                0x1F,
                0xDA,
                0xA7,
                0x56,
                0x63
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICSubIfdMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x86,
                0x53,
                0xDE,
                0x8A,
                0x9B,
                0x8E,
                0x4C,
                0x4F,
                0xAC,
                0xF2,
                0xF0,
                0x00,
                0x87,
                0x06,
                0xB2,
                0x38
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICExifMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0x38,
                0x40,
                0xD9,
                0x7F,
                0x29,
                0x49,
                0x4A,
                0xBF,
                0x9B,
                0x77,
                0x89,
                0x81,
                0x50,
                0xA4,
                0x42
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICExifMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDA,
                0x4C,
                0xA1,
                0xC9,
                0x39,
                0xC3,
                0x0B,
                0x46,
                0x90,
                0x78,
                0xD4,
                0xDE,
                0xBC,
                0xFA,
                0xBE,
                0x91
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICGpsMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0B,
                0x79,
                0x97,
                0x36,
                0x3B,
                0x22,
                0x4E,
                0x48,
                0x99,
                0x25,
                0xC4,
                0x86,
                0x92,
                0x18,
                0xF1,
                0x7A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICGpsMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0x13,
                0x8C,
                0xCB,
                0xB5,
                0x62,
                0x96,
                0x4C,
                0xA4,
                0x8B,
                0x6B,
                0xA6,
                0xAC,
                0xE3,
                0x9C,
                0x76
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICInteropMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x98,
                0xB8,
                0xC8,
                0xB5,
                0x74,
                0x00,
                0x9F,
                0x45,
                0xB7,
                0x00,
                0x86,
                0x0D,
                0x46,
                0x51,
                0xEA,
                0x14
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICInteropMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x45,
                0xC6,
                0x2E,
                0x12,
                0x7E,
                0xCD,
                0xD8,
                0x44,
                0xB1,
                0x86,
                0x2C,
                0x8C,
                0x20,
                0xC3,
                0xB5,
                0x0F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICThumbnailMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x59,
                0x29,
                0x01,
                0xFB,
                0xF6,
                0xF4,
                0xD7,
                0x44,
                0x9D,
                0x09,
                0xDA,
                0xA0,
                0x87,
                0xA9,
                0xDB,
                0x57
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICThumbnailMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0xB2,
                0x49,
                0xD0,
                0xD0,
                0x5D,
                0xFE,
                0x44,
                0xB0,
                0xB3,
                0x8F,
                0x92,
                0xC8,
                0xE6,
                0xD0,
                0x80
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICIPTCMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x59,
                0x29,
                0x01,
                0x03,
                0xF6,
                0xF4,
                0xD7,
                0x44,
                0x9D,
                0x09,
                0xDA,
                0xA0,
                0x87,
                0xA9,
                0xDB,
                0x57
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICIPTCMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0xB2,
                0x49,
                0x12,
                0xD0,
                0x5D,
                0xFE,
                0x44,
                0xB0,
                0xB3,
                0x8F,
                0x92,
                0xC8,
                0xE6,
                0xD0,
                0x80
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICIRBMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD7,
                0xD3,
                0xDC,
                0xD4,
                0xC2,
                0xB4,
                0xD9,
                0x47,
                0xA6,
                0xBF,
                0xB8,
                0x9B,
                0xA3,
                0x96,
                0xA4,
                0xA3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICIRBMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x35,
                0x19,
                0x5C,
                0x5C,
                0x35,
                0x02,
                0x34,
                0x44,
                0x80,
                0xBC,
                0x25,
                0x1B,
                0xC1,
                0xEC,
                0x39,
                0xC6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WIC8BIMIPTCMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8C,
                0x66,
                0x10,
                0x00,
                0x01,
                0x08,
                0xA6,
                0x4D,
                0xA4,
                0xA4,
                0x82,
                0x65,
                0x22,
                0xB6,
                0xD2,
                0x8F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WIC8BIMIPTCMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x26,
                0x82,
                0x10,
                0x00,
                0x41,
                0xEE,
                0xA2,
                0x44,
                0x9E,
                0x9C,
                0x4B,
                0xE4,
                0xD5,
                0xB1,
                0xD2,
                0xCD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WIC8BIMResolutionInfoMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7A,
                0x13,
                0x05,
                0x58,
                0x48,
                0xE3,
                0x7C,
                0x4F,
                0xB3,
                0xCC,
                0x6D,
                0xB9,
                0x96,
                0x5A,
                0x05,
                0x99
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WIC8BIMResolutionInfoMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0xFE,
                0xF2,
                0x4F,
                0x4A,
                0xE7,
                0x71,
                0x4B,
                0x98,
                0xC4,
                0xAB,
                0x7D,
                0xC1,
                0x67,
                0x07,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WIC8BIMIPTCDigestMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1E,
                0x5F,
                0x80,
                0x02,
                0xAA,
                0xD5,
                0x5B,
                0x41,
                0x82,
                0xC5,
                0x61,
                0xC0,
                0x33,
                0xA9,
                0x88,
                0xA6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WIC8BIMIPTCDigestMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0xE6,
                0xB5,
                0x2D,
                0x67,
                0x0D,
                0x5F,
                0x49,
                0x8F,
                0x9D,
                0xC2,
                0xF0,
                0x18,
                0x86,
                0x47,
                0xAC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngTextMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCC,
                0xAF,
                0x59,
                0x4B,
                0xC3,
                0xB8,
                0x8A,
                0x40,
                0xB6,
                0x70,
                0x89,
                0xE5,
                0xFA,
                0xB6,
                0xFD,
                0xA7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngTextMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB9,
                0xAF,
                0xEB,
                0xB5,
                0x3E,
                0x25,
                0x72,
                0x4A,
                0xA7,
                0x44,
                0x07,
                0x62,
                0xD2,
                0x68,
                0x56,
                0x83
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICXMPMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0x24,
                0xB6,
                0x72,
                0x11,
                0xAE,
                0x48,
                0x49,
                0xA6,
                0x5C,
                0x35,
                0x1E,
                0xB0,
                0x82,
                0x94,
                0x19
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICXMPMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4E,
                0xE1,
                0x65,
                0x17,
                0xD4,
                0x1B,
                0x2E,
                0x46,
                0xB6,
                0xB1,
                0x59,
                0x0B,
                0xF1,
                0x26,
                0x2A,
                0xC6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICXMPStructMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9A,
                0x0D,
                0xB9,
                0x01,
                0x09,
                0x82,
                0xF7,
                0x47,
                0x9C,
                0x52,
                0xE1,
                0x24,
                0x4B,
                0xF5,
                0x0C,
                0xED
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICXMPStructMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x93,
                0x1F,
                0xC2,
                0x22,
                0xDB,
                0x7D,
                0x1C,
                0x41,
                0x9B,
                0x17,
                0xC5,
                0xB7,
                0xBD,
                0x06,
                0x4A,
                0xBC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICXMPBagMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0x9A,
                0xE7,
                0xE7,
                0x2C,
                0x4F,
                0xAB,
                0x4F,
                0x8D,
                0x00,
                0x39,
                0x4F,
                0x2D,
                0x6B,
                0xBE,
                0xBE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICXMPBagMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8C,
                0x2C,
                0x82,
                0xED,
                0xBE,
                0xD6,
                0x01,
                0x43,
                0xA6,
                0x31,
                0x0E,
                0x14,
                0x16,
                0xBA,
                0xD2,
                0x8F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICXMPSeqMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x53,
                0xE7,
                0x12,
                0x7F,
                0x71,
                0xFC,
                0xD7,
                0x43,
                0xA5,
                0x1D,
                0x92,
                0xF3,
                0x59,
                0x77,
                0xAB,
                0xB5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICXMPSeqMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDE,
                0xD1,
                0x68,
                0x6D,
                0x32,
                0xD4,
                0x0F,
                0x4B,
                0x92,
                0x3A,
                0x09,
                0x11,
                0x83,
                0xA9,
                0xBD,
                0xA7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICXMPAltMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC2,
                0xDC,
                0x94,
                0xAA,
                0xB0,
                0xB8,
                0x98,
                0x48,
                0xB8,
                0x35,
                0x00,
                0x0A,
                0xAB,
                0xD7,
                0x43,
                0x93
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICXMPAltMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6C,
                0x2A,
                0x6C,
                0x07,
                0x8F,
                0xF7,
                0x46,
                0x4C,
                0xA7,
                0x23,
                0x35,
                0x83,
                0xE7,
                0x08,
                0x76,
                0xEA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICLSDMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x93,
                0x07,
                0x07,
                0x41,
                0xE4,
                0x59,
                0x9A,
                0x47,
                0xA1,
                0xF7,
                0x95,
                0x4A,
                0xDC,
                0x2E,
                0xF5,
                0xFC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICLSDMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE7,
                0x37,
                0xC0,
                0x73,
                0xD9,
                0xE5,
                0x54,
                0x49,
                0x87,
                0x6A,
                0x6D,
                0xA8,
                0x1D,
                0x6E,
                0x57,
                0x68
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICGCEMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5D,
                0x34,
                0x2E,
                0xB9,
                0x2D,
                0xF5,
                0xF3,
                0x41,
                0xB5,
                0x62,
                0x08,
                0x1B,
                0xC7,
                0x72,
                0xE3,
                0xB9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICGCEMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x76,
                0xDC,
                0x95,
                0xAF,
                0xB2,
                0x16,
                0xF4,
                0x47,
                0xB3,
                0xEA,
                0x3C,
                0x31,
                0x79,
                0x66,
                0x93,
                0xE7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICIMDMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x67,
                0xA2,
                0x47,
                0x74,
                0x15,
                0x00,
                0xC8,
                0x42,
                0xA8,
                0xF1,
                0xFB,
                0x3B,
                0x94,
                0xC6,
                0x83,
                0x61
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICIMDMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1F,
                0x07,
                0x89,
                0x8C,
                0x2E,
                0x45,
                0x95,
                0x4E,
                0x96,
                0x82,
                0x9D,
                0x10,
                0x24,
                0x62,
                0x71,
                0x72
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICAPEMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3A,
                0xB9,
                0x67,
                0x17,
                0x21,
                0xB0,
                0xEA,
                0x44,
                0x92,
                0x0F,
                0x86,
                0x3C,
                0x11,
                0xF4,
                0xF7,
                0x68
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICAPEMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0xDF,
                0x6E,
                0xBD,
                0x90,
                0x28,
                0x2F,
                0x48,
                0xB2,
                0x33,
                0x8D,
                0x73,
                0x39,
                0xA1,
                0xCF,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICJpegChrominanceMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4B,
                0x90,
                0xB1,
                0x50,
                0x8F,
                0xF2,
                0x74,
                0x45,
                0x93,
                0xF4,
                0x0B,
                0xAD,
                0xE8,
                0x2C,
                0x69,
                0xE9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICJpegChrominanceMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF0,
                0x66,
                0xF5,
                0x3F,
                0x6B,
                0x6E,
                0xD4,
                0x49,
                0x96,
                0xE6,
                0xB7,
                0x88,
                0x86,
                0x69,
                0x2C,
                0x62
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICJpegLuminanceMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x88,
                0x2F,
                0x6F,
                0x35,
                0xA6,
                0x05,
                0x28,
                0x47,
                0xB9,
                0xA4,
                0x1B,
                0xFB,
                0xCE,
                0x04,
                0xD8,
                0x38
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICJpegLuminanceMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0x3A,
                0x58,
                0x1D,
                0x0E,
                0x8A,
                0x57,
                0x46,
                0x99,
                0x82,
                0xA3,
                0x80,
                0xCA,
                0x58,
                0xFB,
                0x4B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICJpegCommentMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0x34,
                0x66,
                0x9F,
                0xC4,
                0x60,
                0x4D,
                0x4C,
                0xAB,
                0x58,
                0xD2,
                0x35,
                0x86,
                0x85,
                0xF6,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICJpegCommentMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6F,
                0x23,
                0x73,
                0xE5,
                0xB1,
                0x55,
                0xDA,
                0x4E,
                0x81,
                0xEA,
                0x9F,
                0x65,
                0xDB,
                0x02,
                0x90,
                0xD3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICGifCommentMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0x7D,
                0x55,
                0x32,
                0xDC,
                0x69,
                0x95,
                0x4F,
                0x83,
                0x6E,
                0xF5,
                0x97,
                0x2B,
                0x2F,
                0x61,
                0x59
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICGifCommentMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFC,
                0x97,
                0x27,
                0xA0,
                0xAE,
                0xC4,
                0x8C,
                0x41,
                0xAF,
                0x95,
                0xE6,
                0x37,
                0xC7,
                0xEA,
                0xD2,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngGamaMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x39,
                0xCA,
                0x92,
                0x36,
                0x82,
                0xE0,
                0x50,
                0x43,
                0x9E,
                0x1F,
                0x37,
                0x04,
                0xCB,
                0x08,
                0x3C,
                0xD5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngGamaMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x13,
                0x6D,
                0x03,
                0xFF,
                0x4B,
                0x5D,
                0xDD,
                0x46,
                0xB1,
                0x0F,
                0x10,
                0x66,
                0x93,
                0xD9,
                0xFE,
                0x4F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngBkgdMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA6,
                0xA4,
                0xE7,
                0x0C,
                0xE8,
                0x03,
                0x60,
                0x4A,
                0x9D,
                0x15,
                0x28,
                0x2E,
                0xF3,
                0x2E,
                0xE7,
                0xDA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngBkgdMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFD,
                0xF2,
                0xE3,
                0x68,
                0xAE,
                0x31,
                0x41,
                0x44,
                0xBB,
                0x6A,
                0xFD,
                0x70,
                0x47,
                0x52,
                0x5F,
                0x90
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngItxtMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFA,
                0xB2,
                0xBF,
                0xAA,
                0x1E,
                0x3E,
                0x8F,
                0x4A,
                0x89,
                0x77,
                0x55,
                0x56,
                0xFB,
                0x94,
                0xEA,
                0x23
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngItxtMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0x97,
                0x87,
                0x31,
                0x51,
                0xE7,
                0xF8,
                0x4D,
                0x98,
                0x1D,
                0x68,
                0xDF,
                0xF6,
                0x77,
                0x04,
                0xED
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngChrmMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x36,
                0x5F,
                0x0B,
                0xF9,
                0x7B,
                0x36,
                0x2A,
                0x40,
                0x9D,
                0xD1,
                0xBC,
                0x0F,
                0xD5,
                0x9D,
                0x8F,
                0x62
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngChrmMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEB,
                0xE3,
                0x3C,
                0xE2,
                0x08,
                0x56,
                0x83,
                0x4E,
                0xBC,
                0xEF,
                0x27,
                0xB1,
                0x98,
                0x7E,
                0x51,
                0xD7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngHistMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB7,
                0x0B,
                0x7A,
                0x87,
                0x13,
                0xA3,
                0x91,
                0x44,
                0x87,
                0xB5,
                0x2E,
                0x6D,
                0x05,
                0x94,
                0xF5,
                0x20
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngHistMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0xE7,
                0x03,
                0x8A,
                0x2E,
                0x67,
                0x6E,
                0x44,
                0xBF,
                0x1F,
                0x2C,
                0x11,
                0xD2,
                0x33,
                0xB6,
                0xFF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngIccpMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0xE6,
                0xD3,
                0xF5,
                0x0F,
                0xCB,
                0x28,
                0x46,
                0xA4,
                0x78,
                0x6D,
                0x82,
                0x44,
                0xBE,
                0x36,
                0xB1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngIccpMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5F,
                0x1E,
                0x67,
                0x16,
                0xE6,
                0x0C,
                0xC4,
                0x4C,
                0x97,
                0x68,
                0xE8,
                0x9F,
                0xE5,
                0x01,
                0x8A,
                0xDE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngSrgbMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0x36,
                0x40,
                0xFB,
                0x7E,
                0x54,
                0x56,
                0x49,
                0xA3,
                0xB9,
                0xD4,
                0x41,
                0x88,
                0x59,
                0xBA,
                0x66
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngSrgbMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0x35,
                0xEE,
                0xA6,
                0xEC,
                0x87,
                0xDF,
                0x47,
                0x9F,
                0x22,
                0x1D,
                0x5A,
                0xAD,
                0x84,
                0x0C,
                0x82
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngTimeMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0xDF,
                0x4E,
                0xD9,
                0xE5,
                0xEF,
                0x0D,
                0x4F,
                0x85,
                0xC8,
                0xF5,
                0xA6,
                0x8B,
                0x30,
                0x00,
                0xB1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICPngTimeMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x84,
                0xB7,
                0x1A,
                0xA3,
                0xB5,
                0x91,
                0x4D,
                0x8A,
                0xCE,
                0x33,
                0xFC,
                0xD1,
                0x49,
                0x9B,
                0xE6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICDdsMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0x88,
                0x6C,
                0x27,
                0x33,
                0x75,
                0x86,
                0x4A,
                0xB6,
                0x76,
                0x66,
                0xB3,
                0x60,
                0x80,
                0xD4,
                0x84
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICDdsMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBD,
                0x8B,
                0x68,
                0xFD,
                0xED,
                0x31,
                0xB7,
                0x4D,
                0xA7,
                0x23,
                0x93,
                0x49,
                0x27,
                0xD3,
                0x83,
                0x67
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICHeifMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3F,
                0xFC,
                0xDD,
                0xAC,
                0xEC,
                0x85,
                0xBC,
                0x41,
                0xBD,
                0xEF,
                0x1B,
                0xC2,
                0x62,
                0xE4,
                0xDB,
                0x05
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICHeifMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x79,
                0x5E,
                0xE4,
                0x3A,
                0xBC,
                0x40,
                0x01,
                0x44,
                0xAC,
                0xE5,
                0xDD,
                0x3C,
                0xB1,
                0x6E,
                0x6A,
                0xFE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICHeifHDRMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3D,
                0xDE,
                0x38,
                0x24,
                0xD9,
                0x94,
                0xE8,
                0x4B,
                0x84,
                0xA8,
                0x4D,
                0xE9,
                0x5A,
                0x57,
                0x5E,
                0x75
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICWebpAnimMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0x99,
                0x6F,
                0x07,
                0x48,
                0xA3,
                0x5C,
                0x46,
                0xA8,
                0x07,
                0xA2,
                0x52,
                0xF3,
                0xF2,
                0xD3,
                0xDE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WICWebpAnmfMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0x0B,
                0xA1,
                0x85,
                0xF6,
                0xC9,
                0x9F,
                0x43,
                0xBE,
                0x5E,
                0xC0,
                0xFB,
                0xEF,
                0x67,
                0x80,
                0x7C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}