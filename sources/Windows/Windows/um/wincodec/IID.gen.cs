// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IWICPalette
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0x00,
                0x00,
                0x00,
                0xF2,
                0xA8,
                0x77,
                0x48,
                0xBA,
                0x0A,
                0xFD,
                0x2B,
                0x66,
                0x45,
                0xFB,
                0x94
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICBitmapSource
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0x01,
                0x00,
                0x00,
                0xF2,
                0xA8,
                0x77,
                0x48,
                0xBA,
                0x0A,
                0xFD,
                0x2B,
                0x66,
                0x45,
                0xFB,
                0x94
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICFormatConverter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0x03,
                0x00,
                0x00,
                0xF2,
                0xA8,
                0x77,
                0x48,
                0xBA,
                0x0A,
                0xFD,
                0x2B,
                0x66,
                0x45,
                0xFB,
                0x94
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICPlanarFormatConverter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCB,
                0xE9,
                0xBE,
                0xBE,
                0xB0,
                0x83,
                0xCC,
                0x4D,
                0x81,
                0x32,
                0xB0,
                0xAA,
                0xA5,
                0x5E,
                0xAC,
                0x96
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICBitmapScaler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0x03,
                0x00,
                0x00,
                0xF2,
                0xA8,
                0x77,
                0x48,
                0xBA,
                0x0A,
                0xFD,
                0x2B,
                0x66,
                0x45,
                0xFB,
                0x94
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICBitmapClipper
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xCF,
                0xFB,
                0xE4,
                0x3D,
                0x22,
                0x81,
                0x4E,
                0x93,
                0x33,
                0xD6,
                0x35,
                0x55,
                0x6D,
                0xD1,
                0xB5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICBitmapFlipRotator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4F,
                0x83,
                0x09,
                0x50,
                0x6A,
                0x2D,
                0xCE,
                0x41,
                0x9E,
                0x1B,
                0x17,
                0xC5,
                0xAF,
                0xF7,
                0xA7,
                0x82
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICBitmapLock
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x23,
                0x01,
                0x00,
                0x00,
                0xF2,
                0xA8,
                0x77,
                0x48,
                0xBA,
                0x0A,
                0xFD,
                0x2B,
                0x66,
                0x45,
                0xFB,
                0x94
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICBitmap
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x21,
                0x01,
                0x00,
                0x00,
                0xF2,
                0xA8,
                0x77,
                0x48,
                0xBA,
                0x0A,
                0xFD,
                0x2B,
                0x66,
                0x45,
                0xFB,
                0x94
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICColorContext
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0x3A,
                0x61,
                0x3C,
                0xB2,
                0x34,
                0xEA,
                0x44,
                0x9A,
                0x7C,
                0x45,
                0xAE,
                0xA9,
                0xC6,
                0xFD,
                0x6D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICColorTransform
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4F,
                0x03,
                0x6F,
                0xB6,
                0xE2,
                0xD0,
                0xAB,
                0x40,
                0xB4,
                0x36,
                0x6D,
                0xE3,
                0x9E,
                0x32,
                0x1A,
                0x94
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICFastMetadataEncoder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x09,
                0x2C,
                0x4E,
                0xB8,
                0xC9,
                0x78,
                0xC4,
                0x4A,
                0x8B,
                0xD3,
                0x52,
                0x4A,
                0xE1,
                0x66,
                0x3A,
                0x2F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICStream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0xF8,
                0x5F,
                0x13,
                0xB7,
                0x22,
                0xDF,
                0x4D,
                0xB0,
                0xF6,
                0x21,
                0x8F,
                0x4F,
                0x29,
                0x9A,
                0x43
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICEnumMetadataItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6D,
                0xB4,
                0x2B,
                0xDC,
                0x07,
                0x3F,
                0x1E,
                0x48,
                0x86,
                0x25,
                0x22,
                0x0C,
                0x4A,
                0xED,
                0xBB,
                0x33
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICMetadataQueryReader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x68,
                0x96,
                0x98,
                0x30,
                0xC9,
                0xE1,
                0x97,
                0x45,
                0xB3,
                0x95,
                0x45,
                0x8E,
                0xED,
                0xB8,
                0x08,
                0xDF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICMetadataQueryWriter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1A,
                0x79,
                0x21,
                0xA7,
                0xEF,
                0x0D,
                0x06,
                0x4D,
                0xBD,
                0x91,
                0x21,
                0x18,
                0xBF,
                0x1D,
                0xB1,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICBitmapEncoder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0x01,
                0x00,
                0x00,
                0xF2,
                0xA8,
                0x77,
                0x48,
                0xBA,
                0x0A,
                0xFD,
                0x2B,
                0x66,
                0x45,
                0xFB,
                0x94
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICBitmapFrameEncode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0x01,
                0x00,
                0x00,
                0xF2,
                0xA8,
                0x77,
                0x48,
                0xBA,
                0x0A,
                0xFD,
                0x2B,
                0x66,
                0x45,
                0xFB,
                0x94
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICPlanarBitmapFrameEncode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB8,
                0xB7,
                0x28,
                0xF9,
                0x21,
                0x22,
                0xC1,
                0x40,
                0xB7,
                0x2E,
                0x7E,
                0x82,
                0xF1,
                0x97,
                0x4D,
                0x1A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICImageEncoder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF8,
                0x5B,
                0xC7,
                0x04,
                0xE1,
                0x3C,
                0x3B,
                0x47,
                0xAC,
                0xC5,
                0x3C,
                0xC4,
                0xF5,
                0xE9,
                0x49,
                0x99
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICBitmapDecoder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE7,
                0xE9,
                0xDD,
                0x9E,
                0xEE,
                0x8D,
                0xEA,
                0x47,
                0x99,
                0xDF,
                0xE6,
                0xFA,
                0xF2,
                0xED,
                0x44,
                0xBF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICBitmapSourceTransform
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1B,
                0x81,
                0x16,
                0x3B,
                0x43,
                0x6A,
                0xC9,
                0x4E,
                0xB7,
                0x13,
                0x3D,
                0x5A,
                0x0C,
                0x13,
                0xB9,
                0x40
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICPlanarBitmapSourceTransform
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0x9C,
                0xFF,
                0x3A,
                0x95,
                0xBE,
                0x03,
                0x43,
                0xB9,
                0x27,
                0xE7,
                0xD1,
                0x6F,
                0xF4,
                0xA6,
                0x13
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICBitmapFrameDecode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1B,
                0x81,
                0x16,
                0x3B,
                0x43,
                0x6A,
                0xC9,
                0x4E,
                0xA8,
                0x13,
                0x3D,
                0x93,
                0x0C,
                0x13,
                0xB9,
                0x40
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICProgressiveLevelControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6F,
                0x29,
                0xAC,
                0xDA,
                0xA5,
                0x7A,
                0xBF,
                0x4D,
                0x8D,
                0x15,
                0x22,
                0x5C,
                0x59,
                0x76,
                0xF8,
                0x91
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICProgressCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0xF9,
                0x76,
                0x47,
                0x17,
                0x95,
                0xFA,
                0x45,
                0xBF,
                0x24,
                0xE8,
                0x9C,
                0x5E,
                0xC5,
                0xC6,
                0x0C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICBitmapCodecProgressNotification
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4E,
                0x02,
                0xC1,
                0x64,
                0xCF,
                0xC3,
                0x62,
                0x44,
                0x80,
                0x78,
                0x88,
                0xC2,
                0xB1,
                0x1C,
                0x46,
                0xD9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICComponentInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0A,
                0x3F,
                0xBC,
                0x23,
                0x8B,
                0x69,
                0x57,
                0x43,
                0x88,
                0x6B,
                0xF2,
                0x4D,
                0x50,
                0x67,
                0x13,
                0x34
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICFormatConverterInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x65,
                0xFB,
                0x34,
                0x9F,
                0xF4,
                0x13,
                0x15,
                0x4F,
                0xBC,
                0x57,
                0x37,
                0x26,
                0xB5,
                0xE5,
                0x3D,
                0x9F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICBitmapCodecInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC4,
                0x44,
                0x7A,
                0xE8,
                0x6E,
                0xB7,
                0x47,
                0x4C,
                0x8B,
                0x09,
                0x29,
                0x8E,
                0xB1,
                0x2A,
                0x27,
                0x14
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICBitmapEncoderInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0xB4,
                0xC9,
                0x94,
                0x9F,
                0xA0,
                0x92,
                0x4F,
                0x8A,
                0x1E,
                0x4A,
                0x9B,
                0xCE,
                0x7E,
                0x76,
                0xFB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICBitmapDecoderInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7F,
                0x00,
                0xCD,
                0xD8,
                0x8F,
                0xD0,
                0x91,
                0x41,
                0x9B,
                0xFC,
                0x23,
                0x6E,
                0xA7,
                0xF0,
                0xE4,
                0xB5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICPixelFormatInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0xA6,
                0xED,
                0xE8,
                0x48,
                0x3D,
                0x1A,
                0x43,
                0xAB,
                0x44,
                0x69,
                0x05,
                0x9B,
                0xE8,
                0x8B,
                0xBE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICPixelFormatInfo2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA2,
                0x33,
                0xDB,
                0xA9,
                0x5F,
                0xAF,
                0xC7,
                0x43,
                0xB6,
                0x79,
                0x74,
                0xF5,
                0x98,
                0x4B,
                0x5A,
                0xA4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICImagingFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA9,
                0xC8,
                0x5E,
                0xEC,
                0x95,
                0xC3,
                0x14,
                0x43,
                0x9C,
                0x77,
                0x54,
                0xD7,
                0xA9,
                0x35,
                0xFF,
                0x70
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICImagingFactory2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x45,
                0x6B,
                0x81,
                0x7B,
                0x96,
                0x19,
                0x76,
                0x44,
                0xB1,
                0x32,
                0xDE,
                0x9E,
                0x24,
                0x7C,
                0x8A,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICDevelopRawNotificationCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6E,
                0x5A,
                0xC7,
                0x95,
                0x8C,
                0x3E,
                0xC2,
                0x4E,
                0x85,
                0xA8,
                0xAE,
                0xBC,
                0xC5,
                0x51,
                0xE5,
                0x9B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICDevelopRaw
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0x5E,
                0xEC,
                0xFB,
                0xBE,
                0xF7,
                0x65,
                0x4B,
                0xB7,
                0xF8,
                0xC0,
                0xC8,
                0x1F,
                0xEF,
                0x02,
                0x6D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICDdsDecoder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x37,
                0xD5,
                0x9C,
                0x40,
                0x32,
                0x85,
                0xCB,
                0x40,
                0x97,
                0x74,
                0xE2,
                0xFE,
                0xB2,
                0xDF,
                0x4E,
                0x9C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICDdsEncoder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4C,
                0xDB,
                0xAC,
                0x5C,
                0x7E,
                0x40,
                0xB3,
                0x41,
                0xB9,
                0x36,
                0xD0,
                0xF0,
                0x10,
                0xCD,
                0x67,
                0x32
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICDdsFrameDecode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x61,
                0x0C,
                0x4C,
                0x3D,
                0xA4,
                0x18,
                0xE4,
                0x41,
                0xBD,
                0x80,
                0x48,
                0x1A,
                0x4F,
                0xC9,
                0xF4,
                0x64
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICJpegFrameDecode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6E,
                0xF6,
                0x39,
                0x89,
                0x6A,
                0xC4,
                0x21,
                0x4C,
                0xA9,
                0xD1,
                0x98,
                0xB3,
                0x27,
                0xCE,
                0x16,
                0x79
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWICJpegFrameEncode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1F,
                0x60,
                0x0C,
                0x2F,
                0xC6,
                0xD2,
                0x8C,
                0x46,
                0xAB,
                0xFA,
                0x49,
                0x49,
                0x5D,
                0x98,
                0x3E,
                0xD1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}