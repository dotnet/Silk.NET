// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
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
    public static ref readonly Guid IID_IDirect3D9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCA,
                0xCB,
                0xBD,
                0x81,
                0xD4,
                0x64,
                0x6D,
                0x42,
                0xAE,
                0x8D,
                0xAD,
                0x01,
                0x47,
                0xF4,
                0x27,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DDevice9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0x3B,
                0x22,
                0xD0,
                0x7A,
                0xBF,
                0xFD,
                0x43,
                0x92,
                0xBD,
                0xA4,
                0x3B,
                0x0D,
                0x82,
                0xB9,
                0xEB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DResource9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0xC0,
                0xEE,
                0x05,
                0x7D,
                0x8F,
                0x62,
                0x43,
                0xB9,
                0x99,
                0xD1,
                0xBA,
                0xF3,
                0x57,
                0xC7,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DBaseTexture9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0xA8,
                0x0C,
                0x58,
                0x3C,
                0x1D,
                0x54,
                0x4D,
                0x99,
                0x1D,
                0xB7,
                0xD3,
                0xE3,
                0xC2,
                0x98,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DTexture9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0x12,
                0xC3,
                0x85,
                0xE5,
                0x3D,
                0x00,
                0x4F,
                0x9B,
                0x3A,
                0xF1,
                0x1A,
                0xC3,
                0x8C,
                0x18,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DCubeTexture9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x2F,
                0xF3,
                0xFF,
                0x53,
                0xD9,
                0x3A,
                0x47,
                0x92,
                0x23,
                0x93,
                0xD6,
                0x52,
                0xAB,
                0xA9,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DVolumeTexture9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0x52,
                0x18,
                0x25,
                0x89,
                0xE7,
                0x11,
                0x41,
                0xA7,
                0xB9,
                0x47,
                0xEF,
                0x32,
                0x8D,
                0x13,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DVertexBuffer9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0xB1,
                0x4B,
                0xB6,
                0x70,
                0xFD,
                0xF6,
                0x4D,
                0xBF,
                0x91,
                0x19,
                0xD0,
                0xA1,
                0x24,
                0x55,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DIndexBuffer9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0xD6,
                0x9D,
                0x7C,
                0xF7,
                0xD3,
                0x29,
                0x45,
                0xAC,
                0xEE,
                0x78,
                0x58,
                0x30,
                0xAC,
                0xDE,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DSurface9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0xAF,
                0xFB,
                0x0C,
                0xF6,
                0x9F,
                0x9A,
                0x42,
                0x99,
                0xB3,
                0xA2,
                0x79,
                0x6A,
                0xF8,
                0xB8,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DVolume9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0x16,
                0xF4,
                0x24,
                0x67,
                0x1F,
                0xA7,
                0x4A,
                0xB8,
                0x8E,
                0xD3,
                0x3F,
                0x6F,
                0x31,
                0x28,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DSwapChain9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0x50,
                0x49,
                0x79,
                0xFC,
                0xAD,
                0x8A,
                0x45,
                0x90,
                0x5E,
                0x10,
                0xA1,
                0x0B,
                0x0B,
                0x50,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DVertexDeclaration9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0xC5,
                0x13,
                0xDD,
                0xFA,
                0x36,
                0x98,
                0x40,
                0xA8,
                0xFB,
                0xC7,
                0xED,
                0x39,
                0xDC,
                0x85,
                0x46,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DVertexShader9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x55,
                0xC5,
                0xEF,
                0x65,
                0x62,
                0x13,
                0x46,
                0x8A,
                0x94,
                0x43,
                0x85,
                0x78,
                0x89,
                0xEB,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DPixelShader9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0xDB,
                0x3B,
                0x6D,
                0x02,
                0x5B,
                0x15,
                0x44,
                0xB8,
                0x52,
                0xCE,
                0x5E,
                0x8B,
                0xCC,
                0xB2,
                0x89,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DStateBlock9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x4F,
                0x7C,
                0xB0,
                0x0D,
                0x31,
                0xA8,
                0x4B,
                0xA2,
                0x3C,
                0x4F,
                0x0F,
                0x20,
                0x6F,
                0x21,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DQuery9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0x14,
                0x77,
                0xD9,
                0x95,
                0xA6,
                0x26,
                0x4F,
                0xBB,
                0xD3,
                0x27,
                0xB8,
                0x40,
                0xB5,
                0x41,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_HelperName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0x67,
                0xA3,
                0xE4,
                0xFE,
                0xFD,
                0x22,
                0x4B,
                0xB1,
                0x46,
                0x3C,
                0x04,
                0xC0,
                0x7F,
                0x4C,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3D9Ex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0x72,
                0x17,
                0x02,
                0xFC,
                0x69,
                0x0C,
                0x40,
                0x8F,
                0xF1,
                0x93,
                0xA4,
                0x4D,
                0xF6,
                0x86,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DDevice9Ex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0x10,
                0x8B,
                0xB1,
                0x49,
                0x26,
                0x5A,
                0x40,
                0x87,
                0x0F,
                0x95,
                0xF7,
                0x77,
                0xD4,
                0x31,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DSwapChain9Ex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0x6C,
                0x88,
                0x91,
                0x3D,
                0x1C,
                0x2E,
                0x4D,
                0xA0,
                0xAB,
                0x3E,
                0x4C,
                0x7D,
                0x8D,
                0x33,
                0x03,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3D9ExOverlayExtension
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x13,
                0xEB,
                0x7A,
                0x18,
                0xF5,
                0xAA,
                0x59,
                0x4C,
                0x87,
                0x6D,
                0xE0,
                0x59,
                0x08,
                0x8C,
                0x0D,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DDevice9Video
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x45,
                0xDC,
                0x26,
                0xEE,
                0xA1,
                0xE7,
                0x4A,
                0x96,
                0xDA,
                0x11,
                0x8A,
                0x36,
                0xC0,
                0xEC,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DAuthenticatedChannel9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0xBE,
                0x24,
                0xFF,
                0x21,
                0xDA,
                0xEB,
                0x4B,
                0x98,
                0xB5,
                0xD2,
                0xF8,
                0x99,
                0xF9,
                0x8A,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirect3DCryptoSession9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0xB7,
                0x0A,
                0xFA,
                0x9C,
                0x7A,
                0xCA,
                0x48,
                0x8C,
                0x5B,
                0x23,
                0x7E,
                0x71,
                0xA5,
                0x44,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
