// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10DeviceChild
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x4C,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10DepthStencilState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC8,
                0x1C,
                0x4B,
                0x2B,
                0xAD,
                0xA4,
                0xF8,
                0x41,
                0x83,
                0x22,
                0xCA,
                0x86,
                0xFC,
                0x3E,
                0xC6,
                0x75
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10BlendState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0x8D,
                0xAD,
                0xED,
                0x35,
                0x8A,
                0x6D,
                0x4D,
                0x85,
                0x66,
                0x2E,
                0xA2,
                0x76,
                0xCD,
                0xE1,
                0x61
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10RasterizerState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x92,
                0x72,
                0xA0,
                0xA2,
                0xAF,
                0x89,
                0x45,
                0x43,
                0xBE,
                0x2E,
                0xC5,
                0x3D,
                0x9F,
                0xBB,
                0x6E,
                0x9F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10Resource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0x4C,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10Buffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0x4C,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10Texture1D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0x4C,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10Texture2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x04,
                0x4C,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10Texture3D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0x4C,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10View
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3F,
                0xB0,
                0x02,
                0xC9,
                0xA7,
                0x60,
                0xBA,
                0x49,
                0x99,
                0x36,
                0x2A,
                0x3A,
                0xB3,
                0x7A,
                0x7E,
                0x33
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10ShaderResourceView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x07,
                0x4C,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10RenderTargetView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x08,
                0x4C,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10DepthStencilView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x09,
                0x4C,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10VertexShader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0A,
                0x4C,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10GeometryShader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x88,
                0xBE,
                0x16,
                0x63,
                0xCD,
                0x54,
                0x40,
                0x40,
                0xAB,
                0x44,
                0x20,
                0x46,
                0x1B,
                0xC8,
                0x1F,
                0x68
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10PixelShader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0xB6,
                0x68,
                0x49,
                0x00,
                0x9D,
                0xDE,
                0x4C,
                0x83,
                0x46,
                0x8E,
                0x7F,
                0x67,
                0x58,
                0x19,
                0xB6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10InputLayout
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0B,
                0x4C,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10SamplerState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0x4C,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10Asynchronous
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0D,
                0x4C,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10Query
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0x4C,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10Predicate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0x4C,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10Counter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0x4C,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10Device
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0F,
                0x4C,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10Multithread
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x4E,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}