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
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE"]/*'/>
public enum D3DPrimitive
{
    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_UNDEFINED"]/*'/>

    DPrimitiveUndefined = 0,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_POINT"]/*'/>

    DPrimitivePoint = 1,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_LINE"]/*'/>

    DPrimitiveLine = 2,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_TRIANGLE"]/*'/>

    DPrimitiveTriangle = 3,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_LINE_ADJ"]/*'/>

    DPrimitiveLineAdj = 6,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_TRIANGLE_ADJ"]/*'/>

    DPrimitiveTriangleAdj = 7,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_1_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive1ControlPointPatch = 8,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_2_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive2ControlPointPatch = 9,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_3_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive3ControlPointPatch = 10,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_4_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive4ControlPointPatch = 11,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_5_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive5ControlPointPatch = 12,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_6_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive6ControlPointPatch = 13,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_7_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive7ControlPointPatch = 14,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_8_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive8ControlPointPatch = 15,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_9_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive9ControlPointPatch = 16,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_10_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive10ControlPointPatch = 17,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_11_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive11ControlPointPatch = 18,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_12_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive12ControlPointPatch = 19,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_13_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive13ControlPointPatch = 20,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_14_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive14ControlPointPatch = 21,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_15_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive15ControlPointPatch = 22,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_16_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive16ControlPointPatch = 23,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_17_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive17ControlPointPatch = 24,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_18_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive18ControlPointPatch = 25,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_19_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive19ControlPointPatch = 26,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_20_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive20ControlPointPatch = 27,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_21_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive21ControlPointPatch = 28,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_22_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive22ControlPointPatch = 29,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_23_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive23ControlPointPatch = 30,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_24_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive24ControlPointPatch = 31,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_25_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive25ControlPointPatch = 32,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_26_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive26ControlPointPatch = 33,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_27_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive27ControlPointPatch = 34,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_28_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive28ControlPointPatch = 35,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_29_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive29ControlPointPatch = 36,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_30_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive30ControlPointPatch = 37,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_31_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive31ControlPointPatch = 38,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D_PRIMITIVE_32_CONTROL_POINT_PATCH"]/*'/>

    DPrimitive32ControlPointPatch = 39,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D10_PRIMITIVE_UNDEFINED"]/*'/>

    D10PrimitiveUndefined = DPrimitiveUndefined,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D10_PRIMITIVE_POINT"]/*'/>

    D10PrimitivePoint = DPrimitivePoint,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D10_PRIMITIVE_LINE"]/*'/>

    D10PrimitiveLine = DPrimitiveLine,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D10_PRIMITIVE_TRIANGLE"]/*'/>

    D10PrimitiveTriangle = DPrimitiveTriangle,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D10_PRIMITIVE_LINE_ADJ"]/*'/>

    D10PrimitiveLineAdj = DPrimitiveLineAdj,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D10_PRIMITIVE_TRIANGLE_ADJ"]/*'/>

    D10PrimitiveTriangleAdj = DPrimitiveTriangleAdj,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_UNDEFINED"]/*'/>

    D11PrimitiveUndefined = DPrimitiveUndefined,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_POINT"]/*'/>

    D11PrimitivePoint = DPrimitivePoint,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_LINE"]/*'/>

    D11PrimitiveLine = DPrimitiveLine,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_TRIANGLE"]/*'/>

    D11PrimitiveTriangle = DPrimitiveTriangle,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_LINE_ADJ"]/*'/>

    D11PrimitiveLineAdj = DPrimitiveLineAdj,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_TRIANGLE_ADJ"]/*'/>

    D11PrimitiveTriangleAdj = DPrimitiveTriangleAdj,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_1_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive1ControlPointPatch = DPrimitive1ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_2_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive2ControlPointPatch = DPrimitive2ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_3_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive3ControlPointPatch = DPrimitive3ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_4_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive4ControlPointPatch = DPrimitive4ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_5_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive5ControlPointPatch = DPrimitive5ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_6_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive6ControlPointPatch = DPrimitive6ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_7_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive7ControlPointPatch = DPrimitive7ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_8_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive8ControlPointPatch = DPrimitive8ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_9_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive9ControlPointPatch = DPrimitive9ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_10_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive10ControlPointPatch = DPrimitive10ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_11_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive11ControlPointPatch = DPrimitive11ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_12_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive12ControlPointPatch = DPrimitive12ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_13_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive13ControlPointPatch = DPrimitive13ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_14_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive14ControlPointPatch = DPrimitive14ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_15_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive15ControlPointPatch = DPrimitive15ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_16_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive16ControlPointPatch = DPrimitive16ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_17_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive17ControlPointPatch = DPrimitive17ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_18_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive18ControlPointPatch = DPrimitive18ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_19_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive19ControlPointPatch = DPrimitive19ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_20_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive20ControlPointPatch = DPrimitive20ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_21_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive21ControlPointPatch = DPrimitive21ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_22_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive22ControlPointPatch = DPrimitive22ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_23_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive23ControlPointPatch = DPrimitive23ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_24_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive24ControlPointPatch = DPrimitive24ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_25_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive25ControlPointPatch = DPrimitive25ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_26_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive26ControlPointPatch = DPrimitive26ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_27_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive27ControlPointPatch = DPrimitive27ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_28_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive28ControlPointPatch = DPrimitive28ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_29_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive29ControlPointPatch = DPrimitive29ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_30_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive30ControlPointPatch = DPrimitive30ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_31_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive31ControlPointPatch = DPrimitive31ControlPointPatch,

    /// <include file='D3D_PRIMITIVE.xml' path='doc/member[@name="D3D_PRIMITIVE.D3D11_PRIMITIVE_32_CONTROL_POINT_PATCH"]/*'/>

    D11Primitive32ControlPointPatch = DPrimitive32ControlPointPatch,
}
