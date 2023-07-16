// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.DirectX;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Texture2D1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x51,
                0x82,
                0x21,
                0x51,
                0x33,
                0x1E,
                0x17,
                0x46,
                0x9C,
                0xCB,
                0x4D,
                0x3A,
                0x43,
                0x67,
                0xE7,
                0xBB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Texture3D1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0x16,
                0x71,
                0x0C,
                0x53,
                0x28,
                0x46,
                0x48,
                0x9B,
                0xB0,
                0xF3,
                0xE6,
                0x06,
                0x39,
                0xE4,
                0x6A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11RasterizerState2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFB,
                0x02,
                0xBD,
                0x6F,
                0x9F,
                0x20,
                0xC4,
                0x46,
                0xB0,
                0x59,
                0x2E,
                0xD1,
                0x55,
                0x86,
                0xA6,
                0xAC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11ShaderResourceView1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x87,
                0x8B,
                0x30,
                0x91,
                0x40,
                0x90,
                0x1D,
                0x41,
                0x8C,
                0x67,
                0xC3,
                0x92,
                0x53,
                0xCE,
                0x38,
                0x02
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11RenderTargetView1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x23,
                0x2E,
                0xBE,
                0xFF,
                0x11,
                0xF0,
                0x8A,
                0x41,
                0xAC,
                0x56,
                0x5C,
                0xEE,
                0xD7,
                0xC5,
                0xB9,
                0x4B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11UnorderedAccessView1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x53,
                0x61,
                0x3B,
                0x7B,
                0x86,
                0xA8,
                0x44,
                0x45,
                0xAB,
                0x37,
                0x65,
                0x37,
                0xC8,
                0x50,
                0x04,
                0x03
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Query1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x66,
                0x47,
                0x1B,
                0x63,
                0xDC,
                0x36,
                0x1D,
                0x46,
                0x8D,
                0xB6,
                0xC4,
                0x7E,
                0x13,
                0xE6,
                0x09,
                0x16
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11DeviceContext3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1D,
                0xC0,
                0xE3,
                0xB4,
                0x9E,
                0xE7,
                0x37,
                0x46,
                0x91,
                0xB2,
                0x51,
                0x0E,
                0x9F,
                0x4C,
                0x9B,
                0x8F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Fence
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD1,
                0xE9,
                0xFD,
                0xAF,
                0xF7,
                0x1D,
                0xB7,
                0x4B,
                0x8A,
                0x34,
                0x0F,
                0x46,
                0x25,
                0x1D,
                0xAB,
                0x80
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11DeviceContext4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDA,
                0x00,
                0x76,
                0x91,
                0x8C,
                0xF5,
                0x33,
                0x4C,
                0x98,
                0xD8,
                0x3E,
                0x15,
                0xB3,
                0x90,
                0xFA,
                0x24
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Device3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x37,
                0x8C,
                0x5C,
                0xA0,
                0xC6,
                0xD2,
                0x32,
                0x47,
                0xB3,
                0xA0,
                0x9C,
                0xE0,
                0xB0,
                0xDC,
                0x9A,
                0xE6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}