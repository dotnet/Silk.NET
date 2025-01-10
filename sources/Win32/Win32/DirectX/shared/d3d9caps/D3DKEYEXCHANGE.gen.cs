// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DKEYEXCHANGE
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DKEYEXCHANGE_RSAES_OAEP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0x98,
                0x94,
                0xC1,
                0x2A,
                0xD7,
                0x1D,
                0x4A,
                0x8E,
                0x5D,
                0xED,
                0x85,
                0x7D,
                0x17,
                0x15,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3DKEYEXCHANGE_DXVA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0x77,
                0xD3,
                0x43,
                0xE5,
                0x38,
                0x24,
                0x49,
                0x8D,
                0x86,
                0xD3,
                0xFC,
                0xCF,
                0x15,
                0x3E,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
