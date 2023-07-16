// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class CLSID
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_CreateMediaExtensionObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0xA5,
                0x65,
                0xEF,
                0x88,
                0x07,
                0xB8,
                0x45,
                0x8B,
                0x14,
                0xBC,
                0x0F,
                0x6A,
                0x6B,
                0x51,
                0x37
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_HttpSchemePlugin
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0x44,
                0xCB,
                0x44,
                0xA9,
                0x9D,
                0xDF,
                0x49,
                0xB3,
                0xFD,
                0x02,
                0x37,
                0x77,
                0xB1,
                0x6E,
                0x50
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_UrlmonSchemePlugin
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF9,
                0xB4,
                0xC4,
                0x9E,
                0x29,
                0x30,
                0xAD,
                0x45,
                0x94,
                0x7B,
                0x34,
                0x4D,
                0xE2,
                0xA2,
                0x49,
                0xE2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_NetSchemePlugin
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAB,
                0xEB,
                0xF4,
                0xE9,
                0x7B,
                0xD9,
                0x3E,
                0x46,
                0xA2,
                0xB1,
                0xC5,
                0x4E,
                0xE3,
                0xF9,
                0x41,
                0x4D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_FrameServerNetworkCameraSource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA7,
                0x3A,
                0x21,
                0x7A,
                0x6F,
                0x86,
                0x4A,
                0x41,
                0x8C,
                0x1A,
                0x27,
                0x5C,
                0x72,
                0x83,
                0xA3,
                0x95
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MPEG2ByteStreamPlugin
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x59,
                0x1C,
                0x87,
                0x40,
                0x40,
                0xAB,
                0x1F,
                0x47,
                0x8D,
                0xC3,
                0x1F,
                0x25,
                0x9D,
                0x86,
                0x24,
                0x79
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MSH264DecoderMFT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x72,
                0x7E,
                0xCE,
                0x62,
                0x71,
                0x4C,
                0x20,
                0x4D,
                0xB1,
                0x5D,
                0x45,
                0x28,
                0x31,
                0xA8,
                0x7D,
                0x9D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MSH264EncoderMFT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0x03,
                0xA5,
                0x6C,
                0x1A,
                0x05,
                0xED,
                0x4D,
                0x97,
                0x79,
                0xA4,
                0x33,
                0x05,
                0x16,
                0x5E,
                0x35
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MSDDPlusDecMFT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFE,
                0x0A,
                0x7C,
                0x17,
                0x0B,
                0x90,
                0xD4,
                0x48,
                0x9E,
                0x4C,
                0x57,
                0xAD,
                0xD2,
                0x50,
                0xB3,
                0xD4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MP3DecMediaObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0xA8,
                0xEE,
                0xBB,
                0x63,
                0x0A,
                0x52,
                0x4F,
                0xA7,
                0xAB,
                0xA9,
                0xB3,
                0xA8,
                0x4E,
                0xD3,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MSAACDecMFT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA7,
                0x86,
                0xD1,
                0x32,
                0x8F,
                0x21,
                0x75,
                0x4C,
                0x88,
                0x76,
                0xDD,
                0x77,
                0x27,
                0x3A,
                0x89,
                0x99
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MSH265DecoderMFT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA3,
                0x51,
                0x0A,
                0x42,
                0x05,
                0xD6,
                0x0C,
                0x43,
                0xB4,
                0xFC,
                0x45,
                0x27,
                0x4F,
                0xA6,
                0xC5,
                0x62
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_WMVDecoderMFT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0x53,
                0xD3,
                0x82,
                0xBD,
                0x90,
                0x82,
                0x43,
                0x8B,
                0xC2,
                0x3F,
                0x61,
                0x92,
                0xB7,
                0x6E,
                0x34
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_WMADecMediaObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0x4A,
                0xEB,
                0x2E,
                0x78,
                0x45,
                0x10,
                0x4D,
                0xBC,
                0xA7,
                0xBB,
                0x95,
                0x5F,
                0x56,
                0x32,
                0x0A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MSMPEGAudDecMFT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x39,
                0x7B,
                0x70,
                0x70,
                0xCA,
                0xB2,
                0x15,
                0x40,
                0xAB,
                0xEA,
                0xF8,
                0x44,
                0x7D,
                0x22,
                0xD8,
                0x8B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MSMPEGDecoderMFT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0x9E,
                0x70,
                0x2D,
                0x3F,
                0x12,
                0xB5,
                0x49,
                0x9C,
                0xBC,
                0x9A,
                0xF5,
                0xCD,
                0xE2,
                0x8F,
                0xB9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_AudioResamplerMediaObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9E,
                0xB6,
                0x47,
                0xF4,
                0x84,
                0x18,
                0x7E,
                0x4A,
                0x80,
                0x55,
                0x34,
                0x6F,
                0x74,
                0xD6,
                0xED,
                0xB3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MSVPxDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x48,
                0xF5,
                0xAA,
                0xE3,
                0xA4,
                0xC9,
                0x6E,
                0x4C,
                0x23,
                0x4D,
                0x5A,
                0xDA,
                0x37,
                0x4B,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MSOpusDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0x7C,
                0xE1,
                0x63,
                0x43,
                0x2D,
                0x42,
                0x4C,
                0x8F,
                0xE3,
                0x8D,
                0x8B,
                0x63,
                0xE4,
                0x6A,
                0x6A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_VideoProcessorMFT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x26,
                0x3B,
                0x75,
                0x88,
                0x24,
                0x5B,
                0xBD,
                0x49,
                0xB2,
                0xE7,
                0x0C,
                0x44,
                0x5C,
                0x78,
                0xC9,
                0x82
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_CameraConfigurationManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0xB5,
                0x92,
                0x6C,
                0x54,
                0x58,
                0x17,
                0x4A,
                0x92,
                0xB6,
                0xAC,
                0x89,
                0xC9,
                0x6E,
                0x96,
                0x83
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}