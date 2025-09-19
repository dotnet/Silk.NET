// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IIppPrintDevice3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xb6,
                0x25,
                0x8f,
                0x6d,
                0xa4,
                0x6d,
                0x5e,
                0x37,
                0x80,
                0xce,
                0x5f,
                0x69,
                0xd5,
                0x54,
                0x47,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IIppPrintDevice4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8c,
                0x48,
                0x24,
                0x7e,
                0xe8,
                0x69,
                0x59,
                0xfb,
                0xbc,
                0x6d,
                0xda,
                0xea,
                0x06,
                0x14,
                0xf9,
                0x3e,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
