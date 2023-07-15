// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ObjectArray.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IObjectArray
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0x9D,
                0xCA,
                0x92,
                0x22,
                0x56,
                0xBA,
                0x4B,
                0xA8,
                0x05,
                0x5E,
                0x9F,
                0x54,
                0x1B,
                0xD8,
                0xC9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IObjectCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA4,
                0xB1,
                0x32,
                0x56,
                0x8A,
                0xE3,
                0x0A,
                0x40,
                0x92,
                0x8A,
                0xD4,
                0xCD,
                0x63,
                0x23,
                0x02,
                0x95
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}