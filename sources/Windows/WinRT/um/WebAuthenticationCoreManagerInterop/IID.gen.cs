// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebAuthenticationCoreManagerInterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IWebAuthenticationCoreManagerInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x04, 0xE8, 0xB8, 0xF4,
                0x1E, 0x81,
                0x36, 0x44,
                0xB6,
                0x9C,
                0x44,
                0xCB,
                0x67,
                0xB7,
                0x20,
                0x84
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
