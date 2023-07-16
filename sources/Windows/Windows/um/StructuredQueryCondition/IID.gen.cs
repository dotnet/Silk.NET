// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/StructuredQueryCondition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IRichChunk
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9C,
                0xF6,
                0xDE,
                0x4F,
                0xC9,
                0xDB,
                0x4E,
                0x45,
                0x99,
                0x10,
                0xB3,
                0x4F,
                0x3C,
                0x64,
                0xB5,
                0x10
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICondition
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD4,
                0x88,
                0xC9,
                0x0F,
                0x35,
                0xC9,
                0x97,
                0x4B,
                0xA9,
                0x73,
                0x46,
                0x28,
                0x2E,
                0xA1,
                0x75,
                0xC8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICondition2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1D,
                0x85,
                0xB8,
                0x0D,
                0x5B,
                0x2E,
                0xEB,
                0x47,
                0x92,
                0x08,
                0xD2,
                0x8C,
                0x32,
                0x5A,
                0x01,
                0xD7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}