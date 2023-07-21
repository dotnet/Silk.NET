// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.directx.direct3d11.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IDirect3DDxgiInterfaceAccess
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x12, 0xD0, 0xB3, 0xA9,
                0xF2, 0x3D,
                0xE3, 0x4E,
                0xB8,
                0xD1,
                0x86,
                0x95,
                0xF4,
                0x57,
                0xD3,
                0xC1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
