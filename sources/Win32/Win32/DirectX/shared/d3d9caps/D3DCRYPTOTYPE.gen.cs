// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DCRYPTOTYPE
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DCRYPTOTYPE_AES128_CTR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0xD7,
                0x6B,
                0x9B,
                0x74,
                0x4F,
                0xC9,
                0x41,
                0x9E,
                0x7B,
                0x0B,
                0xE2,
                0xD7,
                0xD9,
                0x3B,
                0x4F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DCRYPTOTYPE_PROPRIETARY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0x9A,
                0x4E,
                0xAB,
                0x1C,
                0x1D,
                0xE6,
                0x46,
                0xA7,
                0x2F,
                0x08,
                0x69,
                0x91,
                0x7B,
                0x0D,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
