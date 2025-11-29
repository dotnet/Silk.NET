// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME"]/*'/>
public enum D3DName
{
    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_UNDEFINED"]/*'/>

    DNameUndefined = 0,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_POSITION"]/*'/>

    DNamePosition = 1,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_CLIP_DISTANCE"]/*'/>

    DNameClipDistance = 2,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_CULL_DISTANCE"]/*'/>

    DNameCullDistance = 3,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_RENDER_TARGET_ARRAY_INDEX"]/*'/>

    DNameRenderTargetArrayIndex = 4,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_VIEWPORT_ARRAY_INDEX"]/*'/>

    DNameViewportArrayIndex = 5,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_VERTEX_ID"]/*'/>

    DNameVertexId = 6,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_PRIMITIVE_ID"]/*'/>

    DNamePrimitiveId = 7,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_INSTANCE_ID"]/*'/>

    DNameInstanceId = 8,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_IS_FRONT_FACE"]/*'/>

    DNameIsFrontFace = 9,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_SAMPLE_INDEX"]/*'/>

    DNameSampleIndex = 10,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_FINAL_QUAD_EDGE_TESSFACTOR"]/*'/>

    DNameFinalQuadEdgeTessfactor = 11,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_FINAL_QUAD_INSIDE_TESSFACTOR"]/*'/>

    DNameFinalQuadInsideTessfactor = 12,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_FINAL_TRI_EDGE_TESSFACTOR"]/*'/>

    DNameFinalTriEdgeTessfactor = 13,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_FINAL_TRI_INSIDE_TESSFACTOR"]/*'/>

    DNameFinalTriInsideTessfactor = 14,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_FINAL_LINE_DETAIL_TESSFACTOR"]/*'/>

    DNameFinalLineDetailTessfactor = 15,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_FINAL_LINE_DENSITY_TESSFACTOR"]/*'/>

    DNameFinalLineDensityTessfactor = 16,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_BARYCENTRICS"]/*'/>

    DNameBarycentrics = 23,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_SHADINGRATE"]/*'/>

    DNameShadingrate = 24,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_CULLPRIMITIVE"]/*'/>

    DNameCullprimitive = 25,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_TARGET"]/*'/>

    DNameTarget = 64,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_DEPTH"]/*'/>

    DNameDepth = 65,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_COVERAGE"]/*'/>

    DNameCoverage = 66,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_DEPTH_GREATER_EQUAL"]/*'/>

    DNameDepthGreaterEqual = 67,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_DEPTH_LESS_EQUAL"]/*'/>

    DNameDepthLessEqual = 68,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_STENCIL_REF"]/*'/>

    DNameStencilRef = 69,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_INNER_COVERAGE"]/*'/>

    DNameInnerCoverage = 70,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_UNDEFINED"]/*'/>

    D10NameUndefined = DNameUndefined,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_POSITION"]/*'/>

    D10NamePosition = DNamePosition,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_CLIP_DISTANCE"]/*'/>

    D10NameClipDistance = DNameClipDistance,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_CULL_DISTANCE"]/*'/>

    D10NameCullDistance = DNameCullDistance,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_RENDER_TARGET_ARRAY_INDEX"]/*'/>

    D10NameRenderTargetArrayIndex = DNameRenderTargetArrayIndex,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_VIEWPORT_ARRAY_INDEX"]/*'/>

    D10NameViewportArrayIndex = DNameViewportArrayIndex,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_VERTEX_ID"]/*'/>

    D10NameVertexId = DNameVertexId,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_PRIMITIVE_ID"]/*'/>

    D10NamePrimitiveId = DNamePrimitiveId,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_INSTANCE_ID"]/*'/>

    D10NameInstanceId = DNameInstanceId,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_IS_FRONT_FACE"]/*'/>

    D10NameIsFrontFace = DNameIsFrontFace,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_SAMPLE_INDEX"]/*'/>

    D10NameSampleIndex = DNameSampleIndex,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_TARGET"]/*'/>

    D10NameTarget = DNameTarget,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_DEPTH"]/*'/>

    D10NameDepth = DNameDepth,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_COVERAGE"]/*'/>

    D10NameCoverage = DNameCoverage,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_FINAL_QUAD_EDGE_TESSFACTOR"]/*'/>

    D11NameFinalQuadEdgeTessfactor = DNameFinalQuadEdgeTessfactor,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_FINAL_QUAD_INSIDE_TESSFACTOR"]/*'/>

    D11NameFinalQuadInsideTessfactor = DNameFinalQuadInsideTessfactor,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_FINAL_TRI_EDGE_TESSFACTOR"]/*'/>

    D11NameFinalTriEdgeTessfactor = DNameFinalTriEdgeTessfactor,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_FINAL_TRI_INSIDE_TESSFACTOR"]/*'/>

    D11NameFinalTriInsideTessfactor = DNameFinalTriInsideTessfactor,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_FINAL_LINE_DETAIL_TESSFACTOR"]/*'/>

    D11NameFinalLineDetailTessfactor = DNameFinalLineDetailTessfactor,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_FINAL_LINE_DENSITY_TESSFACTOR"]/*'/>

    D11NameFinalLineDensityTessfactor = DNameFinalLineDensityTessfactor,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_DEPTH_GREATER_EQUAL"]/*'/>

    D11NameDepthGreaterEqual = DNameDepthGreaterEqual,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_DEPTH_LESS_EQUAL"]/*'/>

    D11NameDepthLessEqual = DNameDepthLessEqual,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_STENCIL_REF"]/*'/>

    D11NameStencilRef = DNameStencilRef,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_INNER_COVERAGE"]/*'/>

    D11NameInnerCoverage = DNameInnerCoverage,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D12_NAME_BARYCENTRICS"]/*'/>

    D12NameBarycentrics = DNameBarycentrics,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D12_NAME_SHADINGRATE"]/*'/>

    D12NameShadingrate = DNameShadingrate,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D12_NAME_CULLPRIMITIVE"]/*'/>

    D12NameCullprimitive = DNameCullprimitive,
}
