// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class MF
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_INITIALIZED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0x92,
                0x99,
                0x21,
                0x92,
                0xCF,
                0x31,
                0x45,
                0xA1,
                0xAE,
                0x96,
                0xE1,
                0xE8,
                0x86,
                0xC8,
                0xF1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_PREVIEW_STARTED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x21,
                0xDF,
                0x16,
                0xA4,
                0xD3,
                0xF9,
                0x74,
                0x4A,
                0x99,
                0x1B,
                0xB8,
                0x17,
                0x29,
                0x89,
                0x52,
                0xC4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_PREVIEW_STOPPED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3C,
                0x14,
                0xD5,
                0x13,
                0xDD,
                0x1E,
                0x50,
                0x4E,
                0xA2,
                0xEF,
                0x35,
                0x0A,
                0x47,
                0x67,
                0x80,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_RECORD_STARTED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7B,
                0x02,
                0x2B,
                0xAC,
                0xF9,
                0xDD,
                0xA0,
                0x48,
                0x89,
                0xBE,
                0x38,
                0xAB,
                0x35,
                0xEF,
                0x45,
                0xC0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_RECORD_STOPPED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0A,
                0x20,
                0xE5,
                0x55,
                0x8F,
                0xF9,
                0x0D,
                0x4C,
                0xA9,
                0xEC,
                0x9E,
                0xB2,
                0x5E,
                0xD3,
                0xD7,
                0x73
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_PHOTO_TAKEN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x45,
                0xC4,
                0x50,
                0x3C,
                0x04,
                0x73,
                0xEB,
                0x48,
                0x86,
                0x5D,
                0xBB,
                0xA1,
                0x9B,
                0xA3,
                0xAF,
                0x5C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_SOURCE_CURRENT_DEVICE_MEDIA_TYPE_SET
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4C,
                0x5E,
                0xE7,
                0xE7,
                0x9C,
                0x03,
                0x10,
                0x44,
                0x81,
                0x5B,
                0x87,
                0x41,
                0x30,
                0x7B,
                0x63,
                0xAA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_ERROR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0x9F,
                0xB8,
                0x46,
                0xCC,
                0x33,
                0x99,
                0x43,
                0x9D,
                0xAD,
                0x78,
                0x4D,
                0xE7,
                0x7D,
                0x58,
                0x7C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_EFFECT_ADDED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB5,
                0xC7,
                0x8D,
                0xAA,
                0x48,
                0xA0,
                0x13,
                0x4E,
                0x8E,
                0xBE,
                0xF2,
                0x3C,
                0x46,
                0xC8,
                0x30,
                0xC1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_EFFECT_REMOVED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x07,
                0xDB,
                0xE8,
                0xC6,
                0x09,
                0xFB,
                0x48,
                0x4A,
                0x89,
                0xC6,
                0xBF,
                0x92,
                0xA0,
                0x42,
                0x22,
                0xC9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_ALL_EFFECTS_REMOVED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x21,
                0x75,
                0xED,
                0xFD,
                0xD8,
                0x8E,
                0x1A,
                0x43,
                0xA9,
                0x6B,
                0xF3,
                0xE2,
                0x56,
                0x5E,
                0x98,
                0x1C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_SINK_PREPARED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x57,
                0xE2,
                0xFC,
                0x7B,
                0xB1,
                0x12,
                0x09,
                0x44,
                0x8C,
                0x34,
                0xD4,
                0x45,
                0xDA,
                0xAB,
                0x75,
                0x78
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_OUTPUT_MEDIA_TYPE_SET
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x94,
                0xD9,
                0xAA,
                0xCA,
                0xEC,
                0x83,
                0xE9,
                0x45,
                0xA3,
                0x0A,
                0x1F,
                0x20,
                0xAA,
                0xDB,
                0x98,
                0x31
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_CAMERA_STREAM_BLOCKED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0x94,
                0x20,
                0xA4,
                0x39,
                0x8D,
                0xF3,
                0x46,
                0xB7,
                0x59,
                0x59,
                0x12,
                0x52,
                0x8F,
                0x42,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_CAMERA_STREAM_UNBLOCKED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF0,
                0xEE,
                0xE9,
                0x9B,
                0xAF,
                0xCD,
                0x17,
                0x47,
                0x85,
                0x64,
                0x83,
                0x4A,
                0xAE,
                0x66,
                0x41,
                0x5C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_D3D_MANAGER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7B,
                0x5E,
                0xE2,
                0x76,
                0x95,
                0xD5,
                0x83,
                0x42,
                0x96,
                0x2C,
                0xC5,
                0x94,
                0xAF,
                0xD7,
                0x8D,
                0xDF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_RECORD_SINK_VIDEO_MAX_UNPROCESSED_SAMPLES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0xF7,
                0x67,
                0xB4,
                0x13,
                0x79,
                0x94,
                0x48,
                0x9D,
                0x42,
                0xA2,
                0x15,
                0xFE,
                0xA2,
                0x3D,
                0xA9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_RECORD_SINK_AUDIO_MAX_UNPROCESSED_SAMPLES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0xB1,
                0xDD,
                0x1C,
                0xF4,
                0xA7,
                0x58,
                0x4D,
                0x98,
                0x96,
                0x4D,
                0x15,
                0xA5,
                0x3C,
                0x4E,
                0xFE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_RECORD_SINK_VIDEO_MAX_PROCESSED_SAMPLES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9E,
                0xA4,
                0xB4,
                0xE7,
                0x2C,
                0x38,
                0xEF,
                0x4A,
                0xA9,
                0x46,
                0xAE,
                0xD5,
                0x49,
                0x0B,
                0x71,
                0x11
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_RECORD_SINK_AUDIO_MAX_PROCESSED_SAMPLES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A,
                0xE1,
                0x96,
                0x98,
                0x07,
                0xF7,
                0x00,
                0x45,
                0xB6,
                0xBD,
                0xDB,
                0x8E,
                0xB8,
                0x10,
                0xB5,
                0x0F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_USE_AUDIO_DEVICE_ONLY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDA,
                0x77,
                0x80,
                0x1C,
                0x66,
                0x84,
                0xC4,
                0x4D,
                0x8B,
                0x8E,
                0x27,
                0x6B,
                0x3F,
                0x85,
                0x92,
                0x3B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_USE_VIDEO_DEVICE_ONLY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x71,
                0x51,
                0x02,
                0x7E,
                0x32,
                0xCF,
                0x2E,
                0x4F,
                0x8F,
                0x19,
                0x41,
                0x05,
                0x77,
                0xB7,
                0x3A,
                0x66
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_DISABLE_HARDWARE_TRANSFORMS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6B,
                0x2A,
                0xC4,
                0xB7,
                0x07,
                0x32,
                0x95,
                0x44,
                0xB4,
                0xE7,
                0x81,
                0xF9,
                0xC3,
                0x5D,
                0x59,
                0x91
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_DISABLE_DXVA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0x88,
                0x81,
                0xF9,
                0x9D,
                0x17,
                0x3F,
                0x43,
                0xA3,
                0x2F,
                0x74,
                0xCB,
                0xCF,
                0x74,
                0x46,
                0x6D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_MEDIASOURCE_CONFIG
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD2,
                0x89,
                0x69,
                0xBC,
                0xC1,
                0x0F,
                0xE1,
                0x46,
                0xA7,
                0x4F,
                0xEF,
                0xD3,
                0x6B,
                0xC7,
                0x88,
                0xDE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_DECODER_MFT_FIELDOFUSE_UNLOCK_Attribute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE8,
                0xD2,
                0x8A,
                0x2B,
                0xCB,
                0x7A,
                0x21,
                0x43,
                0xA6,
                0x06,
                0x32,
                0x5C,
                0x42,
                0x49,
                0xF4,
                0xFC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_ENCODER_MFT_FIELDOFUSE_UNLOCK_Attribute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x3A,
                0xC6,
                0x54,
                0xD5,
                0x78,
                0x2F,
                0x42,
                0xAA,
                0x3E,
                0x5E,
                0x99,
                0xAC,
                0x64,
                0x92,
                0x69
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_ENABLE_CAMERA_STREAMSTATE_NOTIFICATION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9D,
                0x8E,
                0x80,
                0x4C,
                0xED,
                0xAA,
                0x13,
                0x47,
                0x90,
                0xFB,
                0xCB,
                0x24,
                0x06,
                0x4A,
                0xB8,
                0xDA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_MEDIA_CATEGORY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD5,
                0x5B,
                0x3F,
                0x8E,
                0xBF,
                0xDB,
                0xF0,
                0x42,
                0x85,
                0x42,
                0xD0,
                0x7A,
                0x39,
                0x71,
                0x76,
                0x2A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_AUDIO_PROCESSING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5E,
                0xBE,
                0xF1,
                0x10,
                0x11,
                0x7E,
                0x0B,
                0x41,
                0x97,
                0x3D,
                0xF4,
                0xB6,
                0x10,
                0x90,
                0x00,
                0xFE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_EVENT_GENERATOR_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD5,
                0x8A,
                0xFA,
                0xAB,
                0x6D,
                0xFC,
                0x11,
                0x49,
                0x87,
                0xE0,
                0x96,
                0x19,
                0x45,
                0xF8,
                0xF7,
                0xCE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_EVENT_STREAM_INDEX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0x7F,
                0x69,
                0x82,
                0xCF,
                0xB1,
                0xEB,
                0x42,
                0x97,
                0x53,
                0xF8,
                0x6D,
                0x64,
                0x9C,
                0x88,
                0x65
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_SELECTEDCAMERAPROFILE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0x0B,
                0x16,
                0x03,
                0x6F,
                0x1C,
                0xB2,
                0x4D,
                0xAD,
                0x56,
                0xA7,
                0xC4,
                0x30,
                0xF8,
                0x23,
                0x92
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CAPTURE_ENGINE_SELECTEDCAMERAPROFILE_INDEX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x13,
                0x86,
                0xE8,
                0x3C,
                0x14,
                0x22,
                0xC3,
                0x46,
                0xB4,
                0x17,
                0x82,
                0xF8,
                0xA3,
                0x13,
                0xC9,
                0xC3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}