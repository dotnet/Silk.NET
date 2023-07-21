// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/MemoryBuffer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IMemoryBufferByteAccess
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x35, 0x32, 0x0D, 0x5B,
                0xBA, 0x4D,
                0x44, 0x4D,
                0x86,
                0x5E,
                0x8F,
                0x1D,
                0x0E,
                0x4F,
                0xD0,
                0x4D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
