// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class EP
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid EP_NavPane
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0x6B,
                0x31,
                0xCB,
                0xF7,
                0x25,
                0xB8,
                0x42,
                0x8A,
                0x09,
                0x54,
                0x0D,
                0x23,
                0xA4,
                0x3C,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EP_Commands
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0x58,
                0x74,
                0xD9,
                0x5F,
                0xCA,
                0x76,
                0x4A,
                0x91,
                0xCD,
                0xF5,
                0xA1,
                0x29,
                0xFB,
                0xB0,
                0x76,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EP_Commands_Organize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x17,
                0xE8,
                0x72,
                0xEC,
                0xE3,
                0x60,
                0x46,
                0xBF,
                0x24,
                0x3C,
                0x3B,
                0x7B,
                0x64,
                0x88,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EP_Commands_View
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2D,
                0xC3,
                0xF7,
                0x21,
                0xAA,
                0xEE,
                0x9B,
                0x43,
                0xBB,
                0x51,
                0x37,
                0xB9,
                0x6F,
                0xD6,
                0xA9,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EP_DetailsPane
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0xF9,
                0xAB,
                0x43,
                0xB8,
                0x89,
                0x2D,
                0x47,
                0xB9,
                0xCE,
                0xE6,
                0x9B,
                0x82,
                0x29,
                0xF0,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EP_PreviewPane
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x63,
                0x3C,
                0x89,
                0xC8,
                0x45,
                0x17,
                0x4D,
                0xBE,
                0x19,
                0x22,
                0x3B,
                0xE7,
                0x1B,
                0xE3,
                0x65,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EP_QueryPane
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4F,
                0xDE,
                0xBC,
                0x65,
                0x07,
                0x4F,
                0x27,
                0x4F,
                0x83,
                0xA7,
                0x1A,
                0xFC,
                0xA4,
                0xDF,
                0x7D,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EP_AdvQueryPane
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0xDB,
                0xE9,
                0xB4,
                0xBA,
                0x34,
                0x39,
                0x4C,
                0xB5,
                0xCC,
                0x16,
                0xA1,
                0xBD,
                0x2C,
                0x41,
                0x1C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EP_StatusBar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0x56,
                0xFE,
                0x65,
                0xFE,
                0x5C,
                0xC4,
                0x4B,
                0xAD,
                0x8A,
                0x7A,
                0xE3,
                0xFE,
                0x7E,
                0x8F,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EP_Ribbon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x24,
                0x75,
                0xD2,
                0xF2,
                0xC9,
                0x34,
                0x48,
                0xA1,
                0x06,
                0xDF,
                0x88,
                0x89,
                0xFD,
                0x4F,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
