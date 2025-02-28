// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAcousticEchoCancellationConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0x7e,
                0x73,
                0x5b,
                0x17,
                0x5b,
                0x51,
                0x77,
                0xa4,
                0x07,
                0x2e,
                0x33,
                0xba,
                0xfe,
                0x33,
                0xa5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioEffect2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0x70,
                0x3c,
                0xb0,
                0x75,
                0x7e,
                0x57,
                0x57,
                0x8a,
                0xf0,
                0x6b,
                0xa5,
                0x8a,
                0x8b,
                0x29,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
