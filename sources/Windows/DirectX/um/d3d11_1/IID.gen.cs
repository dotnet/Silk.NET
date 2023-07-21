// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.22621.0
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
    public static ref readonly Guid IID_ID3D11BlendState1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xBE, 0xFA, 0x86, 0xCC,
                0x55, 0xDA,
                0x1D, 0x40,
                0x85,
                0xE7,
                0xE3,
                0xC9,
                0xDE,
                0x28,
                0x77,
                0xE9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11RasterizerState1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA6, 0xD7, 0x17, 0x12,
                0x39, 0x50,
                0x8C, 0x41,
                0xB0,
                0x42,
                0x9C,
                0xBE,
                0x25,
                0x6A,
                0xFD,
                0x6E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3DDeviceContextState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8A, 0x0D, 0x1E, 0x5C,
                0x23, 0x7C,
                0xF9, 0x48,
                0x8C,
                0x59,
                0xA9,
                0x29,
                0x58,
                0xCE,
                0xFF,
                0x11
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11DeviceContext1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAA, 0x6F, 0x2C, 0xBB,
                0xFB, 0xB5,
                0x82, 0x40,
                0x8E,
                0x6B,
                0x38,
                0x8B,
                0x8C,
                0xFA,
                0x90,
                0xE1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11VideoContext1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDA, 0x26, 0xF0, 0xA7,
                0xF8, 0xA5,
                0x87, 0x44,
                0xA5,
                0x64,
                0x15,
                0xE3,
                0x43,
                0x57,
                0x65,
                0x1E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11VideoDevice1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x51, 0x1D, 0xDA, 0x29,
                0x21, 0x13,
                0x54, 0x44,
                0x80,
                0x4B,
                0xF5,
                0xFC,
                0x9F,
                0x86,
                0x1F,
                0x0F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11VideoProcessorEnumerator1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF2, 0x17, 0x52, 0x46,
                0x68, 0x55,
                0xCF, 0x43,
                0xB5,
                0xB9,
                0xF6,
                0x1D,
                0x54,
                0x53,
                0x1C,
                0xA1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Device1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x29, 0xFB, 0x4B, 0xA0,
                0xEF, 0x08,
                0xD6, 0x43,
                0xA4,
                0x9C,
                0xA9,
                0xBD,
                0xBD,
                0xCB,
                0xE6,
                0x86
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3DUserDefinedAnnotation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8B, 0xAD, 0xDA, 0xB2,
                0xD4, 0x03,
                0xBF, 0x4D,
                0x95,
                0xEB,
                0x32,
                0xAB,
                0x4B,
                0x63,
                0xD0,
                0xAB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
