// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/ivectorchangedeventargs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IVectorChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDF, 0x33, 0x59, 0x57,
                0xFE, 0x34,
                0x80, 0x44,
                0xAF,
                0x15,
                0x07,
                0x69,
                0x1F,
                0x3D,
                0x5D,
                0x9B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
