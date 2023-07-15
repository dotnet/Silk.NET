// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xapo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IXAPO
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0xB9,
                0x10,
                0xA4,
                0x39,
                0x98,
                0x19,
                0x48,
                0xA0,
                0xBE,
                0x28,
                0x56,
                0xAE,
                0x6B,
                0x3A,
                0xDB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXAPOParameters
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x66,
                0x5C,
                0xD9,
                0x26,
                0xF2,
                0x80,
                0x9A,
                0x49,
                0xAD,
                0x54,
                0x5A,
                0xE7,
                0xF0,
                0x1C,
                0x6D,
                0x98
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}