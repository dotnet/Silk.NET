// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DEPTH_STENCILOP_DESC1")]
    public unsafe partial struct DepthStencilopDesc1
    {
        public DepthStencilopDesc1
        (
            StencilOp? stencilFailOp = null,
            StencilOp? stencilDepthFailOp = null,
            StencilOp? stencilPassOp = null,
            ComparisonFunc? stencilFunc = null,
            byte? stencilReadMask = null,
            byte? stencilWriteMask = null
        ) : this()
        {
            if (stencilFailOp is not null)
            {
                StencilFailOp = stencilFailOp.Value;
            }

            if (stencilDepthFailOp is not null)
            {
                StencilDepthFailOp = stencilDepthFailOp.Value;
            }

            if (stencilPassOp is not null)
            {
                StencilPassOp = stencilPassOp.Value;
            }

            if (stencilFunc is not null)
            {
                StencilFunc = stencilFunc.Value;
            }

            if (stencilReadMask is not null)
            {
                StencilReadMask = stencilReadMask.Value;
            }

            if (stencilWriteMask is not null)
            {
                StencilWriteMask = stencilWriteMask.Value;
            }
        }


        [NativeName("Type", "D3D12_STENCIL_OP")]
        [NativeName("Type.Name", "D3D12_STENCIL_OP")]
        [NativeName("Name", "StencilFailOp")]
        public StencilOp StencilFailOp;

        [NativeName("Type", "D3D12_STENCIL_OP")]
        [NativeName("Type.Name", "D3D12_STENCIL_OP")]
        [NativeName("Name", "StencilDepthFailOp")]
        public StencilOp StencilDepthFailOp;

        [NativeName("Type", "D3D12_STENCIL_OP")]
        [NativeName("Type.Name", "D3D12_STENCIL_OP")]
        [NativeName("Name", "StencilPassOp")]
        public StencilOp StencilPassOp;

        [NativeName("Type", "D3D12_COMPARISON_FUNC")]
        [NativeName("Type.Name", "D3D12_COMPARISON_FUNC")]
        [NativeName("Name", "StencilFunc")]
        public ComparisonFunc StencilFunc;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "StencilReadMask")]
        public byte StencilReadMask;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "StencilWriteMask")]
        public byte StencilWriteMask;
    }
}
