// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PrintManagerInterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IPrintManagerInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x42,
                0x5A,
                0x43,
                0xC5,
                0x43,
                0x8D,
                0x7B,
                0x4E,
                0xA6,
                0x8A,
                0xEF,
                0x31,
                0x1E,
                0x39,
                0x20,
                0x87
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}