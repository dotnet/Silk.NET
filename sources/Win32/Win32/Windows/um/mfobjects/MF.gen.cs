// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MF
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_BYTESTREAM_ORIGIN_NAME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0x82,
                0x35,
                0xFC,
                0xB6,
                0x3C,
                0x0C,
                0x46,
                0xA4,
                0x24,
                0xB6,
                0x68,
                0x12,
                0x60,
                0x37,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_BYTESTREAM_CONTENT_TYPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0x82,
                0x35,
                0xFC,
                0xB6,
                0x3C,
                0x0C,
                0x46,
                0xA4,
                0x24,
                0xB6,
                0x68,
                0x12,
                0x60,
                0x37,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_BYTESTREAM_DURATION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0x82,
                0x35,
                0xFC,
                0xB6,
                0x3C,
                0x0C,
                0x46,
                0xA4,
                0x24,
                0xB6,
                0x68,
                0x12,
                0x60,
                0x37,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_BYTESTREAM_LAST_MODIFIED_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x82,
                0x35,
                0xFC,
                0xB6,
                0x3C,
                0x0C,
                0x46,
                0xA4,
                0x24,
                0xB6,
                0x68,
                0x12,
                0x60,
                0x37,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_BYTESTREAM_IFO_FILE_URI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x82,
                0x35,
                0xFC,
                0xB6,
                0x3C,
                0x0C,
                0x46,
                0xA4,
                0x24,
                0xB6,
                0x68,
                0x12,
                0x60,
                0x37,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_BYTESTREAM_DLNA_PROFILE_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0x82,
                0x35,
                0xFC,
                0xB6,
                0x3C,
                0x0C,
                0x46,
                0xA4,
                0x24,
                0xB6,
                0x68,
                0x12,
                0x60,
                0x37,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_BYTESTREAM_EFFECTIVE_URL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0x02,
                0xFA,
                0x9A,
                0xD1,
                0x89,
                0xAF,
                0x42,
                0x84,
                0x56,
                0x1D,
                0xE6,
                0xB5,
                0x62,
                0xD6,
                0x91,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_BYTESTREAM_TRANSCODED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0xC2,
                0xC5,
                0xB6,
                0xC9,
                0x4D,
                0xB9,
                0x4D,
                0xAB,
                0x48,
                0xCF,
                0x3B,
                0x6D,
                0x8B,
                0xC5,
                0xE0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define MF_MEDIATYPE_EQUAL_MAJOR_TYPES 0x00000001")]
    public const int MF_MEDIATYPE_EQUAL_MAJOR_TYPES = 0x00000001;

    [NativeTypeName("#define MF_MEDIATYPE_EQUAL_FORMAT_TYPES 0x00000002")]
    public const int MF_MEDIATYPE_EQUAL_FORMAT_TYPES = 0x00000002;

    [NativeTypeName("#define MF_MEDIATYPE_EQUAL_FORMAT_DATA 0x00000004")]
    public const int MF_MEDIATYPE_EQUAL_FORMAT_DATA = 0x00000004;

    [NativeTypeName("#define MF_MEDIATYPE_EQUAL_FORMAT_USER_DATA 0x00000008")]
    public const int MF_MEDIATYPE_EQUAL_FORMAT_USER_DATA = 0x00000008;

    [NativeTypeName("#define MF_EVENT_FLAG_NO_WAIT 0x00000001")]
    public const int MF_EVENT_FLAG_NO_WAIT = 0x00000001;
}
