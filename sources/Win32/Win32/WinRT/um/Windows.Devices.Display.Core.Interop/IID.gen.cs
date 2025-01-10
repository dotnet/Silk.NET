// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Windows.Devices.Display.Core.Interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IDisplayDeviceInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0x83,
                0x33,
                0x64,
                0x6A,
                0x36,
                0x1B,
                0x47,
                0xBD,
                0x56,
                0xDD,
                0x8E,
                0xF4,
                0x8E,
                0x43,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDisplayPathInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0x42,
                0xBA,
                0xA6,
                0x9E,
                0xE5,
                0x71,
                0x4E,
                0xB2,
                0x5B,
                0x4E,
                0x43,
                0x6D,
                0x21,
                0xEE,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
