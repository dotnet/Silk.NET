// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IPrintDocumentPackageTarget
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC4,
                0xFE,
                0x8E,
                0x1B,
                0x19,
                0x30,
                0x27,
                0x4C,
                0x96,
                0x4E,
                0x36,
                0x72,
                0x02,
                0x15,
                0x69,
                0x06
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintDocumentPackageTarget2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0x29,
                0x60,
                0xC5,
                0x5C,
                0x53,
                0xF9,
                0x48,
                0x86,
                0x6A,
                0x63,
                0x25,
                0x40,
                0x66,
                0x0C,
                0xB4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintDocumentPackageStatusEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAD,
                0xC8,
                0x90,
                0xED,
                0x34,
                0x5C,
                0x05,
                0x4D,
                0xA1,
                0xEC,
                0x0E,
                0x8A,
                0x9B,
                0x3A,
                0xD7,
                0xAF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintDocumentPackageTargetFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF7,
                0x9B,
                0x95,
                0xD2,
                0x1B,
                0xB3,
                0x3D,
                0x4A,
                0x96,
                0x00,
                0x71,
                0x2E,
                0xB1,
                0x33,
                0x5B,
                0xA4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}