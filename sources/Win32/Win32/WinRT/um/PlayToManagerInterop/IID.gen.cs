// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PlayToManagerInterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IPlayToManagerInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0x46,
                0x39,
                0x24,
                0x2C,
                0x1F,
                0xB3,
                0x4E,
                0x8C,
                0xD7,
                0x0E,
                0xC1,
                0xDA,
                0x42,
                0xA5,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
