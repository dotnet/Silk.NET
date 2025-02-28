// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAudioEffectsPackConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0xd7,
                0x62,
                0x7d,
                0x70,
                0xc1,
                0x53,
                0x6c,
                0xa8,
                0xf8,
                0x6f,
                0x98,
                0x01,
                0x5a,
                0x7f,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioEffectsPackConfigurationStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0xc2,
                0x04,
                0x13,
                0x53,
                0x0c,
                0x55,
                0xff,
                0xba,
                0x2b,
                0x8e,
                0x68,
                0xa9,
                0xb5,
                0x6a,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
