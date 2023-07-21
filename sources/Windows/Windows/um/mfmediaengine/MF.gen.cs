// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class MF
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MSE_CALLBACK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC0, 0xA7, 0x63, 0x90,
                0xC5, 0x42,
                0xFD, 0x4F,
                0xA8,
                0xA8,
                0x6F,
                0xCF,
                0x9E,
                0xA3,
                0xD0,
                0x0C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MSE_ACTIVELIST_CALLBACK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0F, 0xDA, 0x9B, 0x94,
                0x49, 0x45,
                0xD5, 0x46,
                0xAD,
                0x7F,
                0xB8,
                0x46,
                0xE1,
                0xAB,
                0x16,
                0x52
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MSE_BUFFERLIST_CALLBACK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB0, 0x69, 0xE6, 0x42,
                0x0E, 0xD6,
                0xFB, 0x4A,
                0xA8,
                0x5B,
                0xD8,
                0xE5,
                0xFE,
                0x6B,
                0xDA,
                0xB5
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MSE_VP9_SUPPORT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x29, 0x84, 0xD7, 0x92,
                0x8B, 0xD8,
                0xF0, 0x4F,
                0x83,
                0x22,
                0x80,
                0x3E,
                0xFA,
                0x6E,
                0x96,
                0x26
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MSE_OPUS_SUPPORT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC1, 0x4C, 0x22, 0x4D,
                0xC4, 0x8C,
                0xA3, 0x48,
                0xA7,
                0xA7,
                0xE4,
                0xC1,
                0x6C,
                0xE6,
                0x38,
                0x8A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_NEEDKEY_CALLBACK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x43, 0x08, 0xA8, 0x7E,
                0xE4, 0xB6,
                0x2C, 0x43,
                0x8E,
                0xA4,
                0x78,
                0x48,
                0xFF,
                0xE4,
                0x22,
                0x0E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_CALLBACK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB8, 0x81, 0x03, 0xC6,
                0xA4, 0x83,
                0xF8, 0x41,
                0xA3,
                0xD0,
                0xDE,
                0x05,
                0x07,
                0x68,
                0x49,
                0xA9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_DXGI_MANAGER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDA, 0x02, 0x57, 0x06,
                0x94, 0x10,
                0x6D, 0x48,
                0x86,
                0x17,
                0xEE,
                0x7C,
                0xC4,
                0xEE,
                0x46,
                0x48
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_EXTENSION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x46, 0xFD, 0x09, 0x31,
                0x0D, 0x06,
                0x62, 0x4B,
                0x8D,
                0xCF,
                0xFA,
                0xFF,
                0x81,
                0x13,
                0x18,
                0xD2
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_PLAYBACK_HWND
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x9B, 0x87, 0x88, 0xD9,
                0xC9, 0x67,
                0x92, 0x4D,
                0xBA,
                0xA7,
                0x6E,
                0xAD,
                0xD4,
                0x46,
                0x03,
                0x9D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_OPM_HWND
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE7, 0x8E, 0xBE, 0xA0,
                0x72, 0x05,
                0x2C, 0x4F,
                0xA8,
                0x01,
                0x2A,
                0x15,
                0x1B,
                0xD3,
                0xE7,
                0x26
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_PLAYBACK_VISUAL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x6F, 0xD2, 0xEB, 0x6D,
                0xB9, 0x6A,
                0x7E, 0x4D,
                0xB0,
                0xEE,
                0xC6,
                0x1A,
                0x73,
                0xFF,
                0xAD,
                0x15
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_COREWINDOW
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDC, 0xE4, 0xCA, 0xFC,
                0x7F, 0x0B,
                0xC2, 0x41,
                0x9F,
                0x96,
                0x46,
                0x59,
                0x94,
                0x8A,
                0xCD,
                0xDC
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_VIDEO_OUTPUT_FORMAT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3C, 0x89, 0x66, 0x50,
                0xF9, 0x8C,
                0xBC, 0x42,
                0x8B,
                0x8A,
                0x47,
                0x22,
                0x12,
                0xE5,
                0x27,
                0x26
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_CONTENT_PROTECTION_FLAGS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x23, 0x02, 0x35, 0xE0,
                0xAF, 0x5A,
                0x76, 0x4D,
                0xA7,
                0xC3,
                0x06,
                0xDE,
                0x70,
                0x89,
                0x4D,
                0xB4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_CONTENT_PROTECTION_MANAGER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAA, 0xDF, 0xD6, 0xFD,
                0x85, 0xBD,
                0xF3, 0x4A,
                0x9E,
                0x0F,
                0xA0,
                0x1D,
                0x53,
                0x9D,
                0x87,
                0x6A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_AUDIO_ENDPOINT_ROLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD1, 0x93, 0xCB, 0xD2,
                0x6A, 0x11,
                0xF2, 0x44,
                0x93,
                0x85,
                0xF7,
                0xD0,
                0xFD,
                0xA2,
                0xFB,
                0x46
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_AUDIO_CATEGORY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1D, 0xC5, 0xD4, 0xC8,
                0x0E, 0x35,
                0xF2, 0x41,
                0xBA,
                0x46,
                0xFA,
                0xEB,
                0xBB,
                0x08,
                0x57,
                0xF6
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_STREAM_CONTAINS_ALPHA_CHANNEL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x44, 0xAF, 0xBF, 0x5C,
                0xB2, 0xD2,
                0xFB, 0x4C,
                0x80,
                0xA7,
                0xD4,
                0x29,
                0xC7,
                0x4C,
                0x78,
                0x9D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE2, 0x12, 0x02, 0x4E,
                0x8F, 0xE1,
                0xE1, 0x41,
                0x95,
                0xE5,
                0xC0,
                0xE7,
                0xE9,
                0x23,
                0x5B,
                0xC3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x39, 0x2D, 0x2C, 0x05,
                0xC0, 0x40,
                0x88, 0x41,
                0xAB,
                0x86,
                0xF8,
                0x28,
                0x27,
                0x3B,
                0x75,
                0x22
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xFD, 0x7A, 0xA4, 0x11,
                0x89, 0x65,
                0x24, 0x41,
                0xB3,
                0x12,
                0x61,
                0x58,
                0xEC,
                0x51,
                0x7F,
                0xC3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE11
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5F, 0x31, 0xF1, 0x1C,
                0x3F, 0xCE,
                0x35, 0x40,
                0x93,
                0x91,
                0x16,
                0x14,
                0x2F,
                0x77,
                0x51,
                0x89
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE_EDGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x65, 0xE4, 0xF3, 0xA6,
                0xCA, 0x3A,
                0x2C, 0x44,
                0xA3,
                0xF0,
                0xAD,
                0x6D,
                0xDA,
                0xD8,
                0x39,
                0xAE
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_COMPATIBILITY_MODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD4, 0x6A, 0xF2, 0x3E,
                0x54, 0xDC,
                0xDE, 0x45,
                0xB9,
                0xAF,
                0x76,
                0xC8,
                0xC6,
                0x6B,
                0xFA,
                0x8E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_COMPATIBILITY_MODE_WWA_EDGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x98, 0x90, 0xB2, 0x15,
                0x01, 0x9F,
                0x4D, 0x4E,
                0xB6,
                0x5A,
                0xC0,
                0x6C,
                0x6C,
                0x89,
                0xDA,
                0x2A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_COMPATIBILITY_MODE_WIN10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x89, 0xE0, 0x25, 0x5B,
                0xA7, 0x6C,
                0x39, 0x41,
                0xA2,
                0xCB,
                0xFC,
                0xAA,
                0xB3,
                0x95,
                0x52,
                0xA3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_SOURCE_RESOLVER_CONFIG_STORE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x97, 0xC4, 0xC0, 0x0A,
                0xC4, 0xB3,
                0xC9, 0x48,
                0x9C,
                0xDE,
                0xBB,
                0x8C,
                0xA2,
                0x44,
                0x2C,
                0xA3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_TRACK_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x12, 0xA3, 0xBE, 0x65,
                0x43, 0x40,
                0x15, 0x48,
                0x8E,
                0xAB,
                0x44,
                0xDC,
                0xE2,
                0xEF,
                0x8F,
                0x2A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_TELEMETRY_APPLICATION_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3B, 0x27, 0x7B, 0x1E,
                0xE4, 0xA7,
                0x2A, 0x40,
                0x8F,
                0x51,
                0xC4,
                0x8E,
                0x88,
                0xA2,
                0xCA,
                0xBC
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_SYNCHRONOUS_CLOSE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2F, 0xE1, 0xC2, 0xC3,
                0x0E, 0x7E,
                0x43, 0x4E,
                0xB9,
                0x1C,
                0xDC,
                0x99,
                0x2C,
                0xCD,
                0xFA,
                0x5E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_MEDIA_PLAYER_MODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x45, 0x8D, 0xDD, 0x3D,
                0xA1, 0x5A,
                0x12, 0x41,
                0x82,
                0xE5,
                0x36,
                0xF6,
                0xA2,
                0x19,
                0x7E,
                0x6E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_TIMEDTEXT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x11, 0xA4, 0x5E, 0x80,
                0xE0, 0x92,
                0x59, 0x4E,
                0x9B,
                0x6E,
                0x5C,
                0x7D,
                0x79,
                0x15,
                0xE6,
                0x4F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_CONTINUE_ON_CODEC_ERROR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF9, 0xB7, 0xCD, 0xDB,
                0xE4, 0x48,
                0x95, 0x42,
                0xB7,
                0x0D,
                0xD5,
                0x18,
                0x23,
                0x4E,
                0xEB,
                0x38
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_ENGINE_EME_CALLBACK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA7, 0x53, 0x45, 0x49,
                0x81, 0xA4,
                0xB7, 0x4C,
                0xBE,
                0xC5,
                0x38,
                0x09,
                0x03,
                0x51,
                0x37,
                0x31
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MF_EME_INITDATATYPES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1B, 0x23, 0x7D, 0x49,
                0xB9, 0x4E,
                0xF0, 0x4D,
                0xB4,
                0x74,
                0xB9,
                0xAF,
                0xEB,
                0x0A,
                0xDF,
                0x38,
                0x03, 0x00, 0x00, 0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MF_EME_DISTINCTIVEID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA5, 0xC4, 0xC9, 0x7D,
                0xBE, 0x12,
                0x7E, 0x49,
                0x8B,
                0xFF,
                0x9B,
                0x60,
                0xB2,
                0xDC,
                0x58,
                0x45,
                0x04, 0x00, 0x00, 0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MF_EME_PERSISTEDSTATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAE, 0xF6, 0x4D, 0x5D,
                0xF1, 0x9A,
                0x3D, 0x4E,
                0x95,
                0x5B,
                0x0E,
                0x4B,
                0xD2,
                0x2F,
                0xED,
                0xF0,
                0x05, 0x00, 0x00, 0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MF_EME_AUDIOCAPABILITIES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x84, 0xBB, 0x0F, 0x98,
                0x7D, 0x29,
                0xA7, 0x4E,
                0x89,
                0x5F,
                0xBC,
                0xF2,
                0x8A,
                0x46,
                0x28,
                0x81,
                0x06, 0x00, 0x00, 0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MF_EME_VIDEOCAPABILITIES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3D, 0xF8, 0x72, 0xB1,
                0xDD, 0x30,
                0x10, 0x4C,
                0x80,
                0x06,
                0xED,
                0x53,
                0xDA,
                0x4D,
                0x3B,
                0xDB,
                0x07, 0x00, 0x00, 0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MF_EME_LABEL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0E, 0x27, 0xAE, 0x9E,
                0xD7, 0xB2,
                0x17, 0x48,
                0xB8,
                0x8F,
                0x54,
                0x00,
                0x99,
                0xF2,
                0xEF,
                0x4E,
                0x08, 0x00, 0x00, 0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MF_EME_SESSIONTYPES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4F, 0x38, 0x23, 0x76,
                0xF5, 0x00,
                0x76, 0x43,
                0x86,
                0x98,
                0x34,
                0x58,
                0xDB,
                0x03,
                0x0E,
                0xD5,
                0x09, 0x00, 0x00, 0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MF_EME_ROBUSTNESS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x9E, 0x2B, 0x3D, 0x9D,
                0x23, 0x70,
                0x44, 0x49,
                0xA8,
                0xF5,
                0xEC,
                0xCA,
                0x52,
                0xA4,
                0x69,
                0x90,
                0x03, 0x00, 0x00, 0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MF_EME_CONTENTTYPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xFC, 0xB1, 0x9F, 0x28,
                0xC4, 0xD9,
                0xC7, 0x4C,
                0xB2,
                0xBE,
                0x97,
                0x2B,
                0x0E,
                0x9B,
                0x28,
                0x3A,
                0x04, 0x00, 0x00, 0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MF_EME_CDM_INPRIVATESTOREPATH
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD9, 0x5F, 0x30, 0xEC,
                0x9F, 0x03,
                0xC8, 0x4A,
                0x98,
                0xDA,
                0xE7,
                0x92,
                0x1E,
                0x00,
                0x6A,
                0x90,
                0x03, 0x00, 0x00, 0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MF_EME_CDM_STOREPATH
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1E, 0x84, 0x95, 0xF7,
                0xF9, 0x99,
                0xD7, 0x44,
                0xAF,
                0xC0,
                0xD3,
                0x09,
                0xC0,
                0x4C,
                0x94,
                0xAB,
                0x04, 0x00, 0x00, 0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define MF_INVALID_PRESENTATION_TIME 0x8000000000000000")]
    public const ulong MF_INVALID_PRESENTATION_TIME = 0x8000000000000000;
}
