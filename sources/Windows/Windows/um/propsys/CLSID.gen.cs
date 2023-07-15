// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class CLSID
{
    public static ref readonly Guid CLSID_InMemoryPropertyStore
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x12,
                0xE0,
                0x02,
                0x9A,
                0x03,
                0x63,
                0x1E,
                0x4E,
                0xB9,
                0xA1,
                0x63,
                0x0F,
                0x80,
                0x25,
                0x92,
                0xC5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_InMemoryPropertyStoreMarshalByValue
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2D,
                0x0E,
                0xCA,
                0xD4,
                0xA7,
                0x6D,
                0x75,
                0x4B,
                0xA9,
                0x7C,
                0x5F,
                0x30,
                0x6F,
                0x0E,
                0xAE,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_PropertySystem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0x7F,
                0x96,
                0xB8,
                0xAE,
                0x58,
                0x46,
                0x4F,
                0x9F,
                0xB2,
                0x5D,
                0x79,
                0x04,
                0x79,
                0x8F,
                0x4B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}