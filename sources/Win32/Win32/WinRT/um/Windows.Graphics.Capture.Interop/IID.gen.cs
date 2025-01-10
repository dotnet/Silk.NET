// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Windows.Graphics.Capture.Interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IGraphicsCaptureItemInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
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
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWindowGraphicsCaptureItemInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0xC4,
                0xE4,
                0x38,
                0xE6,
                0x94,
                0x44,
                0x4C,
                0x9C,
                0xFA,
                0x96,
                0x81,
                0x93,
                0x31,
                0x6C,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMonitorGraphicsCaptureItemInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0x4D,
                0x27,
                0x33,
                0x76,
                0xA0,
                0x48,
                0x40,
                0x84,
                0x16,
                0x74,
                0x7E,
                0x9B,
                0x04,
                0xDB,
                0x7B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
