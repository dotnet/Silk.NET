// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
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
    public static ref readonly Guid IID_IDXGIDisplayControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1A, 0xBF, 0x9D, 0xEA,
                0x8E, 0xC8,
                0x86, 0x44,
                0x85,
                0x4A,
                0x98,
                0xAA,
                0x01,
                0x38,
                0xF3,
                0x0C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIOutputDuplication
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC3, 0xFA, 0x1C, 0x19,
                0x41, 0xA3,
                0x0D, 0x47,
                0xB2,
                0x6E,
                0xA8,
                0x64,
                0xF4,
                0x28,
                0x31,
                0x9C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGISurface2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDD, 0x96, 0xA4, 0xAB,
                0x17, 0xB6,
                0xB8, 0x4C,
                0xA8,
                0x66,
                0xBC,
                0x44,
                0xD7,
                0xEB,
                0x1F,
                0xA2
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIResource1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x79, 0x13, 0x96, 0x30,
                0x09, 0x46,
                0x41, 0x4A,
                0x99,
                0x8E,
                0x54,
                0xFE,
                0x56,
                0x7E,
                0xE0,
                0xC1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIDevice2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x17, 0x86, 0x00, 0x05,
                0xFD, 0xFB,
                0x51, 0x40,
                0xA7,
                0x90,
                0x14,
                0x48,
                0x84,
                0xB4,
                0xF6,
                0xA9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGISwapChain1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF7, 0x45, 0x0A, 0x79,
                0x42, 0x0D,
                0x76, 0x48,
                0x98,
                0x3A,
                0x0A,
                0x55,
                0xCF,
                0xE6,
                0xF4,
                0xAA
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIFactory2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1C, 0x3A, 0xC8, 0x50,
                0x72, 0xE0,
                0x48, 0x4C,
                0x87,
                0xB0,
                0x36,
                0x30,
                0xFA,
                0x36,
                0xA6,
                0xD0
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIAdapter2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0A, 0xAE, 0xA1, 0x0A,
                0x0E, 0xFA,
                0x84, 0x4B,
                0x86,
                0x44,
                0xE0,
                0x5F,
                0xF8,
                0xE5,
                0xAC,
                0xB5
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIOutput1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA8, 0xDE, 0xCD, 0x00,
                0x9B, 0x93,
                0x83, 0x4B,
                0xA3,
                0x40,
                0xA6,
                0x85,
                0x22,
                0x66,
                0x66,
                0xCC
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
