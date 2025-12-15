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
    [NativeName("Name", "D3D12_DEPTH_STENCIL_DESC2")]
    public unsafe partial struct DepthStencilDesc2
    {
        public DepthStencilDesc2
        (
            Silk.NET.Core.Bool32? depthEnable = null,
            DepthWriteMask? depthWriteMask = null,
            ComparisonFunc? depthFunc = null,
            Silk.NET.Core.Bool32? stencilEnable = null,
            DepthStencilopDesc1? frontFace = null,
            DepthStencilopDesc1? backFace = null,
            Silk.NET.Core.Bool32? depthBoundsTestEnable = null
        ) : this()
        {
            if (depthEnable is not null)
            {
                DepthEnable = depthEnable.Value;
            }

            if (depthWriteMask is not null)
            {
                DepthWriteMask = depthWriteMask.Value;
            }

            if (depthFunc is not null)
            {
                DepthFunc = depthFunc.Value;
            }

            if (stencilEnable is not null)
            {
                StencilEnable = stencilEnable.Value;
            }

            if (frontFace is not null)
            {
                FrontFace = frontFace.Value;
            }

            if (backFace is not null)
            {
                BackFace = backFace.Value;
            }

            if (depthBoundsTestEnable is not null)
            {
                DepthBoundsTestEnable = depthBoundsTestEnable.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DepthEnable")]
        public Silk.NET.Core.Bool32 DepthEnable;

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
        public Silk.NET.Core.Bool32 StencilEnable;

        [NativeName("Type", "D3D12_DEPTH_STENCILOP_DESC1")]
        [NativeName("Type.Name", "D3D12_DEPTH_STENCILOP_DESC1")]
        [NativeName("Name", "FrontFace")]
        public DepthStencilopDesc1 FrontFace;

        [NativeName("Type", "D3D12_DEPTH_STENCILOP_DESC1")]
        [NativeName("Type.Name", "D3D12_DEPTH_STENCILOP_DESC1")]
        [NativeName("Name", "BackFace")]
        public DepthStencilopDesc1 BackFace;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DepthBoundsTestEnable")]
        public Silk.NET.Core.Bool32 DepthBoundsTestEnable;
    }
}
