// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MFT
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_ENCODER_ERROR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0xED,
                0xD1,
                0xC8,
                0xE4,
                0x98,
                0xD5,
                0x41,
                0x92,
                0x97,
                0x44,
                0xF5,
                0x38,
                0x52,
                0xF9,
                0x0E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_GFX_DRIVER_VERSION_ID_Attribute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0x90,
                0x4B,
                0xF3,
                0xE0,
                0x05,
                0x16,
                0x4B,
                0x99,
                0x3D,
                0x3E,
                0x2A,
                0x2C,
                0xDE,
                0x6A,
                0xD3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_CATEGORY_VIDEO_DECODER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0x2D,
                0xC0,
                0xD6,
                0x33,
                0x68,
                0xB4,
                0x45,
                0x97,
                0x1A,
                0x05,
                0xA4,
                0xB0,
                0x4B,
                0xAB,
                0x91,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_CATEGORY_VIDEO_ENCODER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0xAC,
                0x9E,
                0xF7,
                0x45,
                0xE5,
                0x87,
                0x43,
                0xBD,
                0xEE,
                0xD6,
                0x47,
                0xD7,
                0xBD,
                0xE4,
                0x2A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_CATEGORY_VIDEO_EFFECT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x7C,
                0xE1,
                0x12,
                0x2C,
                0x53,
                0x6E,
                0x4A,
                0x8A,
                0x1C,
                0x40,
                0x82,
                0x5A,
                0x73,
                0x63,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_CATEGORY_MULTIPLEXER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0x56,
                0x9C,
                0x05,
                0xAE,
                0x05,
                0x61,
                0x4B,
                0xB6,
                0x9D,
                0x55,
                0xB6,
                0x1E,
                0xE5,
                0x4A,
                0x7B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_CATEGORY_DEMULTIPLEXER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0x0A,
                0x70,
                0xA8,
                0x9B,
                0x93,
                0xC5,
                0x44,
                0x99,
                0xD7,
                0x76,
                0x22,
                0x6B,
                0x23,
                0xB3,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_CATEGORY_AUDIO_DECODER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0x3F,
                0xA7,
                0x9E,
                0x7A,
                0xEF,
                0x59,
                0x45,
                0x8D,
                0x5D,
                0x71,
                0x9D,
                0x8F,
                0x04,
                0x26,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_CATEGORY_AUDIO_ENCODER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0x4B,
                0xC6,
                0x91,
                0x1E,
                0xF9,
                0x8C,
                0x4D,
                0x92,
                0x76,
                0xDB,
                0x24,
                0x82,
                0x79,
                0xD9,
                0x75,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_CATEGORY_AUDIO_EFFECT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x4C,
                0x06,
                0x11,
                0x48,
                0x36,
                0xD0,
                0x4E,
                0x93,
                0x2E,
                0x05,
                0xCE,
                0x8A,
                0xC8,
                0x11,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_CATEGORY_VIDEO_PROCESSOR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0xA3,
                0x2E,
                0x30,
                0x5F,
                0xAA,
                0xF9,
                0x47,
                0x9F,
                0x7A,
                0xC2,
                0x18,
                0x8B,
                0xB1,
                0x63,
                0x02,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_CATEGORY_OTHER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0x5D,
                0x17,
                0x90,
                0xEA,
                0xB7,
                0x01,
                0x49,
                0xAE,
                0xB3,
                0x93,
                0x3A,
                0x87,
                0x47,
                0x75,
                0x6F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_CATEGORY_ENCRYPTOR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0x87,
                0xC6,
                0xB0,
                0xCD,
                0x01,
                0xB5,
                0x44,
                0xB8,
                0xB2,
                0x7C,
                0x1D,
                0x7E,
                0x05,
                0x8B,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_CATEGORY_VIDEO_RENDERER_EFFECT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0xD8,
                0x5C,
                0x14,
                0xF4,
                0x92,
                0x23,
                0x4B,
                0x8A,
                0xE7,
                0xE0,
                0xDF,
                0x06,
                0xC2,
                0xDA,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_ENUM_VIDEO_RENDERER_EXTENSION_PROFILE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0x69,
                0xC5,
                0x62,
                0x4E,
                0x9A,
                0x3B,
                0x44,
                0xB9,
                0xDC,
                0xCA,
                0xC8,
                0x30,
                0xC2,
                0x41,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_ENUM_ADAPTER_LUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x51,
                0x39,
                0x1D,
                0x20,
                0xE2,
                0xA8,
                0x4D,
                0xA0,
                0x7F,
                0xBA,
                0x17,
                0x25,
                0x52,
                0xD6,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_SUPPORT_DYNAMIC_FORMAT_CHANGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0x6A,
                0x47,
                0x53,
                0x13,
                0x3F,
                0xFB,
                0x49,
                0xAC,
                0x42,
                0xEE,
                0x27,
                0x33,
                0xC9,
                0x67,
                0x41,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
