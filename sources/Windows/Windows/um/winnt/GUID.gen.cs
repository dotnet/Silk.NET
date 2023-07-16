// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class GUID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MAX_POWER_SAVINGS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x08,
                0x13,
                0x84,
                0xA1,
                0x41,
                0x35,
                0xAB,
                0x4F,
                0xBC,
                0x81,
                0xF7,
                0x15,
                0x56,
                0xF2,
                0x0B,
                0x4A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MIN_POWER_SAVINGS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDA,
                0x7F,
                0x5E,
                0x8C,
                0xBF,
                0xE8,
                0x96,
                0x4A,
                0x9A,
                0x85,
                0xA6,
                0xE2,
                0x3A,
                0x8C,
                0x63,
                0x5C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_TYPICAL_POWER_SAVINGS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0x42,
                0x1B,
                0x38,
                0x94,
                0xF6,
                0xF0,
                0x41,
                0x96,
                0x85,
                0xFF,
                0x5B,
                0xB2,
                0x60,
                0xDF,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_POWERSCHEME_PERSONALITY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0x85,
                0x5D,
                0x24,
                0x43,
                0x39,
                0x22,
                0x44,
                0xB0,
                0x25,
                0x13,
                0xA7,
                0x84,
                0xF6,
                0x79,
                0xB7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ACTIVE_POWERSCHEME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x86,
                0xF2,
                0xF9,
                0x31,
                0x84,
                0x50,
                0xFE,
                0x42,
                0xB7,
                0x20,
                0x2B,
                0x02,
                0x64,
                0x99,
                0x37,
                0x63
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_IDLE_RESILIENCY_SUBGROUP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0x11,
                0x60,
                0x2E,
                0x51,
                0x53,
                0x9D,
                0x4D,
                0x8E,
                0x04,
                0x25,
                0x29,
                0x66,
                0xBA,
                0xD0,
                0x54
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_IDLE_RESILIENCY_PERIOD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAA,
                0x79,
                0x2B,
                0xC4,
                0x3A,
                0xAA,
                0x4B,
                0x48,
                0xA9,
                0x8F,
                0x2C,
                0xF3,
                0x2A,
                0xA9,
                0x0A,
                0x28
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_DEEP_SLEEP_ENABLED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0xF7,
                0x02,
                0xD5,
                0xC7,
                0x1D,
                0xFD,
                0x4E,
                0xA5,
                0x5D,
                0xF0,
                0x4B,
                0x6F,
                0x5C,
                0x05,
                0x45
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_DEEP_SLEEP_PLATFORM_STATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB8,
                0x2F,
                0x3F,
                0xD2,
                0x36,
                0x95,
                0x38,
                0x40,
                0x9C,
                0x94,
                0x1C,
                0xE0,
                0x2E,
                0x5C,
                0x21,
                0x52
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_DISK_COALESCING_POWERDOWN_TIMEOUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB4,
                0x0E,
                0x6F,
                0xC3,
                0x88,
                0x29,
                0x70,
                0x4A,
                0x8E,
                0xEE,
                0x08,
                0x84,
                0xFC,
                0x2C,
                0x24,
                0x33
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_EXECUTION_REQUIRED_REQUEST_TIMEOUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0xBC,
                0x66,
                0x31,
                0x98,
                0x7E,
                0x03,
                0x4E,
                0xB3,
                0x4E,
                0xEC,
                0x0F,
                0x5F,
                0x2B,
                0x21,
                0x8E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_VIDEO_SUBGROUP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5F,
                0xB9,
                0x16,
                0x75,
                0x76,
                0xF7,
                0x64,
                0x44,
                0x8C,
                0x53,
                0x06,
                0x16,
                0x7F,
                0x40,
                0xCC,
                0x99
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_VIDEO_POWERDOWN_TIMEOUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x21,
                0xC0,
                0x0B,
                0x3C,
                0xA8,
                0xC8,
                0x07,
                0x4E,
                0xA9,
                0x73,
                0x6B,
                0x14,
                0xCB,
                0xCB,
                0x2B,
                0x7E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_VIDEO_ANNOYANCE_TIMEOUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2D,
                0xCF,
                0xDB,
                0x82,
                0x67,
                0xCD,
                0xC5,
                0x40,
                0xBF,
                0xDC,
                0x9F,
                0x1A,
                0x5C,
                0xCD,
                0x46,
                0x63
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_VIDEO_ADAPTIVE_PERCENT_INCREASE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0x04,
                0xD9,
                0xEE,
                0x42,
                0xB1,
                0x83,
                0x41,
                0xB1,
                0x0B,
                0x5A,
                0x11,
                0x97,
                0xA3,
                0x78,
                0x64
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_VIDEO_DIM_TIMEOUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9B,
                0xA2,
                0xAA,
                0x17,
                0x43,
                0x8B,
                0x94,
                0x4B,
                0xAA,
                0xFE,
                0x35,
                0xF6,
                0x4D,
                0xAA,
                0xF1,
                0xEE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_VIDEO_ADAPTIVE_POWERDOWN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0x9D,
                0x95,
                0x90,
                0xA1,
                0xD6,
                0xB9,
                0x49,
                0xAF,
                0x93,
                0xBC,
                0xE8,
                0x85,
                0xAD,
                0x33,
                0x5B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MONITOR_POWER_ON
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0x10,
                0x73,
                0x02,
                0x10,
                0x45,
                0x26,
                0x45,
                0x99,
                0xE6,
                0xE5,
                0xA1,
                0x7E,
                0xBD,
                0x1A,
                0xEA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_DEVICE_POWER_POLICY_VIDEO_BRIGHTNESS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0x5E,
                0xED,
                0xAD,
                0x09,
                0xB9,
                0x19,
                0x46,
                0x99,
                0x49,
                0xF5,
                0xD7,
                0x1D,
                0xAC,
                0x0B,
                0xCB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_DEVICE_POWER_POLICY_VIDEO_DIM_BRIGHTNESS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE2,
                0xFD,
                0xFB,
                0xF1,
                0x60,
                0xA9,
                0x65,
                0x41,
                0x9F,
                0x88,
                0x50,
                0x66,
                0x79,
                0x11,
                0xCE,
                0x96
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_VIDEO_CURRENT_MONITOR_BRIGHTNESS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0xE2,
                0xFE,
                0x8F,
                0x01,
                0x2D,
                0xBE,
                0x46,
                0xAD,
                0xB9,
                0x39,
                0x8A,
                0xDD,
                0xC5,
                0xB4,
                0xFF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_VIDEO_ADAPTIVE_DISPLAY_BRIGHTNESS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x66,
                0xAA,
                0xD9,
                0xFB,
                0x53,
                0x95,
                0x97,
                0x40,
                0xBA,
                0x44,
                0xED,
                0x6E,
                0x9D,
                0x65,
                0xEA,
                0xB8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_CONSOLE_DISPLAY_STATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x56,
                0x95,
                0xE6,
                0x6F,
                0x4A,
                0x70,
                0xA0,
                0x47,
                0x8F,
                0x24,
                0xC2,
                0x8D,
                0x93,
                0x6F,
                0xDA,
                0x47
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ALLOW_DISPLAY_REQUIRED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDA,
                0xB8,
                0xCE,
                0xA9,
                0x46,
                0xCD,
                0xFB,
                0x44,
                0xA9,
                0x8B,
                0x02,
                0xAF,
                0x69,
                0xDE,
                0x46,
                0x23
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_VIDEO_CONSOLE_LOCK_TIMEOUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA5,
                0xB3,
                0xC4,
                0x8E,
                0x68,
                0x68,
                0xC2,
                0x48,
                0xBE,
                0x75,
                0x4F,
                0x30,
                0x44,
                0xBE,
                0x88,
                0xA7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ADVANCED_COLOR_QUALITY_BIAS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x69,
                0x3E,
                0x4C,
                0x68,
                0xF7,
                0xA4,
                0x14,
                0x40,
                0x87,
                0x54,
                0xD4,
                0x51,
                0x79,
                0xA5,
                0x61,
                0x67
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ADAPTIVE_POWER_BEHAVIOR_SUBGROUP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0xB9,
                0x19,
                0x86,
                0x04,
                0xE0,
                0xD8,
                0x4D,
                0x9B,
                0x66,
                0xDA,
                0xE8,
                0x6F,
                0x80,
                0x66,
                0x98
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_NON_ADAPTIVE_INPUT_TIMEOUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0xBF,
                0xDB,
                0x5A,
                0x4E,
                0x07,
                0xA1,
                0x4D,
                0xBA,
                0x38,
                0xDB,
                0x8B,
                0x36,
                0xB2,
                0xC8,
                0xF3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ADAPTIVE_INPUT_CONTROLLER_STATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE9,
                0xFA,
                0x98,
                0x0E,
                0x5A,
                0xF4,
                0xE1,
                0x4D,
                0xA7,
                0x57,
                0x60,
                0x31,
                0xF1,
                0x97,
                0xF6,
                0xEA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_DISK_SUBGROUP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x47,
                0xEE,
                0x12,
                0x00,
                0x41,
                0x90,
                0x5D,
                0x4B,
                0x9B,
                0x77,
                0x53,
                0x5F,
                0xBA,
                0x8B,
                0x14,
                0x42
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_DISK_MAX_POWER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x50,
                0xA5,
                0xDE,
                0x51,
                0x38,
                0xBB,
                0xC4,
                0x4B,
                0x99,
                0x1B,
                0xEA,
                0xCF,
                0x37,
                0xBE,
                0x5E,
                0xC8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_DISK_POWERDOWN_TIMEOUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC4,
                0xE2,
                0x38,
                0x67,
                0xA5,
                0xE8,
                0x42,
                0x4A,
                0xB1,
                0x6A,
                0xE0,
                0x40,
                0xE7,
                0x69,
                0x75,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_DISK_IDLE_TIMEOUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA8,
                0x9B,
                0xE3,
                0x58,
                0xE6,
                0xB8,
                0xF6,
                0x4E,
                0x90,
                0xD0,
                0x89,
                0xAE,
                0x32,
                0xB2,
                0x58,
                0xD6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_DISK_BURST_IGNORE_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0xC6,
                0xE3,
                0x80,
                0x94,
                0xBB,
                0xD8,
                0x4A,
                0xBB,
                0xE0,
                0x0D,
                0x31,
                0x95,
                0xEF,
                0xC6,
                0x63
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_DISK_ADAPTIVE_POWERDOWN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE1,
                0x32,
                0x6A,
                0x39,
                0x9A,
                0x49,
                0xB2,
                0x40,
                0x91,
                0x24,
                0xA9,
                0x6A,
                0xFE,
                0x70,
                0x76,
                0x67
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_DISK_NVME_NOPPME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB6,
                0x72,
                0x73,
                0xFC,
                0x2D,
                0xAB,
                0xEE,
                0x43,
                0x87,
                0x97,
                0x15,
                0xE9,
                0x84,
                0x1F,
                0x2C,
                0xCA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_SLEEP_SUBGROUP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA8,
                0x9F,
                0x8C,
                0x23,
                0xAD,
                0x0A,
                0xED,
                0x41,
                0x83,
                0xF4,
                0x97,
                0xBE,
                0x24,
                0x2C,
                0x8F,
                0x20
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_SLEEP_IDLE_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0x32,
                0xCD,
                0x81,
                0x33,
                0x78,
                0xF3,
                0x44,
                0x87,
                0x37,
                0x70,
                0x81,
                0xF3,
                0x8D,
                0x1F,
                0x70
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_STANDBY_TIMEOUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0xC1,
                0xF6,
                0x29,
                0xDA,
                0x86,
                0xC5,
                0x48,
                0x9F,
                0xDB,
                0xF2,
                0xB6,
                0x7B,
                0x1F,
                0x44,
                0xDA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_UNATTEND_SLEEP_TIMEOUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF9,
                0xA2,
                0xC4,
                0x7B,
                0xFC,
                0xD8,
                0x69,
                0x44,
                0xB0,
                0x7B,
                0x33,
                0xEB,
                0x78,
                0x5A,
                0xAC,
                0xA0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_HIBERNATE_TIMEOUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA6,
                0x15,
                0x78,
                0x9D,
                0xE4,
                0x7E,
                0x7E,
                0x49,
                0x88,
                0x88,
                0x51,
                0x5A,
                0x05,
                0xF0,
                0x23,
                0x64
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_HIBERNATE_FASTS4_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x29,
                0x6D,
                0xAC,
                0x94,
                0xCE,
                0x73,
                0xA6,
                0x41,
                0x80,
                0x9F,
                0x63,
                0x63,
                0xBA,
                0x21,
                0xB4,
                0x7E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_CRITICAL_POWER_TRANSITION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x25,
                0x70,
                0xA2,
                0xB7,
                0x69,
                0xE5,
                0xC2,
                0x46,
                0xA5,
                0x04,
                0x2B,
                0x96,
                0xCA,
                0xD2,
                0x25,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_SYSTEM_AWAYMODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0xF5,
                0xA7,
                0x98,
                0xF7,
                0x01,
                0xAA,
                0x48,
                0x9C,
                0x0F,
                0x44,
                0x35,
                0x2C,
                0x29,
                0xE5,
                0xC0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ALLOW_AWAYMODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0xA1,
                0xDF,
                0x25,
                0xD1,
                0x5D,
                0x36,
                0x47,
                0xB5,
                0xAB,
                0xE8,
                0xA3,
                0x7B,
                0x5B,
                0x81,
                0x87
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_USER_PRESENCE_PREDICTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0x17,
                0x01,
                0x82,
                0x95,
                0xFB,
                0x46,
                0x4D,
                0x8D,
                0x35,
                0x40,
                0x42,
                0xB1,
                0xD2,
                0x0D,
                0xEF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_STANDBY_BUDGET_GRACE_PERIOD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE1,
                0x7F,
                0xC0,
                0x60,
                0x56,
                0x05,
                0xCF,
                0x45,
                0x99,
                0x03,
                0xD5,
                0x6E,
                0x32,
                0x21,
                0x02,
                0x42
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_STANDBY_BUDGET_PERCENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBE,
                0x27,
                0xE5,
                0x9F,
                0x70,
                0x1B,
                0xDA,
                0x48,
                0x93,
                0x0D,
                0x7B,
                0xCF,
                0x17,
                0xB4,
                0x49,
                0x90
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_STANDBY_RESERVE_GRACE_PERIOD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x92,
                0xEE,
                0x63,
                0xC7,
                0xE8,
                0x71,
                0x27,
                0x41,
                0x84,
                0xEB,
                0xF6,
                0xED,
                0x04,
                0x3A,
                0x3E,
                0x3D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_STANDBY_RESERVE_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE5,
                0xE7,
                0x8F,
                0x46,
                0x58,
                0x11,
                0xEC,
                0x46,
                0x88,
                0xBC,
                0x5B,
                0x96,
                0xC9,
                0xE4,
                0x4F,
                0xD0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_STANDBY_RESET_PERCENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA5,
                0x11,
                0xCB,
                0x49,
                0xE2,
                0x56,
                0xFB,
                0x4A,
                0x9D,
                0x38,
                0x3D,
                0xF4,
                0x78,
                0x72,
                0xE2,
                0x1B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_HUPR_ADAPTIVE_DISPLAY_TIMEOUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB6,
                0x6A,
                0x7D,
                0x0A,
                0x83,
                0xAC,
                0xD1,
                0x4A,
                0x82,
                0x82,
                0xEC,
                0xA5,
                0xB5,
                0x83,
                0x08,
                0xF3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_HUPR_ADAPTIVE_DIM_TIMEOUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x97,
                0x60,
                0x8C,
                0xCF,
                0xB8,
                0x12,
                0x79,
                0x42,
                0xBB,
                0xDD,
                0x44,
                0x60,
                0x1E,
                0xE5,
                0x20,
                0x9D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ALLOW_STANDBY_STATES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0x25,
                0xFC,
                0xAB,
                0x08,
                0x36,
                0x2A,
                0x4C,
                0x94,
                0xEA,
                0x17,
                0x1B,
                0x0E,
                0xD5,
                0x46,
                0xAB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ALLOW_RTC_WAKE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0x71,
                0x3B,
                0xBD,
                0x80,
                0x06,
                0x9D,
                0x4D,
                0x8A,
                0xB2,
                0xE1,
                0xD2,
                0xB4,
                0xAC,
                0x80,
                0x6D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_LEGACY_RTC_MITIGATION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC3,
                0xBD,
                0x34,
                0x1A,
                0x6B,
                0x7E,
                0x2E,
                0x44,
                0xA9,
                0xD0,
                0x64,
                0xB6,
                0xEF,
                0x37,
                0x8E,
                0x84
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ALLOW_SYSTEM_REQUIRED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF5,
                0x95,
                0xB1,
                0xA4,
                0x25,
                0x82,
                0xD8,
                0x47,
                0x80,
                0x12,
                0x9D,
                0x41,
                0x36,
                0x97,
                0x86,
                0xE2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_POWER_SAVING_STATUS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC0,
                0x58,
                0x09,
                0xE0,
                0x13,
                0xC2,
                0xCE,
                0x4A,
                0xAC,
                0x77,
                0xFE,
                0xCC,
                0xED,
                0x2E,
                0xEE,
                0xA5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ENERGY_SAVER_SUBGROUP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x23,
                0x09,
                0x83,
                0xDE,
                0x62,
                0xA5,
                0xAF,
                0x41,
                0xA0,
                0x86,
                0xE3,
                0xA2,
                0xC6,
                0xBA,
                0xD2,
                0xDA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ENERGY_SAVER_BATTERY_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0x53,
                0x96,
                0xE6,
                0x7F,
                0xCF,
                0x05,
                0x4F,
                0xAA,
                0x73,
                0xCB,
                0x83,
                0x3F,
                0xA9,
                0x0A,
                0xD4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ENERGY_SAVER_BRIGHTNESS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0x98,
                0xD0,
                0x13,
                0x4E,
                0xF7,
                0x4A,
                0x47,
                0xA8,
                0x52,
                0xB6,
                0xBD,
                0xE8,
                0xAD,
                0x03,
                0xA8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ENERGY_SAVER_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0xB3,
                0x5B,
                0x5C,
                0x29,
                0xAD,
                0xE2,
                0x4E,
                0x9D,
                0x0B,
                0x2B,
                0x25,
                0x27,
                0x0F,
                0x7A,
                0x81
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_SYSTEM_BUTTON_SUBGROUP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x89,
                0x1E,
                0x97,
                0x4F,
                0xBD,
                0xEE,
                0x55,
                0x44,
                0xA8,
                0xDE,
                0x9E,
                0x59,
                0x04,
                0x0E,
                0x73,
                0x47
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_POWERBUTTON_ACTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA3,
                0xEF,
                0x48,
                0x76,
                0x9C,
                0xDD,
                0x3E,
                0x4E,
                0xB5,
                0x66,
                0x50,
                0xF9,
                0x29,
                0x38,
                0x62,
                0x80
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_SLEEPBUTTON_ACTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC0,
                0x6B,
                0x99,
                0x96,
                0x50,
                0xAD,
                0xEC,
                0x47,
                0x92,
                0x3B,
                0x6F,
                0x41,
                0x87,
                0x4D,
                0xD9,
                0xEB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_USERINTERFACEBUTTON_ACTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x53,
                0x66,
                0x06,
                0xA7,
                0x6C,
                0x8D,
                0xA8,
                0x40,
                0x91,
                0x0E,
                0xA1,
                0xF5,
                0x4B,
                0x84,
                0xC7,
                0xE5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_LIDCLOSE_ACTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x67,
                0x33,
                0xA8,
                0x5C,
                0x45,
                0x6E,
                0x9F,
                0x45,
                0xA2,
                0x7B,
                0x47,
                0x6B,
                0x1D,
                0x01,
                0xC9,
                0x36
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_LIDOPEN_POWERSTATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE7,
                0x10,
                0xFF,
                0x99,
                0xB1,
                0x23,
                0x07,
                0x4C,
                0xA9,
                0xD1,
                0x5C,
                0x32,
                0x06,
                0xD7,
                0x41,
                0xB4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_BATTERY_SUBGROUP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8D,
                0x04,
                0x3A,
                0xE7,
                0x27,
                0xBF,
                0x12,
                0x4F,
                0x97,
                0x31,
                0x8B,
                0x20,
                0x76,
                0xE8,
                0x89,
                0x1F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_BATTERY_DISCHARGE_ACTION_0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2F,
                0xA0,
                0x7E,
                0x63,
                0xCB,
                0xBB,
                0x15,
                0x40,
                0x8E,
                0x2C,
                0xA1,
                0xC7,
                0xB9,
                0xC0,
                0xB5,
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD7,
                0xD8,
                0x66,
                0x9A,
                0xF7,
                0x4F,
                0xF9,
                0x4E,
                0xB5,
                0xA2,
                0x5A,
                0x32,
                0x6C,
                0xA2,
                0xA4,
                0x69
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9F,
                0x7C,
                0xBB,
                0x5D,
                0xE9,
                0x38,
                0xD2,
                0x40,
                0x97,
                0x49,
                0x4F,
                0x8A,
                0x0E,
                0x9F,
                0x64,
                0x0F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_BATTERY_DISCHARGE_ACTION_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCB,
                0x2D,
                0x74,
                0xD8,
                0x6A,
                0x3E,
                0x3C,
                0x4B,
                0xB3,
                0xFE,
                0x37,
                0x46,
                0x23,
                0xCD,
                0xCF,
                0x06
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9A,
                0xBA,
                0x83,
                0x81,
                0x10,
                0xE9,
                0xDA,
                0x48,
                0x87,
                0x69,
                0x14,
                0xAE,
                0x6D,
                0xC1,
                0x17,
                0x0A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x51,
                0xD9,
                0xDE,
                0xBC,
                0x7B,
                0x18,
                0x05,
                0x4D,
                0xBC,
                0xCC,
                0xF7,
                0xE5,
                0x19,
                0x60,
                0xC2,
                0x58
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_BATTERY_DISCHARGE_ACTION_2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x38,
                0xBA,
                0x1C,
                0x42,
                0x8E,
                0x1A,
                0x81,
                0x48,
                0xAC,
                0x89,
                0xE3,
                0x3A,
                0x8B,
                0x04,
                0xEC,
                0xE4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA2,
                0x7C,
                0xA0,
                0x07,
                0xAF,
                0xAD,
                0xD7,
                0x40,
                0xB0,
                0x77,
                0x53,
                0x3A,
                0xAD,
                0xED,
                0x1B,
                0xFA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC4,
                0xF0,
                0xD2,
                0x7F,
                0xB7,
                0xFE,
                0xA3,
                0x4D,
                0x81,
                0x17,
                0xE3,
                0xFB,
                0xED,
                0xC4,
                0x65,
                0x82
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_BATTERY_DISCHARGE_ACTION_3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x13,
                0x26,
                0x47,
                0x80,
                0x80,
                0x97,
                0x5E,
                0x45,
                0xB3,
                0x08,
                0x72,
                0xD3,
                0x00,
                0x3C,
                0xF2,
                0xF8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA6,
                0xD5,
                0xAF,
                0x58,
                0xDD,
                0xC2,
                0xD2,
                0x47,
                0x9F,
                0xBF,
                0xEF,
                0x70,
                0xCC,
                0x5C,
                0x59,
                0x65
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0x3C,
                0x61,
                0x73,
                0xFA,
                0xDB,
                0x79,
                0x42,
                0x83,
                0x56,
                0x49,
                0x35,
                0xF6,
                0xBF,
                0x62,
                0xF3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_SETTINGS_SUBGROUP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x51,
                0x32,
                0x53,
                0x54,
                0xBE,
                0x82,
                0x24,
                0x48,
                0x96,
                0xC1,
                0x47,
                0xB6,
                0x0B,
                0x74,
                0x0D,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_THROTTLE_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x04,
                0x73,
                0x02,
                0x57,
                0xF6,
                0x4A,
                0x04,
                0x41,
                0x92,
                0x60,
                0xE3,
                0xD9,
                0x52,
                0x48,
                0xFC,
                0x36
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_THROTTLE_MAXIMUM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF7,
                0x38,
                0x50,
                0xBC,
                0xE0,
                0x23,
                0x60,
                0x49,
                0x96,
                0xDA,
                0x33,
                0xAB,
                0xAF,
                0x59,
                0x35,
                0xEC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_THROTTLE_MAXIMUM_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF7,
                0x38,
                0x50,
                0xBC,
                0xE0,
                0x23,
                0x60,
                0x49,
                0x96,
                0xDA,
                0x33,
                0xAB,
                0xAF,
                0x59,
                0x35,
                0xED
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_THROTTLE_MINIMUM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8E,
                0xEE,
                0x3D,
                0x89,
                0xEF,
                0x2B,
                0xE0,
                0x41,
                0x89,
                0xC6,
                0xB5,
                0x5D,
                0x09,
                0x29,
                0x96,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_THROTTLE_MINIMUM_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8E,
                0xEE,
                0x3D,
                0x89,
                0xEF,
                0x2B,
                0xE0,
                0x41,
                0x89,
                0xC6,
                0xB5,
                0x5D,
                0x09,
                0x29,
                0x96,
                0x4D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_FREQUENCY_LIMIT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3F,
                0xAE,
                0xB0,
                0x75,
                0xE0,
                0xBC,
                0xA7,
                0x45,
                0x8C,
                0x89,
                0xC9,
                0x61,
                0x1C,
                0x25,
                0xE1,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_FREQUENCY_LIMIT_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3F,
                0xAE,
                0xB0,
                0x75,
                0xE0,
                0xBC,
                0xA7,
                0x45,
                0x8C,
                0x89,
                0xC9,
                0x61,
                0x1C,
                0x25,
                0xE1,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_ALLOW_THROTTLING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFD,
                0xD4,
                0x04,
                0x3B,
                0xC7,
                0x1C,
                0x23,
                0x4F,
                0xAB,
                0x1C,
                0xD1,
                0x33,
                0x78,
                0x19,
                0xC4,
                0xBB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_IDLESTATE_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA7,
                0x62,
                0xF2,
                0x68,
                0x21,
                0xF6,
                0x69,
                0x40,
                0xB9,
                0xA5,
                0x48,
                0x74,
                0x16,
                0x9B,
                0xE2,
                0x3C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERFSTATE_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x14,
                0x38,
                0xDC,
                0xBB,
                0xE9,
                0x18,
                0x63,
                0x44,
                0x8A,
                0x55,
                0xD1,
                0x97,
                0x32,
                0x7C,
                0x45,
                0xC0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_INCREASE_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0xDF,
                0xCA,
                0x06,
                0xED,
                0x64,
                0x8A,
                0x44,
                0x89,
                0x27,
                0xCE,
                0x7B,
                0xF9,
                0x0E,
                0xB3,
                0x5D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_INCREASE_THRESHOLD_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0xDF,
                0xCA,
                0x06,
                0xED,
                0x64,
                0x8A,
                0x44,
                0x89,
                0x27,
                0xCE,
                0x7B,
                0xF9,
                0x0E,
                0xB3,
                0x5E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_DECREASE_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0xAB,
                0xA0,
                0x12,
                0x28,
                0xFE,
                0xA9,
                0x4F,
                0xB3,
                0xBD,
                0x4B,
                0x64,
                0xF4,
                0x49,
                0x60,
                0xA6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_DECREASE_THRESHOLD_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0xAB,
                0xA0,
                0x12,
                0x28,
                0xFE,
                0xA9,
                0x4F,
                0xB3,
                0xBD,
                0x4B,
                0x64,
                0xF4,
                0x49,
                0x60,
                0xA7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_INCREASE_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x50,
                0x1F,
                0x5E,
                0x46,
                0x10,
                0xB6,
                0x3A,
                0x47,
                0xAB,
                0x58,
                0x00,
                0xD1,
                0x07,
                0x7D,
                0xC4,
                0x18
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_INCREASE_POLICY_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x50,
                0x1F,
                0x5E,
                0x46,
                0x10,
                0xB6,
                0x3A,
                0x47,
                0xAB,
                0x58,
                0x00,
                0xD1,
                0x07,
                0x7D,
                0xC4,
                0x19
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_DECREASE_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0xEF,
                0xFB,
                0x40,
                0x9D,
                0x2E,
                0x25,
                0x4D,
                0xA1,
                0x85,
                0x0C,
                0xFD,
                0x85,
                0x74,
                0xBA,
                0xC6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_DECREASE_POLICY_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0xEF,
                0xFB,
                0x40,
                0x9D,
                0x2E,
                0x25,
                0x4D,
                0xA1,
                0x85,
                0x0C,
                0xFD,
                0x85,
                0x74,
                0xBA,
                0xC7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_INCREASE_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x92,
                0xF4,
                0x4C,
                0x98,
                0xED,
                0x3B,
                0x88,
                0x44,
                0xA8,
                0xF9,
                0x42,
                0x86,
                0xC9,
                0x7B,
                0xF5,
                0xAA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_INCREASE_TIME_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x92,
                0xF4,
                0x4C,
                0x98,
                0xED,
                0x3B,
                0x88,
                0x44,
                0xA8,
                0xF9,
                0x42,
                0x86,
                0xC9,
                0x7B,
                0xF5,
                0xAB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_DECREASE_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9B,
                0xEB,
                0xED,
                0xD8,
                0xCF,
                0x95,
                0x95,
                0x4F,
                0xA7,
                0x3C,
                0xB0,
                0x61,
                0x97,
                0x36,
                0x93,
                0xC8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_DECREASE_TIME_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9B,
                0xEB,
                0xED,
                0xD8,
                0xCF,
                0x95,
                0x95,
                0x4F,
                0xA7,
                0x3C,
                0xB0,
                0x61,
                0x97,
                0x36,
                0x93,
                0xC9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_TIME_CHECK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0x01,
                0x2B,
                0x4D,
                0x5C,
                0x7D,
                0x8B,
                0x49,
                0x88,
                0xE2,
                0x34,
                0x34,
                0x53,
                0x92,
                0xA2,
                0xC5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_BOOST_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0xC0,
                0xBC,
                0x45,
                0x85,
                0xD8,
                0xE2,
                0x43,
                0x86,
                0x05,
                0xEE,
                0x0E,
                0xC6,
                0xE9,
                0x6B,
                0x59
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_BOOST_MODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x38,
                0x72,
                0x33,
                0xBE,
                0x82,
                0x0D,
                0x46,
                0x41,
                0xA9,
                0x60,
                0x4F,
                0x37,
                0x49,
                0xD4,
                0x70,
                0xC7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_AUTONOMOUS_MODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0x4A,
                0xAA,
                0x8B,
                0xC6,
                0x14,
                0x51,
                0x44,
                0x8E,
                0x8B,
                0x14,
                0xBD,
                0xBD,
                0x19,
                0x75,
                0x37
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_ENERGY_PERFORMANCE_PREFERENCE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9E,
                0x7F,
                0x68,
                0x36,
                0xA5,
                0xE3,
                0xBF,
                0x4D,
                0xB1,
                0xDC,
                0x15,
                0xEB,
                0x38,
                0x1C,
                0x68,
                0x63
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_ENERGY_PERFORMANCE_PREFERENCE_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9E,
                0x7F,
                0x68,
                0x36,
                0xA5,
                0xE3,
                0xBF,
                0x4D,
                0xB1,
                0xDC,
                0x15,
                0xEB,
                0x38,
                0x1C,
                0x68,
                0x64
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_AUTONOMOUS_ACTIVITY_WINDOW
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD0,
                0xA3,
                0xED,
                0xCF,
                0x97,
                0x76,
                0x66,
                0x45,
                0xA9,
                0x22,
                0xA9,
                0x08,
                0x6C,
                0xD4,
                0x9D,
                0xFA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_DUTY_CYCLING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB3,
                0x50,
                0x44,
                0x4E,
                0x79,
                0x61,
                0x91,
                0x4E,
                0xB8,
                0xF1,
                0x5B,
                0xB9,
                0x93,
                0x8F,
                0x81,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_IDLE_ALLOW_SCALING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB0,
                0x93,
                0x29,
                0x6C,
                0x48,
                0x8F,
                0x1F,
                0x48,
                0xBC,
                0xC6,
                0x00,
                0xDD,
                0x27,
                0x42,
                0xAA,
                0x06
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_IDLE_DISABLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0xA2,
                0x76,
                0x5D,
                0xC0,
                0xE8,
                0x2F,
                0x40,
                0xA1,
                0x33,
                0x21,
                0x58,
                0x49,
                0x2D,
                0x58,
                0xAD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_IDLE_STATE_MAXIMUM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0xE9,
                0x43,
                0x99,
                0x30,
                0x9A,
                0xC1,
                0x4E,
                0x9B,
                0x99,
                0x44,
                0xDD,
                0x3B,
                0x76,
                0xF7,
                0xA2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_IDLE_TIME_CHECK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0x1C,
                0x58,
                0xC4,
                0xAB,
                0x89,
                0x97,
                0x45,
                0x8E,
                0x2B,
                0x9C,
                0x9C,
                0xAB,
                0x44,
                0x0E,
                0x6B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_IDLE_DEMOTE_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x58,
                0xD7,
                0x92,
                0x4B,
                0x24,
                0x5A,
                0x51,
                0x48,
                0xA4,
                0x70,
                0x81,
                0x5D,
                0x78,
                0xAE,
                0xE1,
                0x19
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_IDLE_PROMOTE_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0x48,
                0x22,
                0x7B,
                0xCC,
                0xB3,
                0x79,
                0x4D,
                0x81,
                0x9F,
                0x83,
                0x74,
                0x15,
                0x2C,
                0xBE,
                0x7C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_INCREASE_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0x29,
                0x14,
                0xDF,
                0xF3,
                0x20,
                0xDF,
                0x4E,
                0x9A,
                0x4A,
                0x9C,
                0x83,
                0xD3,
                0xD7,
                0x17,
                0xD1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_DECREASE_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0x2F,
                0xDD,
                0x68,
                0xCE,
                0xA4,
                0x11,
                0x4E,
                0x84,
                0x87,
                0x37,
                0x94,
                0xE4,
                0x13,
                0x5D,
                0xFA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_INCREASE_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x79,
                0x06,
                0xBE,
                0xC7,
                0x17,
                0x28,
                0x69,
                0x4D,
                0x9D,
                0x02,
                0x51,
                0x9A,
                0x53,
                0x7E,
                0xD0,
                0xC6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_DECREASE_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0x1B,
                0x02,
                0x71,
                0x49,
                0xC7,
                0x21,
                0x4D,
                0xBE,
                0x74,
                0xA0,
                0x0F,
                0x33,
                0x5D,
                0x58,
                0x2B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_MAX_CORES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0x20,
                0x06,
                0xEA,
                0x34,
                0x0E,
                0xF1,
                0x4F,
                0x9B,
                0x6D,
                0xEB,
                0x10,
                0x59,
                0x33,
                0x40,
                0x28
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_MAX_CORES_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0x20,
                0x06,
                0xEA,
                0x34,
                0x0E,
                0xF1,
                0x4F,
                0x9B,
                0x6D,
                0xEB,
                0x10,
                0x59,
                0x33,
                0x40,
                0x29
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_MIN_CORES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x47,
                0xB6,
                0xC5,
                0x0C,
                0xDF,
                0xC1,
                0x37,
                0x46,
                0x89,
                0x1A,
                0xDE,
                0xC3,
                0x5C,
                0x31,
                0x85,
                0x83
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_MIN_CORES_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x47,
                0xB6,
                0xC5,
                0x0C,
                0xDF,
                0xC1,
                0x37,
                0x46,
                0x89,
                0x1A,
                0xDE,
                0xC3,
                0x5C,
                0x31,
                0x85,
                0x84
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_INCREASE_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0x5A,
                0xDD,
                0x2D,
                0x71,
                0x5A,
                0x7E,
                0x43,
                0x91,
                0x2A,
                0xDB,
                0x0B,
                0x8C,
                0x78,
                0x87,
                0x32
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_DECREASE_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0x0D,
                0xD1,
                0xDF,
                0xEB,
                0xD5,
                0xDD,
                0x45,
                0x87,
                0x7A,
                0x9A,
                0x34,
                0xDD,
                0xD1,
                0x5C,
                0x82
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_DECREASE_FACTOR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE3,
                0x45,
                0x7B,
                0x8F,
                0x93,
                0xC3,
                0x0A,
                0x48,
                0x87,
                0x8C,
                0xF6,
                0x7A,
                0xC3,
                0xD0,
                0x70,
                0x82
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7B,
                0x69,
                0x33,
                0x5B,
                0x9D,
                0xE8,
                0x38,
                0x4D,
                0xAA,
                0x46,
                0x9E,
                0x7D,
                0xFB,
                0x7C,
                0xD2,
                0xF9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_AFFINITY_WEIGHTING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF1,
                0x67,
                0x08,
                0xE7,
                0x2F,
                0xFA,
                0x4E,
                0x4F,
                0xAE,
                0xA1,
                0x4D,
                0x8A,
                0x0B,
                0xA2,
                0x3B,
                0x20
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_DECREASE_FACTOR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3C,
                0x02,
                0x99,
                0x12,
                0x28,
                0xBC,
                0x0A,
                0x4F,
                0x81,
                0xEC,
                0xD3,
                0x29,
                0x5A,
                0x8D,
                0x81,
                0x5D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x92,
                0x8E,
                0xC1,
                0x9A,
                0x3C,
                0xAA,
                0x27,
                0x4E,
                0xB3,
                0x07,
                0x01,
                0xAE,
                0x37,
                0x30,
                0x71,
                0x29
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_WEIGHTING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD8,
                0xC2,
                0x09,
                0x88,
                0x55,
                0xB1,
                0xD4,
                0x42,
                0xBC,
                0xDA,
                0x0D,
                0x34,
                0x56,
                0x51,
                0xB1,
                0xDB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB6,
                0x8C,
                0x3C,
                0x94,
                0x93,
                0x6F,
                0x27,
                0x42,
                0xAD,
                0x87,
                0xE9,
                0xA3,
                0xFE,
                0xEC,
                0x08,
                0xD1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PARKING_CORE_OVERRIDE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAA,
                0x12,
                0x56,
                0xA5,
                0x24,
                0xF6,
                0xC6,
                0x42,
                0xA4,
                0x43,
                0x73,
                0x97,
                0xD0,
                0x64,
                0xC0,
                0x4F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PARKING_PERF_STATE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0x35,
                0x72,
                0x44,
                0x8D,
                0x6A,
                0xC0,
                0x4C,
                0x8E,
                0x24,
                0x9E,
                0xAF,
                0x70,
                0xB9,
                0x6E,
                0x2B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PARKING_PERF_STATE_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0x35,
                0x72,
                0x44,
                0x8D,
                0x6A,
                0xC0,
                0x4C,
                0x8E,
                0x24,
                0x9E,
                0xAF,
                0x70,
                0xB9,
                0x6E,
                0x2C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PARKING_CONCURRENCY_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6F,
                0xAB,
                0x30,
                0x24,
                0x20,
                0xA5,
                0xA2,
                0x44,
                0x96,
                0x01,
                0xF7,
                0xF2,
                0x3B,
                0x51,
                0x34,
                0xB1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PARKING_HEADROOM_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x73,
                0xA6,
                0x35,
                0xF7,
                0x66,
                0x20,
                0x80,
                0x4F,
                0xA0,
                0xC5,
                0xDD,
                0xEE,
                0x0C,
                0xF1,
                0xBF,
                0x5D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PARKING_DISTRIBUTION_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE9,
                0xF4,
                0xDA,
                0x4B,
                0x03,
                0xD1,
                0xD7,
                0x46,
                0xA5,
                0xF0,
                0x62,
                0x80,
                0x12,
                0x16,
                0x16,
                0xEF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_SOFT_PARKING_LATENCY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0xAC,
                0xCF,
                0x97,
                0x17,
                0x22,
                0xEB,
                0x47,
                0x99,
                0x2D,
                0x61,
                0x8B,
                0x19,
                0x77,
                0xC9,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_HISTORY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA7,
                0xBA,
                0x24,
                0x7D,
                0x84,
                0x0B,
                0x0F,
                0x48,
                0x84,
                0x0C,
                0x1B,
                0x07,
                0x43,
                0xC0,
                0x0F,
                0x5F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_HISTORY_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA7,
                0xBA,
                0x24,
                0x7D,
                0x84,
                0x0B,
                0x0F,
                0x48,
                0x84,
                0x0C,
                0x1B,
                0x07,
                0x43,
                0xC0,
                0x0F,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_INCREASE_HISTORY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0xEF,
                0xB3,
                0x99,
                0x2F,
                0x75,
                0xA1,
                0x46,
                0x80,
                0xFB,
                0x77,
                0x30,
                0x01,
                0x1F,
                0x23,
                0x54
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_DECREASE_HISTORY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF8,
                0xF6,
                0x00,
                0x03,
                0xD6,
                0xAB,
                0xA9,
                0x45,
                0xB7,
                0x4F,
                0x49,
                0x08,
                0x69,
                0x1A,
                0x40,
                0xB5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_CORE_PARKING_HISTORY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0xF2,
                0xD7,
                0x77,
                0x1A,
                0x8F,
                0xCD,
                0x42,
                0x85,
                0x37,
                0x45,
                0x45,
                0x0A,
                0x83,
                0x9B,
                0xE8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_LATENCY_HINT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0xDF,
                0x22,
                0x08,
                0x83,
                0x9C,
                0x1C,
                0x44,
                0xA0,
                0x79,
                0x0D,
                0xE4,
                0xCF,
                0x00,
                0x9C,
                0x7B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_LATENCY_HINT_PERF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0x75,
                0x9B,
                0x61,
                0x3B,
                0x00,
                0x82,
                0x4E,
                0xB7,
                0xA6,
                0x4D,
                0xD2,
                0x9C,
                0x30,
                0x09,
                0x71
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_PERF_LATENCY_HINT_PERF_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0x75,
                0x9B,
                0x61,
                0x3B,
                0x00,
                0x82,
                0x4E,
                0xB7,
                0xA6,
                0x4D,
                0xD2,
                0x9C,
                0x30,
                0x09,
                0x72
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA5,
                0xDA,
                0x6C,
                0x61,
                0x5E,
                0x69,
                0x45,
                0x45,
                0x97,
                0xAD,
                0x97,
                0xDC,
                0x2D,
                0x1B,
                0xDD,
                0x88
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA5,
                0xDA,
                0x6C,
                0x61,
                0x5E,
                0x69,
                0x45,
                0x45,
                0x97,
                0xAD,
                0x97,
                0xDC,
                0x2D,
                0x1B,
                0xDD,
                0x89
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_MODULE_PARKING_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6B,
                0xAF,
                0xDE,
                0xB0,
                0xC0,
                0x59,
                0x23,
                0x45,
                0x8A,
                0x45,
                0xCA,
                0x7F,
                0x40,
                0x24,
                0x41,
                0x14
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_COMPLEX_PARKING_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE9,
                0xA5,
                0x69,
                0xB6,
                0x1D,
                0x7B,
                0x32,
                0x41,
                0xBA,
                0xAA,
                0x49,
                0x19,
                0x0A,
                0xBC,
                0xFE,
                0xB6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_SMT_UNPARKING_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x29,
                0x68,
                0x8A,
                0xB2,
                0xF7,
                0xC5,
                0x4E,
                0x44,
                0x8F,
                0x61,
                0x10,
                0xE2,
                0x4E,
                0x85,
                0xC5,
                0x32
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_DISTRIBUTE_UTILITY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0x73,
                0x00,
                0xE0,
                0x89,
                0xF5,
                0xED,
                0x42,
                0xA4,
                0x01,
                0x5D,
                0xDB,
                0x10,
                0xE7,
                0x85,
                0xD3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_HETEROGENEOUS_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFA,
                0x5C,
                0x2F,
                0x7F,
                0x0C,
                0xF1,
                0x23,
                0x48,
                0xB5,
                0xE1,
                0xE9,
                0x3A,
                0xE8,
                0x5F,
                0x46,
                0xB5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_HETERO_DECREASE_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB6,
                0x92,
                0x24,
                0x7F,
                0xB1,
                0x60,
                0xE5,
                0x45,
                0xAE,
                0x55,
                0x77,
                0x3F,
                0x8C,
                0xD5,
                0xCA,
                0xEC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_HETERO_INCREASE_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA7,
                0xEF,
                0x09,
                0x40,
                0x2D,
                0xE7,
                0xBA,
                0x4C,
                0x9E,
                0xDF,
                0x91,
                0x08,
                0x4E,
                0xA8,
                0xCB,
                0xC3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_HETERO_DECREASE_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0x1C,
                0x86,
                0xF8,
                0xE7,
                0x95,
                0x5C,
                0x47,
                0x86,
                0x5B,
                0x13,
                0xC0,
                0xCB,
                0x3F,
                0x9D,
                0x6B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_HETERO_DECREASE_THRESHOLD_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0x1C,
                0x86,
                0xF8,
                0xE7,
                0x95,
                0x5C,
                0x47,
                0x86,
                0x5B,
                0x13,
                0xC0,
                0xCB,
                0x3F,
                0x9D,
                0x6C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_HETERO_INCREASE_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7D,
                0x39,
                0x00,
                0xB0,
                0x0B,
                0x9B,
                0x3D,
                0x48,
                0x98,
                0xC9,
                0x69,
                0x2A,
                0x60,
                0x60,
                0xCF,
                0xBF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_HETERO_INCREASE_THRESHOLD_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7D,
                0x39,
                0x00,
                0xB0,
                0x0B,
                0x9B,
                0x3D,
                0x48,
                0x98,
                0xC9,
                0x69,
                0x2A,
                0x60,
                0x60,
                0xCF,
                0xC0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CLASS0_FLOOR_PERF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0x84,
                0xDC,
                0xFD,
                0x64,
                0x83,
                0xDC,
                0x4E,
                0x94,
                0xCF,
                0xC1,
                0x7F,
                0x60,
                0xDE,
                0x1C,
                0x80
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_CLASS1_INITIAL_PERF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x65,
                0xFC,
                0xAC,
                0x1F,
                0x30,
                0xA9,
                0xC5,
                0x4B,
                0x9F,
                0x38,
                0x50,
                0x4E,
                0xC0,
                0x97,
                0xBB,
                0xC0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_THREAD_SCHEDULING_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDC,
                0xB6,
                0xB8,
                0x93,
                0x98,
                0x06,
                0x1C,
                0x4D,
                0x9E,
                0xE4,
                0x06,
                0x44,
                0xE9,
                0x00,
                0xC8,
                0x5D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_SHORT_THREAD_SCHEDULING_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0x8B,
                0xE0,
                0xBA,
                0x5E,
                0x2D,
                0x88,
                0x46,
                0xAD,
                0x6A,
                0x13,
                0x24,
                0x33,
                0x56,
                0x65,
                0x4B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_SHORT_THREAD_RUNTIME_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC2,
                0x98,
                0x29,
                0xD9,
                0x48,
                0x6A,
                0xCA,
                0x49,
                0x85,
                0xD4,
                0x8C,
                0xCE,
                0xEC,
                0x29,
                0x45,
                0x70
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_SHORT_THREAD_ARCH_CLASS_UPPER_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEB,
                0x23,
                0x84,
                0x82,
                0x62,
                0x86,
                0x44,
                0x43,
                0x90,
                0xF7,
                0x52,
                0xBF,
                0x15,
                0x87,
                0x0F,
                0x5A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_SHORT_THREAD_ARCH_CLASS_LOWER_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x46,
                0x4D,
                0x82,
                0x53,
                0xBD,
                0x87,
                0x39,
                0x47,
                0xAA,
                0x1B,
                0xAA,
                0x79,
                0x3F,
                0xAC,
                0x36,
                0xD6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_LONG_THREAD_ARCH_CLASS_UPPER_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0x3D,
                0x90,
                0xBF,
                0x24,
                0x9D,
                0xD3,
                0x49,
                0xA4,
                0x68,
                0xE6,
                0x5E,
                0x03,
                0x25,
                0x04,
                0x6A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_LONG_THREAD_ARCH_CLASS_LOWER_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0x78,
                0xF2,
                0x43,
                0x8A,
                0x0F,
                0xD0,
                0x46,
                0x8B,
                0x31,
                0x9A,
                0x23,
                0xE6,
                0x15,
                0xD7,
                0x13
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_SYSTEM_COOLING_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0xA6,
                0xD3,
                0x94,
                0x99,
                0xA8,
                0xC5,
                0x4A,
                0xAE,
                0x2B,
                0xE4,
                0xD8,
                0xF6,
                0x34,
                0x36,
                0x7F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_DISABLE_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3D,
                0x38,
                0xB8,
                0x38,
                0xE0,
                0xCC,
                0x79,
                0x4C,
                0x9E,
                0x3E,
                0x56,
                0xA4,
                0xF1,
                0x7C,
                0xC4,
                0x80
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_DISABLE_THRESHOLD_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3D,
                0x38,
                0xB8,
                0x38,
                0xE0,
                0xCC,
                0x79,
                0x4C,
                0x9E,
                0x3E,
                0x56,
                0xA4,
                0xF1,
                0x7C,
                0xC4,
                0x81
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_ENABLE_THRESHOLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x56,
                0xE2,
                0x44,
                0x3D,
                0x22,
                0x72,
                0x15,
                0x44,
                0xA9,
                0xED,
                0x9C,
                0x45,
                0xFA,
                0x3D,
                0xD8,
                0x30
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_ENABLE_THRESHOLD_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x56,
                0xE2,
                0x44,
                0x3D,
                0x22,
                0x72,
                0x15,
                0x44,
                0xA9,
                0xED,
                0x9C,
                0x45,
                0xFA,
                0x3D,
                0xD8,
                0x31
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_DISABLE_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9F,
                0x99,
                0x65,
                0xF5,
                0xB0,
                0x3F,
                0x1A,
                0x41,
                0xA2,
                0x26,
                0x3F,
                0x01,
                0x98,
                0xDE,
                0xC1,
                0x30
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_DISABLE_TIME_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9F,
                0x99,
                0x65,
                0xF5,
                0xB0,
                0x3F,
                0x1A,
                0x41,
                0xA2,
                0x26,
                0x3F,
                0x01,
                0x98,
                0xDE,
                0xC1,
                0x31
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_ENABLE_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x88,
                0x51,
                0x91,
                0x3D,
                0x30,
                0x78,
                0xAE,
                0x49,
                0xA7,
                0x9A,
                0x0F,
                0xB0,
                0xA1,
                0xE5,
                0xA2,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_ENABLE_TIME_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x88,
                0x51,
                0x91,
                0x3D,
                0x30,
                0x78,
                0xAE,
                0x49,
                0xA7,
                0x9A,
                0x0F,
                0xB0,
                0xA1,
                0xE5,
                0xA2,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_EPP_CEILING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0xC7,
                0x27,
                0x44,
                0x56,
                0x97,
                0x5C,
                0x4A,
                0xB8,
                0x4B,
                0xC7,
                0xBD,
                0xA7,
                0x9C,
                0x73,
                0x20
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_EPP_CEILING_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0xC7,
                0x27,
                0x44,
                0x56,
                0x97,
                0x5C,
                0x4A,
                0xB8,
                0x4B,
                0xC7,
                0xBD,
                0xA7,
                0x9C,
                0x73,
                0x21
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_PERF_FLOOR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0x92,
                0x8E,
                0xCE,
                0x86,
                0x6A,
                0x72,
                0x45,
                0xBF,
                0xE0,
                0x20,
                0xC2,
                0x1D,
                0x03,
                0xCD,
                0x40
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_PERF_FLOOR_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0x92,
                0x8E,
                0xCE,
                0x86,
                0x6A,
                0x72,
                0x45,
                0xBF,
                0xE0,
                0x20,
                0xC2,
                0x1D,
                0x03,
                0xCD,
                0x41
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_LOCK_CONSOLE_ON_WAKE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0x6B,
                0x79,
                0x0E,
                0x0D,
                0x10,
                0xD6,
                0x47,
                0xA2,
                0xD5,
                0xF7,
                0xD2,
                0xDA,
                0xA5,
                0x1F,
                0x51
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_DEVICE_IDLE_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1A,
                0xB7,
                0xAA,
                0x4F,
                0xE5,
                0x92,
                0x26,
                0x47,
                0xB5,
                0x31,
                0x22,
                0x45,
                0x59,
                0x67,
                0x2D,
                0x19
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_CONNECTIVITY_IN_STANDBY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE8,
                0x76,
                0x55,
                0xF1,
                0xB7,
                0x98,
                0x86,
                0x41,
                0xB9,
                0x44,
                0xEA,
                0xFA,
                0x66,
                0x44,
                0x02,
                0xD9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_DISCONNECTED_STANDBY_MODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD9,
                0xB2,
                0xAF,
                0x68,
                0x95,
                0xEE,
                0xA8,
                0x47,
                0x8F,
                0x50,
                0x41,
                0x15,
                0x08,
                0x80,
                0x73,
                0xB1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ACDC_POWER_SOURCE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x59,
                0x9A,
                0x3E,
                0x5D,
                0xD5,
                0xE9,
                0x00,
                0x4B,
                0xA6,
                0xBD,
                0xFF,
                0x34,
                0xFF,
                0x51,
                0x65,
                0x48
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_LIDSWITCH_STATE_CHANGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0x0F,
                0x3E,
                0xBA,
                0x17,
                0xB8,
                0x94,
                0x40,
                0xA2,
                0xD1,
                0xD5,
                0x63,
                0x79,
                0xE6,
                0xA0,
                0xF3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_LIDSWITCH_STATE_RELIABILITY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF1,
                0x4F,
                0x4C,
                0xAE,
                0x61,
                0xD3,
                0xF4,
                0x43,
                0x80,
                0xAA,
                0xBB,
                0xB6,
                0xEB,
                0x03,
                0xDE,
                0x94
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_BATTERY_PERCENTAGE_REMAINING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0x80,
                0xAD,
                0xA7,
                0x5A,
                0xB4,
                0xAE,
                0x4C,
                0x87,
                0xA3,
                0xEE,
                0xCB,
                0xB4,
                0x68,
                0xA9,
                0xE1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_BATTERY_COUNT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0x3F,
                0x26,
                0x7D,
                0xA4,
                0xFC,
                0xE5,
                0x49,
                0x85,
                0x4B,
                0xA9,
                0xF2,
                0xBF,
                0xBD,
                0x5C,
                0x24
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_GLOBAL_USER_PRESENCE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1D,
                0x8A,
                0x6E,
                0x78,
                0x27,
                0xB4,
                0x44,
                0x43,
                0x92,
                0x07,
                0x09,
                0xE7,
                0x0B,
                0xDC,
                0xBE,
                0xA9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_SESSION_DISPLAY_STATUS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0xC2,
                0x84,
                0x2B,
                0x23,
                0xAD,
                0xDF,
                0x4D,
                0x93,
                0xDB,
                0x05,
                0xFF,
                0xBD,
                0x7E,
                0xFC,
                0xA5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_SESSION_USER_PRESENCE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x48,
                0x45,
                0x0F,
                0x3C,
                0x3F,
                0xC0,
                0x4D,
                0x4C,
                0xB9,
                0xF2,
                0x23,
                0x7E,
                0xDE,
                0x68,
                0x63,
                0x76
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_IDLE_BACKGROUND_TASK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD8,
                0x31,
                0x5C,
                0x51,
                0x34,
                0xF7,
                0x3D,
                0x16,
                0xA0,
                0xFD,
                0x11,
                0xA0,
                0x8C,
                0x91,
                0xE8,
                0xF1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_BACKGROUND_TASK_NOTIFICATION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0xF2,
                0x23,
                0xCF,
                0x54,
                0x2A,
                0xD8,
                0x48,
                0xB1,
                0x14,
                0xDE,
                0x15,
                0x18,
                0xFF,
                0x05,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_APPLAUNCH_BUTTON
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0x92,
                0x68,
                0x1A,
                0x99,
                0x73,
                0x9A,
                0x4E,
                0x8F,
                0x99,
                0xB7,
                0x1F,
                0x99,
                0x9D,
                0xB3,
                0xFA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PCIEXPRESS_SETTINGS_SUBGROUP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x13,
                0x4D,
                0x1A,
                0x50,
                0xAF,
                0x42,
                0x29,
                0x44,
                0x9F,
                0xD1,
                0xA8,
                0x21,
                0x8C,
                0x26,
                0x8E,
                0x20
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PCIEXPRESS_ASPM_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x06,
                0xF9,
                0x12,
                0xEE,
                0x77,
                0xD2,
                0x4B,
                0x40,
                0xB6,
                0xDA,
                0xE5,
                0xFA,
                0x1A,
                0x57,
                0x6D,
                0xF5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ENABLE_SWITCH_FORCED_SHUTDOWN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0x6B,
                0x3A,
                0x83,
                0xA4,
                0xDF,
                0xD1,
                0x46,
                0x82,
                0xF8,
                0xE0,
                0x9E,
                0x34,
                0xD0,
                0x29,
                0xD6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_INTSTEER_SUBGROUP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x38,
                0x2F,
                0x67,
                0x48,
                0x9A,
                0x7A,
                0xB2,
                0x4B,
                0x8B,
                0xF8,
                0x3D,
                0x85,
                0xBE,
                0x19,
                0xDE,
                0x4E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_INTSTEER_MODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF9,
                0x24,
                0xFC,
                0x2B,
                0xA2,
                0x5E,
                0x01,
                0x48,
                0x82,
                0x13,
                0x3D,
                0xBA,
                0xE0,
                0x1A,
                0xA3,
                0x9D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_INTSTEER_LOAD_PER_PROC_TRIGGER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0xE6,
                0xCD,
                0x73,
                0x20,
                0xD7,
                0xB2,
                0x4B,
                0xA8,
                0x60,
                0xC7,
                0x55,
                0xAF,
                0xE7,
                0x7E,
                0xF2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_INTSTEER_TIME_UNPARK_TRIGGER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0x49,
                0xBA,
                0xD6,
                0x6F,
                0x38,
                0x2C,
                0x4C,
                0x8A,
                0xDB,
                0x5C,
                0x21,
                0xB3,
                0x32,
                0x8D,
                0x25
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_GRAPHICS_SUBGROUP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8D,
                0x93,
                0xB4,
                0x5F,
                0xE8,
                0x1E,
                0x0F,
                0x4B,
                0x9A,
                0x3C,
                0x50,
                0x36,
                0xB0,
                0xAB,
                0x99,
                0x5C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_GPU_PREFERENCE_POLICY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A,
                0x8B,
                0x84,
                0xDD,
                0x5D,
                0x8A,
                0x51,
                0x44,
                0x9A,
                0xE2,
                0x39,
                0xCD,
                0x41,
                0x65,
                0x8F,
                0x6C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_MIXED_REALITY_MODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4E,
                0x6B,
                0x62,
                0x1E,
                0x04,
                0xCF,
                0x8D,
                0x4F,
                0x9C,
                0xC7,
                0xC9,
                0x7C,
                0x5B,
                0x0F,
                0x23,
                0x91
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_SPR_ACTIVE_SESSION_CHANGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x38,
                0xCE,
                0x24,
                0x0E,
                0x93,
                0xC3,
                0x42,
                0x47,
                0xBD,
                0xB1,
                0x74,
                0x4F,
                0x4B,
                0x9E,
                0xE0,
                0x8E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}