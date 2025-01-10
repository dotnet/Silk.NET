// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcompanimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IDCompositionAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD9,
                0x91,
                0xFD,
                0xCB,
                0xB2,
                0x51,
                0xE4,
                0x45,
                0xB3,
                0xDE,
                0xD1,
                0x9C,
                0xCF,
                0xB8,
                0x63,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
