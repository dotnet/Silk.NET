// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IDWriteRenderingParams3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAA, 0x4B, 0x92, 0xB7,
                0x1B, 0x39,
                0x2A, 0x41,
                0x8C,
                0x5C,
                0xE4,
                0x4C,
                0xC2,
                0xD8,
                0x67,
                0xDC
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFactory3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC3, 0x41, 0x1B, 0x9A,
                0xBB, 0xD3,
                0x6A, 0x46,
                0x87,
                0xFC,
                0xFE,
                0x67,
                0x55,
                0x6A,
                0x3B,
                0x65
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontSet
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x41, 0x51, 0x58, 0x53,
                0xF8, 0xD9,
                0x95, 0x40,
                0x83,
                0x21,
                0xD7,
                0x3C,
                0xF6,
                0xBD,
                0x11,
                0x6B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontSetBuilder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xFE, 0x2A, 0x64, 0x2F,
                0x68, 0x9C,
                0x40, 0x4F,
                0xB8,
                0xBE,
                0x45,
                0x74,
                0x01,
                0xAF,
                0xCB,
                0x3D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontCollection1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x41, 0x51, 0x58, 0x53,
                0xF8, 0xD9,
                0x95, 0x40,
                0x83,
                0x21,
                0xD7,
                0x3C,
                0xF6,
                0xBD,
                0x11,
                0x6C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontFamily1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xEF, 0xD8, 0x20, 0xDA,
                0x2A, 0x81,
                0x43, 0x4C,
                0x98,
                0x02,
                0x62,
                0xEC,
                0x4A,
                0xBD,
                0x7A,
                0xDF
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontList1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xEF, 0xD8, 0x20, 0xDA,
                0x2A, 0x81,
                0x43, 0x4C,
                0x98,
                0x02,
                0x62,
                0xEC,
                0x4A,
                0xBD,
                0x7A,
                0xDE
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontFaceReference
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xCA, 0xA7, 0x7F, 0x5E,
                0xE3, 0xDD,
                0x4C, 0x42,
                0x89,
                0xF0,
                0x9F,
                0xCD,
                0x6F,
                0xED,
                0x58,
                0xCD
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFont3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD6, 0x8E, 0x74, 0x29,
                0x9C, 0x8C,
                0x6A, 0x4A,
                0xBE,
                0x0B,
                0xD9,
                0x12,
                0xE8,
                0x53,
                0x89,
                0x44
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontFace3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x98, 0x75, 0x7D, 0xD3,
                0xBE, 0x09,
                0x22, 0x42,
                0xA2,
                0x36,
                0x20,
                0x81,
                0x34,
                0x1C,
                0xC1,
                0xF2
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteStringList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x40, 0x31, 0xEE, 0xCF,
                0x57, 0x11,
                0xCA, 0x47,
                0x8B,
                0x85,
                0x31,
                0xBF,
                0xCF,
                0x3F,
                0x2D,
                0x0E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontDownloadListener
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB9, 0xE5, 0x6F, 0xB0,
                0xEC, 0x43,
                0x93, 0x43,
                0x88,
                0x1B,
                0xDB,
                0xE4,
                0xDC,
                0x72,
                0xFD,
                0xA7
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontDownloadQueue
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x52, 0x60, 0x1E, 0xB7,
                0xEA, 0x5A,
                0xA3, 0x4F,
                0x83,
                0x2E,
                0xF6,
                0x0D,
                0x43,
                0x1F,
                0x7E,
                0x91
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteGdiInterop1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x70, 0xBE, 0x56, 0x45,
                0xBD, 0x3A,
                0x70, 0x4F,
                0x90,
                0xBE,
                0x42,
                0x17,
                0x80,
                0xA6,
                0xF5,
                0x15
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteTextFormat2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDD, 0x0E, 0x7E, 0xF6,
                0x3D, 0x9E,
                0xCC, 0x4E,
                0x8C,
                0x32,
                0x41,
                0x83,
                0x25,
                0x3D,
                0xFE,
                0x70
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteTextLayout3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x52, 0xCD, 0xDD, 0x07,
                0x0E, 0x02,
                0xE8, 0x4D,
                0xAC,
                0x33,
                0x6C,
                0x95,
                0x3D,
                0x83,
                0xF9,
                0x2D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteColorGlyphRunEnumerator1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDA, 0x86, 0x5F, 0x7C,
                0xA1, 0xC7,
                0x05, 0x4F,
                0xB8,
                0xE1,
                0x55,
                0xA1,
                0x79,
                0xFE,
                0x5A,
                0x35
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontFace4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x04, 0xA9, 0xF2, 0x27,
                0xB8, 0x4E,
                0x1D, 0x44,
                0x96,
                0x78,
                0x05,
                0x63,
                0xF5,
                0x3E,
                0x3E,
                0x2F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFactory4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD3, 0x5B, 0x0B, 0x4B,
                0x97, 0x07,
                0x49, 0x45,
                0x8A,
                0xC5,
                0xFE,
                0x91,
                0x5C,
                0xC5,
                0x38,
                0x56
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontSetBuilder1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5F, 0x71, 0xF7, 0x3F,
                0xDC, 0x3C,
                0xC6, 0x4D,
                0x9B,
                0x72,
                0xEC,
                0x56,
                0x21,
                0xDC,
                0xCA,
                0xFD
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteAsyncResult
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xFD, 0xF8, 0x25, 0xCE,
                0x3B, 0x86,
                0x13, 0x4D,
                0x96,
                0x51,
                0xC1,
                0xF8,
                0x8D,
                0xC7,
                0x3F,
                0xE2
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteRemoteFontFileStream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x7A, 0x75, 0xB3, 0x4D,
                0x72, 0x2C,
                0xD9, 0x4E,
                0xB2,
                0xB6,
                0x1A,
                0xBA,
                0xBE,
                0x1A,
                0xFF,
                0x9C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteRemoteFontFileLoader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x83, 0x8C, 0x64, 0x68,
                0xDE, 0x6E,
                0xC0, 0x46,
                0xAB,
                0x46,
                0x20,
                0x08,
                0x3A,
                0x88,
                0x7F,
                0xDE
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteInMemoryFontFileLoader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x47, 0x2F, 0x10, 0xDC,
                0x2D, 0xA1,
                0x1C, 0x4B,
                0x82,
                0x2D,
                0x9E,
                0x11,
                0x7E,
                0x33,
                0x04,
                0x3F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFactory5
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x9A, 0xB9, 0x8D, 0x95,
                0x2A, 0xBE,
                0x09, 0x4F,
                0xAF,
                0x7D,
                0x65,
                0x18,
                0x98,
                0x03,
                0xD1,
                0xD3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFactory6
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x80, 0x4D, 0x74, 0xF3,
                0xF7, 0x21,
                0xEB, 0x42,
                0xB3,
                0x5D,
                0x99,
                0x5B,
                0xC7,
                0x2F,
                0xC2,
                0x23
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontFace5
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA5, 0xF3, 0xEF, 0x98,
                0x67, 0xB6,
                0x9A, 0x47,
                0xB1,
                0x45,
                0xE2,
                0xFA,
                0x5B,
                0x9F,
                0xDC,
                0x29
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontResource
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x76, 0x3A, 0x80, 0x1F,
                0x71, 0x68,
                0xE8, 0x48,
                0x98,
                0x7F,
                0xB9,
                0x75,
                0x55,
                0x1C,
                0x50,
                0xF2
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontFaceReference1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x77, 0xFE, 0x81, 0xC0,
                0xD1, 0x2F,
                0xAC, 0x41,
                0xA5,
                0xA3,
                0x34,
                0x98,
                0x3C,
                0x4B,
                0xA6,
                0x1A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontSetBuilder2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x12, 0xA6, 0x5B, 0xEE,
                0x31, 0xB1,
                0x3C, 0x46,
                0x8F,
                0x4F,
                0x31,
                0x89,
                0xB9,
                0x40,
                0x1E,
                0x45
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontSet1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x85, 0xDA, 0x9F, 0x7E,
                0x92, 0x6C,
                0x53, 0x40,
                0xBC,
                0x47,
                0x7A,
                0xE3,
                0x53,
                0x0D,
                0xB4,
                0xD3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontList2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x34, 0x3A, 0x76, 0xC0,
                0xAF, 0x77,
                0x5A, 0x44,
                0xB7,
                0x35,
                0x08,
                0xC3,
                0x7B,
                0x0A,
                0x5B,
                0xF5
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontFamily2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x77, 0x9E, 0xD4, 0x3E,
                0x98, 0xA3,
                0x61, 0x42,
                0xB9,
                0xCF,
                0xC1,
                0x26,
                0xC2,
                0x13,
                0x1E,
                0xF3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontCollection2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC6, 0x39, 0x40, 0x51,
                0x17, 0x46,
                0x64, 0x40,
                0xBF,
                0x8B,
                0x92,
                0xEA,
                0x83,
                0xE5,
                0x06,
                0xE0
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteTextLayout4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x42, 0xBF, 0xA9, 0x05,
                0x3F, 0x22,
                0x41, 0x44,
                0xB5,
                0xFB,
                0x82,
                0x63,
                0x68,
                0x5F,
                0x55,
                0xE9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteTextFormat3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x41, 0x56, 0x3B, 0x6D,
                0x50, 0xE5,
                0x0D, 0x43,
                0xA8,
                0x5B,
                0xB7,
                0xBF,
                0x48,
                0xA9,
                0x34,
                0x27
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontFallback1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x9D, 0x59, 0x97, 0x23,
                0x0D, 0xDD,
                0x81, 0x46,
                0xBD,
                0x6A,
                0xF4,
                0xF3,
                0x1E,
                0xAA,
                0xDE,
                0x77
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontSet2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x19, 0xAD, 0x7E, 0xDC,
                0x4C, 0xE5,
                0xAF, 0x43,
                0xB2,
                0xDA,
                0x4E,
                0x2B,
                0x79,
                0xBA,
                0x3F,
                0x7F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontCollection3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA6, 0x55, 0xD0, 0xA4,
                0xE3, 0xF9,
                0x25, 0x4E,
                0x93,
                0xB7,
                0x9E,
                0x30,
                0x9F,
                0x3A,
                0xF8,
                0xE9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFactory7
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB3, 0xE0, 0xD0, 0x35,
                0x76, 0x90,
                0x2E, 0x4D,
                0xA0,
                0x16,
                0xA9,
                0x1B,
                0x56,
                0x8A,
                0x06,
                0xB4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontSet3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF2, 0x3E, 0x07, 0x7C,
                0xF4, 0xA7,
                0x45, 0x40,
                0x8C,
                0x32,
                0x8A,
                0xB8,
                0xAE,
                0x64,
                0x0F,
                0x90
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontFace6
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1B, 0xFE, 0xB1, 0xC4,
                0x84, 0x6E,
                0xD5, 0x47,
                0xB5,
                0x4C,
                0xA5,
                0x97,
                0x98,
                0x1B,
                0x06,
                0xAD
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontSet4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xFC, 0x75, 0xC1, 0xEE,
                0xA9, 0xBE,
                0x86, 0x4C,
                0x8B,
                0x53,
                0xCC,
                0xBD,
                0xD7,
                0xDF,
                0x0C,
                0x82
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
