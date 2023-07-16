// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class MF
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_WVC1_PROG_SINGLE_SLICE_CONTENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x59,
                0x25,
                0xEC,
                0x67,
                0x2F,
                0x0F,
                0x20,
                0x44,
                0xA4,
                0xDD,
                0x2F,
                0x8E,
                0xE7,
                0xA5,
                0x73,
                0x8B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_PROGRESSIVE_CODING_CONTENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEA,
                0x0E,
                0x02,
                0x8F,
                0x08,
                0x15,
                0x1F,
                0x47,
                0x9D,
                0xA6,
                0x50,
                0x7D,
                0x7C,
                0xFA,
                0x40,
                0xDB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_NALU_LENGTH_SET
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x53,
                0x1D,
                0x91,
                0xA7,
                0xA4,
                0x12,
                0x65,
                0x49,
                0xAE,
                0x70,
                0x6E,
                0xAD,
                0xD6,
                0xFF,
                0x05,
                0x51
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_NALU_LENGTH_INFORMATION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0x4E,
                0x12,
                0x19,
                0x4B,
                0xAD,
                0x5F,
                0x46,
                0xBB,
                0x18,
                0x20,
                0x18,
                0x62,
                0x87,
                0xB6,
                0xAF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_USER_DATA_PAYLOAD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5D,
                0x98,
                0xD4,
                0xD1,
                0x92,
                0xDC,
                0x7A,
                0x45,
                0xB3,
                0xA0,
                0x65,
                0x1A,
                0x33,
                0xA3,
                0x10,
                0x47
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MPEG4SINK_SPSPPS_PASSTHROUGH
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x34,
                0xA1,
                0x01,
                0x56,
                0x05,
                0x20,
                0xD2,
                0x4A,
                0xB3,
                0x7D,
                0x22,
                0xA6,
                0xC5,
                0x54,
                0xDE,
                0xB2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MPEG4SINK_MOOV_BEFORE_MDAT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAC,
                0xE3,
                0x72,
                0xF6,
                0xE6,
                0xE1,
                0x10,
                0x4F,
                0xB5,
                0xEC,
                0x5F,
                0x3B,
                0x30,
                0x82,
                0x88,
                0x16
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MPEG4SINK_MINIMUM_PROPERTIES_SIZE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0xED,
                0xA1,
                0xDC,
                0x0E,
                0x45,
                0x22,
                0x4A,
                0x8C,
                0x62,
                0x4E,
                0xD4,
                0x52,
                0xF7,
                0xA1,
                0x87
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MPEG4SINK_MIN_FRAGMENT_DURATION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0x57,
                0x0B,
                0xA3,
                0xFD,
                0x8E,
                0xE8,
                0x45,
                0x94,
                0xFE,
                0x27,
                0xC8,
                0x4B,
                0x5B,
                0xDF,
                0xF6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MPEG4SINK_MAX_CODED_SEQUENCES_PER_FRAGMENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD6,
                0x3B,
                0x1B,
                0xFC,
                0x2D,
                0x69,
                0xE5,
                0x4C,
                0x92,
                0x99,
                0x73,
                0x8A,
                0xA5,
                0x46,
                0x3E,
                0x9A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SESSION_TOPOLOADER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0xD4,
                0x83,
                0x1E,
                0x1C,
                0x1F,
                0x71,
                0x45,
                0x84,
                0x05,
                0x88,
                0xF4,
                0xB2,
                0x18,
                0x1F,
                0x71
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SESSION_GLOBAL_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0xD4,
                0x83,
                0x1E,
                0x1C,
                0x1F,
                0x71,
                0x45,
                0x84,
                0x05,
                0x88,
                0xF4,
                0xB2,
                0x18,
                0x1F,
                0x72
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SESSION_QUALITY_MANAGER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0xD4,
                0x83,
                0x1E,
                0x1C,
                0x1F,
                0x71,
                0x45,
                0x84,
                0x05,
                0x88,
                0xF4,
                0xB2,
                0x18,
                0x1F,
                0x73
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SESSION_CONTENT_PROTECTION_MANAGER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0xD4,
                0x83,
                0x1E,
                0x1C,
                0x1F,
                0x71,
                0x45,
                0x84,
                0x05,
                0x88,
                0xF4,
                0xB2,
                0x18,
                0x1F,
                0x74
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SESSION_SERVER_CONTEXT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x91,
                0xB2,
                0xE5,
                0xAF,
                0xFA,
                0x50,
                0xE8,
                0x46,
                0xB9,
                0xBE,
                0x0C,
                0x0C,
                0x3C,
                0xE4,
                0xB3,
                0xA5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SESSION_REMOTE_SOURCE_MODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF4,
                0x3E,
                0x03,
                0xF4,
                0xB3,
                0x9B,
                0x78,
                0x43,
                0x94,
                0x1F,
                0x85,
                0xA0,
                0x85,
                0x6B,
                0xC2,
                0x44
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SESSION_APPROX_EVENT_OCCURRENCE_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2F,
                0x85,
                0x0E,
                0x19,
                0x38,
                0x62,
                0xD1,
                0x42,
                0xB5,
                0xAF,
                0x69,
                0xEA,
                0x33,
                0x8E,
                0xF8,
                0x50
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_PMP_SERVER_CONTEXT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0xC9,
                0x00,
                0x2F,
                0xCF,
                0xD2,
                0x78,
                0x42,
                0x8B,
                0x6A,
                0xD0,
                0x77,
                0xFA,
                0xC3,
                0xA2,
                0x5F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TIME_FORMAT_ENTRY_RELATIVE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x78,
                0xF1,
                0x99,
                0x43,
                0xD3,
                0x46,
                0x04,
                0x45,
                0xAF,
                0xDA,
                0x20,
                0xD3,
                0x2E,
                0x9B,
                0xA3,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SOURCE_STREAM_SUPPORTS_HW_CONNECTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAA,
                0x53,
                0x82,
                0xA3,
                0x14,
                0x63,
                0xFD,
                0x42,
                0xA3,
                0xCE,
                0xBB,
                0x27,
                0xB6,
                0x85,
                0x99,
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_STREAM_SINK_SUPPORTS_HW_CONNECTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBF,
                0x5C,
                0x46,
                0x9B,
                0x97,
                0x05,
                0x9E,
                0x4F,
                0x9F,
                0x3C,
                0xB9,
                0x7E,
                0xEE,
                0xF9,
                0x03,
                0x59
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_STREAM_SINK_SUPPORTS_ROTATION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0x62,
                0xE9,
                0xB3,
                0x05,
                0xBD,
                0xA5,
                0x41,
                0x97,
                0xAD,
                0x8A,
                0x7F,
                0xEE,
                0x24,
                0xB9,
                0x12
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SINK_VIDEO_PTS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE7,
                0xBD,
                0x62,
                0x21,
                0x1E,
                0x42,
                0x90,
                0x4B,
                0x9B,
                0x33,
                0xE5,
                0x8F,
                0xBF,
                0x1D,
                0x58,
                0xB6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SINK_VIDEO_NATIVE_WIDTH
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x07,
                0xA7,
                0xD6,
                0xE6,
                0x05,
                0x15,
                0x47,
                0x47,
                0x9B,
                0x10,
                0x72,
                0xD2,
                0xD1,
                0x58,
                0xCB,
                0x3A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SINK_VIDEO_NATIVE_HEIGHT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0x67,
                0xCA,
                0xF0,
                0x0C,
                0x49,
                0xE8,
                0x43,
                0x94,
                0x1C,
                0xC0,
                0xB3,
                0x20,
                0x6B,
                0x9A,
                0x65
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SINK_VIDEO_DISPLAY_ASPECT_RATIO_NUMERATOR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0x3B,
                0xF3,
                0xD0,
                0x8A,
                0xB7,
                0x79,
                0x48,
                0xB4,
                0x55,
                0xF0,
                0x3E,
                0xF3,
                0xFA,
                0x82,
                0xCD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SINK_VIDEO_DISPLAY_ASPECT_RATIO_DENOMINATOR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x97,
                0xEB,
                0xA1,
                0x6E,
                0xE0,
                0x1F,
                0x10,
                0x4F,
                0xA6,
                0xE4,
                0x1F,
                0x4F,
                0x66,
                0x15,
                0x64,
                0xE0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_BD_MVC_PLANE_OFFSET_METADATA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0x54,
                0xA6,
                0x62,
                0x6C,
                0xB7,
                0x01,
                0x49,
                0x98,
                0x23,
                0x2C,
                0xB6,
                0x15,
                0xD4,
                0x73,
                0x18
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_LUMA_KEY_ENABLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0F,
                0x82,
                0x69,
                0x73,
                0xDE,
                0x76,
                0xCA,
                0x43,
                0x92,
                0x84,
                0x47,
                0xB8,
                0xF3,
                0x7E,
                0x06,
                0x49
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_LUMA_KEY_LOWER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD5,
                0xB8,
                0xD7,
                0x93,
                0x81,
                0x0B,
                0x15,
                0x47,
                0xAE,
                0xA0,
                0x87,
                0x25,
                0x87,
                0x16,
                0x21,
                0xE9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_LUMA_KEY_UPPER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBB,
                0x39,
                0x9F,
                0xD0,
                0x02,
                0x46,
                0x31,
                0x4C,
                0xA7,
                0x06,
                0xA1,
                0x21,
                0x71,
                0xA5,
                0x11,
                0x0A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_USER_EXTENDED_ATTRIBUTES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0xBA,
                0x2A,
                0xC0,
                0xB2,
                0xFE,
                0x41,
                0x45,
                0x92,
                0x2F,
                0x92,
                0x0B,
                0x43,
                0x70,
                0x27,
                0x22
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_INDEPENDENT_STILL_IMAGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0xAF,
                0x12,
                0xEA,
                0x10,
                0x07,
                0xC9,
                0x42,
                0xA1,
                0x27,
                0xDA,
                0xA3,
                0xE7,
                0x84,
                0x83,
                0xA5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_XVP_SAMPLE_LOCK_TIMEOUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x29,
                0xDB,
                0x4D,
                0xAA,
                0x34,
                0x51,
                0x63,
                0x43,
                0xAC,
                0x72,
                0x83,
                0xEC,
                0x4B,
                0xC1,
                0x04,
                0x26
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPOLOGY_PROJECTSTART
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0xF8,
                0xD3,
                0x7E,
                0xBB,
                0x86,
                0x3F,
                0x4B,
                0xB7,
                0xE4,
                0x7C,
                0xB4,
                0x3A,
                0xFD,
                0x4B,
                0x80
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPOLOGY_PROJECTSTOP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xF8,
                0xD3,
                0x7E,
                0xBB,
                0x86,
                0x3F,
                0x4B,
                0xB7,
                0xE4,
                0x7C,
                0xB4,
                0x3A,
                0xFD,
                0x4B,
                0x80
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPOLOGY_NO_MARKIN_MARKOUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x04,
                0xF8,
                0xD3,
                0x7E,
                0xBB,
                0x86,
                0x3F,
                0x4B,
                0xB7,
                0xE4,
                0x7C,
                0xB4,
                0x3A,
                0xFD,
                0x4B,
                0x80
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPOLOGY_DXVA_MODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF6,
                0x34,
                0x8D,
                0x1E,
                0xAB,
                0xF5,
                0x23,
                0x4E,
                0xBB,
                0x88,
                0x87,
                0x4A,
                0xA3,
                0xA1,
                0xA7,
                0x4D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPOLOGY_ENABLE_XVP_FOR_PLAYBACK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1F,
                0x73,
                0x67,
                0x19,
                0x78,
                0xCD,
                0xFC,
                0x42,
                0xB0,
                0x26,
                0x09,
                0x92,
                0xA5,
                0x6E,
                0x56,
                0x93
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPOLOGY_STATIC_PLAYBACK_OPTIMIZATIONS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x42,
                0xAC,
                0x6C,
                0xB8,
                0xA6,
                0x41,
                0x79,
                0x4B,
                0x89,
                0x7A,
                0x1A,
                0xB0,
                0xE5,
                0x2B,
                0x4A,
                0x1B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPOLOGY_PLAYBACK_MAX_DIMS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0xCF,
                0x15,
                0x57,
                0x68,
                0x57,
                0xAA,
                0x44,
                0xAD,
                0x6E,
                0x87,
                0x21,
                0xF1,
                0xB0,
                0xF9,
                0xBB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPOLOGY_HARDWARE_MODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFD,
                0x62,
                0xD3,
                0xD2,
                0x4F,
                0x4E,
                0x91,
                0x41,
                0xA5,
                0x79,
                0xC6,
                0x18,
                0xB6,
                0x67,
                0x06,
                0xAF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPOLOGY_PLAYBACK_FRAMERATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7A,
                0x73,
                0x64,
                0xC1,
                0xB1,
                0xC2,
                0x53,
                0x45,
                0x83,
                0xBB,
                0x5A,
                0x52,
                0x60,
                0x72,
                0x44,
                0x8F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPOLOGY_DYNAMIC_CHANGE_NOT_ALLOWED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0B,
                0x95,
                0x29,
                0xD5,
                0x84,
                0xD4,
                0x27,
                0x45,
                0xA9,
                0xCD,
                0xB1,
                0x90,
                0x95,
                0x32,
                0xB5,
                0xB0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPOLOGY_ENUMERATE_SOURCE_TYPES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6D,
                0xC3,
                0x48,
                0x62,
                0x0B,
                0x5D,
                0x40,
                0x4F,
                0xA0,
                0xBB,
                0xB0,
                0xB3,
                0x05,
                0xF7,
                0x76,
                0x98
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPOLOGY_START_TIME_ON_PRESENTATION_SWITCH
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3F,
                0x11,
                0xCC,
                0xC8,
                0x51,
                0x79,
                0x48,
                0x45,
                0xAA,
                0xD6,
                0x9E,
                0xD6,
                0x20,
                0x2E,
                0x62,
                0xB3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DISABLE_LOCALLY_REGISTERED_PLUGINS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA9,
                0x6D,
                0xB1,
                0x66,
                0xD4,
                0xAD,
                0xE0,
                0x47,
                0xA1,
                0x6B,
                0x5A,
                0xF1,
                0xFB,
                0x48,
                0x36,
                0x34
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_LOCAL_PLUGIN_CONTROL_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0x00,
                0x1B,
                0xD9,
                0x6D,
                0xC8,
                0x81,
                0x4F,
                0x88,
                0x22,
                0x8C,
                0x68,
                0xE1,
                0xD7,
                0xFA,
                0x04
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_FLUSH
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE8,
                0xBC,
                0x4B,
                0x49,
                0x31,
                0xB0,
                0x38,
                0x4E,
                0x97,
                0xC4,
                0xD5,
                0x42,
                0x2D,
                0xD6,
                0x18,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_DRAIN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE9,
                0xBC,
                0x4B,
                0x49,
                0x31,
                0xB0,
                0x38,
                0x4E,
                0x97,
                0xC4,
                0xD5,
                0x42,
                0x2D,
                0xD6,
                0x18,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_D3DAWARE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xED,
                0xBC,
                0x4B,
                0x49,
                0x31,
                0xB0,
                0x38,
                0x4E,
                0x97,
                0xC4,
                0xD5,
                0x42,
                0x2D,
                0xD6,
                0x18,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPOLOGY_RESOLUTION_STATUS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDE,
                0xBC,
                0x4B,
                0x49,
                0x31,
                0xB0,
                0x38,
                0x4E,
                0x97,
                0xC4,
                0xD5,
                0x42,
                0x2D,
                0xD6,
                0x18,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_ERRORCODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0xBC,
                0x4B,
                0x49,
                0x31,
                0xB0,
                0x38,
                0x4E,
                0x97,
                0xC4,
                0xD5,
                0x42,
                0x2D,
                0xD6,
                0x18,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_CONNECT_METHOD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF1,
                0xBC,
                0x4B,
                0x49,
                0x31,
                0xB0,
                0x38,
                0x4E,
                0x97,
                0xC4,
                0xD5,
                0x42,
                0x2D,
                0xD6,
                0x18,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_LOCKED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF7,
                0xBC,
                0x4B,
                0x49,
                0x31,
                0xB0,
                0x38,
                0x4E,
                0x97,
                0xC4,
                0xD5,
                0x42,
                0x2D,
                0xD6,
                0x18,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_WORKQUEUE_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF8,
                0xBC,
                0x4B,
                0x49,
                0x31,
                0xB0,
                0x38,
                0x4E,
                0x97,
                0xC4,
                0xD5,
                0x42,
                0x2D,
                0xD6,
                0x18,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_WORKQUEUE_MMCSS_CLASS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF9,
                0xBC,
                0x4B,
                0x49,
                0x31,
                0xB0,
                0x38,
                0x4E,
                0x97,
                0xC4,
                0xD5,
                0x42,
                0x2D,
                0xD6,
                0x18,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_DECRYPTOR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFA,
                0xBC,
                0x4B,
                0x49,
                0x31,
                0xB0,
                0x38,
                0x4E,
                0x97,
                0xC4,
                0xD5,
                0x42,
                0x2D,
                0xD6,
                0x18,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_DISCARDABLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFB,
                0xBC,
                0x4B,
                0x49,
                0x31,
                0xB0,
                0x38,
                0x4E,
                0x97,
                0xC4,
                0xD5,
                0x42,
                0x2D,
                0xD6,
                0x18,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_ERROR_MAJORTYPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFD,
                0xBC,
                0x4B,
                0x49,
                0x31,
                0xB0,
                0x38,
                0x4E,
                0x97,
                0xC4,
                0xD5,
                0x42,
                0x2D,
                0xD6,
                0x18,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_ERROR_SUBTYPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFE,
                0xBC,
                0x4B,
                0x49,
                0x31,
                0xB0,
                0x38,
                0x4E,
                0x97,
                0xC4,
                0xD5,
                0x42,
                0x2D,
                0xD6,
                0x18,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_WORKQUEUE_MMCSS_TASKID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0xBC,
                0x4B,
                0x49,
                0x31,
                0xB0,
                0x38,
                0x4E,
                0x97,
                0xC4,
                0xD5,
                0x42,
                0x2D,
                0xD6,
                0x18,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_WORKQUEUE_MMCSS_PRIORITY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0xF8,
                0x01,
                0x50,
                0x16,
                0x28,
                0xF4,
                0x48,
                0x93,
                0x64,
                0xAD,
                0x1E,
                0xF6,
                0x61,
                0xA1,
                0x23
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_WORKQUEUE_ITEM_PRIORITY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBE,
                0x99,
                0xFF,
                0xA1,
                0x97,
                0x5E,
                0x53,
                0x4A,
                0xB4,
                0x94,
                0x56,
                0x8C,
                0x64,
                0x2C,
                0x0F,
                0xF3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_MARKIN_HERE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0xBD,
                0x4B,
                0x49,
                0x31,
                0xB0,
                0x38,
                0x4E,
                0x97,
                0xC4,
                0xD5,
                0x42,
                0x2D,
                0xD6,
                0x18,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_MARKOUT_HERE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0xBD,
                0x4B,
                0x49,
                0x31,
                0xB0,
                0x38,
                0x4E,
                0x97,
                0xC4,
                0xD5,
                0x42,
                0x2D,
                0xD6,
                0x18,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_DECODER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0xBD,
                0x4B,
                0x49,
                0x31,
                0xB0,
                0x38,
                0x4E,
                0x97,
                0xC4,
                0xD5,
                0x42,
                0x2D,
                0xD6,
                0x18,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_MEDIASTART
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEA,
                0x58,
                0x5C,
                0x83,
                0x75,
                0xE0,
                0xC7,
                0x4B,
                0xBC,
                0xBA,
                0x4D,
                0xE0,
                0x00,
                0xDF,
                0x9A,
                0xE6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_MEDIASTOP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEB,
                0x58,
                0x5C,
                0x83,
                0x75,
                0xE0,
                0xC7,
                0x4B,
                0xBC,
                0xBA,
                0x4D,
                0xE0,
                0x00,
                0xDF,
                0x9A,
                0xE6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_SOURCE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEC,
                0x58,
                0x5C,
                0x83,
                0x75,
                0xE0,
                0xC7,
                0x4B,
                0xBC,
                0xBA,
                0x4D,
                0xE0,
                0x00,
                0xDF,
                0x9A,
                0xE6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_PRESENTATION_DESCRIPTOR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xED,
                0x58,
                0x5C,
                0x83,
                0x75,
                0xE0,
                0xC7,
                0x4B,
                0xBC,
                0xBA,
                0x4D,
                0xE0,
                0x00,
                0xDF,
                0x9A,
                0xE6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_STREAM_DESCRIPTOR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0x58,
                0x5C,
                0x83,
                0x75,
                0xE0,
                0xC7,
                0x4B,
                0xBC,
                0xBA,
                0x4D,
                0xE0,
                0x00,
                0xDF,
                0x9A,
                0xE6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_SEQUENCE_ELEMENTID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEF,
                0x58,
                0x5C,
                0x83,
                0x75,
                0xE0,
                0xC7,
                0x4B,
                0xBC,
                0xBA,
                0x4D,
                0xE0,
                0x00,
                0xDF,
                0x9A,
                0xE6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_TRANSFORM_OBJECTID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC9,
                0xC0,
                0xDC,
                0x88,
                0x3E,
                0x29,
                0x8B,
                0x4E,
                0x9A,
                0xEB,
                0x0A,
                0xD6,
                0x4C,
                0xC0,
                0x16,
                0xB0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_STREAMID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9B,
                0x2F,
                0x93,
                0x14,
                0x87,
                0x90,
                0xB4,
                0x4B,
                0x84,
                0x12,
                0x51,
                0x67,
                0x14,
                0x5C,
                0xBE,
                0x04
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_NOSHUTDOWN_ON_REMOVE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9C,
                0x2F,
                0x93,
                0x14,
                0x87,
                0x90,
                0xB4,
                0x4B,
                0x84,
                0x12,
                0x51,
                0x67,
                0x14,
                0x5C,
                0xBE,
                0x04
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_RATELESS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9D,
                0x2F,
                0x93,
                0x14,
                0x87,
                0x90,
                0xB4,
                0x4B,
                0x84,
                0x12,
                0x51,
                0x67,
                0x14,
                0x5C,
                0xBE,
                0x04
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_DISABLE_PREROLL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9E,
                0x2F,
                0x93,
                0x14,
                0x87,
                0x90,
                0xB4,
                0x4B,
                0x84,
                0x12,
                0x51,
                0x67,
                0x14,
                0x5C,
                0xBE,
                0x04
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_PRIMARYOUTPUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x99,
                0xEF,
                0x04,
                0x63,
                0xB2,
                0x16,
                0xBE,
                0x4E,
                0x9D,
                0x67,
                0xE4,
                0xC5,
                0x39,
                0xB3,
                0xA2,
                0x59
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_PD_PMPHOST_CONTEXT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0x0D,
                0x99,
                0x6C,
                0x8E,
                0xBB,
                0x7A,
                0x47,
                0x85,
                0x98,
                0x0D,
                0x5D,
                0x96,
                0xFC,
                0xD8,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_PD_APP_CONTEXT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x32,
                0x0D,
                0x99,
                0x6C,
                0x8E,
                0xBB,
                0x7A,
                0x47,
                0x85,
                0x98,
                0x0D,
                0x5D,
                0x96,
                0xFC,
                0xD8,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_PD_DURATION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0x0D,
                0x99,
                0x6C,
                0x8E,
                0xBB,
                0x7A,
                0x47,
                0x85,
                0x98,
                0x0D,
                0x5D,
                0x96,
                0xFC,
                0xD8,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_PD_TOTAL_FILE_SIZE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x34,
                0x0D,
                0x99,
                0x6C,
                0x8E,
                0xBB,
                0x7A,
                0x47,
                0x85,
                0x98,
                0x0D,
                0x5D,
                0x96,
                0xFC,
                0xD8,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_PD_AUDIO_ENCODING_BITRATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x35,
                0x0D,
                0x99,
                0x6C,
                0x8E,
                0xBB,
                0x7A,
                0x47,
                0x85,
                0x98,
                0x0D,
                0x5D,
                0x96,
                0xFC,
                0xD8,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_PD_VIDEO_ENCODING_BITRATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x36,
                0x0D,
                0x99,
                0x6C,
                0x8E,
                0xBB,
                0x7A,
                0x47,
                0x85,
                0x98,
                0x0D,
                0x5D,
                0x96,
                0xFC,
                0xD8,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_PD_MIME_TYPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x37,
                0x0D,
                0x99,
                0x6C,
                0x8E,
                0xBB,
                0x7A,
                0x47,
                0x85,
                0x98,
                0x0D,
                0x5D,
                0x96,
                0xFC,
                0xD8,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_PD_LAST_MODIFIED_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x38,
                0x0D,
                0x99,
                0x6C,
                0x8E,
                0xBB,
                0x7A,
                0x47,
                0x85,
                0x98,
                0x0D,
                0x5D,
                0x96,
                0xFC,
                0xD8,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_PD_PLAYBACK_ELEMENT_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x39,
                0x0D,
                0x99,
                0x6C,
                0x8E,
                0xBB,
                0x7A,
                0x47,
                0x85,
                0x98,
                0x0D,
                0x5D,
                0x96,
                0xFC,
                0xD8,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_PD_PREFERRED_LANGUAGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3A,
                0x0D,
                0x99,
                0x6C,
                0x8E,
                0xBB,
                0x7A,
                0x47,
                0x85,
                0x98,
                0x0D,
                0x5D,
                0x96,
                0xFC,
                0xD8,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_PD_PLAYBACK_BOUNDARY_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0x0D,
                0x99,
                0x6C,
                0x8E,
                0xBB,
                0x7A,
                0x47,
                0x85,
                0x98,
                0x0D,
                0x5D,
                0x96,
                0xFC,
                0xD8,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_PD_AUDIO_ISVARIABLEBITRATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0x6E,
                0x02,
                0x33,
                0x87,
                0xE3,
                0x82,
                0x45,
                0xAE,
                0x0A,
                0x34,
                0xA2,
                0xAD,
                0x3B,
                0xAA,
                0x18
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_PD_ADAPTIVE_STREAMING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x97,
                0x5D,
                0x0D,
                0xEA,
                0xF9,
                0x29,
                0x8B,
                0x48,
                0xAE,
                0x6B,
                0x7D,
                0x6B,
                0x41,
                0x36,
                0x11,
                0x2B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SD_LANGUAGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0x21,
                0xAF,
                0x00,
                0xC2,
                0xBD,
                0x3C,
                0x42,
                0xAB,
                0xCA,
                0xF5,
                0x03,
                0x59,
                0x3B,
                0xC1,
                0x21
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SD_PROTECTED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0x21,
                0xAF,
                0x00,
                0xC2,
                0xBD,
                0x3C,
                0x42,
                0xAB,
                0xCA,
                0xF5,
                0x03,
                0x59,
                0x3B,
                0xC1,
                0x21
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SD_STREAM_NAME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9D,
                0x09,
                0x1B,
                0x4F,
                0x14,
                0xD3,
                0xE5,
                0x41,
                0xA7,
                0x81,
                0x7F,
                0xEF,
                0xAA,
                0x4C,
                0x50,
                0x1F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SD_MUTUALLY_EXCLUSIVE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9C,
                0xF7,
                0x3E,
                0x02,
                0x8D,
                0x38,
                0x7F,
                0x48,
                0xAC,
                0x17,
                0x69,
                0x6C,
                0xD6,
                0xE3,
                0xC6,
                0xF5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_MIXER_CLSID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0x13,
                0x49,
                0xBA,
                0x50,
                0xBE,
                0x1E,
                0x45,
                0x95,
                0xAB,
                0x6D,
                0x4A,
                0xCC,
                0xC7,
                0xDA,
                0xD8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_MIXER_ACTIVATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x61,
                0x13,
                0x49,
                0xBA,
                0x50,
                0xBE,
                0x1E,
                0x45,
                0x95,
                0xAB,
                0x6D,
                0x4A,
                0xCC,
                0xC7,
                0xDA,
                0xD8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_MIXER_FLAGS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0x13,
                0x49,
                0xBA,
                0x50,
                0xBE,
                0x1E,
                0x45,
                0x95,
                0xAB,
                0x6D,
                0x4A,
                0xCC,
                0xC7,
                0xDA,
                0xD8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_CLSID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x64,
                0x13,
                0x49,
                0xBA,
                0x50,
                0xBE,
                0x1E,
                0x45,
                0x95,
                0xAB,
                0x6D,
                0x4A,
                0xCC,
                0xC7,
                0xDA,
                0xD8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_ACTIVATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x65,
                0x13,
                0x49,
                0xBA,
                0x50,
                0xBE,
                0x1E,
                0x45,
                0x95,
                0xAB,
                0x6D,
                0x4A,
                0xCC,
                0xC7,
                0xDA,
                0xD8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_FLAGS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x66,
                0x13,
                0x49,
                0xBA,
                0x50,
                0xBE,
                0x1E,
                0x45,
                0x95,
                0xAB,
                0x6D,
                0x4A,
                0xCC,
                0xC7,
                0xDA,
                0xD8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_ACTIVATE_MFT_LOCKED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3C,
                0x09,
                0xF6,
                0xC1,
                0x65,
                0x7F,
                0xBD,
                0x4F,
                0x9E,
                0x39,
                0x5F,
                0xAE,
                0xC3,
                0xC4,
                0xFB,
                0xD7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_ACTIVATE_VIDEO_WINDOW
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDD,
                0xBB,
                0x2D,
                0x9A,
                0x7E,
                0xF5,
                0x62,
                0x41,
                0x82,
                0xB9,
                0x68,
                0x31,
                0x37,
                0x76,
                0x82,
                0xD3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0xB5,
                0xE4,
                0xED,
                0x05,
                0xF8,
                0x6C,
                0x4D,
                0x99,
                0xB3,
                0xDB,
                0x01,
                0xBF,
                0x95,
                0xDF,
                0xAB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_SESSION_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE3,
                0xB5,
                0xE4,
                0xED,
                0x05,
                0xF8,
                0x6C,
                0x4D,
                0x99,
                0xB3,
                0xDB,
                0x01,
                0xBF,
                0x95,
                0xDF,
                0xAB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_ENDPOINT_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC3,
                0xAE,
                0x0A,
                0xB1,
                0x71,
                0xEF,
                0xC3,
                0x4C,
                0xB8,
                0x73,
                0x05,
                0xA9,
                0xA0,
                0x8B,
                0x9F,
                0x8E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_ENDPOINT_ROLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0x44,
                0xA6,
                0x6B,
                0xC5,
                0x27,
                0x02,
                0x4D,
                0x98,
                0x87,
                0xC2,
                0x86,
                0x19,
                0xFD,
                0xB9,
                0x1B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_STREAM_CATEGORY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x71,
                0x04,
                0x77,
                0xA9,
                0xEC,
                0x92,
                0xF4,
                0x4D,
                0x94,
                0xFE,
                0x81,
                0xC3,
                0x6F,
                0x0C,
                0x3A,
                0x7A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_METADATA_PROVIDER_SERVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0x40,
                0x21,
                0xDB,
                0xA4,
                0x58,
                0x2E,
                0x4D,
                0xB8,
                0x4F,
                0x6F,
                0x75,
                0x5B,
                0x2F,
                0x7A,
                0x0D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_PROPERTY_HANDLER_SERVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0xCE,
                0xFA,
                0xA3,
                0xB8,
                0x32,
                0xDD,
                0x41,
                0x90,
                0xE7,
                0x5F,
                0xEF,
                0x7C,
                0x89,
                0x91,
                0xB5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_RATE_CONTROL_SERVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x97,
                0xA2,
                0x6F,
                0x86,
                0x02,
                0xB8,
                0xF8,
                0x4B,
                0x9D,
                0xC9,
                0x5E,
                0x3B,
                0x6A,
                0x9F,
                0x53,
                0xC9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TIMECODE_SERVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA7,
                0x02,
                0xD5,
                0xA0,
                0xB3,
                0x0E,
                0x85,
                0x48,
                0xB1,
                0xB9,
                0x9F,
                0xEB,
                0x0D,
                0x08,
                0x34,
                0x54
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SAMPLEGRABBERSINK_SAMPLE_TIME_OFFSET
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x76,
                0xD7,
                0xE3,
                0x62,
                0x00,
                0x81,
                0x03,
                0x4E,
                0xA6,
                0xE8,
                0xBD,
                0x38,
                0x57,
                0xAC,
                0x9C,
                0x47
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SAMPLEGRABBERSINK_IGNORE_CLOCK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC0,
                0xA2,
                0xFD,
                0x0E,
                0x69,
                0x2B,
                0x2E,
                0x4E,
                0xAB,
                0x8D,
                0x46,
                0xDC,
                0xBF,
                0xF7,
                0xD2,
                0x5D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_QUALITY_SERVICES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0xBE,
                0xE2,
                0xB7,
                0x96,
                0x2F,
                0x40,
                0x46,
                0xB5,
                0x2C,
                0x28,
                0x23,
                0x65,
                0xBD,
                0xF1,
                0x6C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_WORKQUEUE_SERVICES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x89,
                0xD4,
                0x37,
                0x8E,
                0xE0,
                0x41,
                0x3A,
                0x41,
                0x90,
                0x68,
                0x28,
                0x7C,
                0x88,
                0x6D,
                0x8D,
                0xDA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_QUALITY_NOTIFY_PROCESSING_LATENCY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF8,
                0x4A,
                0xB4,
                0xF6,
                0x4D,
                0x60,
                0xFE,
                0x46,
                0xA9,
                0x5D,
                0x45,
                0x47,
                0x9B,
                0x10,
                0xC9,
                0xBC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_QUALITY_NOTIFY_SAMPLE_LAG
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x06,
                0x52,
                0xD1,
                0x30,
                0x2A,
                0xED,
                0x60,
                0x47,
                0xBE,
                0x17,
                0xEB,
                0x4A,
                0x9F,
                0x12,
                0x29,
                0x5C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TIME_FORMAT_SEGMENT_OFFSET
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x77,
                0xBE,
                0xB8,
                0xC8,
                0x9C,
                0x86,
                0x1D,
                0x43,
                0x81,
                0x2E,
                0x16,
                0x96,
                0x93,
                0xF6,
                0x5A,
                0x39
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SOURCE_PRESENTATION_PROVIDER_SERVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDC,
                0xAA,
                0x02,
                0xE0,
                0xAF,
                0xF4,
                0xE5,
                0x4E,
                0x98,
                0x47,
                0x05,
                0x3E,
                0xDF,
                0x84,
                0x04,
                0x26
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TOPONODE_ATTRIBUTE_EDITOR_SERVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1A,
                0x6E,
                0x65,
                0x65,
                0x7F,
                0x07,
                0x72,
                0x44,
                0x83,
                0xEF,
                0x31,
                0x6F,
                0x11,
                0xD5,
                0x08,
                0x7A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_BYTESTREAMHANDLER_ACCEPTS_SHARE_WRITE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0xF7,
                0xE1,
                0xA6,
                0x01,
                0x30,
                0x15,
                0x49,
                0x81,
                0x50,
                0x15,
                0x58,
                0xA2,
                0x18,
                0x0E,
                0xC8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_BYTESTREAM_SERVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0x5E,
                0x02,
                0xAB,
                0xD9,
                0x16,
                0x80,
                0x41,
                0xA1,
                0x27,
                0xBA,
                0x6C,
                0x70,
                0x15,
                0x61,
                0x61
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_PROTECTION_MANAGER_PROPERTIES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA9,
                0x81,
                0xBD,
                0x38,
                0xEA,
                0xAC,
                0x73,
                0x4C,
                0x89,
                0xB2,
                0x55,
                0x32,
                0xC0,
                0xAE,
                0xCA,
                0x79
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_POLICY_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0xC2,
                0x60,
                0xB1,
                0x59,
                0xC0,
                0xF1,
                0x48,
                0xA9,
                0x01,
                0x9E,
                0xE2,
                0x98,
                0xA9,
                0xA8,
                0xC3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SampleProtectionSalt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0xDE,
                0x03,
                0x54,
                0xEE,
                0xB9,
                0x8F,
                0x43,
                0xAA,
                0x83,
                0x38,
                0x04,
                0x99,
                0x7E,
                0x56,
                0x9D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_REMOTE_PROXY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0xC9,
                0x00,
                0x2F,
                0xCF,
                0xD2,
                0x78,
                0x42,
                0x8B,
                0x6A,
                0xD0,
                0x77,
                0xFA,
                0xC3,
                0xA2,
                0x5F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SAMI_SERVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE7,
                0x9A,
                0xA8,
                0x49,
                0xD9,
                0xB4,
                0xF2,
                0x4E,
                0xAA,
                0x5C,
                0xF6,
                0x5A,
                0x3E,
                0x05,
                0xAE,
                0x4E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_PD_SAMI_STYLELIST
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7F,
                0x3C,
                0xB7,
                0xE0,
                0x6D,
                0x48,
                0x4E,
                0x48,
                0x98,
                0x72,
                0x4D,
                0xE5,
                0x19,
                0x2A,
                0x7B,
                0xF8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SD_SAMI_LANGUAGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0xB9,
                0xFC,
                0x36,
                0xD0,
                0x6C,
                0xCB,
                0x44,
                0xAC,
                0xB9,
                0xA8,
                0xF5,
                0x60,
                0x0D,
                0xD0,
                0xBB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TRANSCODE_CONTAINERTYPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3F,
                0xF2,
                0x0F,
                0x15,
                0xBC,
                0x4A,
                0x8B,
                0x47,
                0xAC,
                0x4F,
                0xE1,
                0x91,
                0x6F,
                0xBA,
                0x1C,
                0xCA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TRANSCODE_SKIP_METADATA_TRANSFER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEF,
                0x69,
                0x44,
                0x4E,
                0x71,
                0xB5,
                0x59,
                0x49,
                0x8F,
                0x83,
                0x3D,
                0xCF,
                0xBA,
                0x33,
                0xA3,
                0x93
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TRANSCODE_TOPOLOGYMODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0xF6,
                0x3D,
                0x3E,
                0x4A,
                0x39,
                0xB2,
                0x40,
                0x9D,
                0xEA,
                0x3B,
                0xAB,
                0x65,
                0x0B,
                0xEB,
                0xF2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TRANSCODE_ADJUST_PROFILE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1B,
                0xC2,
                0x37,
                0x9C,
                0x0F,
                0x06,
                0x7C,
                0x48,
                0xA6,
                0x90,
                0x80,
                0xD7,
                0xF5,
                0x0D,
                0x1C,
                0x72
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TRANSCODE_ENCODINGPROFILE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0x78,
                0x47,
                0x69,
                0x08,
                0xF5,
                0xA9,
                0x4E,
                0xB1,
                0xE9,
                0xA1,
                0xFE,
                0x3A,
                0x49,
                0xFB,
                0xC9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TRANSCODE_QUALITYVSSPEED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF8,
                0x2D,
                0x33,
                0x98,
                0xCD,
                0x03,
                0x6B,
                0x47,
                0x89,
                0xFA,
                0x3F,
                0x9E,
                0x44,
                0x2D,
                0xEC,
                0x9F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_TRANSCODE_DONOT_INSERT_ENCODER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0xA7,
                0x5A,
                0xF4,
                0x24,
                0xAB,
                0x12,
                0x40,
                0xA1,
                0x1B,
                0xDC,
                0x82,
                0x20,
                0x20,
                0x14,
                0x10
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_VIDEO_PROCESSOR_ALGORITHM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1F,
                0x1E,
                0x0A,
                0x4A,
                0x2C,
                0x27,
                0xB6,
                0x4F,
                0x9E,
                0xB1,
                0xDB,
                0x33,
                0x0C,
                0xBC,
                0x97,
                0xCA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_XVP_DISABLE_FRC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0xFA,
                0x0A,
                0x2C,
                0x97,
                0x7A,
                0x5A,
                0x4D,
                0x9E,
                0xE8,
                0x16,
                0xD4,
                0xFC,
                0x51,
                0x8D,
                0x8C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_XVP_CALLER_ALLOCATES_OUTPUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0xCA,
                0xA2,
                0x04,
                0xAB,
                0x0C,
                0xB1,
                0x40,
                0xA1,
                0xB9,
                0x75,
                0xBC,
                0x36,
                0x58,
                0xF0,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_LOCAL_MFT_REGISTRATION_SERVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9C,
                0xCF,
                0xF5,
                0xDD,
                0x06,
                0x45,
                0xAA,
                0x45,
                0xAB,
                0xF0,
                0x6D,
                0x5D,
                0x94,
                0xDD,
                0x1B,
                0x4A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_WRAPPED_BUFFER_SERVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x72,
                0x40,
                0x54,
                0xAB,
                0x69,
                0xC2,
                0xBC,
                0x4E,
                0xA5,
                0x52,
                0x1C,
                0x3B,
                0x32,
                0xBE,
                0xD5,
                0xCA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_WRAPPED_SAMPLE_SERVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF2,
                0x2B,
                0xF5,
                0x31,
                0x3E,
                0xD0,
                0x48,
                0x40,
                0x80,
                0xD0,
                0x9C,
                0x10,
                0x46,
                0xD8,
                0x7C,
                0x61
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_WRAPPED_OBJECT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4C,
                0x2C,
                0x18,
                0x2B,
                0xAC,
                0xD6,
                0xF4,
                0x49,
                0x89,
                0x15,
                0xF7,
                0x18,
                0x87,
                0xDB,
                0x70,
                0xCD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFE,
                0xC5,
                0x0A,
                0xC6,
                0x2A,
                0x25,
                0x8F,
                0x47,
                0xA0,
                0xEF,
                0xBC,
                0x8F,
                0xA5,
                0xF7,
                0xCA,
                0xD3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_HW_SOURCE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBA,
                0x46,
                0x70,
                0xDE,
                0xD6,
                0x54,
                0x87,
                0x44,
                0xA2,
                0xA4,
                0xEC,
                0x7C,
                0x0D,
                0x1B,
                0xD1,
                0x63
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_FRIENDLY_NAME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x59,
                0xE5,
                0xD0,
                0x60,
                0xF8,
                0x52,
                0xA2,
                0x4F,
                0xBB,
                0xCE,
                0xAC,
                0xDB,
                0x34,
                0xA8,
                0xEC,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_MEDIA_TYPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0x19,
                0xA8,
                0x56,
                0x78,
                0x0C,
                0xE4,
                0x4D,
                0xA0,
                0xA7,
                0x3D,
                0xDA,
                0xBA,
                0x0F,
                0x24,
                0xD4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_CATEGORY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x69,
                0xAE,
                0xF0,
                0x77,
                0xBD,
                0xC3,
                0x09,
                0x45,
                0x94,
                0x1D,
                0x46,
                0x7E,
                0x4D,
                0x24,
                0x89,
                0x9E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_SYMBOLIC_LINK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD8,
                0xAA,
                0xF0,
                0x58,
                0xBF,
                0x22,
                0x8A,
                0x4F,
                0xBB,
                0x3D,
                0xD2,
                0xC4,
                0x97,
                0x8C,
                0x6E,
                0x2F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_SYMBOLIC_LINK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5E,
                0x4B,
                0xD2,
                0x98,
                0x30,
                0x59,
                0x14,
                0x46,
                0xB5,
                0xA1,
                0xF6,
                0x00,
                0xF9,
                0x35,
                0x5A,
                0x78
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_MAX_BUFFERS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0xB7,
                0xD9,
                0x7D,
                0x2D,
                0x4F,
                0xD5,
                0x41,
                0x8F,
                0x95,
                0x0C,
                0xC9,
                0xA9,
                0x12,
                0xBA,
                0x26
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_ENDPOINT_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x58,
                0x92,
                0xDA,
                0x30,
                0xB9,
                0xFE,
                0xA7,
                0x47,
                0xA4,
                0x53,
                0x76,
                0x3A,
                0x7A,
                0x8E,
                0x1C,
                0x5F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_ROLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8E,
                0x11,
                0x9D,
                0xBC,
                0x67,
                0x8C,
                0x18,
                0x4A,
                0x85,
                0xD4,
                0x12,
                0xD3,
                0x00,
                0x40,
                0x05,
                0x52
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_PROVIDER_DEVICE_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x42,
                0x9D,
                0x68,
                0x36,
                0x6C,
                0xA0,
                0xAE,
                0x40,
                0x84,
                0xCF,
                0xF5,
                0xA0,
                0x34,
                0x06,
                0x7C,
                0xC4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_XADDRESS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0xBE,
                0xA0,
                0xBC,
                0x27,
                0xC3,
                0xC7,
                0x44,
                0x9B,
                0x7D,
                0x7F,
                0xA8,
                0xD9,
                0xB5,
                0xBC,
                0xDA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_STREAM_URL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD2,
                0x40,
                0x7B,
                0x9D,
                0x17,
                0x36,
                0x43,
                0x40,
                0x93,
                0xE3,
                0x8D,
                0x6D,
                0xA9,
                0xBB,
                0x34,
                0x92
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_USERNAME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDD,
                0x1A,
                0xD0,
                0x05,
                0x9F,
                0x94,
                0xEB,
                0x46,
                0xBC,
                0x8E,
                0x8B,
                0x0D,
                0x2B,
                0x32,
                0xD7,
                0x9D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_PASSWORD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0x7E,
                0xFD,
                0xA0,
                0xD9,
                0x42,
                0xDF,
                0x49,
                0x84,
                0xC0,
                0xE8,
                0x2C,
                0x5E,
                0xAB,
                0x88,
                0x74
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1C,
                0x9A,
                0xDD,
                0x14,
                0xFF,
                0x7C,
                0xBE,
                0x41,
                0xB1,
                0xB9,
                0xBA,
                0x1A,
                0xC6,
                0xEC,
                0xB5,
                0x71
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7A,
                0x58,
                0xC3,
                0x8A,
                0xE7,
                0x4A,
                0xD8,
                0x42,
                0x99,
                0xE0,
                0x0A,
                0x60,
                0x13,
                0xEE,
                0xF9,
                0x0F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICESTREAM_IMAGE_STREAM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x65,
                0xB8,
                0xFF,
                0xA7,
                0xB2,
                0xE7,
                0xB0,
                0x43,
                0x9F,
                0x6F,
                0x9A,
                0xF2,
                0xA0,
                0xE5,
                0x0F,
                0xC0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICESTREAM_INDEPENDENT_IMAGE_STREAM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0xEC,
                0xEE,
                0x03,
                0x05,
                0xD6,
                0x76,
                0x45,
                0x8B,
                0x29,
                0x65,
                0x80,
                0xB4,
                0x90,
                0xD7,
                0xD3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICESTREAM_STREAM_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0x51,
                0xBD,
                0x11,
                0x24,
                0xD1,
                0x6B,
                0x44,
                0x88,
                0xE6,
                0x17,
                0x06,
                0x02,
                0x57,
                0xFF,
                0xF9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICESTREAM_STREAM_CATEGORY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB8,
                0xE7,
                0x39,
                0x29,
                0x2E,
                0xA6,
                0x79,
                0x45,
                0xB6,
                0x74,
                0xD4,
                0x07,
                0x3D,
                0xFA,
                0xBB,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICESTREAM_FRAMESERVER_SHARED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE9,
                0x78,
                0xB3,
                0x1C,
                0x79,
                0xB2,
                0xD4,
                0x41,
                0xAF,
                0x97,
                0x34,
                0xA2,
                0x43,
                0xE6,
                0x83,
                0x20
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICESTREAM_TRANSFORM_STREAM_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB7,
                0x37,
                0x39,
                0xE6,
                0xAF,
                0xDA,
                0x49,
                0x4D,
                0x81,
                0x5F,
                0xD8,
                0x26,
                0xF8,
                0xAD,
                0x31,
                0xE7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICESTREAM_EXTENSION_PLUGIN_CLSID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x58,
                0x65,
                0x8E,
                0x04,
                0xC4,
                0x60,
                0x73,
                0x41,
                0xBD,
                0x5B,
                0x6A,
                0x3C,
                0xA2,
                0x89,
                0x6A,
                0xEE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICEMFT_EXTENSION_PLUGIN_CLSID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAE,
                0xDB,
                0x44,
                0x08,
                0xFA,
                0x34,
                0xA0,
                0x48,
                0xA7,
                0x83,
                0x8E,
                0x69,
                0x6F,
                0xB1,
                0xC9,
                0xA8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICESTREAM_EXTENSION_PLUGIN_CONNECTION_POINT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5C,
                0x37,
                0xF9,
                0x37,
                0x64,
                0xE6,
                0xA4,
                0x4E,
                0xAA,
                0xE4,
                0xCB,
                0x6D,
                0x1D,
                0xAC,
                0xA1,
                0xF4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICESTREAM_TAKEPHOTO_TRIGGER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x34,
                0x0E,
                0x18,
                0x1D,
                0x8C,
                0x53,
                0xBB,
                0x4F,
                0xA7,
                0x5A,
                0x85,
                0x9A,
                0xF7,
                0xD2,
                0x61,
                0xA6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICESTREAM_MAX_FRAME_BUFFERS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBE,
                0xCE,
                0x84,
                0x16,
                0x75,
                0x31,
                0x85,
                0x49,
                0x88,
                0x2C,
                0x0E,
                0xFD,
                0x3E,
                0x8A,
                0xC1,
                0x1E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICEMFT_CONNECTED_FILTER_KSCONTROL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA6,
                0x4F,
                0x2C,
                0x6A,
                0x79,
                0xD1,
                0xCD,
                0x41,
                0x95,
                0x23,
                0x82,
                0x23,
                0x71,
                0xEA,
                0x40,
                0xE5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICEMFT_CONNECTED_PIN_KSCONTROL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF7,
                0x10,
                0x33,
                0xE6,
                0x44,
                0xB2,
                0xF8,
                0x4E,
                0x9A,
                0x7D,
                0x24,
                0xC7,
                0x4E,
                0x32,
                0xEB,
                0xD0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICE_THERMAL_STATE_CHANGED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAF,
                0xD0,
                0xCC,
                0x70,
                0x9F,
                0xFC,
                0xEB,
                0x4D,
                0xA8,
                0x75,
                0x9F,
                0xEC,
                0xD1,
                0x6C,
                0x5B,
                0xD4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIASOURCE_SERVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF7,
                0x92,
                0x99,
                0xF0,
                0xBA,
                0x9F,
                0x4A,
                0x4C,
                0xA3,
                0x7F,
                0x8C,
                0x47,
                0xB4,
                0xE1,
                0xDF,
                0xE7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_ACCESS_CONTROLLED_MEDIASOURCE_SERVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0x50,
                0x4A,
                0x01,
                0x05,
                0x2F,
                0x6A,
                0x4C,
                0x9F,
                0x9C,
                0x7D,
                0x0D,
                0xC4,
                0xED,
                0xA5,
                0xF4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CONTENT_DECRYPTOR_SERVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0x29,
                0xA7,
                0x68,
                0x7B,
                0xFC,
                0xEE,
                0x44,
                0x85,
                0xF4,
                0x7C,
                0x51,
                0xBD,
                0x55,
                0xA6,
                0x59
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CONTENT_PROTECTION_DEVICE_SERVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6F,
                0x43,
                0x58,
                0xFF,
                0xA0,
                0x76,
                0xFE,
                0x41,
                0xB5,
                0x66,
                0x10,
                0xCC,
                0x53,
                0x96,
                0x2E,
                0xDD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SD_AUDIO_ENCODER_DELAY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2C,
                0x42,
                0x85,
                0x8E,
                0xDE,
                0x73,
                0x3F,
                0x40,
                0x9A,
                0x35,
                0x55,
                0x0A,
                0xD6,
                0xE8,
                0xB9,
                0x51
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SD_AUDIO_ENCODER_PADDING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2C,
                0x7F,
                0x9C,
                0x52,
                0x4B,
                0xAC,
                0x3F,
                0x4E,
                0xBF,
                0xC3,
                0x09,
                0x02,
                0x19,
                0x49,
                0x82,
                0xCB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SD_MEDIASOURCE_STATUS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8B,
                0x67,
                0x13,
                0x19,
                0x0F,
                0xFC,
                0xDA,
                0x44,
                0x8F,
                0x43,
                0x1B,
                0xA3,
                0xB5,
                0x26,
                0xF4,
                0xAE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SD_VIDEO_SPHERICAL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0xA4,
                0x1D,
                0xA5,
                0xDC,
                0x3F,
                0x8C,
                0x47,
                0xBC,
                0xB5,
                0x30,
                0xBE,
                0x76,
                0x59,
                0x5F,
                0x55
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SD_VIDEO_SPHERICAL_FORMAT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x07,
                0xC4,
                0x8F,
                0x4A,
                0xA1,
                0x6E,
                0xC8,
                0x46,
                0xB5,
                0x67,
                0x69,
                0x71,
                0xD4,
                0xA1,
                0x39,
                0xC3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_SD_VIDEO_SPHERICAL_INITIAL_VIEWDIRECTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0x5A,
                0xD2,
                0x11,
                0x62,
                0xBB,
                0x7F,
                0x46,
                0x9D,
                0xB1,
                0xC1,
                0x71,
                0x65,
                0x71,
                0x6C,
                0x49
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIASOURCE_EXPOSE_ALL_STREAMS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB8,
                0x50,
                0xF2,
                0xE7,
                0xD9,
                0x8F,
                0x09,
                0x4A,
                0xB6,
                0xC1,
                0x6A,
                0x31,
                0x5C,
                0x7C,
                0x72,
                0x0E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_ST_MEDIASOURCE_COLLECTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x72,
                0xE9,
                0x6D,
                0x61,
                0xAD,
                0x83,
                0x50,
                0x49,
                0x81,
                0x70,
                0x63,
                0x0D,
                0x19,
                0xCB,
                0xE3,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICESTREAM_FILTER_KSCONTROL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0x3C,
                0x78,
                0x46,
                0xF5,
                0x3D,
                0x23,
                0x49,
                0xA9,
                0xEF,
                0x36,
                0xB7,
                0x22,
                0x3E,
                0xDD,
                0xE0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICESTREAM_PIN_KSCONTROL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA7,
                0xF9,
                0x3E,
                0xEF,
                0xF2,
                0x87,
                0xCA,
                0x48,
                0xBE,
                0x02,
                0x67,
                0x48,
                0x78,
                0x91,
                0x8E,
                0x98
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICESTREAM_SOURCE_ATTRIBUTES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0xB6,
                0x8C,
                0x2F,
                0x1B,
                0x36,
                0x4F,
                0x43,
                0x85,
                0xEA,
                0x99,
                0xA0,
                0x3E,
                0x1C,
                0xE4,
                0xE0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICESTREAM_FRAMESERVER_HIDDEN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7B,
                0x56,
                0x02,
                0xF4,
                0x91,
                0x4D,
                0x79,
                0x41,
                0x96,
                0xD1,
                0x74,
                0xC8,
                0x48,
                0x0C,
                0x20,
                0x34
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_STF_VERSION_INFO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x39,
                0xBD,
                0x70,
                0x67,
                0x82,
                0xEF,
                0xEE,
                0x44,
                0xA4,
                0x9B,
                0x93,
                0x4B,
                0xEB,
                0x24,
                0xAE,
                0xF7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_STF_VERSION_DATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD5,
                0x65,
                0xA1,
                0x31,
                0x67,
                0xDF,
                0x95,
                0x40,
                0x8E,
                0x44,
                0x88,
                0x68,
                0xFC,
                0x20,
                0xDB,
                0xFD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICESTREAM_REQUIRED_CAPABILITIES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0x95,
                0x8B,
                0x6D,
                0xF6,
                0x7C,
                0xF4,
                0x43,
                0xAF,
                0x56,
                0x9C,
                0x0E,
                0x1E,
                0x4F,
                0xCB,
                0xE1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICESTREAM_REQUIRED_SDDL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5D,
                0xE8,
                0x1A,
                0x33,
                0xD3,
                0xC0,
                0xBA,
                0x49,
                0x83,
                0xBA,
                0x82,
                0xA1,
                0x2D,
                0x63,
                0xCD,
                0xD6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICEMFT_SENSORPROFILE_COLLECTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0xDC,
                0xEB,
                0x36,
                0x2C,
                0xB1,
                0x1B,
                0x44,
                0x89,
                0xF4,
                0x08,
                0xB2,
                0xF4,
                0x1A,
                0x9C,
                0xFC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DEVICESTREAM_SENSORSTREAM_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0x9F,
                0x5B,
                0xE3,
                0x59,
                0x06,
                0xAD,
                0x4C,
                0xBB,
                0x51,
                0x33,
                0x16,
                0x0B,
                0xE7,
                0xE4,
                0x13
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_CROSSPROCESS 0x00000001")]
    public const int MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_CROSSPROCESS = 0x00000001;
    [NativeTypeName("#define MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_NOPERSIST 0x00000002")]
    public const int MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_NOPERSIST = 0x00000002;
    [NativeTypeName("#define MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_DONT_ALLOW_FORMAT_CHANGES 0x00000004")]
    public const int MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_DONT_ALLOW_FORMAT_CHANGES = 0x00000004;
    [NativeTypeName("#define MF_USER_MODE_COMPONENT_LOAD 0x00000001")]
    public const int MF_USER_MODE_COMPONENT_LOAD = 0x00000001;
    [NativeTypeName("#define MF_KERNEL_MODE_COMPONENT_LOAD 0x00000002")]
    public const int MF_KERNEL_MODE_COMPONENT_LOAD = 0x00000002;
    [NativeTypeName("#define MF_GRL_LOAD_FAILED 0x00000010")]
    public const int MF_GRL_LOAD_FAILED = 0x00000010;
    [NativeTypeName("#define MF_INVALID_GRL_SIGNATURE 0x00000020")]
    public const int MF_INVALID_GRL_SIGNATURE = 0x00000020;
    [NativeTypeName("#define MF_GRL_ABSENT 0x00001000")]
    public const int MF_GRL_ABSENT = 0x00001000;
    [NativeTypeName("#define MF_COMPONENT_REVOKED 0x00002000")]
    public const int MF_COMPONENT_REVOKED = 0x00002000;
    [NativeTypeName("#define MF_COMPONENT_INVALID_EKU 0x00004000")]
    public const int MF_COMPONENT_INVALID_EKU = 0x00004000;
    [NativeTypeName("#define MF_COMPONENT_CERT_REVOKED 0x00008000")]
    public const int MF_COMPONENT_CERT_REVOKED = 0x00008000;
    [NativeTypeName("#define MF_COMPONENT_INVALID_ROOT 0x00010000")]
    public const int MF_COMPONENT_INVALID_ROOT = 0x00010000;
    [NativeTypeName("#define MF_COMPONENT_HS_CERT_REVOKED 0x00020000")]
    public const int MF_COMPONENT_HS_CERT_REVOKED = 0x00020000;
    [NativeTypeName("#define MF_COMPONENT_LS_CERT_REVOKED 0x00040000")]
    public const int MF_COMPONENT_LS_CERT_REVOKED = 0x00040000;
    [NativeTypeName("#define MF_BOOT_DRIVER_VERIFICATION_FAILED 0x00100000")]
    public const int MF_BOOT_DRIVER_VERIFICATION_FAILED = 0x00100000;
    [NativeTypeName("#define MF_TEST_SIGNED_COMPONENT_LOADING 0x01000000")]
    public const int MF_TEST_SIGNED_COMPONENT_LOADING = 0x01000000;
    [NativeTypeName("#define MF_MINCRYPT_FAILURE 0x10000000")]
    public const int MF_MINCRYPT_FAILURE = 0x10000000;
    [NativeTypeName("#define MF_UNKNOWN_DURATION 0")]
    public const int MF_UNKNOWN_DURATION = 0;
}