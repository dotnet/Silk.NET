// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/useractivityinterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IUserActivityInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0x31,
                0xDE,
                0x1A,
                0x0A,
                0x0E,
                0xD9,
                0x40,
                0x82,
                0x4C,
                0x9A,
                0x08,
                0x8A,
                0x50,
                0x05,
                0x9F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IUserActivitySourceHostInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0xF8,
                0x5D,
                0xC1,
                0x44,
                0x88,
                0x7A,
                0x48,
                0xB8,
                0x5B,
                0x75,
                0x78,
                0xE0,
                0xF6,
                0x14,
                0x19
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IUserActivityRequestManagerInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x76,
                0xF8,
                0x69,
                0xDD,
                0x99,
                0x96,
                0x15,
                0x47,
                0x90,
                0x95,
                0xE3,
                0x7E,
                0xA3,
                0x0D,
                0xFA,
                0x1B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}