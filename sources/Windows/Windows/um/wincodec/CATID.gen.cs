// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class CATID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CATID_WICBitmapDecoders
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x37, 0x68, 0xD9, 0x7E,
                0xF0, 0x96,
                0x12, 0x48,
                0xB2,
                0x11,
                0xF1,
                0x3C,
                0x24,
                0x11,
                0x7E,
                0xD3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CATID_WICBitmapEncoders
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x96, 0x72, 0x75, 0xAC,
                0x22, 0x35,
                0x11, 0x4E,
                0x98,
                0x62,
                0xC1,
                0x7B,
                0xE5,
                0xA1,
                0x76,
                0x7E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CATID_WICPixelFormats
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0F, 0xE7, 0x46, 0x2B,
                0xA7, 0xCD,
                0x3E, 0x47,
                0x89,
                0xF6,
                0xDC,
                0x96,
                0x30,
                0xA2,
                0x39,
                0x0B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CATID_WICFormatConverters
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE8, 0xEA, 0x35, 0x78,
                0x14, 0xBF,
                0xD1, 0x49,
                0x93,
                0xCE,
                0x53,
                0x3A,
                0x40,
                0x7B,
                0x22,
                0x48
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CATID_WICMetadataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD8, 0x94, 0xAF, 0x05,
                0x74, 0x71,
                0xD2, 0x4C,
                0xBE,
                0x4A,
                0x41,
                0x24,
                0xB8,
                0x0E,
                0xE4,
                0xB8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CATID_WICMetadataWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA4, 0xB9, 0xE3, 0xAB,
                0x7D, 0x25,
                0x97, 0x4B,
                0xBD,
                0x1A,
                0x29,
                0x4A,
                0xF4,
                0x96,
                0x22,
                0x2E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
