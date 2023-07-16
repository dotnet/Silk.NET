// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SystemMediaTransportControlsInterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_ISystemMediaTransportControlsInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2D,
                0x47,
                0xB0,
                0xDD,
                0x11,
                0xC9,
                0x1F,
                0x4A,
                0x86,
                0xD9,
                0xDC,
                0x3D,
                0x71,
                0xA9,
                0x5F,
                0x5A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}