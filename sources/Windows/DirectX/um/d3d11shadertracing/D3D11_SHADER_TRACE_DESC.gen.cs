// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_SHADER_TRACE_DESC.xml' path='doc/member[@name="D3D11_SHADER_TRACE_DESC"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_SHADER_TRACE_DESC
{
    /// <include file='D3D11_SHADER_TRACE_DESC.xml' path='doc/member[@name="D3D11_SHADER_TRACE_DESC.Type"]/*'/>
    public D3D11_SHADER_TYPE Type;
    /// <include file='D3D11_SHADER_TRACE_DESC.xml' path='doc/member[@name="D3D11_SHADER_TRACE_DESC.Flags"]/*'/>
    public uint Flags;
    /// <include file='D3D11_SHADER_TRACE_DESC.xml' path='doc/member[@name="D3D11_SHADER_TRACE_DESC.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_d3d11shadertracing_L134_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.VertexShaderTraceDesc"]/*'/>
    [UnscopedRef]
    public ref D3D11_VERTEX_SHADER_TRACE_DESC VertexShaderTraceDesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.VertexShaderTraceDesc;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.HullShaderTraceDesc"]/*'/>
    [UnscopedRef]
    public ref D3D11_HULL_SHADER_TRACE_DESC HullShaderTraceDesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.HullShaderTraceDesc;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.DomainShaderTraceDesc"]/*'/>
    [UnscopedRef]
    public ref D3D11_DOMAIN_SHADER_TRACE_DESC DomainShaderTraceDesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.DomainShaderTraceDesc;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.GeometryShaderTraceDesc"]/*'/>
    [UnscopedRef]
    public ref D3D11_GEOMETRY_SHADER_TRACE_DESC GeometryShaderTraceDesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.GeometryShaderTraceDesc;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.PixelShaderTraceDesc"]/*'/>
    [UnscopedRef]
    public ref D3D11_PIXEL_SHADER_TRACE_DESC PixelShaderTraceDesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.PixelShaderTraceDesc;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ComputeShaderTraceDesc"]/*'/>
    [UnscopedRef]
    public ref D3D11_COMPUTE_SHADER_TRACE_DESC ComputeShaderTraceDesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ComputeShaderTraceDesc;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.VertexShaderTraceDesc"]/*'/>
        [FieldOffset(0)]
        public D3D11_VERTEX_SHADER_TRACE_DESC VertexShaderTraceDesc;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.HullShaderTraceDesc"]/*'/>
        [FieldOffset(0)]
        public D3D11_HULL_SHADER_TRACE_DESC HullShaderTraceDesc;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.DomainShaderTraceDesc"]/*'/>
        [FieldOffset(0)]
        public D3D11_DOMAIN_SHADER_TRACE_DESC DomainShaderTraceDesc;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.GeometryShaderTraceDesc"]/*'/>
        [FieldOffset(0)]
        public D3D11_GEOMETRY_SHADER_TRACE_DESC GeometryShaderTraceDesc;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.PixelShaderTraceDesc"]/*'/>
        [FieldOffset(0)]
        public D3D11_PIXEL_SHADER_TRACE_DESC PixelShaderTraceDesc;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ComputeShaderTraceDesc"]/*'/>
        [FieldOffset(0)]
        public D3D11_COMPUTE_SHADER_TRACE_DESC ComputeShaderTraceDesc;
    }
}