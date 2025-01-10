// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.26100.0
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
    public static ref readonly Guid IID_ID3D10StateBlock
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0x42,
                0x03,
                0x08,
                0xF5,
                0x57,
                0xD6,
                0x4D,
                0x94,
                0x65,
                0xA8,
                0x75,
                0x70,
                0x83,
                0x4A,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x1D,
                0x9E,
                0x4E,
                0x9D,
                0xCD,
                0x72,
                0x47,
                0xA8,
                0x37,
                0x00,
                0x18,
                0x0B,
                0x9B,
                0x88,
                0xFD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectVariable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0x71,
                0x89,
                0xAE,
                0xE6,
                0x00,
                0xBF,
                0x45,
                0xBB,
                0x8E,
                0x28,
                0x1D,
                0xD6,
                0xDB,
                0x8E,
                0x1B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectScalarVariable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0x8F,
                0xE4,
                0x00,
                0xC8,
                0xD2,
                0xE8,
                0x49,
                0xA8,
                0x6C,
                0x02,
                0x2D,
                0xEE,
                0x53,
                0x43,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectVectorVariable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0x8C,
                0xB9,
                0x62,
                0x82,
                0x1F,
                0x67,
                0x4C,
                0xBC,
                0xD0,
                0x72,
                0xCF,
                0x8F,
                0x21,
                0x7E,
                0x81,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectMatrixVariable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x6C,
                0x66,
                0x50,
                0x2F,
                0xB8,
                0xED,
                0x4E,
                0xA1,
                0x72,
                0x5B,
                0x6E,
                0x7E,
                0x85,
                0x22,
                0xE0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectStringVariable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0x75,
                0x41,
                0x71,
                0xF9,
                0x8D,
                0x0A,
                0x4E,
                0xA7,
                0x8A,
                0x25,
                0x5F,
                0x97,
                0x56,
                0xBA,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectShaderResourceVariable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0x15,
                0xA7,
                0xC0,
                0x72,
                0xD8,
                0x1D,
                0x4B,
                0x80,
                0x73,
                0xEF,
                0xC2,
                0xAC,
                0xD4,
                0xB1,
                0xFC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectRenderTargetViewVariable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x0C,
                0xCA,
                0x28,
                0xC9,
                0xC2,
                0xBB,
                0x40,
                0xB5,
                0x7F,
                0x67,
                0xB7,
                0x37,
                0x12,
                0x2B,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectDepthStencilViewVariable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0xC9,
                0x02,
                0x3E,
                0x79,
                0xCC,
                0x85,
                0x49,
                0xB6,
                0x22,
                0x2D,
                0x92,
                0xAD,
                0x70,
                0x16,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectConstantBuffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0x8F,
                0x64,
                0x56,
                0x8B,
                0xCC,
                0x44,
                0x44,
                0xA5,
                0xAD,
                0xB5,
                0xA3,
                0xD7,
                0x6E,
                0x91,
                0xB3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectShaderVariable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0x92,
                0x84,
                0x80,
                0x99,
                0xC7,
                0x97,
                0x47,
                0x8C,
                0x33,
                0x04,
                0x07,
                0xA0,
                0x7D,
                0x9E,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectBlendVariable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x94,
                0x22,
                0xCD,
                0x1F,
                0x6D,
                0xDF,
                0xAE,
                0x4E,
                0x86,
                0xB3,
                0x0E,
                0x91,
                0x60,
                0xCF,
                0xB0,
                0x7B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectDepthStencilVariable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0x23,
                0x48,
                0xAF,
                0x0A,
                0x33,
                0xA5,
                0x46,
                0x9A,
                0x5C,
                0x01,
                0xC7,
                0x1A,
                0xF2,
                0x4C,
                0x8D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectRasterizerVariable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0E,
                0x9F,
                0xAF,
                0x21,
                0x94,
                0x4D,
                0xA9,
                0x4E,
                0x97,
                0x85,
                0x2C,
                0xB7,
                0x6B,
                0x8C,
                0x0B,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectSamplerVariable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0xD5,
                0x30,
                0x65,
                0xE9,
                0x07,
                0x71,
                0x42,
                0xA4,
                0x18,
                0xE7,
                0xCE,
                0x4B,
                0xD1,
                0xE4,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectPass
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0xEB,
                0xFB,
                0x5C,
                0x06,
                0x1A,
                0xE0,
                0x46,
                0xB2,
                0x82,
                0xE3,
                0xF9,
                0xBF,
                0xA3,
                0x6A,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectTechnique
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0x2C,
                0x12,
                0xDB,
                0xC9,
                0xD1,
                0x92,
                0x42,
                0xB2,
                0x37,
                0x24,
                0xED,
                0x3D,
                0xE8,
                0xB1,
                0x75,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10Effect
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0xCA,
                0xB0,
                0x51,
                0x0B,
                0xEC,
                0x19,
                0x45,
                0x87,
                0x0D,
                0x8E,
                0xE1,
                0xCB,
                0x50,
                0x17,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10EffectPool
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0xAB,
                0x37,
                0x95,
                0x50,
                0x32,
                0x2E,
                0x41,
                0x82,
                0x13,
                0xFC,
                0xD2,
                0xF8,
                0x67,
                0x79,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
