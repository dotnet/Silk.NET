// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class MFPROTECTION
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid MFPROTECTION_DISABLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1B,
                0xD8,
                0xC6,
                0x8C,
                0xC6,
                0xFE,
                0x8F,
                0x4D,
                0x96,
                0x4B,
                0xCF,
                0xBA,
                0x0B,
                0x0D,
                0xAD,
                0x0D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFPROTECTION_CONSTRICTVIDEO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0x70,
                0x33,
                0x19,
                0xE4,
                0xC5,
                0x3A,
                0x4C,
                0x8A,
                0x66,
                0x69,
                0x59,
                0xB4,
                0xDA,
                0x44,
                0x42
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFPROTECTION_CONSTRICTVIDEO_NOOPM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0xE8,
                0x80,
                0xA5,
                0x47,
                0xC2,
                0x57,
                0x49,
                0xB9,
                0x83,
                0x3C,
                0x2E,
                0xEB,
                0xD1,
                0xFF,
                0x59
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFPROTECTION_CONSTRICTAUDIO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0x9B,
                0xC9,
                0xFF,
                0x48,
                0xDF,
                0x16,
                0x4E,
                0x8E,
                0x66,
                0x09,
                0x68,
                0x92,
                0xC1,
                0x57,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFPROTECTION_TRUSTEDAUDIODRIVERS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD2,
                0xF3,
                0xBD,
                0x65,
                0x68,
                0x01,
                0x16,
                0x48,
                0xA5,
                0x33,
                0x55,
                0xD4,
                0x7B,
                0x02,
                0x71,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFPROTECTION_HDCP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3D,
                0xC0,
                0x7C,
                0xAE,
                0x28,
                0xC8,
                0x21,
                0x40,
                0xAC,
                0xB7,
                0xD5,
                0x78,
                0xD2,
                0x7A,
                0xAF,
                0x13
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFPROTECTION_CGMSA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE9,
                0x69,
                0x7E,
                0xE5,
                0x6B,
                0x22,
                0x31,
                0x4D,
                0xB4,
                0xE3,
                0xD3,
                0xDB,
                0x00,
                0x87,
                0x36,
                0xDD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFPROTECTION_ACP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0x11,
                0xFD,
                0xC3,
                0xB7,
                0xF8,
                0x20,
                0x4D,
                0xB0,
                0x08,
                0x1D,
                0xB1,
                0x7D,
                0x61,
                0xF2,
                0xDA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFPROTECTION_WMDRMOTA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA1,
                0xA6,
                0x67,
                0xA2,
                0x2E,
                0x36,
                0xD0,
                0x47,
                0x88,
                0x05,
                0x46,
                0x28,
                0x59,
                0x8A,
                0x23,
                0xE4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFPROTECTION_FFT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB2,
                0x56,
                0x2A,
                0x46,
                0x66,
                0x28,
                0xB6,
                0x4B,
                0x98,
                0x0D,
                0x6D,
                0x8D,
                0x9E,
                0xDB,
                0x1A,
                0x8C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFPROTECTION_PROTECTED_SURFACE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x66,
                0x95,
                0x5D,
                0x4F,
                0x42,
                0xE7,
                0x25,
                0x4A,
                0x8D,
                0x1F,
                0xD2,
                0x87,
                0xB5,
                0xFA,
                0x0A,
                0xDE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFPROTECTION_DISABLE_SCREEN_SCRAPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA4,
                0x79,
                0x11,
                0xA2,
                0xCD,
                0xB7,
                0xD8,
                0x40,
                0x96,
                0x14,
                0x8E,
                0xF2,
                0x37,
                0x1B,
                0xA7,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFPROTECTION_VIDEO_FRAMES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0x9C,
                0xA5,
                0x36,
                0x01,
                0x74,
                0x8C,
                0x4A,
                0xBC,
                0x20,
                0x46,
                0xA7,
                0xC9,
                0xE5,
                0x97,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFPROTECTION_HARDWARE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0xF0,
                0xE7,
                0x4E,
                0xD7,
                0x9E,
                0x4F,
                0x42,
                0xB6,
                0xBE,
                0x99,
                0x6B,
                0x33,
                0x52,
                0x88,
                0x56
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFPROTECTION_HDCP_WITH_TYPE_ENFORCEMENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE8,
                0x85,
                0xA5,
                0xA4,
                0x60,
                0xED,
                0x2D,
                0x44,
                0x81,
                0x4D,
                0xDB,
                0x4D,
                0x42,
                0x20,
                0xA0,
                0x6D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFPROTECTION_GRAPHICS_TRANSFER_AES_ENCRYPTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x64,
                0xDE,
                0x73,
                0xC8,
                0xA5,
                0xD8,
                0xE6,
                0x49,
                0x88,
                0xBB,
                0xFB,
                0x96,
                0x3F,
                0xD3,
                0xD4,
                0xCE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}