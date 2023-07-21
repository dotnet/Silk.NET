// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.data.pdf.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IPdfRendererNative
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x91, 0xCD, 0x9D, 0x7D,
                0x77, 0xD2,
                0x47, 0x49,
                0x85,
                0x27,
                0x07,
                0xA0,
                0xDA,
                0xED,
                0xA9,
                0x4A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
