// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_DiaSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0x61,
                0x75,
                0xE6,
                0x65,
                0x1E,
                0x17,
                0x4D,
                0x85,
                0x76,
                0x61,
                0x07,
                0x61,
                0x39,
                0x8C,
                0x3C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_DiaSourceAlt
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x31,
                0x48,
                0x90,
                0x91,
                0xCA,
                0x49,
                0x66,
                0x47,
                0xB9,
                0x5C,
                0x25,
                0x39,
                0x7E,
                0x2D,
                0xD6,
                0xDC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_DiaStackWalker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0x85,
                0x4A,
                0xCE,
                0x68,
                0x57,
                0x5B,
                0x47,
                0xA4,
                0xE1,
                0xC0,
                0xBC,
                0xA2,
                0x11,
                0x2A,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
