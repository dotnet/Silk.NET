// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;
public static partial class D3D11
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG2_MOCOMP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4B,
                0xF4,
                0xA9,
                0xE6,
                0xB0,
                0x61,
                0x63,
                0x45,
                0x9E,
                0xA4,
                0x63,
                0xD2,
                0xA3,
                0xC6,
                0xFE,
                0x66
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG2_IDCT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0xAD,
                0x22,
                0xBF,
                0xEA,
                0x03,
                0x90,
                0x46,
                0x80,
                0x77,
                0x47,
                0x33,
                0x46,
                0x20,
                0x9B,
                0x7E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG2_VLD
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG1_VLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0xC7,
                0x3E,
                0x6F,
                0x35,
                0x37,
                0xCC,
                0x42,
                0x80,
                0x63,
                0x65,
                0xCC,
                0x3C,
                0xB3,
                0x66,
                0x16
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG2and1_VLD
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_MOCOMP_NOFGT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x64,
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_MOCOMP_FGT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x65,
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_IDCT_NOFGT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x66,
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_IDCT_FGT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x67,
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_VLD_NOFGT
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_VLD_FGT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x69,
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_VLD_WITHFMOASO_NOFGT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF9,
                0x4F,
                0xF0,
                0xD5,
                0x18,
                0x34,
                0xD8,
                0x45,
                0x95,
                0x61,
                0x32,
                0xA7,
                0x6A,
                0xAE,
                0x2D,
                0xDD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_VLD_STEREO_PROGRESSIVE_NOFGT
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_VLD_STEREO_NOFGT
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_H264_VLD_MULTIVIEW_NOFGT
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_WMV8_POSTPROC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_WMV8_MOCOMP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_WMV9_POSTPROC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x90,
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_WMV9_MOCOMP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x91,
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_WMV9_IDCT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x94,
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_VC1_POSTPROC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA0,
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_VC1_MOCOMP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA1,
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_VC1_IDCT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA2,
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_VC1_VLD
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_VC1_D2010
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG4PT2_VLD_SIMPLE
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG4PT2_VLD_ADVSIMPLE_NOGMC
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG4PT2_VLD_ADVSIMPLE_GMC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5B,
                0x8B,
                0x99,
                0xAB,
                0x58,
                0x42,
                0xA9,
                0x44,
                0x9F,
                0xEB,
                0x94,
                0xE5,
                0x97,
                0xA6,
                0xBA,
                0xAE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_PROFILE_HEVC_VLD_MAIN
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_HEVC_VLD_MAIN10
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_VP9_VLD_PROFILE0
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_VP9_VLD_10BIT_PROFILE2
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_VP8_VLD
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_AV1_VLD_PROFILE0
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_AV1_VLD_PROFILE1
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_AV1_VLD_PROFILE2
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_AV1_VLD_12BIT_PROFILE2
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
    public static ref readonly Guid D3D11_DECODER_PROFILE_AV1_VLD_12BIT_PROFILE2_420
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_CRYPTO_TYPE_AES128_CTR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0xD7,
                0x6B,
                0x9B,
                0x74,
                0x4F,
                0xC9,
                0x41,
                0x9E,
                0x7B,
                0x0B,
                0xE2,
                0xD7,
                0xD9,
                0x3B,
                0x4F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_ENCRYPTION_HW_CENC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4F,
                0xAC,
                0xD6,
                0x89,
                0xF2,
                0x09,
                0x29,
                0x42,
                0xB2,
                0xCD,
                0x37,
                0x74,
                0x0A,
                0x6D,
                0xFD,
                0x81
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_BITSTREAM_ENCRYPTION_TYPE_CENC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x35,
                0x52,
                0x40,
                0xB0,
                0x3D,
                0xC1,
                0xF2,
                0x44,
                0x9A,
                0xE5,
                0xDD,
                0x48,
                0xE0,
                0x8E,
                0x5B,
                0x67
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_DECODER_BITSTREAM_ENCRYPTION_TYPE_CBCS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0x93,
                0x2D,
                0x42,
                0x21,
                0x9D,
                0xB7,
                0x4B,
                0x93,
                0x71,
                0xFA,
                0xF5,
                0xA8,
                0x2C,
                0x3E,
                0x04
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_KEY_EXCHANGE_HW_PROTECTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0x0D,
                0x17,
                0xB1,
                0x8D,
                0x62,
                0xA3,
                0x4D,
                0xAD,
                0x3B,
                0x82,
                0xDD,
                0xB0,
                0x8B,
                0x49,
                0x70
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_PROTECTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0xB5,
                0x4E,
                0xA8,
                0x95,
                0xC4,
                0xAA,
                0x48,
                0xB9,
                0x4D,
                0x8B,
                0xD2,
                0xD6,
                0xFB,
                0xCE,
                0x05
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA5,
                0x18,
                0x1B,
                0xBC,
                0xFB,
                0xB1,
                0xAB,
                0x42,
                0xBD,
                0x94,
                0xB5,
                0x82,
                0x8B,
                0x4B,
                0xF7,
                0xBE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_DEVICE_HANDLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9D,
                0x53,
                0x1C,
                0xEC,
                0xFF,
                0x8C,
                0x2A,
                0x4E,
                0xBC,
                0xC4,
                0xF5,
                0x69,
                0x2F,
                0x99,
                0xF4,
                0x80
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9E,
                0x49,
                0x34,
                0x26,
                0x18,
                0xD0,
                0x74,
                0x4D,
                0xAC,
                0x17,
                0x7F,
                0x72,
                0x40,
                0x59,
                0x52,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_COUNT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB3,
                0x07,
                0xB2,
                0x0D,
                0x50,
                0x94,
                0xA6,
                0x46,
                0x82,
                0xDE,
                0x1B,
                0x96,
                0xD4,
                0x4F,
                0x9C,
                0xF2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0xBA,
                0x9B,
                0x64,
                0xF4,
                0xF0,
                0x39,
                0x46,
                0xA1,
                0x5B,
                0x24,
                0x39,
                0x3F,
                0xC3,
                0xAB,
                0xAC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_UNRESTRICTED_PROTECTED_SHARED_RESOURCE_COUNT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD6,
                0x0B,
                0x2F,
                0x01,
                0x62,
                0xE6,
                0x74,
                0x44,
                0xBE,
                0xFD,
                0xAA,
                0x53,
                0xE5,
                0x14,
                0x3C,
                0x6D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5E,
                0x2B,
                0x04,
                0x2C,
                0x07,
                0x8C,
                0xD5,
                0x46,
                0xAA,
                0xBE,
                0x8F,
                0x75,
                0xCB,
                0xAD,
                0x4C,
                0x31
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_OUTPUT_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA3,
                0xDC,
                0x9D,
                0x83,
                0x4E,
                0x9B,
                0xE4,
                0x41,
                0xB0,
                0x53,
                0x89,
                0x2B,
                0xD2,
                0xA1,
                0x1E,
                0xE7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ATTRIBUTES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD2,
                0xD9,
                0x14,
                0x62,
                0x2C,
                0x43,
                0xBB,
                0x4A,
                0x9F,
                0xCE,
                0x21,
                0x6E,
                0xEA,
                0x26,
                0x9E,
                0x3B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_ENCRYPTION_WHEN_ACCESSIBLE_GUID_COUNT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x66,
                0x70,
                0x0F,
                0xB3,
                0x3C,
                0x20,
                0x07,
                0x4B,
                0x93,
                0xFC,
                0xCE,
                0xAA,
                0xFD,
                0x61,
                0x24,
                0x1E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_ENCRYPTION_WHEN_ACCESSIBLE_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x58,
                0x59,
                0x3A,
                0xF8,
                0x86,
                0xE9,
                0xDA,
                0x4B,
                0xBE,
                0xB0,
                0x41,
                0x1F,
                0x6A,
                0x7A,
                0x01,
                0xB7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_QUERY_CURRENT_ENCRYPTION_WHEN_ACCESSIBLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0x91,
                0x17,
                0xEC,
                0xD3,
                0xDA,
                0x15,
                0x4F,
                0x9E,
                0xC3,
                0xFA,
                0xA9,
                0x3D,
                0x60,
                0xD4,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_CONFIGURE_INITIALIZE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0x4B,
                0x11,
                0x06,
                0x23,
                0x35,
                0x0A,
                0x47,
                0x8D,
                0xCA,
                0xFB,
                0xC2,
                0x84,
                0x51,
                0x54,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_CONFIGURE_PROTECTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x58,
                0x56,
                0x45,
                0x50,
                0x47,
                0x3F,
                0x62,
                0x43,
                0xBF,
                0x99,
                0xBF,
                0xDF,
                0xCD,
                0xE9,
                0xED,
                0x29
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_CONFIGURE_CRYPTO_SESSION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x54,
                0xCC,
                0x46,
                0x63,
                0xFC,
                0x2C,
                0xD4,
                0x4A,
                0x82,
                0x24,
                0xD1,
                0x58,
                0x37,
                0xDE,
                0x77,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x47,
                0xD0,
                0x72,
                0x07,
                0x40,
                0x1B,
                0xE8,
                0x48,
                0x9C,
                0xA6,
                0xB5,
                0xF5,
                0x10,
                0xDE,
                0x9F,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_AUTHENTICATED_CONFIGURE_ENCRYPTION_WHEN_ACCESSIBLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x86,
                0xF2,
                0xFF,
                0x41,
                0xE0,
                0x6A,
                0x43,
                0x4D,
                0x9D,
                0x55,
                0xA4,
                0x6E,
                0x9E,
                0xFD,
                0x15,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D11_KEY_EXCHANGE_RSAES_OAEP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x95,
                0x98,
                0x94,
                0xC1,
                0x2A,
                0xD7,
                0x1D,
                0x4A,
                0x8E,
                0x5D,
                0xED,
                0x85,
                0x7D,
                0x17,
                0x15,
                0x20
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define D3D11_16BIT_INDEX_STRIP_CUT_VALUE ( 0xffff )")]
    public const int D3D11_16BIT_INDEX_STRIP_CUT_VALUE = (0xffff);
    [NativeTypeName("#define D3D11_32BIT_INDEX_STRIP_CUT_VALUE ( 0xffffffff )")]
    public const uint D3D11_32BIT_INDEX_STRIP_CUT_VALUE = (0xffffffff);
    [NativeTypeName("#define D3D11_8BIT_INDEX_STRIP_CUT_VALUE ( 0xff )")]
    public const int D3D11_8BIT_INDEX_STRIP_CUT_VALUE = (0xff);
    [NativeTypeName("#define D3D11_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT ( 9 )")]
    public const int D3D11_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT = (9);
    [NativeTypeName("#define D3D11_CLIP_OR_CULL_DISTANCE_COUNT ( 8 )")]
    public const int D3D11_CLIP_OR_CULL_DISTANCE_COUNT = (8);
    [NativeTypeName("#define D3D11_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT ( 2 )")]
    public const int D3D11_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT = (2);
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT ( 14 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT = (14);
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS ( 4 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS = (4);
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT ( 15 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT = (15);
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT ( 16 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT = (16);
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS = (4);
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT ( 15 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT = (15);
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST = (1);
    [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT ( 64 )")]
    public const int D3D11_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT = (64);
    [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS = (4);
    [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT ( 1 )")]
    public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT = (1);
    [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST = (1);
    [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS = (1);
    [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT ( 128 )")]
    public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT = (128);
    [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST = (1);
    [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT ( 128 )")]
    public const int D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT = (128);
    [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS = (1);
    [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_REGISTER_COUNT ( 16 )")]
    public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_COUNT = (16);
    [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST = (1);
    [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT ( 16 )")]
    public const int D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT = (16);
    [NativeTypeName("#define D3D11_COMMONSHADER_SUBROUTINE_NESTING_LIMIT ( 32 )")]
    public const int D3D11_COMMONSHADER_SUBROUTINE_NESTING_LIMIT = (32);
    [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENTS = (4);
    [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_COUNT ( 4096 )")]
    public const int D3D11_COMMONSHADER_TEMP_REGISTER_COUNT = (4096);
    [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_READS_PER_INST ( 3 )")]
    public const int D3D11_COMMONSHADER_TEMP_REGISTER_READS_PER_INST = (3);
    [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_READ_PORTS ( 3 )")]
    public const int D3D11_COMMONSHADER_TEMP_REGISTER_READ_PORTS = (3);
    [NativeTypeName("#define D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX ( 10 )")]
    public const int D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX = (10);
    [NativeTypeName("#define D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN ( -10 )")]
    public const int D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN = (-10);
    [NativeTypeName("#define D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE ( -8 )")]
    public const int D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE = (-8);
    [NativeTypeName("#define D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE ( 7 )")]
    public const int D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE = (7);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET00_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 256 )")]
    public const int D3D11_CS_4_X_BUCKET00_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (256);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET00_MAX_NUM_THREADS_PER_GROUP ( 64 )")]
    public const int D3D11_CS_4_X_BUCKET00_MAX_NUM_THREADS_PER_GROUP = (64);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET01_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 240 )")]
    public const int D3D11_CS_4_X_BUCKET01_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (240);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET01_MAX_NUM_THREADS_PER_GROUP ( 68 )")]
    public const int D3D11_CS_4_X_BUCKET01_MAX_NUM_THREADS_PER_GROUP = (68);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET02_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 224 )")]
    public const int D3D11_CS_4_X_BUCKET02_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (224);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET02_MAX_NUM_THREADS_PER_GROUP ( 72 )")]
    public const int D3D11_CS_4_X_BUCKET02_MAX_NUM_THREADS_PER_GROUP = (72);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET03_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 208 )")]
    public const int D3D11_CS_4_X_BUCKET03_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (208);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET03_MAX_NUM_THREADS_PER_GROUP ( 76 )")]
    public const int D3D11_CS_4_X_BUCKET03_MAX_NUM_THREADS_PER_GROUP = (76);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET04_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 192 )")]
    public const int D3D11_CS_4_X_BUCKET04_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (192);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET04_MAX_NUM_THREADS_PER_GROUP ( 84 )")]
    public const int D3D11_CS_4_X_BUCKET04_MAX_NUM_THREADS_PER_GROUP = (84);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET05_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 176 )")]
    public const int D3D11_CS_4_X_BUCKET05_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (176);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET05_MAX_NUM_THREADS_PER_GROUP ( 92 )")]
    public const int D3D11_CS_4_X_BUCKET05_MAX_NUM_THREADS_PER_GROUP = (92);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET06_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 160 )")]
    public const int D3D11_CS_4_X_BUCKET06_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (160);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET06_MAX_NUM_THREADS_PER_GROUP ( 100 )")]
    public const int D3D11_CS_4_X_BUCKET06_MAX_NUM_THREADS_PER_GROUP = (100);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET07_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 144 )")]
    public const int D3D11_CS_4_X_BUCKET07_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (144);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET07_MAX_NUM_THREADS_PER_GROUP ( 112 )")]
    public const int D3D11_CS_4_X_BUCKET07_MAX_NUM_THREADS_PER_GROUP = (112);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET08_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 128 )")]
    public const int D3D11_CS_4_X_BUCKET08_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (128);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET08_MAX_NUM_THREADS_PER_GROUP ( 128 )")]
    public const int D3D11_CS_4_X_BUCKET08_MAX_NUM_THREADS_PER_GROUP = (128);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET09_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 112 )")]
    public const int D3D11_CS_4_X_BUCKET09_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (112);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET09_MAX_NUM_THREADS_PER_GROUP ( 144 )")]
    public const int D3D11_CS_4_X_BUCKET09_MAX_NUM_THREADS_PER_GROUP = (144);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET10_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 96 )")]
    public const int D3D11_CS_4_X_BUCKET10_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (96);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET10_MAX_NUM_THREADS_PER_GROUP ( 168 )")]
    public const int D3D11_CS_4_X_BUCKET10_MAX_NUM_THREADS_PER_GROUP = (168);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET11_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 80 )")]
    public const int D3D11_CS_4_X_BUCKET11_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (80);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET11_MAX_NUM_THREADS_PER_GROUP ( 204 )")]
    public const int D3D11_CS_4_X_BUCKET11_MAX_NUM_THREADS_PER_GROUP = (204);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET12_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 64 )")]
    public const int D3D11_CS_4_X_BUCKET12_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (64);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET12_MAX_NUM_THREADS_PER_GROUP ( 256 )")]
    public const int D3D11_CS_4_X_BUCKET12_MAX_NUM_THREADS_PER_GROUP = (256);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET13_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 48 )")]
    public const int D3D11_CS_4_X_BUCKET13_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (48);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET13_MAX_NUM_THREADS_PER_GROUP ( 340 )")]
    public const int D3D11_CS_4_X_BUCKET13_MAX_NUM_THREADS_PER_GROUP = (340);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET14_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 32 )")]
    public const int D3D11_CS_4_X_BUCKET14_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (32);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET14_MAX_NUM_THREADS_PER_GROUP ( 512 )")]
    public const int D3D11_CS_4_X_BUCKET14_MAX_NUM_THREADS_PER_GROUP = (512);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET15_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 16 )")]
    public const int D3D11_CS_4_X_BUCKET15_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (16);
    [NativeTypeName("#define D3D11_CS_4_X_BUCKET15_MAX_NUM_THREADS_PER_GROUP ( 768 )")]
    public const int D3D11_CS_4_X_BUCKET15_MAX_NUM_THREADS_PER_GROUP = (768);
    [NativeTypeName("#define D3D11_CS_4_X_DISPATCH_MAX_THREAD_GROUPS_IN_Z_DIMENSION ( 1 )")]
    public const int D3D11_CS_4_X_DISPATCH_MAX_THREAD_GROUPS_IN_Z_DIMENSION = (1);
    [NativeTypeName("#define D3D11_CS_4_X_RAW_UAV_BYTE_ALIGNMENT ( 256 )")]
    public const int D3D11_CS_4_X_RAW_UAV_BYTE_ALIGNMENT = (256);
    [NativeTypeName("#define D3D11_CS_4_X_THREAD_GROUP_MAX_THREADS_PER_GROUP ( 768 )")]
    public const int D3D11_CS_4_X_THREAD_GROUP_MAX_THREADS_PER_GROUP = (768);
    [NativeTypeName("#define D3D11_CS_4_X_THREAD_GROUP_MAX_X ( 768 )")]
    public const int D3D11_CS_4_X_THREAD_GROUP_MAX_X = (768);
    [NativeTypeName("#define D3D11_CS_4_X_THREAD_GROUP_MAX_Y ( 768 )")]
    public const int D3D11_CS_4_X_THREAD_GROUP_MAX_Y = (768);
    [NativeTypeName("#define D3D11_CS_4_X_UAV_REGISTER_COUNT ( 1 )")]
    public const int D3D11_CS_4_X_UAV_REGISTER_COUNT = (1);
    [NativeTypeName("#define D3D11_CS_DISPATCH_MAX_THREAD_GROUPS_PER_DIMENSION ( 65535 )")]
    public const int D3D11_CS_DISPATCH_MAX_THREAD_GROUPS_PER_DIMENSION = (65535);
    [NativeTypeName("#define D3D11_CS_TGSM_REGISTER_COUNT ( 8192 )")]
    public const int D3D11_CS_TGSM_REGISTER_COUNT = (8192);
    [NativeTypeName("#define D3D11_CS_TGSM_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D11_CS_TGSM_REGISTER_READS_PER_INST = (1);
    [NativeTypeName("#define D3D11_CS_TGSM_RESOURCE_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_CS_TGSM_RESOURCE_REGISTER_COMPONENTS = (1);
    [NativeTypeName("#define D3D11_CS_TGSM_RESOURCE_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_CS_TGSM_RESOURCE_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_CS_THREADGROUPID_REGISTER_COMPONENTS ( 3 )")]
    public const int D3D11_CS_THREADGROUPID_REGISTER_COMPONENTS = (3);
    [NativeTypeName("#define D3D11_CS_THREADGROUPID_REGISTER_COUNT ( 1 )")]
    public const int D3D11_CS_THREADGROUPID_REGISTER_COUNT = (1);
    [NativeTypeName("#define D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COMPONENTS = (1);
    [NativeTypeName("#define D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COUNT ( 1 )")]
    public const int D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COUNT = (1);
    [NativeTypeName("#define D3D11_CS_THREADIDINGROUP_REGISTER_COMPONENTS ( 3 )")]
    public const int D3D11_CS_THREADIDINGROUP_REGISTER_COMPONENTS = (3);
    [NativeTypeName("#define D3D11_CS_THREADIDINGROUP_REGISTER_COUNT ( 1 )")]
    public const int D3D11_CS_THREADIDINGROUP_REGISTER_COUNT = (1);
    [NativeTypeName("#define D3D11_CS_THREADID_REGISTER_COMPONENTS ( 3 )")]
    public const int D3D11_CS_THREADID_REGISTER_COMPONENTS = (3);
    [NativeTypeName("#define D3D11_CS_THREADID_REGISTER_COUNT ( 1 )")]
    public const int D3D11_CS_THREADID_REGISTER_COUNT = (1);
    [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MAX_THREADS_PER_GROUP ( 1024 )")]
    public const int D3D11_CS_THREAD_GROUP_MAX_THREADS_PER_GROUP = (1024);
    [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MAX_X ( 1024 )")]
    public const int D3D11_CS_THREAD_GROUP_MAX_X = (1024);
    [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MAX_Y ( 1024 )")]
    public const int D3D11_CS_THREAD_GROUP_MAX_Y = (1024);
    [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MAX_Z ( 64 )")]
    public const int D3D11_CS_THREAD_GROUP_MAX_Z = (64);
    [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MIN_X ( 1 )")]
    public const int D3D11_CS_THREAD_GROUP_MIN_X = (1);
    [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MIN_Y ( 1 )")]
    public const int D3D11_CS_THREAD_GROUP_MIN_Y = (1);
    [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MIN_Z ( 1 )")]
    public const int D3D11_CS_THREAD_GROUP_MIN_Z = (1);
    [NativeTypeName("#define D3D11_CS_THREAD_LOCAL_TEMP_REGISTER_POOL ( 16384 )")]
    public const int D3D11_CS_THREAD_LOCAL_TEMP_REGISTER_POOL = (16384);
    [NativeTypeName("#define D3D11_DEFAULT_BLEND_FACTOR_ALPHA ( 1.0f )")]
    public const float D3D11_DEFAULT_BLEND_FACTOR_ALPHA = (1.0f);
    [NativeTypeName("#define D3D11_DEFAULT_BLEND_FACTOR_BLUE ( 1.0f )")]
    public const float D3D11_DEFAULT_BLEND_FACTOR_BLUE = (1.0f);
    [NativeTypeName("#define D3D11_DEFAULT_BLEND_FACTOR_GREEN ( 1.0f )")]
    public const float D3D11_DEFAULT_BLEND_FACTOR_GREEN = (1.0f);
    [NativeTypeName("#define D3D11_DEFAULT_BLEND_FACTOR_RED ( 1.0f )")]
    public const float D3D11_DEFAULT_BLEND_FACTOR_RED = (1.0f);
    [NativeTypeName("#define D3D11_DEFAULT_BORDER_COLOR_COMPONENT ( 0.0f )")]
    public const float D3D11_DEFAULT_BORDER_COLOR_COMPONENT = (0.0f);
    [NativeTypeName("#define D3D11_DEFAULT_DEPTH_BIAS ( 0 )")]
    public const int D3D11_DEFAULT_DEPTH_BIAS = (0);
    [NativeTypeName("#define D3D11_DEFAULT_DEPTH_BIAS_CLAMP ( 0.0f )")]
    public const float D3D11_DEFAULT_DEPTH_BIAS_CLAMP = (0.0f);
    [NativeTypeName("#define D3D11_DEFAULT_MAX_ANISOTROPY ( 16 )")]
    public const int D3D11_DEFAULT_MAX_ANISOTROPY = (16);
    [NativeTypeName("#define D3D11_DEFAULT_MIP_LOD_BIAS ( 0.0f )")]
    public const float D3D11_DEFAULT_MIP_LOD_BIAS = (0.0f);
    [NativeTypeName("#define D3D11_DEFAULT_RENDER_TARGET_ARRAY_INDEX ( 0 )")]
    public const int D3D11_DEFAULT_RENDER_TARGET_ARRAY_INDEX = (0);
    [NativeTypeName("#define D3D11_DEFAULT_SAMPLE_MASK ( 0xffffffff )")]
    public const uint D3D11_DEFAULT_SAMPLE_MASK = (0xffffffff);
    [NativeTypeName("#define D3D11_DEFAULT_SCISSOR_ENDX ( 0 )")]
    public const int D3D11_DEFAULT_SCISSOR_ENDX = (0);
    [NativeTypeName("#define D3D11_DEFAULT_SCISSOR_ENDY ( 0 )")]
    public const int D3D11_DEFAULT_SCISSOR_ENDY = (0);
    [NativeTypeName("#define D3D11_DEFAULT_SCISSOR_STARTX ( 0 )")]
    public const int D3D11_DEFAULT_SCISSOR_STARTX = (0);
    [NativeTypeName("#define D3D11_DEFAULT_SCISSOR_STARTY ( 0 )")]
    public const int D3D11_DEFAULT_SCISSOR_STARTY = (0);
    [NativeTypeName("#define D3D11_DEFAULT_SLOPE_SCALED_DEPTH_BIAS ( 0.0f )")]
    public const float D3D11_DEFAULT_SLOPE_SCALED_DEPTH_BIAS = (0.0f);
    [NativeTypeName("#define D3D11_DEFAULT_STENCIL_READ_MASK ( 0xff )")]
    public const int D3D11_DEFAULT_STENCIL_READ_MASK = (0xff);
    [NativeTypeName("#define D3D11_DEFAULT_STENCIL_REFERENCE ( 0 )")]
    public const int D3D11_DEFAULT_STENCIL_REFERENCE = (0);
    [NativeTypeName("#define D3D11_DEFAULT_STENCIL_WRITE_MASK ( 0xff )")]
    public const int D3D11_DEFAULT_STENCIL_WRITE_MASK = (0xff);
    [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX ( 0 )")]
    public const int D3D11_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX = (0);
    [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_HEIGHT ( 0 )")]
    public const int D3D11_DEFAULT_VIEWPORT_HEIGHT = (0);
    [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_MAX_DEPTH ( 0.0f )")]
    public const float D3D11_DEFAULT_VIEWPORT_MAX_DEPTH = (0.0f);
    [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_MIN_DEPTH ( 0.0f )")]
    public const float D3D11_DEFAULT_VIEWPORT_MIN_DEPTH = (0.0f);
    [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_TOPLEFTX ( 0 )")]
    public const int D3D11_DEFAULT_VIEWPORT_TOPLEFTX = (0);
    [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_TOPLEFTY ( 0 )")]
    public const int D3D11_DEFAULT_VIEWPORT_TOPLEFTY = (0);
    [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_WIDTH ( 0 )")]
    public const int D3D11_DEFAULT_VIEWPORT_WIDTH = (0);
    [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS ( 3968 )")]
    public const int D3D11_DS_INPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS = (3968);
    [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENTS = (4);
    [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COUNT = (32);
    [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READS_PER_INST = (2);
    [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENTS ( 3 )")]
    public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENTS = (3);
    [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COUNT ( 1 )")]
    public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COUNT = (1);
    [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READS_PER_INST = (2);
    [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENTS = (4);
    [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COUNT = (32);
    [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST = (2);
    [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS = (1);
    [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COUNT ( 1 )")]
    public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COUNT = (1);
    [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST = (2);
    [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_DS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_DS_OUTPUT_REGISTER_COMPONENTS = (4);
    [NativeTypeName("#define D3D11_DS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_DS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_DS_OUTPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_DS_OUTPUT_REGISTER_COUNT = (32);
    [NativeTypeName("#define D3D11_FLOAT16_FUSED_TOLERANCE_IN_ULP ( 0.6 )")]
    public const double D3D11_FLOAT16_FUSED_TOLERANCE_IN_ULP = (0.6);
    [NativeTypeName("#define D3D11_FLOAT32_MAX ( 3.402823466e+38f )")]
    public const float D3D11_FLOAT32_MAX = (3.402823466e+38f);
    [NativeTypeName("#define D3D11_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP ( 0.6f )")]
    public const float D3D11_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP = (0.6f);
    [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR ( 2.4f )")]
    public const float D3D11_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR = (2.4f);
    [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_EXPONENT_NUMERATOR ( 1.0f )")]
    public const float D3D11_FLOAT_TO_SRGB_EXPONENT_NUMERATOR = (1.0f);
    [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_OFFSET ( 0.055f )")]
    public const float D3D11_FLOAT_TO_SRGB_OFFSET = (0.055f);
    [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_SCALE_1 ( 12.92f )")]
    public const float D3D11_FLOAT_TO_SRGB_SCALE_1 = (12.92f);
    [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_SCALE_2 ( 1.055f )")]
    public const float D3D11_FLOAT_TO_SRGB_SCALE_2 = (1.055f);
    [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_THRESHOLD ( 0.0031308f )")]
    public const float D3D11_FLOAT_TO_SRGB_THRESHOLD = (0.0031308f);
    [NativeTypeName("#define D3D11_FTOI_INSTRUCTION_MAX_INPUT ( 2147483647.999f )")]
    public const float D3D11_FTOI_INSTRUCTION_MAX_INPUT = (2147483647.999f);
    [NativeTypeName("#define D3D11_FTOI_INSTRUCTION_MIN_INPUT ( -2147483648.999f )")]
    public const float D3D11_FTOI_INSTRUCTION_MIN_INPUT = (-2147483648.999f);
    [NativeTypeName("#define D3D11_FTOU_INSTRUCTION_MAX_INPUT ( 4294967295.999f )")]
    public const float D3D11_FTOU_INSTRUCTION_MAX_INPUT = (4294967295.999f);
    [NativeTypeName("#define D3D11_FTOU_INSTRUCTION_MIN_INPUT ( 0.0f )")]
    public const float D3D11_FTOU_INSTRUCTION_MIN_INPUT = (0.0f);
    [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_READS_PER_INST ( 2 )")]
    public const int D3D11_GS_INPUT_INSTANCE_ID_READS_PER_INST = (2);
    [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_READ_PORTS ( 1 )")]
    public const int D3D11_GS_INPUT_INSTANCE_ID_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENTS = (1);
    [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
    public const int D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COUNT = (1);
    [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS = (1);
    [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_COUNT ( 1 )")]
    public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_COUNT = (1);
    [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST = (2);
    [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_GS_INPUT_REGISTER_COMPONENTS = (4);
    [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_GS_INPUT_REGISTER_COUNT = (32);
    [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_GS_INPUT_REGISTER_READS_PER_INST = (2);
    [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_GS_INPUT_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_VERTICES ( 32 )")]
    public const int D3D11_GS_INPUT_REGISTER_VERTICES = (32);
    [NativeTypeName("#define D3D11_GS_MAX_INSTANCE_COUNT ( 32 )")]
    public const int D3D11_GS_MAX_INSTANCE_COUNT = (32);
    [NativeTypeName("#define D3D11_GS_MAX_OUTPUT_VERTEX_COUNT_ACROSS_INSTANCES ( 1024 )")]
    public const int D3D11_GS_MAX_OUTPUT_VERTEX_COUNT_ACROSS_INSTANCES = (1024);
    [NativeTypeName("#define D3D11_GS_OUTPUT_ELEMENTS ( 32 )")]
    public const int D3D11_GS_OUTPUT_ELEMENTS = (32);
    [NativeTypeName("#define D3D11_GS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_GS_OUTPUT_REGISTER_COMPONENTS = (4);
    [NativeTypeName("#define D3D11_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_GS_OUTPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_GS_OUTPUT_REGISTER_COUNT = (32);
    [NativeTypeName("#define D3D11_HS_CONTROL_POINT_PHASE_INPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_HS_CONTROL_POINT_PHASE_INPUT_REGISTER_COUNT = (32);
    [NativeTypeName("#define D3D11_HS_CONTROL_POINT_PHASE_OUTPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_HS_CONTROL_POINT_PHASE_OUTPUT_REGISTER_COUNT = (32);
    [NativeTypeName("#define D3D11_HS_CONTROL_POINT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_HS_CONTROL_POINT_REGISTER_COMPONENTS = (4);
    [NativeTypeName("#define D3D11_HS_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_HS_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_HS_CONTROL_POINT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_HS_CONTROL_POINT_REGISTER_READS_PER_INST = (2);
    [NativeTypeName("#define D3D11_HS_CONTROL_POINT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_HS_CONTROL_POINT_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_HS_FORK_PHASE_INSTANCE_COUNT_UPPER_BOUND ( 0xffffffff )")]
    public const uint D3D11_HS_FORK_PHASE_INSTANCE_COUNT_UPPER_BOUND = (0xffffffff);
    [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENTS = (1);
    [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
    public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COUNT = (1);
    [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READS_PER_INST = (2);
    [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENTS = (1);
    [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
    public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COUNT = (1);
    [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READS_PER_INST = (2);
    [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS = (1);
    [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COUNT ( 1 )")]
    public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COUNT = (1);
    [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST = (2);
    [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_HS_JOIN_PHASE_INSTANCE_COUNT_UPPER_BOUND ( 0xffffffff )")]
    public const uint D3D11_HS_JOIN_PHASE_INSTANCE_COUNT_UPPER_BOUND = (0xffffffff);
    [NativeTypeName("#define D3D11_HS_MAXTESSFACTOR_LOWER_BOUND ( 1.0f )")]
    public const float D3D11_HS_MAXTESSFACTOR_LOWER_BOUND = (1.0f);
    [NativeTypeName("#define D3D11_HS_MAXTESSFACTOR_UPPER_BOUND ( 64.0f )")]
    public const float D3D11_HS_MAXTESSFACTOR_UPPER_BOUND = (64.0f);
    [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS ( 3968 )")]
    public const int D3D11_HS_OUTPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS = (3968);
    [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENTS = (1);
    [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COUNT ( 1 )")]
    public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COUNT = (1);
    [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READS_PER_INST = (2);
    [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENTS = (4);
    [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COUNT = (32);
    [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST = (2);
    [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_SCALAR_COMPONENTS ( 128 )")]
    public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_SCALAR_COMPONENTS = (128);
    [NativeTypeName("#define D3D11_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES ( 0 )")]
    public const int D3D11_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES = (0);
    [NativeTypeName("#define D3D11_IA_DEFAULT_PRIMITIVE_TOPOLOGY ( 0 )")]
    public const int D3D11_IA_DEFAULT_PRIMITIVE_TOPOLOGY = (0);
    [NativeTypeName("#define D3D11_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES ( 0 )")]
    public const int D3D11_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES = (0);
    [NativeTypeName("#define D3D11_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT ( 1 )")]
    public const int D3D11_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT = (1);
    [NativeTypeName("#define D3D11_IA_INSTANCE_ID_BIT_COUNT ( 32 )")]
    public const int D3D11_IA_INSTANCE_ID_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_IA_INTEGER_ARITHMETIC_BIT_COUNT ( 32 )")]
    public const int D3D11_IA_INTEGER_ARITHMETIC_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_IA_PATCH_MAX_CONTROL_POINT_COUNT ( 32 )")]
    public const int D3D11_IA_PATCH_MAX_CONTROL_POINT_COUNT = (32);
    [NativeTypeName("#define D3D11_IA_PRIMITIVE_ID_BIT_COUNT ( 32 )")]
    public const int D3D11_IA_PRIMITIVE_ID_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_IA_VERTEX_ID_BIT_COUNT ( 32 )")]
    public const int D3D11_IA_VERTEX_ID_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT ( 32 )")]
    public const int D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT = (32);
    [NativeTypeName("#define D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS ( 128 )")]
    public const int D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS = (128);
    [NativeTypeName("#define D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT ( 32 )")]
    public const int D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT = (32);
    [NativeTypeName("#define D3D11_INTEGER_DIVIDE_BY_ZERO_QUOTIENT ( 0xffffffff )")]
    public const uint D3D11_INTEGER_DIVIDE_BY_ZERO_QUOTIENT = (0xffffffff);
    [NativeTypeName("#define D3D11_INTEGER_DIVIDE_BY_ZERO_REMAINDER ( 0xffffffff )")]
    public const uint D3D11_INTEGER_DIVIDE_BY_ZERO_REMAINDER = (0xffffffff);
    [NativeTypeName("#define D3D11_KEEP_RENDER_TARGETS_AND_DEPTH_STENCIL ( 0xffffffff )")]
    public const uint D3D11_KEEP_RENDER_TARGETS_AND_DEPTH_STENCIL = (0xffffffff);
    [NativeTypeName("#define D3D11_KEEP_UNORDERED_ACCESS_VIEWS ( 0xffffffff )")]
    public const uint D3D11_KEEP_UNORDERED_ACCESS_VIEWS = (0xffffffff);
    [NativeTypeName("#define D3D11_LINEAR_GAMMA ( 1.0f )")]
    public const float D3D11_LINEAR_GAMMA = (1.0f);
    [NativeTypeName("#define D3D11_MAJOR_VERSION ( 11 )")]
    public const int D3D11_MAJOR_VERSION = (11);
    [NativeTypeName("#define D3D11_MAX_BORDER_COLOR_COMPONENT ( 1.0f )")]
    public const float D3D11_MAX_BORDER_COLOR_COMPONENT = (1.0f);
    [NativeTypeName("#define D3D11_MAX_DEPTH ( 1.0f )")]
    public const float D3D11_MAX_DEPTH = (1.0f);
    [NativeTypeName("#define D3D11_MAX_MAXANISOTROPY ( 16 )")]
    public const int D3D11_MAX_MAXANISOTROPY = (16);
    [NativeTypeName("#define D3D11_MAX_MULTISAMPLE_SAMPLE_COUNT ( 32 )")]
    public const int D3D11_MAX_MULTISAMPLE_SAMPLE_COUNT = (32);
    [NativeTypeName("#define D3D11_MAX_POSITION_VALUE ( 3.402823466e+34f )")]
    public const float D3D11_MAX_POSITION_VALUE = (3.402823466e+34f);
    [NativeTypeName("#define D3D11_MAX_TEXTURE_DIMENSION_2_TO_EXP ( 17 )")]
    public const int D3D11_MAX_TEXTURE_DIMENSION_2_TO_EXP = (17);
    [NativeTypeName("#define D3D11_MINOR_VERSION ( 0 )")]
    public const int D3D11_MINOR_VERSION = (0);
    [NativeTypeName("#define D3D11_MIN_BORDER_COLOR_COMPONENT ( 0.0f )")]
    public const float D3D11_MIN_BORDER_COLOR_COMPONENT = (0.0f);
    [NativeTypeName("#define D3D11_MIN_DEPTH ( 0.0f )")]
    public const float D3D11_MIN_DEPTH = (0.0f);
    [NativeTypeName("#define D3D11_MIN_MAXANISOTROPY ( 0 )")]
    public const int D3D11_MIN_MAXANISOTROPY = (0);
    [NativeTypeName("#define D3D11_MIP_LOD_BIAS_MAX ( 15.99f )")]
    public const float D3D11_MIP_LOD_BIAS_MAX = (15.99f);
    [NativeTypeName("#define D3D11_MIP_LOD_BIAS_MIN ( -16.0f )")]
    public const float D3D11_MIP_LOD_BIAS_MIN = (-16.0f);
    [NativeTypeName("#define D3D11_MIP_LOD_FRACTIONAL_BIT_COUNT ( 8 )")]
    public const int D3D11_MIP_LOD_FRACTIONAL_BIT_COUNT = (8);
    [NativeTypeName("#define D3D11_MIP_LOD_RANGE_BIT_COUNT ( 8 )")]
    public const int D3D11_MIP_LOD_RANGE_BIT_COUNT = (8);
    [NativeTypeName("#define D3D11_MULTISAMPLE_ANTIALIAS_LINE_WIDTH ( 1.4f )")]
    public const float D3D11_MULTISAMPLE_ANTIALIAS_LINE_WIDTH = (1.4f);
    [NativeTypeName("#define D3D11_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT ( 0 )")]
    public const int D3D11_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT = (0);
    [NativeTypeName("#define D3D11_PIXEL_ADDRESS_RANGE_BIT_COUNT ( 15 )")]
    public const int D3D11_PIXEL_ADDRESS_RANGE_BIT_COUNT = (15);
    [NativeTypeName("#define D3D11_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT ( 16 )")]
    public const int D3D11_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT = (16);
    [NativeTypeName("#define D3D11_PS_CS_UAV_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_PS_CS_UAV_REGISTER_COMPONENTS = (1);
    [NativeTypeName("#define D3D11_PS_CS_UAV_REGISTER_COUNT ( 8 )")]
    public const int D3D11_PS_CS_UAV_REGISTER_COUNT = (8);
    [NativeTypeName("#define D3D11_PS_CS_UAV_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D11_PS_CS_UAV_REGISTER_READS_PER_INST = (1);
    [NativeTypeName("#define D3D11_PS_CS_UAV_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_PS_CS_UAV_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_PS_FRONTFACING_DEFAULT_VALUE ( 0xffffffff )")]
    public const uint D3D11_PS_FRONTFACING_DEFAULT_VALUE = (0xffffffff);
    [NativeTypeName("#define D3D11_PS_FRONTFACING_FALSE_VALUE ( 0 )")]
    public const int D3D11_PS_FRONTFACING_FALSE_VALUE = (0);
    [NativeTypeName("#define D3D11_PS_FRONTFACING_TRUE_VALUE ( 0xffffffff )")]
    public const uint D3D11_PS_FRONTFACING_TRUE_VALUE = (0xffffffff);
    [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_PS_INPUT_REGISTER_COMPONENTS = (4);
    [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_PS_INPUT_REGISTER_COUNT = (32);
    [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_PS_INPUT_REGISTER_READS_PER_INST = (2);
    [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_PS_INPUT_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT ( 0.0f )")]
    public const float D3D11_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT = (0.0f);
    [NativeTypeName("#define D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS = (1);
    [NativeTypeName("#define D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_PS_OUTPUT_DEPTH_REGISTER_COUNT ( 1 )")]
    public const int D3D11_PS_OUTPUT_DEPTH_REGISTER_COUNT = (1);
    [NativeTypeName("#define D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENTS = (1);
    [NativeTypeName("#define D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_PS_OUTPUT_MASK_REGISTER_COUNT ( 1 )")]
    public const int D3D11_PS_OUTPUT_MASK_REGISTER_COUNT = (1);
    [NativeTypeName("#define D3D11_PS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_PS_OUTPUT_REGISTER_COMPONENTS = (4);
    [NativeTypeName("#define D3D11_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_PS_OUTPUT_REGISTER_COUNT ( 8 )")]
    public const int D3D11_PS_OUTPUT_REGISTER_COUNT = (8);
    [NativeTypeName("#define D3D11_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT ( 0.5f )")]
    public const float D3D11_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT = (0.5f);
    [NativeTypeName("#define D3D11_RAW_UAV_SRV_BYTE_ALIGNMENT ( 16 )")]
    public const int D3D11_RAW_UAV_SRV_BYTE_ALIGNMENT = (16);
    [NativeTypeName("#define D3D11_REQ_BLEND_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
    public const int D3D11_REQ_BLEND_OBJECT_COUNT_PER_DEVICE = (4096);
    [NativeTypeName("#define D3D11_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP ( 27 )")]
    public const int D3D11_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP = (27);
    [NativeTypeName("#define D3D11_REQ_CONSTANT_BUFFER_ELEMENT_COUNT ( 4096 )")]
    public const int D3D11_REQ_CONSTANT_BUFFER_ELEMENT_COUNT = (4096);
    [NativeTypeName("#define D3D11_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
    public const int D3D11_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_DEVICE = (4096);
    [NativeTypeName("#define D3D11_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP ( 32 )")]
    public const int D3D11_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = (32);
    [NativeTypeName("#define D3D11_REQ_DRAW_VERTEX_COUNT_2_TO_EXP ( 32 )")]
    public const int D3D11_REQ_DRAW_VERTEX_COUNT_2_TO_EXP = (32);
    [NativeTypeName("#define D3D11_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION ( 16384 )")]
    public const int D3D11_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION = (16384);
    [NativeTypeName("#define D3D11_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT ( 1024 )")]
    public const int D3D11_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT = (1024);
    [NativeTypeName("#define D3D11_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT ( 4096 )")]
    public const int D3D11_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT = (4096);
    [NativeTypeName("#define D3D11_REQ_MAXANISOTROPY ( 16 )")]
    public const int D3D11_REQ_MAXANISOTROPY = (16);
    [NativeTypeName("#define D3D11_REQ_MIP_LEVELS ( 15 )")]
    public const int D3D11_REQ_MIP_LEVELS = (15);
    [NativeTypeName("#define D3D11_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES ( 2048 )")]
    public const int D3D11_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES = (2048);
    [NativeTypeName("#define D3D11_REQ_RASTERIZER_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
    public const int D3D11_REQ_RASTERIZER_OBJECT_COUNT_PER_DEVICE = (4096);
    [NativeTypeName("#define D3D11_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH ( 16384 )")]
    public const int D3D11_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH = (16384);
    [NativeTypeName("#define D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_A_TERM ( 128 )")]
    public const int D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_A_TERM = (128);
    [NativeTypeName("#define D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_B_TERM ( 0.25f )")]
    public const float D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_B_TERM = (0.25f);
    [NativeTypeName("#define D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_C_TERM ( 2048 )")]
    public const int D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_C_TERM = (2048);
    [NativeTypeName("#define D3D11_REQ_RESOURCE_VIEW_COUNT_PER_DEVICE_2_TO_EXP ( 20 )")]
    public const int D3D11_REQ_RESOURCE_VIEW_COUNT_PER_DEVICE_2_TO_EXP = (20);
    [NativeTypeName("#define D3D11_REQ_SAMPLER_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
    public const int D3D11_REQ_SAMPLER_OBJECT_COUNT_PER_DEVICE = (4096);
    [NativeTypeName("#define D3D11_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION ( 2048 )")]
    public const int D3D11_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION = (2048);
    [NativeTypeName("#define D3D11_REQ_TEXTURE1D_U_DIMENSION ( 16384 )")]
    public const int D3D11_REQ_TEXTURE1D_U_DIMENSION = (16384);
    [NativeTypeName("#define D3D11_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION ( 2048 )")]
    public const int D3D11_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION = (2048);
    [NativeTypeName("#define D3D11_REQ_TEXTURE2D_U_OR_V_DIMENSION ( 16384 )")]
    public const int D3D11_REQ_TEXTURE2D_U_OR_V_DIMENSION = (16384);
    [NativeTypeName("#define D3D11_REQ_TEXTURE3D_U_V_OR_W_DIMENSION ( 2048 )")]
    public const int D3D11_REQ_TEXTURE3D_U_V_OR_W_DIMENSION = (2048);
    [NativeTypeName("#define D3D11_REQ_TEXTURECUBE_DIMENSION ( 16384 )")]
    public const int D3D11_REQ_TEXTURECUBE_DIMENSION = (16384);
    [NativeTypeName("#define D3D11_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL ( 0 )")]
    public const int D3D11_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL = (0);
    [NativeTypeName("#define D3D11_SHADER_MAJOR_VERSION ( 5 )")]
    public const int D3D11_SHADER_MAJOR_VERSION = (5);
    [NativeTypeName("#define D3D11_SHADER_MAX_INSTANCES ( 65535 )")]
    public const int D3D11_SHADER_MAX_INSTANCES = (65535);
    [NativeTypeName("#define D3D11_SHADER_MAX_INTERFACES ( 253 )")]
    public const int D3D11_SHADER_MAX_INTERFACES = (253);
    [NativeTypeName("#define D3D11_SHADER_MAX_INTERFACE_CALL_SITES ( 4096 )")]
    public const int D3D11_SHADER_MAX_INTERFACE_CALL_SITES = (4096);
    [NativeTypeName("#define D3D11_SHADER_MAX_TYPES ( 65535 )")]
    public const int D3D11_SHADER_MAX_TYPES = (65535);
    [NativeTypeName("#define D3D11_SHADER_MINOR_VERSION ( 0 )")]
    public const int D3D11_SHADER_MINOR_VERSION = (0);
    [NativeTypeName("#define D3D11_SHIFT_INSTRUCTION_PAD_VALUE ( 0 )")]
    public const int D3D11_SHIFT_INSTRUCTION_PAD_VALUE = (0);
    [NativeTypeName("#define D3D11_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT ( 5 )")]
    public const int D3D11_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT = (5);
    [NativeTypeName("#define D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT ( 8 )")]
    public const int D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT = (8);
    [NativeTypeName("#define D3D11_SO_BUFFER_MAX_STRIDE_IN_BYTES ( 2048 )")]
    public const int D3D11_SO_BUFFER_MAX_STRIDE_IN_BYTES = (2048);
    [NativeTypeName("#define D3D11_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES ( 512 )")]
    public const int D3D11_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES = (512);
    [NativeTypeName("#define D3D11_SO_BUFFER_SLOT_COUNT ( 4 )")]
    public const int D3D11_SO_BUFFER_SLOT_COUNT = (4);
    [NativeTypeName("#define D3D11_SO_DDI_REGISTER_INDEX_DENOTING_GAP ( 0xffffffff )")]
    public const uint D3D11_SO_DDI_REGISTER_INDEX_DENOTING_GAP = (0xffffffff);
    [NativeTypeName("#define D3D11_SO_NO_RASTERIZED_STREAM ( 0xffffffff )")]
    public const uint D3D11_SO_NO_RASTERIZED_STREAM = (0xffffffff);
    [NativeTypeName("#define D3D11_SO_OUTPUT_COMPONENT_COUNT ( 128 )")]
    public const int D3D11_SO_OUTPUT_COMPONENT_COUNT = (128);
    [NativeTypeName("#define D3D11_SO_STREAM_COUNT ( 4 )")]
    public const int D3D11_SO_STREAM_COUNT = (4);
    [NativeTypeName("#define D3D11_SPEC_DATE_DAY ( 16 )")]
    public const int D3D11_SPEC_DATE_DAY = (16);
    [NativeTypeName("#define D3D11_SPEC_DATE_MONTH ( 05 )")]
    public const int D3D11_SPEC_DATE_MONTH = (05);
    [NativeTypeName("#define D3D11_SPEC_DATE_YEAR ( 2011 )")]
    public const int D3D11_SPEC_DATE_YEAR = (2011);
    [NativeTypeName("#define D3D11_SPEC_VERSION ( 1.07 )")]
    public const double D3D11_SPEC_VERSION = (1.07);
    [NativeTypeName("#define D3D11_SRGB_GAMMA ( 2.2f )")]
    public const float D3D11_SRGB_GAMMA = (2.2f);
    [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_DENOMINATOR_1 ( 12.92f )")]
    public const float D3D11_SRGB_TO_FLOAT_DENOMINATOR_1 = (12.92f);
    [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_DENOMINATOR_2 ( 1.055f )")]
    public const float D3D11_SRGB_TO_FLOAT_DENOMINATOR_2 = (1.055f);
    [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_EXPONENT ( 2.4f )")]
    public const float D3D11_SRGB_TO_FLOAT_EXPONENT = (2.4f);
    [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_OFFSET ( 0.055f )")]
    public const float D3D11_SRGB_TO_FLOAT_OFFSET = (0.055f);
    [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_THRESHOLD ( 0.04045f )")]
    public const float D3D11_SRGB_TO_FLOAT_THRESHOLD = (0.04045f);
    [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_TOLERANCE_IN_ULP ( 0.5f )")]
    public const float D3D11_SRGB_TO_FLOAT_TOLERANCE_IN_ULP = (0.5f);
    [NativeTypeName("#define D3D11_STANDARD_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_STANDARD_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_STANDARD_COMPONENT_BIT_COUNT_DOUBLED ( 64 )")]
    public const int D3D11_STANDARD_COMPONENT_BIT_COUNT_DOUBLED = (64);
    [NativeTypeName("#define D3D11_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE ( 4 )")]
    public const int D3D11_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE = (4);
    [NativeTypeName("#define D3D11_STANDARD_PIXEL_COMPONENT_COUNT ( 128 )")]
    public const int D3D11_STANDARD_PIXEL_COMPONENT_COUNT = (128);
    [NativeTypeName("#define D3D11_STANDARD_PIXEL_ELEMENT_COUNT ( 32 )")]
    public const int D3D11_STANDARD_PIXEL_ELEMENT_COUNT = (32);
    [NativeTypeName("#define D3D11_STANDARD_VECTOR_SIZE ( 4 )")]
    public const int D3D11_STANDARD_VECTOR_SIZE = (4);
    [NativeTypeName("#define D3D11_STANDARD_VERTEX_ELEMENT_COUNT ( 32 )")]
    public const int D3D11_STANDARD_VERTEX_ELEMENT_COUNT = (32);
    [NativeTypeName("#define D3D11_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT ( 64 )")]
    public const int D3D11_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT = (64);
    [NativeTypeName("#define D3D11_SUBPIXEL_FRACTIONAL_BIT_COUNT ( 8 )")]
    public const int D3D11_SUBPIXEL_FRACTIONAL_BIT_COUNT = (8);
    [NativeTypeName("#define D3D11_SUBTEXEL_FRACTIONAL_BIT_COUNT ( 8 )")]
    public const int D3D11_SUBTEXEL_FRACTIONAL_BIT_COUNT = (8);
    [NativeTypeName("#define D3D11_TESSELLATOR_MAX_EVEN_TESSELLATION_FACTOR ( 64 )")]
    public const int D3D11_TESSELLATOR_MAX_EVEN_TESSELLATION_FACTOR = (64);
    [NativeTypeName("#define D3D11_TESSELLATOR_MAX_ISOLINE_DENSITY_TESSELLATION_FACTOR ( 64 )")]
    public const int D3D11_TESSELLATOR_MAX_ISOLINE_DENSITY_TESSELLATION_FACTOR = (64);
    [NativeTypeName("#define D3D11_TESSELLATOR_MAX_ODD_TESSELLATION_FACTOR ( 63 )")]
    public const int D3D11_TESSELLATOR_MAX_ODD_TESSELLATION_FACTOR = (63);
    [NativeTypeName("#define D3D11_TESSELLATOR_MAX_TESSELLATION_FACTOR ( 64 )")]
    public const int D3D11_TESSELLATOR_MAX_TESSELLATION_FACTOR = (64);
    [NativeTypeName("#define D3D11_TESSELLATOR_MIN_EVEN_TESSELLATION_FACTOR ( 2 )")]
    public const int D3D11_TESSELLATOR_MIN_EVEN_TESSELLATION_FACTOR = (2);
    [NativeTypeName("#define D3D11_TESSELLATOR_MIN_ISOLINE_DENSITY_TESSELLATION_FACTOR ( 1 )")]
    public const int D3D11_TESSELLATOR_MIN_ISOLINE_DENSITY_TESSELLATION_FACTOR = (1);
    [NativeTypeName("#define D3D11_TESSELLATOR_MIN_ODD_TESSELLATION_FACTOR ( 1 )")]
    public const int D3D11_TESSELLATOR_MIN_ODD_TESSELLATION_FACTOR = (1);
    [NativeTypeName("#define D3D11_TEXEL_ADDRESS_RANGE_BIT_COUNT ( 16 )")]
    public const int D3D11_TEXEL_ADDRESS_RANGE_BIT_COUNT = (16);
    [NativeTypeName("#define D3D11_UNBOUND_MEMORY_ACCESS_RESULT ( 0 )")]
    public const int D3D11_UNBOUND_MEMORY_ACCESS_RESULT = (0);
    [NativeTypeName("#define D3D11_VIEWPORT_AND_SCISSORRECT_MAX_INDEX ( 15 )")]
    public const int D3D11_VIEWPORT_AND_SCISSORRECT_MAX_INDEX = (15);
    [NativeTypeName("#define D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE ( 16 )")]
    public const int D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE = (16);
    [NativeTypeName("#define D3D11_VIEWPORT_BOUNDS_MAX ( 32767 )")]
    public const int D3D11_VIEWPORT_BOUNDS_MAX = (32767);
    [NativeTypeName("#define D3D11_VIEWPORT_BOUNDS_MIN ( -32768 )")]
    public const int D3D11_VIEWPORT_BOUNDS_MIN = (-32768);
    [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_VS_INPUT_REGISTER_COMPONENTS = (4);
    [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_VS_INPUT_REGISTER_COUNT = (32);
    [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D11_VS_INPUT_REGISTER_READS_PER_INST = (2);
    [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D11_VS_INPUT_REGISTER_READ_PORTS = (1);
    [NativeTypeName("#define D3D11_VS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D11_VS_OUTPUT_REGISTER_COMPONENTS = (4);
    [NativeTypeName("#define D3D11_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D11_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);
    [NativeTypeName("#define D3D11_VS_OUTPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D11_VS_OUTPUT_REGISTER_COUNT = (32);
    [NativeTypeName("#define D3D11_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT ( 10 )")]
    public const int D3D11_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT = (10);
    [NativeTypeName("#define D3D11_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP ( 25 )")]
    public const int D3D11_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = (25);
    [NativeTypeName("#define D3D11_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP ( 25 )")]
    public const int D3D11_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP = (25);
    [NativeTypeName("#define D3D11_1_UAV_SLOT_COUNT ( 64 )")]
    public const int D3D11_1_UAV_SLOT_COUNT = (64);
    [NativeTypeName("#define D3D11_2_TILED_RESOURCE_TILE_SIZE_IN_BYTES ( 65536 )")]
    public const int D3D11_2_TILED_RESOURCE_TILE_SIZE_IN_BYTES = (65536);
    [NativeTypeName("#define D3D11_4_VIDEO_DECODER_MAX_HISTOGRAM_COMPONENTS ( 4 )")]
    public const int D3D11_4_VIDEO_DECODER_MAX_HISTOGRAM_COMPONENTS = (4);
    [NativeTypeName("#define D3D11_4_VIDEO_DECODER_HISTOGRAM_OFFSET_ALIGNMENT ( 256 )")]
    public const int D3D11_4_VIDEO_DECODER_HISTOGRAM_OFFSET_ALIGNMENT = (256);
    [NativeTypeName("#define D3D11_APPEND_ALIGNED_ELEMENT ( 0xffffffff )")]
    public const uint D3D11_APPEND_ALIGNED_ELEMENT = (0xffffffff);
    [NativeTypeName("#define D3D11_FILTER_REDUCTION_TYPE_MASK ( 0x3 )")]
    public const int D3D11_FILTER_REDUCTION_TYPE_MASK = (0x3);
    [NativeTypeName("#define D3D11_FILTER_REDUCTION_TYPE_SHIFT ( 7 )")]
    public const int D3D11_FILTER_REDUCTION_TYPE_SHIFT = (7);
    [NativeTypeName("#define D3D11_FILTER_TYPE_MASK ( 0x3 )")]
    public const int D3D11_FILTER_TYPE_MASK = (0x3);
    [NativeTypeName("#define D3D11_MIN_FILTER_SHIFT ( 4 )")]
    public const int D3D11_MIN_FILTER_SHIFT = (4);
    [NativeTypeName("#define D3D11_MAG_FILTER_SHIFT ( 2 )")]
    public const int D3D11_MAG_FILTER_SHIFT = (2);
    [NativeTypeName("#define D3D11_MIP_FILTER_SHIFT ( 0 )")]
    public const int D3D11_MIP_FILTER_SHIFT = (0);
    [NativeTypeName("#define D3D11_COMPARISON_FILTERING_BIT ( 0x80 )")]
    public const int D3D11_COMPARISON_FILTERING_BIT = (0x80);
    [NativeTypeName("#define D3D11_ANISOTROPIC_FILTERING_BIT ( 0x40 )")]
    public const int D3D11_ANISOTROPIC_FILTERING_BIT = (0x40);
    [NativeTypeName("#define D3D11_SDK_VERSION ( 7 )")]
    public const int D3D11_SDK_VERSION = (7);
}