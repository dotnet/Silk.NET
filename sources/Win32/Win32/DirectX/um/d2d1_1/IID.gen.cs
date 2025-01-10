// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_ID2D1GdiMetafileSink
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x73,
                0x23,
                0x82,
                0x11,
                0x81,
                0x7C,
                0x4F,
                0xBC,
                0xF4,
                0xB5,
                0xC1,
                0x17,
                0x55,
                0x64,
                0xFE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1GdiMetafile
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x3D,
                0x54,
                0x2F,
                0xC1,
                0xCF,
                0x11,
                0x42,
                0x86,
                0x4F,
                0xCF,
                0xD9,
                0x1C,
                0x6F,
                0x33,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1CommandSink
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0x89,
                0xD7,
                0x54,
                0x61,
                0xA0,
                0xA7,
                0x40,
                0xBE,
                0xC7,
                0xE4,
                0x65,
                0xBC,
                0xBA,
                0x2C,
                0x4F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1CommandList
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0x4A,
                0xF3,
                0xB4,
                0x83,
                0x23,
                0x76,
                0x4D,
                0x94,
                0xF6,
                0xEC,
                0x34,
                0x36,
                0x57,
                0xC3,
                0xDC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1PrintControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0x86,
                0x1D,
                0x2C,
                0x90,
                0xC2,
                0xC8,
                0x41,
                0xAE,
                0x7E,
                0x34,
                0xA9,
                0x87,
                0x02,
                0xE9,
                0xA5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1ImageBrush
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0x98,
                0x9E,
                0xFE,
                0x95,
                0x3F,
                0x7C,
                0x40,
                0xB5,
                0xDB,
                0xCB,
                0x94,
                0xD4,
                0xE8,
                0xF8,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1BitmapBrush1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x3A,
                0x34,
                0x41,
                0x1A,
                0xE4,
                0xA2,
                0x49,
                0x91,
                0xCD,
                0x21,
                0x79,
                0x3B,
                0xBB,
                0x62,
                0xE5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1StrokeStyle1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x2A,
                0xA7,
                0x10,
                0x1C,
                0xE9,
                0xF4,
                0x43,
                0x99,
                0x3F,
                0xDD,
                0xF4,
                0xB8,
                0x2B,
                0x0B,
                0x4A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1PathGeometry1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0xA2,
                0xBA,
                0x62,
                0x54,
                0xAB,
                0xB7,
                0x41,
                0xB8,
                0x72,
                0x78,
                0x7E,
                0x01,
                0x06,
                0xA4,
                0x21,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Properties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0x73,
                0x34,
                0x48,
                0x46,
                0xCD,
                0x9D,
                0x4F,
                0x9D,
                0x3A,
                0x31,
                0x12,
                0xAA,
                0x80,
                0x15,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Effect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x1A,
                0x21,
                0x28,
                0x89,
                0x7D,
                0x6F,
                0x47,
                0x81,
                0x81,
                0x2D,
                0x61,
                0x59,
                0xB2,
                0x20,
                0xAD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Bitmap1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0xA8,
                0x98,
                0xA8,
                0x73,
                0x38,
                0x88,
                0x45,
                0xB0,
                0x8B,
                0xEB,
                0xBF,
                0x97,
                0x8D,
                0xF0,
                0x41,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1ColorContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0x20,
                0x48,
                0x1C,
                0x71,
                0x57,
                0x18,
                0x45,
                0xA5,
                0x81,
                0x2F,
                0xE4,
                0xDD,
                0x0E,
                0xC6,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1GradientStopCollection1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x72,
                0x15,
                0xAE,
                0xD0,
                0x5D,
                0x77,
                0x47,
                0x99,
                0x8B,
                0x92,
                0x79,
                0x47,
                0x2A,
                0xE6,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1DrawingStateBlock1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x1F,
                0x9F,
                0x68,
                0x2E,
                0xC7,
                0x33,
                0x4E,
                0x8F,
                0x19,
                0x85,
                0x75,
                0x4E,
                0xFD,
                0x5A,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1DeviceContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0xFE,
                0xF7,
                0xE8,
                0x1C,
                0x19,
                0x6D,
                0x46,
                0xAD,
                0x95,
                0x97,
                0x56,
                0x78,
                0xBD,
                0xA9,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Device
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x57,
                0xDD,
                0x47,
                0x05,
                0xAC,
                0xDD,
                0x4C,
                0x80,
                0x49,
                0x9B,
                0x02,
                0xCD,
                0x16,
                0xF4,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Factory1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0xD3,
                0x12,
                0xBB,
                0xEE,
                0xDA,
                0x9A,
                0x4B,
                0xAA,
                0x1D,
                0x14,
                0xBA,
                0x40,
                0x1C,
                0xFA,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ID2D1Multithread
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0xE7,
                0xE6,
                0x31,
                0xFF,
                0xE0,
                0x46,
                0x4D,
                0x8C,
                0x64,
                0xA0,
                0xA8,
                0xC4,
                0x1C,
                0x15,
                0xD3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
