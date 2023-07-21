// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_ITextStoreACP
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE3, 0x8F, 0x88, 0x28,
                0xA0, 0xC2,
                0x3A, 0x48,
                0xA3,
                0xEA,
                0x8C,
                0xB1,
                0xCE,
                0x51,
                0xFF,
                0x3D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITextStoreACP2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x9F, 0xD8, 0x6A, 0xF8,
                0xE4, 0x5F,
                0x8D, 0x4B,
                0xBB,
                0x9F,
                0xEF,
                0x37,
                0x97,
                0xA8,
                0x4F,
                0x1F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITextStoreACPSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x94, 0x4C, 0xD4, 0x22,
                0x19, 0xA4,
                0x42, 0x45,
                0xA2,
                0x72,
                0xAE,
                0x26,
                0x09,
                0x3E,
                0xCE,
                0xCF
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAnchor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x34, 0x7E, 0xEB, 0x0F,
                0x60, 0x5A,
                0x56, 0x43,
                0x8E,
                0xF7,
                0xAB,
                0xDE,
                0xC2,
                0xFF,
                0x7C,
                0xF8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITextStoreAnchor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB0, 0x77, 0x20, 0x9B,
                0x18, 0x5F,
                0xEC, 0x4D,
                0xBE,
                0xE9,
                0x3C,
                0xC7,
                0x22,
                0xF5,
                0xDF,
                0xE0
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITextStoreAnchorSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x05, 0xE9, 0x80, 0xAA,
                0x21, 0x20,
                0xD2, 0x11,
                0x93,
                0xE0,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
