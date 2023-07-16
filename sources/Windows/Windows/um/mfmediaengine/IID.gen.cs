// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IMFMediaError
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD2,
                0x10,
                0x0E,
                0xFC,
                0x2A,
                0xAB,
                0x01,
                0x45,
                0xA9,
                0x51,
                0x06,
                0xBB,
                0x10,
                0x75,
                0x18,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaTimeRange
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFC,
                0xA2,
                0x71,
                0xDB,
                0x8A,
                0x07,
                0x4E,
                0x41,
                0x9D,
                0xF9,
                0x8C,
                0x25,
                0x31,
                0xB0,
                0xAA,
                0x6C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineNotify
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x12,
                0xC1,
                0xE7,
                0xFE,
                0x76,
                0xE7,
                0xB5,
                0x42,
                0x9B,
                0xBF,
                0x00,
                0x48,
                0x52,
                0x4E,
                0x2B,
                0xD5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineSrcElements
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x54,
                0x53,
                0x5E,
                0x7A,
                0x14,
                0xB1,
                0x72,
                0x4C,
                0xB9,
                0x91,
                0x31,
                0x31,
                0xD7,
                0x50,
                0x32,
                0xEA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngine
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBB,
                0xB0,
                0xA1,
                0x98,
                0xEB,
                0x03,
                0x35,
                0x49,
                0xAE,
                0x7C,
                0x93,
                0xC1,
                0xFA,
                0x0E,
                0x1C,
                0x93
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAD,
                0x5E,
                0x01,
                0x83,
                0xE6,
                0xB1,
                0xD0,
                0x40,
                0xA9,
                0x8A,
                0x37,
                0x14,
                0x5F,
                0xFE,
                0x1A,
                0xD1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineAudioEndpointId
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x98,
                0xAC,
                0x3B,
                0x7A,
                0x76,
                0x0E,
                0xFB,
                0x49,
                0x8C,
                0x20,
                0x8A,
                0x86,
                0xFD,
                0x98,
                0xEA,
                0xF2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineExtension
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0xD6,
                0x69,
                0x2F,
                0xB5,
                0x20,
                0xE9,
                0x41,
                0xAF,
                0xDF,
                0x89,
                0xCE,
                0xD1,
                0xDD,
                0xA0,
                0x4E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineProtectedContent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE8,
                0x21,
                0x80,
                0x9F,
                0x8C,
                0x9C,
                0x7E,
                0x48,
                0xBB,
                0x5C,
                0x79,
                0xAA,
                0x47,
                0x79,
                0x93,
                0x8C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioSourceProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0xF2,
                0xBA,
                0xEB,
                0xC2,
                0xAF,
                0x82,
                0x45,
                0x91,
                0xC6,
                0xB6,
                0x0D,
                0xF2,
                0xE8,
                0x49,
                0x54
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineWebSupport
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA1,
                0x43,
                0x27,
                0xBA,
                0xE0,
                0x07,
                0xEF,
                0x48,
                0x84,
                0xB6,
                0x9A,
                0x2E,
                0xD0,
                0x23,
                0xCA,
                0x6C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaSourceExtensionNotify
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0x13,
                0x90,
                0xA7,
                0xDD,
                0x05,
                0x69,
                0x44,
                0xA7,
                0xB7,
                0x0E,
                0x01,
                0x97,
                0x9E,
                0x36,
                0x1D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFBufferListNotify
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF7,
                0x47,
                0xCD,
                0x24,
                0xD8,
                0x81,
                0x85,
                0x47,
                0xAD,
                0xB2,
                0xAF,
                0x69,
                0x7A,
                0x96,
                0x3C,
                0xD2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSourceBufferNotify
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x23,
                0x76,
                0xE4,
                0x87,
                0xEB,
                0x2C,
                0xD6,
                0x45,
                0x9B,
                0x88,
                0xD8,
                0x52,
                0x0C,
                0x4D,
                0xCB,
                0xBC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSourceBuffer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4B,
                0x3A,
                0xCD,
                0xE2,
                0x25,
                0xAF,
                0x3D,
                0x4D,
                0x91,
                0x10,
                0xDA,
                0x0E,
                0x6F,
                0x8E,
                0xE8,
                0x77
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSourceBufferAppendMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB4,
                0x6F,
                0x66,
                0x19,
                0xBE,
                0xBA,
                0x55,
                0x4C,
                0xBC,
                0x03,
                0x0A,
                0x07,
                0x4D,
                0xA3,
                0x7E,
                0x2A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSourceBufferList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF8,
                0x81,
                0x99,
                0x24,
                0x25,
                0x83,
                0xF3,
                0x41,
                0xB8,
                0x0C,
                0x3B,
                0x9E,
                0x3A,
                0xAD,
                0x0C,
                0xBE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaSourceExtension
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4E,
                0xB9,
                0x67,
                0xE4,
                0x13,
                0xA7,
                0x62,
                0x45,
                0xA8,
                0x02,
                0x81,
                0x6A,
                0x42,
                0xE9,
                0x00,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaSourceExtensionLiveSeekableRange
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD6,
                0xBF,
                0x1A,
                0x5D,
                0x0A,
                0x45,
                0x92,
                0x4D,
                0x9E,
                0xFC,
                0xD6,
                0xB6,
                0xCB,
                0xC1,
                0xF4,
                0xDA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineEME
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0x93,
                0xDC,
                0x50,
                0x4F,
                0xBA,
                0x75,
                0x42,
                0xAE,
                0x66,
                0x83,
                0xE8,
                0x36,
                0xE5,
                0x74,
                0x69
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineSrcElementsEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB3,
                0x6B,
                0x4A,
                0x65,
                0xA3,
                0xE1,
                0x4A,
                0x42,
                0x99,
                0x08,
                0x53,
                0xA4,
                0x3A,
                0x0D,
                0xFD,
                0xA0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineNeedKeyNotify
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x04,
                0x02,
                0xA3,
                0x46,
                0x96,
                0xA6,
                0x18,
                0x4B,
                0x88,
                0x04,
                0x24,
                0x6B,
                0x8F,
                0x03,
                0x1B,
                0xB1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaKeys
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0x1C,
                0xB3,
                0x5C,
                0xFF,
                0x61,
                0x8F,
                0x41,
                0xAF,
                0xDA,
                0xCA,
                0xAF,
                0x41,
                0x42,
                0x1A,
                0x38
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaKeySession
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD5,
                0x67,
                0xFA,
                0x24,
                0xD0,
                0xD1,
                0xC5,
                0x4D,
                0x99,
                0x5C,
                0xC0,
                0xEF,
                0xDC,
                0x19,
                0x1F,
                0xB5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaKeySessionNotify
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF9,
                0x83,
                0x00,
                0x6A,
                0x47,
                0x89,
                0x1D,
                0x4C,
                0x9C,
                0xE0,
                0xCD,
                0xEE,
                0x22,
                0xB2,
                0x31,
                0x35
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCdmSuspendNotify
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD2,
                0x45,
                0x56,
                0x7A,
                0xBD,
                0x43,
                0xFD,
                0x47,
                0x87,
                0xB7,
                0xDC,
                0xD2,
                0x4C,
                0xC7,
                0xD6,
                0x92
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFHDCPStatus
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x54,
                0x0F,
                0x40,
                0xDE,
                0xF1,
                0x5B,
                0xCF,
                0x40,
                0x89,
                0x64,
                0x0B,
                0xEA,
                0x13,
                0x6B,
                0x1E,
                0x3D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineOPMInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE6,
                0x63,
                0x57,
                0x76,
                0x01,
                0x6C,
                0x01,
                0x4B,
                0xBB,
                0x0F,
                0xB8,
                0x29,
                0xF6,
                0x0E,
                0xD2,
                0x8C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineClassFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0x5A,
                0x64,
                0x4D,
                0xAA,
                0x26,
                0x88,
                0x46,
                0x9B,
                0xE1,
                0xDF,
                0x35,
                0x16,
                0x99,
                0x0B,
                0x93
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineClassFactoryEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0x56,
                0x61,
                0xC5,
                0x5B,
                0xEA,
                0xA5,
                0x48,
                0x9D,
                0xF8,
                0xFB,
                0xE0,
                0x35,
                0xD0,
                0x92,
                0x9E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineClassFactory2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEF,
                0x3C,
                0x08,
                0x09,
                0x7F,
                0x86,
                0xF6,
                0x4B,
                0x87,
                0x76,
                0xDE,
                0xE3,
                0xA7,
                0xB4,
                0x2F,
                0xCA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFExtendedDRMTypeSupport
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0xC5,
                0x2E,
                0x33,
                0x58,
                0x37,
                0x8D,
                0x46,
                0xA7,
                0x84,
                0xE3,
                0x8F,
                0x23,
                0x55,
                0x21,
                0x28
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineSupportsSourceTransfer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x56,
                0xB0,
                0x24,
                0xA7,
                0x2E,
                0x1B,
                0x42,
                0x46,
                0xA6,
                0xF3,
                0xDB,
                0x94,
                0x20,
                0xC5,
                0x29,
                0x08
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineTransferSource
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0x04,
                0x23,
                0x24,
                0x54,
                0xFE,
                0xCC,
                0x40,
                0x94,
                0xF3,
                0xFC,
                0xC3,
                0x94,
                0xC3,
                0x40,
                0xD6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTimedText
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC9,
                0x94,
                0x2A,
                0x1F,
                0xDF,
                0xA3,
                0x0D,
                0x43,
                0x9D,
                0x0F,
                0xAC,
                0xD8,
                0x5D,
                0xDC,
                0x29,
                0xAF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTimedTextNotify
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB6,
                0x87,
                0x6B,
                0xDF,
                0x12,
                0xCE,
                0xDB,
                0x45,
                0xAB,
                0xA7,
                0x43,
                0x2F,
                0xE0,
                0x54,
                0xE5,
                0x7D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTimedTextTrack
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2D,
                0xC3,
                0x22,
                0x88,
                0x4E,
                0x65,
                0x33,
                0x42,
                0xBF,
                0x21,
                0xD7,
                0xF2,
                0xE6,
                0x7D,
                0x30,
                0xD4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTimedTextTrackList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4C,
                0x33,
                0xFF,
                0x23,
                0x2C,
                0x44,
                0x5F,
                0x44,
                0xBC,
                0xCC,
                0xED,
                0xC4,
                0x38,
                0xAA,
                0x11,
                0xE2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTimedTextCue
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x47,
                0x04,
                0x56,
                0x1E,
                0x2B,
                0x9A,
                0xE1,
                0x43,
                0xA9,
                0x4C,
                0xB0,
                0xAA,
                0xAB,
                0xFB,
                0xFB,
                0xC9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTimedTextFormattedText
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0xF3,
                0x3A,
                0xE1,
                0x47,
                0x4D,
                0x54,
                0x43,
                0xB1,
                0xF5,
                0xE8,
                0x3A,
                0xE0,
                0xEC,
                0xAE,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTimedTextStyle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5D,
                0x45,
                0xB2,
                0x09,
                0x34,
                0xB8,
                0x01,
                0x4F,
                0xA3,
                0x47,
                0x90,
                0x52,
                0xE2,
                0x1C,
                0x45,
                0x0E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTimedTextRegion
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFC,
                0x2A,
                0xD2,
                0xC8,
                0x47,
                0xBC,
                0xDF,
                0x4B,
                0x9B,
                0x04,
                0x78,
                0x7E,
                0x49,
                0xCE,
                0x3F,
                0x58
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTimedTextBinary
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x12,
                0xA4,
                0xE3,
                0x4A,
                0x45,
                0x05,
                0xC4,
                0x43,
                0xBF,
                0x6F,
                0x6B,
                0x97,
                0xA5,
                0xC6,
                0xC4,
                0x32
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTimedTextCueList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x45,
                0x87,
                0x12,
                0xAD,
                0x1B,
                0x21,
                0xA0,
                0x40,
                0x99,
                0x81,
                0xFE,
                0x65,
                0xF1,
                0x66,
                0xD0,
                0xFD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTimedTextRuby
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF5,
                0xA6,
                0xC6,
                0x76,
                0x55,
                0x49,
                0xE5,
                0x4D,
                0xB2,
                0x7B,
                0x14,
                0xB7,
                0x34,
                0xCC,
                0x14,
                0xB4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTimedTextBouten
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0x3E,
                0x5F,
                0x3C,
                0xC0,
                0x90,
                0x4E,
                0x46,
                0x81,
                0x36,
                0x89,
                0x8D,
                0x29,
                0x75,
                0xF8,
                0x47
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTimedTextStyle2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x99,
                0x91,
                0x63,
                0xDB,
                0x09,
                0xC8,
                0x89,
                0x4C,
                0xBF,
                0xCA,
                0xD0,
                0xBB,
                0xB9,
                0x72,
                0x9D,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineEMENotify
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0x4D,
                0x18,
                0x9E,
                0xB7,
                0xCD,
                0x86,
                0x4F,
                0xB4,
                0x9E,
                0x56,
                0x66,
                0x89,
                0xF4,
                0xA6,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaKeySessionNotify2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A,
                0xE9,
                0xA9,
                0xC3,
                0x88,
                0xDA,
                0xB0,
                0x46,
                0xA1,
                0x10,
                0x6C,
                0xF9,
                0x53,
                0x02,
                0x6C,
                0xB9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaKeySystemAccess
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDA,
                0x3F,
                0xC6,
                0xAE,
                0x97,
                0x7A,
                0x44,
                0x49,
                0xB3,
                0x5C,
                0x6C,
                0x6D,
                0xF8,
                0x08,
                0x5C,
                0xC3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineClassFactory3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4F,
                0x61,
                0x87,
                0x37,
                0xF7,
                0x65,
                0x03,
                0x40,
                0xB6,
                0x73,
                0xEA,
                0xD8,
                0x29,
                0x3A,
                0x0E,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaKeys2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x07,
                0x25,
                0x89,
                0x45,
                0x66,
                0xAD,
                0xE2,
                0x4D,
                0x83,
                0xA2,
                0xAC,
                0xBB,
                0x13,
                0xCD,
                0x8D,
                0x43
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaKeySession2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0x7E,
                0x70,
                0xE9,
                0x55,
                0x6D,
                0x36,
                0x46,
                0xB1,
                0x85,
                0x3D,
                0xE2,
                0x12,
                0x10,
                0xBD,
                0x75
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaEngineClassFactory4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0x56,
                0xE2,
                0xFB,
                0xCF,
                0x43,
                0x9B,
                0x4A,
                0x8C,
                0xB8,
                0xCE,
                0x86,
                0x32,
                0xA3,
                0x41,
                0x86
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}