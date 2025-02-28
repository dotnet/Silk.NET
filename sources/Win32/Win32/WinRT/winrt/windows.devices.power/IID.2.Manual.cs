// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IPowerGridData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xc3,
                0x60,
                0xfb,
                0x17,
                0xfc,
                0x92,
                0x5f,
                0x6e,
                0x99,
                0x9d,
                0x16,
                0xa4,
                0xcf,
                0x9d,
                0x6c,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPowerGridForecast
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0x7e,
                0x4d,
                0xe9,
                0xed,
                0x60,
                0x58,
                0xbb,
                0xa8,
                0x50,
                0x00,
                0x3c,
                0x6a,
                0x13,
                0x86,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPowerGridForecastStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5b,
                0x78,
                0xc8,
                0x06,
                0x2e,
                0x4e,
                0x5b,
                0xcc,
                0xbb,
                0x34,
                0xcb,
                0x81,
                0xc6,
                0x0f,
                0x9e,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
