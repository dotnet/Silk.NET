// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_CODECAPI_AVEncCommonFormatConstraint
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB8,
                0xB9,
                0xCB,
                0x57,
                0x6F,
                0x11,
                0x51,
                0x49,
                0xB4,
                0x0C,
                0xC2,
                0xA0,
                0x35,
                0xED,
                0x8F,
                0x17
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncCommonFormatUnSpecified
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5A,
                0xA3,
                0x46,
                0xAF,
                0x24,
                0x60,
                0x25,
                0x45,
                0xA4,
                0x8A,
                0x09,
                0x4B,
                0x97,
                0xF5,
                0xB3,
                0xC2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncCommonFormatDVD_V
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC4,
                0x98,
                0x95,
                0xCC,
                0xFE,
                0xE7,
                0x1D,
                0x45,
                0xB1,
                0xCA,
                0x76,
                0x1B,
                0xC8,
                0x40,
                0xB7,
                0xF3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncCommonFormatDVD_DashVR
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD6,
                0x99,
                0x51,
                0xE5,
                0x4C,
                0x04,
                0xAE,
                0x4D,
                0xA4,
                0x88,
                0x53,
                0x1E,
                0xD3,
                0x06,
                0x23,
                0x5B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncCommonFormatDVD_PlusVR
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2E,
                0x6F,
                0x4C,
                0xE7,
                0x37,
                0xEC,
                0x8D,
                0x47,
                0x9A,
                0xF4,
                0xA5,
                0xE1,
                0x35,
                0xB6,
                0x27,
                0x1C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncCommonFormatVCD
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF7,
                0x5B,
                0x03,
                0x95,
                0x90,
                0x9D,
                0xFF,
                0x40,
                0xAD,
                0x5C,
                0x5C,
                0xF8,
                0xCF,
                0x71,
                0xCA,
                0x1D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncCommonFormatSVCD
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x18,
                0x58,
                0xD8,
                0x51,
                0x20,
                0x82,
                0x8C,
                0x44,
                0x80,
                0x66,
                0xD6,
                0x9B,
                0xED,
                0x16,
                0xC9,
                0xAD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncCommonFormatATSC
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0x89,
                0x7B,
                0x8D,
                0x19,
                0xA0,
                0x70,
                0x46,
                0xAA,
                0x76,
                0x2E,
                0xDC,
                0xAC,
                0x7A,
                0xC2,
                0x96
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncCommonFormatDVB
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8F,
                0x0D,
                0x83,
                0x71,
                0x33,
                0x6C,
                0x0D,
                0x43,
                0x84,
                0x4B,
                0xC2,
                0x70,
                0x5B,
                0xAA,
                0xE6,
                0xDB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncCommonFormatMP3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0x33,
                0x97,
                0x34,
                0x08,
                0xEB,
                0xC2,
                0x4D,
                0x81,
                0x97,
                0xE4,
                0x98,
                0x35,
                0xEF,
                0x82,
                0x8B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncCommonFormatHighMAT
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0xE7,
                0xAB,
                0x1E,
                0x2B,
                0xFB,
                0x28,
                0x49,
                0x90,
                0xD1,
                0x78,
                0xDB,
                0x88,
                0xEE,
                0xE8,
                0x89
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncCommonFormatHighMPV
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB8,
                0x5D,
                0xD2,
                0xA2,
                0xF9,
                0xB8,
                0xC2,
                0x42,
                0x8B,
                0xC7,
                0x0B,
                0x93,
                0xCF,
                0x60,
                0x47,
                0x88
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCodecType
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0x4A,
                0xAF,
                0x08,
                0xF2,
                0xF3,
                0x74,
                0x4C,
                0x9D,
                0xCF,
                0x37,
                0xF2,
                0xEC,
                0x79,
                0xF8,
                0x26
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncMPEG1Video
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFE,
                0xFE,
                0xDA,
                0xC8,
                0x1E,
                0xDA,
                0x74,
                0x47,
                0xB2,
                0x7D,
                0x11,
                0x83,
                0x0C,
                0x16,
                0xB1,
                0xFE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncMPEG2Video
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9A,
                0xC1,
                0x6D,
                0x04,
                0x77,
                0x66,
                0xAA,
                0x4A,
                0xA3,
                0x1D,
                0xC1,
                0xAB,
                0x71,
                0x6F,
                0x45,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncMPEG1Audio
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0x13,
                0xDD,
                0xD4,
                0x4A,
                0xCD,
                0xD6,
                0x4C,
                0x81,
                0x38,
                0xB9,
                0x4D,
                0xB4,
                0x54,
                0x2B,
                0x04
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncMPEG2Audio
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1F,
                0xBB,
                0x4C,
                0xEE,
                0x3F,
                0x9C,
                0x70,
                0x47,
                0x92,
                0xB5,
                0xFC,
                0xB7,
                0xC2,
                0xA8,
                0xD3,
                0x81
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncWMV
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9B,
                0xEF,
                0x0F,
                0x4E,
                0x43,
                0x1D,
                0xBD,
                0x41,
                0xB8,
                0xBD,
                0x4D,
                0x7B,
                0xF7,
                0x45,
                0x7A,
                0x2A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEndMPEG4Video
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A,
                0xB1,
                0x37,
                0xDD,
                0x03,
                0x95,
                0x8B,
                0x4F,
                0xB8,
                0xD0,
                0x32,
                0x4A,
                0x00,
                0xC0,
                0xA1,
                0xCF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncH264Video
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAB,
                0x4E,
                0x04,
                0x95,
                0xB3,
                0x31,
                0xDE,
                0x47,
                0x8E,
                0x75,
                0x38,
                0xA4,
                0x2B,
                0xB0,
                0x3E,
                0x28
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncDV
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0x69,
                0xB7,
                0x09,
                0x29,
                0x33,
                0xFB,
                0x44,
                0x89,
                0x54,
                0xFA,
                0x30,
                0x93,
                0x7D,
                0x3D,
                0x5A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncWMAPro
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0xF9,
                0x55,
                0x19,
                0xF7,
                0x33,
                0x68,
                0x4A,
                0xAB,
                0x81,
                0x53,
                0xF5,
                0x65,
                0x71,
                0x25,
                0xC4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncWMALossless
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x65,
                0x72,
                0xCA,
                0x55,
                0xD8,
                0x23,
                0x61,
                0x47,
                0x90,
                0x31,
                0xB7,
                0x4F,
                0xBE,
                0x12,
                0xF4,
                0xC1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncWMAVoice
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCB,
                0x18,
                0xED,
                0x13,
                0xE8,
                0x50,
                0x76,
                0x42,
                0xA2,
                0x88,
                0xA6,
                0xAA,
                0x22,
                0x83,
                0x82,
                0xD9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncDolbyDigitalPro
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCC,
                0x76,
                0xBE,
                0xF5,
                0xF8,
                0x0F,
                0xEB,
                0x40,
                0x9C,
                0xB1,
                0xBB,
                0xA9,
                0x40,
                0x04,
                0xD4,
                0x4F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncDolbyDigitalConsumer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6C,
                0xBF,
                0xA7,
                0xC1,
                0x59,
                0x00,
                0xFA,
                0x4B,
                0x94,
                0xEF,
                0xEF,
                0x74,
                0x7A,
                0x76,
                0x8D,
                0x52
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncDolbyDigitalPlus
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0x1B,
                0x8D,
                0x69,
                0xDD,
                0xF7,
                0x5C,
                0x41,
                0x97,
                0x1C,
                0x42,
                0x49,
                0x2A,
                0x20,
                0x56,
                0xC6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncDTSHD
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0xE6,
                0x52,
                0x20,
                0x9D,
                0x46,
                0xFB,
                0x4B,
                0x80,
                0xCA,
                0x1D,
                0x65,
                0x6E,
                0x7E,
                0x91,
                0x8F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncDTS
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA2,
                0xCA,
                0xFB,
                0x45,
                0x6E,
                0x5E,
                0xB0,
                0x4A,
                0x88,
                0x93,
                0x59,
                0x03,
                0xBE,
                0xE9,
                0x3A,
                0xCF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncMLP
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x29,
                0x3E,
                0xF7,
                0x05,
                0xD1,
                0xF0,
                0x1E,
                0x43,
                0xA4,
                0x1C,
                0xA4,
                0x74,
                0x32,
                0xEC,
                0x5A,
                0x66
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncPCM
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF4,
                0xE7,
                0x4B,
                0x84,
                0xCF,
                0x26,
                0x79,
                0x47,
                0xB3,
                0x86,
                0xCC,
                0x05,
                0xD1,
                0x87,
                0x99,
                0x0C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVEncSDDS
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2F,
                0xB8,
                0xC1,
                0x1D,
                0xC8,
                0x11,
                0x71,
                0x4C,
                0xB7,
                0xB6,
                0xEE,
                0x3E,
                0xB9,
                0xBC,
                0x2B,
                0x94
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonRateControlMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE9,
                0x08,
                0x06,
                0x1C,
                0x0C,
                0x37,
                0x10,
                0x47,
                0x8A,
                0x58,
                0xCB,
                0x61,
                0x81,
                0xC4,
                0x24,
                0x23
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonLowLatency
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x55,
                0xCD,
                0x3E,
                0x9D,
                0xE8,
                0x89,
                0x0A,
                0x49,
                0x97,
                0x0A,
                0x0C,
                0x95,
                0x48,
                0xD5,
                0xA5,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonMultipassMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4C,
                0x3D,
                0x53,
                0x22,
                0xE1,
                0x47,
                0xB5,
                0x41,
                0x93,
                0x52,
                0xA2,
                0xB7,
                0x78,
                0x0E,
                0x7A,
                0xC4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonPassStart
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9F,
                0x73,
                0x67,
                0x6A,
                0xB5,
                0x4E,
                0x85,
                0x43,
                0x99,
                0x28,
                0xF2,
                0x76,
                0xA9,
                0x39,
                0xEF,
                0x95
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonPassEnd
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0x01,
                0x3D,
                0x0E,
                0x5C,
                0xC8,
                0x7D,
                0x46,
                0x8B,
                0x60,
                0xC4,
                0x10,
                0x12,
                0xEE,
                0x3B,
                0xF6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonRealTime
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF6,
                0x0F,
                0x3A,
                0x14,
                0x31,
                0xA1,
                0xDA,
                0x43,
                0xB8,
                0x1E,
                0x98,
                0xFB,
                0xB8,
                0xEC,
                0x37,
                0x8E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonQuality
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA3,
                0x57,
                0xBF,
                0xFC,
                0xA5,
                0x7E,
                0x0C,
                0x4B,
                0x96,
                0x44,
                0x69,
                0xB4,
                0x0C,
                0x39,
                0xC3,
                0x91
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonQualityVsSpeed
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF8,
                0x2D,
                0x33,
                0x98,
                0xCD,
                0x03,
                0x6B,
                0x47,
                0x89,
                0xFA,
                0x3F,
                0x9E,
                0x44,
                0x2D,
                0xEC,
                0x9F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonTranscodeEncodingProfile
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0x78,
                0x47,
                0x69,
                0x08,
                0xF5,
                0xA9,
                0x4E,
                0xB1,
                0xE9,
                0xA1,
                0xFE,
                0x3A,
                0x49,
                0xFB,
                0xC9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonMeanBitRate
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x74,
                0x23,
                0x22,
                0xF7,
                0x44,
                0x21,
                0x15,
                0x48,
                0xB5,
                0x50,
                0xA3,
                0x7F,
                0x8E,
                0x12,
                0xEE,
                0x52
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonMeanBitRateInterval
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0x2F,
                0xAA,
                0xBF,
                0x82,
                0xCB,
                0xC0,
                0x4B,
                0x84,
                0x74,
                0xF0,
                0x6A,
                0x8A,
                0x0D,
                0x02,
                0x58
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonMaxBitRate
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0xEA,
                0x51,
                0x96,
                0xB9,
                0x39,
                0xBF,
                0x4E,
                0x85,
                0xEF,
                0xD7,
                0xF4,
                0x44,
                0xEC,
                0x74,
                0x65
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonMinBitRate
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB2,
                0x05,
                0x14,
                0x10,
                0x83,
                0x20,
                0x34,
                0x40,
                0xA8,
                0x06,
                0xEF,
                0xBE,
                0xDD,
                0xD7,
                0xC9,
                0xFF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonBufferSize
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x74,
                0x65,
                0xB9,
                0x0D,
                0xA4,
                0xB6,
                0x8B,
                0x4C,
                0x81,
                0x06,
                0x37,
                0x73,
                0xDE,
                0x03,
                0x10,
                0xCD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonBufferInLevel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0xC8,
                0xC5,
                0xD9,
                0x74,
                0xFC,
                0x64,
                0x40,
                0x94,
                0xE9,
                0xCD,
                0x19,
                0xF9,
                0x47,
                0xED,
                0x45
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonBufferOutLevel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0x7F,
                0xAE,
                0xCC,
                0xBC,
                0xD0,
                0x3D,
                0x4E,
                0xA5,
                0x7E,
                0xFB,
                0x57,
                0x40,
                0x14,
                0x00,
                0x69
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonStreamEndHandling
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAF,
                0x30,
                0xAD,
                0x6A,
                0xA8,
                0x6B,
                0xCC,
                0x4C,
                0x8F,
                0xCA,
                0x18,
                0xD1,
                0x9B,
                0xEA,
                0xEB,
                0x1C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncStatCommonCompletedPasses
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0xE5,
                0x5D,
                0x3E,
                0xF7,
                0x9D,
                0x8C,
                0x43,
                0x85,
                0x4F,
                0x9F,
                0x7D,
                0xD3,
                0x68,
                0x3D,
                0x34
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoOutputFrameRate
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC3,
                0xE7,
                0x85,
                0xEA,
                0x67,
                0x95,
                0x99,
                0x4D,
                0x87,
                0xC4,
                0x02,
                0xC1,
                0xC2,
                0x78,
                0xCA,
                0x7C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoOutputFrameRateConversion
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF4,
                0x8B,
                0x06,
                0x8C,
                0x9A,
                0x36,
                0xA3,
                0x4B,
                0x82,
                0xFD,
                0xB2,
                0x51,
                0x8F,
                0xB3,
                0x39,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoPixelAspectRatio
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8F,
                0x71,
                0xDC,
                0x3C,
                0xE9,
                0xB3,
                0xB6,
                0x4E,
                0xA5,
                0x7F,
                0xCF,
                0x1F,
                0x1B,
                0x32,
                0x1B,
                0x87
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoAcceleration_MPEG2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2E,
                0x8A,
                0xDB,
                0xF7,
                0x48,
                0x4F,
                0xE8,
                0x4E,
                0xAE,
                0x31,
                0x8B,
                0x6E,
                0xBE,
                0x55,
                0x8A,
                0xE2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoAcceleration_H264
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2F,
                0x8A,
                0xDB,
                0xF7,
                0x48,
                0x4F,
                0xE8,
                0x4E,
                0xAE,
                0x31,
                0x8B,
                0x6E,
                0xBE,
                0x55,
                0x8A,
                0xE2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoAcceleration_VC1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0x8A,
                0xDB,
                0xF7,
                0x48,
                0x4F,
                0xE8,
                0x4E,
                0xAE,
                0x31,
                0x8B,
                0x6E,
                0xBE,
                0x55,
                0x8A,
                0xE2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoProcDeinterlaceCSC
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0x8A,
                0xDB,
                0xF7,
                0x48,
                0x4F,
                0xE8,
                0x4E,
                0xAE,
                0x31,
                0x8B,
                0x6E,
                0xBE,
                0x55,
                0x8A,
                0xE2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoThumbnailGenerationMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0x8E,
                0xFD,
                0x2E,
                0x50,
                0x11,
                0x28,
                0x43,
                0x9C,
                0xF5,
                0x66,
                0xDC,
                0xE9,
                0x33,
                0xFC,
                0xF4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoMaxCodedWidth
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB8,
                0x57,
                0xE5,
                0x5A,
                0xAF,
                0x77,
                0xF5,
                0x41,
                0x9F,
                0xA6,
                0x4D,
                0xB2,
                0xFE,
                0x1D,
                0x4B,
                0xCA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoMaxCodedHeight
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6A,
                0xA1,
                0x62,
                0x72,
                0xDC,
                0xD2,
                0x75,
                0x4E,
                0x9B,
                0xA8,
                0x65,
                0xC0,
                0xC6,
                0xD3,
                0x2B,
                0x13
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecNumWorkerThreads
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE8,
                0xC3,
                0x61,
                0x95,
                0x9E,
                0xEA,
                0x35,
                0x44,
                0x9B,
                0x1E,
                0xA9,
                0x3E,
                0x69,
                0x18,
                0x94,
                0xD8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecSoftwareDynamicFormatChange
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0A,
                0x2F,
                0x2E,
                0x86,
                0x7B,
                0x50,
                0xFF,
                0x47,
                0xAF,
                0x47,
                0x01,
                0xE2,
                0x62,
                0x42,
                0x98,
                0xB7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecDisableVideoPostProcessing
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x93,
                0x91,
                0x74,
                0xF8,
                0x7A,
                0x66,
                0x2C,
                0x4F,
                0xA9,
                0xE8,
                0x5D,
                0x4A,
                0xF9,
                0x24,
                0xF0,
                0x8F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoDropPicWithMissingRef
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0x63,
                0x22,
                0xF8,
                0xC2,
                0x14,
                0x67,
                0x45,
                0x97,
                0x34,
                0x50,
                0x04,
                0xE9,
                0x6F,
                0xF8,
                0x87
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoSoftwareDeinterlaceMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0xD1,
                0x08,
                0x0C,
                0xED,
                0x9C,
                0x40,
                0x45,
                0xBA,
                0xE3,
                0xCE,
                0xB3,
                0x80,
                0x14,
                0x11,
                0x09
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoFastDecodeMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7D,
                0x9F,
                0x52,
                0x6B,
                0xB1,
                0xD3,
                0xC6,
                0x49,
                0xA9,
                0x99,
                0x9E,
                0xC6,
                0x91,
                0x1B,
                0xED,
                0xBF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVLowLatencyMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
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
                0xEE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoH264ErrorConcealment
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE8,
                0xAC,
                0xEC,
                0xEC,
                0x36,
                0x34,
                0x2C,
                0x46,
                0x92,
                0x94,
                0xCD,
                0x7B,
                0xAC,
                0xD7,
                0x58,
                0xA9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoMPEG2ErrorConcealment
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x18,
                0xFE,
                0x2B,
                0x9D,
                0x8D,
                0x72,
                0xD2,
                0x48,
                0xB3,
                0x58,
                0xBC,
                0x7E,
                0x43,
                0x6C,
                0x66,
                0x74
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoCodecType
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE5,
                0x28,
                0x45,
                0x43,
                0xF0,
                0x21,
                0xB6,
                0x46,
                0xB6,
                0x2C,
                0x9B,
                0x1B,
                0x6B,
                0x65,
                0x8C,
                0xD1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoDXVAMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9E,
                0xF0,
                0x58,
                0xF7,
                0x37,
                0x73,
                0xE7,
                0x4A,
                0x83,
                0x87,
                0x73,
                0xDC,
                0x2D,
                0x54,
                0xE6,
                0x7D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoDXVABusEncryption
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8B,
                0x3C,
                0x15,
                0x42,
                0x0B,
                0xFD,
                0x65,
                0x47,
                0xA4,
                0x62,
                0xDD,
                0xD9,
                0xE8,
                0xBC,
                0xC3,
                0x88
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoForceSourceScanType
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5F,
                0x06,
                0xF2,
                0x1E,
                0x8A,
                0x05,
                0x65,
                0x47,
                0xA4,
                0xFC,
                0x8A,
                0x86,
                0x4C,
                0x10,
                0x30,
                0x12
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoNoOfFieldsToEncode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE2,
                0xBB,
                0xE4,
                0x61,
                0xE0,
                0x4E,
                0xE7,
                0x40,
                0x80,
                0xAB,
                0x51,
                0xDD,
                0xEE,
                0xBE,
                0x62,
                0x91
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoNoOfFieldsToSkip
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0x12,
                0x7E,
                0xA9,
                0x27,
                0x14,
                0x16,
                0x4C,
                0xA7,
                0xF7,
                0x3D,
                0xCF,
                0xD8,
                0xBA,
                0x4C,
                0xC5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoEncodeDimension
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x28,
                0xDF,
                0x74,
                0x10,
                0x0F,
                0x7E,
                0xA4,
                0x47,
                0xA4,
                0x53,
                0xCD,
                0xD7,
                0x38,
                0x70,
                0xF5,
                0xCE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoEncodeOffsetOrigin
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFE,
                0x98,
                0xC0,
                0x6B,
                0x1A,
                0xA7,
                0x54,
                0x44,
                0x85,
                0x2E,
                0x4D,
                0x2D,
                0xDE,
                0xB2,
                0xCD,
                0x24
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoDisplayDimension
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x68,
                0x36,
                0x05,
                0xDE,
                0xEC,
                0xF4,
                0xA9,
                0x47,
                0x86,
                0xD0,
                0x83,
                0x67,
                0x70,
                0xF0,
                0xC1,
                0xD5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoOutputScanType
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x76,
                0x55,
                0x0B,
                0x46,
                0x2E,
                0x84,
                0xAB,
                0x49,
                0xA6,
                0x2D,
                0xB3,
                0x6F,
                0x73,
                0x12,
                0xC9,
                0xDB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoInverseTelecineEnable
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8B,
                0x09,
                0xA9,
                0x2E,
                0x6D,
                0xE7,
                0xCD,
                0x4C,
                0xA0,
                0x30,
                0xD3,
                0xB8,
                0x89,
                0xC1,
                0xB6,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoInverseTelecineThreshold
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0x7D,
                0x24,
                0x40,
                0x95,
                0xE8,
                0x7F,
                0x49,
                0xB4,
                0x4C,
                0xB7,
                0x45,
                0x60,
                0xAC,
                0xFE,
                0x27
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoSourceFilmContent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4B,
                0xC6,
                0x91,
                0x17,
                0xFC,
                0xCC,
                0x27,
                0x48,
                0xA0,
                0xED,
                0x25,
                0x57,
                0x79,
                0x3B,
                0x2B,
                0x1C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoSourceIsBW
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9B,
                0xC4,
                0xFF,
                0x42,
                0x12,
                0x18,
                0xDC,
                0x4F,
                0x8D,
                0x24,
                0x70,
                0x54,
                0xC5,
                0x21,
                0xE6,
                0xEB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoFieldSwap
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x69,
                0x75,
                0xFD,
                0xFE,
                0x0A,
                0x4E,
                0xF2,
                0x49,
                0x9F,
                0x2B,
                0x36,
                0x0E,
                0xA4,
                0x8C,
                0x19,
                0xA2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoInputChromaResolution
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0xEC,
                0x0C,
                0xBB,
                0xF1,
                0x16,
                0xB0,
                0x47,
                0x8A,
                0x88,
                0x37,
                0x81,
                0x5B,
                0xEE,
                0x17,
                0x39
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoOutputChromaResolution
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC9,
                0xB4,
                0x97,
                0x60,
                0x1D,
                0x7C,
                0x64,
                0x4E,
                0xBF,
                0xCC,
                0x9E,
                0x97,
                0x65,
                0x31,
                0x8A,
                0xE7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoInputChromaSubsampling
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x39,
                0x3A,
                0xE7,
                0xA8,
                0x35,
                0x44,
                0xC3,
                0x4E,
                0xA6,
                0xEA,
                0x98,
                0x30,
                0x0F,
                0x4B,
                0x36,
                0xF7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoOutputChromaSubsampling
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6C,
                0x1C,
                0x56,
                0xFA,
                0x17,
                0x7D,
                0xF0,
                0x44,
                0x83,
                0xC9,
                0x32,
                0xED,
                0x12,
                0xE9,
                0x63,
                0x43
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoInputColorPrimaries
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3F,
                0x78,
                0x4D,
                0xC2,
                0xE6,
                0x7C,
                0x78,
                0x42,
                0x90,
                0xAB,
                0x28,
                0xA4,
                0xF1,
                0xE5,
                0xF8,
                0x6C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoOutputColorPrimaries
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0x90,
                0x95,
                0xBE,
                0x04,
                0x9D,
                0x21,
                0x49,
                0x89,
                0x85,
                0xA6,
                0xD6,
                0xD8,
                0x7D,
                0x1A,
                0x6C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoInputColorTransferFunction
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0x61,
                0x05,
                0x8C,
                0xC3,
                0xA9,
                0x08,
                0x4B,
                0xA0,
                0xA0,
                0xCE,
                0x13,
                0xF8,
                0xA2,
                0x7C,
                0x75
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoOutputColorTransferFunction
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4A,
                0x88,
                0x7F,
                0x4A,
                0x11,
                0xEA,
                0x0D,
                0x46,
                0xBF,
                0x57,
                0xB8,
                0x8B,
                0xC7,
                0x59,
                0x00,
                0xDE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoInputColorTransferMatrix
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB9,
                0x68,
                0xED,
                0x52,
                0xD5,
                0x72,
                0x89,
                0x40,
                0x95,
                0x8D,
                0xF5,
                0x40,
                0x5D,
                0x55,
                0x08,
                0x1C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoOutputColorTransferMatrix
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0x04,
                0xB9,
                0xA9,
                0x40,
                0xAF,
                0x10,
                0x43,
                0x8F,
                0xBE,
                0xED,
                0x6D,
                0x93,
                0x3F,
                0x89,
                0x2B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoInputColorLighting
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0x95,
                0xA9,
                0x46,
                0x15,
                0x00,
                0x45,
                0x4A,
                0x9C,
                0x30,
                0x1D,
                0x5C,
                0xFA,
                0x25,
                0x83,
                0x16
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoOutputColorLighting
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0xAA,
                0x5A,
                0x0E,
                0xE6,
                0xAC,
                0x5C,
                0x4C,
                0x99,
                0x8E,
                0x1A,
                0x8C,
                0x9C,
                0x6C,
                0x0F,
                0x89
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoInputColorNominalRange
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0x25,
                0xCF,
                0x16,
                0xA6,
                0xA2,
                0xE9,
                0x48,
                0xAE,
                0x80,
                0x21,
                0xAE,
                0xC4,
                0x1D,
                0x42,
                0x7E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoOutputColorNominalRange
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xED,
                0x35,
                0x28,
                0x97,
                0xB5,
                0x87,
                0x95,
                0x4E,
                0x95,
                0x00,
                0xC7,
                0x39,
                0x58,
                0x56,
                0x6E,
                0x54
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncInputVideoSystem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6D,
                0x14,
                0xDE,
                0xBE,
                0x16,
                0xB6,
                0xC7,
                0x4D,
                0x92,
                0xB2,
                0xF5,
                0xD9,
                0xFA,
                0x92,
                0x98,
                0xF7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoHeaderDropFrame
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x24,
                0xE1,
                0xD9,
                0x6E,
                0x25,
                0x79,
                0xFE,
                0x43,
                0x97,
                0x1B,
                0xE0,
                0x19,
                0xF6,
                0x22,
                0x22,
                0xB4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoHeaderHours
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0x77,
                0xCC,
                0x2A,
                0xDA,
                0xE2,
                0x58,
                0x41,
                0xBF,
                0x9B,
                0x88,
                0x88,
                0x01,
                0x29,
                0xD7,
                0x40
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoHeaderMinutes
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0x99,
                0x1A,
                0xDC,
                0x07,
                0x03,
                0x8B,
                0x40,
                0x88,
                0x0B,
                0xB8,
                0x34,
                0x8E,
                0xE8,
                0xCA,
                0x7F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoHeaderSeconds
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0x1A,
                0x2E,
                0x4A,
                0x80,
                0xA7,
                0x58,
                0x4F,
                0x81,
                0x20,
                0x9A,
                0x44,
                0x9D,
                0x69,
                0x65,
                0x6B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoHeaderFrames
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x67,
                0xF5,
                0xD5,
                0xAF,
                0x1B,
                0x5C,
                0xDC,
                0x4A,
                0xBD,
                0xAF,
                0x73,
                0x56,
                0x10,
                0x38,
                0x14,
                0x36
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoDefaultUpperFieldDominant
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC4,
                0x67,
                0x01,
                0x81,
                0xC1,
                0x0B,
                0xCA,
                0x47,
                0x8F,
                0xC2,
                0x57,
                0x05,
                0x5A,
                0x14,
                0x74,
                0xA5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoCBRMotionTradeoff
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1E,
                0x45,
                0x49,
                0x0D,
                0xD5,
                0x18,
                0x67,
                0x43,
                0xA4,
                0xEF,
                0x32,
                0x40,
                0xDF,
                0x16,
                0x93,
                0xC4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoCodedVideoAccessUnitSize
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0x0C,
                0xB1,
                0xB4,
                0xA7,
                0x14,
                0xE8,
                0x4C,
                0xB1,
                0x73,
                0xDC,
                0x90,
                0xA0,
                0xB4,
                0xFC,
                0xDB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoMaxKeyframeDistance
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3A,
                0x12,
                0x87,
                0x29,
                0x93,
                0xBA,
                0x04,
                0x47,
                0xB4,
                0x89,
                0xEC,
                0x1E,
                0x5F,
                0x25,
                0x29,
                0x2C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncH264CABACEnable
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0xAD,
                0x6C,
                0xEE,
                0x05,
                0xD3,
                0x48,
                0x42,
                0xA5,
                0x0E,
                0xE1,
                0xB2,
                0x55,
                0xF7,
                0xCA,
                0xF8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoContentType
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0x7A,
                0x11,
                0x66,
                0x77,
                0xEB,
                0x9D,
                0x45,
                0x93,
                0x0C,
                0xA4,
                0x8D,
                0x9D,
                0x06,
                0x83,
                0xFC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncNumWorkerThreads
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0xBF,
                0xC8,
                0xB0,
                0xF7,
                0x16,
                0x51,
                0x49,
                0xA3,
                0x0B,
                0x1D,
                0xB1,
                0x60,
                0x92,
                0x93,
                0xD6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoEncodeQP
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6B,
                0x69,
                0xB5,
                0x2C,
                0xFB,
                0x23,
                0xE1,
                0x4C,
                0xA0,
                0xF9,
                0xEF,
                0x5B,
                0x90,
                0xFD,
                0x55,
                0xCA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoMinQP
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6A,
                0x2C,
                0xE2,
                0x0E,
                0x7C,
                0xA3,
                0x68,
                0x45,
                0xB5,
                0xF1,
                0x9D,
                0x4C,
                0x2B,
                0x3A,
                0xB8,
                0x86
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoForceKeyFrame
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x98,
                0x1B,
                0x8C,
                0x39,
                0x53,
                0x83,
                0x5A,
                0x47,
                0x9E,
                0xF2,
                0x8F,
                0x26,
                0x5D,
                0x26,
                0x03,
                0x45
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncH264SPSID
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x51,
                0x8F,
                0xF3,
                0x50,
                0x79,
                0x2B,
                0xE3,
                0x40,
                0xB3,
                0x9C,
                0x7E,
                0x9F,
                0xA0,
                0x77,
                0x05,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncH264PPSID
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC2,
                0x9E,
                0xE2,
                0xBF,
                0x6C,
                0x05,
                0x68,
                0x4D,
                0xA3,
                0x8D,
                0xAE,
                0x59,
                0x44,
                0xC8,
                0x58,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAdaptiveMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0xB1,
                0x19,
                0x44,
                0x1F,
                0xDA,
                0x53,
                0x4F,
                0xBC,
                0x76,
                0x09,
                0x7D,
                0x0C,
                0x1E,
                0xFB,
                0x1E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVScenarioInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x64,
                0x6E,
                0x8A,
                0xB2,
                0xF9,
                0x3F,
                0x6A,
                0x44,
                0x8A,
                0x4B,
                0x0D,
                0x7A,
                0x53,
                0x41,
                0x32,
                0x36
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVGOPSizeMin
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0xCF,
                0x55,
                0x71,
                0x40,
                0xD4,
                0x52,
                0x48,
                0xAD,
                0x0F,
                0x9C,
                0x4A,
                0xBF,
                0xE3,
                0x7A,
                0x6A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVGOPSizeMax
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC4,
                0xE4,
                0x7D,
                0xFE,
                0x36,
                0x19,
                0xE2,
                0x4F,
                0xBD,
                0xF7,
                0x1F,
                0x18,
                0xCA,
                0x1D,
                0x00,
                0x1F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoMaxCTBSize
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0x63,
                0x23,
                0x82,
                0xC8,
                0xCE,
                0xE5,
                0x43,
                0x92,
                0xFD,
                0xE0,
                0x97,
                0x48,
                0x84,
                0x85,
                0xE9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoCTBSize
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB2,
                0xB8,
                0x7D,
                0xD4,
                0x3B,
                0xE7,
                0xB9,
                0x4C,
                0x8C,
                0x3E,
                0xBD,
                0x87,
                0x7D,
                0x06,
                0xD7,
                0x7B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_VideoEncoderDisplayContentType
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0x0B,
                0xB9,
                0x79,
                0xB1,
                0xF4,
                0xDC,
                0x42,
                0x9D,
                0xD7,
                0xCD,
                0xAF,
                0x81,
                0x35,
                0xC4,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncEnableVideoProcessing
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF6,
                0x4B,
                0x6F,
                0x00,
                0xA3,
                0x0E,
                0x42,
                0x4D,
                0x87,
                0x02,
                0xB5,
                0xD8,
                0xBE,
                0x0F,
                0x7A,
                0x92
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoGradualIntraRefresh
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0x7D,
                0x34,
                0x8F,
                0x0D,
                0xCB,
                0xBA,
                0x49,
                0xB4,
                0x62,
                0xDB,
                0x69,
                0x27,
                0xEE,
                0x21,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GetOPMContext
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0x6C,
                0x03,
                0x2F,
                0x14,
                0x4C,
                0x89,
                0x46,
                0x88,
                0x39,
                0x29,
                0x4C,
                0x6D,
                0x73,
                0xE0,
                0x53
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_SetHDCPManagerContext
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC8,
                0x1F,
                0x2D,
                0x6D,
                0xC9,
                0x3D,
                0xEB,
                0x47,
                0xA1,
                0xA2,
                0x47,
                0x1C,
                0x80,
                0xCD,
                0x60,
                0xD0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoMaxTemporalLayers
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFE,
                0x8C,
                0x66,
                0x9C,
                0xE1,
                0x08,
                0x4A,
                0x42,
                0x93,
                0x4E,
                0xB7,
                0x64,
                0xB0,
                0x64,
                0x80,
                0x2A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoNumGOPsPerIDR
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0x5B,
                0xBC,
                0x83,
                0x89,
                0x5B,
                0x21,
                0x45,
                0x8F,
                0x66,
                0x33,
                0x15,
                0x1C,
                0x37,
                0x31,
                0x76
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncCommonAllowFrameDrops
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCB,
                0x7D,
                0x47,
                0xD8,
                0x98,
                0x95,
                0xE3,
                0x48,
                0x8D,
                0x0C,
                0x75,
                0x2B,
                0xF2,
                0x06,
                0x09,
                0x3E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoIntraLayerPrediction
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB8,
                0x46,
                0xAF,
                0xD3,
                0x47,
                0xBF,
                0xBB,
                0x44,
                0xA2,
                0x83,
                0x69,
                0xF0,
                0xB0,
                0x22,
                0x8F,
                0xF9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoInstantTemporalUpSwitching
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x07,
                0x83,
                0x30,
                0xA3,
                0x96,
                0x0D,
                0xA4,
                0x4B,
                0xB1,
                0xF0,
                0xB9,
                0x1A,
                0x5E,
                0x49,
                0xDF,
                0x10
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncLowPowerEncoder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0xD5,
                0x68,
                0xB6,
                0xAD,
                0x8B,
                0x6A,
                0x4F,
                0x91,
                0x41,
                0x37,
                0x5A,
                0x95,
                0x35,
                0x8B,
                0x6D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEnableInLoopDeblockFilter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x99,
                0xE3,
                0xE8,
                0xD2,
                0x23,
                0x06,
                0xF3,
                0x4B,
                0x92,
                0xA8,
                0x4D,
                0x18,
                0x18,
                0x52,
                0x9D,
                0xED
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoSelectLayer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF5,
                0x84,
                0x10,
                0xEB,
                0xAA,
                0x6A,
                0x14,
                0x49,
                0xBB,
                0x2F,
                0x61,
                0x47,
                0x22,
                0x7F,
                0x12,
                0xE7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoTemporalLayerCount
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0xEB,
                0xCA,
                0x19,
                0x4D,
                0xB7,
                0xFD,
                0x4C,
                0x8C,
                0x27,
                0xC2,
                0xF9,
                0xD9,
                0x7D,
                0x5F,
                0x52
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoUsage
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0x68,
                0x63,
                0x1F,
                0xC1,
                0x5D,
                0xF1,
                0x49,
                0xB1,
                0xD8,
                0xCE,
                0x3C,
                0xF6,
                0x2E,
                0xA3,
                0x85
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoRateControlParams
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x67,
                0x37,
                0xD4,
                0x87,
                0x45,
                0x76,
                0xEC,
                0x44,
                0xB4,
                0x38,
                0xD3,
                0x32,
                0x2F,
                0xBC,
                0xA2,
                0x9F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoSupportedControls
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDD,
                0x0F,
                0xF4,
                0xD3,
                0xB9,
                0x77,
                0x3D,
                0x47,
                0x81,
                0x96,
                0x06,
                0x12,
                0x59,
                0xE6,
                0x9C,
                0xFF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoEncodeFrameTypeQP
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0xB6,
                0x70,
                0xAA,
                0x3F,
                0xE0,
                0x0C,
                0x45,
                0xAD,
                0x07,
                0x07,
                0x31,
                0x4E,
                0x63,
                0x9C,
                0xE7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncSliceControlMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEF,
                0x82,
                0xE7,
                0xE9,
                0x18,
                0x5F,
                0xC9,
                0x44,
                0xA9,
                0x0B,
                0xE9,
                0xC3,
                0xC2,
                0xC1,
                0x7B,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncSliceControlSize
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF3,
                0x1D,
                0xF5,
                0x92,
                0xA5,
                0x07,
                0x72,
                0x41,
                0xAE,
                0xFE,
                0xC6,
                0x9C,
                0xA3,
                0xB6,
                0x0E,
                0x35
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncSliceGenerationMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7F,
                0xC6,
                0x6B,
                0x8A,
                0x97,
                0x94,
                0x86,
                0x42,
                0xB4,
                0x6B,
                0x02,
                0xDB,
                0x8D,
                0x60,
                0xED,
                0xBC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoMaxNumRefFrame
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xED,
                0x29,
                0x48,
                0x96,
                0xF9,
                0x94,
                0xB4,
                0x43,
                0xB7,
                0x4D,
                0xEF,
                0x40,
                0x94,
                0x4B,
                0x69,
                0xA0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoMeanAbsoluteDifference
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0F,
                0xC1,
                0xC0,
                0xE5,
                0xA4,
                0x81,
                0x2D,
                0x42,
                0x8C,
                0x3F,
                0xB4,
                0x74,
                0xA4,
                0x58,
                0x13,
                0x36
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoMaxQP
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x66,
                0x6F,
                0xAF,
                0x3D,
                0xA7,
                0xA6,
                0xE0,
                0x45,
                0xA8,
                0xE5,
                0xF2,
                0x74,
                0x3F,
                0x46,
                0xA3,
                0xA2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoLTRBufferControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3D,
                0xE9,
                0xA0,
                0xA4,
                0xBC,
                0x4C,
                0x4C,
                0x44,
                0x89,
                0xF4,
                0x82,
                0x6D,
                0x31,
                0x0E,
                0x92,
                0xA7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoMarkLTRFrame
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x48,
                0x47,
                0x2F,
                0xE4,
                0x6D,
                0xA0,
                0xF9,
                0x4E,
                0x8C,
                0xEA,
                0x3D,
                0x05,
                0xFD,
                0xE3,
                0xBD,
                0x3B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoUseLTRFrame
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB8,
                0x2D,
                0x75,
                0x00,
                0xF7,
                0x55,
                0x80,
                0x4F,
                0x89,
                0x5B,
                0x27,
                0x63,
                0x91,
                0x95,
                0xF2,
                0xAD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoROIEnabled
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x18,
                0x7F,
                0x4F,
                0xD7,
                0xDD,
                0x44,
                0x85,
                0x4B,
                0xAB,
                0xA3,
                0x05,
                0xD9,
                0xF4,
                0x2A,
                0x82,
                0x80
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoDirtyRectEnabled
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDD,
                0x8F,
                0xCB,
                0x8A,
                0x0C,
                0x5E,
                0x66,
                0x4C,
                0x87,
                0x29,
                0xB8,
                0xF6,
                0x29,
                0xAB,
                0x04,
                0xFB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMaxFrameRate
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0x1B,
                0x8E,
                0xB9,
                0xFA,
                0x19,
                0x4F,
                0x4D,
                0x99,
                0x31,
                0xD6,
                0xA5,
                0xB8,
                0xAA,
                0xB9,
                0x3C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMuxOutputStreamType
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8F,
                0x9E,
                0xDD,
                0xCE,
                0xD3,
                0x34,
                0xDB,
                0x44,
                0xA1,
                0xD8,
                0xF8,
                0x15,
                0x20,
                0x25,
                0x4F,
                0x3E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncStatVideoOutputFrameRate
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0x78,
                0x74,
                0xBE,
                0xB4,
                0x9A,
                0x63,
                0x4A,
                0x98,
                0xFE,
                0xF1,
                0x43,
                0xF0,
                0x4F,
                0x8E,
                0xE9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncStatVideoCodedFrames
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x61,
                0x8D,
                0x7F,
                0xD4,
                0x5A,
                0x6F,
                0x26,
                0x4A,
                0xBB,
                0x9F,
                0xCD,
                0x95,
                0x18,
                0x46,
                0x2B,
                0xCD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncStatVideoTotalFrames
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0x99,
                0xAA,
                0xFD,
                0x9A,
                0x11,
                0x22,
                0x42,
                0x9A,
                0xD6,
                0x3F,
                0x7C,
                0xAB,
                0x99,
                0xCC,
                0x8B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioIntervalToEncode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0x4B,
                0x6E,
                0x86,
                0x5A,
                0x72,
                0x7C,
                0x46,
                0xBB,
                0x01,
                0xB4,
                0x96,
                0xB2,
                0x3B,
                0x25,
                0xF9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioIntervalToSkip
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x94,
                0x5F,
                0xC1,
                0x88,
                0x8C,
                0xC3,
                0x96,
                0x47,
                0xA9,
                0xE8,
                0x96,
                0xE9,
                0x67,
                0x98,
                0x3F,
                0x26
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioDualMono
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6B,
                0x12,
                0x48,
                0x36,
                0xE8,
                0xA3,
                0x29,
                0x43,
                0x9B,
                0x3A,
                0x5C,
                0xE5,
                0x66,
                0xA4,
                0x3B,
                0xD3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioMeanBitRate
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBB,
                0x95,
                0x12,
                0x92,
                0xCA,
                0x4F,
                0x79,
                0x46,
                0xAA,
                0xB8,
                0x9E,
                0x2A,
                0x1D,
                0x75,
                0x33,
                0x84
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioMapDestChannel0
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0x0B,
                0x5D,
                0xBC,
                0x6A,
                0xDF,
                0x16,
                0x4E,
                0x98,
                0x03,
                0xB8,
                0x20,
                0x07,
                0xA3,
                0x0C,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioMapDestChannel1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x61,
                0x0B,
                0x5D,
                0xBC,
                0x6A,
                0xDF,
                0x16,
                0x4E,
                0x98,
                0x03,
                0xB8,
                0x20,
                0x07,
                0xA3,
                0x0C,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioMapDestChannel2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0x0B,
                0x5D,
                0xBC,
                0x6A,
                0xDF,
                0x16,
                0x4E,
                0x98,
                0x03,
                0xB8,
                0x20,
                0x07,
                0xA3,
                0x0C,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioMapDestChannel3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x63,
                0x0B,
                0x5D,
                0xBC,
                0x6A,
                0xDF,
                0x16,
                0x4E,
                0x98,
                0x03,
                0xB8,
                0x20,
                0x07,
                0xA3,
                0x0C,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioMapDestChannel4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x64,
                0x0B,
                0x5D,
                0xBC,
                0x6A,
                0xDF,
                0x16,
                0x4E,
                0x98,
                0x03,
                0xB8,
                0x20,
                0x07,
                0xA3,
                0x0C,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioMapDestChannel5
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x65,
                0x0B,
                0x5D,
                0xBC,
                0x6A,
                0xDF,
                0x16,
                0x4E,
                0x98,
                0x03,
                0xB8,
                0x20,
                0x07,
                0xA3,
                0x0C,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioMapDestChannel6
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x66,
                0x0B,
                0x5D,
                0xBC,
                0x6A,
                0xDF,
                0x16,
                0x4E,
                0x98,
                0x03,
                0xB8,
                0x20,
                0x07,
                0xA3,
                0x0C,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioMapDestChannel7
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x67,
                0x0B,
                0x5D,
                0xBC,
                0x6A,
                0xDF,
                0x16,
                0x4E,
                0x98,
                0x03,
                0xB8,
                0x20,
                0x07,
                0xA3,
                0x0C,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioMapDestChannel8
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x68,
                0x0B,
                0x5D,
                0xBC,
                0x6A,
                0xDF,
                0x16,
                0x4E,
                0x98,
                0x03,
                0xB8,
                0x20,
                0x07,
                0xA3,
                0x0C,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioMapDestChannel9
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x69,
                0x0B,
                0x5D,
                0xBC,
                0x6A,
                0xDF,
                0x16,
                0x4E,
                0x98,
                0x03,
                0xB8,
                0x20,
                0x07,
                0xA3,
                0x0C,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioMapDestChannel10
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6A,
                0x0B,
                0x5D,
                0xBC,
                0x6A,
                0xDF,
                0x16,
                0x4E,
                0x98,
                0x03,
                0xB8,
                0x20,
                0x07,
                0xA3,
                0x0C,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioMapDestChannel11
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6B,
                0x0B,
                0x5D,
                0xBC,
                0x6A,
                0xDF,
                0x16,
                0x4E,
                0x98,
                0x03,
                0xB8,
                0x20,
                0x07,
                0xA3,
                0x0C,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioMapDestChannel12
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6C,
                0x0B,
                0x5D,
                0xBC,
                0x6A,
                0xDF,
                0x16,
                0x4E,
                0x98,
                0x03,
                0xB8,
                0x20,
                0x07,
                0xA3,
                0x0C,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioMapDestChannel13
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6D,
                0x0B,
                0x5D,
                0xBC,
                0x6A,
                0xDF,
                0x16,
                0x4E,
                0x98,
                0x03,
                0xB8,
                0x20,
                0x07,
                0xA3,
                0x0C,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioMapDestChannel14
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6E,
                0x0B,
                0x5D,
                0xBC,
                0x6A,
                0xDF,
                0x16,
                0x4E,
                0x98,
                0x03,
                0xB8,
                0x20,
                0x07,
                0xA3,
                0x0C,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioMapDestChannel15
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6F,
                0x0B,
                0x5D,
                0xBC,
                0x6A,
                0xDF,
                0x16,
                0x4E,
                0x98,
                0x03,
                0xB8,
                0x20,
                0x07,
                0xA3,
                0x0C,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAudioInputContent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0x6C,
                0x22,
                0x3E,
                0xB9,
                0x60,
                0x39,
                0x4A,
                0xB0,
                0x0B,
                0xA7,
                0xB4,
                0x0F,
                0x70,
                0xD5,
                0x66
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncStatAudioPeakPCMValue
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x34,
                0xFD,
                0xE7,
                0xDC,
                0x00,
                0xDC,
                0x16,
                0x4C,
                0x82,
                0x1B,
                0x35,
                0xD9,
                0xEB,
                0x00,
                0xFB,
                0x1A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncStatAudioAveragePCMValue
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF8,
                0x72,
                0x92,
                0x97,
                0x7F,
                0xD1,
                0x32,
                0x4E,
                0xBB,
                0x73,
                0x4E,
                0x73,
                0x1C,
                0x68,
                0xBA,
                0x2D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncStatAudioAverageBPS
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0x24,
                0x67,
                0xCA,
                0x59,
                0x70,
                0x51,
                0x43,
                0x8B,
                0x43,
                0xF8,
                0x21,
                0x98,
                0x82,
                0x6A,
                0x14
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncStatAverageBPS
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0x24,
                0x67,
                0xCA,
                0x59,
                0x70,
                0x51,
                0x43,
                0x8B,
                0x43,
                0xF8,
                0x21,
                0x98,
                0x82,
                0x6A,
                0x14
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncStatHardwareProcessorUtilitization
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0xC0,
                0x5D,
                0x99,
                0x95,
                0xCB,
                0xE6,
                0x49,
                0xB9,
                0x1B,
                0x59,
                0x67,
                0x75,
                0x3C,
                0xDC,
                0xB8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncStatHardwareBandwidthUtilitization
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9B,
                0xBA,
                0x24,
                0x01,
                0x41,
                0xDC,
                0x26,
                0x48,
                0xB4,
                0x5F,
                0x18,
                0xAC,
                0x01,
                0xB3,
                0xD5,
                0xA8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVGOPSize
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x26,
                0x1B,
                0xF3,
                0x95,
                0xA4,
                0x95,
                0xAA,
                0x41,
                0x93,
                0x03,
                0x24,
                0x6A,
                0x7F,
                0xC6,
                0xEE,
                0xF1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVGOPOpen
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA6,
                0xD4,
                0xD5,
                0xB1,
                0x00,
                0x33,
                0xB1,
                0x49,
                0xAE,
                0x61,
                0xA0,
                0x99,
                0x37,
                0xAB,
                0x0E,
                0x49
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVDefaultBPictureCount
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAC,
                0x0A,
                0x39,
                0x8D,
                0x5C,
                0xDC,
                0x00,
                0x42,
                0xB5,
                0x7F,
                0x81,
                0x4D,
                0x04,
                0xBA,
                0xBA,
                0xB2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVProfile
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4A,
                0x53,
                0xBB,
                0xDA,
                0x99,
                0x1D,
                0x84,
                0x42,
                0x97,
                0x5A,
                0xD9,
                0x0E,
                0x22,
                0x39,
                0xBA,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVLevel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0x0C,
                0xE4,
                0x6E,
                0x0C,
                0xA6,
                0xEF,
                0x41,
                0x8F,
                0x50,
                0x37,
                0xC2,
                0x24,
                0x9E,
                0x2C,
                0xB3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVFrameFieldMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x96,
                0xDE,
                0xB5,
                0xAC,
                0x93,
                0x7B,
                0x2F,
                0x4C,
                0x88,
                0x25,
                0xB0,
                0x29,
                0x5F,
                0xA9,
                0x3B,
                0xF4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVAddSeqEndCode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8F,
                0x17,
                0x23,
                0xA8,
                0xDF,
                0x57,
                0x7A,
                0x4C,
                0xB8,
                0xFD,
                0xE5,
                0xEC,
                0x88,
                0x87,
                0x70,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVGOPSInSeq
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD4,
                0x10,
                0x34,
                0x99,
                0x91,
                0x26,
                0x92,
                0x41,
                0x99,
                0x78,
                0x98,
                0xDC,
                0x26,
                0x03,
                0x66,
                0x9F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVUseConcealmentMotionVectors
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF3,
                0x0C,
                0x77,
                0xEC,
                0x08,
                0x69,
                0x4B,
                0x4B,
                0xAA,
                0x30,
                0x7F,
                0xB9,
                0x86,
                0x21,
                0x4F,
                0xEA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVSceneDetection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF1,
                0x99,
                0x27,
                0x55,
                0x4C,
                0xDB,
                0x5B,
                0x40,
                0x8A,
                0x3A,
                0xC9,
                0x3F,
                0x2D,
                0x06,
                0x74,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVGenerateHeaderSeqExt
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0x86,
                0xE7,
                0xD5,
                0x2D,
                0x08,
                0x6B,
                0x4E,
                0x98,
                0xAF,
                0x0F,
                0x51,
                0xAB,
                0x13,
                0x92,
                0x22
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVGenerateHeaderSeqDispExt
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6F,
                0xAA,
                0x37,
                0x64,
                0x3C,
                0x5A,
                0xE9,
                0x4D,
                0x8A,
                0x16,
                0x53,
                0xD9,
                0xC4,
                0xAD,
                0x32,
                0x6F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVGenerateHeaderPicExt
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAB,
                0x64,
                0x84,
                0x1B,
                0x4F,
                0x94,
                0xF0,
                0x45,
                0xB7,
                0x4E,
                0x3A,
                0x58,
                0xDA,
                0xD1,
                0x1F,
                0x37
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVGenerateHeaderPicDispExt
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0x2F,
                0x41,
                0xC6,
                0x3F,
                0xC0,
                0x40,
                0x4F,
                0xA0,
                0x0C,
                0x42,
                0x93,
                0xDF,
                0x83,
                0x95,
                0xBB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVGenerateHeaderSeqScaleExt
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2F,
                0xD6,
                0x22,
                0x07,
                0x59,
                0xDD,
                0x86,
                0x4A,
                0x9C,
                0xD5,
                0x64,
                0x4F,
                0x8E,
                0x26,
                0x53,
                0xD8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVScanPattern
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8E,
                0x47,
                0x8A,
                0x7F,
                0xBB,
                0x7B,
                0xE2,
                0x4A,
                0xB2,
                0xFC,
                0x96,
                0xD1,
                0x7F,
                0xC4,
                0xA2,
                0xD6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVIntraDCPrecision
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x51,
                0x61,
                0x11,
                0xA0,
                0xC8,
                0xCB,
                0xF3,
                0x4A,
                0x97,
                0xDC,
                0xD0,
                0x0C,
                0xCE,
                0xB8,
                0x2D,
                0x79
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVQScaleType
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB7,
                0xEB,
                0x79,
                0x2B,
                0x84,
                0xF4,
                0xF7,
                0x4A,
                0xBB,
                0x58,
                0xA2,
                0xA1,
                0x88,
                0xC5,
                0xCB,
                0xBE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVIntraVLCTable
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF5,
                0x3F,
                0xB8,
                0xA2,
                0x99,
                0x1A,
                0x5A,
                0x40,
                0xAF,
                0x95,
                0xC5,
                0x99,
                0x7D,
                0x55,
                0x8D,
                0x3A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVQuantMatrixIntra
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF3,
                0x04,
                0xEA,
                0x9B,
                0x21,
                0x66,
                0x2C,
                0x44,
                0x8B,
                0xA1,
                0x3A,
                0xC3,
                0x78,
                0x97,
                0x96,
                0x98
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVQuantMatrixNonIntra
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD8,
                0x41,
                0xF4,
                0x87,
                0x97,
                0x09,
                0xEB,
                0x4B,
                0xA0,
                0x8E,
                0x85,
                0x73,
                0xD4,
                0x09,
                0xCF,
                0x75
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVQuantMatrixChromaIntra
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD4,
                0xEC,
                0xB9,
                0x9E,
                0x8D,
                0x01,
                0xFD,
                0x4F,
                0x8F,
                0x2D,
                0x39,
                0xE4,
                0x9F,
                0x07,
                0xB1,
                0x7A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPVQuantMatrixChromaNonIntra
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB1,
                0xB6,
                0x15,
                0x14,
                0x2A,
                0x36,
                0x38,
                0x43,
                0xBA,
                0x9A,
                0x1E,
                0xF5,
                0x87,
                0x03,
                0xC0,
                0x5B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPALayer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0x72,
                0x37,
                0x9D,
                0x1B,
                0xF9,
                0x3D,
                0x45,
                0x9C,
                0xE0,
                0x78,
                0x44,
                0x54,
                0x14,
                0xC2,
                0x2D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPACodingMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xDE,
                0x6A,
                0xB1,
                0x93,
                0x4B,
                0xD7,
                0x43,
                0xA5,
                0x50,
                0x90,
                0xB4,
                0xFE,
                0x22,
                0x45,
                0x37
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPACopyright
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A,
                0x76,
                0xAE,
                0xA6,
                0xA9,
                0xD0,
                0x54,
                0x44,
                0xB8,
                0xEF,
                0xF2,
                0xDB,
                0xEE,
                0xFD,
                0xD3,
                0xBD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPAOriginalBitstream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x55,
                0x78,
                0xFB,
                0x3C,
                0xC9,
                0x9C,
                0xFF,
                0x47,
                0xB8,
                0x29,
                0xB3,
                0x67,
                0x86,
                0xC9,
                0x23,
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPAEnableRedundancyProtection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9E,
                0xB0,
                0x54,
                0x5E,
                0xE7,
                0xB2,
                0x73,
                0x49,
                0xA8,
                0x9B,
                0x0B,
                0x36,
                0x50,
                0xA3,
                0xBE,
                0xDA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPAPrivateUserBit
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0x05,
                0xA5,
                0xAF,
                0xE3,
                0xC1,
                0x3D,
                0x4E,
                0x85,
                0x1B,
                0x61,
                0xB7,
                0x00,
                0xE5,
                0xE6,
                0xCC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMPAEmphasisType
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDA,
                0xFC,
                0x59,
                0x2D,
                0x4E,
                0xBF,
                0xD6,
                0x4E,
                0xB5,
                0xDF,
                0x5B,
                0x03,
                0xB3,
                0x6B,
                0x0A,
                0x1F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDService
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0xBE,
                0xE1,
                0xD2,
                0x72,
                0x51,
                0x2A,
                0x4D,
                0xA5,
                0x0E,
                0x2F,
                0x3B,
                0x82,
                0xB1,
                0xDD,
                0xF8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDDialogNormalization
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0x5A,
                0x05,
                0xD7,
                0x25,
                0xF1,
                0x7D,
                0x43,
                0xA7,
                0x04,
                0x79,
                0xC7,
                0x9F,
                0x04,
                0x04,
                0xA8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDCentreDownMixLevel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2C,
                0x07,
                0x85,
                0xE2,
                0x58,
                0xC9,
                0x81,
                0x4A,
                0xAF,
                0xD2,
                0xE5,
                0xE0,
                0xDA,
                0xF1,
                0xB1,
                0x48
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDSurroundDownMixLevel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE5,
                0xD6,
                0x20,
                0x7B,
                0xCF,
                0x0B,
                0x73,
                0x42,
                0xA4,
                0x87,
                0x50,
                0x6B,
                0x04,
                0x79,
                0x97,
                0xE9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDProductionInfoExists
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5F,
                0xFE,
                0xB7,
                0xB0,
                0xAB,
                0xB6,
                0x40,
                0x4F,
                0x96,
                0x4D,
                0x8D,
                0x91,
                0xF1,
                0x7C,
                0x19,
                0xE8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDProductionRoomType
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0xAD,
                0xD7,
                0xDA,
                0xD8,
                0x23,
                0xB7,
                0x4A,
                0xA2,
                0x84,
                0x55,
                0x69,
                0x86,
                0xD8,
                0xA6,
                0xFE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDProductionMixLevel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3A,
                0x10,
                0x1D,
                0x30,
                0xF9,
                0xCB,
                0x76,
                0x47,
                0x88,
                0x99,
                0x7C,
                0x15,
                0xB4,
                0x61,
                0xAB,
                0x26
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDCopyright
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x76,
                0xF0,
                0x94,
                0x86,
                0x75,
                0xCD,
                0x1D,
                0x48,
                0xA5,
                0xC6,
                0xA9,
                0x04,
                0xDC,
                0xC8,
                0x28,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDOriginalBitstream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0xE8,
                0x6A,
                0x96,
                0xD3,
                0x5B,
                0xF9,
                0x4F,
                0x95,
                0xB9,
                0xD3,
                0x05,
                0x66,
                0x27,
                0x38,
                0x56
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDDigitalDeemphasis
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC2,
                0xA2,
                0x24,
                0xE0,
                0x7C,
                0x94,
                0xAC,
                0x45,
                0x87,
                0xD8,
                0xF1,
                0x03,
                0x0C,
                0x5C,
                0x00,
                0x82
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDDCHighPassFilter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9F,
                0x23,
                0x65,
                0x95,
                0x1C,
                0x86,
                0xC8,
                0x4A,
                0xBF,
                0xDA,
                0xE0,
                0x0C,
                0xB4,
                0xDB,
                0x85,
                0x48
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDChannelBWLowPassFilter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1D,
                0x82,
                0x97,
                0xE1,
                0xE7,
                0xD2,
                0xE2,
                0x43,
                0xAD,
                0x2C,
                0x00,
                0x58,
                0x2F,
                0x51,
                0x85,
                0x45
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDLFELowPassFilter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6F,
                0x0F,
                0xB8,
                0xD3,
                0x15,
                0x9D,
                0xE5,
                0x45,
                0x91,
                0xBE,
                0x01,
                0x9C,
                0x3F,
                0xAB,
                0x1F,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDSurround90DegreeePhaseShift
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9D,
                0xEC,
                0xEC,
                0x25,
                0x53,
                0x35,
                0xC0,
                0x42,
                0xBB,
                0x56,
                0xD2,
                0x57,
                0x92,
                0x10,
                0x4F,
                0x80
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDSurround3dBAttenuation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9D,
                0xB9,
                0x43,
                0x4D,
                0xE2,
                0x31,
                0xB9,
                0x48,
                0xBF,
                0x2E,
                0x5C,
                0xBF,
                0x1A,
                0x57,
                0x27,
                0x84
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDDynamicRangeCompressionControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6D,
                0xFF,
                0xC2,
                0xCF,
                0xB8,
                0x79,
                0x8D,
                0x4B,
                0xA8,
                0xAA,
                0xA0,
                0xC9,
                0xBD,
                0x1C,
                0x29,
                0x40
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDRFPreEmphasisFilter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC0,
                0x44,
                0xAF,
                0x21,
                0x4E,
                0x24,
                0x3D,
                0x4F,
                0xA2,
                0xCC,
                0x3D,
                0x30,
                0x68,
                0xB2,
                0xE7,
                0x3F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDSurroundExMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0x7C,
                0x60,
                0x91,
                0xDD,
                0xDB,
                0xB6,
                0x4E,
                0xBC,
                0xA2,
                0xAA,
                0xDF,
                0xAF,
                0xA3,
                0xDD,
                0x68
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDPreferredStereoDownMixMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0x6B,
                0x4E,
                0x7F,
                0x85,
                0x91,
                0x3D,
                0x40,
                0xB0,
                0xA2,
                0x76,
                0x37,
                0x43,
                0xE6,
                0xF0,
                0x63
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDLtRtCenterMixLvl_x10
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA2,
                0x28,
                0xA1,
                0xDC,
                0x1F,
                0x49,
                0x00,
                0x46,
                0xB2,
                0xDA,
                0x76,
                0xE3,
                0x34,
                0x4B,
                0x41,
                0x97
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDLtRtSurroundMixLvl_x10
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0x46,
                0x22,
                0x21,
                0x2C,
                0x3D,
                0xFA,
                0x4D,
                0xBC,
                0x21,
                0x65,
                0x2A,
                0x90,
                0x98,
                0x69,
                0x0D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDLoRoCenterMixLvl_x10
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0xA2,
                0xFB,
                0x1C,
                0xB3,
                0x25,
                0xF4,
                0x4B,
                0x9B,
                0xFD,
                0xE7,
                0x11,
                0x12,
                0x67,
                0x85,
                0x8C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDLoRoSurroundMixLvl_x10
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF6,
                0xCF,
                0x25,
                0xE7,
                0x56,
                0xEB,
                0xC7,
                0x40,
                0x84,
                0x50,
                0x2B,
                0x93,
                0x67,
                0xE9,
                0x15,
                0x55
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDAtoDConverterType
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x12,
                0x96,
                0x9F,
                0x71,
                0xA1,
                0x81,
                0xE0,
                0x47,
                0x9A,
                0x05,
                0xD9,
                0x4A,
                0xD5,
                0xFC,
                0xA9,
                0x48
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncDDHeadphoneMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEC,
                0xDB,
                0x52,
                0x40,
                0xF5,
                0x52,
                0xF5,
                0x42,
                0x9B,
                0x00,
                0xD1,
                0x34,
                0xB1,
                0x34,
                0x1B,
                0x9D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncWMVKeyFrameDistance
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5E,
                0x05,
                0x69,
                0x55,
                0x68,
                0xE2,
                0x71,
                0x47,
                0xB8,
                0x3E,
                0x95,
                0x55,
                0xEA,
                0x28,
                0xAE,
                0xD3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncWMVInterlacedEncoding
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0x0F,
                0xD0,
                0xE3,
                0xF5,
                0xC6,
                0x14,
                0x4E,
                0xA5,
                0x88,
                0x0E,
                0xC8,
                0x7A,
                0x72,
                0x6F,
                0x9B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncWMVDecoderComplexity
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAB,
                0x0D,
                0x2C,
                0xF3,
                0xCB,
                0xF3,
                0x17,
                0x42,
                0xB7,
                0x9F,
                0x87,
                0x62,
                0x76,
                0x8B,
                0x5F,
                0x67
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncWMVKeyFrameBufferLevelMarker
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0x11,
                0xFF,
                0x51,
                0xAC,
                0x33,
                0x6C,
                0x42,
                0xA1,
                0xB1,
                0x09,
                0x32,
                0x1B,
                0xDF,
                0x96,
                0xB4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncWMVProduceDummyFrames
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0xD0,
                0x69,
                0xD6,
                0x3C,
                0x18,
                0xE3,
                0x42,
                0xA3,
                0xCA,
                0x2F,
                0x45,
                0x86,
                0xD2,
                0x39,
                0x6C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncStatWMVCBAvg
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9F,
                0x22,
                0xA6,
                0x6A,
                0x02,
                0xD6,
                0x9D,
                0x4B,
                0xB6,
                0x8C,
                0xC1,
                0xAD,
                0x78,
                0x88,
                0x4B,
                0xEF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncStatWMVCBMax
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF8,
                0xBE,
                0x76,
                0xE9,
                0xFE,
                0x00,
                0xB4,
                0x44,
                0xB6,
                0x25,
                0x8F,
                0x23,
                0x8B,
                0xC0,
                0x34,
                0x99
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncStatWMVDecoderComplexityProfile
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC3,
                0x9F,
                0xE6,
                0x89,
                0x9B,
                0x0F,
                0x6C,
                0x43,
                0x97,
                0x4A,
                0xDF,
                0x82,
                0x12,
                0x27,
                0xC9,
                0x0D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncStatMPVSkippedEmptyFrames
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD3,
                0x5F,
                0x19,
                0x32,
                0x0D,
                0x59,
                0x12,
                0x48,
                0xA7,
                0xED,
                0x6D,
                0x63,
                0x9A,
                0x1F,
                0x97,
                0x11
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12PktzSTDBuffer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD0,
                0x1B,
                0x75,
                0x0B,
                0x9E,
                0x81,
                0x8C,
                0x47,
                0x94,
                0x35,
                0x75,
                0x20,
                0x89,
                0x26,
                0xB3,
                0x77
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12PktzStreamID
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x38,
                0xD0,
                0x34,
                0xC8,
                0xE8,
                0xF5,
                0x08,
                0x44,
                0x9B,
                0x60,
                0x88,
                0xF3,
                0x64,
                0x93,
                0xFE,
                0xDF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12PktzInitialPTS
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x65,
                0x20,
                0x4F,
                0x2A,
                0x63,
                0x9A,
                0x20,
                0x4D,
                0xAE,
                0x22,
                0x0A,
                0x1B,
                0xC8,
                0x96,
                0xA3,
                0x15
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12PktzPacketSize
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7A,
                0x34,
                0x71,
                0xAB,
                0x32,
                0x13,
                0xDE,
                0x4D,
                0xA0,
                0xE5,
                0xCC,
                0xF7,
                0xDA,
                0x8A,
                0x0F,
                0x22
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12PktzCopyright
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0xB0,
                0xF4,
                0xC8,
                0x4C,
                0x09,
                0xC7,
                0x43,
                0x8E,
                0x68,
                0xA5,
                0x95,
                0x40,
                0x5A,
                0x6E,
                0xF8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12PktzOriginal
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0x84,
                0x17,
                0x6B,
                0xB9,
                0x31,
                0x64,
                0x49,
                0x94,
                0xCB,
                0x6B,
                0xFF,
                0x86,
                0x6C,
                0xDF,
                0x83
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12MuxPacketOverhead
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0xD7,
                0x0B,
                0xE4,
                0x55,
                0x39,
                0x53,
                0x44,
                0xAC,
                0xF9,
                0xB7,
                0x91,
                0x32,
                0xA3,
                0x8F,
                0xA0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12MuxNumStreams
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0x4A,
                0x16,
                0xF7,
                0xED,
                0xDC,
                0x59,
                0x46,
                0xA8,
                0xF2,
                0xFB,
                0x69,
                0x3F,
                0x2A,
                0x4C,
                0xD0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12MuxEarliestPTS
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB6,
                0x32,
                0x72,
                0x15,
                0x09,
                0xF8,
                0x4E,
                0x47,
                0x94,
                0x64,
                0xA7,
                0xF9,
                0x30,
                0x14,
                0xA8,
                0x17
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12MuxLargestPacketSize
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0xB7,
                0xCE,
                0x35,
                0x61,
                0xF4,
                0x92,
                0x4B,
                0xA4,
                0xEF,
                0x17,
                0xB6,
                0x84,
                0x1E,
                0xD2,
                0x54
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12MuxInitialSCR
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x21,
                0xAD,
                0x33,
                0x34,
                0x91,
                0x1B,
                0x0B,
                0x4A,
                0xB1,
                0x90,
                0x2B,
                0x77,
                0x06,
                0x3B,
                0x63,
                0xA4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12MuxMuxRate
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x72,
                0x7C,
                0x04,
                0xEE,
                0xDB,
                0x4B,
                0x9D,
                0x4A,
                0x8E,
                0x21,
                0x41,
                0x92,
                0x6C,
                0x82,
                0x3D,
                0xA7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12MuxPackSize
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3A,
                0x05,
                0x16,
                0xF9,
                0xE8,
                0x1C,
                0xAF,
                0x4F,
                0xAA,
                0x0B,
                0xBA,
                0x31,
                0xC8,
                0x00,
                0x34,
                0xB8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12MuxSysSTDBufferBound
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0x69,
                0x74,
                0x35,
                0x45,
                0xB5,
                0xE7,
                0x43,
                0xBB,
                0x35,
                0xC5,
                0xE0,
                0xA7,
                0xD5,
                0x09,
                0x3C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12MuxSysRateBound
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0x42,
                0xF0,
                0x05,
                0x30,
                0xEE,
                0x9D,
                0x48,
                0xAE,
                0x28,
                0x20,
                0x5C,
                0x72,
                0x44,
                0x67,
                0x10
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12MuxTargetPacketizer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A,
                0x21,
                0x62,
                0xD8,
                0x15,
                0x20,
                0xDD,
                0x45,
                0x9A,
                0x32,
                0x1B,
                0x3A,
                0xA8,
                0x82,
                0x05,
                0xA0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12MuxSysFixed
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0x98,
                0xFB,
                0xCE,
                0x4F,
                0x89,
                0x2E,
                0x45,
                0x8F,
                0x89,
                0xA4,
                0xEF,
                0x8C,
                0xEC,
                0x06,
                0x3A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12MuxSysCSPS
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x45,
                0xFF,
                0x52,
                0x79,
                0x0D,
                0x9C,
                0x22,
                0x48,
                0xBC,
                0x82,
                0x8A,
                0xD7,
                0x72,
                0xE0,
                0x29,
                0x93
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12MuxSysVideoLock
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x08,
                0x64,
                0x29,
                0xB8,
                0x30,
                0x24,
                0x37,
                0x4D,
                0xA2,
                0xA1,
                0x95,
                0xB3,
                0xE4,
                0x35,
                0xA9,
                0x1D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12MuxSysAudioLock
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0x57,
                0xBB,
                0x0F,
                0x43,
                0x1D,
                0xBF,
                0x47,
                0xBD,
                0x79,
                0xF2,
                0x29,
                0x3D,
                0x8C,
                0xE3,
                0x37
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncMP12MuxDVDNavPacks
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xED,
                0x7C,
                0x60,
                0xC7,
                0xF1,
                0x8C,
                0x99,
                0x4A,
                0x83,
                0xA1,
                0xEE,
                0x54,
                0x61,
                0xBE,
                0x35,
                0x74
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecCommonInputFormat
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x39,
                0x52,
                0x00,
                0xE5,
                0x89,
                0xBD,
                0xE3,
                0x4B,
                0x9C,
                0x0F,
                0x5D,
                0xDE,
                0x31,
                0x79,
                0x88,
                0xCC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecCommonOutputFormat
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x28,
                0x00,
                0x79,
                0x3C,
                0xCE,
                0xC0,
                0x56,
                0x42,
                0xB1,
                0xA2,
                0x1B,
                0x0F,
                0xC8,
                0xB1,
                0xDC,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecCommonMeanBitRate
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0x82,
                0x48,
                0x59,
                0x7A,
                0x00,
                0x7A,
                0x4F,
                0x8E,
                0x41,
                0x5C,
                0x48,
                0xB1,
                0xEA,
                0xC5,
                0xC6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecCommonMeanBitRateInterval
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0x37,
                0xE4,
                0x0E,
                0xA7,
                0x38,
                0x5C,
                0x4C,
                0x94,
                0x4C,
                0x68,
                0xAB,
                0x42,
                0x11,
                0x6B,
                0x85
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVDecAudioOutputFormat_PCM_Stereo_MatrixEncoded
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0x1D,
                0x6E,
                0x69,
                0x8F,
                0x54,
                0x36,
                0x40,
                0x82,
                0x5F,
                0x70,
                0x26,
                0xC6,
                0x00,
                0x11,
                0xBD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVDecAudioOutputFormat_PCM
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0x1D,
                0x6E,
                0x69,
                0x8F,
                0x54,
                0x36,
                0x40,
                0x82,
                0x5F,
                0x70,
                0x26,
                0xC6,
                0x00,
                0x11,
                0xBD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVDecAudioOutputFormat_SPDIF_PCM
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x32,
                0x1D,
                0x6E,
                0x69,
                0x8F,
                0x54,
                0x36,
                0x40,
                0x82,
                0x5F,
                0x70,
                0x26,
                0xC6,
                0x00,
                0x11,
                0xBD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVDecAudioOutputFormat_SPDIF_Bitstream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0x1D,
                0x6E,
                0x69,
                0x8F,
                0x54,
                0x36,
                0x40,
                0x82,
                0x5F,
                0x70,
                0x26,
                0xC6,
                0x00,
                0x11,
                0xBD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVDecAudioOutputFormat_PCM_Headphones
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x34,
                0x1D,
                0x6E,
                0x69,
                0x8F,
                0x54,
                0x36,
                0x40,
                0x82,
                0x5F,
                0x70,
                0x26,
                0xC6,
                0x00,
                0x11,
                0xBD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVDecAudioOutputFormat_PCM_Stereo_Auto
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x35,
                0x1D,
                0x6E,
                0x69,
                0x8F,
                0x54,
                0x36,
                0x40,
                0x82,
                0x5F,
                0x70,
                0x26,
                0xC6,
                0x00,
                0x11,
                0xBD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoImageSize
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0x74,
                0xE5,
                0x5E,
                0x01,
                0x68,
                0xAB,
                0x4C,
                0xAA,
                0xF1,
                0x62,
                0x48,
                0xFA,
                0x84,
                0x1B,
                0xA4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoPixelAspectRatio
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x45,
                0x82,
                0xCF,
                0xB0,
                0x2D,
                0xF3,
                0xDF,
                0x41,
                0xB0,
                0x2C,
                0x87,
                0xBD,
                0x30,
                0x4D,
                0x12,
                0xAB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoInputScanType
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1F,
                0x7E,
                0x47,
                0x38,
                0xA7,
                0x0E,
                0xCD,
                0x42,
                0x8C,
                0xD1,
                0x13,
                0x0C,
                0xED,
                0x57,
                0xC5,
                0x80
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecVideoSWPowerLevel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x47,
                0x23,
                0x5D,
                0xFB,
                0xD8,
                0x4D,
                0x09,
                0x45,
                0xAE,
                0xD0,
                0xDB,
                0x5F,
                0xA9,
                0xAA,
                0x93,
                0xF4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVDecAudioInputWMA
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0x8D,
                0x5E,
                0xC9,
                0x58,
                0x40,
                0x04,
                0x42,
                0x8C,
                0x42,
                0xCB,
                0x24,
                0xD9,
                0x1E,
                0x4B,
                0x9B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVDecAudioInputWMAPro
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0xB7,
                0x28,
                0x01,
                0x72,
                0xDA,
                0xE3,
                0x4F,
                0xBE,
                0xF8,
                0x5C,
                0x52,
                0xE3,
                0x55,
                0x77,
                0x04
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVDecAudioInputDolby
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA0,
                0x28,
                0x42,
                0x8E,
                0x00,
                0xF0,
                0x0B,
                0x4E,
                0x8F,
                0x54,
                0xAB,
                0x8D,
                0x24,
                0xAD,
                0x61,
                0xA2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVDecAudioInputDTS
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0xC0,
                0x0B,
                0x60,
                0x1F,
                0x6A,
                0x91,
                0x4E,
                0xB2,
                0x41,
                0x1B,
                0xBE,
                0xB1,
                0xCB,
                0x19,
                0xE0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVDecAudioInputPCM
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA5,
                0x1D,
                0x42,
                0xF2,
                0xB4,
                0xBB,
                0xD5,
                0x4C,
                0xA9,
                0x96,
                0x93,
                0x3C,
                0x6B,
                0x5D,
                0x13,
                0x47
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVDecAudioInputMPEG
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x36,
                0x6F,
                0x10,
                0x91,
                0xC5,
                0x02,
                0x75,
                0x4F,
                0x97,
                0x19,
                0x3B,
                0x7A,
                0xBF,
                0x75,
                0xE1,
                0xF6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVDecAudioInputAAC
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x28,
                0x78,
                0xDF,
                0x97,
                0x4A,
                0xB9,
                0xE2,
                0x47,
                0xA4,
                0xBC,
                0x51,
                0x19,
                0x4D,
                0xB2,
                0x2A,
                0x4D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVDecAudioInputHEAAC
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAA,
                0xB4,
                0xEF,
                0x16,
                0x0E,
                0x33,
                0x5C,
                0x4F,
                0x98,
                0xA8,
                0xCF,
                0x6A,
                0xC5,
                0x5C,
                0xBE,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_GUID_AVDecAudioInputDolbyDigitalPlus
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0xE1,
                0x03,
                0x08,
                0x5D,
                0x8F,
                0xF5,
                0x47,
                0x99,
                0x08,
                0x19,
                0xA5,
                0xBB,
                0xC9,
                0xFE,
                0x34
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecAACDownmixMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x75,
                0x44,
                0x27,
                0x01,
                0xBB,
                0xF6,
                0x17,
                0x40,
                0xB0,
                0x84,
                0x81,
                0xA7,
                0x63,
                0xC9,
                0x42,
                0xD4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecHEAACDynamicRangeControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBE,
                0x8A,
                0x7C,
                0x28,
                0xA4,
                0x69,
                0x39,
                0x4D,
                0x80,
                0x80,
                0xD3,
                0xD9,
                0x71,
                0x21,
                0x78,
                0xA0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecAudioDualMono
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA8,
                0xCD,
                0x52,
                0x4A,
                0xF8,
                0x30,
                0x16,
                0x42,
                0xBE,
                0x0F,
                0xBA,
                0x0B,
                0x20,
                0x25,
                0x92,
                0x1D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecAudioDualMonoReproMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x86,
                0x61,
                0x10,
                0xA5,
                0x94,
                0xCC,
                0xC9,
                0x4B,
                0x8C,
                0xD9,
                0xAA,
                0x2F,
                0x61,
                0xF6,
                0x80,
                0x7E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVAudioChannelCount
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC4,
                0x83,
                0x35,
                0x1D,
                0x83,
                0x15,
                0x4E,
                0x47,
                0xB7,
                0x1A,
                0x5E,
                0xE4,
                0x63,
                0xC1,
                0x98,
                0xE4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVAudioChannelConfig
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB3,
                0x9C,
                0xF8,
                0x17,
                0x8D,
                0xC3,
                0x68,
                0x43,
                0x9E,
                0xDE,
                0x63,
                0xB9,
                0x4D,
                0x17,
                0x7F,
                0x9F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVAudioSampleRate
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x23,
                0x27,
                0x1D,
                0x97,
                0xCB,
                0x1A,
                0xE7,
                0x42,
                0x85,
                0x5C,
                0x52,
                0x0A,
                0x4B,
                0x70,
                0xA5,
                0xF2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDDSurroundMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x86,
                0xF3,
                0xF2,
                0x99,
                0xD1,
                0x98,
                0x52,
                0x44,
                0xA1,
                0x63,
                0xAB,
                0xC7,
                0x8A,
                0x6E,
                0xB7,
                0x70
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecDDOperationalMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD1,
                0xC6,
                0xD6,
                0xD6,
                0x4E,
                0x06,
                0xDD,
                0x4F,
                0xA4,
                0x0E,
                0x3E,
                0xCB,
                0xFC,
                0xB7,
                0xEB,
                0xD0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecDDMatrixDecodingMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA5,
                0x11,
                0xC8,
                0xDD,
                0xED,
                0x04,
                0xF3,
                0x4B,
                0xA0,
                0xCA,
                0xD0,
                0x04,
                0x49,
                0xF9,
                0x35,
                0x5F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecDDDynamicRangeScaleHigh
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x21,
                0x6C,
                0x19,
                0x50,
                0x33,
                0x1F,
                0xF5,
                0x4A,
                0xB2,
                0x96,
                0x11,
                0x42,
                0x6D,
                0x6C,
                0x87,
                0x89
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecDDDynamicRangeScaleLow
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0x62,
                0x4E,
                0x04,
                0xA5,
                0x11,
                0xD5,
                0x42,
                0xA3,
                0xB2,
                0x3B,
                0xB2,
                0xC7,
                0xC2,
                0xD7,
                0xCF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDecDDStereoDownMixMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2C,
                0x12,
                0xE4,
                0x6C,
                0xE9,
                0x3E,
                0x82,
                0x41,
                0xB4,
                0xAE,
                0xC1,
                0x0F,
                0xC0,
                0x88,
                0x64,
                0x9D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDSPLoudnessEqualization
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0x1A,
                0xFD,
                0x8A,
                0x12,
                0x18,
                0xBF,
                0x4C,
                0x93,
                0x19,
                0x43,
                0x3A,
                0x5B,
                0x2A,
                0x3B,
                0x27
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVDSPSpeakerFill
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA1,
                0xBC,
                0x12,
                0x56,
                0xDA,
                0x56,
                0x82,
                0x45,
                0x8D,
                0xA1,
                0xCA,
                0x80,
                0x90,
                0xF9,
                0x27,
                0x68
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVPriorityControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC8,
                0x3D,
                0xBA,
                0x54,
                0xDE,
                0xBD,
                0x29,
                0x43,
                0xB1,
                0x87,
                0x20,
                0x18,
                0xBC,
                0x5C,
                0x2B,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVRealtimeControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x32,
                0x06,
                0x44,
                0x6F,
                0xAD,
                0xC4,
                0xF7,
                0x4B,
                0x9E,
                0x52,
                0x45,
                0x69,
                0x42,
                0xB4,
                0x54,
                0xB0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncNoInputCopy
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A,
                0x6A,
                0xB4,
                0xD2,
                0xEE,
                0xE8,
                0xC5,
                0x4E,
                0x86,
                0x9E,
                0x44,
                0x9B,
                0x6C,
                0x62,
                0xC8,
                0x1A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncChromaEncodeMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5A,
                0xAB,
                0x47,
                0x8A,
                0x98,
                0x47,
                0x93,
                0x4C,
                0xB5,
                0xA5,
                0x55,
                0x4F,
                0x9A,
                0x3B,
                0x9F,
                0x50
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncProgressiveUpdateTime
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x66,
                0xAF,
                0x9F,
                0x64,
                0xC6,
                0xAF,
                0x28,
                0x48,
                0x8F,
                0xDC,
                0x07,
                0x71,
                0xCD,
                0x9A,
                0xB1,
                0x7D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncChromaUpdateTime
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x98,
                0xD9,
                0x4F,
                0x4B,
                0x74,
                0x42,
                0xBB,
                0x40,
                0x8E,
                0xE4,
                0x07,
                0x55,
                0x3E,
                0x7E,
                0x2D,
                0x3A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncAACEnableVBR
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x98,
                0xBB,
                0x36,
                0xE8,
                0xA3,
                0xFC,
                0xB6,
                0x44,
                0x9A,
                0x39,
                0x24,
                0x78,
                0x6B,
                0xE4,
                0x1B,
                0xE1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoConsecutiveFramesForLayer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0x55,
                0xF3,
                0x0A,
                0x84,
                0xD9,
                0xAE,
                0x45,
                0xBB,
                0xB8,
                0x53,
                0x93,
                0x3E,
                0x0A,
                0xB1,
                0xB5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncVideoMaxNumRefFrameForLayer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x39,
                0xC6,
                0x41,
                0x31,
                0x29,
                0x63,
                0xD1,
                0x40,
                0xB7,
                0xE7,
                0x2F,
                0x0E,
                0x3A,
                0xC1,
                0x8E,
                0x02
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncTileRows
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFC,
                0x50,
                0xC6,
                0xFB,
                0xAB,
                0x41,
                0x9B,
                0x4F,
                0x84,
                0xB5,
                0x06,
                0x5B,
                0xE9,
                0xCD,
                0x99,
                0xEE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CODECAPI_AVEncTileColumns
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0x12,
                0xB3,
                0xB4,
                0xE8,
                0x01,
                0x2C,
                0x45,
                0xB8,
                0x76,
                0x8C,
                0x65,
                0x06,
                0x54,
                0x59,
                0x25
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}