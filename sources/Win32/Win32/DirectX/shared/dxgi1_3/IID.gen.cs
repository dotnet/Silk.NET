// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.26100.0
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
    public static ref readonly Guid IID_IDXGIDevice3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0x89,
                0x07,
                0x60,
                0x44,
                0x32,
                0xFD,
                0x4A,
                0xBF,
                0x18,
                0xA6,
                0xD3,
                0xBE,
                0xDA,
                0x50,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGISwapChain2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0x2A,
                0xBE,
                0xA8,
                0x9F,
                0x19,
                0x46,
                0x49,
                0xB3,
                0x31,
                0x79,
                0x59,
                0x9F,
                0xB9,
                0x8D,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIOutput2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x39,
                0x5E,
                0x59,
                0x24,
                0x27,
                0x63,
                0x46,
                0x99,
                0xB1,
                0xDA,
                0x96,
                0x9D,
                0xE2,
                0x83,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIFactory3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0x38,
                0x48,
                0x25,
                0x46,
                0xCD,
                0x7D,
                0x4C,
                0x86,
                0xCA,
                0x47,
                0xAA,
                0x95,
                0xB8,
                0x37,
                0xBD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIDecodeSwapChain
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6B,
                0x06,
                0x33,
                0x26,
                0x14,
                0x45,
                0x7A,
                0x4C,
                0x8F,
                0xD8,
                0x12,
                0xEA,
                0x98,
                0x05,
                0x9D,
                0x18,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIFactoryMedia
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0xD1,
                0xE7,
                0x41,
                0x91,
                0xA5,
                0x7B,
                0x4F,
                0xA2,
                0xE5,
                0xFA,
                0x9C,
                0x84,
                0x3E,
                0x1C,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGISwapChainMedia
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0B,
                0xB9,
                0x95,
                0xDD,
                0x5F,
                0xF0,
                0x6A,
                0x4F,
                0xBD,
                0x65,
                0x25,
                0xBF,
                0xB2,
                0x64,
                0xBD,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIOutput3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0xB3,
                0x6B,
                0x8A,
                0x7E,
                0x7E,
                0xF4,
                0x41,
                0xA8,
                0xE0,
                0x5B,
                0x32,
                0xF7,
                0xF9,
                0x9B,
                0x18,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
