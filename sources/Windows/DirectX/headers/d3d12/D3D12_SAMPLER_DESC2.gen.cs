// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_SAMPLER_DESC2.xml' path='doc/member[@name="D3D12_SAMPLER_DESC2"]/*'/>
public unsafe partial struct D3D12_SAMPLER_DESC2
{
    /// <include file='D3D12_SAMPLER_DESC2.xml' path='doc/member[@name="D3D12_SAMPLER_DESC2.Filter"]/*'/>
    public D3D12_FILTER Filter;
    /// <include file='D3D12_SAMPLER_DESC2.xml' path='doc/member[@name="D3D12_SAMPLER_DESC2.AddressU"]/*'/>
    public D3D12_TEXTURE_ADDRESS_MODE AddressU;
    /// <include file='D3D12_SAMPLER_DESC2.xml' path='doc/member[@name="D3D12_SAMPLER_DESC2.AddressV"]/*'/>
    public D3D12_TEXTURE_ADDRESS_MODE AddressV;
    /// <include file='D3D12_SAMPLER_DESC2.xml' path='doc/member[@name="D3D12_SAMPLER_DESC2.AddressW"]/*'/>
    public D3D12_TEXTURE_ADDRESS_MODE AddressW;
    /// <include file='D3D12_SAMPLER_DESC2.xml' path='doc/member[@name="D3D12_SAMPLER_DESC2.MipLODBias"]/*'/>
    public float MipLODBias;
    /// <include file='D3D12_SAMPLER_DESC2.xml' path='doc/member[@name="D3D12_SAMPLER_DESC2.MaxAnisotropy"]/*'/>
    public uint MaxAnisotropy;
    /// <include file='D3D12_SAMPLER_DESC2.xml' path='doc/member[@name="D3D12_SAMPLER_DESC2.ComparisonFunc"]/*'/>
    public D3D12_COMPARISON_FUNC ComparisonFunc;
    /// <include file='D3D12_SAMPLER_DESC2.xml' path='doc/member[@name="D3D12_SAMPLER_DESC2.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_d3d12_L3379_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='D3D12_SAMPLER_DESC2.xml' path='doc/member[@name="D3D12_SAMPLER_DESC2.MinLOD"]/*'/>
    public float MinLOD;
    /// <include file='D3D12_SAMPLER_DESC2.xml' path='doc/member[@name="D3D12_SAMPLER_DESC2.MaxLOD"]/*'/>
    public float MaxLOD;
    /// <include file='D3D12_SAMPLER_DESC2.xml' path='doc/member[@name="D3D12_SAMPLER_DESC2.Flags"]/*'/>
    public D3D12_SAMPLER_FLAGS Flags;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FloatBorderColor"]/*'/>
    [UnscopedRef]
    public Span<float> FloatBorderColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.FloatBorderColor[0], 4);
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.UintBorderColor"]/*'/>
    [UnscopedRef]
    public Span<uint> UintBorderColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.UintBorderColor[0], 4);
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FloatBorderColor"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("FLOAT[4]")]
        public fixed float FloatBorderColor[4];
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.UintBorderColor"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("UINT[4]")]
        public fixed uint UintBorderColor[4];
    }
}