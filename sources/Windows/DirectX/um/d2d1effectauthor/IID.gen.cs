// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_ID2D1VertexBuffer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x36,
                0x13,
                0x8B,
                0x9B,
                0xA5,
                0x00,
                0x68,
                0x46,
                0x92,
                0xB7,
                0xCE,
                0xD5,
                0xD8,
                0xBF,
                0x9B,
                0x7B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1ResourceTexture
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC3,
                0x15,
                0x8D,
                0x68,
                0xB0,
                0x02,
                0x8D,
                0x43,
                0xB1,
                0x3A,
                0xD1,
                0xB4,
                0x4C,
                0x32,
                0xC3,
                0x9A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1RenderInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBD,
                0xE1,
                0x9A,
                0x51,
                0x9A,
                0xD1,
                0x0D,
                0x42,
                0xB8,
                0x49,
                0x36,
                0x4F,
                0x59,
                0x47,
                0x76,
                0xB7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1DrawInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x32,
                0xE6,
                0x3C,
                0x69,
                0x2F,
                0x7F,
                0xDE,
                0x45,
                0x93,
                0xFE,
                0x18,
                0xD8,
                0x8B,
                0x37,
                0xAA,
                0x21
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1ComputeInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4B,
                0xB1,
                0x98,
                0x55,
                0xD7,
                0x9F,
                0xB7,
                0x48,
                0x9B,
                0xDB,
                0x8F,
                0x09,
                0x64,
                0xEB,
                0x38,
                0xBC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1TransformNode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE7,
                0xE1,
                0xEF,
                0xB2,
                0x9F,
                0x72,
                0x02,
                0x41,
                0x94,
                0x9F,
                0x50,
                0x5F,
                0xA2,
                0x1B,
                0xF6,
                0x66
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1TransformGraph
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x38,
                0x90,
                0xD2,
                0x13,
                0xE6,
                0xC3,
                0x34,
                0x40,
                0x90,
                0x81,
                0x13,
                0xB5,
                0x3A,
                0x41,
                0x79,
                0x92
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1Transform
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7D,
                0x28,
                0x1A,
                0xEF,
                0x2A,
                0x34,
                0x76,
                0x4F,
                0x8F,
                0xDB,
                0xDA,
                0x0D,
                0x6E,
                0xA9,
                0xF9,
                0x2B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1DrawTransform
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB6,
                0xDC,
                0xBF,
                0x36,
                0x39,
                0x97,
                0x5D,
                0x43,
                0xA3,
                0x0D,
                0xA6,
                0x53,
                0xBE,
                0xFF,
                0x6A,
                0x6F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1ComputeTransform
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3C,
                0x57,
                0x85,
                0x0D,
                0xE3,
                0x01,
                0x7D,
                0x4F,
                0xBF,
                0xD9,
                0x0D,
                0x60,
                0x60,
                0x8B,
                0xF3,
                0xC3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1AnalysisTransform
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0xDC,
                0x59,
                0x03,
                0xE6,
                0x95,
                0x68,
                0x45,
                0x90,
                0x55,
                0x27,
                0x72,
                0x0D,
                0x13,
                0x0E,
                0x93
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1SourceTransform
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDD,
                0x00,
                0x18,
                0xDB,
                0x34,
                0x0C,
                0xF9,
                0x4C,
                0xBE,
                0x90,
                0x31,
                0xCC,
                0x0A,
                0x56,
                0x53,
                0xE1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1ConcreteTransform
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0x9D,
                0x79,
                0x1A,
                0xF7,
                0x69,
                0x4C,
                0x4E,
                0x9F,
                0xED,
                0x43,
                0x7C,
                0xCC,
                0x66,
                0x84,
                0xCC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1BlendTransform
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x32,
                0x0B,
                0xAC,
                0x63,
                0x44,
                0xBA,
                0x0F,
                0x45,
                0x88,
                0x06,
                0x7F,
                0x4C,
                0xA1,
                0xFF,
                0x2F,
                0x1B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1BorderTransform
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5C,
                0x73,
                0x98,
                0x49,
                0x19,
                0x3A,
                0x3C,
                0x47,
                0x97,
                0x81,
                0x65,
                0x68,
                0x47,
                0xE3,
                0xA3,
                0x47
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1OffsetTransform
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEA,
                0xAD,
                0xE6,
                0x3F,
                0x43,
                0x76,
                0x53,
                0x4F,
                0xBD,
                0x14,
                0xA0,
                0xCE,
                0x63,
                0xF2,
                0x40,
                0x42
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1BoundsAdjustmentTransform
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE2,
                0x32,
                0xF7,
                0x90,
                0x92,
                0x50,
                0x06,
                0x46,
                0xA8,
                0x19,
                0x86,
                0x51,
                0x97,
                0x0B,
                0xAC,
                0xCD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1EffectImpl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3F,
                0xFD,
                0x48,
                0xA2,
                0x6C,
                0x3E,
                0x63,
                0x4E,
                0x9F,
                0x03,
                0x7F,
                0x68,
                0xEC,
                0xC9,
                0x1D,
                0xB9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1EffectContext
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6B,
                0x91,
                0x9F,
                0x3D,
                0xDC,
                0x27,
                0xD7,
                0x4A,
                0xB4,
                0xF1,
                0x64,
                0x94,
                0x53,
                0x40,
                0xF5,
                0x63
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}