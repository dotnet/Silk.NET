// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IImageBytes
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x23,
                0x18,
                0x5D,
                0x02,
                0x7D,
                0x6C,
                0x7B,
                0x44,
                0xBB,
                0xDB,
                0xA3,
                0xCB,
                0xC3,
                0xDF,
                0xA2,
                0xFC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}