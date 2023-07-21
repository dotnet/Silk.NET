// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_ID2D1EffectContext1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5A, 0x59, 0xAB, 0x84,
                0x81, 0xFC,
                0x46, 0x45,
                0xBA,
                0xCD,
                0xE8,
                0xEF,
                0x4D,
                0x8A,
                0xBE,
                0x7A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1EffectContext2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA0, 0xD2, 0x7A, 0x57,
                0xC7, 0x9F,
                0xDA, 0x4D,
                0x8B,
                0x18,
                0xDA,
                0xB8,
                0x10,
                0x14,
                0x00,
                0x52
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
