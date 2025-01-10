// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectDraw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0xDB,
                0x14,
                0x6C,
                0x33,
                0xA7,
                0xCE,
                0x11,
                0xA5,
                0x21,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0xE5,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectDraw2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0xF3,
                0xA6,
                0xB3,
                0x43,
                0x2B,
                0xCF,
                0x11,
                0xA2,
                0xDE,
                0x00,
                0xAA,
                0x00,
                0xB9,
                0x33,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectDraw4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0x50,
                0x59,
                0x9C,
                0xBD,
                0x39,
                0xD1,
                0x11,
                0x8C,
                0x4A,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x30,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectDraw7
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x5E,
                0xE6,
                0x15,
                0x9C,
                0x3B,
                0xD2,
                0x11,
                0xB9,
                0x2F,
                0x00,
                0x60,
                0x97,
                0x97,
                0xEA,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectDrawSurface
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0xDB,
                0x14,
                0x6C,
                0x33,
                0xA7,
                0xCE,
                0x11,
                0xA5,
                0x21,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0xE5,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectDrawSurface2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x58,
                0x80,
                0x57,
                0xEC,
                0x6E,
                0xCF,
                0x11,
                0x94,
                0x41,
                0xA8,
                0x23,
                0x03,
                0xC1,
                0x0E,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectDrawSurface3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x4E,
                0x04,
                0xDA,
                0xB2,
                0x69,
                0xD0,
                0x11,
                0xA1,
                0xD5,
                0x00,
                0xAA,
                0x00,
                0xB8,
                0xDF,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectDrawSurface4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0x86,
                0x2B,
                0x0B,
                0x35,
                0xAD,
                0xD0,
                0x11,
                0x8E,
                0xA6,
                0x00,
                0x60,
                0x97,
                0x97,
                0xEA,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectDrawSurface7
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x5A,
                0x67,
                0x06,
                0x9B,
                0x3B,
                0xD2,
                0x11,
                0xB9,
                0x2F,
                0x00,
                0x60,
                0x97,
                0x97,
                0xEA,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectDrawPalette
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
                0xDB,
                0x14,
                0x6C,
                0x33,
                0xA7,
                0xCE,
                0x11,
                0xA5,
                0x21,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0xE5,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectDrawClipper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0xDB,
                0x14,
                0x6C,
                0x33,
                0xA7,
                0xCE,
                0x11,
                0xA5,
                0x21,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0xE5,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectDrawColorControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x0E,
                0x9F,
                0x4B,
                0x7E,
                0x0D,
                0xD0,
                0x11,
                0x9B,
                0x06,
                0x00,
                0xA0,
                0xC9,
                0x03,
                0xA3,
                0xB8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectDrawGammaControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x1C,
                0xC1,
                0x69,
                0x6B,
                0xB4,
                0xD1,
                0x11,
                0xAD,
                0x7A,
                0x00,
                0xC0,
                0x4F,
                0xC2,
                0x9B,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
