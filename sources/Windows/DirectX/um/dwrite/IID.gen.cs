// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IDWriteFontFileLoader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4E,
                0xAD,
                0x7C,
                0x72,
                0xAF,
                0xD6,
                0x9E,
                0x4C,
                0x8A,
                0x08,
                0xD6,
                0x95,
                0xB1,
                0x1C,
                0xAA,
                0x49
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteLocalFontFileLoader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEC,
                0xF3,
                0xD9,
                0xB2,
                0xFE,
                0xC9,
                0x11,
                0x4A,
                0xA2,
                0xEC,
                0xD8,
                0x62,
                0x08,
                0xF7,
                0xC0,
                0xA2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontFileStream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFE,
                0x65,
                0x48,
                0x6D,
                0xB8,
                0x0A,
                0x91,
                0x4D,
                0x8F,
                0x62,
                0x5D,
                0xD6,
                0xBE,
                0x34,
                0xA3,
                0xE0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontFile
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6A,
                0x88,
                0x9D,
                0x73,
                0xF5,
                0xCE,
                0xDC,
                0x47,
                0x87,
                0x69,
                0x1A,
                0x8B,
                0x41,
                0xBE,
                0xBB,
                0xB0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteRenderingParams
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3A,
                0xA5,
                0x0D,
                0x2F,
                0xDD,
                0x2A,
                0xCD,
                0x47,
                0x82,
                0xEE,
                0xD9,
                0xEC,
                0x34,
                0x68,
                0x8E,
                0x75
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontFace
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0x80,
                0x49,
                0x5F,
                0x24,
                0x70,
                0x43,
                0x4D,
                0xBF,
                0xA9,
                0xD2,
                0x59,
                0x84,
                0xF5,
                0x38,
                0x49
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontCollectionLoader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0x20,
                0xA9,
                0xCC,
                0xF0,
                0x52,
                0x2B,
                0x49,
                0xBF,
                0xA8,
                0x29,
                0xC7,
                0x2E,
                0xE0,
                0xA4,
                0x68
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontFileEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0x50,
                0x75,
                0x72,
                0xF7,
                0x5F,
                0x5D,
                0x43,
                0x83,
                0x48,
                0x4B,
                0xE9,
                0x7C,
                0xFA,
                0x6C,
                0x7C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteLocalizedStrings
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x09,
                0x62,
                0x25,
                0x08,
                0x9A,
                0x09,
                0x34,
                0x4B,
                0xB8,
                0x6D,
                0xC2,
                0x2B,
                0x11,
                0x0E,
                0x77,
                0x71
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0xEE,
                0x4C,
                0xA8,
                0xEA,
                0x3E,
                0xEE,
                0x4E,
                0xA8,
                0x27,
                0x87,
                0xC1,
                0xA0,
                0x2A,
                0x0F,
                0xCC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x38,
                0x84,
                0x0D,
                0x1A,
                0x97,
                0x1D,
                0xC1,
                0x4E,
                0xAE,
                0xF9,
                0xA2,
                0xFB,
                0x86,
                0xED,
                0x6A,
                0xCB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontFamily
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEF,
                0xD8,
                0x20,
                0xDA,
                0x2A,
                0x81,
                0x43,
                0x4C,
                0x98,
                0x02,
                0x62,
                0xEC,
                0x4A,
                0xBD,
                0x7A,
                0xDD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFont
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x96,
                0x66,
                0xD1,
                0xAC,
                0x14,
                0x8C,
                0x5D,
                0x4F,
                0x87,
                0x7E,
                0xFE,
                0x3F,
                0xC1,
                0xD3,
                0x27,
                0x37
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteTextFormat
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x18,
                0x68,
                0x90,
                0x9C,
                0xD7,
                0x31,
                0xD3,
                0x4F,
                0xA1,
                0x51,
                0x7C,
                0x5E,
                0x22,
                0x5D,
                0xB5,
                0x5A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteTypography
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0x11,
                0xF1,
                0x55,
                0xC2,
                0x1D,
                0x3C,
                0x4B,
                0x95,
                0x41,
                0xF4,
                0x68,
                0x94,
                0xED,
                0x85,
                0xB6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteNumberSubstitution
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC9,
                0x5C,
                0x88,
                0x14,
                0xB0,
                0xBA,
                0x90,
                0x4F,
                0xB6,
                0xED,
                0x5C,
                0x36,
                0x6A,
                0x2C,
                0xD0,
                0x3D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteTextAnalysisSource
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x58,
                0x1A,
                0x8E,
                0x68,
                0x94,
                0x50,
                0xC8,
                0x47,
                0xAD,
                0xC8,
                0xFB,
                0xCE,
                0xA6,
                0x0A,
                0xE9,
                0x2B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteTextAnalysisSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0xCD,
                0x10,
                0x58,
                0xA0,
                0x0C,
                0x01,
                0x47,
                0xB3,
                0xFA,
                0xBE,
                0xC5,
                0x18,
                0x2A,
                0xE4,
                0xF6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteTextAnalyzer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3E,
                0x16,
                0xE6,
                0xB7,
                0x46,
                0x7F,
                0xB4,
                0x43,
                0x84,
                0xB3,
                0xE4,
                0xE6,
                0x24,
                0x9C,
                0x36,
                0x5D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteInlineObject
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE3,
                0xFD,
                0x39,
                0x83,
                0x6F,
                0x10,
                0xAB,
                0x47,
                0x83,
                0x73,
                0x1C,
                0x62,
                0x95,
                0xEB,
                0x10,
                0xB3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWritePixelSnapping
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDA,
                0xA2,
                0xF3,
                0xEA,
                0xF4,
                0xEC,
                0x24,
                0x4D,
                0xB6,
                0x44,
                0xB3,
                0x4F,
                0x68,
                0x42,
                0x02,
                0x4B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteTextRenderer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x35,
                0x81,
                0x8A,
                0xEF,
                0xC6,
                0x5C,
                0xFE,
                0x45,
                0x88,
                0x25,
                0xC5,
                0xA0,
                0x72,
                0x4E,
                0xB8,
                0x19
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteTextLayout
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x37,
                0x70,
                0x73,
                0x53,
                0x14,
                0x6D,
                0x0B,
                0x41,
                0x9B,
                0xFE,
                0x0B,
                0x18,
                0x2B,
                0xB7,
                0x09,
                0x61
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteBitmapRenderTarget
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA3,
                0x32,
                0x5A,
                0x5E,
                0xFF,
                0x8D,
                0x73,
                0x47,
                0x9F,
                0xF6,
                0x06,
                0x96,
                0xEA,
                0xB7,
                0x72,
                0x67
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteGdiInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x91,
                0x94,
                0xDD,
                0x1E,
                0x53,
                0x98,
                0x99,
                0x42,
                0x89,
                0x8F,
                0x64,
                0x32,
                0x98,
                0x3B,
                0x6F,
                0x3A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteGlyphRunAnalysis
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF7,
                0xDB,
                0x97,
                0x7D,
                0x85,
                0xE0,
                0xD4,
                0x42,
                0x81,
                0xE3,
                0x6A,
                0x88,
                0x3B,
                0xDE,
                0xD1,
                0x18
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5A,
                0xEE,
                0x59,
                0xB8,
                0x38,
                0xD8,
                0x5B,
                0x4B,
                0xA2,
                0xE8,
                0x1A,
                0xDC,
                0x7D,
                0x93,
                0xDB,
                0x48
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}