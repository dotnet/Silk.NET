// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IPointerPointPhysicalPosition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x31,
                0x85,
                0xa3,
                0xa5,
                0xe7,
                0x48,
                0x59,
                0x9c,
                0x0b,
                0x89,
                0x34,
                0x02,
                0x04,
                0x80,
                0x6c,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
