// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MFTranscodeContainerType
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid MFTranscodeContainerType_ASF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x6F,
                0x0F,
                0x43,
                0xBF,
                0xB6,
                0xC1,
                0x4F,
                0xA0,
                0xBD,
                0x9E,
                0xE4,
                0x6E,
                0xEE,
                0x2A,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFTranscodeContainerType_MPEG4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0xD0,
                0x6C,
                0xDC,
                0xD0,
                0xB9,
                0xEF,
                0x40,
                0xBD,
                0x35,
                0xFA,
                0x62,
                0x2C,
                0x1A,
                0xB2,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFTranscodeContainerType_MP3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0xB9,
                0x38,
                0xE4,
                0xF1,
                0x83,
                0xE6,
                0x4D,
                0x9E,
                0x3A,
                0x9F,
                0xFB,
                0xC6,
                0xDD,
                0x24,
                0xD1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFTranscodeContainerType_FLAC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0x4A,
                0x34,
                0x31,
                0xA9,
                0x05,
                0xB5,
                0x42,
                0x90,
                0x1B,
                0x8E,
                0x9D,
                0x42,
                0x57,
                0xF7,
                0x5E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFTranscodeContainerType_3GP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x01,
                0xC5,
                0x34,
                0x72,
                0x44,
                0x34,
                0x4F,
                0x9E,
                0xA0,
                0xC4,
                0x9F,
                0xBA,
                0xCF,
                0x03,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFTranscodeContainerType_AC3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x91,
                0x8D,
                0x6D,
                0x91,
                0x8C,
                0xD1,
                0x4E,
                0x87,
                0x42,
                0x8C,
                0x34,
                0x7D,
                0x5B,
                0x44,
                0xD0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFTranscodeContainerType_ADTS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0xD2,
                0x2F,
                0x13,
                0x02,
                0x0F,
                0xDE,
                0x43,
                0xA3,
                0x01,
                0x38,
                0xFB,
                0xBB,
                0xB3,
                0x83,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFTranscodeContainerType_MPEG2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0xDB,
                0xC2,
                0xBF,
                0xB4,
                0x7B,
                0x8F,
                0x4F,
                0xAF,
                0xDE,
                0xE1,
                0x12,
                0xC4,
                0x4B,
                0xA8,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFTranscodeContainerType_WAVE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0x45,
                0xC3,
                0x64,
                0x26,
                0x0F,
                0x41,
                0x47,
                0xBE,
                0x63,
                0x87,
                0xBD,
                0xF8,
                0xBB,
                0x93,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFTranscodeContainerType_AVI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0xE8,
                0xDF,
                0x7E,
                0x2F,
                0x40,
                0x76,
                0x4D,
                0xA3,
                0x3C,
                0x61,
                0x9F,
                0xD1,
                0x57,
                0xD0,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFTranscodeContainerType_FMPEG4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x76,
                0xA8,
                0x9B,
                0x9F,
                0x41,
                0x77,
                0x4B,
                0xA1,
                0xE0,
                0x35,
                0x95,
                0x9D,
                0x9D,
                0x40,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFTranscodeContainerType_AMR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0x5A,
                0x5D,
                0x02,
                0x1A,
                0x62,
                0x5B,
                0x47,
                0x96,
                0x4D,
                0x66,
                0xB1,
                0xC8,
                0x24,
                0xF0,
                0x79,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
