// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10sdklayers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

public static partial class DXGI
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid DXGI_DEBUG_D3D10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x52, 0x4C, 0x3B, 0x24,
                0x06, 0x36,
                0x3A, 0x4D,
                0x99,
                0xD7,
                0xA7,
                0xE7,
                0xB3,
                0x3E,
                0xD7,
                0x06
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
