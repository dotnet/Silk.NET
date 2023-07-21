// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class MFT
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_END_STREAMING_AWARE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x45, 0xC8, 0xFB, 0x70,
                0x7E, 0xB0,
                0x89, 0x40,
                0xB0,
                0x64,
                0x39,
                0x9D,
                0xC6,
                0x11,
                0x0F,
                0x29
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_AUDIO_DECODER_AUDIO_ENDPOINT_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x6E, 0xDD, 0xCC, 0xC7,
                0x98, 0x53,
                0x95, 0x46,
                0x8B,
                0xE7,
                0x51,
                0xB3,
                0xE9,
                0x51,
                0x11,
                0xBD
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_AUDIO_DECODER_SPATIAL_METADATA_CLIENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF4, 0x7D, 0x98, 0x05,
                0x70, 0x12,
                0x99, 0x49,
                0x92,
                0x5F,
                0x8E,
                0x93,
                0x9A,
                0x7C,
                0x0A,
                0xF7
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_SUPPORT_3DVIDEO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB1, 0x81, 0x3F, 0x09,
                0x2E, 0x4F,
                0x31, 0x46,
                0x81,
                0x68,
                0x79,
                0x34,
                0x03,
                0x2A,
                0x01,
                0xD3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_DECODER_EXPOSE_OUTPUT_TYPES_IN_NATIVE_ORDER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3F, 0x83, 0x80, 0xEF,
                0xFA, 0xF8,
                0xD9, 0x44,
                0x80,
                0xD8,
                0x41,
                0xED,
                0x62,
                0x32,
                0x67,
                0x0C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_DECODER_QUALITY_MANAGEMENT_CUSTOM_CONTROL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD7, 0x30, 0x4E, 0xA2,
                0x25, 0xDE,
                0x58, 0x45,
                0xBB,
                0xFB,
                0x71,
                0x07,
                0x0A,
                0x2D,
                0x33,
                0x2E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_DECODER_QUALITY_MANAGEMENT_RECOVERY_WITHOUT_ARTIFACTS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xEB, 0x0D, 0x98, 0xD8,
                0x48, 0x0A,
                0x5F, 0x42,
                0x86,
                0x23,
                0x61,
                0x1D,
                0xB4,
                0x1D,
                0x38,
                0x10
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_REMUX_MARK_I_PICTURE_AS_CLEAN_POINT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x85, 0x8F, 0x4E, 0x36,
                0x2E, 0x3F,
                0x6C, 0x43,
                0xB2,
                0xA2,
                0x44,
                0x40,
                0xA0,
                0x12,
                0xA9,
                0xE8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_DECODER_FINAL_VIDEO_RESOLUTION_HINT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x96, 0x84, 0x2F, 0xDC,
                0xC4, 0x15,
                0x7A, 0x40,
                0xB6,
                0xF0,
                0x1B,
                0x66,
                0xAB,
                0x5F,
                0xBF,
                0x53
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_ENCODER_SUPPORTS_CONFIG_EVENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAE, 0x55, 0xA3, 0x86,
                0x77, 0x3A,
                0xC4, 0x4E,
                0x9F,
                0x31,
                0x01,
                0x14,
                0x9A,
                0x4E,
                0x92,
                0xDE
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_ENUM_HARDWARE_VENDOR_ID_Attribute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xCC, 0xB0, 0xEC, 0x3A,
                0x5B, 0x03,
                0xCC, 0x4B,
                0x81,
                0x85,
                0x2B,
                0x8D,
                0x55,
                0x1E,
                0xF3,
                0xAF
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_TRANSFORM_CLSID_Attribute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2B, 0xC4, 0x21, 0x68,
                0xA4, 0x65,
                0x82, 0x4E,
                0x99,
                0xBC,
                0x9A,
                0x88,
                0x20,
                0x5E,
                0xCD,
                0x0C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_INPUT_TYPES_Attributes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB1, 0xC9, 0x76, 0x42,
                0x9D, 0x75,
                0xF3, 0x4B,
                0x9C,
                0xD0,
                0x0D,
                0x72,
                0x3D,
                0x13,
                0x8F,
                0x96
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_OUTPUT_TYPES_Attributes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF3, 0x8C, 0xAE, 0x8E,
                0x4F, 0xA4,
                0x06, 0x43,
                0xBA,
                0x5C,
                0xBF,
                0x5D,
                0xDA,
                0x24,
                0x28,
                0x18
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_ENUM_HARDWARE_URL_Attribute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAC, 0x66, 0xB8, 0x2F,
                0x78, 0xB0,
                0x42, 0x49,
                0xAB,
                0x6C,
                0x00,
                0x3D,
                0x05,
                0xCD,
                0xA6,
                0x74
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_FRIENDLY_NAME_Attribute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAE, 0xFB, 0x4F, 0x31,
                0x41, 0x5B,
                0x95, 0x4C,
                0x9C,
                0x19,
                0x4E,
                0x7D,
                0x58,
                0x6F,
                0xAC,
                0xE3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_CONNECTED_STREAM_ATTRIBUTE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x20, 0xB8, 0xEE, 0x71,
                0x9F, 0xA5,
                0xE2, 0x4D,
                0xBC,
                0xEC,
                0x38,
                0xDB,
                0x1D,
                0xD6,
                0x11,
                0xA4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_CONNECTED_TO_HW_STREAM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x28, 0xE7, 0xE6, 0x34,
                0xD6, 0x06,
                0x91, 0x44,
                0xA5,
                0x53,
                0x47,
                0x95,
                0x65,
                0x0D,
                0xB9,
                0x12
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_PREFERRED_OUTPUTTYPE_Attribute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x99, 0x04, 0x70, 0x7E,
                0x6A, 0x39,
                0xEE, 0x49,
                0xB1,
                0xB4,
                0xF6,
                0x28,
                0x02,
                0x1E,
                0x8C,
                0x9D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_PROCESS_LOCAL_Attribute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE4, 0x86, 0x31, 0x54,
                0x49, 0x46,
                0x65, 0x4E,
                0xB5,
                0x88,
                0x4A,
                0xA3,
                0x52,
                0xAF,
                0xF3,
                0x79
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_PREFERRED_ENCODER_PROFILE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x09, 0x49, 0x00, 0x53,
                0xF5, 0x1E,
                0xD7, 0x46,
                0xA1,
                0x8E,
                0x5A,
                0x75,
                0xF8,
                0xB5,
                0x90,
                0x5F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_HW_TIMESTAMP_WITH_QPC_Attribute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB8, 0x0F, 0x03, 0x8D,
                0x43, 0xCC,
                0x58, 0x42,
                0xA2,
                0x2E,
                0x92,
                0x10,
                0xBE,
                0xF8,
                0x9B,
                0xE4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_FIELDOFUSE_UNLOCK_Attribute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xFD, 0xE9, 0xC2, 0x8E,
                0x48, 0x91,
                0x0D, 0x41,
                0x83,
                0x1E,
                0x70,
                0x24,
                0x39,
                0x46,
                0x1A,
                0x8E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_CODEC_MERIT_Attribute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x15, 0xCB, 0xA7, 0x88,
                0x07, 0x7B,
                0x34, 0x4A,
                0x91,
                0x28,
                0xE6,
                0x4C,
                0x67,
                0x03,
                0xC4,
                0xD3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_ENUM_TRANSCODE_ONLY_ATTRIBUTE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xCD, 0xA8, 0x1E, 0x11,
                0x2A, 0xB6,
                0xDB, 0x4B,
                0x89,
                0xF6,
                0x67,
                0xFF,
                0xCD,
                0xC2,
                0x45,
                0x8B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFT_AUDIO_DECODER_DEGRADATION_INFO_ATTRIBUTE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAD, 0x86, 0x33, 0x6C,
                0x20, 0xEC,
                0x0D, 0x43,
                0xB2,
                0xA5,
                0x50,
                0x5C,
                0x71,
                0x78,
                0xD9,
                0xC4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_POLICY_SET_AWARE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x19, 0x3B, 0x63, 0x5A,
                0x39, 0xCC,
                0xA8, 0x4F,
                0x8C,
                0xA5,
                0x59,
                0x98,
                0x1B,
                0x7A,
                0x00,
                0x18
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFT_USING_HARDWARE_DRM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x7D, 0xA7, 0xFA, 0x34,
                0x9E, 0xD7,
                0x57, 0x49,
                0xB8,
                0xCE,
                0x36,
                0x2B,
                0x26,
                0x84,
                0x99,
                0x6C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define MFT_STREAMS_UNLIMITED 0xFFFFFFFF")]
    public const uint MFT_STREAMS_UNLIMITED = 0xFFFFFFFF;

    [NativeTypeName("#define MFT_OUTPUT_BOUND_LOWER_UNBOUNDED MINLONGLONG")]
    public const long MFT_OUTPUT_BOUND_LOWER_UNBOUNDED = ((long)(~(0x7fffffffffffffff)));

    [NativeTypeName("#define MFT_OUTPUT_BOUND_UPPER_UNBOUNDED MAXLONGLONG")]
    public const long MFT_OUTPUT_BOUND_UPPER_UNBOUNDED = (0x7fffffffffffffff);
}
