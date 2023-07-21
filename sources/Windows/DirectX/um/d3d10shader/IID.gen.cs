// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.22621.0
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
    public static ref readonly Guid IID_ID3D10ShaderReflectionType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x7D, 0xAD, 0x30, 0xC5,
                0x16, 0x9B,
                0x95, 0x43,
                0xA9,
                0x79,
                0xBA,
                0x2E,
                0xCF,
                0xF8,
                0x3A,
                0xDD
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10ShaderReflectionVariable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x95, 0x3C, 0xF6, 0x1B,
                0x50, 0x26,
                0x5D, 0x40,
                0x99,
                0xC1,
                0x36,
                0x36,
                0xBD,
                0x1D,
                0xA0,
                0xA1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10ShaderReflectionConstantBuffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x94, 0x6A, 0xC6, 0x66,
                0xDD, 0xDD,
                0x62, 0x4B,
                0xA6,
                0x6A,
                0xF0,
                0xDA,
                0x33,
                0xC2,
                0xB4,
                0xD0
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D10ShaderReflection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB6, 0x20, 0x0E, 0xD4,
                0xF7, 0xF8,
                0xAD, 0x42,
                0xAB,
                0x20,
                0x4B,
                0xAF,
                0x8F,
                0x15,
                0xDF,
                0xAA
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
