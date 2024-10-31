// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY")]
    public enum D3DPrimitiveTopology : int
    {
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_UNDEFINED")]
        D3DPrimitiveTopologyUndefined = 0x0,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_POINTLIST")]
        D3DPrimitiveTopologyPointlist = 0x1,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_LINELIST")]
        D3DPrimitiveTopologyLinelist = 0x2,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_LINESTRIP")]
        D3DPrimitiveTopologyLinestrip = 0x3,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST")]
        D3DPrimitiveTopologyTrianglelist = 0x4,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP")]
        D3DPrimitiveTopologyTrianglestrip = 0x5,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_TRIANGLEFAN")]
        D3DPrimitiveTopologyTrianglefan = 0x6,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_LINELIST_ADJ")]
        D3DPrimitiveTopologyLinelistAdj = 0xA,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ")]
        D3DPrimitiveTopologyLinestripAdj = 0xB,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ")]
        D3DPrimitiveTopologyTrianglelistAdj = 0xC,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ")]
        D3DPrimitiveTopologyTrianglestripAdj = 0xD,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology1ControlPointPatchlist = 0x21,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology2ControlPointPatchlist = 0x22,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology3ControlPointPatchlist = 0x23,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology4ControlPointPatchlist = 0x24,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology5ControlPointPatchlist = 0x25,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology6ControlPointPatchlist = 0x26,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology7ControlPointPatchlist = 0x27,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology8ControlPointPatchlist = 0x28,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology9ControlPointPatchlist = 0x29,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology10ControlPointPatchlist = 0x2A,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology11ControlPointPatchlist = 0x2B,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology12ControlPointPatchlist = 0x2C,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology13ControlPointPatchlist = 0x2D,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology14ControlPointPatchlist = 0x2E,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology15ControlPointPatchlist = 0x2F,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology16ControlPointPatchlist = 0x30,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology17ControlPointPatchlist = 0x31,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology18ControlPointPatchlist = 0x32,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology19ControlPointPatchlist = 0x33,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology20ControlPointPatchlist = 0x34,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology21ControlPointPatchlist = 0x35,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology22ControlPointPatchlist = 0x36,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology23ControlPointPatchlist = 0x37,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology24ControlPointPatchlist = 0x38,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology25ControlPointPatchlist = 0x39,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology26ControlPointPatchlist = 0x3A,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology27ControlPointPatchlist = 0x3B,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology28ControlPointPatchlist = 0x3C,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology29ControlPointPatchlist = 0x3D,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology30ControlPointPatchlist = 0x3E,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology31ControlPointPatchlist = 0x3F,
        [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST")]
        D3DPrimitiveTopology32ControlPointPatchlist = 0x40,
        [NativeName("Name", "D3D10_PRIMITIVE_TOPOLOGY_UNDEFINED")]
        D3D10PrimitiveTopologyUndefined = 0x0,
        [NativeName("Name", "D3D10_PRIMITIVE_TOPOLOGY_POINTLIST")]
        D3D10PrimitiveTopologyPointlist = 0x1,
        [NativeName("Name", "D3D10_PRIMITIVE_TOPOLOGY_LINELIST")]
        D3D10PrimitiveTopologyLinelist = 0x2,
        [NativeName("Name", "D3D10_PRIMITIVE_TOPOLOGY_LINESTRIP")]
        D3D10PrimitiveTopologyLinestrip = 0x3,
        [NativeName("Name", "D3D10_PRIMITIVE_TOPOLOGY_TRIANGLELIST")]
        D3D10PrimitiveTopologyTrianglelist = 0x4,
        [NativeName("Name", "D3D10_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP")]
        D3D10PrimitiveTopologyTrianglestrip = 0x5,
        [NativeName("Name", "D3D10_PRIMITIVE_TOPOLOGY_LINELIST_ADJ")]
        D3D10PrimitiveTopologyLinelistAdj = 0xA,
        [NativeName("Name", "D3D10_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ")]
        D3D10PrimitiveTopologyLinestripAdj = 0xB,
        [NativeName("Name", "D3D10_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ")]
        D3D10PrimitiveTopologyTrianglelistAdj = 0xC,
        [NativeName("Name", "D3D10_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ")]
        D3D10PrimitiveTopologyTrianglestripAdj = 0xD,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_UNDEFINED")]
        D3D11PrimitiveTopologyUndefined = 0x0,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_POINTLIST")]
        D3D11PrimitiveTopologyPointlist = 0x1,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_LINELIST")]
        D3D11PrimitiveTopologyLinelist = 0x2,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_LINESTRIP")]
        D3D11PrimitiveTopologyLinestrip = 0x3,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST")]
        D3D11PrimitiveTopologyTrianglelist = 0x4,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP")]
        D3D11PrimitiveTopologyTrianglestrip = 0x5,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_LINELIST_ADJ")]
        D3D11PrimitiveTopologyLinelistAdj = 0xA,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ")]
        D3D11PrimitiveTopologyLinestripAdj = 0xB,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ")]
        D3D11PrimitiveTopologyTrianglelistAdj = 0xC,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ")]
        D3D11PrimitiveTopologyTrianglestripAdj = 0xD,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology1ControlPointPatchlist = 0x21,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology2ControlPointPatchlist = 0x22,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology3ControlPointPatchlist = 0x23,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology4ControlPointPatchlist = 0x24,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology5ControlPointPatchlist = 0x25,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology6ControlPointPatchlist = 0x26,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology7ControlPointPatchlist = 0x27,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology8ControlPointPatchlist = 0x28,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology9ControlPointPatchlist = 0x29,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology10ControlPointPatchlist = 0x2A,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology11ControlPointPatchlist = 0x2B,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology12ControlPointPatchlist = 0x2C,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology13ControlPointPatchlist = 0x2D,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology14ControlPointPatchlist = 0x2E,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology15ControlPointPatchlist = 0x2F,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology16ControlPointPatchlist = 0x30,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology17ControlPointPatchlist = 0x31,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology18ControlPointPatchlist = 0x32,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology19ControlPointPatchlist = 0x33,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology20ControlPointPatchlist = 0x34,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology21ControlPointPatchlist = 0x35,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology22ControlPointPatchlist = 0x36,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology23ControlPointPatchlist = 0x37,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology24ControlPointPatchlist = 0x38,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology25ControlPointPatchlist = 0x39,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology26ControlPointPatchlist = 0x3A,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology27ControlPointPatchlist = 0x3B,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology28ControlPointPatchlist = 0x3C,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology29ControlPointPatchlist = 0x3D,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology30ControlPointPatchlist = 0x3E,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology31ControlPointPatchlist = 0x3F,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST")]
        D3D11PrimitiveTopology32ControlPointPatchlist = 0x40,
    }
}
