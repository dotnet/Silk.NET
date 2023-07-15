// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IContact.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class CLSID
{
    public static ref readonly Guid CLSID_Contact
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x08,
                0x88,
                0xB6,
                0x61,
                0xEE,
                0x8E,
                0xD1,
                0x4F,
                0xAC,
                0xB8,
                0x3D,
                0x80,
                0x4C,
                0x8D,
                0xB0,
                0x56
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ContactManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAB,
                0xC8,
                0x65,
                0x71,
                0x88,
                0xAF,
                0xBD,
                0x42,
                0x86,
                0xFD,
                0x53,
                0x10,
                0xB4,
                0x28,
                0x5A,
                0x02
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}