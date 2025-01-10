// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CLSID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CaptureGraphBuilder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0xB6,
                0x87,
                0xBF,
                0x27,
                0x8C,
                0xD0,
                0x11,
                0xB3,
                0xF0,
                0x00,
                0xAA,
                0x00,
                0x37,
                0x61,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CaptureGraphBuilder2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0xB6,
                0x87,
                0xBF,
                0x27,
                0x8C,
                0xD0,
                0x11,
                0xB3,
                0xF0,
                0x00,
                0xAA,
                0x00,
                0x37,
                0x61,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ProtoFilterGraph
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0xEB,
                0x36,
                0xE4,
                0x4F,
                0x52,
                0xCE,
                0x11,
                0x9F,
                0x53,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0xA7,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_SystemClock
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0xEB,
                0x36,
                0xE4,
                0x4F,
                0x52,
                0xCE,
                0x11,
                0x9F,
                0x53,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0xA7,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_FilterMapper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0xEB,
                0x36,
                0xE4,
                0x4F,
                0x52,
                0xCE,
                0x11,
                0x9F,
                0x53,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0xA7,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_FilterGraph
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0xEB,
                0x36,
                0xE4,
                0x4F,
                0x52,
                0xCE,
                0x11,
                0x9F,
                0x53,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0xA7,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_FilterGraphNoThread
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0xEB,
                0x36,
                0xE4,
                0x4F,
                0x52,
                0xCE,
                0x11,
                0x9F,
                0x53,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0xA7,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_FilterGraphPrivateThread
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0xBC,
                0xEC,
                0xA3,
                0x1A,
                0x58,
                0x76,
                0x44,
                0xB6,
                0x93,
                0xA6,
                0x33,
                0x40,
                0x46,
                0x2D,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MPEG1Doc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0xD1,
                0xBB,
                0xE4,
                0x69,
                0x42,
                0xCE,
                0x11,
                0x83,
                0x8D,
                0x00,
                0xAA,
                0x00,
                0x55,
                0x59,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_FileSource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x22,
                0x17,
                0x70,
                0xE3,
                0x8A,
                0xCE,
                0x11,
                0xA8,
                0x5C,
                0x00,
                0xAA,
                0x00,
                0x2F,
                0xEA,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MPEG1PacketPlayer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x59,
                0xC2,
                0x26,
                0xA9,
                0x4C,
                0xCE,
                0x11,
                0xA8,
                0x28,
                0x00,
                0xAA,
                0x00,
                0x2F,
                0xEA,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MPEG1Splitter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0x75,
                0x64,
                0x33,
                0x2A,
                0x94,
                0xCE,
                0x11,
                0xA8,
                0x70,
                0x00,
                0xAA,
                0x00,
                0x2F,
                0xEA,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CMpegVideoCodec
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x07,
                0xB5,
                0xFE,
                0xEF,
                0x7B,
                0xCE,
                0x11,
                0x9B,
                0xD9,
                0x00,
                0x00,
                0xE2,
                0x02,
                0x59,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CMpegAudioCodec
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x86,
                0x22,
                0x4A,
                0xEF,
                0x7B,
                0xCE,
                0x11,
                0x9B,
                0xD9,
                0x00,
                0x00,
                0xE2,
                0x02,
                0x59,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_TextRender
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0x29,
                0x06,
                0xE3,
                0xE5,
                0x27,
                0xCE,
                0x11,
                0x87,
                0x5D,
                0x00,
                0x60,
                0x8C,
                0xB7,
                0x80,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_InfTee
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x8A,
                0x38,
                0xF8,
                0xBB,
                0xD5,
                0xD0,
                0x11,
                0xBE,
                0x5A,
                0x00,
                0x80,
                0xC7,
                0x06,
                0x56,
                0x8E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AviSplitter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x4C,
                0x54,
                0x1B,
                0x0B,
                0xFD,
                0xCE,
                0x11,
                0x8C,
                0x63,
                0x00,
                0xAA,
                0x00,
                0x44,
                0xB5,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AviReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x4C,
                0x54,
                0x1B,
                0x0B,
                0xFD,
                0xCE,
                0x11,
                0x8C,
                0x63,
                0x00,
                0xAA,
                0x00,
                0x44,
                0xB5,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_VfwCapture
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0x4C,
                0x54,
                0x1B,
                0x0B,
                0xFD,
                0xCE,
                0x11,
                0x8C,
                0x63,
                0x00,
                0xAA,
                0x00,
                0x44,
                0xB5,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CaptureProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0x4C,
                0x54,
                0x1B,
                0x0B,
                0xFD,
                0xCE,
                0x11,
                0x8C,
                0x63,
                0x00,
                0xAA,
                0x00,
                0x44,
                0xB5,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_FGControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0xEB,
                0x36,
                0xE4,
                0x4F,
                0x52,
                0xCE,
                0x11,
                0x9F,
                0x53,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0xA7,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MOVReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x48,
                0x58,
                0x44,
                0xEE,
                0xF8,
                0xCE,
                0x11,
                0xB2,
                0xD4,
                0x00,
                0xDD,
                0x01,
                0x10,
                0x1B,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_QuickTimeParser
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0xD5,
                0x1B,
                0xD5,
                0x48,
                0x75,
                0xCF,
                0x11,
                0xA5,
                0x20,
                0x00,
                0x80,
                0xC7,
                0x7E,
                0xF5,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_QTDec
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x96,
                0xFE,
                0xFD,
                0xA3,
                0x74,
                0xD0,
                0x11,
                0xAF,
                0xA7,
                0x00,
                0xAA,
                0x00,
                0xB6,
                0x7A,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AVIDoc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0x8A,
                0x58,
                0xD3,
                0x81,
                0x07,
                0xCE,
                0x11,
                0xB0,
                0x3A,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0xA7,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_VideoRenderer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0x02,
                0xE1,
                0x70,
                0x56,
                0x55,
                0xCE,
                0x11,
                0x97,
                0xC0,
                0x00,
                0xAA,
                0x00,
                0x55,
                0x59,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_Colour
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0xE1,
                0x43,
                0x16,
                0xF5,
                0x90,
                0xCE,
                0x11,
                0x97,
                0xD5,
                0x00,
                0xAA,
                0x00,
                0x55,
                0x59,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_Dither
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x85,
                0xA0,
                0x1D,
                0xDC,
                0x9E,
                0xCF,
                0x11,
                0xBC,
                0x10,
                0x00,
                0xAA,
                0x00,
                0xAC,
                0x74,
                0xF6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ModexRenderer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0x76,
                0x16,
                0x07,
                0x11,
                0x50,
                0xCF,
                0x11,
                0xBF,
                0x33,
                0x00,
                0xAA,
                0x00,
                0x55,
                0x59,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AudioRender
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x29,
                0x06,
                0xE3,
                0xE5,
                0x27,
                0xCE,
                0x11,
                0x87,
                0x5D,
                0x00,
                0x60,
                0x8C,
                0xB7,
                0x80,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AudioProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0x9F,
                0x58,
                0x05,
                0x56,
                0xC3,
                0xCE,
                0x11,
                0xBF,
                0x01,
                0x00,
                0xAA,
                0x00,
                0x55,
                0x59,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DSoundRender
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x68,
                0x37,
                0x79,
                0xD0,
                0x07,
                0xCF,
                0x11,
                0xA2,
                0x4D,
                0x00,
                0x20,
                0xAF,
                0xD7,
                0x97,
                0x67,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AudioRecord
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0x29,
                0x06,
                0xE3,
                0xE5,
                0x27,
                0xCE,
                0x11,
                0x87,
                0x5D,
                0x00,
                0x60,
                0x8C,
                0xB7,
                0x80,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AudioInputMixerProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0xCA,
                0xA8,
                0x2C,
                0x3F,
                0x3C,
                0xD2,
                0x11,
                0xB7,
                0x3D,
                0x00,
                0xC0,
                0x4F,
                0xB6,
                0xBD,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AVIDec
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0xD4,
                0x49,
                0xCF,
                0x15,
                0x11,
                0xCE,
                0x11,
                0xB0,
                0x3A,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0xA7,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AVIDraw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0xDF,
                0x88,
                0xA8,
                0x90,
                0x1E,
                0xCF,
                0x11,
                0xAC,
                0x98,
                0x00,
                0xAA,
                0x00,
                0x4C,
                0x0F,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ACMWrapper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0xCF,
                0x08,
                0x6A,
                0x18,
                0x0E,
                0xCF,
                0x11,
                0xA2,
                0x4D,
                0x00,
                0x20,
                0xAF,
                0xD7,
                0x97,
                0x67,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AsyncReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0xEB,
                0x36,
                0xE4,
                0x4F,
                0x52,
                0xCE,
                0x11,
                0x9F,
                0x53,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0xA7,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_URLReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0xEB,
                0x36,
                0xE4,
                0x4F,
                0x52,
                0xCE,
                0x11,
                0x9F,
                0x53,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0xA7,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_PersistMonikerPID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0xEB,
                0x36,
                0xE4,
                0x4F,
                0x52,
                0xCE,
                0x11,
                0x9F,
                0x53,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0xA7,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AVICo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x28,
                0x6E,
                0xD7,
                0x63,
                0x15,
                0xCF,
                0x11,
                0xAC,
                0x98,
                0x00,
                0xAA,
                0x00,
                0x4C,
                0x0F,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_FileWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0xE5,
                0x96,
                0x85,
                0xA5,
                0x0D,
                0xD0,
                0x11,
                0xBD,
                0x21,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AviDest
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0x09,
                0x51,
                0xE2,
                0x37,
                0xF1,
                0xCE,
                0x11,
                0x8B,
                0x67,
                0x00,
                0xAA,
                0x00,
                0xA3,
                0xF1,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AviMuxProptyPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0xB5,
                0x47,
                0xC6,
                0x7C,
                0x15,
                0xD0,
                0x11,
                0xBD,
                0x23,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AviMuxProptyPage1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0xE9,
                0x9A,
                0x0A,
                0xC0,
                0x85,
                0xD0,
                0x11,
                0xBD,
                0x42,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AVIMIDIRender
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0x53,
                0xB6,
                0x07,
                0x45,
                0xC4,
                0xCE,
                0x11,
                0xAF,
                0xDE,
                0x00,
                0xAA,
                0x00,
                0x6C,
                0x14,
                0xF4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WMAsfReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0x63,
                0x74,
                0x18,
                0xB7,
                0x5B,
                0xD3,
                0x11,
                0xAC,
                0xBE,
                0x00,
                0x80,
                0xC7,
                0x5E,
                0x24,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WMAsfWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0E,
                0x22,
                0x23,
                0x7C,
                0xBB,
                0x55,
                0xD3,
                0x11,
                0x8B,
                0x16,
                0x00,
                0xC0,
                0x4F,
                0xB6,
                0xBD,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MPEG2Demultiplexer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0xC2,
                0xB6,
                0xAF,
                0x41,
                0x2C,
                0xD3,
                0x11,
                0x8A,
                0x60,
                0x00,
                0x00,
                0xF8,
                0x1E,
                0x0E,
                0x4A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MPEG2Demultiplexer_NoClock
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x33,
                0x7D,
                0x68,
                0x44,
                0x36,
                0x7A,
                0x46,
                0xAD,
                0xFE,
                0x6C,
                0xD7,
                0xA8,
                0x5C,
                0x4A,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MMSPLITTER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x6B,
                0xE8,
                0x3A,
                0xE8,
                0x7B,
                0xD1,
                0x11,
                0xAB,
                0xE6,
                0x00,
                0xA0,
                0xC9,
                0x05,
                0xF3,
                0x75,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_StreamBufferSink
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x7A,
                0xB4,
                0x2D,
                0x39,
                0xCF,
                0xC2,
                0x43,
                0xB4,
                0xD6,
                0x0C,
                0xD8,
                0xD9,
                0x09,
                0x46,
                0xF4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_SBE2Sink
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0x85,
                0x44,
                0xE2,
                0xDA,
                0x95,
                0x05,
                0x42,
                0x9A,
                0x27,
                0x7E,
                0xC8,
                0x1E,
                0x72,
                0x3B,
                0x1A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_StreamBufferSource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xFE,
                0xF5,
                0xC9,
                0x51,
                0xF8,
                0xB5,
                0x4E,
                0x99,
                0xEE,
                0xAD,
                0x60,
                0x2A,
                0xF1,
                0xE6,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_StreamBufferConfig
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0x68,
                0x8A,
                0xFA,
                0x64,
                0xC8,
                0xA2,
                0x4B,
                0xAD,
                0x53,
                0xD3,
                0x87,
                0x6A,
                0x87,
                0x49,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_StreamBufferPropertyHandler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0x73,
                0x7A,
                0xE3,
                0x01,
                0xFB,
                0xDC,
                0x43,
                0x91,
                0x4E,
                0xAA,
                0xEE,
                0x76,
                0x09,
                0x5A,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_StreamBufferThumbnailHandler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0x90,
                0x37,
                0x71,
                0xE1,
                0x5E,
                0xBA,
                0x45,
                0x80,
                0x70,
                0xA1,
                0x33,
                0x7D,
                0x27,
                0x62,
                0xFA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_Mpeg2VideoStreamAnalyzer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0xD7,
                0xFA,
                0x6C,
                0x5D,
                0x73,
                0xA5,
                0x4A,
                0x8A,
                0xFC,
                0xAF,
                0x91,
                0xA7,
                0xD6,
                0x1E,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_StreamBufferRecordingAttributes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0x63,
                0xAA,
                0xCC,
                0x57,
                0x10,
                0x78,
                0x47,
                0xAE,
                0x92,
                0x12,
                0x06,
                0xAB,
                0x9A,
                0xCE,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_StreamBufferComposeRecording
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0xC4,
                0x82,
                0xD6,
                0x0A,
                0xA9,
                0xFE,
                0x42,
                0xB9,
                0xE1,
                0x03,
                0x10,
                0x98,
                0x49,
                0xC4,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_SBE2File
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0x94,
                0xA0,
                0x93,
                0xE8,
                0x51,
                0x5B,
                0x48,
                0x90,
                0x4A,
                0x8D,
                0x6B,
                0x97,
                0xDC,
                0x6B,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DVVideoCodec
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x7C,
                0xB7,
                0xB1,
                0xE4,
                0xC3,
                0xCF,
                0x11,
                0xAF,
                0x79,
                0x00,
                0xAA,
                0x00,
                0xB6,
                0x7A,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DVVideoEnc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x36,
                0xAA,
                0x13,
                0x6F,
                0xBB,
                0xD0,
                0x11,
                0xAF,
                0xB9,
                0x00,
                0xAA,
                0x00,
                0xB6,
                0x7A,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DVSplitter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0x16,
                0xB3,
                0x4E,
                0xC6,
                0x9F,
                0xCF,
                0x11,
                0xAF,
                0x6E,
                0x00,
                0xAA,
                0x00,
                0xB6,
                0x7A,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DVMux
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x7E,
                0x9D,
                0x12,
                0x0D,
                0xC1,
                0xD0,
                0x11,
                0xAF,
                0xB9,
                0x00,
                0xAA,
                0x00,
                0xB6,
                0x7A,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_SeekingPassThru
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0xF7,
                0x0A,
                0x06,
                0xDD,
                0x68,
                0xD0,
                0x11,
                0x8F,
                0xC1,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_Line21Decoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x4A,
                0x8D,
                0x6E,
                0x0C,
                0x31,
                0xD0,
                0x11,
                0xB7,
                0x9A,
                0x00,
                0xAA,
                0x00,
                0x37,
                0x67,
                0xA7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_Line21Decoder2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x32,
                0x64,
                0x20,
                0xE4,
                0xA1,
                0x01,
                0xEE,
                0x4B,
                0xB3,
                0xE1,
                0x37,
                0x02,
                0xC8,
                0xED,
                0xC5,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CCAFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0xA5,
                0x07,
                0x3D,
                0xCA,
                0x35,
                0x7C,
                0x44,
                0x9B,
                0x05,
                0x8D,
                0x85,
                0xCE,
                0x92,
                0x4F,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_OverlayMixer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x43,
                0x87,
                0xCD,
                0x36,
                0x37,
                0xD0,
                0x11,
                0x9E,
                0x69,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0xC1,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_VBISurfaces
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x98,
                0x4B,
                0x81,
                0x88,
                0x1C,
                0xD1,
                0x11,
                0xBA,
                0xD9,
                0x00,
                0x60,
                0x97,
                0x44,
                0x11,
                0x1A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WSTDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x06,
                0xBC,
                0x70,
                0x66,
                0x56,
                0xD3,
                0x11,
                0xA1,
                0x84,
                0x00,
                0x10,
                0x5A,
                0xEF,
                0x9F,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MjpegDec
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0x56,
                0x10,
                0x30,
                0xFF,
                0x6D,
                0xD2,
                0x11,
                0x9E,
                0xEB,
                0x00,
                0x60,
                0x08,
                0x03,
                0x9E,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MJPGEnc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0xB0,
                0x0A,
                0xB8,
                0x16,
                0x74,
                0xD2,
                0x11,
                0x9E,
                0xEB,
                0x00,
                0x60,
                0x08,
                0x03,
                0x9E,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_SystemDeviceEnum
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x5D,
                0xBE,
                0x62,
                0xEB,
                0x60,
                0xD0,
                0x11,
                0xBD,
                0x3B,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CDeviceMoniker
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0xD4,
                0x15,
                0x43,
                0x8C,
                0x5B,
                0xD0,
                0x11,
                0xBD,
                0x3B,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_VideoInputDeviceCategory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0xB3,
                0x0B,
                0x86,
                0x01,
                0x5D,
                0xD0,
                0x11,
                0xBD,
                0x3B,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CVidCapClassManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0xB3,
                0x0B,
                0x86,
                0x01,
                0x5D,
                0xD0,
                0x11,
                0xBD,
                0x3B,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_LegacyAmFilterCategory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x63,
                0x38,
                0x08,
                0xDE,
                0x70,
                0xD0,
                0x11,
                0xBD,
                0x40,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CQzFilterClassManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x63,
                0x38,
                0x08,
                0xDE,
                0x70,
                0xD0,
                0x11,
                0xBD,
                0x40,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_VideoCompressorCategory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0xA7,
                0xD9,
                0x33,
                0xC8,
                0x90,
                0xD0,
                0x11,
                0xBD,
                0x43,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CIcmCoClassManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0xA7,
                0xD9,
                0x33,
                0xC8,
                0x90,
                0xD0,
                0x11,
                0xBD,
                0x43,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AudioCompressorCategory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0xA7,
                0xD9,
                0x33,
                0xC8,
                0x90,
                0xD0,
                0x11,
                0xBD,
                0x43,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CAcmCoClassManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0xA7,
                0xD9,
                0x33,
                0xC8,
                0x90,
                0xD0,
                0x11,
                0xBD,
                0x43,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AudioInputDeviceCategory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0xA7,
                0xD9,
                0x33,
                0xC8,
                0x90,
                0xD0,
                0x11,
                0xBD,
                0x43,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CWaveinClassManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0xA7,
                0xD9,
                0x33,
                0xC8,
                0x90,
                0xD0,
                0x11,
                0xBD,
                0x43,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AudioRendererCategory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0x58,
                0xF1,
                0xE0,
                0x04,
                0xCB,
                0xD0,
                0x11,
                0xBD,
                0x4E,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CWaveOutClassManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0x58,
                0xF1,
                0xE0,
                0x04,
                0xCB,
                0xD0,
                0x11,
                0xBD,
                0x4E,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MidiRendererCategory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0x24,
                0xFE,
                0x4E,
                0x8A,
                0x16,
                0xD1,
                0x11,
                0xBC,
                0x76,
                0x00,
                0xC0,
                0x4F,
                0xB9,
                0x45,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CMidiOutClassManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0x24,
                0xFE,
                0x4E,
                0x8A,
                0x16,
                0xD1,
                0x11,
                0xBC,
                0x76,
                0x00,
                0xC0,
                0x4F,
                0xB9,
                0x45,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_TransmitCategory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0xFB,
                0x7B,
                0xCC,
                0x75,
                0xF1,
                0xD1,
                0x11,
                0xA3,
                0x92,
                0x00,
                0xE0,
                0x29,
                0x1F,
                0x39,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DeviceControlCategory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0xFB,
                0x7B,
                0xCC,
                0x75,
                0xF1,
                0xD1,
                0x11,
                0xA3,
                0x92,
                0x00,
                0xE0,
                0x29,
                0x1F,
                0x39,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ActiveMovieCategories
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0x3D,
                0x4E,
                0xDA,
                0x7D,
                0xD0,
                0xD0,
                0x11,
                0xBD,
                0x50,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DVDHWDecodersCategory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0xAE,
                0x21,
                0x27,
                0x70,
                0x7E,
                0xD0,
                0x11,
                0xA5,
                0xD6,
                0x28,
                0xDB,
                0x04,
                0xC1,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MediaEncoderCategory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0xE9,
                0x22,
                0x7D,
                0xA9,
                0x5C,
                0x87,
                0x47,
                0x8C,
                0x2B,
                0xA6,
                0x77,
                0x9B,
                0xD1,
                0x17,
                0x81,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MediaMultiplexerCategory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x95,
                0x6C,
                0x23,
                0xCE,
                0xAD,
                0x36,
                0x47,
                0xBF,
                0x72,
                0xBA,
                0xB3,
                0x4E,
                0x39,
                0x21,
                0x96,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_FilterMapper2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x22,
                0xA4,
                0xCD,
                0x88,
                0xBD,
                0xD0,
                0x11,
                0xBD,
                0x4E,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MemoryAllocator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x1C,
                0x65,
                0x1E,
                0x99,
                0xB1,
                0xD0,
                0x11,
                0x82,
                0x12,
                0x00,
                0xC0,
                0x4F,
                0xC3,
                0x2C,
                0x45,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MediaPropertyBag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x8D,
                0xBD,
                0xCD,
                0x93,
                0xC1,
                0xD0,
                0x11,
                0xBD,
                0x4E,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xCE,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DvdGraphBuilder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x52,
                0xC1,
                0xFC,
                0x72,
                0xF3,
                0xD0,
                0x11,
                0x8E,
                0x00,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0xC0,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DVDNavigator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x46,
                0x8C,
                0x9B,
                0x1A,
                0x2C,
                0xD0,
                0x11,
                0x84,
                0x93,
                0x00,
                0xA0,
                0x24,
                0x38,
                0xAD,
                0x48,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DVDState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCF,
                0xC5,
                0x63,
                0xF9,
                0x59,
                0xA6,
                0x93,
                0x4A,
                0x96,
                0x38,
                0xCA,
                0xF3,
                0xCD,
                0x27,
                0x7D,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_SmartTee
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0xE2,
                0x58,
                0xCC,
                0xA1,
                0x8A,
                0xD1,
                0x11,
                0xB3,
                0xF1,
                0x00,
                0xAA,
                0x00,
                0x37,
                0x61,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DtvCcFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0x6B,
                0x05,
                0xFB,
                0x02,
                0x25,
                0xB9,
                0x45,
                0x8E,
                0x86,
                0x2B,
                0x40,
                0xDE,
                0x84,
                0xAD,
                0x29,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CaptionsFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0xE4,
                0x7E,
                0x2F,
                0xF5,
                0x6F,
                0xB4,
                0x4E,
                0xB2,
                0x4A,
                0x2B,
                0xFC,
                0x41,
                0x11,
                0x71,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_SubtitlesFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0xCF,
                0x22,
                0x9F,
                0x07,
                0xCE,
                0xAB,
                0x41,
                0x8B,
                0xA0,
                0xC7,
                0x36,
                0x4A,
                0xF9,
                0x0A,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DirectShowPluginControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x36,
                0xC7,
                0x70,
                0x86,
                0x14,
                0xF6,
                0x7B,
                0x42,
                0x8A,
                0xDA,
                0xBB,
                0xAD,
                0xC5,
                0x87,
                0x19,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DirectDrawProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x4C,
                0x4D,
                0x94,
                0x52,
                0xDD,
                0xCE,
                0x11,
                0xBF,
                0x0E,
                0x00,
                0xAA,
                0x00,
                0x55,
                0x59,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_PerformanceProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x68,
                0xCE,
                0x59,
                0xF8,
                0xAC,
                0xCF,
                0x11,
                0xB5,
                0x6E,
                0x00,
                0x80,
                0xC7,
                0xC4,
                0xB6,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_QualityProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0xFB,
                0x8A,
                0x41,
                0xB8,
                0xF8,
                0xCE,
                0x11,
                0xAA,
                0xC6,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0x99,
                0xA3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_VPObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x28,
                0x29,
                0xCE,
                0x88,
                0xFC,
                0xD0,
                0x11,
                0x9E,
                0x69,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0xC1,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_VPVBIObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0x98,
                0x4B,
                0x81,
                0x88,
                0x1C,
                0xD1,
                0x11,
                0xBA,
                0xD9,
                0x00,
                0x60,
                0x97,
                0x44,
                0x11,
                0x1A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ModexProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xAA,
                0x18,
                0x06,
                0xC4,
                0x6B,
                0xCF,
                0x11,
                0xBF,
                0x36,
                0x00,
                0xAA,
                0x00,
                0x55,
                0x59,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DVDecPropertiesPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x93,
                0x11,
                0x10,
                0xFE,
                0x0B,
                0xD0,
                0x11,
                0xAF,
                0x91,
                0x00,
                0xAA,
                0x00,
                0xB6,
                0x7A,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DVEncPropertiesPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0xF0,
                0x50,
                0x41,
                0x6F,
                0xBB,
                0xD0,
                0x11,
                0xAF,
                0xB9,
                0x00,
                0xAA,
                0x00,
                0xB6,
                0x7A,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DVMuxPropertyPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x80,
                0xB8,
                0x4D,
                0x0D,
                0xC1,
                0xD0,
                0x11,
                0xAF,
                0xB9,
                0x00,
                0xAA,
                0x00,
                0xB6,
                0x7A,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WstDecoderPropertyPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x7F,
                0xE2,
                0x04,
                0xE4,
                0x91,
                0xD3,
                0x11,
                0xA1,
                0x84,
                0x00,
                0x10,
                0x5A,
                0xEF,
                0x9F,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_TVTunerFilterPropertyPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0xEE,
                0x6E,
                0x26,
                0x63,
                0x6C,
                0xCF,
                0x11,
                0x8A,
                0x03,
                0x00,
                0xAA,
                0x00,
                0x6E,
                0xCB,
                0x65,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CrossbarFilterPropertyPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x64,
                0xF9,
                0x71,
                0xF3,
                0x78,
                0xD0,
                0x11,
                0xA1,
                0x8C,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0x89,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_TVAudioFilterPropertyPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x63,
                0x64,
                0xF9,
                0x71,
                0xF3,
                0x78,
                0xD0,
                0x11,
                0xA1,
                0x8C,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0x89,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_VideoProcAmpPropertyPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x64,
                0xF9,
                0x71,
                0xF3,
                0x78,
                0xD0,
                0x11,
                0xA1,
                0x8C,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0x89,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CameraControlPropertyPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0x64,
                0xF9,
                0x71,
                0xF3,
                0x78,
                0xD0,
                0x11,
                0xA1,
                0x8C,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0x89,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AnalogVideoDecoderPropertyPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x64,
                0xF9,
                0x71,
                0xF3,
                0x78,
                0xD0,
                0x11,
                0xA1,
                0x8C,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0x89,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_VideoStreamConfigPropertyPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x64,
                0xF9,
                0x71,
                0xF3,
                0x78,
                0xD0,
                0x11,
                0xA1,
                0x8C,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0x89,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AudioRendererAdvancedProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x2A,
                0xE9,
                0x37,
                0xAA,
                0xD9,
                0xD2,
                0x11,
                0xBF,
                0x84,
                0x8E,
                0xF2,
                0xB1,
                0x55,
                0x5A,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_VideoMixingRenderer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0xEB,
                0x7B,
                0xB8,
                0x29,
                0x8D,
                0x3F,
                0x42,
                0xAE,
                0x4D,
                0x65,
                0x82,
                0xC1,
                0x01,
                0x75,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_VideoRendererDefault
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0xCF,
                0xC1,
                0x6B,
                0xC1,
                0x8F,
                0x61,
                0x42,
                0xAC,
                0x22,
                0xCF,
                0xB4,
                0xCC,
                0x38,
                0xDB,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AllocPresenter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x63,
                0x4F,
                0xD5,
                0x99,
                0x69,
                0x1A,
                0xAE,
                0x41,
                0xAA,
                0x4D,
                0xC9,
                0x76,
                0xEB,
                0x3F,
                0x07,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AllocPresenterDDXclMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0xAC,
                0x44,
                0x44,
                0x2E,
                0x24,
                0x1B,
                0x47,
                0xA3,
                0xC7,
                0x45,
                0xDC,
                0xD4,
                0x63,
                0x52,
                0xBC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_VideoPortManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0xA6,
                0x26,
                0x6F,
                0x7B,
                0x96,
                0xFD,
                0x47,
                0x87,
                0x4A,
                0x7A,
                0xED,
                0x2C,
                0x9D,
                0x25,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_VideoMixingRenderer9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0xAB,
                0xB4,
                0x51,
                0x8F,
                0x74,
                0x3B,
                0x4E,
                0xA2,
                0x76,
                0xC8,
                0x28,
                0x33,
                0x0E,
                0x92,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_EnhancedVideoRenderer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0x74,
                0x10,
                0xFA,
                0x63,
                0x9B,
                0x6C,
                0x4B,
                0xBC,
                0x49,
                0xFC,
                0x30,
                0x0E,
                0xA5,
                0xF2,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MFVideoMixer9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0xE0,
                0x74,
                0xE4,
                0x65,
                0xAB,
                0x6A,
                0x4F,
                0x82,
                0x7C,
                0x21,
                0x8B,
                0x1B,
                0xAA,
                0xF3,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MFVideoPresenter9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x55,
                0x45,
                0x98,
                0x36,
                0x51,
                0x28,
                0x4D,
                0xAB,
                0x08,
                0x4C,
                0xEE,
                0x40,
                0xEA,
                0x27,
                0x81,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_EVRTearlessWindowPresenter9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0xA5,
                0xA7,
                0xA0,
                0xB2,
                0x59,
                0x19,
                0x49,
                0xA6,
                0x94,
                0xAD,
                0xD0,
                0xA5,
                0x26,
                0xC3,
                0x73,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_EVRPlaybackPipelineOptimizer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x91,
                0x07,
                0x62,
                0x3B,
                0x23,
                0xF8,
                0x41,
                0xA8,
                0x0F,
                0xF0,
                0x17,
                0x05,
                0xF5,
                0x14,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_NetworkProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0xA6,
                0xF3,
                0xB2,
                0xDA,
                0x29,
                0x78,
                0x4C,
                0x88,
                0x31,
                0x09,
                0x1E,
                0xD5,
                0x09,
                0xA4,
                0x75,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ATSCNetworkProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0x2F,
                0xAD,
                0x0D,
                0xD7,
                0x5F,
                0xD3,
                0x11,
                0x8F,
                0x50,
                0x00,
                0xC0,
                0x4F,
                0x79,
                0x71,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ATSCNetworkPropertyPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x4D,
                0x44,
                0xE3,
                0xC4,
                0x5A,
                0x86,
                0x43,
                0x88,
                0xDF,
                0x13,
                0xFD,
                0x23,
                0x0E,
                0x1D,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DVBSNetworkProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0x37,
                0x4B,
                0xFA,
                0xB4,
                0x45,
                0x45,
                0x4D,
                0x84,
                0x40,
                0x26,
                0x39,
                0x57,
                0xB1,
                0x16,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DVBTNetworkProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0x62,
                0x6C,
                0x21,
                0x7F,
                0x6D,
                0x9A,
                0x4E,
                0x85,
                0x71,
                0x05,
                0xF1,
                0x4E,
                0xDB,
                0x76,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DVBCNetworkProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0x0F,
                0x0C,
                0xDC,
                0x85,
                0x04,
                0x66,
                0x42,
                0xB9,
                0x3F,
                0x68,
                0xFB,
                0xF8,
                0x0E,
                0xD8,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DShowTVEFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x02,
                0x50,
                0x05,
                0xA5,
                0xFA,
                0xF9,
                0x4D,
                0x82,
                0x46,
                0xBF,
                0xC2,
                0x3A,
                0xC5,
                0xCE,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_TVEFilterTuneProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x02,
                0x50,
                0x05,
                0xA5,
                0xFA,
                0xF9,
                0x4D,
                0x82,
                0x46,
                0xBF,
                0xC2,
                0x3A,
                0xC5,
                0xCE,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_TVEFilterCCProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0x02,
                0x50,
                0x05,
                0xA5,
                0xFA,
                0xF9,
                0x4D,
                0x82,
                0x46,
                0xBF,
                0xC2,
                0x3A,
                0xC5,
                0xCE,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_TVEFilterStatsProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0x02,
                0x50,
                0x05,
                0xA5,
                0xFA,
                0xF9,
                0x4D,
                0x82,
                0x46,
                0xBF,
                0xC2,
                0x3A,
                0xC5,
                0xCE,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_IVideoEncoderProxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0x4E,
                0x3C,
                0xB4,
                0x32,
                0x8C,
                0x91,
                0x47,
                0x91,
                0x02,
                0x50,
                0x8A,
                0xDA,
                0x5E,
                0xE8,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ICodecAPIProxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0x99,
                0xF0,
                0x7F,
                0x99,
                0x19,
                0x86,
                0x42,
                0xA7,
                0x3C,
                0x62,
                0x2B,
                0x88,
                0x14,
                0xE7,
                0xEB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_IVideoEncoderCodecAPIProxy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD9,
                0xAB,
                0x5D,
                0xB0,
                0xE5,
                0x56,
                0xDC,
                0x4F,
                0xAF,
                0xA4,
                0x8A,
                0x47,
                0xE9,
                0x1F,
                0x1C,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_SBE2MediaTypeProfile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xA6,
                0x26,
                0x1F,
                0x5C,
                0x2B,
                0x63,
                0x4B,
                0xB8,
                0xE8,
                0x9E,
                0xA5,
                0xC1,
                0xA7,
                0xDC,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_SBE2FileScan
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x80,
                0x45,
                0x3E,
                0xA6,
                0x0C,
                0xAA,
                0x41,
                0xA5,
                0x94,
                0x2A,
                0xA6,
                0xC0,
                0x2D,
                0x70,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
