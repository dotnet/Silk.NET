// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class PIN
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid PIN_CATEGORY_CAPTURE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0x42,
                0x6C,
                0xFB,
                0x53,
                0x03,
                0xD1,
                0x11,
                0x90,
                0x5F,
                0x00,
                0x00,
                0xC0,
                0xCC,
                0x16,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PIN_CATEGORY_PREVIEW
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0x42,
                0x6C,
                0xFB,
                0x53,
                0x03,
                0xD1,
                0x11,
                0x90,
                0x5F,
                0x00,
                0x00,
                0xC0,
                0xCC,
                0x16,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PIN_CATEGORY_ANALOGVIDEOIN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0x42,
                0x6C,
                0xFB,
                0x53,
                0x03,
                0xD1,
                0x11,
                0x90,
                0x5F,
                0x00,
                0x00,
                0xC0,
                0xCC,
                0x16,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PIN_CATEGORY_VBI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0x42,
                0x6C,
                0xFB,
                0x53,
                0x03,
                0xD1,
                0x11,
                0x90,
                0x5F,
                0x00,
                0x00,
                0xC0,
                0xCC,
                0x16,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PIN_CATEGORY_VIDEOPORT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0x42,
                0x6C,
                0xFB,
                0x53,
                0x03,
                0xD1,
                0x11,
                0x90,
                0x5F,
                0x00,
                0x00,
                0xC0,
                0xCC,
                0x16,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PIN_CATEGORY_NABTS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x86,
                0x42,
                0x6C,
                0xFB,
                0x53,
                0x03,
                0xD1,
                0x11,
                0x90,
                0x5F,
                0x00,
                0x00,
                0xC0,
                0xCC,
                0x16,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PIN_CATEGORY_EDS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x87,
                0x42,
                0x6C,
                0xFB,
                0x53,
                0x03,
                0xD1,
                0x11,
                0x90,
                0x5F,
                0x00,
                0x00,
                0xC0,
                0xCC,
                0x16,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PIN_CATEGORY_TELETEXT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x88,
                0x42,
                0x6C,
                0xFB,
                0x53,
                0x03,
                0xD1,
                0x11,
                0x90,
                0x5F,
                0x00,
                0x00,
                0xC0,
                0xCC,
                0x16,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PIN_CATEGORY_CC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x89,
                0x42,
                0x6C,
                0xFB,
                0x53,
                0x03,
                0xD1,
                0x11,
                0x90,
                0x5F,
                0x00,
                0x00,
                0xC0,
                0xCC,
                0x16,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PIN_CATEGORY_STILL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0x42,
                0x6C,
                0xFB,
                0x53,
                0x03,
                0xD1,
                0x11,
                0x90,
                0x5F,
                0x00,
                0x00,
                0xC0,
                0xCC,
                0x16,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PIN_CATEGORY_TIMECODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8B,
                0x42,
                0x6C,
                0xFB,
                0x53,
                0x03,
                0xD1,
                0x11,
                0x90,
                0x5F,
                0x00,
                0x00,
                0xC0,
                0xCC,
                0x16,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PIN_CATEGORY_VIDEOPORT_VBI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8C,
                0x42,
                0x6C,
                0xFB,
                0x53,
                0x03,
                0xD1,
                0x11,
                0x90,
                0x5F,
                0x00,
                0x00,
                0xC0,
                0xCC,
                0x16,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}