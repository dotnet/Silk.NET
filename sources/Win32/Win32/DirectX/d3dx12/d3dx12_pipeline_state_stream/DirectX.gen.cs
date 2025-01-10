// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using static Silk.NET.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DirectX
{
    public static D3D12_PIPELINE_STATE_SUBOBJECT_TYPE D3DX12GetBaseSubobjectType(
        D3D12_PIPELINE_STATE_SUBOBJECT_TYPE SubobjectType
    )
    {
        switch (SubobjectType)
        {
            case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1:
            {
                return D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL;
            }
            case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL2:
            {
                return D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL;
            }
            case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER1:
            {
                return D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER;
            }
            default:
            {
                return SubobjectType;
            }
        }
    }
}
