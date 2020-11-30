// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d11shadertracing_L126_C5")]
    public unsafe partial struct AnonymousRecordD3d11shadertracingL126C5
    {
        public AnonymousRecordD3d11shadertracingL126C5
        (
            VertexShaderTraceDesc? vertexShaderTraceDesc = null,
            HullShaderTraceDesc? hullShaderTraceDesc = null,
            DomainShaderTraceDesc? domainShaderTraceDesc = null,
            GeometryShaderTraceDesc? geometryShaderTraceDesc = null,
            PixelShaderTraceDesc? pixelShaderTraceDesc = null,
            ComputeShaderTraceDesc? computeShaderTraceDesc = null
        ) : this()
        {
            if (vertexShaderTraceDesc is not null)
            {
                VertexShaderTraceDesc = vertexShaderTraceDesc.Value;
            }

            if (hullShaderTraceDesc is not null)
            {
                HullShaderTraceDesc = hullShaderTraceDesc.Value;
            }

            if (domainShaderTraceDesc is not null)
            {
                DomainShaderTraceDesc = domainShaderTraceDesc.Value;
            }

            if (geometryShaderTraceDesc is not null)
            {
                GeometryShaderTraceDesc = geometryShaderTraceDesc.Value;
            }

            if (pixelShaderTraceDesc is not null)
            {
                PixelShaderTraceDesc = pixelShaderTraceDesc.Value;
            }

            if (computeShaderTraceDesc is not null)
            {
                ComputeShaderTraceDesc = computeShaderTraceDesc.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D11_VERTEX_SHADER_TRACE_DESC")]
        [NativeName("Type.Name", "D3D11_VERTEX_SHADER_TRACE_DESC")]
        [NativeName("Name", "VertexShaderTraceDesc")]
        public VertexShaderTraceDesc VertexShaderTraceDesc;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_HULL_SHADER_TRACE_DESC")]
        [NativeName("Type.Name", "D3D11_HULL_SHADER_TRACE_DESC")]
        [NativeName("Name", "HullShaderTraceDesc")]
        public HullShaderTraceDesc HullShaderTraceDesc;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_DOMAIN_SHADER_TRACE_DESC")]
        [NativeName("Type.Name", "D3D11_DOMAIN_SHADER_TRACE_DESC")]
        [NativeName("Name", "DomainShaderTraceDesc")]
        public DomainShaderTraceDesc DomainShaderTraceDesc;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_GEOMETRY_SHADER_TRACE_DESC")]
        [NativeName("Type.Name", "D3D11_GEOMETRY_SHADER_TRACE_DESC")]
        [NativeName("Name", "GeometryShaderTraceDesc")]
        public GeometryShaderTraceDesc GeometryShaderTraceDesc;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_PIXEL_SHADER_TRACE_DESC")]
        [NativeName("Type.Name", "D3D11_PIXEL_SHADER_TRACE_DESC")]
        [NativeName("Name", "PixelShaderTraceDesc")]
        public PixelShaderTraceDesc PixelShaderTraceDesc;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_COMPUTE_SHADER_TRACE_DESC")]
        [NativeName("Type.Name", "D3D11_COMPUTE_SHADER_TRACE_DESC")]
        [NativeName("Name", "ComputeShaderTraceDesc")]
        public ComputeShaderTraceDesc ComputeShaderTraceDesc;
    }
}
