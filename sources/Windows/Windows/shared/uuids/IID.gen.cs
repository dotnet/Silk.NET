// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IBaseVideoMixer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x40, 0xD6, 0xDE, 0x61,
                0x12, 0xE9,
                0xCE, 0x11,
                0xA0,
                0x99,
                0x00,
                0xAA,
                0x00,
                0x47,
                0x9A,
                0x58
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectDrawVideo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB0, 0x9E, 0xD3, 0x36,
                0x75, 0xDD,
                0xCE, 0x11,
                0xBF,
                0x0E,
                0x00,
                0xAA,
                0x00,
                0x55,
                0x59,
                0x5A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IQualProp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB0, 0xEC, 0xD0, 0x1B,
                0xE2, 0xF8,
                0xCE, 0x11,
                0xAA,
                0xC6,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0x99,
                0xA3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IVPObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x62, 0x28, 0x29, 0xCE,
                0x88, 0xFC,
                0xD0, 0x11,
                0x9E,
                0x69,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0xC1,
                0x5B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IVPControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC1, 0x12, 0xDF, 0x25,
                0xE0, 0x3D,
                0xD1, 0x11,
                0x9E,
                0x69,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0xC1,
                0x5B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IVPVBIObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x02, 0x98, 0x4B, 0x81,
                0x88, 0x1C,
                0xD1, 0x11,
                0xBA,
                0xD9,
                0x00,
                0x60,
                0x97,
                0x44,
                0x11,
                0x1A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IVPConfig
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x60, 0xA6, 0x29, 0xBC,
                0xE3, 0x30,
                0xD0, 0x11,
                0x9E,
                0x69,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0xC1,
                0x5B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IVPNotify
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA1, 0x94, 0x67, 0xC7,
                0xC5, 0xD6,
                0xD0, 0x11,
                0x9E,
                0x69,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0xC1,
                0x5B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IVPNotify2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x83, 0x71, 0xF4, 0xEB,
                0x64, 0x87,
                0xD1, 0x11,
                0x9E,
                0x69,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0xC1,
                0x5B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IVPVBIConfig
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x00, 0x9B, 0x52, 0xEC,
                0x1F, 0x1A,
                0xD1, 0x11,
                0xBA,
                0xD9,
                0x00,
                0x60,
                0x97,
                0x44,
                0x11,
                0x1A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IVPVBINotify
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x01, 0x9B, 0x52, 0xEC,
                0x1F, 0x1A,
                0xD1, 0x11,
                0xBA,
                0xD9,
                0x00,
                0x60,
                0x97,
                0x44,
                0x11,
                0x1A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IMixerPinConfig
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE1, 0xDD, 0x3C, 0x59,
                0x59, 0x07,
                0xD1, 0x11,
                0x9E,
                0x69,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0xC1,
                0x5B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IMixerPinConfig2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x82, 0x71, 0xF4, 0xEB,
                0x64, 0x87,
                0xD1, 0x11,
                0x9E,
                0x69,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0xC1,
                0x5B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDDVideoPortContainer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x60, 0x27, 0x14, 0x6C,
                0x33, 0xA7,
                0xCE, 0x11,
                0xA5,
                0x21,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0xE5,
                0x60
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectDrawKernel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x20, 0xC1, 0x56, 0x8D,
                0x08, 0x6A,
                0xD0, 0x11,
                0x9B,
                0x06,
                0x00,
                0xA0,
                0xC9,
                0x03,
                0xA3,
                0xB8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectDrawSurfaceKernel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA0, 0x5D, 0x75, 0x60,
                0x40, 0x6A,
                0xD0, 0x11,
                0x9B,
                0x06,
                0x00,
                0xA0,
                0xC9,
                0x03,
                0xA3,
                0xB8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IFullScreenVideo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x10, 0x71, 0x1D, 0xDD,
                0x36, 0x78,
                0xCF, 0x11,
                0xBF,
                0x47,
                0x00,
                0xAA,
                0x00,
                0x55,
                0x59,
                0x5A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IFullScreenVideoEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x70, 0x94, 0x47, 0x53,
                0xDD, 0xF1,
                0xCF, 0x11,
                0xBC,
                0x42,
                0x00,
                0xAA,
                0x00,
                0xAC,
                0x74,
                0xF6
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IAMDirectSound
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x60, 0x42, 0x6F, 0x54,
                0x3E, 0xD5,
                0xCF, 0x11,
                0xB3,
                0xF0,
                0x00,
                0xAA,
                0x00,
                0x37,
                0x61,
                0xC5
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IMpegAudioDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x70, 0xD5, 0x5D, 0xB4,
                0x77, 0x3C,
                0xD1, 0x11,
                0xAB,
                0xE1,
                0x00,
                0xA0,
                0xC9,
                0x05,
                0xF3,
                0x75
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IAMLine21Decoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x21, 0x4A, 0x8D, 0x6E,
                0x0C, 0x31,
                0xD0, 0x11,
                0xB7,
                0x9A,
                0x00,
                0xAA,
                0x00,
                0x37,
                0x67,
                0xA7
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IAMWstDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x21, 0xDE, 0x56, 0xC0,
                0xC2, 0x75,
                0xD3, 0x11,
                0xA1,
                0x84,
                0x00,
                0x10,
                0x5A,
                0xEF,
                0x9F,
                0x33
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
