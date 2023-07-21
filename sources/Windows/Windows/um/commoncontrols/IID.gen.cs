// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/commoncontrols.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IImageList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x26, 0x59, 0xEB, 0x46,
                0x2E, 0x58,
                0x17, 0x40,
                0x9F,
                0xDF,
                0xE8,
                0x99,
                0x8D,
                0xAA,
                0x09,
                0x50
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IImageList2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x83, 0x9D, 0x2B, 0x19,
                0xFC, 0x50,
                0x7B, 0x45,
                0x90,
                0xA0,
                0x2B,
                0x82,
                0xA8,
                0xB5,
                0xDA,
                0xE1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ImageList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA2, 0x6B, 0x47, 0x7C,
                0xB1, 0x02,
                0xF4, 0x48,
                0x80,
                0x48,
                0xB2,
                0x46,
                0x19,
                0xDD,
                0xC0,
                0x58
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
