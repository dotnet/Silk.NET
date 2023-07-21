// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IMFMediaSession
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x34, 0x78, 0x37, 0x90,
                0xD0, 0x21,
                0xEE, 0x4D,
                0x82,
                0x14,
                0xBA,
                0x2E,
                0x3E,
                0x6C,
                0x11,
                0x27
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSourceResolver
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2D, 0xA3, 0xE5, 0xFB,
                0x97, 0xA4,
                0x61, 0x4B,
                0xBB,
                0x85,
                0x97,
                0xB1,
                0xA8,
                0x48,
                0xA6,
                0xE3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaSource
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8D, 0x80, 0x9A, 0x27,
                0xC7, 0xAE,
                0xC8, 0x40,
                0x9C,
                0x6B,
                0xA6,
                0xB4,
                0x92,
                0xC7,
                0x8A,
                0x66
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaSourceEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB9, 0x2E, 0x9B, 0x3C,
                0xD5, 0x86,
                0x14, 0x45,
                0xA3,
                0x94,
                0xF5,
                0x66,
                0x64,
                0xF9,
                0xF0,
                0xD8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFClockConsumer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x62, 0xA6, 0xF2, 0x6E,
                0xC0, 0x47,
                0x66, 0x46,
                0xB1,
                0x3D,
                0xCB,
                0xB7,
                0x17,
                0xF2,
                0xFA,
                0x2C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaStream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8F, 0x10, 0x82, 0xD1,
                0xC6, 0x4E,
                0x3F, 0x44,
                0xAA,
                0x42,
                0xA7,
                0x11,
                0x06,
                0xEC,
                0x82,
                0x5F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x60, 0xA6, 0xF2, 0x6E,
                0xC0, 0x47,
                0x66, 0x46,
                0xB1,
                0x3D,
                0xCB,
                0xB7,
                0x17,
                0xF2,
                0xFA,
                0x2C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFStreamSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xCF, 0xB3, 0x97, 0x0A,
                0x7C, 0x8E,
                0x3D, 0x4A,
                0x8F,
                0x8C,
                0x0C,
                0x84,
                0x3D,
                0xC2,
                0x47,
                0xFB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFVideoSampleAllocator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x10, 0xC9, 0xCB, 0x86,
                0x33, 0xE5,
                0x51, 0x47,
                0x8E,
                0x3B,
                0xF1,
                0x9B,
                0x5B,
                0x80,
                0x6A,
                0x03
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFVideoSampleAllocatorNotify
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xBE, 0xCD, 0x92, 0xA7,
                0x74, 0xC3,
                0x89, 0x4E,
                0x83,
                0x35,
                0x27,
                0x8E,
                0x7B,
                0x99,
                0x56,
                0xA4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFVideoSampleAllocatorNotifyEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1A, 0xAA, 0x78, 0x39,
                0x5B, 0x6D,
                0x7F, 0x4B,
                0xA3,
                0x40,
                0x90,
                0x89,
                0x91,
                0x89,
                0xAE,
                0x34
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFVideoSampleAllocatorCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB4, 0x88, 0x23, 0x99,
                0x72, 0x33,
                0x67, 0x4F,
                0x8B,
                0x6F,
                0xC8,
                0x4C,
                0x07,
                0x1F,
                0x47,
                0x51
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFVideoSampleAllocatorEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x48, 0x3A, 0x5B, 0x54,
                0x83, 0x32,
                0x62, 0x4F,
                0x86,
                0x6F,
                0xA6,
                0x2D,
                0x8F,
                0x59,
                0x8F,
                0x9F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFDXGIDeviceManagerSource
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4B, 0x07, 0xBC, 0x20,
                0x8D, 0x7A,
                0x09, 0x46,
                0x8C,
                0x3B,
                0x64,
                0xA0,
                0xA3,
                0xB5,
                0xD7,
                0xCE
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFVideoProcessorControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD5, 0x75, 0xF6, 0xA3,
                0x19, 0x61,
                0x7F, 0x4F,
                0xA1,
                0x00,
                0x1D,
                0x8B,
                0x28,
                0x0F,
                0x0E,
                0xFB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFVideoProcessorControl2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD3, 0x33, 0xE6, 0xBD,
                0xDC, 0xE1,
                0x7F, 0x4A,
                0xA6,
                0x93,
                0xBB,
                0xAE,
                0x39,
                0x9C,
                0x4A,
                0x20
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFVideoProcessorControl3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF2, 0xB3, 0x24, 0x24,
                0x23, 0xEB,
                0xF1, 0x40,
                0x91,
                0xAA,
                0x74,
                0xBD,
                0xDE,
                0xEA,
                0x08,
                0x83
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFVideoRendererEffectControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD7, 0x33, 0x4D, 0x60,
                0x23, 0xCF,
                0xD5, 0x41,
                0x82,
                0x24,
                0x5B,
                0xBB,
                0xB1,
                0xA8,
                0x74,
                0x75
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTopology
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3A, 0x87, 0xCF, 0x83,
                0xDA, 0xF6,
                0xC8, 0x4B,
                0x82,
                0x3F,
                0xBA,
                0xCF,
                0xD5,
                0x5D,
                0xC4,
                0x33
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTopologyNode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3A, 0x87, 0xCF, 0x83,
                0xDA, 0xF6,
                0xC8, 0x4B,
                0x82,
                0x3F,
                0xBA,
                0xCF,
                0xD5,
                0x5D,
                0xC4,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFGetService
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x88, 0x38, 0x99, 0xFA,
                0x83, 0x43,
                0x5A, 0x41,
                0xA9,
                0x30,
                0xDD,
                0x47,
                0x2A,
                0x8C,
                0xF6,
                0xF7
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFClock
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x45, 0xE9, 0xB1, 0x2E,
                0xB8, 0x18,
                0x39, 0x41,
                0x9B,
                0x1A,
                0xD5,
                0xD5,
                0x84,
                0x81,
                0x85,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFPresentationClock
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5C, 0xE8, 0x8C, 0x86,
                0xA9, 0x8E,
                0x55, 0x4F,
                0xAB,
                0x82,
                0xB0,
                0x09,
                0xA9,
                0x10,
                0xA8,
                0x05
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFPresentationTimeSource
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xCE, 0x2C, 0xF1, 0x7F,
                0x6F, 0xF7,
                0xC2, 0x41,
                0x86,
                0x3B,
                0x16,
                0x66,
                0xC8,
                0xE5,
                0xE1,
                0x39
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFClockStateSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x82, 0x6E, 0x69, 0xF6,
                0xF7, 0x74,
                0x3D, 0x4F,
                0xA1,
                0x78,
                0x8A,
                0x5E,
                0x09,
                0xC3,
                0x65,
                0x9F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFPresentationDescriptor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x11, 0x27, 0xCB, 0x03,
                0xD7, 0x24,
                0xB6, 0x4D,
                0xA1,
                0x7F,
                0xF3,
                0xA7,
                0xA4,
                0x79,
                0xA5,
                0x36
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFStreamDescriptor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x9C, 0x3D, 0xC0, 0x56,
                0xBB, 0x9D,
                0xF5, 0x45,
                0xAB,
                0x4B,
                0xD8,
                0x0F,
                0x47,
                0xC0,
                0x59,
                0x38
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaTypeHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x6C, 0xCF, 0x3D, 0xE9,
                0x07, 0x4B,
                0x1E, 0x4E,
                0x81,
                0x23,
                0xAA,
                0x16,
                0xED,
                0x6E,
                0xAD,
                0xF5
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTimer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xBD, 0x4C, 0x6E, 0xE5,
                0x70, 0x8F,
                0xD8, 0x49,
                0xA0,
                0xF8,
                0xED,
                0xB3,
                0xD6,
                0xAB,
                0x9B,
                0xF2
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFShutdown
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA4, 0x2E, 0xEC, 0x97,
                0x42, 0x0E,
                0x37, 0x49,
                0x97,
                0xAC,
                0x9D,
                0x6D,
                0x32,
                0x88,
                0x24,
                0xE1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTopoLoader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x57, 0x61, 0x9A, 0xDE,
                0x60, 0xF6,
                0x43, 0x46,
                0xB5,
                0x6A,
                0xDF,
                0x9F,
                0x79,
                0x98,
                0xC7,
                0xCD
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFContentProtectionManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x59, 0x24, 0xF9, 0xAC,
                0x61, 0x6A,
                0xBD, 0x42,
                0xB5,
                0x7C,
                0xB4,
                0x3E,
                0x51,
                0x20,
                0x3C,
                0xB0
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFContentEnabler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x59, 0xEF, 0xC4, 0xD3,
                0xCE, 0x49,
                0x81, 0x43,
                0x90,
                0x71,
                0xD5,
                0xBC,
                0xD0,
                0x44,
                0xC7,
                0x70
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMetadata
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8C, 0xFB, 0x8C, 0xF8,
                0x16, 0xEF,
                0x91, 0x49,
                0xB4,
                0x50,
                0xCB,
                0x8C,
                0x69,
                0xE5,
                0x17,
                0x04
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMetadataProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2D, 0x1D, 0x18, 0x56,
                0x21, 0xE2,
                0xDB, 0x4A,
                0xB1,
                0xC8,
                0x3C,
                0xEE,
                0x6A,
                0x53,
                0xF7,
                0x6F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFRateSupport
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xBC, 0xCD, 0x9C, 0x0A,
                0x97, 0xD7,
                0x63, 0x45,
                0x96,
                0x67,
                0x94,
                0xEC,
                0x5D,
                0x79,
                0x29,
                0x2D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFRateControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x21, 0xCD, 0xDD, 0x88,
                0xC3, 0x03,
                0x75, 0x42,
                0x91,
                0xED,
                0x55,
                0xEE,
                0x39,
                0x29,
                0x32,
                0x8F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTimecodeTranslate
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x61, 0x86, 0x9D, 0xAB,
                0xE8, 0xF7,
                0xF4, 0x4E,
                0x98,
                0x61,
                0x89,
                0xF3,
                0x34,
                0xF9,
                0x4E,
                0x74
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSeekInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x53, 0xEA, 0xAF, 0x26,
                0xED, 0xD9,
                0xB5, 0x42,
                0xAB,
                0x80,
                0xE6,
                0x4F,
                0x9E,
                0xE3,
                0x47,
                0x79
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSimpleAudioVolume
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x13, 0xDF, 0x9E, 0x08,
                0x71, 0xCF,
                0x38, 0x43,
                0x8D,
                0x13,
                0x9E,
                0x56,
                0x9D,
                0xBD,
                0xC3,
                0x19
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFAudioStreamVolume
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDB, 0xBB, 0xB1, 0x76,
                0xC8, 0x4E,
                0x36, 0x4F,
                0xB1,
                0x06,
                0x70,
                0xA9,
                0x31,
                0x6D,
                0xF5,
                0x93
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFAudioPolicy
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2B, 0x8C, 0x63, 0xA0,
                0x65, 0x64,
                0x95, 0x43,
                0x9A,
                0xE7,
                0xA3,
                0x21,
                0xA9,
                0xFD,
                0x28,
                0x56
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSampleGrabberSinkCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xBF, 0x80, 0x7B, 0x8C,
                0x42, 0xEE,
                0x59, 0x4B,
                0xB1,
                0xDF,
                0x55,
                0x66,
                0x8E,
                0x1B,
                0xDC,
                0xA8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSampleGrabberSinkCallback2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x50, 0xAA, 0x86, 0xCA,
                0x6E, 0xC4,
                0x9E, 0x42,
                0xAB,
                0x27,
                0x16,
                0xD6,
                0xAC,
                0x68,
                0x44,
                0xCB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFWorkQueueServices
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB8, 0x1B, 0xFE, 0x35,
                0xA9, 0xA3,
                0xFE, 0x40,
                0xBB,
                0xEC,
                0xEB,
                0x56,
                0x9C,
                0x9C,
                0xCC,
                0xA3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFWorkQueueServicesEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1B, 0x96, 0xBF, 0x96,
                0xFE, 0x40,
                0xF1, 0x42,
                0xBA,
                0x9D,
                0x32,
                0x02,
                0x38,
                0xB4,
                0x97,
                0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFQualityManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x86, 0x9D, 0x00, 0x8D,
                0x9F, 0x5B,
                0x15, 0x41,
                0xB1,
                0xFC,
                0x9F,
                0x80,
                0xD5,
                0x2A,
                0xB8,
                0xAB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFQualityAdvise
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE9, 0xE2, 0x15, 0xEC,
                0x6B, 0xE3,
                0x7C, 0x4F,
                0x87,
                0x58,
                0x77,
                0xD4,
                0x52,
                0xEF,
                0x4C,
                0xE7
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFQualityAdvise2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0D, 0x6F, 0x70, 0xF3,
                0xA2, 0x8E,
                0x86, 0x48,
                0x80,
                0x00,
                0x71,
                0x55,
                0xE9,
                0xEC,
                0x2E,
                0xAE
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFQualityAdviseLimits
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4D, 0x8E, 0xCD, 0xDF,
                0xB5, 0x30,
                0x67, 0x45,
                0xAC,
                0xAA,
                0x8E,
                0xB5,
                0xB7,
                0x85,
                0x3D,
                0xC9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFRealTimeClient
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0B, 0xD6, 0x47, 0x23,
                0xB5, 0x3F,
                0x0C, 0x48,
                0x88,
                0x03,
                0x8D,
                0xF3,
                0xAD,
                0xCD,
                0x3E,
                0xF0
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFRealTimeClientEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x48, 0x08, 0x91, 0x03,
                0x16, 0xAB,
                0x11, 0x46,
                0xB1,
                0x00,
                0x17,
                0xB8,
                0x8A,
                0xE2,
                0xF2,
                0x48
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSequencerSource
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x19, 0xD2, 0x7C, 0x19,
                0xCB, 0x19,
                0xE1, 0x4D,
                0xA6,
                0x4C,
                0xAC,
                0xF2,
                0xED,
                0xCB,
                0xE5,
                0x9E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaSourceTopologyProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x09, 0x60, 0x1D, 0x0E,
                0xF3, 0xC9,
                0x2D, 0x44,
                0x8C,
                0x51,
                0xA4,
                0x2D,
                0x2D,
                0x49,
                0x45,
                0x2F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaSourcePresentationProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0A, 0x60, 0x1D, 0x0E,
                0xF3, 0xC9,
                0x2D, 0x44,
                0x8C,
                0x51,
                0xA4,
                0x2D,
                0x2D,
                0x49,
                0x45,
                0x2F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTopologyNodeAttributeEditor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDD, 0xA6, 0x6A, 0x67,
                0x8A, 0x23,
                0x0D, 0x41,
                0xBB,
                0x99,
                0x65,
                0x66,
                0x8D,
                0x01,
                0x60,
                0x5A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFByteStreamBuffering
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x82, 0xD7, 0x66, 0x6D,
                0x4F, 0x1D,
                0xB7, 0x4D,
                0x8C,
                0x63,
                0xCB,
                0x8C,
                0x77,
                0xF1,
                0xEF,
                0x5E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFByteStreamCacheControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA4, 0x2E, 0x04, 0xF5,
                0x96, 0x7A,
                0x75, 0x4A,
                0xAA,
                0x7B,
                0x2B,
                0xE1,
                0xEF,
                0x7F,
                0x88,
                0xD5
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFByteStreamTimeSeek
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xFA, 0x6B, 0x97, 0x64,
                0x61, 0xFB,
                0x41, 0x40,
                0x90,
                0x69,
                0x8C,
                0x9A,
                0x5F,
                0x65,
                0x9B,
                0xEB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFByteStreamCacheControl2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x9C, 0x46, 0xCE, 0x71,
                0x4B, 0xF3,
                0xEA, 0x49,
                0xA5,
                0x6B,
                0x2D,
                0x2A,
                0x10,
                0xE5,
                0x11,
                0x49
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFNetCredential
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x6A, 0xEF, 0x87, 0x5B,
                0xD8, 0x7E,
                0x4F, 0x43,
                0xBA,
                0x0E,
                0x18,
                0x4F,
                0xAC,
                0x16,
                0x28,
                0xD1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFNetCredentialManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x6B, 0xEF, 0x87, 0x5B,
                0xD8, 0x7E,
                0x4F, 0x43,
                0xBA,
                0x0E,
                0x18,
                0x4F,
                0xAC,
                0x16,
                0x28,
                0xD1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFNetCredentialCache
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x6C, 0xEF, 0x87, 0x5B,
                0xD8, 0x7E,
                0x4F, 0x43,
                0xBA,
                0x0E,
                0x18,
                0x4F,
                0xAC,
                0x16,
                0x28,
                0xD1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSSLCertificateManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x87, 0xD8, 0xF7, 0x61,
                0x30, 0x12,
                0x8B, 0x4A,
                0xAE,
                0xBA,
                0x8A,
                0xD4,
                0x34,
                0xD1,
                0xA6,
                0x4D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFNetResourceFilter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA3, 0x78, 0x18, 0x09,
                0x11, 0xBF,
                0x5C, 0x4A,
                0xBC,
                0x9F,
                0x33,
                0x99,
                0x5B,
                0x06,
                0xEF,
                0x2D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSourceOpenMonitor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB3, 0x54, 0x90, 0x05,
                0x7C, 0x02,
                0x4C, 0x49,
                0xA2,
                0x7D,
                0x91,
                0x13,
                0x29,
                0x1C,
                0xF8,
                0x7F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFNetProxyLocator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x83, 0x03, 0xCD, 0xE9,
                0x68, 0xA2,
                0xB4, 0x4B,
                0x82,
                0xDE,
                0x65,
                0x8D,
                0x53,
                0x57,
                0x4D,
                0x41
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFNetProxyLocatorFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x84, 0x03, 0xCD, 0xE9,
                0x68, 0xA2,
                0xB4, 0x4B,
                0x82,
                0xDE,
                0x65,
                0x8D,
                0x53,
                0x57,
                0x4D,
                0x41
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSaveJob
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x63, 0x16, 0x93, 0xE9,
                0xBF, 0x80,
                0x6E, 0x4C,
                0x98,
                0xAF,
                0x5D,
                0xCF,
                0x58,
                0x74,
                0x7D,
                0x1F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFNetSchemeHandlerConfig
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x73, 0x9E, 0xE1, 0x7B,
                0xBF, 0xC9,
                0x8A, 0x46,
                0xAC,
                0x5A,
                0xA5,
                0xE8,
                0x65,
                0x3B,
                0xEC,
                0x87
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSchemeHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x74, 0x7B, 0x4C, 0x6D,
                0xA0, 0x52,
                0xB7, 0x4B,
                0xB0,
                0xDB,
                0x55,
                0xF2,
                0x9F,
                0x47,
                0xA6,
                0x68
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFByteStreamHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA4, 0x0A, 0x42, 0xBB,
                0x5B, 0x76,
                0x1F, 0x4A,
                0x91,
                0xFE,
                0xD6,
                0xA8,
                0xA1,
                0x43,
                0x92,
                0x4C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTrustedInput
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC4, 0x12, 0x26, 0x54,
                0xB8, 0xA1,
                0x32, 0x46,
                0xB5,
                0x21,
                0xDE,
                0x11,
                0xEA,
                0x64,
                0xA0,
                0xB0
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFInputTrustAuthority
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x98, 0x8E, 0x9F, 0xD1,
                0x26, 0xB1,
                0x46, 0x44,
                0x89,
                0x0C,
                0x5D,
                0xCB,
                0x7A,
                0xD7,
                0x14,
                0x53
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTrustedOutput
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x95, 0x8E, 0x9F, 0xD1,
                0x26, 0xB1,
                0x46, 0x44,
                0x89,
                0x0C,
                0x5D,
                0xCB,
                0x7A,
                0xD7,
                0x14,
                0x53
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFOutputTrustAuthority
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x94, 0x8E, 0x9F, 0xD1,
                0x26, 0xB1,
                0x46, 0x44,
                0x89,
                0x0C,
                0x5D,
                0xCB,
                0x7A,
                0xD7,
                0x14,
                0x53
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFOutputPolicy
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0A, 0xF1, 0x00, 0x7F,
                0xED, 0xDA,
                0xAF, 0x41,
                0xAB,
                0x26,
                0x5F,
                0xDF,
                0xA4,
                0xDF,
                0xBA,
                0x3C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFOutputSchema
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5B, 0xFC, 0xE0, 0x7B,
                0xD9, 0xAB,
                0xFB, 0x44,
                0xA5,
                0xC8,
                0xF5,
                0x01,
                0x36,
                0xE7,
                0x15,
                0x99
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSecureChannel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5D, 0x55, 0xAE, 0xD0,
                0x12, 0x3B,
                0x97, 0x4D,
                0xB0,
                0x60,
                0x09,
                0x90,
                0xBC,
                0x5A,
                0xEB,
                0x67
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSampleProtection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5F, 0x39, 0x36, 0x8E,
                0xB9, 0xC7,
                0xC4, 0x43,
                0xA5,
                0x4D,
                0x51,
                0x2B,
                0x4A,
                0xF6,
                0x3C,
                0x95
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaSinkPreroll
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2A, 0x4B, 0xFD, 0x5D,
                0x74, 0x76,
                0x10, 0x41,
                0xA4,
                0xE6,
                0x8A,
                0x68,
                0xFD,
                0x5F,
                0x36,
                0x88
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFFinalizableMediaSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4A, 0xB7, 0xEC, 0xEA,
                0x50, 0x9A,
                0xCE, 0x42,
                0x95,
                0x41,
                0x6A,
                0x7F,
                0x57,
                0xAA,
                0x4A,
                0xD7
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFStreamingSinkConfig
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x41, 0xAA, 0xB7, 0x9D,
                0xC5, 0x3C,
                0xD4, 0x40,
                0x85,
                0x09,
                0x55,
                0x58,
                0x04,
                0xAD,
                0x34,
                0xCC
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFRemoteProxy
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAD, 0x23, 0x4E, 0x99,
                0xC2, 0x1C,
                0x3C, 0x49,
                0xB9,
                0xFA,
                0x46,
                0xF1,
                0xCB,
                0x04,
                0x0F,
                0xA4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFObjectReferenceStream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE3, 0x5B, 0xEF, 0x09,
                0xA7, 0xC8,
                0x9E, 0x46,
                0x8B,
                0x70,
                0x73,
                0xBF,
                0x25,
                0xBB,
                0x19,
                0x3F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFPMPHost
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA9, 0xA1, 0x0C, 0xF7,
                0xC7, 0xFD,
                0x82, 0x47,
                0xB9,
                0x94,
                0xAD,
                0xFF,
                0xB1,
                0xC9,
                0x86,
                0x06
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFPMPClient
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5D, 0x65, 0x4E, 0x6C,
                0xD8, 0xEA,
                0x21, 0x44,
                0xB6,
                0xB9,
                0x54,
                0xDC,
                0xDB,
                0xBD,
                0xF8,
                0x20
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFPMPServer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAF, 0x23, 0x4E, 0x99,
                0xC2, 0x1C,
                0x3C, 0x49,
                0xB9,
                0xFA,
                0x46,
                0xF1,
                0xCB,
                0x04,
                0x0F,
                0xA4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFRemoteDesktopPlugin
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x09, 0x63, 0xDE, 0x1C,
                0xE0, 0xCA,
                0x40, 0x49,
                0x90,
                0x7E,
                0xC1,
                0xEC,
                0x9C,
                0x3D,
                0x1D,
                0x4A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSAMIStyle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDD, 0x25, 0xE0, 0xA7,
                0x03, 0x53,
                0x62, 0x4A,
                0x89,
                0xD6,
                0xE7,
                0x47,
                0xE1,
                0xEF,
                0xAC,
                0x73
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTranscodeProfile
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA3, 0xDB, 0xDF, 0x4A,
                0xB0, 0x7A,
                0x53, 0x49,
                0xA6,
                0x2B,
                0x46,
                0x1E,
                0x7F,
                0xF3,
                0xDA,
                0x1E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTranscodeSinkInfoProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2E, 0xCD, 0xFF, 0x8C,
                0x03, 0x5A,
                0x3A, 0x4A,
                0xAF,
                0xF7,
                0xED,
                0xCD,
                0x10,
                0x7C,
                0x62,
                0x0E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFFieldOfUseMFTUnlock
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD3, 0x71, 0x8E, 0x50,
                0x66, 0xEC,
                0xC3, 0x4F,
                0x87,
                0x75,
                0xB4,
                0xB9,
                0xED,
                0x6B,
                0xA8,
                0x47
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFLocalMFTRegistration
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x73, 0x4D, 0x9C, 0x14,
                0xBE, 0xB4,
                0x8D, 0x4F,
                0x8B,
                0x87,
                0x07,
                0x9E,
                0x92,
                0x6B,
                0x6A,
                0xDD
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCapturePhotoConfirmation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x49, 0x85, 0xF6, 0x19,
                0x8A, 0xCA,
                0x06, 0x47,
                0xA4,
                0xEF,
                0x48,
                0x1D,
                0xBC,
                0x95,
                0xE1,
                0x2C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFPMPHostApp
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4A, 0x05, 0xD2, 0x84,
                0xA1, 0x3A,
                0x28, 0x47,
                0xA3,
                0xB0,
                0x44,
                0x0A,
                0x41,
                0x8C,
                0xF4,
                0x9C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFPMPClientApp
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x46, 0xF6, 0x04, 0xC0,
                0x2C, 0xBE,
                0xF3, 0x48,
                0x93,
                0xA2,
                0xA0,
                0x98,
                0x3E,
                0xBA,
                0x11,
                0x08
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaStreamSourceSampleRequest
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF9, 0x9A, 0x0B, 0x38,
                0x5B, 0xA8,
                0x78, 0x4E,
                0xA2,
                0xAF,
                0xEA,
                0x5C,
                0xE6,
                0x45,
                0xC6,
                0xB4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFTrackedSample
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE9, 0xF8, 0x5B, 0x24,
                0x55, 0x07,
                0xF7, 0x40,
                0x88,
                0xA5,
                0xAE,
                0x0F,
                0x18,
                0xD5,
                0x5E,
                0x17
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFProtectedEnvironmentAccess
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x45, 0xC8, 0x5D, 0xEF,
                0xD9, 0xF0,
                0xC9, 0x4E,
                0xB0,
                0x0C,
                0xCB,
                0x51,
                0x83,
                0xD3,
                0x84,
                0x34
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSignedLibrary
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xCA, 0x4B, 0x72, 0x4A,
                0x6A, 0xFF,
                0x07, 0x4C,
                0x8E,
                0x0D,
                0x7A,
                0x35,
                0x84,
                0x21,
                0xCF,
                0x06
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSystemId
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3A, 0xAF, 0xF4, 0xFF,
                0xC1, 0x1F,
                0xF9, 0x4E,
                0xA2,
                0x9B,
                0xD2,
                0x6C,
                0x49,
                0xE2,
                0xF3,
                0x1A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFContentProtectionDevice
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x74, 0x71, 0x25, 0xE6,
                0x60, 0xA0,
                0x9A, 0x4C,
                0xA0,
                0x88,
                0x3B,
                0x1B,
                0x47,
                0x1C,
                0xAD,
                0x28
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFContentDecryptorContext
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xBD, 0xB1, 0xC4, 0x7E,
                0xFB, 0x43,
                0x63, 0x47,
                0x85,
                0xD2,
                0x64,
                0xFC,
                0xB5,
                0xC5,
                0xF4,
                0xCB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFNetCrossOriginSupport
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x44, 0x7D, 0x2B, 0xBC,
                0x2D, 0xA7,
                0xD5, 0x49,
                0x83,
                0x76,
                0x14,
                0x80,
                0xDE,
                0xE5,
                0x8B,
                0x22
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFHttpDownloadRequest
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDF, 0xFD, 0x79, 0xF7,
                0xE7, 0x26,
                0x70, 0x42,
                0x8A,
                0x8B,
                0xB9,
                0x83,
                0xD1,
                0x85,
                0x9D,
                0xE0
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFHttpDownloadSession
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2C, 0x9A, 0xFA, 0x71,
                0xCE, 0x53,
                0x62, 0x46,
                0xA1,
                0x32,
                0x1A,
                0x7E,
                0x8C,
                0xBF,
                0x62,
                0xDB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFHttpDownloadSessionProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB9, 0xF4, 0x4C, 0x1B,
                0x16, 0x3A,
                0x15, 0x41,
                0x83,
                0x9D,
                0x03,
                0xCC,
                0x5C,
                0x99,
                0xDF,
                0x01
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaSource2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x14, 0x34, 0xB0, 0xFB,
                0x3B, 0xD1,
                0x86, 0x47,
                0x83,
                0x19,
                0x5A,
                0xC5,
                0x1F,
                0xC0,
                0xA1,
                0x36
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaStream2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD6, 0x37, 0xBC, 0xC5,
                0xC7, 0x75,
                0xA1, 0x46,
                0xA1,
                0x32,
                0x81,
                0xB5,
                0xF7,
                0x23,
                0xC2,
                0x0F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSensorDevice
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF2, 0x48, 0x9F, 0xFB,
                0x18, 0x2A,
                0x28, 0x4E,
                0x97,
                0x30,
                0x78,
                0x6F,
                0x30,
                0xF0,
                0x4D,
                0xC4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSensorGroup
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3A, 0x24, 0x10, 0x41,
                0x57, 0x97,
                0x1F, 0x46,
                0x89,
                0xF1,
                0xF2,
                0x23,
                0x45,
                0xBC,
                0xAB,
                0x4E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSensorStream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x71, 0x21, 0xA4, 0xE9,
                0x6E, 0xC5,
                0x8A, 0x49,
                0x8B,
                0x39,
                0xED,
                0xA5,
                0xA0,
                0x70,
                0xB7,
                0xFC
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSensorTransformFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xEE, 0xC2, 0xD9, 0xEE,
                0xB4, 0x66,
                0x18, 0x4F,
                0xA6,
                0x97,
                0xAC,
                0x7D,
                0x39,
                0x60,
                0x21,
                0x5C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSensorProfile
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD1, 0x65, 0xF7, 0x22,
                0xAB, 0x8D,
                0x07, 0x41,
                0x84,
                0x6D,
                0x56,
                0xBA,
                0xF7,
                0x22,
                0x15,
                0xE7
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSensorProfileCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5B, 0xA5, 0x5E, 0xC9,
                0x87, 0x01,
                0xBE, 0x48,
                0x93,
                0x53,
                0x8D,
                0x25,
                0x07,
                0x66,
                0x23,
                0x51
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSensorProcessActivity
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4A, 0x7F, 0xDC, 0x39,
                0x41, 0xB1,
                0x19, 0x47,
                0x81,
                0x3C,
                0xA7,
                0xF4,
                0x61,
                0x62,
                0xA2,
                0xB8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSensorActivityReport
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE1, 0x4B, 0x8C, 0x3E,
                0xC2, 0xA8,
                0x28, 0x45,
                0x90,
                0xDE,
                0x28,
                0x51,
                0xBD,
                0xE5,
                0xFE,
                0xAD
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSensorActivitiesReport
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5E, 0x7A, 0x3F, 0x68,
                0x19, 0x4A,
                0xCD, 0x43,
                0xB1,
                0xA9,
                0xDB,
                0xF4,
                0xAB,
                0x3F,
                0x77,
                0x77
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSensorActivitiesReportCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xEE, 0x72, 0x50, 0xDE,
                0xE3, 0xDB,
                0xDC, 0x46,
                0x8A,
                0x87,
                0xB6,
                0xF6,
                0x31,
                0x19,
                0x47,
                0x51
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSensorActivityMonitor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x45, 0xF1, 0xCE, 0xD0,
                0xF4, 0xB3,
                0x40, 0x43,
                0xA2,
                0xE5,
                0x7A,
                0x50,
                0x80,
                0xCA,
                0x05,
                0xCB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFExtendedCameraIntrinsicModel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x64, 0x5E, 0x59, 0x5C,
                0x30, 0x46,
                0x31, 0x42,
                0x85,
                0x5A,
                0x12,
                0x84,
                0x2F,
                0x73,
                0x32,
                0x45
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFExtendedCameraIntrinsicsDistortionModel6KT
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3B, 0x65, 0xC2, 0x74,
                0x55, 0x5F,
                0xB1, 0x4E,
                0x9F,
                0x0F,
                0x18,
                0xB8,
                0xF6,
                0x8B,
                0x7D,
                0x3D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFExtendedCameraIntrinsicsDistortionModelArcTan
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x95, 0x5F, 0x2D, 0x81,
                0x72, 0xB5,
                0xDC, 0x45,
                0xBA,
                0xFC,
                0xAE,
                0x24,
                0x19,
                0x9D,
                0xDD,
                0xA8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFExtendedCameraIntrinsics
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAC, 0x6D, 0x7F, 0x68,
                0x87, 0x69,
                0x50, 0x47,
                0xA1,
                0x6A,
                0x73,
                0x4D,
                0x1E,
                0x7A,
                0x10,
                0xFE
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFExtendedCameraControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x20, 0x35, 0xE3, 0x38,
                0xA1, 0xFC,
                0x45, 0x48,
                0xA2,
                0x7A,
                0x68,
                0xB7,
                0xC6,
                0xAB,
                0x37,
                0x89
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFExtendedCameraController
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xEE, 0xBF, 0x1E, 0xB9,
                0x03, 0xCA,
                0xF4, 0x4A,
                0x8A,
                0x82,
                0xA3,
                0x17,
                0x52,
                0xF4,
                0xA0,
                0xFC
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFRelativePanelReport
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xEA, 0x62, 0x53, 0xF2,
                0x0E, 0x2C,
                0x7F, 0x44,
                0x81,
                0xE2,
                0x75,
                0x59,
                0x14,
                0xCD,
                0xC0,
                0xC3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFRelativePanelWatcher
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF6, 0xF7, 0x1A, 0x42,
                0x3E, 0x57,
                0xD0, 0x4A,
                0x8F,
                0xDA,
                0x2E,
                0x57,
                0xCE,
                0xDB,
                0x18,
                0xC6
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFVideoCaptureSampleAllocator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC7, 0x77, 0x5B, 0x72,
                0x9F, 0xCA,
                0xE5, 0x4F,
                0x9D,
                0x72,
                0x99,
                0x46,
                0xBF,
                0x9B,
                0x3C,
                0x70
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSampleAllocatorControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x58, 0xB9, 0x62, 0xDA,
                0x38, 0x3A,
                0x97, 0x4A,
                0xBD,
                0x27,
                0x14,
                0x9C,
                0x64,
                0x0C,
                0x07,
                0x71
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCameraOcclusionStateReport
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xCF, 0xB2, 0x40, 0x16,
                0xDA, 0x74,
                0x62, 0x44,
                0xA4,
                0x3B,
                0xB7,
                0x6D,
                0x3B,
                0xDC,
                0x14,
                0x34
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCameraOcclusionStateReportCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC7, 0x41, 0x58, 0x6E,
                0x89, 0x38,
                0x19, 0x40,
                0x90,
                0x35,
                0x78,
                0x3F,
                0xB1,
                0x9B,
                0x59,
                0x48
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCameraOcclusionStateMonitor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x46, 0x2F, 0x69, 0xCC,
                0x97, 0xC6,
                0xE2, 0x47,
                0xA7,
                0x2D,
                0x7B,
                0x06,
                0x46,
                0x17,
                0x74,
                0x9B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCameraControlNotify
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0D, 0x54, 0xF2, 0xE8,
                0x8A, 0x55,
                0x49, 0x44,
                0x8B,
                0x64,
                0x48,
                0x63,
                0x46,
                0x7A,
                0x9F,
                0xE8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCameraControlMonitor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC9, 0xF2, 0x46, 0x4D,
                0xBA, 0x28,
                0x70, 0x49,
                0x8C,
                0x7B,
                0x1F,
                0x0C,
                0x9D,
                0x80,
                0xAF,
                0x69
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCameraControlDefaults
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x62, 0x06, 0x51, 0x75,
                0x34, 0xB0,
                0xF4, 0x48,
                0x88,
                0xA7,
                0x8D,
                0xE6,
                0x1D,
                0xAA,
                0x4A,
                0xF9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCameraControlDefaultsCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0F, 0x3D, 0xD4, 0x92,
                0xA8, 0x54,
                0xAE, 0x4B,
                0x96,
                0xDA,
                0x35,
                0x6D,
                0x25,
                0x9A,
                0x5C,
                0x26
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCameraConfigurationManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x17, 0xF6, 0x24, 0xA6,
                0x04, 0x47,
                0x06, 0x42,
                0x8A,
                0x6D,
                0xEB,
                0xDA,
                0x4A,
                0x09,
                0x39,
                0x85
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
