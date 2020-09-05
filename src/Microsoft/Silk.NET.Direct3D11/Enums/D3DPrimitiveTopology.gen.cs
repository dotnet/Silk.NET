// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D_PRIMITIVE_TOPOLOGY")]
    public enum D3DPrimitiveTopology
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
        PrimitiveTopologyUndefined = 0x0,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_POINTLIST")]
        PrimitiveTopologyPointlist = 0x1,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_LINELIST")]
        PrimitiveTopologyLinelist = 0x2,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_LINESTRIP")]
        PrimitiveTopologyLinestrip = 0x3,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST")]
        PrimitiveTopologyTrianglelist = 0x4,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP")]
        PrimitiveTopologyTrianglestrip = 0x5,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_LINELIST_ADJ")]
        PrimitiveTopologyLinelistAdj = 0xA,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ")]
        PrimitiveTopologyLinestripAdj = 0xB,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ")]
        PrimitiveTopologyTrianglelistAdj = 0xC,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ")]
        PrimitiveTopologyTrianglestripAdj = 0xD,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology1ControlPointPatchlist = 0x21,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology2ControlPointPatchlist = 0x22,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology3ControlPointPatchlist = 0x23,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology4ControlPointPatchlist = 0x24,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology5ControlPointPatchlist = 0x25,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology6ControlPointPatchlist = 0x26,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology7ControlPointPatchlist = 0x27,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology8ControlPointPatchlist = 0x28,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology9ControlPointPatchlist = 0x29,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology10ControlPointPatchlist = 0x2A,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology11ControlPointPatchlist = 0x2B,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology12ControlPointPatchlist = 0x2C,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology13ControlPointPatchlist = 0x2D,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology14ControlPointPatchlist = 0x2E,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology15ControlPointPatchlist = 0x2F,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology16ControlPointPatchlist = 0x30,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology17ControlPointPatchlist = 0x31,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology18ControlPointPatchlist = 0x32,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology19ControlPointPatchlist = 0x33,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology20ControlPointPatchlist = 0x34,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology21ControlPointPatchlist = 0x35,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology22ControlPointPatchlist = 0x36,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology23ControlPointPatchlist = 0x37,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology24ControlPointPatchlist = 0x38,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology25ControlPointPatchlist = 0x39,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology26ControlPointPatchlist = 0x3A,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology27ControlPointPatchlist = 0x3B,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology28ControlPointPatchlist = 0x3C,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology29ControlPointPatchlist = 0x3D,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology30ControlPointPatchlist = 0x3E,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology31ControlPointPatchlist = 0x3F,
        [NativeName("Name", "D3D11_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST")]
        PrimitiveTopology32ControlPointPatchlist = 0x40,
    }
}
