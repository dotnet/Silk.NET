// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid IID_IRendezvousSession
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDD, 0xB1, 0xA4, 0x9B,
                0x0C, 0x8B,
                0xB7, 0x48,
                0x9E,
                0x7C,
                0x2F,
                0x25,
                0x85,
                0x7C,
                0x8D,
                0xF5
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid IID_IRendezvousApplication
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0B, 0x07, 0x4D, 0x4F,
                0x75, 0xA2,
                0xFB, 0x49,
                0xB1,
                0x0D,
                0x8E,
                0xC2,
                0x63,
                0x87,
                0xB5,
                0x0D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
