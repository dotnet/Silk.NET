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

/// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY"]/*'/>
public enum D3DPrimitiveTopology
{
    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_UNDEFINED"]/*'/>

    DPrimitiveTopologyUndefined = 0,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_POINTLIST"]/*'/>

    DPrimitiveTopologyPointlist = 1,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_LINELIST"]/*'/>

    DPrimitiveTopologyLinelist = 2,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_LINESTRIP"]/*'/>

    DPrimitiveTopologyLinestrip = 3,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST"]/*'/>

    DPrimitiveTopologyTrianglelist = 4,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP"]/*'/>

    DPrimitiveTopologyTrianglestrip = 5,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_TRIANGLEFAN"]/*'/>

    DPrimitiveTopologyTrianglefan = 6,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_LINELIST_ADJ"]/*'/>

    DPrimitiveTopologyLinelistAdj = 10,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ"]/*'/>

    DPrimitiveTopologyLinestripAdj = 11,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ"]/*'/>

    DPrimitiveTopologyTrianglelistAdj = 12,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ"]/*'/>

    DPrimitiveTopologyTrianglestripAdj = 13,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology1ControlPointPatchlist = 33,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology2ControlPointPatchlist = 34,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology3ControlPointPatchlist = 35,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology4ControlPointPatchlist = 36,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology5ControlPointPatchlist = 37,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology6ControlPointPatchlist = 38,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology7ControlPointPatchlist = 39,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology8ControlPointPatchlist = 40,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology9ControlPointPatchlist = 41,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology10ControlPointPatchlist = 42,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology11ControlPointPatchlist = 43,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology12ControlPointPatchlist = 44,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology13ControlPointPatchlist = 45,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology14ControlPointPatchlist = 46,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology15ControlPointPatchlist = 47,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology16ControlPointPatchlist = 48,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology17ControlPointPatchlist = 49,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology18ControlPointPatchlist = 50,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology19ControlPointPatchlist = 51,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology20ControlPointPatchlist = 52,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology21ControlPointPatchlist = 53,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology22ControlPointPatchlist = 54,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology23ControlPointPatchlist = 55,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology24ControlPointPatchlist = 56,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology25ControlPointPatchlist = 57,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology26ControlPointPatchlist = 58,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology27ControlPointPatchlist = 59,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology28ControlPointPatchlist = 60,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology29ControlPointPatchlist = 61,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology30ControlPointPatchlist = 62,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology31ControlPointPatchlist = 63,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST"]/*'/>

    DPrimitiveTopology32ControlPointPatchlist = 64,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_UNDEFINED"]/*'/>

    D10PrimitiveTopologyUndefined = DPrimitiveTopologyUndefined,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_POINTLIST"]/*'/>

    D10PrimitiveTopologyPointlist = DPrimitiveTopologyPointlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_LINELIST"]/*'/>

    D10PrimitiveTopologyLinelist = DPrimitiveTopologyLinelist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_LINESTRIP"]/*'/>

    D10PrimitiveTopologyLinestrip = DPrimitiveTopologyLinestrip,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_TRIANGLELIST"]/*'/>

    D10PrimitiveTopologyTrianglelist = DPrimitiveTopologyTrianglelist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP"]/*'/>

    D10PrimitiveTopologyTrianglestrip = DPrimitiveTopologyTrianglestrip,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_LINELIST_ADJ"]/*'/>

    D10PrimitiveTopologyLinelistAdj = DPrimitiveTopologyLinelistAdj,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ"]/*'/>

    D10PrimitiveTopologyLinestripAdj = DPrimitiveTopologyLinestripAdj,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ"]/*'/>

    D10PrimitiveTopologyTrianglelistAdj = DPrimitiveTopologyTrianglelistAdj,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ"]/*'/>

    D10PrimitiveTopologyTrianglestripAdj = DPrimitiveTopologyTrianglestripAdj,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_UNDEFINED"]/*'/>

    D11PrimitiveTopologyUndefined = DPrimitiveTopologyUndefined,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_POINTLIST"]/*'/>

    D11PrimitiveTopologyPointlist = DPrimitiveTopologyPointlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_LINELIST"]/*'/>

    D11PrimitiveTopologyLinelist = DPrimitiveTopologyLinelist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_LINESTRIP"]/*'/>

    D11PrimitiveTopologyLinestrip = DPrimitiveTopologyLinestrip,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST"]/*'/>

    D11PrimitiveTopologyTrianglelist = DPrimitiveTopologyTrianglelist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP"]/*'/>

    D11PrimitiveTopologyTrianglestrip = DPrimitiveTopologyTrianglestrip,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_LINELIST_ADJ"]/*'/>

    D11PrimitiveTopologyLinelistAdj = DPrimitiveTopologyLinelistAdj,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ"]/*'/>

    D11PrimitiveTopologyLinestripAdj = DPrimitiveTopologyLinestripAdj,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ"]/*'/>

    D11PrimitiveTopologyTrianglelistAdj = DPrimitiveTopologyTrianglelistAdj,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ"]/*'/>

    D11PrimitiveTopologyTrianglestripAdj = DPrimitiveTopologyTrianglestripAdj,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology1ControlPointPatchlist = DPrimitiveTopology1ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology2ControlPointPatchlist = DPrimitiveTopology2ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology3ControlPointPatchlist = DPrimitiveTopology3ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology4ControlPointPatchlist = DPrimitiveTopology4ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology5ControlPointPatchlist = DPrimitiveTopology5ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology6ControlPointPatchlist = DPrimitiveTopology6ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology7ControlPointPatchlist = DPrimitiveTopology7ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology8ControlPointPatchlist = DPrimitiveTopology8ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology9ControlPointPatchlist = DPrimitiveTopology9ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology10ControlPointPatchlist = DPrimitiveTopology10ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology11ControlPointPatchlist = DPrimitiveTopology11ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology12ControlPointPatchlist = DPrimitiveTopology12ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology13ControlPointPatchlist = DPrimitiveTopology13ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology14ControlPointPatchlist = DPrimitiveTopology14ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology15ControlPointPatchlist = DPrimitiveTopology15ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology16ControlPointPatchlist = DPrimitiveTopology16ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology17ControlPointPatchlist = DPrimitiveTopology17ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology18ControlPointPatchlist = DPrimitiveTopology18ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology19ControlPointPatchlist = DPrimitiveTopology19ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology20ControlPointPatchlist = DPrimitiveTopology20ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology21ControlPointPatchlist = DPrimitiveTopology21ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology22ControlPointPatchlist = DPrimitiveTopology22ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology23ControlPointPatchlist = DPrimitiveTopology23ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology24ControlPointPatchlist = DPrimitiveTopology24ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology25ControlPointPatchlist = DPrimitiveTopology25ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology26ControlPointPatchlist = DPrimitiveTopology26ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology27ControlPointPatchlist = DPrimitiveTopology27ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology28ControlPointPatchlist = DPrimitiveTopology28ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology29ControlPointPatchlist = DPrimitiveTopology29ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology30ControlPointPatchlist = DPrimitiveTopology30ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology31ControlPointPatchlist = DPrimitiveTopology31ControlPointPatchlist,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST"]/*'/>

    D11PrimitiveTopology32ControlPointPatchlist = DPrimitiveTopology32ControlPointPatchlist,
}
