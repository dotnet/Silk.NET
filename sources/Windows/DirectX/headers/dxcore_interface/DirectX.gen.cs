// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
public static partial class DirectX
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid DXCORE_ADAPTER_ATTRIBUTE_D3D11_GRAPHICS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x6B, 0x86, 0x47, 0x8C, 0x83, 0x75, 0x0D, 0x45, 0xF0, 0xF0, 0x6B, 0xAD, 0xA8, 0x95, 0xAF, 0x4B];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DXCORE_ADAPTER_ATTRIBUTE_D3D12_GRAPHICS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x4D, 0xCE, 0x9E, 0x0C, 0x6E, 0x2F, 0x01, 0x4F, 0x8C, 0x96, 0xE8, 0x9E, 0x33, 0x1B, 0x47, 0xB1];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid DXCORE_ADAPTER_ATTRIBUTE_D3D12_CORE_COMPUTE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x00, 0x28, 0x8E, 0x24, 0x93, 0xA7, 0x24, 0x47, 0xAB, 0xAA, 0x23, 0xA6, 0xDE, 0x1B, 0xE0, 0x90];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define _FACDXCORE 0x880")]
    public const int _FACDXCORE = 0x880;
}