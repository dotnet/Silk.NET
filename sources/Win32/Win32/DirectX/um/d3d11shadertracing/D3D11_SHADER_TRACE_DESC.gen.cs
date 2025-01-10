// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_SHADER_TRACE_DESC
{
    public D3D11_SHADER_TYPE Type;
    public uint Flags;

    [NativeTypeName("__AnonymousRecord_d3d11shadertracing_L134_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref D3D11_VERTEX_SHADER_TRACE_DESC VertexShaderTraceDesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.VertexShaderTraceDesc; }
    }

    [UnscopedRef]
    public ref D3D11_HULL_SHADER_TRACE_DESC HullShaderTraceDesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.HullShaderTraceDesc; }
    }

    [UnscopedRef]
    public ref D3D11_DOMAIN_SHADER_TRACE_DESC DomainShaderTraceDesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.DomainShaderTraceDesc; }
    }

    [UnscopedRef]
    public ref D3D11_GEOMETRY_SHADER_TRACE_DESC GeometryShaderTraceDesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.GeometryShaderTraceDesc; }
    }

    [UnscopedRef]
    public ref D3D11_PIXEL_SHADER_TRACE_DESC PixelShaderTraceDesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.PixelShaderTraceDesc; }
    }

    [UnscopedRef]
    public ref D3D11_COMPUTE_SHADER_TRACE_DESC ComputeShaderTraceDesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ComputeShaderTraceDesc; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D11_VERTEX_SHADER_TRACE_DESC VertexShaderTraceDesc;

        [FieldOffset(0)]
        public D3D11_HULL_SHADER_TRACE_DESC HullShaderTraceDesc;

        [FieldOffset(0)]
        public D3D11_DOMAIN_SHADER_TRACE_DESC DomainShaderTraceDesc;

        [FieldOffset(0)]
        public D3D11_GEOMETRY_SHADER_TRACE_DESC GeometryShaderTraceDesc;

        [FieldOffset(0)]
        public D3D11_PIXEL_SHADER_TRACE_DESC PixelShaderTraceDesc;

        [FieldOffset(0)]
        public D3D11_COMPUTE_SHADER_TRACE_DESC ComputeShaderTraceDesc;
    }
}
