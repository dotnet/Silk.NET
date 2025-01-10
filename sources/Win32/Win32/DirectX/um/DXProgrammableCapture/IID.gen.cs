// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DXProgrammableCapture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IDXGraphicsAnalysis
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0x15,
                0x25,
                0x9F,
                0x4D,
                0x9D,
                0x02,
                0x49,
                0x9D,
                0x60,
                0x18,
                0x98,
                0x8A,
                0xB7,
                0xD4,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
