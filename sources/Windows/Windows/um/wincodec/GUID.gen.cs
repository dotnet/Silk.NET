// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class GUID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_VendorMicrosoft
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xCA, 0x49, 0xE7, 0xF0,
                0xEF, 0xED,
                0x89, 0x45,
                0xA7,
                0x3A,
                0xEE,
                0x0E,
                0x62,
                0x6A,
                0x2A,
                0x2B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_VendorMicrosoftBuiltIn
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xFD, 0x30, 0x7A, 0x25,
                0xB6, 0x06,
                0x2B, 0x46,
                0xAE,
                0xA4,
                0x63,
                0xF7,
                0x0B,
                0x86,
                0xE5,
                0x33
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ContainerFormatBmp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x7E, 0xD8, 0xF1, 0x0A,
                0xFE, 0xFC,
                0x88, 0x41,
                0xBD,
                0xEB,
                0xA7,
                0x90,
                0x64,
                0x71,
                0xCB,
                0xE3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ContainerFormatPng
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF4, 0xFA, 0x7C, 0x1B,
                0x3F, 0x71,
                0x3C, 0x47,
                0xBB,
                0xCD,
                0x61,
                0x37,
                0x42,
                0x5F,
                0xAE,
                0xAF
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ContainerFormatIco
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC4, 0x60, 0xA8, 0xA3,
                0x8F, 0x33,
                0x17, 0x4C,
                0x91,
                0x9A,
                0xFB,
                0xA4,
                0xB5,
                0x62,
                0x8F,
                0x21
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ContainerFormatJpeg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAA, 0xA5, 0xE4, 0x19,
                0x62, 0x56,
                0xC5, 0x4F,
                0xA0,
                0xC0,
                0x17,
                0x58,
                0x02,
                0x8E,
                0x10,
                0x57
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ContainerFormatTiff
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x30, 0xCC, 0x3B, 0x16,
                0xE9, 0xE2,
                0x0B, 0x4F,
                0x96,
                0x1D,
                0xA3,
                0xE9,
                0xFD,
                0xB7,
                0x88,
                0xA3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ContainerFormatGif
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x01, 0x56, 0x8A, 0x1F,
                0x4D, 0x7D,
                0xBD, 0x4C,
                0x9C,
                0x82,
                0x1B,
                0xC8,
                0xD4,
                0xEE,
                0xB9,
                0xA5
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ContainerFormatWmp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAA, 0x7C, 0xA3, 0x57,
                0x7A, 0x36,
                0x40, 0x45,
                0x91,
                0x6B,
                0xF1,
                0x83,
                0xC5,
                0x09,
                0x3A,
                0x4B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ContainerFormatDds
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x95, 0xCB, 0x67, 0x99,
                0x85, 0x2E,
                0xC8, 0x4A,
                0x8C,
                0xA2,
                0x83,
                0xD7,
                0xCC,
                0xD4,
                0x25,
                0xC9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ContainerFormatAdng
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0D, 0x6D, 0xFF, 0xF3,
                0xC0, 0x38,
                0xC4, 0x41,
                0xB1,
                0xFE,
                0x1F,
                0x38,
                0x24,
                0xF1,
                0x7B,
                0x84
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ContainerFormatHeif
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x21, 0x25, 0xE6, 0xE1,
                0x87, 0x67,
                0x5B, 0x40,
                0xA3,
                0x39,
                0x50,
                0x07,
                0x15,
                0xB5,
                0x76,
                0x3F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ContainerFormatWebp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE2, 0xB0, 0x94, 0xE0,
                0xF2, 0x67,
                0xB3, 0x45,
                0xB0,
                0xEA,
                0x11,
                0x53,
                0x37,
                0xCA,
                0x7C,
                0xF3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ContainerFormatRaw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x60, 0xCE, 0x99, 0xFE,
                0x9C, 0xF1,
                0x3C, 0x43,
                0xA3,
                0xAE,
                0x00,
                0xAC,
                0xEF,
                0xA9,
                0xCA,
                0x21
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormatDontCare
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat1bppIndexed
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x01
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat2bppIndexed
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x02
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat4bppIndexed
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x03
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat8bppIndexed
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x04
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormatBlackWhite
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x05
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat2bppGray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x06
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat4bppGray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x07
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat8bppGray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x08
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat8bppAlpha
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x16, 0x01, 0xCD, 0xE6,
                0xBA, 0xEE,
                0x61, 0x41,
                0xAA,
                0x85,
                0x27,
                0xDD,
                0x9F,
                0xB3,
                0xA8,
                0x95
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat16bppBGR555
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x09
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat16bppBGR565
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x0A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat16bppBGRA5551
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2B, 0x7C, 0xEC, 0x05,
                0xE6, 0xF1,
                0x61, 0x49,
                0xAD,
                0x46,
                0xE1,
                0xCC,
                0x81,
                0x0A,
                0x87,
                0xD2
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat16bppGray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x0B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat24bppBGR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x0C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat24bppRGB
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x0D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat32bppBGR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x0E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat32bppBGRA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x0F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat32bppPBGRA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x10
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat32bppGrayFloat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x11
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat32bppRGB
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x95, 0x6B, 0x8C, 0xD9,
                0xFE, 0x3E,
                0xD6, 0x47,
                0xBB,
                0x25,
                0xEB,
                0x17,
                0x48,
                0xAB,
                0x0C,
                0xF1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat32bppRGBA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2D, 0xAD, 0xC7, 0xF5,
                0x8D, 0x6A,
                0xDD, 0x43,
                0xA7,
                0xA8,
                0xA2,
                0x99,
                0x35,
                0x26,
                0x1A,
                0xE9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat32bppPRGBA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x50, 0xA6, 0xC4, 0x3C,
                0x27, 0xA5,
                0x37, 0x4D,
                0xA9,
                0x16,
                0x31,
                0x42,
                0xC7,
                0xEB,
                0xED,
                0xBA
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat48bppRGB
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x15
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat48bppBGR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x84, 0xA3, 0x05, 0xE6,
                0x68, 0xB4,
                0xCE, 0x46,
                0xBB,
                0x2E,
                0x36,
                0xF1,
                0x80,
                0xE6,
                0x43,
                0x13
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat64bppRGB
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x11, 0x21, 0x18, 0xA1,
                0x6D, 0x18,
                0x42, 0x4D,
                0xBC,
                0x6A,
                0x9C,
                0x83,
                0x03,
                0xA8,
                0xDF,
                0xF9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat64bppRGBA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x16
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat64bppBGRA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x7C, 0xFF, 0x62, 0x15,
                0x52, 0xD3,
                0xF9, 0x46,
                0x97,
                0x9E,
                0x42,
                0x97,
                0x6B,
                0x79,
                0x22,
                0x46
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat64bppPRGBA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x17
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat64bppPBGRA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8E, 0x8E, 0x51, 0x8C,
                0xEC, 0xA4,
                0x8B, 0x46,
                0xAE,
                0x70,
                0xC9,
                0xA3,
                0x5A,
                0x9C,
                0x55,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat16bppGrayFixedPoint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x13
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat32bppBGR101010
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x14
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat48bppRGBFixedPoint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x12
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat48bppBGRFixedPoint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0E, 0x14, 0xCA, 0x49,
                0xB6, 0xCA,
                0x3B, 0x49,
                0x9D,
                0xDF,
                0x60,
                0x18,
                0x7C,
                0x37,
                0x53,
                0x2A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat96bppRGBFixedPoint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x18
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat96bppRGBFloat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8F, 0xD7, 0xFE, 0xE3,
                0xDB, 0xE8,
                0xCF, 0x4A,
                0x84,
                0xC1,
                0xE9,
                0x7F,
                0x61,
                0x36,
                0xB3,
                0x27
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat128bppRGBAFloat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x19
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat128bppPRGBAFloat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x1A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat128bppRGBFloat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x1B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat32bppCMYK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x1C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat64bppRGBAFixedPoint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x1D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat64bppBGRAFixedPoint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3C, 0xE3, 0x6D, 0x35,
                0xD2, 0x54,
                0x23, 0x4A,
                0xBB,
                0x04,
                0x9B,
                0x7B,
                0xF9,
                0xB1,
                0xD4,
                0x2D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat64bppRGBFixedPoint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x40
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat128bppRGBAFixedPoint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x1E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat128bppRGBFixedPoint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x41
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat64bppRGBAHalf
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x3A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat64bppPRGBAHalf
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC2, 0x26, 0xAD, 0x58,
                0x23, 0xC6,
                0x9D, 0x4D,
                0xB3,
                0x20,
                0x38,
                0x7E,
                0x49,
                0xF8,
                0xC4,
                0x42
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat64bppRGBHalf
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x42
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat48bppRGBHalf
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x3B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat32bppRGBE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x3D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat16bppGrayHalf
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x3E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat32bppGrayFixedPoint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x3F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat32bppRGBA1010102
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x72, 0x8D, 0x23, 0x25,
                0xF9, 0xFC,
                0x22, 0x45,
                0xB5,
                0x14,
                0x55,
                0x78,
                0xE5,
                0xAD,
                0x55,
                0xE0
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat32bppRGBA1010102XR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x9A, 0x6B, 0xDE, 0x00,
                0x01, 0xC1,
                0x4B, 0x43,
                0xB5,
                0x02,
                0xD0,
                0x16,
                0x5E,
                0xE1,
                0x12,
                0x2C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat32bppR10G10B10A2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB5, 0x1B, 0x4E, 0x60,
                0x3C, 0x8A,
                0x65, 0x4B,
                0xB1,
                0x1C,
                0xBC,
                0x0B,
                0x8D,
                0xD7,
                0x5B,
                0x7F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat32bppR10G10B10A2HDR10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5D, 0x5C, 0x21, 0x9C,
                0xCC, 0x1A,
                0x0E, 0x4F,
                0xA4,
                0xBC,
                0x70,
                0xFB,
                0x3A,
                0xE8,
                0xFD,
                0x28
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat64bppCMYK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x1F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat24bpp3Channels
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x20
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat32bpp4Channels
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x21
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat40bpp5Channels
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x22
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat48bpp6Channels
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x23
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat56bpp7Channels
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x24
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat64bpp8Channels
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x25
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat48bpp3Channels
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x26
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat64bpp4Channels
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x27
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat80bpp5Channels
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x28
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat96bpp6Channels
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x29
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat112bpp7Channels
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x2A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat128bpp8Channels
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x2B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat40bppCMYKAlpha
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x2C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat80bppCMYKAlpha
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x2D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat32bpp3ChannelsAlpha
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x2E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat40bpp4ChannelsAlpha
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x2F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat48bpp5ChannelsAlpha
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat56bpp6ChannelsAlpha
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x31
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat64bpp7ChannelsAlpha
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x32
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat72bpp8ChannelsAlpha
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x33
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat64bpp3ChannelsAlpha
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x34
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat80bpp4ChannelsAlpha
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x35
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat96bpp5ChannelsAlpha
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x36
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat112bpp6ChannelsAlpha
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x37
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat128bpp7ChannelsAlpha
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x38
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat144bpp8ChannelsAlpha
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xC3, 0xDD, 0x6F,
                0x03, 0x4E,
                0xFE, 0x4B,
                0xB1,
                0x85,
                0x3D,
                0x77,
                0x76,
                0x8D,
                0xC9,
                0x39
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat8bppY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x54, 0xDB, 0xB4, 0x91,
                0xF9, 0x2D,
                0xF0, 0x42,
                0xB4,
                0x49,
                0x29,
                0x09,
                0xBB,
                0x3D,
                0xF8,
                0x8E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat8bppCb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0xF2, 0x39, 0x13,
                0xFE, 0x6B,
                0x3E, 0x4C,
                0x93,
                0x02,
                0xE4,
                0xF3,
                0xA6,
                0xD0,
                0xCA,
                0x2A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat8bppCr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x53, 0x50, 0x14, 0xB8,
                0x16, 0x21,
                0xF0, 0x49,
                0x88,
                0x35,
                0xED,
                0x84,
                0x4B,
                0x20,
                0x5C,
                0x51
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat16bppCbCr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x6E, 0xBA, 0x95, 0xFF,
                0xE0, 0x11,
                0x63, 0x42,
                0xBB,
                0x45,
                0x01,
                0x72,
                0x1F,
                0x34,
                0x60,
                0xA4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat16bppYQuantizedDctCoefficients
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x33, 0xF4, 0x55, 0xA3,
                0xE8, 0x48,
                0x42, 0x4A,
                0x84,
                0xD8,
                0xE2,
                0xAA,
                0x26,
                0xCA,
                0x80,
                0xA4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat16bppCbQuantizedDctCoefficients
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x61, 0xFF, 0xC4, 0xD2,
                0xA5, 0x56,
                0xC2, 0x49,
                0x8B,
                0x5C,
                0x4C,
                0x19,
                0x25,
                0x96,
                0x48,
                0x37
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_WICPixelFormat16bppCrQuantizedDctCoefficients
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF0, 0x54, 0xE3, 0x2F,
                0x80, 0x16,
                0xD8, 0x42,
                0x92,
                0x31,
                0xE7,
                0x3C,
                0x05,
                0x65,
                0xBF,
                0xC1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define GUID_WICPixelFormatUndefined GUID_WICPixelFormatDontCare")]
    public static ref readonly Guid GUID_WICPixelFormatUndefined => ref GUID_WICPixelFormatDontCare;
}
