// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IUniformResourceLocatorA
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x80, 0x3B, 0xF2, 0xFB,
                0xF0, 0xE3,
                0x1B, 0x10,
                0x84,
                0x88,
                0x00,
                0xAA,
                0x00,
                0x3E,
                0x56,
                0xF8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IUniformResourceLocatorW
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA0, 0x0D, 0xBB, 0xCA,
                0x57, 0xDA,
                0xCF, 0x11,
                0x99,
                0x74,
                0x00,
                0x20,
                0xAF,
                0xD7,
                0x97,
                0x62
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
