// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/robuffer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IBufferByteAccess
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xEF, 0x0F, 0x5A, 0x90,
                0x53, 0xBC,
                0xDF, 0x11,
                0x8C,
                0x49,
                0x00,
                0x1E,
                0x4F,
                0xC6,
                0x86,
                0xDA
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
