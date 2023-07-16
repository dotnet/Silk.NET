// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IDWriteTextRenderer1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x34,
                0xE9,
                0xE0,
                0xD3,
                0xA0,
                0x22,
                0x7E,
                0x42,
                0xAA,
                0xE4,
                0x7D,
                0x95,
                0x74,
                0xB5,
                0x9D,
                0xB1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteTextFormat1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0x4B,
                0x17,
                0x5F,
                0x8B,
                0x0D,
                0xFB,
                0x4C,
                0x8B,
                0xCA,
                0xF1,
                0xCC,
                0xE9,
                0xD0,
                0x6C,
                0x67
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteTextLayout2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8F,
                0xC1,
                0x93,
                0x10,
                0x5E,
                0x8D,
                0xF0,
                0x43,
                0xB0,
                0x64,
                0x09,
                0x17,
                0x31,
                0x1B,
                0x52,
                0x5E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteTextAnalyzer2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF3,
                0x9F,
                0x3A,
                0x55,
                0x93,
                0x56,
                0xF7,
                0x4D,
                0xB5,
                0x2B,
                0x74,
                0x80,
                0x6F,
                0x7F,
                0x2E,
                0xB9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontFallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF9,
                0x08,
                0xA0,
                0xEF,
                0xA1,
                0xF7,
                0xBF,
                0x48,
                0xB0,
                0x5C,
                0xF2,
                0x24,
                0x71,
                0x3C,
                0xC0,
                0xFF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFontFallbackBuilder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x06,
                0x2D,
                0x88,
                0xFD,
                0xBA,
                0x8A,
                0xB8,
                0x4F,
                0xB8,
                0x49,
                0x8B,
                0xE8,
                0xB7,
                0x3E,
                0x14,
                0xDE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFont2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD6,
                0x8E,
                0x74,
                0x29,
                0x9C,
                0x8C,
                0x6A,
                0x4A,
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

    public static ref readonly Guid IID_IDWriteFontFace2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0x68,
                0xB7,
                0xD8,
                0xBC,
                0x64,
                0x66,
                0x4E,
                0x98,
                0x2B,
                0xEC,
                0x8E,
                0x87,
                0xF6,
                0x93,
                0xF7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteColorGlyphRunEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0xBE,
                0x1F,
                0xD3,
                0x57,
                0xF1,
                0xA2,
                0x41,
                0x8D,
                0x24,
                0xCB,
                0x77,
                0x9E,
                0x05,
                0x60,
                0xE8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteRenderingParams2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC3,
                0x11,
                0xD7,
                0xF9,
                0x77,
                0x97,
                0xAE,
                0x40,
                0x87,
                0xE8,
                0x3E,
                0x5A,
                0xF9,
                0xBF,
                0x09,
                0x48
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDWriteFactory2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0xFC,
                0x39,
                0x04,
                0x44,
                0xCA,
                0x94,
                0x49,
                0x8D,
                0xEE,
                0x3A,
                0x9A,
                0xF7,
                0xB7,
                0x32,
                0xEC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}