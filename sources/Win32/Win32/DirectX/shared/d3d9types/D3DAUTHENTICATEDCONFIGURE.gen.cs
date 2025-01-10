// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DAUTHENTICATEDCONFIGURE
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDCONFIGURE_INITIALIZE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0x4B,
                0x11,
                0x06,
                0x23,
                0x35,
                0x0A,
                0x47,
                0x8D,
                0xCA,
                0xFB,
                0xC2,
                0x84,
                0x51,
                0x54,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDCONFIGURE_PROTECTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0x56,
                0x45,
                0x50,
                0x47,
                0x3F,
                0x62,
                0x43,
                0xBF,
                0x99,
                0xBF,
                0xDF,
                0xCD,
                0xE9,
                0xED,
                0x29,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDCONFIGURE_CRYPTOSESSION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0xCC,
                0x46,
                0x63,
                0xFC,
                0x2C,
                0xD4,
                0x4A,
                0x82,
                0x24,
                0xD1,
                0x58,
                0x37,
                0xDE,
                0x77,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDCONFIGURE_SHAREDRESOURCE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0xD0,
                0x72,
                0x07,
                0x40,
                0x1B,
                0xE8,
                0x48,
                0x9C,
                0xA6,
                0xB5,
                0xF5,
                0x10,
                0xDE,
                0x9F,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDCONFIGURE_ENCRYPTIONWHENACCESSIBLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0xF2,
                0xFF,
                0x41,
                0xE0,
                0x6A,
                0x43,
                0x4D,
                0x9D,
                0x55,
                0xA4,
                0x6E,
                0x9E,
                0xFD,
                0x15,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
