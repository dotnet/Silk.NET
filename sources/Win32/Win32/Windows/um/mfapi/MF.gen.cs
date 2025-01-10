// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MF
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_SESSIONCAPS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0xBC,
                0x5E,
                0x7E,
                0xB8,
                0x11,
                0xBE,
                0x4A,
                0xAF,
                0xAD,
                0x10,
                0xF6,
                0x59,
                0x9A,
                0x7F,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_SESSIONCAPS_DELTA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0xBC,
                0x5E,
                0x7E,
                0xB8,
                0x11,
                0xBE,
                0x4A,
                0xAF,
                0xAD,
                0x10,
                0xF6,
                0x59,
                0x9A,
                0x7F,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_TOPOLOGY_STATUS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0x01,
                0xC5,
                0x30,
                0x53,
                0x9A,
                0x4B,
                0x45,
                0xAD,
                0x9E,
                0x6D,
                0x5F,
                0x8F,
                0xA7,
                0xC4,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_START_PRESENTATION_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0x14,
                0xD9,
                0x5A,
                0x45,
                0x9B,
                0x8D,
                0x4A,
                0xA2,
                0xC0,
                0x81,
                0xD1,
                0xE5,
                0x0B,
                0xFB,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_PRESENTATION_TIME_OFFSET
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x14,
                0xD9,
                0x5A,
                0x45,
                0x9B,
                0x8D,
                0x4A,
                0xA2,
                0xC0,
                0x81,
                0xD1,
                0xE5,
                0x0B,
                0xFB,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_START_PRESENTATION_TIME_AT_OUTPUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0x14,
                0xD9,
                0x5A,
                0x45,
                0x9B,
                0x8D,
                0x4A,
                0xA2,
                0xC0,
                0x81,
                0xD1,
                0xE5,
                0x0B,
                0xFB,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_SOURCE_FAKE_START
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0x55,
                0xCC,
                0xA8,
                0x31,
                0x6B,
                0x9F,
                0x41,
                0x84,
                0x5D,
                0xFF,
                0xB3,
                0x51,
                0xA2,
                0x43,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_SOURCE_PROJECTSTART
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x55,
                0xCC,
                0xA8,
                0x31,
                0x6B,
                0x9F,
                0x41,
                0x84,
                0x5D,
                0xFF,
                0xB3,
                0x51,
                0xA2,
                0x43,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_SOURCE_ACTUAL_START
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x55,
                0xCC,
                0xA8,
                0x31,
                0x6B,
                0x9F,
                0x41,
                0x84,
                0x5D,
                0xFF,
                0xB3,
                0x51,
                0xA2,
                0x43,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_SOURCE_TOPOLOGY_CANCELED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0xF6,
                0x62,
                0xDB,
                0x5E,
                0x9A,
                0x04,
                0x47,
                0xAC,
                0xF3,
                0x56,
                0x3B,
                0xC6,
                0xA7,
                0x33,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_SOURCE_CHARACTERISTICS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x84,
                0xDB,
                0x47,
                0x22,
                0x8B,
                0x52,
                0x4F,
                0xAF,
                0xDA,
                0x9C,
                0xE1,
                0xB2,
                0xD3,
                0xCF,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_SOURCE_CHARACTERISTICS_OLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x84,
                0xDB,
                0x47,
                0x22,
                0x8B,
                0x52,
                0x4F,
                0xAF,
                0xDA,
                0x9C,
                0xE1,
                0xB2,
                0xD3,
                0xCF,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_DO_THINNING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0xA6,
                0x1E,
                0x32,
                0xD9,
                0xDA,
                0xE4,
                0x46,
                0xB3,
                0x1D,
                0xD2,
                0xEA,
                0xE7,
                0x09,
                0x0E,
                0x30,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_SCRUBSAMPLE_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x12,
                0xC7,
                0x9A,
                0xB8,
                0xDC,
                0xD5,
                0x44,
                0x8D,
                0x0C,
                0x37,
                0x45,
                0x5A,
                0x27,
                0x82,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_OUTPUT_NODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x1A,
                0x0F,
                0x83,
                0x60,
                0xC0,
                0xDD,
                0x46,
                0xA8,
                0x01,
                0x1C,
                0x95,
                0xDE,
                0xC9,
                0xB1,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_MFT_INPUT_STREAM_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCA,
                0x2C,
                0x9C,
                0xF2,
                0xE6,
                0x7A,
                0xD2,
                0x42,
                0xB2,
                0x84,
                0xBF,
                0x83,
                0x7C,
                0xC8,
                0x74,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_MFT_CONTEXT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x31,
                0xCD,
                0xB7,
                0x9E,
                0x89,
                0x41,
                0x4B,
                0x80,
                0xC9,
                0x26,
                0xA8,
                0x96,
                0xD3,
                0x29,
                0x77,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_STREAM_METADATA_KEYDATA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0xA4,
                0x59,
                0xCD,
                0x3B,
                0x4A,
                0xBD,
                0x4B,
                0x86,
                0x65,
                0x72,
                0xA4,
                0x0F,
                0xBE,
                0xA7,
                0x76,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_STREAM_METADATA_CONTENT_KEYIDS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x44,
                0x63,
                0x50,
                0x29,
                0xCC,
                0xC6,
                0x4F,
                0xA7,
                0x5A,
                0xD2,
                0x47,
                0xB3,
                0x5A,
                0xF8,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_EVENT_STREAM_METADATA_SYSTEMID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0xEF,
                0xA2,
                0x1E,
                0x16,
                0xBA,
                0x36,
                0x4A,
                0x87,
                0x19,
                0xFE,
                0x75,
                0x60,
                0xBA,
                0x32,
                0xAD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_PHOTO_FRAME_FLASH
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC6,
                0xD6,
                0x9D,
                0x0F,
                0x03,
                0x60,
                0xD8,
                0x45,
                0xBD,
                0x59,
                0xF1,
                0xF5,
                0x3E,
                0x3D,
                0x04,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_FRAME_RAWSTREAM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0x07,
                0x52,
                0x92,
                0x80,
                0x26,
                0xB9,
                0x49,
                0xAE,
                0x02,
                0xB1,
                0x90,
                0x75,
                0x97,
                0x3B,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_FOCUSSTATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0xE1,
                0x7E,
                0xA8,
                0x7F,
                0x99,
                0x5D,
                0x46,
                0xB9,
                0x1F,
                0x29,
                0xD5,
                0x3B,
                0x98,
                0x2B,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_REQUESTED_FRAME_SETTING_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD9,
                0x16,
                0x37,
                0xBB,
                0x61,
                0x8A,
                0xA4,
                0x47,
                0x81,
                0x97,
                0x45,
                0x9C,
                0x7F,
                0xF1,
                0x74,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_EXPOSURE_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0xAE,
                0xB9,
                0x16,
                0x84,
                0xCD,
                0x63,
                0x40,
                0x87,
                0x9D,
                0xA2,
                0x8C,
                0x76,
                0x33,
                0x72,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_EXPOSURE_COMPENSATION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0xAA,
                0x98,
                0xD1,
                0x62,
                0x4B,
                0x45,
                0x43,
                0xAB,
                0xF3,
                0x3C,
                0x31,
                0xFA,
                0x12,
                0xC2,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_ISO_SPEED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0xA6,
                0x28,
                0xE5,
                0xE3,
                0xB2,
                0xFE,
                0x44,
                0x8B,
                0x65,
                0x07,
                0xBF,
                0x4B,
                0x5A,
                0x13,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_LENS_POSITION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x8E,
                0xFC,
                0xB5,
                0xD1,
                0x11,
                0x70,
                0x4E,
                0x81,
                0x9B,
                0x72,
                0x3A,
                0x89,
                0xFA,
                0x45,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_SCENE_MODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0xB5,
                0xC3,
                0x9C,
                0xD3,
                0x5E,
                0xAE,
                0x4B,
                0xB3,
                0x88,
                0x76,
                0x70,
                0xAE,
                0xF5,
                0x9E,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_FLASH
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0B,
                0x52,
                0x51,
                0x4A,
                0x36,
                0xFB,
                0x6C,
                0x44,
                0x9D,
                0xF2,
                0x68,
                0x17,
                0x1B,
                0x9A,
                0x03,
                0x89,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_FLASH_POWER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x0D,
                0x0E,
                0x9C,
                0x05,
                0x02,
                0x1A,
                0x49,
                0xBC,
                0x9D,
                0x2D,
                0x6E,
                0x1F,
                0x4D,
                0x56,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_WHITEBALANCE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0xFD,
                0x36,
                0xC7,
                0xB9,
                0x0F,
                0x2E,
                0x4E,
                0x97,
                0xA2,
                0xFC,
                0xD4,
                0x90,
                0x73,
                0x9E,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_ZOOMFACTOR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x0B,
                0x0B,
                0xE5,
                0x01,
                0xE5,
                0xC2,
                0x42,
                0xAB,
                0xF2,
                0x85,
                0x7E,
                0xCB,
                0x13,
                0xFA,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_FACEROIS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x25,
                0x4F,
                0x86,
                0x9F,
                0x34,
                0xB1,
                0x46,
                0xA3,
                0x0E,
                0x54,
                0xCC,
                0x22,
                0x92,
                0x8A,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_FACEROITIMESTAMPS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCC,
                0x50,
                0x4D,
                0xE9,
                0xA0,
                0x3D,
                0xD4,
                0x44,
                0xBB,
                0x34,
                0x83,
                0x19,
                0x8A,
                0x74,
                0x18,
                0x68,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_FACEROICHARACTERIZATIONS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0xA1,
                0x27,
                0xB9,
                0xEF,
                0x18,
                0xD3,
                0x46,
                0xB3,
                0xAF,
                0x69,
                0x37,
                0x2F,
                0x94,
                0xD9,
                0xB2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_ISO_GAINS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0x2A,
                0x80,
                0x05,
                0x1D,
                0x0E,
                0xC7,
                0x41,
                0xA8,
                0xC8,
                0x7E,
                0x73,
                0x69,
                0xF8,
                0x4E,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_SENSORFRAMERATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x35,
                0x51,
                0xDB,
                0x3D,
                0x9D,
                0x62,
                0x49,
                0xB0,
                0x6D,
                0x07,
                0xCE,
                0x65,
                0x0D,
                0x9A,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_WHITEBALANCE_GAINS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x0C,
                0x57,
                0xE7,
                0xCB,
                0x2D,
                0x7C,
                0x4C,
                0xAA,
                0xCE,
                0x22,
                0xEC,
                0xE7,
                0xCC,
                0xE6,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_HISTOGRAM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x32,
                0x84,
                0x35,
                0x85,
                0xF6,
                0x2E,
                0xA9,
                0x4B,
                0xA3,
                0xFB,
                0x06,
                0xD8,
                0x29,
                0x74,
                0xB8,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_EXIF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0x75,
                0x95,
                0x2E,
                0x31,
                0x8C,
                0x02,
                0x4A,
                0x85,
                0x75,
                0x42,
                0xB1,
                0x97,
                0xB7,
                0x15,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_FRAME_ILLUMINATION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0x8F,
                0x68,
                0x6D,
                0xD3,
                0x63,
                0xFE,
                0x46,
                0xBA,
                0xDA,
                0x5B,
                0x94,
                0x7D,
                0xB0,
                0xD0,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_UVC_PAYLOADHEADER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x8A,
                0xF8,
                0xF9,
                0xDD,
                0xE1,
                0x1E,
                0x44,
                0x95,
                0xCB,
                0x42,
                0xE2,
                0x1A,
                0x64,
                0xF1,
                0xD9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_FIRST_SCANLINE_START_TIME_QPC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x49,
                0x2C,
                0x6A,
                0x52,
                0xE0,
                0xB6,
                0x46,
                0xB2,
                0xD9,
                0x73,
                0xC1,
                0x55,
                0x87,
                0x09,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_LAST_SCANLINE_END_TIME_QPC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0xDE,
                0xCA,
                0xDC,
                0xD4,
                0xC4,
                0x0D,
                0x40,
                0xB4,
                0x18,
                0x10,
                0xE8,
                0x85,
                0x25,
                0xE1,
                0xF6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_SCANLINE_TIME_QPC_ACCURACY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0x9C,
                0xD7,
                0x4C,
                0x65,
                0xF7,
                0x09,
                0x4B,
                0xB1,
                0xE1,
                0x27,
                0xD1,
                0xF7,
                0xEB,
                0xEA,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_SCANLINE_DIRECTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0xA3,
                0x96,
                0x64,
                0x07,
                0x19,
                0xE6,
                0x49,
                0xB0,
                0xC3,
                0x12,
                0x37,
                0x95,
                0xF3,
                0x80,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_DIGITALWINDOW
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x72,
                0x6F,
                0x27,
                0xC8,
                0x59,
                0x69,
                0x4F,
                0x97,
                0xB4,
                0x06,
                0x8B,
                0x8C,
                0x0E,
                0xC0,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_CAPTURE_METADATA_FRAME_BACKGROUND_MASK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0x4D,
                0xF1,
                0x03,
                0xDD,
                0x75,
                0x3A,
                0x43,
                0xA8,
                0xE2,
                0x1E,
                0x3F,
                0x5F,
                0x2A,
                0x50,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MAJOR_TYPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8E,
                0xA1,
                0xEB,
                0x48,
                0xC9,
                0xF8,
                0x87,
                0x46,
                0xBF,
                0x11,
                0x0A,
                0x74,
                0xC9,
                0xF9,
                0x6A,
                0x8F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_SUBTYPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0x4C,
                0xE3,
                0xF7,
                0xE8,
                0x42,
                0x14,
                0x47,
                0xB7,
                0x4B,
                0xCB,
                0x29,
                0xD7,
                0x2C,
                0x35,
                0xE5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_ALL_SAMPLES_INDEPENDENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x37,
                0x17,
                0xC9,
                0x56,
                0x5E,
                0x1C,
                0x46,
                0xB7,
                0x13,
                0x46,
                0xFB,
                0x99,
                0x5C,
                0xB9,
                0x5F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_FIXED_SIZE_SAMPLES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0xEF,
                0xEB,
                0xB8,
                0x18,
                0xB7,
                0x04,
                0x4E,
                0xB0,
                0xA9,
                0x11,
                0x67,
                0x75,
                0xE3,
                0x32,
                0x1B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_COMPRESSED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0x0C,
                0xFD,
                0x3A,
                0xF2,
                0x18,
                0xA5,
                0x4B,
                0xA1,
                0x10,
                0x8B,
                0xEA,
                0x50,
                0x2E,
                0x1F,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_SAMPLE_SIZE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
                0xAB,
                0xD3,
                0xDA,
                0x90,
                0x19,
                0x8B,
                0x40,
                0xBC,
                0xE2,
                0xEB,
                0xA6,
                0x73,
                0xDA,
                0xCC,
                0x10,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_WRAPPED_TYPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0x7B,
                0x3F,
                0x4D,
                0x2F,
                0xD0,
                0x6C,
                0x4E,
                0x9B,
                0xEE,
                0xE4,
                0xBF,
                0x2C,
                0x6C,
                0x69,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_VIDEO_3D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCF,
                0x88,
                0x5E,
                0xCB,
                0x5B,
                0x7B,
                0x6B,
                0x47,
                0x85,
                0xAA,
                0x1C,
                0xA5,
                0xAE,
                0x18,
                0x75,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_VIDEO_3D_FORMAT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0xD8,
                0x15,
                0x53,
                0xC5,
                0x87,
                0x97,
                0x46,
                0xB7,
                0x93,
                0x66,
                0x06,
                0xC6,
                0x7C,
                0x04,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_VIDEO_3D_NUM_VIEWS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0x7E,
                0x07,
                0xBB,
                0xBF,
                0xDC,
                0xEB,
                0x42,
                0xAF,
                0x60,
                0x41,
                0x8D,
                0xF9,
                0x8A,
                0xA4,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_VIDEO_3D_LEFT_IS_BASE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0x7B,
                0x4B,
                0x6D,
                0x29,
                0x56,
                0x04,
                0x44,
                0x94,
                0x8C,
                0xC6,
                0x34,
                0xF4,
                0xCE,
                0x26,
                0xD4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_VIDEO_3D_FIRST_IS_LEFT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0x84,
                0x29,
                0xEC,
                0xDA,
                0x0A,
                0xA1,
                0x4E,
                0xA4,
                0xFE,
                0xCB,
                0xBD,
                0x36,
                0xCE,
                0x93,
                0x31,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_VIDEO_ROTATION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x46,
                0x80,
                0xC3,
                0x71,
                0x22,
                0x8C,
                0x42,
                0x9B,
                0x83,
                0xEC,
                0xEA,
                0x3B,
                0x4A,
                0x85,
                0xC1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_DEVICESTREAM_MULTIPLEXED_MANAGER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0x42,
                0xA5,
                0x6E,
                0x1F,
                0x28,
                0x31,
                0x42,
                0xA4,
                0x64,
                0xFE,
                0x2F,
                0x50,
                0x22,
                0x50,
                0x1C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MEDIATYPE_MULTIPLEXED_MANAGER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0x8F,
                0xC7,
                0x13,
                0x75,
                0xF2,
                0xA0,
                0x4E,
                0xBB,
                0x5F,
                0x02,
                0x49,
                0x83,
                0x2B,
                0x0D,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_SECURE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0xC4,
                0xAC,
                0xC5,
                0x04,
                0x03,
                0xCF,
                0x4E,
                0x80,
                0x9F,
                0x47,
                0xBC,
                0x97,
                0xFF,
                0x63,
                0xBD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_DEVICESTREAM_ATTRIBUTE_FRAMESOURCE_TYPES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x5F,
                0x14,
                0x17,
                0x2B,
                0x1B,
                0x3C,
                0x42,
                0x80,
                0x01,
                0x2B,
                0x68,
                0x33,
                0xED,
                0x35,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_ALPHA_MODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0x9B,
                0x95,
                0x5D,
                0xBF,
                0x4C,
                0x04,
                0x4D,
                0x91,
                0x9F,
                0x3F,
                0x5F,
                0x7F,
                0x28,
                0x42,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_DEPTH_MEASUREMENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0xC4,
                0x5A,
                0xFD,
                0x17,
                0x09,
                0xB6,
                0x4B,
                0x9D,
                0x54,
                0x31,
                0x22,
                0xBF,
                0x70,
                0x14,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_DEPTH_VALUE_UNIT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF5,
                0x00,
                0xA8,
                0x21,
                0x89,
                0x31,
                0x97,
                0x47,
                0xBE,
                0xBA,
                0xF1,
                0x3C,
                0xD9,
                0xA3,
                0x1A,
                0x5E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_VIDEO_NO_FRAME_ORDERING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0x10,
                0x5B,
                0x3F,
                0xC2,
                0x6B,
                0xE3,
                0x4E,
                0xB7,
                0xED,
                0x89,
                0x02,
                0xC1,
                0x8F,
                0x53,
                0x51,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_VIDEO_H264_NO_FMOASO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0x1C,
                0x46,
                0xED,
                0x9F,
                0xEC,
                0x6A,
                0x41,
                0xA8,
                0xA3,
                0x26,
                0xD7,
                0xD3,
                0x10,
                0x18,
                0xD7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_FORWARD_CUSTOM_NALU
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0x6E,
                0x33,
                0xED,
                0x4F,
                0x24,
                0x8D,
                0x42,
                0x91,
                0x53,
                0x28,
                0xF3,
                0x99,
                0x45,
                0x88,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_FORWARD_CUSTOM_SEI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x62,
                0x73,
                0xE2,
                0x36,
                0xB1,
                0xD1,
                0x41,
                0x95,
                0x94,
                0x3A,
                0x7E,
                0x4F,
                0xEB,
                0xF2,
                0xD1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_VIDEO_RENDERER_EXTENSION_PROFILE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB9,
                0xD4,
                0x37,
                0x84,
                0x48,
                0xD4,
                0xCD,
                0x4F,
                0x9B,
                0x6B,
                0x83,
                0x9B,
                0xF9,
                0x6C,
                0x77,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_DECODER_FWD_CUSTOM_SEI_DECODE_ORDER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xBE,
                0x3B,
                0xF1,
                0xD4,
                0x36,
                0x0A,
                0x41,
                0xB9,
                0x85,
                0x7A,
                0x95,
                0x1A,
                0x1E,
                0x62,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_VIDEO_RENDERER_EFFECT_APP_SERVICE_NAME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x2A,
                0x05,
                0xC6,
                0x9C,
                0x6D,
                0xA3,
                0x40,
                0x9D,
                0xB8,
                0xF0,
                0x27,
                0xA2,
                0x5C,
                0x9A,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AUDIO_NUM_CHANNELS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF5,
                0x8B,
                0xE4,
                0x37,
                0x5E,
                0x64,
                0x5B,
                0x4C,
                0x89,
                0xDE,
                0xAD,
                0xA9,
                0xE2,
                0x9B,
                0x69,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AUDIO_SAMPLES_PER_SECOND
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0xEA,
                0xAE,
                0x5F,
                0x90,
                0x02,
                0x31,
                0x4C,
                0x9E,
                0x8A,
                0xC5,
                0x34,
                0xF6,
                0x8D,
                0x9D,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AUDIO_FLOAT_SAMPLES_PER_SECOND
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0x72,
                0x3B,
                0xFB,
                0xB5,
                0xCF,
                0x19,
                0x43,
                0xAE,
                0xFE,
                0x6E,
                0x42,
                0xB2,
                0x40,
                0x61,
                0x32,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AUDIO_AVG_BYTES_PER_SECOND
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x75,
                0xAB,
                0x1A,
                0xEF,
                0xCF,
                0x1C,
                0x45,
                0xAB,
                0x95,
                0xAC,
                0x03,
                0x4B,
                0x8E,
                0x17,
                0x31,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AUDIO_BLOCK_ALIGNMENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xE2,
                0x2D,
                0x32,
                0xEB,
                0x9E,
                0xBD,
                0x43,
                0xAB,
                0x7A,
                0xFF,
                0x41,
                0x22,
                0x51,
                0x54,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AUDIO_BITS_PER_SAMPLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0xB5,
                0xDE,
                0xF2,
                0xFA,
                0x40,
                0x64,
                0x47,
                0xAA,
                0x33,
                0xED,
                0x4F,
                0x2D,
                0x1F,
                0xF6,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AUDIO_VALID_BITS_PER_SAMPLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0x8D,
                0xBF,
                0xD9,
                0x30,
                0x95,
                0x7C,
                0x4B,
                0x9D,
                0xDF,
                0xFF,
                0x6F,
                0xD5,
                0x8B,
                0xBD,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AUDIO_SAMPLES_PER_BLOCK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0x5A,
                0xB1,
                0xAA,
                0x3A,
                0xE1,
                0x95,
                0x49,
                0x92,
                0x22,
                0x50,
                0x1E,
                0xA1,
                0x5C,
                0x68,
                0x77,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AUDIO_CHANNEL_MASK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0x57,
                0xFB,
                0x55,
                0x4A,
                0x64,
                0xAF,
                0x4C,
                0x84,
                0x79,
                0x93,
                0x89,
                0x83,
                0xBB,
                0x15,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AUDIO_FOLDDOWN_MATRIX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0x92,
                0x62,
                0x9D,
                0xBE,
                0x36,
                0xF2,
                0x4C,
                0xB5,
                0xC4,
                0xA3,
                0x92,
                0x6E,
                0x3E,
                0x87,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AUDIO_WMADRC_PEAKREF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0x92,
                0x62,
                0x9D,
                0xBE,
                0x36,
                0xF2,
                0x4C,
                0xB5,
                0xC4,
                0xA3,
                0x92,
                0x6E,
                0x3E,
                0x87,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AUDIO_WMADRC_PEAKTARGET
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x92,
                0x62,
                0x9D,
                0xBE,
                0x36,
                0xF2,
                0x4C,
                0xB5,
                0xC4,
                0xA3,
                0x92,
                0x6E,
                0x3E,
                0x87,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AUDIO_WMADRC_AVGREF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0x92,
                0x62,
                0x9D,
                0xBE,
                0x36,
                0xF2,
                0x4C,
                0xB5,
                0xC4,
                0xA3,
                0x92,
                0x6E,
                0x3E,
                0x87,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AUDIO_WMADRC_AVGTARGET
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x92,
                0x62,
                0x9D,
                0xBE,
                0x36,
                0xF2,
                0x4C,
                0xB5,
                0xC4,
                0xA3,
                0x92,
                0x6E,
                0x3E,
                0x87,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AUDIO_PREFER_WAVEFORMATEX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0xAA,
                0x01,
                0xA9,
                0x37,
                0xE0,
                0x8A,
                0x45,
                0xBD,
                0xF6,
                0x54,
                0x5B,
                0xE2,
                0x07,
                0x40,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AAC_PAYLOAD_TYPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0xBE,
                0xBA,
                0xBF,
                0x34,
                0x74,
                0x1C,
                0x4D,
                0x94,
                0xF0,
                0x72,
                0xA3,
                0xB9,
                0xE1,
                0x71,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AAC_AUDIO_PROFILE_LEVEL_INDICATION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0xF0,
                0x32,
                0x76,
                0x38,
                0x95,
                0x61,
                0x4D,
                0xAC,
                0xDA,
                0xEA,
                0x29,
                0xC8,
                0xC1,
                0x44,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AUDIO_FLAC_MAX_BLOCK_SIZE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAE,
                0xAD,
                0x81,
                0x8B,
                0x5A,
                0x4B,
                0x40,
                0x4D,
                0x80,
                0x22,
                0xF3,
                0x8D,
                0x09,
                0xCA,
                0x3C,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_SPATIAL_AUDIO_MAX_DYNAMIC_OBJECTS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0xA2,
                0xFB,
                0xDC,
                0x09,
                0x26,
                0x40,
                0x42,
                0xA7,
                0x21,
                0x3F,
                0xAE,
                0xA7,
                0x6A,
                0x4D,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_SPATIAL_AUDIO_OBJECT_METADATA_FORMAT_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x1B,
                0xB7,
                0x2A,
                0x23,
                0x62,
                0xA7,
                0x4B,
                0xAD,
                0x64,
                0x7B,
                0x94,
                0xB4,
                0x7A,
                0xE7,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_SPATIAL_AUDIO_OBJECT_METADATA_LENGTH
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0xA8,
                0x4B,
                0x09,
                0x23,
                0xD7,
                0x9F,
                0x48,
                0x92,
                0xFA,
                0x76,
                0x67,
                0x77,
                0xB3,
                0x47,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_SPATIAL_AUDIO_MAX_METADATA_ITEMS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0x80,
                0xAA,
                0x11,
                0xDA,
                0xE0,
                0xC6,
                0x47,
                0x80,
                0x60,
                0x96,
                0xC1,
                0x25,
                0x9A,
                0xE5,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_SPATIAL_AUDIO_MIN_METADATA_ITEM_OFFSET_SPACING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0x6E,
                0xE9,
                0x83,
                0x84,
                0x11,
                0x7E,
                0x41,
                0x82,
                0x54,
                0x9F,
                0x26,
                0x91,
                0x58,
                0xFC,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_SPATIAL_AUDIO_DATA_PRESENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0xF6,
                0x42,
                0x68,
                0x3E,
                0xD4,
                0xBB,
                0x4E,
                0x9C,
                0x9C,
                0xC9,
                0x6F,
                0x41,
                0x78,
                0x48,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_SPATIAL_AUDIO_IS_PREVIRTUALIZED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0xAB,
                0xAC,
                0x4E,
                0xE5,
                0xFF,
                0x1A,
                0x42,
                0xA2,
                0xA7,
                0x8B,
                0x74,
                0x09,
                0xA1,
                0xCA,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MPEGH_AUDIO_PROFILE_LEVEL_INDICATION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x7A,
                0x26,
                0x51,
                0x0C,
                0xDD,
                0xB9,
                0x4B,
                0xA7,
                0xBD,
                0x91,
                0x73,
                0xAD,
                0x4B,
                0x13,
                0x1C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_FRAME_SIZE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0xC3,
                0x52,
                0x16,
                0xB2,
                0xD6,
                0x12,
                0x40,
                0xB8,
                0x34,
                0x72,
                0x03,
                0x08,
                0x49,
                0xA3,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_FRAME_RATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0xA2,
                0x59,
                0xC4,
                0x2C,
                0x3D,
                0x44,
                0x4E,
                0xB1,
                0x32,
                0xFE,
                0xE5,
                0x15,
                0x6C,
                0x7B,
                0xB0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_PIXEL_ASPECT_RATIO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0x6A,
                0x37,
                0xC6,
                0x0A,
                0x8D,
                0x27,
                0x40,
                0xBE,
                0x45,
                0x6D,
                0x9A,
                0x0A,
                0xD3,
                0x9B,
                0xB6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_DRM_FLAGS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0xF3,
                0x72,
                0x87,
                0x5A,
                0x35,
                0xC7,
                0x4C,
                0xBB,
                0x78,
                0x6D,
                0x61,
                0xA0,
                0x48,
                0xAE,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_TIMESTAMP_CAN_BE_DTS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0x42,
                0x97,
                0x24,
                0x7B,
                0x1B,
                0xE4,
                0x41,
                0x86,
                0x25,
                0xAC,
                0x46,
                0x9F,
                0x2D,
                0xED,
                0xAA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_PAD_CONTROL_FLAGS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x73,
                0x0E,
                0x4D,
                0xEA,
                0x80,
                0x54,
                0x43,
                0xA9,
                0xD0,
                0x11,
                0x76,
                0xCE,
                0xB0,
                0x28,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_SOURCE_CONTENT_HINT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCC,
                0xA3,
                0xAC,
                0x68,
                0xD0,
                0x22,
                0xE6,
                0x44,
                0x85,
                0xF8,
                0x28,
                0x16,
                0x71,
                0x97,
                0xFA,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_VIDEO_CHROMA_SITING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0x23,
                0xDF,
                0x65,
                0x73,
                0xC7,
                0x33,
                0x4C,
                0xAA,
                0x64,
                0x84,
                0x3E,
                0x06,
                0x8E,
                0xFB,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_INTERLACE_MODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0x4B,
                0x72,
                0xE2,
                0x76,
                0xE6,
                0x06,
                0x48,
                0xB4,
                0xB2,
                0xA8,
                0xD6,
                0xEF,
                0xB4,
                0x4C,
                0xCD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_TRANSFER_FUNCTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE9,
                0xFC,
                0xB0,
                0x5F,
                0x5C,
                0xBE,
                0x35,
                0x49,
                0xA8,
                0x11,
                0xEC,
                0x83,
                0x8F,
                0x8E,
                0xED,
                0x93,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_VIDEO_PRIMARIES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0xE4,
                0xFB,
                0xDB,
                0x40,
                0x07,
                0xE0,
                0x4E,
                0x81,
                0x92,
                0x85,
                0x0A,
                0xB0,
                0xE2,
                0x19,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MAX_LUMINANCE_LEVEL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0x31,
                0x25,
                0x50,
                0x10,
                0xC1,
                0xE4,
                0x4D,
                0x98,
                0xAE,
                0x46,
                0xA3,
                0x24,
                0xFA,
                0xE6,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MAX_FRAME_AVERAGE_LUMINANCE_LEVEL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0xBF,
                0xD4,
                0x58,
                0x52,
                0x6F,
                0x33,
                0x47,
                0xA1,
                0x95,
                0xA9,
                0xE2,
                0x9E,
                0xCF,
                0x9E,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MAX_MASTERING_LUMINANCE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x97,
                0xB9,
                0xC6,
                0xD6,
                0x2F,
                0x27,
                0xA1,
                0x4C,
                0x8D,
                0x00,
                0x80,
                0x42,
                0x11,
                0x1A,
                0x0F,
                0xF6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MIN_MASTERING_LUMINANCE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0x44,
                0x9A,
                0x83,
                0x7E,
                0x4E,
                0x4F,
                0x4B,
                0xAE,
                0x79,
                0xCC,
                0x08,
                0x90,
                0x5C,
                0x7B,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_DECODER_USE_MAX_RESOLUTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x7C,
                0x54,
                0x4C,
                0x9A,
                0xAF,
                0x38,
                0x4F,
                0x96,
                0xAD,
                0x97,
                0x87,
                0x73,
                0xCF,
                0x53,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_DECODER_MAX_DPB_COUNT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x14,
                0xBE,
                0x67,
                0xB7,
                0x88,
                0xA9,
                0x4C,
                0x96,
                0x28,
                0xC8,
                0x08,
                0xD5,
                0x26,
                0x22,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_CUSTOM_VIDEO_PRIMARIES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x13,
                0x72,
                0x53,
                0x47,
                0xFB,
                0x8C,
                0x22,
                0x47,
                0xAA,
                0x34,
                0xFB,
                0xC9,
                0xE2,
                0x4D,
                0x77,
                0xB8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_YUV_MATRIX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0xD4,
                0x23,
                0x3E,
                0x75,
                0x2C,
                0x25,
                0x4D,
                0xA0,
                0x0E,
                0xB9,
                0x16,
                0x70,
                0xD1,
                0x23,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_VIDEO_LIGHTING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0x52,
                0xA0,
                0x53,
                0x0B,
                0x89,
                0x16,
                0x42,
                0x8B,
                0xF9,
                0x59,
                0x93,
                0x67,
                0xAD,
                0x6D,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_VIDEO_NOMINAL_RANGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x8E,
                0x1B,
                0xC2,
                0x56,
                0xB9,
                0x71,
                0x40,
                0x8D,
                0xAF,
                0x32,
                0x5E,
                0xDF,
                0x5C,
                0xAB,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_GEOMETRIC_APERTURE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x87,
                0x75,
                0x66,
                0x5F,
                0x7E,
                0x0D,
                0x40,
                0x98,
                0x0A,
                0xAA,
                0x85,
                0x96,
                0xC8,
                0x56,
                0x96,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MINIMUM_DISPLAY_APERTURE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x87,
                0x38,
                0xD7,
                0xFE,
                0x18,
                0xC6,
                0x48,
                0xA1,
                0x77,
                0xEE,
                0x89,
                0x48,
                0x67,
                0xC8,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_PAN_SCAN_APERTURE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x4D,
                0x61,
                0x79,
                0x87,
                0x91,
                0xFB,
                0x48,
                0xB8,
                0xC7,
                0x4D,
                0x52,
                0x68,
                0x9D,
                0xE6,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_PAN_SCAN_ENABLED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x6B,
                0x7F,
                0x4B,
                0x13,
                0x8B,
                0xB2,
                0x40,
                0xA9,
                0x93,
                0xAB,
                0xF6,
                0x30,
                0xB8,
                0x20,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AVG_BITRATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x26,
                0x33,
                0x20,
                0x0D,
                0xFB,
                0x9E,
                0x4D,
                0xBD,
                0x0D,
                0xCB,
                0xF6,
                0x78,
                0x6C,
                0x10,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AVG_BIT_ERROR_RATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xAB,
                0x9C,
                0x79,
                0x08,
                0x35,
                0xB4,
                0x4D,
                0xA3,
                0xC7,
                0x56,
                0x9C,
                0xD5,
                0x33,
                0xDE,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MAX_KEYFRAME_SPACING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0xB5,
                0x6E,
                0xC1,
                0xA1,
                0x73,
                0x6F,
                0x47,
                0x8D,
                0x62,
                0x83,
                0x9D,
                0x6A,
                0x02,
                0x06,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_USER_DATA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0x76,
                0xBC,
                0xB6,
                0x3B,
                0x4C,
                0xA4,
                0x40,
                0xBD,
                0x51,
                0x25,
                0x35,
                0xB6,
                0x6F,
                0xE0,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_OUTPUT_BUFFER_NUM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0xD3,
                0x05,
                0xA5,
                0x30,
                0xF9,
                0x6E,
                0x43,
                0x8E,
                0xDE,
                0x93,
                0xA5,
                0x09,
                0xCE,
                0x23,
                0xB2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_REALTIME_CONTENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0xD2,
                0x12,
                0xBB,
                0xDB,
                0x2B,
                0x5E,
                0x42,
                0x91,
                0xEC,
                0x23,
                0x08,
                0xE1,
                0x89,
                0xA5,
                0x8F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_DEFAULT_STRIDE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x4E,
                0x4B,
                0x64,
                0x02,
                0x1E,
                0x16,
                0x45,
                0xB0,
                0xEB,
                0xC0,
                0x1C,
                0xA9,
                0xD4,
                0x9A,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_PALETTE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0x3F,
                0x28,
                0x6D,
                0x46,
                0x98,
                0x10,
                0x44,
                0xAF,
                0xD9,
                0x65,
                0x4D,
                0x50,
                0x3B,
                0x1A,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_AM_FORMAT_TYPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2D,
                0x07,
                0xD1,
                0x73,
                0x70,
                0x18,
                0x74,
                0x41,
                0xA0,
                0x63,
                0x29,
                0xFF,
                0x4F,
                0xF6,
                0xC1,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_VIDEO_PROFILE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0B,
                0xA8,
                0x76,
                0xAD,
                0x5C,
                0x2D,
                0x0B,
                0x4E,
                0xB3,
                0x75,
                0x64,
                0xE5,
                0x20,
                0x13,
                0x70,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_VIDEO_LEVEL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x65,
                0xF6,
                0x96,
                0xC5,
                0x11,
                0x15,
                0x40,
                0x86,
                0x66,
                0xBF,
                0xF5,
                0x16,
                0x43,
                0x6D,
                0xA7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MPEG_START_TIME_CODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x78,
                0xF6,
                0x91,
                0x33,
                0x43,
                0x80,
                0x42,
                0x97,
                0xCD,
                0xBD,
                0x5A,
                0x6C,
                0x03,
                0xA0,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MPEG2_PROFILE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0B,
                0xA8,
                0x76,
                0xAD,
                0x5C,
                0x2D,
                0x0B,
                0x4E,
                0xB3,
                0x75,
                0x64,
                0xE5,
                0x20,
                0x13,
                0x70,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MPEG2_LEVEL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x65,
                0xF6,
                0x96,
                0xC5,
                0x11,
                0x15,
                0x40,
                0x86,
                0x66,
                0xBF,
                0xF5,
                0x16,
                0x43,
                0x6D,
                0xA7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MPEG2_FLAGS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1D,
                0x99,
                0xE3,
                0x31,
                0x01,
                0xF7,
                0x2F,
                0x4B,
                0xB4,
                0x26,
                0x8A,
                0xE3,
                0xBD,
                0xA9,
                0xE0,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MPEG_SEQUENCE_HEADER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0x6D,
                0x03,
                0x3C,
                0xD0,
                0x3A,
                0x9E,
                0x4C,
                0x92,
                0x16,
                0xEE,
                0x6D,
                0x6A,
                0xC2,
                0x1C,
                0xB3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MPEG2_STANDARD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0xF9,
                0x0A,
                0xA2,
                0x8A,
                0x92,
                0x26,
                0x4B,
                0xAA,
                0xA9,
                0xF0,
                0x5C,
                0x74,
                0xCA,
                0xC4,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MPEG2_TIMECODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0xBA,
                0x29,
                0x52,
                0x9D,
                0xE2,
                0x80,
                0x4F,
                0xA5,
                0x9C,
                0xDF,
                0x4F,
                0x18,
                0x02,
                0x07,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MPEG2_CONTENT_PACKET
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x55,
                0x5D,
                0x82,
                0x12,
                0x4F,
                0x97,
                0x41,
                0x9E,
                0xB3,
                0x59,
                0xB6,
                0xE4,
                0x71,
                0x0F,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MPEG2_ONE_FRAME_PER_PACKET
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0x9E,
                0xA4,
                0x91,
                0x20,
                0x1D,
                0x42,
                0x4B,
                0xAC,
                0xE8,
                0x80,
                0x42,
                0x69,
                0xBF,
                0x95,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MPEG2_HDCP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0x1B,
                0x8F,
                0x16,
                0x91,
                0x3E,
                0x0F,
                0x45,
                0xAE,
                0xA7,
                0xE4,
                0xBA,
                0xEA,
                0xDA,
                0xE5,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_H264_MAX_CODEC_CONFIG_DELAY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x99,
                0x92,
                0xF5,
                0x45,
                0x4C,
                0xBB,
                0x4F,
                0xBB,
                0x49,
                0x6C,
                0xC5,
                0x34,
                0xD0,
                0x5B,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_H264_SUPPORTED_SLICE_MODES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x19,
                0xBE,
                0xC8,
                0x64,
                0x4D,
                0x49,
                0x45,
                0x83,
                0x43,
                0xA8,
                0x08,
                0x6C,
                0x0B,
                0xFD,
                0xA5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_H264_SUPPORTED_SYNC_FRAME_TYPES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0x2C,
                0xA5,
                0x89,
                0x82,
                0xF2,
                0xD2,
                0x48,
                0xB5,
                0x22,
                0x22,
                0xE6,
                0xAE,
                0x63,
                0x31,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_H264_RESOLUTION_SCALING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0x42,
                0x85,
                0xE3,
                0x15,
                0xF7,
                0x57,
                0x47,
                0xBA,
                0x90,
                0x1B,
                0x69,
                0x6C,
                0x77,
                0x34,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_H264_SIMULCAST_SUPPORT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0xD6,
                0xA2,
                0x9E,
                0xF0,
                0x53,
                0x34,
                0x4A,
                0xB9,
                0x4E,
                0x9D,
                0xE4,
                0x9A,
                0x07,
                0x8C,
                0xB3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_H264_SUPPORTED_RATE_CONTROL_MODES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0xC4,
                0x8A,
                0x6A,
                0x9C,
                0x51,
                0x18,
                0x4F,
                0x9B,
                0xB3,
                0x7E,
                0xEA,
                0xAE,
                0xA5,
                0x59,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_H264_MAX_MB_PER_SEC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0x6D,
                0x25,
                0x45,
                0x15,
                0x72,
                0x76,
                0x45,
                0x93,
                0x36,
                0xB0,
                0xF1,
                0xBC,
                0xD5,
                0x9B,
                0xB2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_H264_SUPPORTED_USAGES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x98,
                0xA9,
                0xB1,
                0x60,
                0x01,
                0xDC,
                0xCE,
                0x40,
                0x97,
                0x36,
                0xAB,
                0xA8,
                0x45,
                0xA2,
                0xDB,
                0xDC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_H264_CAPABILITIES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0xD5,
                0x3B,
                0xBB,
                0x0A,
                0x49,
                0xE0,
                0x11,
                0x99,
                0xE4,
                0x13,
                0x16,
                0xDF,
                0xD7,
                0x20,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_H264_SVC_CAPABILITIES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0x3A,
                0x99,
                0xF8,
                0x37,
                0xD9,
                0x8F,
                0x4A,
                0xBB,
                0xCA,
                0x69,
                0x66,
                0xFE,
                0x9E,
                0x11,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_H264_USAGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA5,
                0xE3,
                0x9C,
                0x35,
                0x00,
                0xAF,
                0xCA,
                0x49,
                0xA2,
                0xF4,
                0x2A,
                0xC9,
                0x4C,
                0xA8,
                0x2B,
                0x61,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_H264_RATE_CONTROL_MODES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x77,
                0x51,
                0x70,
                0xCB,
                0x45,
                0xE0,
                0x11,
                0xAC,
                0x7D,
                0xB9,
                0x1C,
                0xE0,
                0xD7,
                0x20,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_H264_LAYOUT_PER_STREAM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0x99,
                0xE2,
                0x85,
                0xE3,
                0x90,
                0xE8,
                0x4F,
                0xB2,
                0xF5,
                0xC0,
                0x67,
                0xE0,
                0xBF,
                0xE5,
                0x7A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_IN_BAND_PARAMETER_SET
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x50,
                0xDA,
                0x75,
                0x0B,
                0x91,
                0x03,
                0x4A,
                0x89,
                0x6C,
                0x7B,
                0x89,
                0x8F,
                0xEE,
                0xA5,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MPEG4_TRACK_TYPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0x86,
                0xF4,
                0x54,
                0x27,
                0x93,
                0x6D,
                0x4F,
                0x80,
                0xAB,
                0x6F,
                0x70,
                0x9E,
                0xBB,
                0x4C,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_CONTAINER_RATE_SCALING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x7F,
                0x87,
                0x83,
                0x44,
                0x04,
                0x28,
                0x4E,
                0x84,
                0x79,
                0x6D,
                0xB0,
                0x98,
                0x9B,
                0x8C,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_DV_AAUX_SRC_PACK_0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0x5D,
                0xBD,
                0x84,
                0xB8,
                0x0F,
                0xC8,
                0x4A,
                0xBE,
                0x4B,
                0xA8,
                0x84,
                0x8B,
                0xEF,
                0x98,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_DV_AAUX_CTRL_PACK_0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x00,
                0x31,
                0xF7,
                0xD1,
                0x1D,
                0x15,
                0x45,
                0xAA,
                0xBE,
                0xF0,
                0xC0,
                0x6A,
                0xA5,
                0x36,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_DV_AAUX_SRC_PACK_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0x65,
                0x0E,
                0x72,
                0x25,
                0x02,
                0x03,
                0x40,
                0xA6,
                0x51,
                0x01,
                0x96,
                0x56,
                0x3A,
                0x95,
                0x8E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_DV_AAUX_CTRL_PACK_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0x47,
                0x1F,
                0xCD,
                0x04,
                0x1F,
                0xE0,
                0x4F,
                0xBF,
                0xB9,
                0xD0,
                0x7A,
                0xE0,
                0x38,
                0x6A,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_DV_VAUX_SRC_PACK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x2D,
                0x40,
                0x41,
                0x57,
                0x7B,
                0xC6,
                0x43,
                0xB1,
                0x29,
                0x2C,
                0xB9,
                0x97,
                0xF1,
                0x50,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_DV_VAUX_CTRL_PACK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0xE1,
                0x84,
                0x2F,
                0xA1,
                0x0D,
                0x88,
                0x47,
                0x93,
                0x8E,
                0x0D,
                0xFB,
                0xFB,
                0xB3,
                0x4B,
                0x48,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_ARBITRARY_HEADER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF5,
                0xD6,
                0x6B,
                0x9E,
                0x09,
                0x01,
                0x95,
                0x4F,
                0x84,
                0xAC,
                0x93,
                0x09,
                0x15,
                0x3A,
                0x19,
                0xFC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_ARBITRARY_FORMAT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0xB2,
                0x75,
                0x5A,
                0x7D,
                0x0D,
                0xA1,
                0x49,
                0xA1,
                0xC3,
                0xE0,
                0xD8,
                0x7F,
                0x0C,
                0xAD,
                0xE5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_IMAGE_LOSS_TOLERANT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x2C,
                0x06,
                0xED,
                0x4E,
                0xE3,
                0x22,
                0x49,
                0xBE,
                0x99,
                0x93,
                0x40,
                0x32,
                0x13,
                0x3D,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MPEG4_SAMPLE_DESCRIPTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0x9D,
                0x1E,
                0x26,
                0x29,
                0x95,
                0x8F,
                0x4B,
                0xA1,
                0x11,
                0x8B,
                0x9C,
                0x95,
                0x0A,
                0x81,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_MPEG4_CURRENT_SAMPLE_ENTRY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0xE1,
                0xA7,
                0x9A,
                0x4A,
                0xB6,
                0x1D,
                0x4C,
                0xA5,
                0x00,
                0x45,
                0x5D,
                0x60,
                0x0B,
                0x65,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SD_AMBISONICS_SAMPLE3D_DESCRIPTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0xCF,
                0x15,
                0xF7,
                0x64,
                0xA9,
                0x3F,
                0x4C,
                0x94,
                0xAE,
                0x9D,
                0x6B,
                0xA7,
                0x26,
                0x46,
                0x41,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_ORIGINAL_4CC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x3F,
                0xBE,
                0xD7,
                0xC7,
                0x2B,
                0x2D,
                0x49,
                0xB8,
                0x43,
                0x61,
                0xA1,
                0x91,
                0x9B,
                0x70,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_ORIGINAL_WAVE_FORMAT_TAG
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0xC8,
                0xBB,
                0x8C,
                0xD9,
                0x9F,
                0xC2,
                0x49,
                0x88,
                0x2F,
                0xA7,
                0x25,
                0x86,
                0xC4,
                0x08,
                0xAD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_FRAME_RATE_RANGE_MIN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x55,
                0xE7,
                0xD2,
                0x1F,
                0xDC,
                0x3F,
                0x40,
                0x9A,
                0x72,
                0xD2,
                0x8B,
                0xB1,
                0xEB,
                0x3B,
                0x5E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MT_FRAME_RATE_RANGE_MAX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0x1D,
                0x37,
                0xE3,
                0xCF,
                0xB4,
                0x05,
                0x4A,
                0xBD,
                0x4E,
                0x20,
                0xB8,
                0x8B,
                0xB2,
                0xC4,
                0xD6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_LOW_LATENCY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1A,
                0x89,
                0x27,
                0x9C,
                0x7A,
                0xED,
                0xE1,
                0x40,
                0x88,
                0xE8,
                0xB2,
                0x27,
                0x27,
                0xA0,
                0x24,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_VIDEO_MAX_MB_PER_SEC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0xE2,
                0xF2,
                0xE3,
                0x45,
                0xD4,
                0x8C,
                0x4B,
                0x92,
                0x11,
                0xAE,
                0x39,
                0x0D,
                0x3B,
                0xA0,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_DISABLE_FRAME_CORRUPTION_INFO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0xE1,
                0x86,
                0x70,
                0xC5,
                0x49,
                0x01,
                0x42,
                0x88,
                0x2A,
                0x85,
                0x38,
                0xF3,
                0x8C,
                0xF1,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_DEVICESTREAM_ATTRIBUTE_FACEAUTH_CAPABILITY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2A,
                0xD1,
                0x6F,
                0xCB,
                0x48,
                0x22,
                0x41,
                0x4E,
                0xAD,
                0x46,
                0xE7,
                0x8B,
                0xB9,
                0x0A,
                0xB9,
                0xFC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_DEVICESTREAM_ATTRIBUTE_SECURE_CAPABILITY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0xD6,
                0x0F,
                0x94,
                0x6E,
                0xEA,
                0x84,
                0x46,
                0x98,
                0x40,
                0x36,
                0xBD,
                0x6E,
                0xC9,
                0xFB,
                0xEF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define MF_SDK_VERSION 0x0002")]
    public const int MF_SDK_VERSION = 0x0002;

    [NativeTypeName("#define MF_API_VERSION 0x0070")]
    public const int MF_API_VERSION = 0x0070;

    [NativeTypeName("#define MF_VERSION (MF_SDK_VERSION << 16 | MF_API_VERSION)")]
    public const int MF_VERSION = (0x0002 << 16 | 0x0070);

    [NativeTypeName("#define MF_E_DXGI_DEVICE_NOT_INITIALIZED ((HRESULT)0x80041000L)")]
    public const int MF_E_DXGI_DEVICE_NOT_INITIALIZED = unchecked((int)(0x80041000));

    [NativeTypeName("#define MF_E_DXGI_NEW_VIDEO_DEVICE ((HRESULT)0x80041001L)")]
    public const int MF_E_DXGI_NEW_VIDEO_DEVICE = unchecked((int)(0x80041001));

    [NativeTypeName("#define MF_E_DXGI_VIDEO_DEVICE_LOCKED ((HRESULT)0x80041002L)")]
    public const int MF_E_DXGI_VIDEO_DEVICE_LOCKED = unchecked((int)(0x80041002));

    [NativeTypeName("#define MF_1_BYTE_ALIGNMENT 0x00000000")]
    public const int MF_1_BYTE_ALIGNMENT = 0x00000000;

    [NativeTypeName("#define MF_2_BYTE_ALIGNMENT 0x00000001")]
    public const int MF_2_BYTE_ALIGNMENT = 0x00000001;

    [NativeTypeName("#define MF_4_BYTE_ALIGNMENT 0x00000003")]
    public const int MF_4_BYTE_ALIGNMENT = 0x00000003;

    [NativeTypeName("#define MF_8_BYTE_ALIGNMENT 0x00000007")]
    public const int MF_8_BYTE_ALIGNMENT = 0x00000007;

    [NativeTypeName("#define MF_16_BYTE_ALIGNMENT 0x0000000f")]
    public const int MF_16_BYTE_ALIGNMENT = 0x0000000f;

    [NativeTypeName("#define MF_32_BYTE_ALIGNMENT 0x0000001f")]
    public const int MF_32_BYTE_ALIGNMENT = 0x0000001f;

    [NativeTypeName("#define MF_64_BYTE_ALIGNMENT 0x0000003f")]
    public const int MF_64_BYTE_ALIGNMENT = 0x0000003f;

    [NativeTypeName("#define MF_128_BYTE_ALIGNMENT 0x0000007f")]
    public const int MF_128_BYTE_ALIGNMENT = 0x0000007f;

    [NativeTypeName("#define MF_256_BYTE_ALIGNMENT 0x000000ff")]
    public const int MF_256_BYTE_ALIGNMENT = 0x000000ff;

    [NativeTypeName("#define MF_512_BYTE_ALIGNMENT 0x000001ff")]
    public const int MF_512_BYTE_ALIGNMENT = 0x000001ff;

    [NativeTypeName("#define MF_1024_BYTE_ALIGNMENT 0x000003ff")]
    public const int MF_1024_BYTE_ALIGNMENT = 0x000003ff;

    [NativeTypeName("#define MF_2048_BYTE_ALIGNMENT 0x000007ff")]
    public const int MF_2048_BYTE_ALIGNMENT = 0x000007ff;

    [NativeTypeName("#define MF_4096_BYTE_ALIGNMENT 0x00000fff")]
    public const int MF_4096_BYTE_ALIGNMENT = 0x00000fff;

    [NativeTypeName("#define MF_8192_BYTE_ALIGNMENT 0x00001fff")]
    public const int MF_8192_BYTE_ALIGNMENT = 0x00001fff;

    [NativeTypeName("#define MF_METADATAFACIALEXPRESSION_SMILE 0x00000001")]
    public const int MF_METADATAFACIALEXPRESSION_SMILE = 0x00000001;

    [NativeTypeName("#define MF_METADATATIMESTAMPS_DEVICE 0x00000001")]
    public const int MF_METADATATIMESTAMPS_DEVICE = 0x00000001;

    [NativeTypeName("#define MF_METADATATIMESTAMPS_PRESENTATION 0x00000002")]
    public const int MF_METADATATIMESTAMPS_PRESENTATION = 0x00000002;

    [NativeTypeName("#define MF_HISTOGRAM_CHANNEL_Y 0x00000001")]
    public const int MF_HISTOGRAM_CHANNEL_Y = 0x00000001;

    [NativeTypeName("#define MF_HISTOGRAM_CHANNEL_R 0x00000002")]
    public const int MF_HISTOGRAM_CHANNEL_R = 0x00000002;

    [NativeTypeName("#define MF_HISTOGRAM_CHANNEL_G 0x00000004")]
    public const int MF_HISTOGRAM_CHANNEL_G = 0x00000004;

    [NativeTypeName("#define MF_HISTOGRAM_CHANNEL_B 0x00000008")]
    public const int MF_HISTOGRAM_CHANNEL_B = 0x00000008;

    [NativeTypeName("#define MF_HISTOGRAM_CHANNEL_Cb 0x00000010")]
    public const int MF_HISTOGRAM_CHANNEL_Cb = 0x00000010;

    [NativeTypeName("#define MF_HISTOGRAM_CHANNEL_Cr 0x00000020")]
    public const int MF_HISTOGRAM_CHANNEL_Cr = 0x00000020;
}
