// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3D12
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_MPEG2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0x41,
                0x27,
                0xEE,
                0x28,
                0x5E,
                0x65,
                0x4E,
                0xBE,
                0xEA,
                0x1D,
                0x26,
                0xB5,
                0x08,
                0xAD,
                0xC9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_MPEG1_AND_MPEG2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x5F,
                0x69,
                0x86,
                0x0E,
                0x34,
                0x04,
                0x4F,
                0x9F,
                0xD3,
                0x92,
                0x53,
                0xDD,
                0x32,
                0x74,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_H264
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0xBE,
                0x81,
                0x1B,
                0xC7,
                0xA0,
                0xD3,
                0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_H264_STEREO_PROGRESSIVE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0xE8,
                0x9B,
                0xD7,
                0xF1,
                0x0C,
                0x81,
                0x4C,
                0xB8,
                0x2A,
                0x69,
                0xA4,
                0xE2,
                0x36,
                0xF4,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_H264_STEREO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0xCC,
                0xAA,
                0xF9,
                0xB6,
                0xC2,
                0xFC,
                0x4C,
                0x87,
                0x79,
                0x57,
                0x07,
                0xB1,
                0x76,
                0x05,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_H264_MULTIVIEW
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0x9D,
                0x5B,
                0x70,
                0xCF,
                0x76,
                0xD6,
                0x49,
                0xB7,
                0xE6,
                0xAC,
                0x88,
                0x72,
                0xDB,
                0x01,
                0x3C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_VC1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0xBE,
                0x81,
                0x1B,
                0xC7,
                0xA0,
                0xD3,
                0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_VC1_D2010
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0xBE,
                0x81,
                0x1B,
                0xC7,
                0xA0,
                0xD3,
                0x11,
                0xB9,
                0x84,
                0x00,
                0xC0,
                0x4F,
                0x2E,
                0x73,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_SIMPLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x4D,
                0xD6,
                0xEF,
                0xE8,
                0xC9,
                0xD7,
                0x41,
                0xA5,
                0xE9,
                0xE9,
                0xB0,
                0xE3,
                0x9F,
                0xA3,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_ADVSIMPLE_NOGMC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0x8A,
                0x41,
                0xED,
                0x0D,
                0x01,
                0xDA,
                0x4E,
                0x9A,
                0xE3,
                0x9A,
                0x65,
                0x35,
                0x8D,
                0x8D,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1B,
                0xD5,
                0x11,
                0x5B,
                0x4C,
                0x2F,
                0x52,
                0x44,
                0xBC,
                0xC3,
                0x09,
                0xF2,
                0xA1,
                0x16,
                0x0C,
                0xC0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0xF0,
                0x7A,
                0x10,
                0x1A,
                0xEF,
                0x19,
                0x4D,
                0xAB,
                0xA8,
                0x67,
                0xA1,
                0x63,
                0x07,
                0x3D,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_HEVC_MONOCHROME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0xB9,
                0x85,
                0x06,
                0x8C,
                0x3D,
                0xA0,
                0x43,
                0x8B,
                0x28,
                0xD7,
                0x4C,
                0x2D,
                0x68,
                0x99,
                0xA4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_HEVC_MONOCHROME10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0F,
                0x1D,
                0x2A,
                0x14,
                0xDD,
                0x69,
                0xC9,
                0x4E,
                0x85,
                0x91,
                0xB1,
                0x2F,
                0xFC,
                0xB9,
                0x1A,
                0x29,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0x92,
                0x72,
                0x1A,
                0x2C,
                0x0C,
                0x15,
                0x4F,
                0x96,
                0xFB,
                0xB1,
                0x7D,
                0x14,
                0x73,
                0x60,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10_422
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x4F,
                0xAC,
                0x0B,
                0x32,
                0x15,
                0x29,
                0x44,
                0xA8,
                0x54,
                0xF8,
                0x4D,
                0xE0,
                0x49,
                0x53,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN12_422
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0xAC,
                0xBC,
                0x55,
                0x11,
                0xF3,
                0x93,
                0x40,
                0xA7,
                0xD0,
                0x1C,
                0xBC,
                0x0B,
                0x84,
                0x9B,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN_444
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x01,
                0x08,
                0x40,
                0x37,
                0xF5,
                0x36,
                0x4B,
                0x98,
                0xCF,
                0x61,
                0xAF,
                0x8A,
                0x2C,
                0x1A,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10_EXT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x54,
                0xC5,
                0x9C,
                0x7C,
                0xE3,
                0x32,
                0x49,
                0x86,
                0x84,
                0x49,
                0x20,
                0xF9,
                0xF6,
                0x40,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10_444
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0xEF,
                0xAB,
                0x0D,
                0x58,
                0x44,
                0x02,
                0x46,
                0xBC,
                0x03,
                0x07,
                0x95,
                0x65,
                0x9D,
                0x61,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN12_444
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0x63,
                0x98,
                0x97,
                0x9D,
                0xFE,
                0xE5,
                0x48,
                0xB4,
                0xDA,
                0xDB,
                0xEC,
                0x45,
                0xB3,
                0xDF,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN16
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0xDB,
                0xFB,
                0xA4,
                0x13,
                0xA1,
                0x2B,
                0x48,
                0xA2,
                0x32,
                0x63,
                0x5C,
                0xC0,
                0x69,
                0x7F,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_VP9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0x07,
                0x37,
                0x46,
                0xD0,
                0xA1,
                0x85,
                0x45,
                0x87,
                0x6D,
                0x83,
                0xAA,
                0x6D,
                0x60,
                0xB8,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_VP9_10BIT_PROFILE2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0x49,
                0xC7,
                0xA4,
                0xCF,
                0x6E,
                0xAA,
                0x48,
                0x84,
                0x48,
                0x50,
                0xA7,
                0xA1,
                0x16,
                0x5F,
                0xF7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_VP8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0x99,
                0xB8,
                0x90,
                0x62,
                0x3A,
                0x05,
                0x47,
                0x88,
                0xB3,
                0x8D,
                0xF0,
                0x4B,
                0x27,
                0x44,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0x4C,
                0xBE,
                0xB8,
                0x53,
                0xCF,
                0xBA,
                0x46,
                0x8D,
                0x59,
                0xD6,
                0xB8,
                0xA6,
                0xDA,
                0x5D,
                0x2A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0F,
                0xFF,
                0x36,
                0x69,
                0xB1,
                0x45,
                0x63,
                0x41,
                0x9C,
                0xC1,
                0x64,
                0x6E,
                0xF6,
                0x94,
                0x61,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x2A,
                0x5F,
                0x0C,
                0x41,
                0xE5,
                0x89,
                0x40,
                0xBB,
                0x7B,
                0x98,
                0x11,
                0x0A,
                0x19,
                0xD7,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0x70,
                0x12,
                0x17,
                0x0F,
                0xA0,
                0xE1,
                0x4C,
                0x99,
                0x4E,
                0xBF,
                0x40,
                0x81,
                0xF6,
                0xF3,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2_420
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xBE,
                0x80,
                0x2D,
                0xAC,
                0x9C,
                0x35,
                0x48,
                0x9E,
                0x91,
                0x32,
                0x7B,
                0xBC,
                0x4F,
                0x9E,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_MJPEG_VLD_420
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0xB5,
                0x5C,
                0x72,
                0x29,
                0x0C,
                0xC4,
                0x43,
                0x94,
                0x40,
                0x8E,
                0x93,
                0x97,
                0x90,
                0x3A,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_MJPEG_VLD_422
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0xB9,
                0x77,
                0x5B,
                0x35,
                0x1A,
                0x30,
                0x4C,
                0x9F,
                0xD8,
                0xEF,
                0x4B,
                0x60,
                0xC0,
                0x35,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_MJPEG_VLD_444
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0x61,
                0x51,
                0xD9,
                0x44,
                0x0D,
                0xE6,
                0x47,
                0xBC,
                0xF5,
                0x1B,
                0xFB,
                0xFB,
                0x26,
                0x8F,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_MJPEG_VLD_4444
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x48,
                0x17,
                0xC9,
                0x18,
                0xFD,
                0xCA,
                0x4A,
                0x9D,
                0xB3,
                0x3A,
                0x66,
                0x34,
                0xAB,
                0x54,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_JPEG_VLD_420
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0x2C,
                0x78,
                0xCF,
                0xF5,
                0xBE,
                0x2C,
                0x4A,
                0x87,
                0xCB,
                0x60,
                0x19,
                0xE7,
                0xB1,
                0x75,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_JPEG_VLD_422
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x17,
                0xF4,
                0x4D,
                0xF0,
                0xE2,
                0xEE,
                0x67,
                0x40,
                0xA7,
                0x78,
                0xF3,
                0x5C,
                0x15,
                0xAB,
                0x97,
                0x21,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_JPEG_VLD_444
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x17,
                0x0E,
                0xD0,
                0x4C,
                0xBA,
                0x89,
                0xEF,
                0x48,
                0xB9,
                0xF9,
                0xED,
                0xCB,
                0x82,
                0x71,
                0x3F,
                0x65,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
