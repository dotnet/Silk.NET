// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

public static partial class DXGI
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid DXGI_DEBUG_D3D12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8C, 0xA9, 0x59, 0xCF,
                0x50, 0xA9,
                0x26, 0x43,
                0x91,
                0xEF,
                0x9B,
                0xBA,
                0xA1,
                0x7B,
                0xFD,
                0x95
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
