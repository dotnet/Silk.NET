// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IDCompositionDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0xA9,
                0x7E,
                0xC3,
                0xAA,
                0xE7,
                0x0D,
                0x45,
                0xB1,
                0x6F,
                0x97,
                0x46,
                0xCB,
                0x04,
                0x07,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionTarget
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0xD0,
                0xCD,
                0xEA,
                0x7E,
                0x11,
                0x17,
                0x4E,
                0x88,
                0xF4,
                0xD1,
                0xB1,
                0x2B,
                0x0E,
                0x3D,
                0x89,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionVisual
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x05,
                0x93,
                0x4D,
                0x7B,
                0x09,
                0x51,
                0x46,
                0x9A,
                0x60,
                0xF0,
                0xF2,
                0x51,
                0x16,
                0xE2,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0xB0,
                0x81,
                0xEC,
                0xCB,
                0xBF,
                0x8D,
                0x4E,
                0xB1,
                0x93,
                0xA9,
                0x15,
                0x58,
                0x79,
                0x99,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionTransform3D
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0x57,
                0x18,
                0x71,
                0x6B,
                0x24,
                0xF2,
                0x41,
                0xAA,
                0xD1,
                0x04,
                0x43,
                0xF7,
                0xF4,
                0xBF,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionTransform
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0xFA,
                0x55,
                0xFD,
                0xE0,
                0x37,
                0x20,
                0x4C,
                0x95,
                0xD2,
                0x9B,
                0xE4,
                0x5B,
                0xC3,
                0x3F,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionTranslateTransform
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0x11,
                0x79,
                0x06,
                0xF0,
                0xC6,
                0x7D,
                0x41,
                0x83,
                0x23,
                0x26,
                0x9E,
                0x98,
                0x7F,
                0x59,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionScaleTransform
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0xE9,
                0xFD,
                0x71,
                0xEF,
                0x40,
                0xEF,
                0x45,
                0xBD,
                0x51,
                0x68,
                0xB0,
                0x37,
                0xC3,
                0x39,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionRotateTransform
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xD8,
                0x1E,
                0x64,
                0x96,
                0xAE,
                0xC5,
                0x46,
                0x90,
                0xDC,
                0x32,
                0x77,
                0x4C,
                0xC5,
                0xC6,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionSkewTransform
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0xA7,
                0x7A,
                0xE5,
                0xDB,
                0xDC,
                0x72,
                0x4C,
                0x9C,
                0x61,
                0x05,
                0x91,
                0xF5,
                0x88,
                0x89,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionMatrixTransform
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0xFF,
                0xCD,
                0x16,
                0x03,
                0xC5,
                0x9C,
                0x41,
                0x83,
                0xF2,
                0x09,
                0x65,
                0xC7,
                0xAF,
                0x1F,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionEffectGroup
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x9A,
                0x92,
                0xA7,
                0xB2,
                0xE6,
                0xD6,
                0x4B,
                0x8B,
                0x95,
                0x40,
                0x40,
                0x11,
                0x9C,
                0xA3,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionTranslateTransform3D
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0x6D,
                0x63,
                0x91,
                0xA1,
                0x9B,
                0x32,
                0x45,
                0xAA,
                0xF7,
                0xE3,
                0x34,
                0x49,
                0x94,
                0xD7,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionScaleTransform3D
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0x9E,
                0x9E,
                0x2A,
                0x4B,
                0x36,
                0x15,
                0x4B,
                0xA7,
                0xC4,
                0xA1,
                0x99,
                0x7F,
                0x78,
                0xB3,
                0x89,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionRotateTransform3D
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3F,
                0xB2,
                0xF5,
                0xD8,
                0x29,
                0xD4,
                0x91,
                0x4A,
                0xB5,
                0x5A,
                0xD2,
                0xF4,
                0x5F,
                0xD7,
                0x5B,
                0x18,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionMatrixTransform3D
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0x63,
                0x33,
                0x4B,
                0x3B,
                0x64,
                0xB7,
                0x41,
                0xB6,
                0xE0,
                0xCC,
                0xF2,
                0x2D,
                0x34,
                0x46,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionClip
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0x37,
                0xAC,
                0x64,
                0x3F,
                0x9D,
                0xEC,
                0x45,
                0xA1,
                0x09,
                0x7C,
                0xAC,
                0x0E,
                0x7A,
                0x13,
                0xA7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionRectangleClip
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0xAD,
                0x42,
                0x98,
                0xCF,
                0xD9,
                0x08,
                0x49,
                0xAE,
                0xD7,
                0x48,
                0xB5,
                0x1D,
                0xA5,
                0xE7,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionSurface
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x49,
                0x8A,
                0xBB,
                0x99,
                0x2C,
                0x5A,
                0x4F,
                0x96,
                0xF5,
                0x48,
                0x19,
                0x02,
                0x7F,
                0xA3,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionVirtualSurface
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0x1C,
                0x47,
                0xAE,
                0x53,
                0x5F,
                0x24,
                0x4A,
                0x8D,
                0x3E,
                0xD0,
                0xC3,
                0x9C,
                0x30,
                0xB3,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionDevice2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0x46,
                0xF6,
                0x75,
                0x8E,
                0x1B,
                0x7C,
                0x44,
                0x9B,
                0xC6,
                0x75,
                0xFE,
                0xA8,
                0x0B,
                0x5B,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionDesktopDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0x33,
                0x46,
                0x5F,
                0x08,
                0x1E,
                0xB8,
                0x4C,
                0x8C,
                0x75,
                0xCE,
                0x24,
                0x33,
                0x3F,
                0x56,
                0x02,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionDeviceDebug
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0xC6,
                0xA3,
                0xA1,
                0x4F,
                0x22,
                0x81,
                0x4A,
                0x97,
                0x73,
                0x4F,
                0x03,
                0xA8,
                0x9D,
                0x3C,
                0x6C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionSurfaceFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0xBC,
                0x34,
                0xE3,
                0x37,
                0x39,
                0x02,
                0x4E,
                0x85,
                0xEB,
                0xFC,
                0xF4,
                0xEB,
                0x30,
                0xD2,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionVisual2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x16,
                0xDE,
                0xE8,
                0x31,
                0x43,
                0x26,
                0x4B,
                0xBC,
                0x5F,
                0x6A,
                0x32,
                0x1D,
                0x34,
                0x7A,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionVisualDebug
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0xB8,
                0xD2,
                0xFE,
                0xB4,
                0x5E,
                0xA0,
                0x43,
                0xAE,
                0xA3,
                0x35,
                0xF6,
                0x52,
                0x80,
                0xF9,
                0x1B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionVisual3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0xF4,
                0x75,
                0x27,
                0xC1,
                0xB6,
                0x15,
                0x40,
                0xB0,
                0xBE,
                0xB3,
                0xE7,
                0xD6,
                0xA4,
                0x97,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionDevice3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0xCB,
                0x87,
                0x09,
                0x16,
                0xF9,
                0xBF,
                0x48,
                0x8D,
                0x35,
                0xCE,
                0x76,
                0x41,
                0x78,
                0x1B,
                0xD9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionFilterEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x21,
                0xC4,
                0x30,
                0xB2,
                0x8C,
                0x9F,
                0x4E,
                0xB1,
                0x33,
                0x37,
                0xBE,
                0x27,
                0x0D,
                0x4A,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionGaussianBlurEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0xD0,
                0xD4,
                0x45,
                0xD4,
                0x1B,
                0x4E,
                0x45,
                0x88,
                0x94,
                0x2B,
                0xFA,
                0x68,
                0x44,
                0x30,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionBrightnessEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x49,
                0x27,
                0x60,
                0x3A,
                0xCB,
                0xAB,
                0x49,
                0x93,
                0x4F,
                0xD7,
                0x98,
                0xDA,
                0x4F,
                0x7D,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionColorMatrixEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0x0A,
                0x17,
                0xC1,
                0xE2,
                0x3C,
                0x66,
                0x49,
                0x90,
                0xD4,
                0x55,
                0x40,
                0x8B,
                0xFC,
                0x84,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionShadowEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x8A,
                0xD1,
                0x4A,
                0xD2,
                0xCF,
                0x2F,
                0x4C,
                0xBB,
                0x62,
                0x96,
                0xE5,
                0x4F,
                0xDB,
                0x68,
                0x79,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionHueRotationEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0xF9,
                0xB9,
                0x6D,
                0x70,
                0x07,
                0x81,
                0x47,
                0xB0,
                0xC6,
                0x38,
                0x19,
                0x12,
                0xF9,
                0xD1,
                0x67,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionSaturationEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0xEB,
                0x8D,
                0xA0,
                0x58,
                0x32,
                0xA4,
                0x4F,
                0x9F,
                0x16,
                0x91,
                0x74,
                0xD3,
                0xFE,
                0x93,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionTurbulenceEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x5B,
                0xA5,
                0xA6,
                0x9C,
                0xC0,
                0xF3,
                0x49,
                0x91,
                0x93,
                0xA4,
                0x19,
                0x22,
                0xC8,
                0x97,
                0x15,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionLinearTransferEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0xEE,
                0x05,
                0x43,
                0xA0,
                0xC4,
                0x88,
                0x4C,
                0x93,
                0x85,
                0x67,
                0x12,
                0x4E,
                0x01,
                0x76,
                0x83,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionTableTransferEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x82,
                0x7E,
                0x9B,
                0xC5,
                0x69,
                0xB4,
                0x4E,
                0xA5,
                0xF5,
                0xA7,
                0x03,
                0x3F,
                0x51,
                0x32,
                0xCD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionCompositeEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x16,
                0x66,
                0x57,
                0x31,
                0xA2,
                0x4D,
                0x49,
                0xA3,
                0x8D,
                0x00,
                0xFD,
                0x5E,
                0xC4,
                0xDB,
                0x46,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionBlendEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0xDC,
                0xEC,
                0x33,
                0x8A,
                0x57,
                0x11,
                0x4A,
                0x9C,
                0x14,
                0x0C,
                0xB9,
                0x05,
                0x17,
                0xF9,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionArithmeticCompositeEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0xDF,
                0x67,
                0x3B,
                0xDD,
                0xE3,
                0x61,
                0x4E,
                0xB6,
                0x40,
                0x46,
                0xC2,
                0xF3,
                0xD7,
                0x39,
                0xDC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionAffineTransform2DEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0xB9,
                0x74,
                0x0B,
                0xD6,
                0xCD,
                0x2F,
                0x49,
                0xBB,
                0xBC,
                0x5E,
                0xD3,
                0x21,
                0x57,
                0x02,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionDelegatedInkTrail
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0x8E,
                0x44,
                0xC2,
                0x7D,
                0x54,
                0x57,
                0x40,
                0x8C,
                0xF5,
                0x81,
                0x44,
                0xED,
                0xE1,
                0xC2,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionInkTrailDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0x7C,
                0x0C,
                0xDF,
                0xEB,
                0xCD,
                0x4A,
                0x4D,
                0xB9,
                0x1C,
                0x72,
                0x1B,
                0xF2,
                0x2F,
                0x4E,
                0x6C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionTexture
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0xB1,
                0x9B,
                0x92,
                0x5F,
                0x72,
                0x3B,
                0x43,
                0xAB,
                0xD7,
                0x27,
                0x30,
                0x75,
                0xA8,
                0x35,
                0xF2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDCompositionDevice4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCA,
                0x5C,
                0xFC,
                0x85,
                0xA6,
                0x2D,
                0x4C,
                0x49,
                0x86,
                0xB6,
                0x4A,
                0x77,
                0x5C,
                0x04,
                0x9B,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
