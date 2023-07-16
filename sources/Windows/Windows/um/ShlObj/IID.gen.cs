// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IDeskBarClient
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x75,
                0xE1,
                0x0F,
                0xEB,
                0x3A,
                0x1A,
                0xD0,
                0x11,
                0x89,
                0xB3,
                0x00,
                0xA0,
                0xC9,
                0x0A,
                0x90,
                0xAC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IInitializeObject
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0xAD,
                0x22,
                0x46,
                0x23,
                0xFF,
                0xD0,
                0x11,
                0x8D,
                0x34,
                0x00,
                0xA0,
                0xC9,
                0x0F,
                0x27,
                0x19
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}