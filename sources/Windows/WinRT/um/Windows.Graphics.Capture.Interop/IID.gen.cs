// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Windows.Graphics.Capture.Interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IGraphicsCaptureItemInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1B,
                0xE8,
                0x28,
                0x36,
                0xAC,
                0x3C,
                0x60,
                0x4C,
                0xB7,
                0xF4,
                0x23,
                0xCE,
                0x0E,
                0x0C,
                0x33,
                0x56
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}