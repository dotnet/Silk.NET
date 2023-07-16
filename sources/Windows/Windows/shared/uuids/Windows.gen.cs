// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class Windows
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CAPTION_FORMAT_ATSC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0xCB,
                0xD9,
                0x3E,
                0x10,
                0xFD,
                0xDE,
                0x4A,
                0xBC,
                0xCC,
                0xFB,
                0x91,
                0x05,
                0xD2,
                0xF3,
                0xEF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CAPTION_FORMAT_DVB
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB4,
                0x0D,
                0x23,
                0x12,
                0x2A,
                0xFF,
                0x7E,
                0x44,
                0xBB,
                0x88,
                0x68,
                0x41,
                0xC4,
                0x16,
                0xD0,
                0x68
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CAPTION_FORMAT_DIRECTV
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE7,
                0x1C,
                0xCA,
                0xE9,
                0x5E,
                0x91,
                0xBE,
                0x47,
                0x9B,
                0xB9,
                0xBF,
                0x1D,
                0x8A,
                0x13,
                0xA5,
                0xEC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CAPTION_FORMAT_ECHOSTAR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0xA2,
                0xB1,
                0xEB,
                0x58,
                0x11,
                0x99,
                0x4B,
                0xAE,
                0x80,
                0x92,
                0xAC,
                0x77,
                0x69,
                0x52,
                0xC4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid AMPROPSETID_Pin
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0xF1,
                0x00,
                0x9B,
                0x67,
                0x15,
                0xD1,
                0x11,
                0xB3,
                0xF1,
                0x00,
                0xAA,
                0x00,
                0x37,
                0x61,
                0xC5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid LOOK_UPSTREAM_ONLY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0x8B,
                0x79,
                0xAC,
                0xE3,
                0x98,
                0xD1,
                0x11,
                0xB3,
                0xF1,
                0x00,
                0xAA,
                0x00,
                0x37,
                0x61,
                0xC5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid LOOK_DOWNSTREAM_ONLY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE1,
                0x8B,
                0x79,
                0xAC,
                0xE3,
                0x98,
                0xD1,
                0x11,
                0xB3,
                0xF1,
                0x00,
                0xAA,
                0x00,
                0x37,
                0x61,
                0xC5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DSATTRIB_UDCRTag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0x36,
                0x78,
                0xEB,
                0xFF,
                0x14,
                0x19,
                0x49,
                0xBC,
                0xE7,
                0x3A,
                0xF1,
                0x23,
                0x19,
                0xE5,
                0x0C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DSATTRIB_PicSampleSeq
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0xAE,
                0x5B,
                0x2F,
                0x8F,
                0x7B,
                0x60,
                0x4F,
                0x82,
                0xD6,
                0xE4,
                0xEA,
                0x2F,
                0x1F,
                0x4C,
                0x99
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DSATTRIB_OptionalVideoAttributes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0x08,
                0x5F,
                0x5A,
                0xC2,
                0x55,
                0x33,
                0x40,
                0x92,
                0xAB,
                0x55,
                0xDB,
                0x8F,
                0x78,
                0x12,
                0x26
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DSATTRIB_CC_CONTAINER_INFO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFB,
                0x50,
                0xE0,
                0xE7,
                0x5D,
                0xDD,
                0xDD,
                0x40,
                0x99,
                0x15,
                0x35,
                0xDC,
                0xB8,
                0x1B,
                0xDC,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DSATTRIB_TRANSPORT_PROPERTIES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x12,
                0xF6,
                0x22,
                0xB6,
                0xAD,
                0x47,
                0x71,
                0x46,
                0xAD,
                0x6C,
                0x05,
                0xA9,
                0x8E,
                0x65,
                0xDE,
                0x3A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DSATTRIB_PBDATAG_ATTRIBUTE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x79,
                0x66,
                0xB5,
                0xE0,
                0xB9,
                0x12,
                0xCC,
                0x43,
                0xB7,
                0xDF,
                0x57,
                0x8C,
                0xAA,
                0x5A,
                0x7B,
                0x63
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DSATTRIB_CAPTURE_STREAMTIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x14,
                0x56,
                0x1A,
                0x0C,
                0xCD,
                0x30,
                0x40,
                0x4F,
                0xBC,
                0xBF,
                0xD0,
                0x3E,
                0x52,
                0x30,
                0x62,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DSATTRIB_DSHOW_STREAM_DESC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0x67,
                0xB5,
                0x5F,
                0x2A,
                0x0A,
                0x65,
                0x45,
                0x82,
                0x7B,
                0x68,
                0x53,
                0xFD,
                0x75,
                0xE6,
                0x11
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DSATTRIB_SAMPLE_LIVE_STREAM_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0xD1,
                0x2C,
                0x89,
                0xF3,
                0x72,
                0x1D,
                0x41,
                0x8B,
                0x91,
                0xA9,
                0xE9,
                0x12,
                0x3A,
                0xC2,
                0x9A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid UUID_UdriTagTables
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x74,
                0x8D,
                0xB9,
                0xE1,
                0x78,
                0x97,
                0x78,
                0x48,
                0xB6,
                0x64,
                0xEB,
                0x20,
                0x20,
                0x36,
                0x4D,
                0x88
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid UUID_WMDRMTagTables
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0x11,
                0xCD,
                0x5D,
                0x63,
                0x92,
                0xBB,
                0x45,
                0xA4,
                0xD5,
                0xC4,
                0x15,
                0xAB,
                0x8C,
                0x58,
                0x9C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ENCAPIPARAM_BITRATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x43,
                0x4C,
                0xCC,
                0x49,
                0x83,
                0xCA,
                0xD4,
                0x4A,
                0xA9,
                0xAF,
                0xF3,
                0x69,
                0x6A,
                0xF6,
                0x66,
                0xDF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ENCAPIPARAM_PEAK_BITRATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA9,
                0x16,
                0x3F,
                0x70,
                0x48,
                0x3D,
                0xA1,
                0x44,
                0xB0,
                0x77,
                0x01,
                0x8D,
                0xFF,
                0x91,
                0x5D,
                0x19
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ENCAPIPARAM_BITRATE_MODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5C,
                0xB2,
                0x5F,
                0xEE,
                0x13,
                0xC7,
                0xD1,
                0x40,
                0x9D,
                0x58,
                0xC0,
                0xD7,
                0x24,
                0x1E,
                0x25,
                0x0F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ENCAPIPARAM_SAP_MODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0x71,
                0x01,
                0x0C,
                0xFC,
                0xFE,
                0xF7,
                0x4A,
                0x99,
                0x91,
                0xA5,
                0x65,
                0x7C,
                0x19,
                0x1C,
                0xD1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CODECAPI_CHANGELISTS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0x2A,
                0xB1,
                0x62,
                0xB0,
                0xF6,
                0xD9,
                0x47,
                0x94,
                0x56,
                0x96,
                0xF2,
                0x2C,
                0x4E,
                0x0B,
                0x9D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CODECAPI_VIDEO_ENCODER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE1,
                0xE8,
                0x12,
                0x71,
                0x03,
                0x3D,
                0xEF,
                0x47,
                0x8E,
                0x60,
                0x03,
                0xF1,
                0xCF,
                0x53,
                0x73,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CODECAPI_AUDIO_ENCODER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3E,
                0x9A,
                0xD1,
                0xB9,
                0x97,
                0xF8,
                0x9C,
                0x42,
                0xBC,
                0x46,
                0x81,
                0x38,
                0xB7,
                0x27,
                0x2B,
                0x2D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CODECAPI_SETALLDEFAULTS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0x6A,
                0x5E,
                0x6C,
                0xF8,
                0xAC,
                0x55,
                0x4F,
                0xA9,
                0x99,
                0x1A,
                0x62,
                0x81,
                0x09,
                0x05,
                0x1B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CODECAPI_ALLSETTINGS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x92,
                0x7E,
                0x57,
                0x6A,
                0xE1,
                0x83,
                0x13,
                0x41,
                0xAD,
                0xC2,
                0x4F,
                0xCE,
                0xC3,
                0x2F,
                0x83,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CODECAPI_SUPPORTSEVENTS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x97,
                0xAF,
                0x81,
                0x05,
                0x93,
                0x76,
                0xBD,
                0x4D,
                0x9D,
                0xCA,
                0x3F,
                0x9E,
                0xBD,
                0x65,
                0x85,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CODECAPI_CURRENTCHANGELIST
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0x4E,
                0xB1,
                0x1C,
                0x72,
                0x7D,
                0x57,
                0x46,
                0x83,
                0xFD,
                0x47,
                0xA2,
                0xC5,
                0xB9,
                0xD1,
                0x3D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CODECAPI_AVDecMmcssClass
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x28,
                0x48,
                0xAD,
                0xE0,
                0x66,
                0xDF,
                0x93,
                0x48,
                0x9F,
                0x33,
                0x78,
                0x8A,
                0xA4,
                0xEC,
                0x40,
                0x82
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}