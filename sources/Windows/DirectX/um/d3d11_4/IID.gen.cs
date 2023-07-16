// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.22621.0
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
    public static ref readonly Guid IID_ID3D11Device4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x71,
                0xAB,
                0x92,
                0x89,
                0xE6,
                0x02,
                0x8D,
                0x4B,
                0xBA,
                0x48,
                0xB0,
                0x56,
                0xDC,
                0xDA,
                0x42,
                0xC4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Device5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0xE2,
                0xFD,
                0x8F,
                0xE7,
                0xA0,
                0xDF,
                0x45,
                0x9E,
                0x01,
                0xE8,
                0x37,
                0x80,
                0x1B,
                0x5E,
                0xA0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Multithread
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x4E,
                0x7E,
                0x9B,
                0x2C,
                0x34,
                0x06,
                0x41,
                0xA1,
                0x9F,
                0x4F,
                0x27,
                0x04,
                0xF6,
                0x89,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11VideoContext2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4C,
                0x37,
                0xE7,
                0xC4,
                0x43,
                0x62,
                0x1B,
                0x4D,
                0xAE,
                0x87,
                0x52,
                0xB4,
                0xF7,
                0x40,
                0xE2,
                0x61
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11VideoDevice2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0xCB,
                0xC0,
                0x59,
                0xF0,
                0x35,
                0x70,
                0x4A,
                0x8F,
                0x67,
                0x87,
                0x90,
                0x5C,
                0x90,
                0x6A,
                0x53
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11VideoContext3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA0,
                0xFA,
                0xE2,
                0xA9,
                0x39,
                0xCB,
                0x8F,
                0x41,
                0xA0,
                0xB7,
                0xD8,
                0xAA,
                0xD4,
                0xDE,
                0x67,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}