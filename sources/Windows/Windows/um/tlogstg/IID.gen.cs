// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/tlogstg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_ITravelLogEntry
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x87,
                0xDD,
                0xBF,
                0x7E,
                0x18,
                0xAD,
                0xD3,
                0x11,
                0xA4,
                0xC5,
                0x00,
                0xC0,
                0x4F,
                0x72,
                0xD6,
                0xB8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITravelLogClient
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3E,
                0x03,
                0x1C,
                0x24,
                0x59,
                0xE6,
                0xDA,
                0x43,
                0xAA,
                0x4D,
                0x40,
                0x86,
                0xDB,
                0xC4,
                0x75,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumTravelLogEntry
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0xDD,
                0xBF,
                0x7E,
                0x18,
                0xAD,
                0xD3,
                0x11,
                0xA4,
                0xC5,
                0x00,
                0xC0,
                0x4F,
                0x72,
                0xD6,
                0xB8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITravelLogStg
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0xDD,
                0xBF,
                0x7E,
                0x18,
                0xAD,
                0xD3,
                0x11,
                0xA4,
                0xC5,
                0x00,
                0xC0,
                0x4F,
                0x72,
                0xD6,
                0xB8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}