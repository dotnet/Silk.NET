// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
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
    public static ref readonly Guid IID_IDXGIObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0x2F,
                0xC2,
                0xAE,
                0xF3,
                0x76,
                0x39,
                0x46,
                0x9B,
                0xE0,
                0x28,
                0xEB,
                0x43,
                0xA6,
                0x7A,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIDeviceSubObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0x03,
                0x3E,
                0x3D,
                0xDE,
                0xF9,
                0x58,
                0x4D,
                0xBB,
                0x6C,
                0x18,
                0xD6,
                0x29,
                0x92,
                0xF1,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIResource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0x3A,
                0x5F,
                0x03,
                0x2E,
                0x48,
                0x50,
                0x4E,
                0xB4,
                0x1F,
                0x8A,
                0x7F,
                0x8B,
                0xD8,
                0x96,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIKeyedMutex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0x12,
                0x8E,
                0x9D,
                0xB3,
                0xD7,
                0x5F,
                0x46,
                0x81,
                0x26,
                0x25,
                0x0E,
                0x34,
                0x9A,
                0xF8,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGISurface
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0xB5,
                0xFC,
                0xCA,
                0xC3,
                0x6A,
                0x89,
                0x48,
                0xBF,
                0x47,
                0x9E,
                0x23,
                0xBB,
                0xD2,
                0x60,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGISurface1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x30,
                0xE6,
                0x4A,
                0x27,
                0x63,
                0x1B,
                0x4C,
                0x80,
                0xAE,
                0xBF,
                0xE1,
                0x2E,
                0xA3,
                0x2B,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIAdapter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0xE7,
                0x11,
                0x24,
                0xAC,
                0x12,
                0xCF,
                0x4C,
                0xBD,
                0x14,
                0x97,
                0x98,
                0xE8,
                0x53,
                0x4D,
                0xC0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIOutput
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0xEE,
                0x02,
                0xAE,
                0x35,
                0xC7,
                0x90,
                0x46,
                0x8D,
                0x52,
                0x5A,
                0x8D,
                0xC2,
                0x02,
                0x13,
                0xAA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGISwapChain
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0x36,
                0x0D,
                0x31,
                0xE7,
                0xD2,
                0x0A,
                0x4C,
                0xAA,
                0x04,
                0x6A,
                0x9D,
                0x23,
                0xB8,
                0x88,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0x66,
                0x71,
                0x7B,
                0xC7,
                0x21,
                0xAE,
                0x44,
                0xB2,
                0x1A,
                0xC9,
                0xAE,
                0x32,
                0x1A,
                0xE3,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIDevice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0x77,
                0xEC,
                0x54,
                0x77,
                0x13,
                0xE6,
                0x44,
                0x8C,
                0x32,
                0x88,
                0xFD,
                0x5F,
                0x44,
                0xC8,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIFactory1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
                0xAE,
                0x0A,
                0x77,
                0x6F,
                0xF2,
                0xBA,
                0x4D,
                0xA8,
                0x29,
                0x25,
                0x3C,
                0x83,
                0xD1,
                0xB3,
                0x87,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIAdapter1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x8F,
                0x03,
                0x29,
                0x39,
                0x38,
                0x26,
                0x46,
                0x91,
                0xFD,
                0x08,
                0x68,
                0x79,
                0x01,
                0x1A,
                0x05,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIDevice1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0F,
                0x97,
                0xDB,
                0x77,
                0x76,
                0x62,
                0xBA,
                0x48,
                0xBA,
                0x28,
                0x07,
                0x01,
                0x43,
                0xB4,
                0x39,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
