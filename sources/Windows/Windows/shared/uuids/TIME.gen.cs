// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class TIME
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid TIME_FORMAT_NONE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TIME_FORMAT_FRAME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x70,
                0x55,
                0x78,
                0x7B,
                0x82,
                0x8C,
                0xCF,
                0x11,
                0xBC,
                0x0C,
                0x00,
                0xAA,
                0x00,
                0xAC,
                0x74,
                0xF6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TIME_FORMAT_BYTE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x71,
                0x55,
                0x78,
                0x7B,
                0x82,
                0x8C,
                0xCF,
                0x11,
                0xBC,
                0x0C,
                0x00,
                0xAA,
                0x00,
                0xAC,
                0x74,
                0xF6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TIME_FORMAT_SAMPLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x72,
                0x55,
                0x78,
                0x7B,
                0x82,
                0x8C,
                0xCF,
                0x11,
                0xBC,
                0x0C,
                0x00,
                0xAA,
                0x00,
                0xAC,
                0x74,
                0xF6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TIME_FORMAT_FIELD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x73,
                0x55,
                0x78,
                0x7B,
                0x82,
                0x8C,
                0xCF,
                0x11,
                0xBC,
                0x0C,
                0x00,
                0xAA,
                0x00,
                0xAC,
                0x74,
                0xF6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TIME_FORMAT_MEDIA_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x74,
                0x55,
                0x78,
                0x7B,
                0x82,
                0x8C,
                0xCF,
                0x11,
                0xBC,
                0x0C,
                0x00,
                0xAA,
                0x00,
                0xAC,
                0x74,
                0xF6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}