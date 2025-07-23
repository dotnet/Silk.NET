// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAudioDeviceController2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x32,
                0x65,
                0x99,
                0x4c,
                0x24,
                0x48,
                0xb0,
                0x81,
                0xdd,
                0x0c,
                0x5c,
                0xc7,
                0x9d,
                0xdf,
                0x05,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
