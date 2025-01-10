// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/RemoteSystemsInterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_ICorrelationVectorInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0x8B,
                0xC7,
                0x83,
                0x8B,
                0xD8,
                0x50,
                0x49,
                0xAA,
                0x6E,
                0x22,
                0xB8,
                0xD2,
                0x2A,
                0xAB,
                0xD3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
