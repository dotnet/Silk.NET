// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DEPTH_STENCIL_DESC1")]
    public unsafe partial struct DepthStencilDesc1
    {
        public DepthStencilDesc1
        (
            int depthEnable = default,
            DepthWriteMask depthWriteMask = default,
            ComparisonFunc depthFunc = default,
            int stencilEnable = default,
            byte stencilReadMask = default,
            byte stencilWriteMask = default,
            DepthStencilopDesc frontFace = default,
            DepthStencilopDesc backFace = default,
            int depthBoundsTestEnable = default
        )
        {
            DepthEnable = depthEnable;
            DepthWriteMask = depthWriteMask;
            DepthFunc = depthFunc;
            StencilEnable = stencilEnable;
            StencilReadMask = stencilReadMask;
            StencilWriteMask = stencilWriteMask;
            FrontFace = frontFace;
            BackFace = backFace;
            DepthBoundsTestEnable = depthBoundsTestEnable;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DepthEnable")]
        public int DepthEnable;

        [NativeName("Type", "D3D12_DEPTH_WRITE_MASK")]
        [NativeName("Type.Name", "D3D12_DEPTH_WRITE_MASK")]
        [NativeName("Name", "DepthWriteMask")]
        public DepthWriteMask DepthWriteMask;

        [NativeName("Type", "D3D12_COMPARISON_FUNC")]
        [NativeName("Type.Name", "D3D12_COMPARISON_FUNC")]
        [NativeName("Name", "DepthFunc")]
        public ComparisonFunc DepthFunc;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "StencilEnable")]
        public int StencilEnable;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "StencilReadMask")]
        public byte StencilReadMask;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "StencilWriteMask")]
        public byte StencilWriteMask;

        [NativeName("Type", "D3D12_DEPTH_STENCILOP_DESC")]
        [NativeName("Type.Name", "D3D12_DEPTH_STENCILOP_DESC")]
        [NativeName("Name", "FrontFace")]
        public DepthStencilopDesc FrontFace;

        [NativeName("Type", "D3D12_DEPTH_STENCILOP_DESC")]
        [NativeName("Type.Name", "D3D12_DEPTH_STENCILOP_DESC")]
        [NativeName("Name", "BackFace")]
        public DepthStencilopDesc BackFace;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DepthBoundsTestEnable")]
        public int DepthBoundsTestEnable;
    }
}
