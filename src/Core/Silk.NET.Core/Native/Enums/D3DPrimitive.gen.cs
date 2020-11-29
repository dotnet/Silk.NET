// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_PRIMITIVE")]
    public enum D3DPrimitive
    {
        [NativeName("Name", "D3D_PRIMITIVE_UNDEFINED")]
        D3DPrimitiveUndefined = 0x0,
        [NativeName("Name", "D3D_PRIMITIVE_POINT")]
        D3DPrimitivePoint = 0x1,
        [NativeName("Name", "D3D_PRIMITIVE_LINE")]
        D3DPrimitiveLine = 0x2,
        [NativeName("Name", "D3D_PRIMITIVE_TRIANGLE")]
        D3DPrimitiveTriangle = 0x3,
        [NativeName("Name", "D3D_PRIMITIVE_LINE_ADJ")]
        D3DPrimitiveLineAdj = 0x6,
        [NativeName("Name", "D3D_PRIMITIVE_TRIANGLE_ADJ")]
        D3DPrimitiveTriangleAdj = 0x7,
        [NativeName("Name", "D3D_PRIMITIVE_1_CONTROL_POINT_PATCH")]
        D3DPrimitive1ControlPointPatch = 0x8,
        [NativeName("Name", "D3D_PRIMITIVE_2_CONTROL_POINT_PATCH")]
        D3DPrimitive2ControlPointPatch = 0x9,
        [NativeName("Name", "D3D_PRIMITIVE_3_CONTROL_POINT_PATCH")]
        D3DPrimitive3ControlPointPatch = 0xA,
        [NativeName("Name", "D3D_PRIMITIVE_4_CONTROL_POINT_PATCH")]
        D3DPrimitive4ControlPointPatch = 0xB,
        [NativeName("Name", "D3D_PRIMITIVE_5_CONTROL_POINT_PATCH")]
        D3DPrimitive5ControlPointPatch = 0xC,
        [NativeName("Name", "D3D_PRIMITIVE_6_CONTROL_POINT_PATCH")]
        D3DPrimitive6ControlPointPatch = 0xD,
        [NativeName("Name", "D3D_PRIMITIVE_7_CONTROL_POINT_PATCH")]
        D3DPrimitive7ControlPointPatch = 0xE,
        [NativeName("Name", "D3D_PRIMITIVE_8_CONTROL_POINT_PATCH")]
        D3DPrimitive8ControlPointPatch = 0xF,
        [NativeName("Name", "D3D_PRIMITIVE_9_CONTROL_POINT_PATCH")]
        D3DPrimitive9ControlPointPatch = 0x10,
        [NativeName("Name", "D3D_PRIMITIVE_10_CONTROL_POINT_PATCH")]
        D3DPrimitive10ControlPointPatch = 0x11,
        [NativeName("Name", "D3D_PRIMITIVE_11_CONTROL_POINT_PATCH")]
        D3DPrimitive11ControlPointPatch = 0x12,
        [NativeName("Name", "D3D_PRIMITIVE_12_CONTROL_POINT_PATCH")]
        D3DPrimitive12ControlPointPatch = 0x13,
        [NativeName("Name", "D3D_PRIMITIVE_13_CONTROL_POINT_PATCH")]
        D3DPrimitive13ControlPointPatch = 0x14,
        [NativeName("Name", "D3D_PRIMITIVE_14_CONTROL_POINT_PATCH")]
        D3DPrimitive14ControlPointPatch = 0x15,
        [NativeName("Name", "D3D_PRIMITIVE_15_CONTROL_POINT_PATCH")]
        D3DPrimitive15ControlPointPatch = 0x16,
        [NativeName("Name", "D3D_PRIMITIVE_16_CONTROL_POINT_PATCH")]
        D3DPrimitive16ControlPointPatch = 0x17,
        [NativeName("Name", "D3D_PRIMITIVE_17_CONTROL_POINT_PATCH")]
        D3DPrimitive17ControlPointPatch = 0x18,
        [NativeName("Name", "D3D_PRIMITIVE_18_CONTROL_POINT_PATCH")]
        D3DPrimitive18ControlPointPatch = 0x19,
        [NativeName("Name", "D3D_PRIMITIVE_19_CONTROL_POINT_PATCH")]
        D3DPrimitive19ControlPointPatch = 0x1A,
        [NativeName("Name", "D3D_PRIMITIVE_20_CONTROL_POINT_PATCH")]
        D3DPrimitive20ControlPointPatch = 0x1B,
        [NativeName("Name", "D3D_PRIMITIVE_21_CONTROL_POINT_PATCH")]
        D3DPrimitive21ControlPointPatch = 0x1C,
        [NativeName("Name", "D3D_PRIMITIVE_22_CONTROL_POINT_PATCH")]
        D3DPrimitive22ControlPointPatch = 0x1D,
        [NativeName("Name", "D3D_PRIMITIVE_23_CONTROL_POINT_PATCH")]
        D3DPrimitive23ControlPointPatch = 0x1E,
        [NativeName("Name", "D3D_PRIMITIVE_24_CONTROL_POINT_PATCH")]
        D3DPrimitive24ControlPointPatch = 0x1F,
        [NativeName("Name", "D3D_PRIMITIVE_25_CONTROL_POINT_PATCH")]
        D3DPrimitive25ControlPointPatch = 0x20,
        [NativeName("Name", "D3D_PRIMITIVE_26_CONTROL_POINT_PATCH")]
        D3DPrimitive26ControlPointPatch = 0x21,
        [NativeName("Name", "D3D_PRIMITIVE_27_CONTROL_POINT_PATCH")]
        D3DPrimitive27ControlPointPatch = 0x22,
        [NativeName("Name", "D3D_PRIMITIVE_28_CONTROL_POINT_PATCH")]
        D3DPrimitive28ControlPointPatch = 0x23,
        [NativeName("Name", "D3D_PRIMITIVE_29_CONTROL_POINT_PATCH")]
        D3DPrimitive29ControlPointPatch = 0x24,
        [NativeName("Name", "D3D_PRIMITIVE_30_CONTROL_POINT_PATCH")]
        D3DPrimitive30ControlPointPatch = 0x25,
        [NativeName("Name", "D3D_PRIMITIVE_31_CONTROL_POINT_PATCH")]
        D3DPrimitive31ControlPointPatch = 0x26,
        [NativeName("Name", "D3D_PRIMITIVE_32_CONTROL_POINT_PATCH")]
        D3DPrimitive32ControlPointPatch = 0x27,
        [NativeName("Name", "D3D10_PRIMITIVE_UNDEFINED")]
        D3D10PrimitiveUndefined = 0x0,
        [NativeName("Name", "D3D10_PRIMITIVE_POINT")]
        D3D10PrimitivePoint = 0x1,
        [NativeName("Name", "D3D10_PRIMITIVE_LINE")]
        D3D10PrimitiveLine = 0x2,
        [NativeName("Name", "D3D10_PRIMITIVE_TRIANGLE")]
        D3D10PrimitiveTriangle = 0x3,
        [NativeName("Name", "D3D10_PRIMITIVE_LINE_ADJ")]
        D3D10PrimitiveLineAdj = 0x6,
        [NativeName("Name", "D3D10_PRIMITIVE_TRIANGLE_ADJ")]
        D3D10PrimitiveTriangleAdj = 0x7,
        [NativeName("Name", "D3D11_PRIMITIVE_UNDEFINED")]
        D3D11PrimitiveUndefined = 0x0,
        [NativeName("Name", "D3D11_PRIMITIVE_POINT")]
        D3D11PrimitivePoint = 0x1,
        [NativeName("Name", "D3D11_PRIMITIVE_LINE")]
        D3D11PrimitiveLine = 0x2,
        [NativeName("Name", "D3D11_PRIMITIVE_TRIANGLE")]
        D3D11PrimitiveTriangle = 0x3,
        [NativeName("Name", "D3D11_PRIMITIVE_LINE_ADJ")]
        D3D11PrimitiveLineAdj = 0x6,
        [NativeName("Name", "D3D11_PRIMITIVE_TRIANGLE_ADJ")]
        D3D11PrimitiveTriangleAdj = 0x7,
        [NativeName("Name", "D3D11_PRIMITIVE_1_CONTROL_POINT_PATCH")]
        D3D11Primitive1ControlPointPatch = 0x8,
        [NativeName("Name", "D3D11_PRIMITIVE_2_CONTROL_POINT_PATCH")]
        D3D11Primitive2ControlPointPatch = 0x9,
        [NativeName("Name", "D3D11_PRIMITIVE_3_CONTROL_POINT_PATCH")]
        D3D11Primitive3ControlPointPatch = 0xA,
        [NativeName("Name", "D3D11_PRIMITIVE_4_CONTROL_POINT_PATCH")]
        D3D11Primitive4ControlPointPatch = 0xB,
        [NativeName("Name", "D3D11_PRIMITIVE_5_CONTROL_POINT_PATCH")]
        D3D11Primitive5ControlPointPatch = 0xC,
        [NativeName("Name", "D3D11_PRIMITIVE_6_CONTROL_POINT_PATCH")]
        D3D11Primitive6ControlPointPatch = 0xD,
        [NativeName("Name", "D3D11_PRIMITIVE_7_CONTROL_POINT_PATCH")]
        D3D11Primitive7ControlPointPatch = 0xE,
        [NativeName("Name", "D3D11_PRIMITIVE_8_CONTROL_POINT_PATCH")]
        D3D11Primitive8ControlPointPatch = 0xF,
        [NativeName("Name", "D3D11_PRIMITIVE_9_CONTROL_POINT_PATCH")]
        D3D11Primitive9ControlPointPatch = 0x10,
        [NativeName("Name", "D3D11_PRIMITIVE_10_CONTROL_POINT_PATCH")]
        D3D11Primitive10ControlPointPatch = 0x11,
        [NativeName("Name", "D3D11_PRIMITIVE_11_CONTROL_POINT_PATCH")]
        D3D11Primitive11ControlPointPatch = 0x12,
        [NativeName("Name", "D3D11_PRIMITIVE_12_CONTROL_POINT_PATCH")]
        D3D11Primitive12ControlPointPatch = 0x13,
        [NativeName("Name", "D3D11_PRIMITIVE_13_CONTROL_POINT_PATCH")]
        D3D11Primitive13ControlPointPatch = 0x14,
        [NativeName("Name", "D3D11_PRIMITIVE_14_CONTROL_POINT_PATCH")]
        D3D11Primitive14ControlPointPatch = 0x15,
        [NativeName("Name", "D3D11_PRIMITIVE_15_CONTROL_POINT_PATCH")]
        D3D11Primitive15ControlPointPatch = 0x16,
        [NativeName("Name", "D3D11_PRIMITIVE_16_CONTROL_POINT_PATCH")]
        D3D11Primitive16ControlPointPatch = 0x17,
        [NativeName("Name", "D3D11_PRIMITIVE_17_CONTROL_POINT_PATCH")]
        D3D11Primitive17ControlPointPatch = 0x18,
        [NativeName("Name", "D3D11_PRIMITIVE_18_CONTROL_POINT_PATCH")]
        D3D11Primitive18ControlPointPatch = 0x19,
        [NativeName("Name", "D3D11_PRIMITIVE_19_CONTROL_POINT_PATCH")]
        D3D11Primitive19ControlPointPatch = 0x1A,
        [NativeName("Name", "D3D11_PRIMITIVE_20_CONTROL_POINT_PATCH")]
        D3D11Primitive20ControlPointPatch = 0x1B,
        [NativeName("Name", "D3D11_PRIMITIVE_21_CONTROL_POINT_PATCH")]
        D3D11Primitive21ControlPointPatch = 0x1C,
        [NativeName("Name", "D3D11_PRIMITIVE_22_CONTROL_POINT_PATCH")]
        D3D11Primitive22ControlPointPatch = 0x1D,
        [NativeName("Name", "D3D11_PRIMITIVE_23_CONTROL_POINT_PATCH")]
        D3D11Primitive23ControlPointPatch = 0x1E,
        [NativeName("Name", "D3D11_PRIMITIVE_24_CONTROL_POINT_PATCH")]
        D3D11Primitive24ControlPointPatch = 0x1F,
        [NativeName("Name", "D3D11_PRIMITIVE_25_CONTROL_POINT_PATCH")]
        D3D11Primitive25ControlPointPatch = 0x20,
        [NativeName("Name", "D3D11_PRIMITIVE_26_CONTROL_POINT_PATCH")]
        D3D11Primitive26ControlPointPatch = 0x21,
        [NativeName("Name", "D3D11_PRIMITIVE_27_CONTROL_POINT_PATCH")]
        D3D11Primitive27ControlPointPatch = 0x22,
        [NativeName("Name", "D3D11_PRIMITIVE_28_CONTROL_POINT_PATCH")]
        D3D11Primitive28ControlPointPatch = 0x23,
        [NativeName("Name", "D3D11_PRIMITIVE_29_CONTROL_POINT_PATCH")]
        D3D11Primitive29ControlPointPatch = 0x24,
        [NativeName("Name", "D3D11_PRIMITIVE_30_CONTROL_POINT_PATCH")]
        D3D11Primitive30ControlPointPatch = 0x25,
        [NativeName("Name", "D3D11_PRIMITIVE_31_CONTROL_POINT_PATCH")]
        D3D11Primitive31ControlPointPatch = 0x26,
        [NativeName("Name", "D3D11_PRIMITIVE_32_CONTROL_POINT_PATCH")]
        D3D11Primitive32ControlPointPatch = 0x27,
    }
}
