// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/inspectable.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Core;
#pragma warning disable CS1589, CS1591, CS0419, CA1416, CS0618
namespace Silk.NET.Core;

public static partial class IID
{
    public static ref readonly Guid IInspectable
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0xE2,
                0x86,
                0xAF,
                0x2D,
                0xB1,
                0x6A,
                0x4C,
                0x9C,
                0x5A,
                0xD7,
                0xAA,
                0x65,
                0x10,
                0x1E,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
