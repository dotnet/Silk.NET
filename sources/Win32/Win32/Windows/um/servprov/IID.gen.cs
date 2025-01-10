// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/servprov.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IServiceProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0x40,
                0x51,
                0x6D,
                0x36,
                0x74,
                0xCE,
                0x11,
                0x80,
                0x34,
                0x00,
                0xAA,
                0x00,
                0x60,
                0x09,
                0xFA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
