// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIViewSettingsInterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IUIViewSettingsInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0xDB,
                0x94,
                0x36,
                0x68,
                0x8F,
                0xBE,
                0x44,
                0x8F,
                0xF5,
                0x19,
                0x5C,
                0x98,
                0xED,
                0xE8,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
