// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IMessageDispatcher.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IMessageDispatcher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x4C,
                0xF8,
                0xF5,
                0xD0,
                0xCF,
                0xD6,
                0x4C,
                0xB6,
                0x6B,
                0xC5,
                0xD2,
                0x6F,
                0xF1,
                0x68,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
