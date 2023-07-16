// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_4.h in the Windows SDK for Windows 10.0.22621.0
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
    public static ref readonly Guid IID_IDXGISwapChain3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0x9B,
                0xD9,
                0x94,
                0xF8,
                0xF1,
                0xB0,
                0x4A,
                0xB2,
                0x36,
                0x7D,
                0xA0,
                0x17,
                0x0E,
                0xDA,
                0xB1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIOutput4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x35,
                0xCA,
                0x7D,
                0xDC,
                0x96,
                0x21,
                0x4D,
                0x41,
                0x9F,
                0x53,
                0x61,
                0x78,
                0x84,
                0x03,
                0x2A,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIFactory4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0xEA,
                0xC6,
                0x1B,
                0x36,
                0xEF,
                0x4F,
                0x46,
                0xBF,
                0x0C,
                0x21,
                0xCA,
                0x39,
                0xE5,
                0x16,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDXGIAdapter3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA4,
                0x67,
                0x59,
                0x64,
                0x92,
                0x13,
                0x10,
                0x43,
                0xA7,
                0x98,
                0x80,
                0x53,
                0xCE,
                0x3E,
                0x93,
                0xFD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}