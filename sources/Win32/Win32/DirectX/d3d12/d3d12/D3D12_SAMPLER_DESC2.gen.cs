// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_SAMPLER_DESC2
{
    public D3D12_FILTER Filter;
    public D3D12_TEXTURE_ADDRESS_MODE AddressU;
    public D3D12_TEXTURE_ADDRESS_MODE AddressV;
    public D3D12_TEXTURE_ADDRESS_MODE AddressW;
    public float MipLODBias;
    public uint MaxAnisotropy;
    public D3D12_COMPARISON_FUNC ComparisonFunc;

    [NativeTypeName("__AnonymousRecord_d3d12_L3619_C5")]
    public _Anonymous_e__Union Anonymous;
    public float MinLOD;
    public float MaxLOD;
    public D3D12_SAMPLER_FLAGS Flags;

    [UnscopedRef]
    public Span<float> FloatBorderColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.FloatBorderColor; }
    }

    [UnscopedRef]
    public Span<uint> UintBorderColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.UintBorderColor; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("FLOAT[4]")]
        public _FloatBorderColor_e__FixedBuffer FloatBorderColor;

        [FieldOffset(0)]
        [NativeTypeName("UINT[4]")]
        public _UintBorderColor_e__FixedBuffer UintBorderColor;

        [InlineArray(4)]
        public partial struct _FloatBorderColor_e__FixedBuffer
        {
            public float e0;
        }

        [InlineArray(4)]
        public partial struct _UintBorderColor_e__FixedBuffer
        {
            public uint e0;
        }
    }
}
