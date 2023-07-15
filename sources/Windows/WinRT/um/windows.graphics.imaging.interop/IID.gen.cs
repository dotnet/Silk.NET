// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.graphics.imaging.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_ISoftwareBitmapNative
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0x84,
                0xBC,
                0x94,
                0xEA,
                0x04,
                0x2E,
                0x4B,
                0xAF,
                0x13,
                0x4D,
                0xE9,
                0x5A,
                0xA8,
                0x98,
                0xEB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISoftwareBitmapNativeFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEC,
                0x81,
                0xC1,
                0xC3,
                0x14,
                0x29,
                0x91,
                0x47,
                0xAF,
                0x02,
                0x02,
                0xD2,
                0x24,
                0xA1,
                0x0B,
                0x43
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}