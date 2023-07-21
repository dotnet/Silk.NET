// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IMFPMediaPlayer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0A, 0x59, 0x14, 0xA7,
                0xAF, 0x58,
                0x0A, 0x43,
                0x85,
                0xBF,
                0x44,
                0xF5,
                0xEC,
                0x83,
                0x8D,
                0x85
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFPMediaItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x6B, 0x3E, 0xEB, 0x90,
                0xBF, 0xEC,
                0xCC, 0x45,
                0xB1,
                0xDA,
                0xC6,
                0xFE,
                0x3E,
                0xA7,
                0x0D,
                0x57
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFPMediaPlayerCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xFB, 0x8F, 0x6C, 0x76,
                0xDB, 0x5F,
                0xEA, 0x4F,
                0xA2,
                0x8D,
                0xB9,
                0x12,
                0x99,
                0x6F,
                0x51,
                0xBD
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
