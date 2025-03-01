// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IBackgroundTaskBuilder6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0xb4,
                0x7b,
                0x17,
                0xec,
                0x8b,
                0x56,
                0x53,
                0x85,
                0x0b,
                0x75,
                0x08,
                0xa0,
                0x1f,
                0x52,
                0xe7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBackgroundTaskBuilderStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xd1,
                0xeb,
                0x50,
                0x46,
                0x06,
                0xf2,
                0x55,
                0xb4,
                0x9b,
                0xb7,
                0xa6,
                0x45,
                0x7e,
                0xbf,
                0x33,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBackgroundTaskRegistration4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x9c,
                0x09,
                0xc9,
                0xb0,
                0xde,
                0x55,
                0x76,
                0xa0,
                0x5b,
                0xa0,
                0x20,
                0x67,
                0x98,
                0x98,
                0x79,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBackgroundWorkCostStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xd8,
                0x68,
                0xc9,
                0x76,
                0x81,
                0xf6,
                0x57,
                0xc8,
                0xab,
                0x2b,
                0x40,
                0x0b,
                0x74,
                0x9e,
                0x21,
                0xd6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
