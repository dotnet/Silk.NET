// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11DeviceChild
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0xE5,
                0x41,
                0x18,
                0xB0,
                0x16,
                0x9B,
                0x48,
                0xBC,
                0xC8,
                0x44,
                0xCF,
                0xB0,
                0xD5,
                0xDE,
                0xAE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11DepthStencilState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0x3E,
                0x82,
                0x03,
                0x8F,
                0x8D,
                0x1C,
                0x4E,
                0x9A,
                0xA2,
                0xF6,
                0x4B,
                0xB2,
                0xCB,
                0xFD,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11BlendState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0x8F,
                0xB6,
                0x75,
                0x7D,
                0x34,
                0x59,
                0x41,
                0x8F,
                0x45,
                0xA0,
                0x64,
                0x0F,
                0x01,
                0xCD,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11RasterizerState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0xAB,
                0xB4,
                0x9B,
                0x1A,
                0xAB,
                0x8F,
                0x4D,
                0xB5,
                0x06,
                0xFC,
                0x04,
                0x20,
                0x0B,
                0x6E,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Resource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0x63,
                0x8E,
                0xDC,
                0x2B,
                0xD1,
                0x52,
                0x49,
                0xB4,
                0x7B,
                0x5E,
                0x45,
                0x02,
                0x6A,
                0x86,
                0x2D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Buffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x0B,
                0x57,
                0x48,
                0xEE,
                0xD1,
                0xCD,
                0x4F,
                0xA2,
                0x50,
                0xEB,
                0x35,
                0x07,
                0x22,
                0xB0,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Texture1D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0x5C,
                0xFB,
                0xF8,
                0xB3,
                0xC6,
                0x75,
                0x4F,
                0xA4,
                0xC8,
                0x43,
                0x9A,
                0xF2,
                0xEF,
                0x56,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Texture2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0xAA,
                0x15,
                0x6F,
                0x08,
                0xD2,
                0x89,
                0x4E,
                0x9A,
                0xB4,
                0x48,
                0x95,
                0x35,
                0xD3,
                0x4F,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Texture3D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x86,
                0x7E,
                0x03,
                0x6D,
                0xF5,
                0x57,
                0x43,
                0xA8,
                0xAF,
                0x9D,
                0xAB,
                0xBE,
                0x6E,
                0x25,
                0x0E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11View
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x12,
                0x9D,
                0x83,
                0x2E,
                0xBB,
                0x2B,
                0x41,
                0xB7,
                0xF4,
                0xA9,
                0xDB,
                0xEB,
                0xE0,
                0x8E,
                0xD1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11ShaderResourceView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x6F,
                0xE0,
                0xB0,
                0x92,
                0x81,
                0x1A,
                0x4E,
                0xB1,
                0xCA,
                0x36,
                0xD7,
                0x41,
                0x47,
                0x10,
                0xB2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11RenderTargetView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0xA0,
                0xDB,
                0xDF,
                0x8D,
                0x0B,
                0x65,
                0x48,
                0x87,
                0x5B,
                0xD7,
                0xB4,
                0x51,
                0x6C,
                0xC1,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11DepthStencilView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2A,
                0xC9,
                0xDA,
                0x9F,
                0x76,
                0x18,
                0xC3,
                0x48,
                0xAF,
                0xAD,
                0x25,
                0xB9,
                0x4F,
                0x84,
                0xA9,
                0xB6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11UnorderedAccessView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0xF5,
                0xAC,
                0x28,
                0x5C,
                0x7F,
                0xF6,
                0x48,
                0x86,
                0x11,
                0xF3,
                0x16,
                0x01,
                0x0A,
                0x63,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11VertexShader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x1D,
                0x30,
                0x3B,
                0x78,
                0xD6,
                0x89,
                0x42,
                0x88,
                0x97,
                0x22,
                0xF8,
                0x92,
                0x8B,
                0x72,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11HullShader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x60,
                0x5C,
                0x8E,
                0x8A,
                0x62,
                0x8E,
                0x4C,
                0x82,
                0x64,
                0xBB,
                0xE4,
                0x5C,
                0xB3,
                0xD5,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11DomainShader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0xC5,
                0x82,
                0xF5,
                0x36,
                0x0F,
                0x0C,
                0x49,
                0x99,
                0x77,
                0x31,
                0xEE,
                0xCE,
                0x26,
                0x8C,
                0xFA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11GeometryShader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0x5B,
                0x32,
                0x38,
                0xFB,
                0xEF,
                0x22,
                0x40,
                0xBA,
                0x02,
                0x2E,
                0x79,
                0x5B,
                0x70,
                0x27,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11PixelShader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0xE4,
                0x82,
                0xEA,
                0xDC,
                0x51,
                0x33,
                0x4F,
                0x93,
                0xD4,
                0xDB,
                0x7C,
                0x91,
                0x25,
                0xAE,
                0x8C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11ComputeShader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x19,
                0x5B,
                0x4F,
                0xBD,
                0xC2,
                0x5E,
                0x49,
                0xBD,
                0x01,
                0x1F,
                0xDE,
                0xD3,
                0x8E,
                0x49,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11InputLayout
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x9D,
                0x81,
                0xE4,
                0xF0,
                0x4C,
                0x25,
                0x40,
                0xBD,
                0x26,
                0x5D,
                0xE8,
                0x2A,
                0x3E,
                0x07,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11SamplerState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0xEA,
                0x6F,
                0xDA,
                0x4C,
                0x56,
                0x87,
                0x44,
                0x98,
                0x10,
                0xF0,
                0xD0,
                0xF9,
                0xB4,
                0xE3,
                0xA5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Asynchronous
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0xD0,
                0x35,
                0x4B,
                0x15,
                0x1E,
                0x58,
                0x42,
                0x9C,
                0x98,
                0x1B,
                0x13,
                0x33,
                0xF6,
                0xDD,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Query
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0x07,
                0xC0,
                0xD6,
                0xB7,
                0x87,
                0x5E,
                0x42,
                0xB8,
                0x4D,
                0x44,
                0xD1,
                0x08,
                0x56,
                0x0A,
                0xFD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Predicate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0x76,
                0xB5,
                0x9E,
                0x77,
                0x9F,
                0x86,
                0x4D,
                0x81,
                0xAA,
                0x8B,
                0xAB,
                0x5F,
                0xE4,
                0x90,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Counter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0x49,
                0x8C,
                0x6E,
                0x71,
                0xA3,
                0x70,
                0x47,
                0xB4,
                0x40,
                0x29,
                0x08,
                0x60,
                0x22,
                0xB7,
                0x41,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11ClassInstance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0x7F,
                0xCD,
                0xA6,
                0xB7,
                0xB0,
                0x2F,
                0x4A,
                0x94,
                0x36,
                0x86,
                0x62,
                0xA6,
                0x57,
                0x97,
                0xCB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11ClassLinkage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0x7C,
                0xF5,
                0xDD,
                0x43,
                0x95,
                0xE4,
                0x46,
                0xA1,
                0x2B,
                0xF2,
                0x07,
                0xA0,
                0xFE,
                0x7F,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11CommandList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0xC4,
                0x4B,
                0xA2,
                0x9E,
                0x76,
                0xF7,
                0x43,
                0x80,
                0x13,
                0x98,
                0xFF,
                0x56,
                0x6C,
                0x18,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11DeviceContext
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0xA9,
                0xBF,
                0xC0,
                0x89,
                0xE0,
                0xFB,
                0x44,
                0x8E,
                0xAF,
                0x26,
                0xF8,
                0x79,
                0x61,
                0x90,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11VideoDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0x5B,
                0x9C,
                0x3C,
                0x5D,
                0x99,
                0xD1,
                0x48,
                0x9B,
                0x8D,
                0xFA,
                0x5C,
                0xAE,
                0xDE,
                0xD6,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11VideoProcessorEnumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x70,
                0x62,
                0x31,
                0xAB,
                0x53,
                0x00,
                0x42,
                0x90,
                0x61,
                0x05,
                0xFA,
                0xA9,
                0xAB,
                0x45,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11VideoProcessor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0x06,
                0x7B,
                0x1D,
                0x5F,
                0x18,
                0xC6,
                0x41,
                0x85,
                0xCE,
                0x0C,
                0x5B,
                0xE3,
                0xD4,
                0xAE,
                0x6C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11AuthenticatedChannel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0xA3,
                0x15,
                0x30,
                0xBD,
                0xDC,
                0xAA,
                0x47,
                0xA7,
                0x47,
                0x19,
                0x24,
                0x86,
                0xD1,
                0x4D,
                0x4A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11CryptoSession
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0xF9,
                0x32,
                0x9B,
                0xCC,
                0xBD,
                0xA6,
                0x40,
                0xA3,
                0x9D,
                0xD5,
                0xC8,
                0x65,
                0x84,
                0x57,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11VideoDecoderOutputView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0x1A,
                0x93,
                0xC2,
                0x85,
                0x2A,
                0x20,
                0x4F,
                0x86,
                0x0F,
                0xFB,
                0xA1,
                0xFD,
                0x25,
                0x6E,
                0x18,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11VideoProcessorInputView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0x5A,
                0xEC,
                0x11,
                0xDC,
                0x51,
                0x45,
                0x49,
                0xAB,
                0x34,
                0x6E,
                0x8C,
                0x21,
                0x30,
                0x0E,
                0xA5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11VideoProcessorOutputView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x28,
                0x48,
                0xA0,
                0xA9,
                0x25,
                0x27,
                0x45,
                0xBD,
                0x93,
                0xD6,
                0x8B,
                0x68,
                0xC4,
                0x42,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11VideoContext
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x1C,
                0xF2,
                0x61,
                0x0E,
                0x3C,
                0x74,
                0x4A,
                0x9C,
                0xEA,
                0x67,
                0x10,
                0x0D,
                0x9A,
                0xD5,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11VideoDevice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0x4D,
                0xEC,
                0x10,
                0x5A,
                0x97,
                0x89,
                0x46,
                0xB9,
                0xE4,
                0xD0,
                0xAA,
                0xC3,
                0x0F,
                0xE3,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Device
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0x6D,
                0x6F,
                0xDB,
                0x77,
                0xAC,
                0x88,
                0x4E,
                0x82,
                0x53,
                0x81,
                0x9D,
                0xF9,
                0xBB,
                0xF1,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
