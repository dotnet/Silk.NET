// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_ID2D1SvgAttribute
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDD,
                0xB0,
                0xCD,
                0xC9,
                0xC9,
                0xF8,
                0x70,
                0x4E,
                0xB7,
                0xC2,
                0x30,
                0x1C,
                0x80,
                0x29,
                0x2C,
                0x5E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1SvgPaint
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0A,
                0xAB,
                0x9B,
                0xD5,
                0xA2,
                0x68,
                0x5B,
                0x45,
                0xA5,
                0xDC,
                0x9E,
                0xB2,
                0x85,
                0x4E,
                0x24,
                0x90
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1SvgStrokeDashArray
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0xCA,
                0xC0,
                0xF1,
                0xA3,
                0x92,
                0x00,
                0x4F,
                0xB4,
                0xCE,
                0xF3,
                0x56,
                0x91,
                0xEF,
                0xD9,
                0xD9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1SvgPointCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0D,
                0x4C,
                0xBE,
                0x9D,
                0x72,
                0x35,
                0xD9,
                0x4D,
                0x98,
                0x25,
                0x55,
                0x30,
                0x81,
                0x3B,
                0xB7,
                0x12
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1SvgPathData
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF4,
                0xE4,
                0x95,
                0xC0,
                0x98,
                0xBB,
                0xD6,
                0x43,
                0x97,
                0x45,
                0x4D,
                0x1B,
                0x84,
                0xEC,
                0x98,
                0x88
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1SvgElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA6,
                0x67,
                0x7B,
                0xAC,
                0x3E,
                0x18,
                0xC1,
                0x49,
                0xA8,
                0x23,
                0x0E,
                0xBE,
                0x40,
                0xB0,
                0xDB,
                0x29
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1SvgDocument
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0x8E,
                0xB8,
                0x86,
                0xA4,
                0xAF,
                0x7B,
                0x4D,
                0x88,
                0xE4,
                0x68,
                0xA5,
                0x1C,
                0x4A,
                0x0A,
                0xEC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}