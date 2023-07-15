// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IAudioClient
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4C,
                0xAD,
                0xB9,
                0x1C,
                0xFA,
                0xDB,
                0x32,
                0x4C,
                0xB1,
                0x78,
                0xC2,
                0xF5,
                0x68,
                0xA7,
                0x03,
                0xB2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioClient2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0x78,
                0x67,
                0x72,
                0x0A,
                0xF6,
                0xDA,
                0x4E,
                0x82,
                0xDE,
                0xE4,
                0x76,
                0x10,
                0xCD,
                0x78,
                0xAA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioClient3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x07,
                0xEE,
                0xD4,
                0x7E,
                0x67,
                0x8E,
                0xD4,
                0x4C,
                0x8C,
                0x1A,
                0x2B,
                0x7A,
                0x59,
                0x87,
                0xAD,
                0x42
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioRenderClient
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFC,
                0xAC,
                0x94,
                0xF2,
                0x46,
                0x31,
                0x83,
                0x44,
                0xA7,
                0xBF,
                0xAD,
                0xDC,
                0xA7,
                0xC2,
                0x60,
                0xE2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioCaptureClient
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x64,
                0xBD,
                0xAD,
                0xC8,
                0x1E,
                0xE7,
                0xA0,
                0x48,
                0xA4,
                0xDE,
                0x18,
                0x5C,
                0x39,
                0x5C,
                0xD3,
                0x17
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioClock
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4F,
                0x31,
                0x63,
                0xCD,
                0xBA,
                0x3F,
                0x1B,
                0x4A,
                0x81,
                0x2C,
                0xEF,
                0x96,
                0x35,
                0x87,
                0x28,
                0xE7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioClock2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x73,
                0xFF,
                0x49,
                0x6F,
                0x27,
                0x67,
                0xAC,
                0x49,
                0xA0,
                0x08,
                0xD9,
                0x8C,
                0xF5,
                0xE7,
                0x00,
                0x48
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioClockAdjustment
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA0,
                0xC0,
                0xE4,
                0xF6,
                0xD9,
                0x46,
                0xB8,
                0x4F,
                0xBE,
                0x21,
                0x57,
                0xA3,
                0xEF,
                0x2B,
                0x62,
                0x6C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISimpleAudioVolume
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x98,
                0x54,
                0xCE,
                0x87,
                0xD6,
                0x68,
                0xE5,
                0x44,
                0x92,
                0x15,
                0x6D,
                0xA4,
                0x7E,
                0xF8,
                0x83,
                0xD8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioClientDuckingControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0xD3,
                0x89,
                0xC7,
                0x8C,
                0xA2,
                0x68,
                0x41,
                0xB2,
                0x8F,
                0xD3,
                0xA8,
                0x37,
                0x92,
                0x4D,
                0xC3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioViewManagerService
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0xEF,
                0xA7,
                0xA7,
                0x49,
                0x1F,
                0xE0,
                0x45,
                0xAD,
                0x35,
                0x61,
                0x20,
                0x57,
                0xCC,
                0x8F,
                0x74
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioEffectsChangedNotificationClient
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4F,
                0xD4,
                0xDE,
                0xA5,
                0x5D,
                0x3C,
                0x2B,
                0x4B,
                0xBD,
                0x1E,
                0x5D,
                0xC1,
                0xEE,
                0x20,
                0xBB,
                0xF6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioEffectsManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAE,
                0xB3,
                0x60,
                0x44,
                0x44,
                0x4B,
                0x27,
                0x45,
                0x86,
                0x76,
                0x75,
                0x48,
                0xA8,
                0xAC,
                0xD2,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioStreamVolume
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x87,
                0x48,
                0x01,
                0x93,
                0x2D,
                0x24,
                0x68,
                0x40,
                0x8A,
                0x15,
                0xCF,
                0x5E,
                0x93,
                0xB9,
                0x0F,
                0xE3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioAmbisonicsControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x91,
                0x4C,
                0x72,
                0x28,
                0x35,
                0xDF,
                0x56,
                0x48,
                0x9F,
                0x76,
                0xD6,
                0xA2,
                0x64,
                0x13,
                0xF3,
                0xDF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IChannelAudioVolume
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x61,
                0x88,
                0x15,
                0x1C,
                0x33,
                0xB5,
                0x30,
                0x4B,
                0xB1,
                0xCF,
                0xE8,
                0x53,
                0xE5,
                0x1C,
                0x59,
                0xB8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAcousticEchoCancellationControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB5,
                0x25,
                0xAE,
                0xF4,
                0xA3,
                0xAA,
                0x7D,
                0x43,
                0xB6,
                0xB3,
                0xDB,
                0xBE,
                0x2D,
                0x0E,
                0x95,
                0x49
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}