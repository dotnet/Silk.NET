// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IShellFolderView
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x78,
                0xA3,
                0x37,
                0x2D,
                0xF8,
                0xCE,
                0x11,
                0xAE,
                0x65,
                0x08,
                0x00,
                0x2B,
                0x2E,
                0x12,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
