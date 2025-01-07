// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IPointerPointPhysicalPosition
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x00, 0x31, 0x85, 0xa3,
                0xa5, 0xe7,
                0x48, 0x59,
                0x9c,
                0x0b,
                0x89,
                0x34,
                0x02,
                0x04,
                0x80,
                0x6c
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
