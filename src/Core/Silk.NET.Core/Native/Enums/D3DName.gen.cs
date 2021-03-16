// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_NAME")]
    public enum D3DName : int
    {
        [NativeName("Name", "D3D_NAME_UNDEFINED")]
        D3DNameUndefined = 0x0,
        [NativeName("Name", "D3D_NAME_POSITION")]
        D3DNamePosition = 0x1,
        [NativeName("Name", "D3D_NAME_CLIP_DISTANCE")]
        D3DNameClipDistance = 0x2,
        [NativeName("Name", "D3D_NAME_CULL_DISTANCE")]
        D3DNameCullDistance = 0x3,
        [NativeName("Name", "D3D_NAME_RENDER_TARGET_ARRAY_INDEX")]
        D3DNameRenderTargetArrayIndex = 0x4,
        [NativeName("Name", "D3D_NAME_VIEWPORT_ARRAY_INDEX")]
        D3DNameViewportArrayIndex = 0x5,
        [NativeName("Name", "D3D_NAME_VERTEX_ID")]
        D3DNameVertexID = 0x6,
        [NativeName("Name", "D3D_NAME_PRIMITIVE_ID")]
        D3DNamePrimitiveID = 0x7,
        [NativeName("Name", "D3D_NAME_INSTANCE_ID")]
        D3DNameInstanceID = 0x8,
        [NativeName("Name", "D3D_NAME_IS_FRONT_FACE")]
        D3DNameIsFrontFace = 0x9,
        [NativeName("Name", "D3D_NAME_SAMPLE_INDEX")]
        D3DNameSampleIndex = 0xA,
        [NativeName("Name", "D3D_NAME_FINAL_QUAD_EDGE_TESSFACTOR")]
        D3DNameFinalQuadEdgeTessfactor = 0xB,
        [NativeName("Name", "D3D_NAME_FINAL_QUAD_INSIDE_TESSFACTOR")]
        D3DNameFinalQuadInsideTessfactor = 0xC,
        [NativeName("Name", "D3D_NAME_FINAL_TRI_EDGE_TESSFACTOR")]
        D3DNameFinalTriEdgeTessfactor = 0xD,
        [NativeName("Name", "D3D_NAME_FINAL_TRI_INSIDE_TESSFACTOR")]
        D3DNameFinalTriInsideTessfactor = 0xE,
        [NativeName("Name", "D3D_NAME_FINAL_LINE_DETAIL_TESSFACTOR")]
        D3DNameFinalLineDetailTessfactor = 0xF,
        [NativeName("Name", "D3D_NAME_FINAL_LINE_DENSITY_TESSFACTOR")]
        D3DNameFinalLineDensityTessfactor = 0x10,
        [NativeName("Name", "D3D_NAME_BARYCENTRICS")]
        D3DNameBarycentrics = 0x17,
        [NativeName("Name", "D3D_NAME_SHADINGRATE")]
        D3DNameShadingrate = 0x18,
        [NativeName("Name", "D3D_NAME_CULLPRIMITIVE")]
        D3DNameCullprimitive = 0x19,
        [NativeName("Name", "D3D_NAME_TARGET")]
        D3DNameTarget = 0x40,
        [NativeName("Name", "D3D_NAME_DEPTH")]
        D3DNameDepth = 0x41,
        [NativeName("Name", "D3D_NAME_COVERAGE")]
        D3DNameCoverage = 0x42,
        [NativeName("Name", "D3D_NAME_DEPTH_GREATER_EQUAL")]
        D3DNameDepthGreaterEqual = 0x43,
        [NativeName("Name", "D3D_NAME_DEPTH_LESS_EQUAL")]
        D3DNameDepthLessEqual = 0x44,
        [NativeName("Name", "D3D_NAME_STENCIL_REF")]
        D3DNameStencilRef = 0x45,
        [NativeName("Name", "D3D_NAME_INNER_COVERAGE")]
        D3DNameInnerCoverage = 0x46,
        [NativeName("Name", "D3D10_NAME_UNDEFINED")]
        D3D10NameUndefined = 0x0,
        [NativeName("Name", "D3D10_NAME_POSITION")]
        D3D10NamePosition = 0x1,
        [NativeName("Name", "D3D10_NAME_CLIP_DISTANCE")]
        D3D10NameClipDistance = 0x2,
        [NativeName("Name", "D3D10_NAME_CULL_DISTANCE")]
        D3D10NameCullDistance = 0x3,
        [NativeName("Name", "D3D10_NAME_RENDER_TARGET_ARRAY_INDEX")]
        D3D10NameRenderTargetArrayIndex = 0x4,
        [NativeName("Name", "D3D10_NAME_VIEWPORT_ARRAY_INDEX")]
        D3D10NameViewportArrayIndex = 0x5,
        [NativeName("Name", "D3D10_NAME_VERTEX_ID")]
        D3D10NameVertexID = 0x6,
        [NativeName("Name", "D3D10_NAME_PRIMITIVE_ID")]
        D3D10NamePrimitiveID = 0x7,
        [NativeName("Name", "D3D10_NAME_INSTANCE_ID")]
        D3D10NameInstanceID = 0x8,
        [NativeName("Name", "D3D10_NAME_IS_FRONT_FACE")]
        D3D10NameIsFrontFace = 0x9,
        [NativeName("Name", "D3D10_NAME_SAMPLE_INDEX")]
        D3D10NameSampleIndex = 0xA,
        [NativeName("Name", "D3D10_NAME_TARGET")]
        D3D10NameTarget = 0x40,
        [NativeName("Name", "D3D10_NAME_DEPTH")]
        D3D10NameDepth = 0x41,
        [NativeName("Name", "D3D10_NAME_COVERAGE")]
        D3D10NameCoverage = 0x42,
        [NativeName("Name", "D3D11_NAME_FINAL_QUAD_EDGE_TESSFACTOR")]
        D3D11NameFinalQuadEdgeTessfactor = 0xB,
        [NativeName("Name", "D3D11_NAME_FINAL_QUAD_INSIDE_TESSFACTOR")]
        D3D11NameFinalQuadInsideTessfactor = 0xC,
        [NativeName("Name", "D3D11_NAME_FINAL_TRI_EDGE_TESSFACTOR")]
        D3D11NameFinalTriEdgeTessfactor = 0xD,
        [NativeName("Name", "D3D11_NAME_FINAL_TRI_INSIDE_TESSFACTOR")]
        D3D11NameFinalTriInsideTessfactor = 0xE,
        [NativeName("Name", "D3D11_NAME_FINAL_LINE_DETAIL_TESSFACTOR")]
        D3D11NameFinalLineDetailTessfactor = 0xF,
        [NativeName("Name", "D3D11_NAME_FINAL_LINE_DENSITY_TESSFACTOR")]
        D3D11NameFinalLineDensityTessfactor = 0x10,
        [NativeName("Name", "D3D11_NAME_DEPTH_GREATER_EQUAL")]
        D3D11NameDepthGreaterEqual = 0x43,
        [NativeName("Name", "D3D11_NAME_DEPTH_LESS_EQUAL")]
        D3D11NameDepthLessEqual = 0x44,
        [NativeName("Name", "D3D11_NAME_STENCIL_REF")]
        D3D11NameStencilRef = 0x45,
        [NativeName("Name", "D3D11_NAME_INNER_COVERAGE")]
        D3D11NameInnerCoverage = 0x46,
        [NativeName("Name", "D3D12_NAME_BARYCENTRICS")]
        D3D12NameBarycentrics = 0x17,
        [NativeName("Name", "D3D12_NAME_SHADINGRATE")]
        D3D12NameShadingrate = 0x18,
        [NativeName("Name", "D3D12_NAME_CULLPRIMITIVE")]
        D3D12NameCullprimitive = 0x19,
    }
}
