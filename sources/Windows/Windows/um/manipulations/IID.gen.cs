// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid IID__IManipulationEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDA, 0xC8, 0x62, 0x4F,
                0x53, 0x9C,
                0x22, 0x4B,
                0x93,
                0xDF,
                0x92,
                0x7A,
                0x86,
                0x2B,
                0xBB,
                0x03
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid IID_IInertiaProcessor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x6D, 0x0C, 0xB0, 0x18,
                0xEE, 0xC5,
                0xB1, 0x41,
                0x90,
                0xA9,
                0x9D,
                0x4A,
                0x92,
                0x90,
                0x95,
                0xAD
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid IID_IManipulationProcessor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x19, 0xC5, 0x2A, 0xA2,
                0x00, 0x83,
                0xA0, 0x48,
                0xBE,
                0xF4,
                0xF1,
                0xBE,
                0x87,
                0x37,
                0xDB,
                0xA4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
