// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MEDIASUBTYPE
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_None
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8E,
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
    public static ref readonly Guid MEDIASUBTYPE_DVB_SUBTITLES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0xCB,
                0xFF,
                0x34,
                0xB3,
                0xD5,
                0x71,
                0x41,
                0x90,
                0x02,
                0xD4,
                0xC6,
                0x03,
                0x01,
                0x69,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_ISDB_CAPTIONS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0xD6,
                0x9D,
                0x05,
                0x55,
                0x2E,
                0x41,
                0x4D,
                0x8D,
                0x1B,
                0x01,
                0xF5,
                0xE4,
                0xF5,
                0x06,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_ISDB_SUPERIMPOSE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0x6D,
                0xDC,
                0x36,
                0xA6,
                0xF1,
                0x16,
                0x42,
                0x90,
                0x48,
                0x9C,
                0xFC,
                0xEF,
                0xEB,
                0x5E,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_CLPL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x4C,
                0x50,
                0x4C,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_YUYV
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x55,
                0x59,
                0x56,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_IYUV
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x59,
                0x55,
                0x56,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_YVU9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x56,
                0x55,
                0x39,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_Y411
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x34,
                0x31,
                0x31,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_Y41P
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x34,
                0x31,
                0x50,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_YUY2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x55,
                0x59,
                0x32,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_YVYU
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x56,
                0x59,
                0x55,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_UYVY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x59,
                0x56,
                0x59,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_Y211
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x32,
                0x31,
                0x31,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_CLJR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x4C,
                0x4A,
                0x52,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_IF09
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x46,
                0x30,
                0x39,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_CPLA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x50,
                0x4C,
                0x41,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_MJPG
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0x4A,
                0x50,
                0x47,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_TVMJ
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0x56,
                0x4D,
                0x4A,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_WAKE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0x41,
                0x4B,
                0x45,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_CFCC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x46,
                0x43,
                0x43,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_IJPG
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x4A,
                0x50,
                0x47,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_Plum
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x6C,
                0x75,
                0x6D,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_DVCS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0x56,
                0x43,
                0x53,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_H264
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x32,
                0x36,
                0x34,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_DVSD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0x56,
                0x53,
                0x44,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_MDVF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0x44,
                0x56,
                0x46,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_RGB1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
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
    public static ref readonly Guid MEDIASUBTYPE_RGB4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
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
    public static ref readonly Guid MEDIASUBTYPE_RGB8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
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
    public static ref readonly Guid MEDIASUBTYPE_RGB565
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
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
    public static ref readonly Guid MEDIASUBTYPE_RGB555
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
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
    public static ref readonly Guid MEDIASUBTYPE_RGB24
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
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
    public static ref readonly Guid MEDIASUBTYPE_RGB32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
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
    public static ref readonly Guid MEDIASUBTYPE_ARGB1555
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0x55,
                0x7C,
                0x29,
                0x09,
                0xE2,
                0xB3,
                0x4C,
                0xB7,
                0x57,
                0xC7,
                0x6D,
                0x6B,
                0x9C,
                0x88,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_ARGB4444
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0x15,
                0x64,
                0x6E,
                0x24,
                0x5C,
                0x5F,
                0x42,
                0x93,
                0xCD,
                0x80,
                0x10,
                0x2B,
                0x3D,
                0x1C,
                0xCA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_ARGB32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x9A,
                0x3C,
                0x77,
                0x74,
                0x32,
                0xD0,
                0x11,
                0xB7,
                0x24,
                0x00,
                0xAA,
                0x00,
                0x6C,
                0x1A,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_A2R10G10B10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0xB7,
                0x8B,
                0x2F,
                0x44,
                0xB6,
                0x50,
                0x45,
                0xAC,
                0xF3,
                0xD3,
                0x0C,
                0xAA,
                0x65,
                0xD5,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_A2B10G10R10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0x78,
                0x6F,
                0x57,
                0xF6,
                0xBD,
                0xC4,
                0x48,
                0x87,
                0x5F,
                0xAE,
                0x7B,
                0x81,
                0x83,
                0x45,
                0x67,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_AYUV
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0x59,
                0x55,
                0x56,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_AI44
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0x49,
                0x34,
                0x34,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_IA44
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x41,
                0x34,
                0x34,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_RGB32_D3D_DX7_RT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x52,
                0x33,
                0x32,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_RGB16_D3D_DX7_RT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x52,
                0x31,
                0x36,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_ARGB32_D3D_DX7_RT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x41,
                0x38,
                0x38,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_ARGB4444_D3D_DX7_RT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x41,
                0x34,
                0x34,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_ARGB1555_D3D_DX7_RT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x41,
                0x31,
                0x35,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_RGB32_D3D_DX9_RT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x52,
                0x33,
                0x32,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_RGB16_D3D_DX9_RT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x52,
                0x31,
                0x36,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_ARGB32_D3D_DX9_RT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x41,
                0x38,
                0x38,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_ARGB4444_D3D_DX9_RT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x41,
                0x34,
                0x34,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_ARGB1555_D3D_DX9_RT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x41,
                0x31,
                0x35,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_YV12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x56,
                0x31,
                0x32,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_NV12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x56,
                0x31,
                0x32,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_NV11
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x56,
                0x31,
                0x31,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_P208
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x32,
                0x30,
                0x38,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_P210
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x32,
                0x31,
                0x30,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_P216
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x32,
                0x31,
                0x36,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_P010
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x30,
                0x31,
                0x30,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_P016
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x30,
                0x31,
                0x36,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_Y210
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x32,
                0x31,
                0x30,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_Y216
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x32,
                0x31,
                0x36,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_P408
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x34,
                0x30,
                0x38,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_NV24
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x56,
                0x32,
                0x34,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_420O
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0x32,
                0x30,
                0x4F,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_IMC1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x4D,
                0x43,
                0x31,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_IMC2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x4D,
                0x43,
                0x32,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_IMC3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x4D,
                0x43,
                0x33,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_IMC4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x4D,
                0x43,
                0x34,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_S340
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x33,
                0x34,
                0x30,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_S342
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x33,
                0x34,
                0x32,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_Overlay
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
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
    public static ref readonly Guid MEDIASUBTYPE_MPEG1Packet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
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
    public static ref readonly Guid MEDIASUBTYPE_MPEG1Payload
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
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
    public static ref readonly Guid MEDIASUBTYPE_MPEG1AudioPayload
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_MPEG1System
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
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
    public static ref readonly Guid MEDIASUBTYPE_MPEG1VideoCD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
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
    public static ref readonly Guid MEDIASUBTYPE_MPEG1Video
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
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
    public static ref readonly Guid MEDIASUBTYPE_MPEG1Audio
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
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
    public static ref readonly Guid MEDIASUBTYPE_Avi
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
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
    public static ref readonly Guid MEDIASUBTYPE_Asf
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x0F,
                0xB8,
                0x3D,
                0x12,
                0x94,
                0xD1,
                0x11,
                0xAD,
                0xED,
                0x00,
                0x00,
                0xF8,
                0x75,
                0x4B,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_QTMovie
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
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
    public static ref readonly Guid MEDIASUBTYPE_QTRpza
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0x70,
                0x7A,
                0x61,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_QTSmc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0x6D,
                0x63,
                0x20,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_QTRle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0x6C,
                0x65,
                0x20,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_QTJpeg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0x70,
                0x65,
                0x67,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_PCMAudio_Obsolete
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
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
    public static ref readonly Guid MEDIASUBTYPE_PCM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_WAVE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
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
    public static ref readonly Guid MEDIASUBTYPE_AU
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
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
    public static ref readonly Guid MEDIASUBTYPE_AIFF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
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
    public static ref readonly Guid MEDIASUBTYPE_dvsd
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x76,
                0x73,
                0x64,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_dvhd
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x76,
                0x68,
                0x64,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_dvsl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x76,
                0x73,
                0x6C,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_dv25
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x76,
                0x32,
                0x35,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_dv50
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x76,
                0x35,
                0x30,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_dvh1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x76,
                0x68,
                0x31,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_Line21_BytePair
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
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
    public static ref readonly Guid MEDIASUBTYPE_Line21_GOPPacket
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
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
    public static ref readonly Guid MEDIASUBTYPE_Line21_VBIRawData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
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
    public static ref readonly Guid MEDIASUBTYPE_708_608Data
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0x14,
                0xF4,
                0x0A,
                0xD2,
                0x4E,
                0x5E,
                0x44,
                0x98,
                0x39,
                0x8F,
                0x09,
                0x55,
                0x68,
                0xAB,
                0x3C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_DtvCcData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0xDD,
                0x2A,
                0xF5,
                0xF0,
                0x36,
                0xF5,
                0x43,
                0x95,
                0xEA,
                0x6D,
                0x86,
                0x64,
                0x84,
                0x26,
                0x2A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_CC_CONTAINER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0x26,
                0xA6,
                0x7E,
                0xDA,
                0x54,
                0x7B,
                0x43,
                0xBE,
                0x9F,
                0xF7,
                0x30,
                0x73,
                0xAD,
                0xFA,
                0x3C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_TELETEXT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE3,
                0x76,
                0x2A,
                0xF7,
                0x0A,
                0xEB,
                0xD0,
                0x11,
                0xAC,
                0xE4,
                0x00,
                0x00,
                0xC0,
                0xCC,
                0x16,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_VBI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xA4,
                0x3D,
                0x66,
                0xE8,
                0x03,
                0x9A,
                0x4E,
                0x9C,
                0xD5,
                0xBF,
                0x11,
                0xED,
                0x0D,
                0xEF,
                0x76,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_WSS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0xD5,
                0x91,
                0x27,
                0x7A,
                0x8E,
                0x6F,
                0x46,
                0x9E,
                0x90,
                0x5D,
                0x3F,
                0x30,
                0x83,
                0x73,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_XDS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE3,
                0x73,
                0xCA,
                0x01,
                0xE6,
                0xDC,
                0x75,
                0x45,
                0xAF,
                0xE1,
                0x2B,
                0xF1,
                0xC9,
                0x02,
                0xCA,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_VPS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0xF6,
                0xB3,
                0xA1,
                0x92,
                0x97,
                0x8D,
                0x4D,
                0x81,
                0xA4,
                0x86,
                0xAF,
                0x25,
                0x77,
                0x20,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_DRM_Audio
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_IEEE_FLOAT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_DOLBY_AC3_SPDIF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_RAW_SPORT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x02,
                0x00,
                0x00,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_SPDIF_TAG_241h
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0x02,
                0x00,
                0x00,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MEDIASUBTYPE_DssVideo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x4F,
                0xAF,
                0xA0,
                0x63,
                0xE1,
                0xD0,
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
    public static ref readonly Guid MEDIASUBTYPE_DssAudio
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0x4F,
                0xAF,
                0xA0,
                0x63,
                0xE1,
                0xD0,
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
    public static ref readonly Guid MEDIASUBTYPE_VPVideo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x6A,
                0x9B,
                0x5A,
                0x22,
                0x1A,
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
    public static ref readonly Guid MEDIASUBTYPE_VPVBI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0x6A,
                0x9B,
                0x5A,
                0x22,
                0x1A,
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
    public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_NTSC_M
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0xDD,
                0x82,
                0x04,
                0x17,
                0x78,
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
    public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_B
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0xDD,
                0x82,
                0x04,
                0x17,
                0x78,
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
    public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0xDD,
                0x82,
                0x04,
                0x17,
                0x78,
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
    public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_G
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0xDD,
                0x82,
                0x04,
                0x17,
                0x78,
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
    public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_H
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0xDD,
                0x82,
                0x04,
                0x17,
                0x78,
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
    public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_I
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE9,
                0xDD,
                0x82,
                0x04,
                0x17,
                0x78,
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
    public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_M
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0xDD,
                0x82,
                0x04,
                0x17,
                0x78,
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
    public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_N
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0xDD,
                0x82,
                0x04,
                0x17,
                0x78,
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
    public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_N_COMBO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0xDD,
                0x82,
                0x04,
                0x17,
                0x78,
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
    public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_B
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0xDD,
                0x82,
                0x04,
                0x17,
                0x78,
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
    public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0xDD,
                0x82,
                0x04,
                0x17,
                0x78,
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
    public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_G
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0xDD,
                0x82,
                0x04,
                0x17,
                0x78,
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
    public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_H
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0xDD,
                0x82,
                0x04,
                0x17,
                0x78,
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
    public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_K
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0xDD,
                0x82,
                0x04,
                0x17,
                0x78,
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
    public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_K1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF5,
                0xDD,
                0x82,
                0x04,
                0x17,
                0x78,
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
    public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_L
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0xDD,
                0x82,
                0x04,
                0x17,
                0x78,
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
}
