// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IKsControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x85, 0x46, 0xF5, 0x28,
                0xFD, 0x06,
                0xD2, 0x11,
                0xB2,
                0x7A,
                0x00,
                0xA0,
                0xC9,
                0x22,
                0x31,
                0x96
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPerChannelDbLevel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x01, 0xE0, 0xF8, 0xC2,
                0x05, 0xF2,
                0xC9, 0x4B,
                0x99,
                0xBC,
                0xC1,
                0x3B,
                0x1E,
                0x04,
                0x8C,
                0xCB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioVolumeLevel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8F, 0xB4, 0xB7, 0x7F,
                0x1D, 0x53,
                0xA2, 0x44,
                0xBC,
                0xB3,
                0x5A,
                0xD5,
                0xA1,
                0x34,
                0xB3,
                0xDC
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioChannelConfig
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x6F, 0xC4, 0x11, 0xBB,
                0x28, 0xEC,
                0x3C, 0x49,
                0xB8,
                0x8A,
                0x5D,
                0xB8,
                0x80,
                0x62,
                0xCE,
                0x98
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioLoudness
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x37, 0x14, 0x8B, 0x7D,
                0x53, 0xDD,
                0x50, 0x43,
                0x9C,
                0x1B,
                0x1E,
                0xE2,
                0x89,
                0x0B,
                0xD9,
                0x38
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioInputSelector
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x02, 0xDC, 0x03, 0x4F,
                0x6E, 0x5E,
                0x53, 0x46,
                0x8F,
                0x72,
                0xA0,
                0x30,
                0xC1,
                0x23,
                0xD5,
                0x98
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioOutputSelector
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x69, 0x5F, 0x51, 0xBB,
                0xA7, 0x94,
                0x9E, 0x42,
                0x8B,
                0x9C,
                0x27,
                0x1B,
                0x3F,
                0x11,
                0xA3,
                0xAB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioMute
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xEA, 0xAE, 0x45, 0xDF,
                0x4A, 0xB7,
                0x6B, 0x4B,
                0xAF,
                0xAD,
                0x23,
                0x66,
                0xB6,
                0xAA,
                0x01,
                0x2E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioBass
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD9, 0xA1, 0xB1, 0xA2,
                0xB3, 0x4D,
                0x5D, 0x42,
                0xA2,
                0xB2,
                0xBD,
                0x33,
                0x5C,
                0xB3,
                0xE2,
                0xE5
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioMidrange
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD7, 0xB6, 0x54, 0x5E,
                0x4B, 0xB4,
                0xD9, 0x40,
                0x9A,
                0x9E,
                0xE6,
                0x91,
                0xD9,
                0xCE,
                0x6E,
                0xDF
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioTreble
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x12, 0x78, 0x71, 0x0A,
                0x4E, 0x69,
                0x07, 0x49,
                0xB7,
                0x4B,
                0xBA,
                0xFA,
                0x5C,
                0xFD,
                0xCA,
                0x7B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioAutoGainControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD4, 0x1F, 0x40, 0x85,
                0xE4, 0x6D,
                0x9D, 0x4B,
                0x98,
                0x69,
                0x2D,
                0x67,
                0x53,
                0xA8,
                0x2F,
                0x3C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioPeakMeter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3C, 0x92, 0x79, 0xDD,
                0x99, 0x05,
                0xE0, 0x45,
                0xB8,
                0xB6,
                0xC8,
                0xDF,
                0x7D,
                0xB6,
                0xE7,
                0x96
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDeviceSpecificProperty
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xBF, 0xBC, 0x22, 0x3B,
                0x86, 0x25,
                0xF0, 0x4A,
                0x85,
                0x83,
                0x20,
                0x5D,
                0x39,
                0x1B,
                0x80,
                0x7C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IKsFormatSupport
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x9D, 0xA6, 0xB4, 0x3C,
                0x6F, 0xBB,
                0x2B, 0x4D,
                0x95,
                0xB7,
                0x45,
                0x2D,
                0x2C,
                0x15,
                0x5D,
                0xB5
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IKsJackDescription
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x57, 0xF7, 0x09, 0x45,
                0x46, 0x2D,
                0x37, 0x46,
                0x8E,
                0x62,
                0xCE,
                0x7D,
                0xB9,
                0x44,
                0xF5,
                0x7B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IKsJackDescription2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x9B, 0x3A, 0x8F, 0x47,
                0xC9, 0xE0,
                0x27, 0x48,
                0x92,
                0x28,
                0x6F,
                0x55,
                0x05,
                0xFF,
                0xE7,
                0x6A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IKsJackDescription3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8B, 0x77, 0xF6, 0xE3,
                0x60, 0x66,
                0xC8, 0x4C,
                0xA2,
                0x91,
                0xEC,
                0xC4,
                0x19,
                0x2D,
                0x99,
                0x67
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IKsJackSinkInformation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xED, 0x72, 0xBD, 0xD9,
                0x0F, 0x29,
                0x81, 0x45,
                0x9F,
                0xF3,
                0x61,
                0x02,
                0x7A,
                0x8F,
                0xE5,
                0x32
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IKsJackContainerId
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x63, 0xF4, 0x9A, 0xC9,
                0x29, 0xD6,
                0xC4, 0x4E,
                0x8C,
                0x00,
                0xE5,
                0x4D,
                0x68,
                0x15,
                0x42,
                0x48
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPartsList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8C, 0x84, 0xAA, 0x6D,
                0xB0, 0x5E,
                0xCC, 0x45,
                0xAE,
                0xA5,
                0x99,
                0x8A,
                0x2C,
                0xDA,
                0x1F,
                0xFB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPart
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE4, 0xE0, 0x2D, 0xAE,
                0xCA, 0x5B,
                0x2D, 0x4F,
                0xAA,
                0x46,
                0x5D,
                0x13,
                0xF8,
                0xFD,
                0xB3,
                0xA9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IConnector
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x58, 0x40, 0x2C, 0x9C,
                0xF5, 0x23,
                0xDE, 0x41,
                0x87,
                0x7A,
                0xDF,
                0x3A,
                0xF2,
                0x36,
                0xA0,
                0x9E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISubunit
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x85, 0x9A, 0x14, 0x82,
                0xA6, 0xDB,
                0x87, 0x44,
                0x86,
                0xBB,
                0xEA,
                0x8F,
                0x7F,
                0xEF,
                0xCC,
                0x71
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IControlInterface
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3F, 0x7C, 0xD3, 0x45,
                0x40, 0x51,
                0x4A, 0x44,
                0xAE,
                0x24,
                0x40,
                0x07,
                0x89,
                0xF3,
                0xCB,
                0xF3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IControlChangeNotify
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xED, 0x13, 0x95, 0xA0,
                0x09, 0xC7,
                0x21, 0x4D,
                0xBD,
                0x7B,
                0x5F,
                0x34,
                0xC4,
                0x7F,
                0x39,
                0x47
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDeviceTopology
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x7E, 0x40, 0x07, 0x2A,
                0x97, 0x64,
                0x18, 0x4A,
                0x97,
                0x87,
                0x32,
                0xF7,
                0x9B,
                0xD0,
                0xD9,
                0x8F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
