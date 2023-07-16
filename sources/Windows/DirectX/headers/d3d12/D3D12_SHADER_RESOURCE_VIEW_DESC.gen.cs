// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='D3D12_SHADER_RESOURCE_VIEW_DESC.xml' path='doc/member[@name="D3D12_SHADER_RESOURCE_VIEW_DESC"]/*'/>
public partial struct D3D12_SHADER_RESOURCE_VIEW_DESC
{
    /// <include file='D3D12_SHADER_RESOURCE_VIEW_DESC.xml' path='doc/member[@name="D3D12_SHADER_RESOURCE_VIEW_DESC.Format"]/*'/>
    public DXGI_FORMAT Format;
    /// <include file='D3D12_SHADER_RESOURCE_VIEW_DESC.xml' path='doc/member[@name="D3D12_SHADER_RESOURCE_VIEW_DESC.ViewDimension"]/*'/>
    public D3D12_SRV_DIMENSION ViewDimension;
    /// <include file='D3D12_SHADER_RESOURCE_VIEW_DESC.xml' path='doc/member[@name="D3D12_SHADER_RESOURCE_VIEW_DESC.Shader4ComponentMapping"]/*'/>
    public uint Shader4ComponentMapping;
    /// <include file='D3D12_SHADER_RESOURCE_VIEW_DESC.xml' path='doc/member[@name="D3D12_SHADER_RESOURCE_VIEW_DESC.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_d3d12_L3213_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Buffer"]/*'/>
    [UnscopedRef]
    public ref D3D12_BUFFER_SRV Buffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Buffer;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1D"]/*'/>
    [UnscopedRef]
    public ref D3D12_TEX1D_SRV Texture1D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture1D;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1DArray"]/*'/>
    [UnscopedRef]
    public ref D3D12_TEX1D_ARRAY_SRV Texture1DArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture1DArray;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2D"]/*'/>
    [UnscopedRef]
    public ref D3D12_TEX2D_SRV Texture2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture2D;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DArray"]/*'/>
    [UnscopedRef]
    public ref D3D12_TEX2D_ARRAY_SRV Texture2DArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture2DArray;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DMS"]/*'/>
    [UnscopedRef]
    public ref D3D12_TEX2DMS_SRV Texture2DMS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture2DMS;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DMSArray"]/*'/>
    [UnscopedRef]
    public ref D3D12_TEX2DMS_ARRAY_SRV Texture2DMSArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture2DMSArray;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture3D"]/*'/>
    [UnscopedRef]
    public ref D3D12_TEX3D_SRV Texture3D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture3D;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.TextureCube"]/*'/>
    [UnscopedRef]
    public ref D3D12_TEXCUBE_SRV TextureCube
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.TextureCube;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.TextureCubeArray"]/*'/>
    [UnscopedRef]
    public ref D3D12_TEXCUBE_ARRAY_SRV TextureCubeArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.TextureCubeArray;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.RaytracingAccelerationStructure"]/*'/>
    [UnscopedRef]
    public ref D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV RaytracingAccelerationStructure
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.RaytracingAccelerationStructure;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Buffer"]/*'/>
        [FieldOffset(0)]
        public D3D12_BUFFER_SRV Buffer;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1D"]/*'/>
        [FieldOffset(0)]
        public D3D12_TEX1D_SRV Texture1D;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1DArray"]/*'/>
        [FieldOffset(0)]
        public D3D12_TEX1D_ARRAY_SRV Texture1DArray;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2D"]/*'/>
        [FieldOffset(0)]
        public D3D12_TEX2D_SRV Texture2D;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DArray"]/*'/>
        [FieldOffset(0)]
        public D3D12_TEX2D_ARRAY_SRV Texture2DArray;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DMS"]/*'/>
        [FieldOffset(0)]
        public D3D12_TEX2DMS_SRV Texture2DMS;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DMSArray"]/*'/>
        [FieldOffset(0)]
        public D3D12_TEX2DMS_ARRAY_SRV Texture2DMSArray;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture3D"]/*'/>
        [FieldOffset(0)]
        public D3D12_TEX3D_SRV Texture3D;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.TextureCube"]/*'/>
        [FieldOffset(0)]
        public D3D12_TEXCUBE_SRV TextureCube;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.TextureCubeArray"]/*'/>
        [FieldOffset(0)]
        public D3D12_TEXCUBE_ARRAY_SRV TextureCubeArray;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.RaytracingAccelerationStructure"]/*'/>
        [FieldOffset(0)]
        public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV RaytracingAccelerationStructure;
    }
}