// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class MF
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_SHARING_ENGINE_DEVICE_NAME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD1, 0x05, 0x1E, 0x77,
                0x2F, 0x86,
                0x99, 0x42,
                0x95,
                0xAC,
                0xAE,
                0x81,
                0xFD,
                0x14,
                0xF3,
                0xE7
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_MEDIA_SHARING_ENGINE_DEVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8A, 0xC5, 0x61, 0xB4,
                0x08, 0x7A,
                0x98, 0x4B,
                0x99,
                0xA8,
                0x70,
                0xFD,
                0x5F,
                0x3B,
                0xAD,
                0xFD
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_MEDIA_SHARING_ENGINE_INITIAL_SEEK_TIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF5, 0x97, 0x34, 0x6F,
                0x28, 0xD5,
                0x4F, 0x4A,
                0x8D,
                0xD7,
                0xDB,
                0x36,
                0x65,
                0x7E,
                0xC4,
                0xC9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SHUTDOWN_RENDERER_ON_ENGINE_SHUTDOWN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4D, 0xD9, 0x12, 0xC1,
                0x9C, 0x6B,
                0xF8, 0x48,
                0xB6,
                0xF9,
                0x79,
                0x50,
                0xFF,
                0x9A,
                0xB7,
                0x1E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_PREFERRED_SOURCE_URI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x88, 0x54, 0xC8, 0x5F,
                0x6A, 0x43,
                0xB8, 0x4D,
                0x90,
                0xAF,
                0x4D,
                0xB4,
                0x02,
                0xAE,
                0x5C,
                0x57
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SHARING_ENGINE_SHAREDRENDERER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA0, 0x46, 0xA4, 0xEF,
                0xE7, 0x73,
                0x4E, 0x40,
                0x8A,
                0xE2,
                0xFE,
                0xF6,
                0x0A,
                0xF5,
                0xA3,
                0x2B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MF_SHARING_ENGINE_CALLBACK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x95, 0x1E, 0xDC, 0x57,
                0x52, 0xD2,
                0xFA, 0x43,
                0x9B,
                0xBC,
                0x18,
                0x00,
                0x70,
                0xEE,
                0xFE,
                0x6D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
