// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
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
    public static ref readonly Guid IID_IDXCoreAdapterFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x59,
                0xEE,
                0x78,
                0x6E,
                0xC3,
                0x13,
                0x4B,
                0xA6,
                0x69,
                0x00,
                0x5D,
                0xD1,
                0x1C,
                0x0F,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXCoreAdapterFactory1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0x2E,
                0x68,
                0xD5,
                0x21,
                0x6D,
                0x1C,
                0x40,
                0x82,
                0x7A,
                0x9A,
                0x51,
                0xA4,
                0xEA,
                0x35,
                0xD7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXCoreAdapterList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x77,
                0x6C,
                0x52,
                0xE9,
                0x40,
                0x9B,
                0x45,
                0xB7,
                0x11,
                0xF3,
                0x2A,
                0xD7,
                0x6D,
                0xFC,
                0x28,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXCoreAdapter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0x4C,
                0xDB,
                0xF0,
                0x5A,
                0xFE,
                0xA2,
                0x42,
                0xBD,
                0x62,
                0xF2,
                0xA6,
                0xCF,
                0x6F,
                0xC8,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXCoreAdapter1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x33,
                0x78,
                0xA0,
                0xA3,
                0xCF,
                0xBE,
                0x43,
                0x9D,
                0x79,
                0x55,
                0xB2,
                0xDA,
                0x97,
                0xC6,
                0x3C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
