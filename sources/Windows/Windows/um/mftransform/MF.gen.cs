// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class MF
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SA_D3D_AWARE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x29,
                0x5C,
                0xA3,
                0xEA,
                0x5E,
                0x77,
                0x8E,
                0x48,
                0x9B,
                0x61,
                0xB3,
                0x28,
                0x3E,
                0x49,
                0x58,
                0x3B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SA_REQUIRED_SAMPLE_COUNT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x61,
                0x2C,
                0x80,
                0x18,
                0x4B,
                0x32,
                0x52,
                0x49,
                0xAB,
                0xD0,
                0x17,
                0x6F,
                0xF5,
                0xC6,
                0x96,
                0xFF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SA_AUDIO_ENDPOINT_AWARE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0x17,
                0x38,
                0xC0,
                0x5C,
                0x80,
                0xB2,
                0x42,
                0xAC,
                0x8D,
                0xE2,
                0xB4,
                0xBF,
                0x21,
                0xF4,
                0xF8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_DMFT_FRAME_BUFFER_INFO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC9,
                0xE1,
                0x6C,
                0x39,
                0xA9,
                0x67,
                0x4C,
                0x45,
                0x87,
                0x97,
                0x95,
                0xA4,
                0x57,
                0x99,
                0xD8,
                0x04
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SA_REQUIRED_SAMPLE_COUNT_PROGRESSIVE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8E,
                0xD5,
                0x72,
                0xB1,
                0x77,
                0xFA,
                0x48,
                0x4E,
                0x8D,
                0x2A,
                0x1D,
                0xF2,
                0xD8,
                0x50,
                0xEA,
                0xC2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD5,
                0x45,
                0x17,
                0x85,
                0xD6,
                0xC3,
                0x6D,
                0x47,
                0x95,
                0x27,
                0x49,
                0x8E,
                0xF2,
                0xD1,
                0x0D,
                0x18
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNT_PROGRESSIVE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA5,
                0x23,
                0x55,
                0x0F,
                0xB2,
                0x1C,
                0xC5,
                0x47,
                0xA5,
                0x50,
                0x2E,
                0xEB,
                0x84,
                0xB4,
                0xD1,
                0x4A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_ENABLE_3DVIDEO_OUTPUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0x7B,
                0xAD,
                0xBD,
                0x5F,
                0x0E,
                0x10,
                0x4B,
                0xAB,
                0x16,
                0x26,
                0xDE,
                0x38,
                0x1B,
                0x62,
                0x93
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SA_D3D11_BINDFLAGS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAD,
                0x97,
                0xCF,
                0xEA,
                0x5C,
                0x06,
                0x08,
                0x44,
                0xBE,
                0xE3,
                0xFD,
                0xCB,
                0xFD,
                0x12,
                0x8B,
                0xE2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SA_D3D11_USAGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x42,
                0xE4,
                0x5F,
                0xE8,
                0xA3,
                0x2C,
                0x6E,
                0x48,
                0xA9,
                0xC7,
                0x10,
                0x9D,
                0xDA,
                0x60,
                0x98,
                0x80
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SA_D3D11_AWARE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC8,
                0x4F,
                0x6B,
                0x20,
                0xF9,
                0xFC,
                0x51,
                0x4C,
                0xAF,
                0xE3,
                0x97,
                0x64,
                0x36,
                0x9E,
                0x33,
                0xA0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SA_D3D11_SHARED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC3,
                0x32,
                0x8F,
                0x7B,
                0x96,
                0x6D,
                0x89,
                0x4B,
                0x92,
                0x03,
                0xDD,
                0x38,
                0xB6,
                0x14,
                0x14,
                0xF3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SA_D3D11_SHARED_WITHOUT_MUTEX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0xD4,
                0xDB,
                0x39,
                0x44,
                0x2E,
                0x31,
                0x49,
                0xA4,
                0xC8,
                0x35,
                0x2D,
                0x3D,
                0xC4,
                0x21,
                0x15
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SA_D3D11_ALLOW_DYNAMIC_YUV_TEXTURE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9F,
                0xD4,
                0x06,
                0xCE,
                0x13,
                0x06,
                0x9D,
                0x4B,
                0x86,
                0xA6,
                0xD8,
                0xC4,
                0xF9,
                0xC1,
                0x00,
                0x75
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SA_D3D11_HW_PROTECTED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD9,
                0xA9,
                0x8B,
                0x3A,
                0xCA,
                0x92,
                0x07,
                0x43,
                0xA3,
                0x91,
                0x69,
                0x99,
                0xDB,
                0xF3,
                0xB6,
                0xCE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SA_BUFFERS_PER_SAMPLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x71,
                0x51,
                0x3C,
                0x87,
                0x3D,
                0x1E,
                0x25,
                0x4E,
                0x98,
                0x8D,
                0xB4,
                0x33,
                0xCE,
                0x04,
                0x19,
                0x83
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SA_D3D11_ALLOCATE_DISPLAYABLE_RESOURCES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6D,
                0xCE,
                0xFA,
                0xEE,
                0xA9,
                0x2E,
                0xDF,
                0x4A,
                0xBB,
                0xDF,
                0x7B,
                0xBC,
                0x48,
                0x2A,
                0x1B,
                0x6D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_TRANSFORM_ASYNC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9A,
                0x69,
                0x1A,
                0xF8,
                0x9A,
                0x64,
                0x7D,
                0x49,
                0x8C,
                0x73,
                0x29,
                0xF8,
                0xFE,
                0xD6,
                0xAD,
                0x7A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_TRANSFORM_ASYNC_UNLOCK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6B,
                0x6D,
                0x66,
                0xE5,
                0x22,
                0x34,
                0xB6,
                0x4E,
                0xA4,
                0x21,
                0xDA,
                0x7D,
                0xB1,
                0xF8,
                0xE2,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_TRANSFORM_FLAGS_Attribute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0xBB,
                0x59,
                0x93,
                0x75,
                0x62,
                0xC4,
                0x46,
                0xA0,
                0x25,
                0x1C,
                0x01,
                0xE4,
                0x5F,
                0x1A,
                0x86
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_TRANSFORM_CATEGORY_Attribute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0xBA,
                0xAB,
                0xCE,
                0x6D,
                0x50,
                0x57,
                0x47,
                0xA6,
                0xFF,
                0x66,
                0xC1,
                0x84,
                0x98,
                0x7E,
                0x4E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}