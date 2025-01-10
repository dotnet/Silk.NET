// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DAUTHENTICATEDQUERY
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDQUERY_PROTECTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
                0xB5,
                0x4E,
                0xA8,
                0x95,
                0xC4,
                0xAA,
                0x48,
                0xB9,
                0x4D,
                0x8B,
                0xD2,
                0xD6,
                0xFB,
                0xCE,
                0x05,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDQUERY_CHANNELTYPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA5,
                0x18,
                0x1B,
                0xBC,
                0xFB,
                0xB1,
                0xAB,
                0x42,
                0xBD,
                0x94,
                0xB5,
                0x82,
                0x8B,
                0x4B,
                0xF7,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDQUERY_DEVICEHANDLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x53,
                0x1C,
                0xEC,
                0xFF,
                0x8C,
                0x2A,
                0x4E,
                0xBC,
                0xC4,
                0xF5,
                0x69,
                0x2F,
                0x99,
                0xF4,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDQUERY_CRYPTOSESSION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0x49,
                0x34,
                0x26,
                0x18,
                0xD0,
                0x74,
                0x4D,
                0xAC,
                0x17,
                0x7F,
                0x72,
                0x40,
                0x59,
                0x52,
                0x8D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDQUERY_RESTRICTEDSHAREDRESOURCEPROCESSCOUNT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x07,
                0xB2,
                0x0D,
                0x50,
                0x94,
                0xA6,
                0x46,
                0x82,
                0xDE,
                0x1B,
                0x96,
                0xD4,
                0x4F,
                0x9C,
                0xF2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDQUERY_RESTRICTEDSHAREDRESOURCEPROCESS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0xBA,
                0x9B,
                0x64,
                0xF4,
                0xF0,
                0x39,
                0x46,
                0xA1,
                0x5B,
                0x24,
                0x39,
                0x3F,
                0xC3,
                0xAB,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDQUERY_UNRESTRICTEDPROTECTEDSHAREDRESOURCECOUNT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0x0B,
                0x2F,
                0x01,
                0x62,
                0xE6,
                0x74,
                0x44,
                0xBE,
                0xFD,
                0xAA,
                0x53,
                0xE5,
                0x14,
                0x3C,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDQUERY_OUTPUTIDCOUNT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x2B,
                0x04,
                0x2C,
                0x07,
                0x8C,
                0xD5,
                0x46,
                0xAA,
                0xBE,
                0x8F,
                0x75,
                0xCB,
                0xAD,
                0x4C,
                0x31,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDQUERY_OUTPUTID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0xDC,
                0x9D,
                0x83,
                0x4E,
                0x9B,
                0xE4,
                0x41,
                0xB0,
                0x53,
                0x89,
                0x2B,
                0xD2,
                0xA1,
                0x1E,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDQUERY_ACCESSIBILITYATTRIBUTES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0xD9,
                0x14,
                0x62,
                0x2C,
                0x43,
                0xBB,
                0x4A,
                0x9F,
                0xCE,
                0x21,
                0x6E,
                0xEA,
                0x26,
                0x9E,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDQUERY_ENCRYPTIONWHENACCESSIBLEGUIDCOUNT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x70,
                0x0F,
                0xB3,
                0x3C,
                0x20,
                0x07,
                0x4B,
                0x93,
                0xFC,
                0xCE,
                0xAA,
                0xFD,
                0x61,
                0x24,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDQUERY_ENCRYPTIONWHENACCESSIBLEGUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0x59,
                0x3A,
                0xF8,
                0x86,
                0xE9,
                0xDA,
                0x4B,
                0xBE,
                0xB0,
                0x41,
                0x1F,
                0x6A,
                0x7A,
                0x01,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DAUTHENTICATEDQUERY_CURRENTENCRYPTIONWHENACCESSIBLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0x91,
                0x17,
                0xEC,
                0xD3,
                0xDA,
                0x15,
                0x4F,
                0x9E,
                0xC3,
                0xFA,
                0xA9,
                0x3D,
                0x60,
                0xD4,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
