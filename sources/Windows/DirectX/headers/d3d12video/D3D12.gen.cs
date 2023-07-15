// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;
public static partial class D3D12
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_MPEG2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0xC9
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0x60
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0xC5
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0x3D
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0x52
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0x3C
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0xC5
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0xC5
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0x19
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0x2E
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0xC0
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0x13
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0x9E
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0xF7
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0xE7
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0x2A
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0x08
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0xC8
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0xF0
            };
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
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0xE8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}