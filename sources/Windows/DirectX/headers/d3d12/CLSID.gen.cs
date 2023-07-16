// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.DirectX;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class CLSID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D3D12Debug
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEB,
                0x2A,
                0x35,
                0xF2,
                0x84,
                0xDD,
                0xFE,
                0x49,
                0xB9,
                0x7B,
                0xA9,
                0xDC,
                0xFD,
                0xCC,
                0x1B,
                0x4F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D3D12Tools
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB1,
                0x16,
                0x82,
                0xE3,
                0x8C,
                0x3C,
                0x33,
                0x48,
                0xAA,
                0x09,
                0x0A,
                0x06,
                0xB6,
                0x5D,
                0x96,
                0xC8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D3D12DeviceRemovedExtendedData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC4,
                0xBB,
                0x75,
                0x4A,
                0xF4,
                0x9F,
                0xD8,
                0x4A,
                0x9F,
                0x18,
                0xAB,
                0xAE,
                0x84,
                0xDC,
                0x5F,
                0xF2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D3D12SDKConfiguration
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0x6A,
                0xDA,
                0x7C,
                0x3E,
                0xA0,
                0xC8,
                0x49,
                0x94,
                0x58,
                0x03,
                0x34,
                0xD2,
                0x0E,
                0x07,
                0xCE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D3D12DeviceFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBF,
                0x63,
                0x48,
                0x11,
                0x86,
                0xC3,
                0xEE,
                0x4A,
                0xB3,
                0x9D,
                0x8F,
                0x0B,
                0xBB,
                0x06,
                0x29,
                0x55
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}