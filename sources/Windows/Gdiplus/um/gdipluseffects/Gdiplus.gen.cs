// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Gdiplus;
public static unsafe partial class Gdiplus
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid BlurEffectGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA4,
                0x80,
                0x3C,
                0x63,
                0x43,
                0x18,
                0x2B,
                0x48,
                0x9E,
                0xF2,
                0xBE,
                0x28,
                0x34,
                0xC5,
                0xFD,
                0xD4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SharpenEffectGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0xF3,
                0xCB,
                0x63,
                0x26,
                0xC5,
                0x2C,
                0x40,
                0x8F,
                0x71,
                0x62,
                0xC5,
                0x40,
                0xBF,
                0x51,
                0x42
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ColorMatrixEffectGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0x26,
                0x8F,
                0x71,
                0x33,
                0x79,
                0xE3,
                0x40,
                0xA5,
                0x11,
                0x5F,
                0x68,
                0xFE,
                0x14,
                0xDD,
                0x74
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ColorLUTEffectGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA9,
                0x72,
                0xCE,
                0xA7,
                0x7F,
                0x0F,
                0xD7,
                0x40,
                0xB3,
                0xCC,
                0xD0,
                0xC0,
                0x2D,
                0x5C,
                0x32,
                0x12
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BrightnessContrastEffectGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE1,
                0xDB,
                0xA1,
                0xD3,
                0xC4,
                0x8E,
                0x17,
                0x4C,
                0x9F,
                0x4C,
                0xEA,
                0x97,
                0xAD,
                0x1C,
                0x34,
                0x3D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid HueSaturationLightnessEffectGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC3,
                0xD6,
                0x2D,
                0x8B,
                0x07,
                0xEB,
                0x87,
                0x4D,
                0xA5,
                0xF0,
                0x71,
                0x08,
                0xE2,
                0x6A,
                0x9C,
                0x5F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid LevelsEffectGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEC,
                0x54,
                0xC3,
                0x99,
                0x31,
                0x2A,
                0x3A,
                0x4F,
                0x8C,
                0x34,
                0x17,
                0xA8,
                0x03,
                0xB3,
                0x3A,
                0x25
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TintEffectGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0xAF,
                0x77,
                0x10,
                0x48,
                0x28,
                0x41,
                0x44,
                0x94,
                0x89,
                0x44,
                0xAD,
                0x4C,
                0x2D,
                0x7A,
                0x2C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ColorBalanceEffectGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7D,
                0x59,
                0x7E,
                0x53,
                0x1E,
                0x25,
                0xDA,
                0x48,
                0x96,
                0x64,
                0x29,
                0xCA,
                0x49,
                0x6B,
                0x70,
                0xF8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid RedEyeCorrectionEffectGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0x9D,
                0xD2,
                0x74,
                0xA4,
                0x69,
                0x66,
                0x42,
                0x95,
                0x49,
                0x3C,
                0xC5,
                0x28,
                0x36,
                0xB6,
                0x32
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ColorCurveEffectGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0x00,
                0x6A,
                0xDD,
                0xE4,
                0x58,
                0x67,
                0x4A,
                0x9D,
                0x9B,
                0xD4,
                0x8E,
                0xB8,
                0x81,
                0xA5,
                0x3D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.GdipCreateEffect"]/*'/>
    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::Status")]
    public static extern GpStatus GdipCreateEffect([NativeTypeName("const GUID")] Guid guid, CGpEffect** effect);
    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.GdipDeleteEffect"]/*'/>
    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::Status")]
    public static extern GpStatus GdipDeleteEffect([NativeTypeName("Gdiplus::CGpEffect *")] CGpEffect* effect);
    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.GdipGetEffectParameterSize"]/*'/>
    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::Status")]
    public static extern GpStatus GdipGetEffectParameterSize([NativeTypeName("Gdiplus::CGpEffect *")] CGpEffect* effect, uint* size);
    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.GdipSetEffectParameters"]/*'/>
    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::Status")]
    public static extern GpStatus GdipSetEffectParameters([NativeTypeName("Gdiplus::CGpEffect *")] CGpEffect* effect, [NativeTypeName("const void *")] void* @params, [NativeTypeName("const UINT")] uint size);
    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.GdipGetEffectParameters"]/*'/>
    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::Status")]
    public static extern GpStatus GdipGetEffectParameters([NativeTypeName("Gdiplus::CGpEffect *")] CGpEffect* effect, uint* size, void* @params);
}