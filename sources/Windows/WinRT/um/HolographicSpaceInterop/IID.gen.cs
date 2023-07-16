// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HolographicSpaceInterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IHolographicSpaceInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x36,
                0xE5,
                0x4E,
                0x5C,
                0x98,
                0x6A,
                0x86,
                0x4B,
                0xA1,
                0x70,
                0x58,
                0x70,
                0x13,
                0xD6,
                0xFD,
                0x4B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}