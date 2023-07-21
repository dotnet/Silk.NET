// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_ISharedBitmap
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA4, 0x62, 0x11, 0x09,
                0x96, 0xBC,
                0x1F, 0x41,
                0xAA,
                0xE8,
                0xC5,
                0x12,
                0x2C,
                0xD0,
                0x33,
                0x63
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IThumbnailCache
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5D, 0xC1, 0x76, 0xF6,
                0x6A, 0x59,
                0xE2, 0x4C,
                0x82,
                0x34,
                0x33,
                0x99,
                0x6F,
                0x44,
                0x5D,
                0xB1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IThumbnailProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xCD, 0xFC, 0x57, 0xE3,
                0x95, 0xA9,
                0x76, 0x45,
                0xB0,
                0x1F,
                0x23,
                0x46,
                0x30,
                0x15,
                0x4E,
                0x96
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IThumbnailSettings
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x00, 0x6F, 0x37, 0xF4,
                0xF5, 0xBE,
                0x45, 0x4D,
                0x80,
                0xF3,
                0x1E,
                0x02,
                0x3B,
                0xBF,
                0x12,
                0x09
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IThumbnailCachePrimer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xFE, 0xF8, 0x03, 0x0F,
                0x26, 0x2B,
                0xF0, 0x46,
                0x96,
                0x5A,
                0x21,
                0x2A,
                0xA8,
                0xD6,
                0x6B,
                0x76
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_LocalThumbnailCache
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x44, 0x45, 0xEF, 0x50,
                0x9F, 0xAC,
                0x8E, 0x4A,
                0xB2,
                0x1B,
                0x8A,
                0x26,
                0x18,
                0x0D,
                0xB1,
                0x3F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SharedBitmap
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x76, 0x64, 0xB2, 0x4D,
                0x87, 0x67,
                0x46, 0x40,
                0xB8,
                0x36,
                0xE8,
                0x41,
                0x2A,
                0x9E,
                0x8A,
                0x27
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
