// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DirectX
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid DXCORE_ADAPTER_ATTRIBUTE_D3D11_GRAPHICS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6B,
                0x86,
                0x47,
                0x8C,
                0x83,
                0x75,
                0x0D,
                0x45,
                0xF0,
                0xF0,
                0x6B,
                0xAD,
                0xA8,
                0x95,
                0xAF,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DXCORE_ADAPTER_ATTRIBUTE_D3D12_GRAPHICS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0xCE,
                0x9E,
                0x0C,
                0x6E,
                0x2F,
                0x01,
                0x4F,
                0x8C,
                0x96,
                0xE8,
                0x9E,
                0x33,
                0x1B,
                0x47,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DXCORE_ADAPTER_ATTRIBUTE_D3D12_CORE_COMPUTE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x28,
                0x8E,
                0x24,
                0x93,
                0xA7,
                0x24,
                0x47,
                0xAB,
                0xAA,
                0x23,
                0xA6,
                0xDE,
                0x1B,
                0xE0,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DXCORE_ADAPTER_ATTRIBUTE_D3D12_GENERIC_ML
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0x0D,
                0x1B,
                0xB7,
                0x88,
                0x10,
                0x2F,
                0x42,
                0xA2,
                0x7C,
                0x02,
                0x50,
                0xB7,
                0xD3,
                0xA9,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DXCORE_ADAPTER_ATTRIBUTE_D3D12_GENERIC_MEDIA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0xC8,
                0xB2,
                0x8E,
                0xF6,
                0x82,
                0x49,
                0x4B,
                0xAA,
                0x87,
                0xAE,
                0xCF,
                0xCF,
                0x01,
                0x74,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DXCORE_HARDWARE_TYPE_ATTRIBUTE_GPU
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0xB2,
                0x9E,
                0xB6,
                0xED,
                0x3D,
                0x64,
                0x44,
                0x97,
                0x9F,
                0xA0,
                0x0B,
                0xD4,
                0x68,
                0x70,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DXCORE_HARDWARE_TYPE_ATTRIBUTE_COMPUTE_ACCELERATOR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x95,
                0xB1,
                0xE0,
                0xEF,
                0x58,
                0x22,
                0x4A,
                0x90,
                0xF1,
                0x1F,
                0x28,
                0x16,
                0x9C,
                0xAB,
                0x8D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DXCORE_HARDWARE_TYPE_ATTRIBUTE_NPU
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0x40,
                0x61,
                0xD4,
                0xD7,
                0xAD,
                0x1B,
                0x45,
                0x9E,
                0x56,
                0x06,
                0xFE,
                0x8C,
                0x3B,
                0x58,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DXCORE_HARDWARE_TYPE_ATTRIBUTE_MEDIA_ACCELERATOR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0xB9,
                0xBD,
                0x66,
                0x0B,
                0x05,
                0xC7,
                0x44,
                0xA4,
                0xFD,
                0xD1,
                0x44,
                0xCE,
                0x0A,
                0xB4,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define _FACDXCORE 0x880")]
    public const int _FACDXCORE = 0x880;
}
