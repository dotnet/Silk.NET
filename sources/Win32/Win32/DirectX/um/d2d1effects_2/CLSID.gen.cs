// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CLSID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Contrast
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0xA7,
                0x48,
                0xB6,
                0xD5,
                0x0E,
                0x80,
                0x4F,
                0xA9,
                0x4A,
                0x8E,
                0x82,
                0x5A,
                0xCA,
                0x6B,
                0x77,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1RgbToHue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0xE5,
                0xF3,
                0x23,
                0xE8,
                0x91,
                0x3D,
                0x4D,
                0xAD,
                0x0A,
                0xAF,
                0xAD,
                0xC1,
                0x00,
                0x4A,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1HueToRgb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0xA6,
                0x78,
                0x7B,
                0x41,
                0x01,
                0xEF,
                0x4D,
                0x8A,
                0x52,
                0x63,
                0x56,
                0xEE,
                0x0C,
                0xBD,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1ChromaKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0x1F,
                0xC0,
                0x74,
                0x0D,
                0x2A,
                0x8C,
                0x40,
                0x88,
                0xE2,
                0xC7,
                0xA3,
                0xC7,
                0x19,
                0x77,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Emboss
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0xEB,
                0xC5,
                0xB1,
                0x48,
                0x03,
                0xF0,
                0x43,
                0x81,
                0x07,
                0x49,
                0x57,
                0xCA,
                0xCB,
                0xA2,
                0xAE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Exposure
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0x8C,
                0x6C,
                0xB5,
                0x34,
                0xF6,
                0xEE,
                0x41,
                0xBE,
                0xE0,
                0xFF,
                0xA6,
                0x17,
                0x10,
                0x60,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Grayscale
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0xE0,
                0xDD,
                0x36,
                0x25,
                0x37,
                0xE0,
                0x42,
                0x83,
                0x6D,
                0x52,
                0xFB,
                0x20,
                0xAE,
                0xE6,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Invert
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0x78,
                0xC3,
                0xE0,
                0x39,
                0xCB,
                0x84,
                0x4E,
                0xB6,
                0xFD,
                0x6B,
                0x72,
                0xF0,
                0x81,
                0x02,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Posterize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x94,
                0x88,
                0x21,
                0xA3,
                0x33,
                0x66,
                0x43,
                0xB7,
                0xBC,
                0x08,
                0x6B,
                0xD0,
                0x2D,
                0x08,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Sepia
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0xF4,
                0x1A,
                0x3A,
                0x1D,
                0x5F,
                0xBE,
                0x4D,
                0x84,
                0xDF,
                0x91,
                0x5D,
                0xA7,
                0x9B,
                0x71,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Sharpen
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0x87,
                0xB8,
                0xC9,
                0xFF,
                0xC5,
                0xC5,
                0x4D,
                0x97,
                0x79,
                0x27,
                0x3D,
                0xCF,
                0x41,
                0x7C,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Straighten
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x7B,
                0xA4,
                0x4D,
                0xA3,
                0x79,
                0xB0,
                0x4F,
                0x82,
                0x37,
                0xBB,
                0xC3,
                0xB2,
                0xA4,
                0xDE,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1TemperatureTint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x60,
                0x17,
                0x89,
                0xF9,
                0x8A,
                0x08,
                0x4A,
                0xAE,
                0xB1,
                0x89,
                0x5F,
                0x38,
                0xDB,
                0x17,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Vignette
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0x40,
                0x0C,
                0xC0,
                0x67,
                0x5E,
                0xA3,
                0x4C,
                0x95,
                0xB4,
                0xF4,
                0xB0,
                0x2C,
                0x11,
                0x51,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1EdgeDetection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCA,
                0x83,
                0xF5,
                0xEF,
                0x07,
                0xCB,
                0xA9,
                0x4A,
                0xAC,
                0x5D,
                0x2C,
                0xC4,
                0x4C,
                0x76,
                0x46,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1HighlightsShadows
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
                0x83,
                0xDC,
                0xCA,
                0x3F,
                0x32,
                0x7E,
                0x4C,
                0xA3,
                0x61,
                0x2E,
                0x2B,
                0x24,
                0xDF,
                0x6E,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1LookupTable3D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x0E,
                0x9E,
                0x34,
                0x88,
                0x00,
                0x79,
                0x4A,
                0x9C,
                0xA3,
                0xC7,
                0xE3,
                0x00,
                0x20,
                0x20,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Opacity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0x79,
                0x1D,
                0x81,
                0x28,
                0xDE,
                0x54,
                0x44,
                0x80,
                0x94,
                0xC6,
                0x46,
                0x85,
                0xF8,
                0xBD,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1AlphaMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0xCF,
                0x0E,
                0xC8,
                0xD5,
                0x3F,
                0x05,
                0x4F,
                0x83,
                0x28,
                0xC5,
                0xD1,
                0x72,
                0x4B,
                0x4F,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1CrossFade
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0x75,
                0xF5,
                0x12,
                0xB1,
                0x4D,
                0x5F,
                0x48,
                0x9A,
                0x84,
                0x03,
                0xA0,
                0x7D,
                0xD3,
                0x82,
                0x9F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Tint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x17,
                0x2B,
                0x31,
                0x36,
                0xDD,
                0xF7,
                0x14,
                0x40,
                0x91,
                0x5D,
                0xFF,
                0xCA,
                0x76,
                0x8C,
                0xF2,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1WhiteLevelAdjustment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0xCA,
                0xA1,
                0x44,
                0xDD,
                0x6C,
                0x18,
                0x48,
                0x8F,
                0xF4,
                0x26,
                0xC1,
                0xCF,
                0xE9,
                0x5B,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1HdrToneMap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0x74,
                0x0B,
                0x7B,
                0x10,
                0x46,
                0x86,
                0x44,
                0xA9,
                0x0C,
                0x99,
                0x9D,
                0x9A,
                0x2E,
                0x2B,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
