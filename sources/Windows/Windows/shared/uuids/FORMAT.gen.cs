// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class FORMAT
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid FORMAT_None
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD6,
                0x17,
                0x64,
                0x0F,
                0x18,
                0xC3,
                0xD0,
                0x11,
                0xA4,
                0x3F,
                0x00,
                0xA0,
                0xC9,
                0x22,
                0x31,
                0x96
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FORMAT_VideoInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0x9F,
                0x58,
                0x05,
                0x56,
                0xC3,
                0xCE,
                0x11,
                0xBF,
                0x01,
                0x00,
                0xAA,
                0x00,
                0x55,
                0x59,
                0x5A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FORMAT_VideoInfo2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA0,
                0x76,
                0x2A,
                0xF7,
                0x0A,
                0xEB,
                0xD0,
                0x11,
                0xAC,
                0xE4,
                0x00,
                0x00,
                0xC0,
                0xCC,
                0x16,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FORMAT_WaveFormatEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0x9F,
                0x58,
                0x05,
                0x56,
                0xC3,
                0xCE,
                0x11,
                0xBF,
                0x01,
                0x00,
                0xAA,
                0x00,
                0x55,
                0x59,
                0x5A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FORMAT_MPEGVideo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0x9F,
                0x58,
                0x05,
                0x56,
                0xC3,
                0xCE,
                0x11,
                0xBF,
                0x01,
                0x00,
                0xAA,
                0x00,
                0x55,
                0x59,
                0x5A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FORMAT_MPEGStreams
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0x9F,
                0x58,
                0x05,
                0x56,
                0xC3,
                0xCE,
                0x11,
                0xBF,
                0x01,
                0x00,
                0xAA,
                0x00,
                0x55,
                0x59,
                0x5A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FORMAT_DvInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0x9F,
                0x58,
                0x05,
                0x56,
                0xC3,
                0xCE,
                0x11,
                0xBF,
                0x01,
                0x00,
                0xAA,
                0x00,
                0x55,
                0x59,
                0x5A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FORMAT_525WSS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0xF0,
                0xEC,
                0xC7,
                0x82,
                0x45,
                0x69,
                0x48,
                0x9A,
                0xBB,
                0xBF,
                0xB5,
                0x23,
                0xB6,
                0x2E,
                0xDF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FORMAT_AnalogVideo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0xDD,
                0x82,
                0x04,
                0x17,
                0x78,
                0xCF,
                0x11,
                0x8A,
                0x03,
                0x00,
                0xAA,
                0x00,
                0x6E,
                0xCB,
                0x65
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FORMAT_CAPTIONED_H264VIDEO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x24,
                0xC0,
                0xEF,
                0xA4,
                0x3E,
                0x87,
                0xA3,
                0x4D,
                0x89,
                0x8B,
                0x47,
                0x4D,
                0xDB,
                0xD7,
                0x9F,
                0xD0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FORMAT_CC_CONTAINER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4A,
                0x7A,
                0x99,
                0x50,
                0x08,
                0xE5,
                0x54,
                0x40,
                0xA2,
                0xB2,
                0x10,
                0xFF,
                0x0A,
                0xC1,
                0xA6,
                0x9A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FORMAT_CAPTIONED_MPEG2VIDEO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA2,
                0xAD,
                0xB2,
                0x7A,
                0xB6,
                0x81,
                0x14,
                0x4F,
                0xB3,
                0xC8,
                0xD0,
                0xC4,
                0x86,
                0x39,
                0x3B,
                0x67
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}