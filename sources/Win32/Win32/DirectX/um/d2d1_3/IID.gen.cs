// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_ID2D1InkStyle
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0xB3,
                0xE8,
                0xBA,
                0xFC,
                0x23,
                0x71,
                0x40,
                0x8C,
                0xB5,
                0xD0,
                0x5D,
                0x6F,
                0x07,
                0x38,
                0x48,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Ink
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3B,
                0x92,
                0x99,
                0xB4,
                0x29,
                0x70,
                0x8F,
                0x47,
                0xA8,
                0xB3,
                0x43,
                0x2C,
                0x7C,
                0x5F,
                0x53,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1GradientMesh
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0xE4,
                0x92,
                0xF2,
                0x50,
                0xC0,
                0xDE,
                0x4C,
                0x83,
                0xD7,
                0x04,
                0x96,
                0x2D,
                0x3B,
                0x23,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1ImageSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x64,
                0xB6,
                0xC9,
                0xA1,
                0x74,
                0x78,
                0x43,
                0x9A,
                0xC2,
                0xEE,
                0xFC,
                0x37,
                0xA3,
                0xF4,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1ImageSourceFromWic
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0x54,
                0x39,
                0x77,
                0x8F,
                0x1C,
                0x55,
                0x45,
                0x86,
                0x83,
                0xF5,
                0x0D,
                0xAB,
                0x0F,
                0xE7,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1TransformedImageSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x79,
                0x1F,
                0x7F,
                0x96,
                0x27,
                0x6C,
                0x41,
                0x8F,
                0x55,
                0x70,
                0x0F,
                0x91,
                0x14,
                0x45,
                0xE5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1LookupTable3D
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x98,
                0xDD,
                0x53,
                0xB0,
                0xA3,
                0x5B,
                0x4D,
                0x82,
                0xE1,
                0x26,
                0xE2,
                0x5C,
                0x5E,
                0x57,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1DeviceContext2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0xA6,
                0x4E,
                0x39,
                0x34,
                0x0C,
                0x21,
                0x43,
                0x95,
                0x0B,
                0x6C,
                0xA2,
                0x0F,
                0x0B,
                0xE6,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Device2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0x72,
                0x44,
                0xA4,
                0xFB,
                0x8D,
                0x60,
                0x4E,
                0x84,
                0x92,
                0x6E,
                0x28,
                0x61,
                0xC9,
                0xCA,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Factory3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0x75,
                0x69,
                0x08,
                0x00,
                0x4F,
                0x3F,
                0x41,
                0xB0,
                0x3E,
                0x2B,
                0xDA,
                0x45,
                0x40,
                0x4D,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1CommandSink2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0E,
                0x44,
                0xAB,
                0x3B,
                0x7E,
                0x41,
                0xDF,
                0x47,
                0xA2,
                0xE2,
                0xBC,
                0x0B,
                0xE6,
                0xA0,
                0x09,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1GdiMetafile1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0xF9,
                0x69,
                0x2E,
                0x3F,
                0xDD,
                0xF9,
                0x4B,
                0x95,
                0xBA,
                0xC0,
                0x4F,
                0x49,
                0xD7,
                0x88,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1GdiMetafileSink1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6B,
                0xCB,
                0x0E,
                0xFD,
                0xE6,
                0x91,
                0x1E,
                0x41,
                0x86,
                0x55,
                0x39,
                0x5E,
                0x76,
                0x0F,
                0x91,
                0xB4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1SpriteBatch
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0x83,
                0xC5,
                0x4D,
                0x10,
                0x3A,
                0x8A,
                0x43,
                0x87,
                0x22,
                0xE9,
                0x76,
                0x52,
                0x24,
                0xF1,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1DeviceContext3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0x74,
                0x5A,
                0x23,
                0x51,
                0x83,
                0x4C,
                0x41,
                0xBC,
                0xD4,
                0x66,
                0x72,
                0xAB,
                0x2D,
                0x8E,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Device3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x20,
                0x2F,
                0x85,
                0x2C,
                0x80,
                0x37,
                0x40,
                0xAB,
                0x60,
                0xFF,
                0x2E,
                0x7E,
                0xE6,
                0xFC,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Factory4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0xC2,
                0x4E,
                0xBD,
                0x62,
                0x06,
                0xEE,
                0x4B,
                0xBA,
                0x8E,
                0x6F,
                0x29,
                0xF0,
                0x32,
                0xE0,
                0x96,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1CommandSink3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0x91,
                0x07,
                0x18,
                0xF3,
                0x4C,
                0x68,
                0x48,
                0xBC,
                0x8E,
                0x06,
                0x06,
                0x7E,
                0x6D,
                0x24,
                0x2D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1SvgGlyphStyle
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x17,
                0x67,
                0xAF,
                0x41,
                0xD2,
                0xB8,
                0x4D,
                0x8E,
                0x41,
                0xDC,
                0xC2,
                0xE5,
                0xC1,
                0xA4,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1DeviceContext4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x31,
                0x78,
                0x42,
                0x8C,
                0x90,
                0x3D,
                0x76,
                0x44,
                0xB6,
                0x47,
                0xC4,
                0xFA,
                0xE3,
                0x49,
                0xE4,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Device4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xB1,
                0xBD,
                0xD7,
                0x83,
                0x56,
                0x46,
                0x4A,
                0xBC,
                0x9C,
                0x72,
                0xDC,
                0x72,
                0x0B,
                0x85,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Factory5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x94,
                0x99,
                0x34,
                0xC4,
                0x8E,
                0x83,
                0x0F,
                0x4B,
                0x8C,
                0xAB,
                0x44,
                0x99,
                0x7D,
                0x9E,
                0xEA,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1CommandSink4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0x65,
                0x8A,
                0xC7,
                0xD6,
                0x40,
                0x18,
                0x42,
                0xB2,
                0xDE,
                0xBE,
                0xEE,
                0xB7,
                0x44,
                0xBB,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1ColorContext1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0x28,
                0xB4,
                0x1A,
                0x7F,
                0xC5,
                0xE9,
                0x4B,
                0xBD,
                0x85,
                0x9C,
                0xD7,
                0x8D,
                0x6F,
                0x55,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1DeviceContext5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0xD2,
                0x36,
                0x78,
                0xCC,
                0x68,
                0xF6,
                0x4D,
                0xB9,
                0xE8,
                0xDE,
                0x99,
                0x1B,
                0xF6,
                0x2E,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Device5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0xA0,
                0x5B,
                0xD5,
                0x05,
                0x64,
                0x94,
                0x46,
                0xAE,
                0xF5,
                0x08,
                0xEE,
                0x1A,
                0x43,
                0x58,
                0xB4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Factory6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0x6F,
                0x97,
                0xF9,
                0x42,
                0xF6,
                0xC1,
                0x44,
                0x97,
                0xCA,
                0xDA,
                0x32,
                0xEA,
                0x2A,
                0x26,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1CommandSink5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0xDD,
                0x47,
                0x70,
                0xE7,
                0xB1,
                0xA7,
                0x44,
                0x95,
                0x9A,
                0x83,
                0x49,
                0xE2,
                0x14,
                0x4F,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1DeviceContext6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x7E,
                0x5F,
                0x98,
                0xD0,
                0x4E,
                0x19,
                0x4A,
                0x98,
                0xA3,
                0x15,
                0xB0,
                0xED,
                0xFD,
                0xE3,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Device6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0xF9,
                0xFE,
                0x7B,
                0x75,
                0x2D,
                0xAD,
                0x4B,
                0xBE,
                0x87,
                0xE1,
                0x8D,
                0xDB,
                0x07,
                0x7B,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Factory7
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0xBD,
                0xC2,
                0xBD,
                0x6C,
                0xB9,
                0xE6,
                0x4D,
                0xBD,
                0xF7,
                0x99,
                0xD4,
                0x74,
                0x54,
                0x54,
                0xDE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1DeviceContext7
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0x1C,
                0x89,
                0xEC,
                0x69,
                0x9B,
                0x51,
                0x48,
                0x9D,
                0xEF,
                0x4E,
                0x09,
                0x15,
                0x77,
                0x1E,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Device7
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0x89,
                0x7C,
                0xF0,
                0x4E,
                0xDD,
                0xA6,
                0x4B,
                0x9C,
                0xBD,
                0xEB,
                0x6D,
                0x37,
                0x52,
                0xDC,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Factory8
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0x93,
                0x7C,
                0x67,
                0x6D,
                0xF3,
                0x1F,
                0x4B,
                0xAE,
                0x86,
                0x86,
                0xD1,
                0x22,
                0x3F,
                0xFD,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
