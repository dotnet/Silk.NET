// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dragdropinterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IDragDropManagerInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0xCB,
                0xD8,
                0x5A,
                0x01,
                0x4C,
                0xAC,
                0x4D,
                0x90,
                0x74,
                0x82,
                0x78,
                0x94,
                0x29,
                0x2D,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
