// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.DirectX;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class CLSID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D12DAffineTransform
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x85, 0x74, 0xA9, 0x6A,
                0x54, 0x63,
                0xFC, 0x4C,
                0x90,
                0x8C,
                0xE4,
                0xA7,
                0x4F,
                0x62,
                0xC9,
                0x6C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D13DPerspectiveTransform
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0B, 0x4D, 0x84, 0xC2,
                0x86, 0x3D,
                0xE7, 0x46,
                0x85,
                0xBA,
                0x52,
                0x6C,
                0x92,
                0x40,
                0xF3,
                0xFB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D13DTransform
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x04, 0x7B, 0x46, 0xE8,
                0x61, 0xEC,
                0x8A, 0x4B,
                0xB5,
                0xDE,
                0xD4,
                0xD7,
                0x3D,
                0xEB,
                0xEA,
                0x5A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1ArithmeticComposite
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x37, 0x14, 0x15, 0xFC,
                0x9A, 0x04,
                0x84, 0x47,
                0xA2,
                0x4A,
                0xF1,
                0xC4,
                0xDA,
                0xF2,
                0x09,
                0x87
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Atlas
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE4, 0x2B, 0x3E, 0x91,
                0xCF, 0xFD,
                0xE2, 0x4F,
                0xA5,
                0xF0,
                0x24,
                0x54,
                0xF1,
                0x4F,
                0xF4,
                0x08
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1BitmapSource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4D, 0xC2, 0xB6, 0x5F,
                0xDD, 0xC6,
                0x31, 0x42,
                0x94,
                0x04,
                0x50,
                0xF4,
                0xD5,
                0xC3,
                0x25,
                0x2D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Blend
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x7B, 0xB7, 0xC5, 0x81,
                0xF8, 0x13,
                0xDD, 0x4C,
                0xAD,
                0x20,
                0xC8,
                0x90,
                0x54,
                0x7A,
                0xC6,
                0x5D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Border
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC0, 0x49, 0x2D, 0x2A,
                0xCF, 0x4A,
                0xC7, 0x43,
                0x8C,
                0x6A,
                0x7C,
                0x4A,
                0x27,
                0x87,
                0x4D,
                0x27
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Brightness
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1E, 0x8D, 0xEA, 0x8C,
                0xB0, 0x77,
                0x86, 0x49,
                0xB3,
                0xB9,
                0x2F,
                0x0C,
                0x0E,
                0xAE,
                0x78,
                0x87
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1ColorManagement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4C, 0x52, 0x28, 0x1A,
                0xD6, 0xFD,
                0xA4, 0x4A,
                0xAE,
                0x8F,
                0x83,
                0x7E,
                0xB8,
                0x26,
                0x7B,
                0x37
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1ColorMatrix
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD6, 0x03, 0x1F, 0x92,
                0x1C, 0x64,
                0xDF, 0x47,
                0x85,
                0x2D,
                0xB4,
                0xBB,
                0x61,
                0x53,
                0xAE,
                0x11
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Composite
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x51, 0x9F, 0xFC, 0x48,
                0xAC, 0xF6,
                0xF1, 0x48,
                0x8B,
                0x58,
                0x3B,
                0x28,
                0xAC,
                0x46,
                0xF7,
                0x6D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1ConvolveMatrix
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x08, 0x8C, 0x7F, 0x40,
                0x33, 0x55,
                0x31, 0x43,
                0xA3,
                0x41,
                0x23,
                0xCC,
                0x38,
                0x77,
                0x84,
                0x3E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Crop
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x10, 0x71, 0x3F, 0xE2,
                0x9A, 0x0E,
                0x24, 0x43,
                0xAF,
                0x47,
                0x6A,
                0x2C,
                0x0C,
                0x46,
                0xF3,
                0x5B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1DirectionalBlur
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA6, 0x19, 0x43, 0x17,
                0xE9, 0x58,
                0xB2, 0x49,
                0xBB,
                0x63,
                0xCA,
                0xF2,
                0xC8,
                0x11,
                0xA3,
                0xDB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1DiscreteTransfer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xCD, 0x6F, 0x86, 0x90,
                0x8E, 0x48,
                0x4B, 0x45,
                0xAF,
                0x06,
                0xE5,
                0x04,
                0x1B,
                0x66,
                0xC3,
                0x6C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1DisplacementMap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x64, 0x83, 0xC4, 0xED,
                0x17, 0x04,
                0x11, 0x41,
                0x94,
                0x50,
                0x43,
                0x84,
                0x5F,
                0xA9,
                0xF8,
                0x90
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1DistantDiffuse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x62, 0xFD, 0x7E, 0x3E,
                0x2D, 0xA3,
                0xD4, 0x46,
                0xA8,
                0x3C,
                0x52,
                0x78,
                0x88,
                0x9A,
                0xC9,
                0x54
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1DistantSpecular
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE5, 0x1E, 0x8C, 0x42,
                0xB8, 0x77,
                0x50, 0x44,
                0x8A,
                0xB5,
                0x72,
                0x21,
                0x9C,
                0x21,
                0xAB,
                0xDA
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1DpiCompensation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC7, 0xC5, 0x26, 0x6C,
                0xE0, 0x34,
                0xFC, 0x46,
                0x9C,
                0xFD,
                0xE5,
                0x82,
                0x37,
                0x06,
                0xE2,
                0x28
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Flood
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x20, 0x3C, 0xC2, 0x61,
                0x69, 0xAE,
                0x8E, 0x4D,
                0x94,
                0xCF,
                0x50,
                0x07,
                0x8D,
                0xF6,
                0x38,
                0xF2
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1GammaTransfer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC4, 0x44, 0x94, 0x40,
                0x19, 0xC4,
                0xA0, 0x41,
                0xB0,
                0xC1,
                0x8C,
                0xD0,
                0xC0,
                0xA1,
                0x8E,
                0x42
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1GaussianBlur
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x69, 0x6D, 0xEB, 0x1F,
                0xE6, 0x2F,
                0xC9, 0x4A,
                0x8C,
                0x58,
                0x1D,
                0x7F,
                0x93,
                0xE7,
                0xA6,
                0xA5
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Scale
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x69, 0x93, 0xAF, 0x9D,
                0x46, 0x38,
                0x0E, 0x4D,
                0xA4,
                0x4E,
                0x0C,
                0x60,
                0x79,
                0x34,
                0xA5,
                0xD7
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Histogram
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD0, 0xB7, 0x1D, 0x88,
                0xEE, 0xF7,
                0x4D, 0x4D,
                0xA6,
                0xD2,
                0x46,
                0x97,
                0xAC,
                0xC6,
                0x6E,
                0xE8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1HueRotation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xEC, 0x58, 0x44, 0x0F,
                0x32, 0x4B,
                0x1B, 0x49,
                0x9E,
                0x85,
                0xBD,
                0x73,
                0xF4,
                0x4D,
                0x3E,
                0xB6
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1LinearTransfer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xFD, 0xC8, 0x47, 0xAD,
                0xEF, 0x63,
                0xCC, 0x4A,
                0x9B,
                0x51,
                0x67,
                0x97,
                0x9C,
                0x03,
                0x6C,
                0x06
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1LuminanceToAlpha
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB7, 0x1A, 0x25, 0x41,
                0xEB, 0x0B,
                0xF8, 0x46,
                0x9D,
                0xA7,
                0x59,
                0xE9,
                0x3F,
                0xCC,
                0xE5,
                0xDE
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Morphology
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0D, 0xC4, 0xE6, 0xEA,
                0x6A, 0x62,
                0x2D, 0x4C,
                0xBF,
                0xCB,
                0x39,
                0x10,
                0x01,
                0xAB,
                0xE2,
                0x02
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1OpacityMetadata
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x6A, 0x00, 0x53, 0x6C,
                0x50, 0x44,
                0x99, 0x41,
                0xAA,
                0x5B,
                0xAD,
                0x16,
                0x56,
                0xFE,
                0xCE,
                0x5E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1PointDiffuse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC3, 0x03, 0xE3, 0xB9,
                0x8C, 0xC0,
                0x91, 0x4F,
                0x8B,
                0x7B,
                0x38,
                0x65,
                0x6B,
                0xC4,
                0x8C,
                0x20
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1PointSpecular
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x26, 0xCA, 0xC3, 0x09,
                0xE2, 0x3A,
                0x09, 0x4F,
                0x9E,
                0xBC,
                0xED,
                0x38,
                0x65,
                0xD5,
                0x3F,
                0x22
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Premultiply
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x19, 0xB4, 0xEA, 0x06,
                0xED, 0xDE,
                0x18, 0x40,
                0x80,
                0xD2,
                0x3E,
                0x1D,
                0x47,
                0x1A,
                0xDE,
                0xB2
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Saturation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xCF, 0xD9, 0xB2, 0x5C,
                0x7D, 0x32,
                0x9F, 0x45,
                0xA0,
                0xCE,
                0x40,
                0xC0,
                0xB2,
                0x08,
                0x6B,
                0xF7
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Shadow
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x61, 0xA3, 0x7E, 0xC6,
                0x63, 0x18,
                0x69, 0x4E,
                0x89,
                0xDB,
                0x69,
                0x5D,
                0x3E,
                0x9A,
                0x5B,
                0x6B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1SpotDiffuse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x05, 0x11, 0x8A, 0x81,
                0x32, 0x79,
                0xF4, 0x44,
                0xAA,
                0x86,
                0x08,
                0xAE,
                0x7B,
                0x2F,
                0x2C,
                0x93
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1SpotSpecular
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1E, 0x42, 0xAE, 0xED,
                0x54, 0x76,
                0x37, 0x4A,
                0x9D,
                0xB8,
                0x71,
                0xAC,
                0xC1,
                0xBE,
                0xB3,
                0xC1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1TableTransfer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC3, 0x18, 0xF8, 0x5B,
                0x43, 0x5E,
                0xCB, 0x48,
                0xB6,
                0x31,
                0x86,
                0x83,
                0x96,
                0xD6,
                0xA1,
                0xD4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Tile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x38, 0x41, 0x78, 0xB0,
                0x76, 0x3B,
                0xC5, 0x4B,
                0xB1,
                0x3B,
                0x0F,
                0xA2,
                0xAD,
                0x02,
                0x65,
                0x9F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1Turbulence
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAE, 0xB6, 0x2B, 0xCF,
                0x9A, 0x88,
                0xD7, 0x4A,
                0xBA,
                0x29,
                0xA2,
                0xFD,
                0x73,
                0x2C,
                0x9F,
                0xC9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1UnPremultiply
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x89, 0xC4, 0x9A, 0xFB,
                0x8D, 0xAD,
                0xED, 0x41,
                0x99,
                0x99,
                0xBB,
                0x63,
                0x47,
                0xD1,
                0x10,
                0xF7
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
