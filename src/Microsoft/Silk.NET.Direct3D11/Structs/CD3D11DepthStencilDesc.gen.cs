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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "CD3D11_DEPTH_STENCIL_DESC")]
    public unsafe partial struct CD3D11DepthStencilDesc
    {
        public CD3D11DepthStencilDesc
        (
            Silk.NET.Core.Bool32? depthEnable = null,
            DepthWriteMask? depthWriteMask = null,
            ComparisonFunc? depthFunc = null,
            Silk.NET.Core.Bool32? stencilEnable = null,
            byte? stencilReadMask = null,
            byte? stencilWriteMask = null,
            DepthStencilopDesc? frontFace = null,
            DepthStencilopDesc? backFace = null
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

            if (stencilReadMask is not null)
            {
                StencilReadMask = stencilReadMask.Value;
            }

            if (stencilWriteMask is not null)
            {
                StencilWriteMask = stencilWriteMask.Value;
            }

            if (frontFace is not null)
            {
                FrontFace = frontFace.Value;
            }

            if (backFace is not null)
            {
                BackFace = backFace.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DepthEnable")]
        public Silk.NET.Core.Bool32 DepthEnable;

        [NativeName("Type", "D3D11_DEPTH_WRITE_MASK")]
        [NativeName("Type.Name", "D3D11_DEPTH_WRITE_MASK")]
        [NativeName("Name", "DepthWriteMask")]
        public DepthWriteMask DepthWriteMask;

        [NativeName("Type", "D3D11_COMPARISON_FUNC")]
        [NativeName("Type.Name", "D3D11_COMPARISON_FUNC")]
        [NativeName("Name", "DepthFunc")]
        public ComparisonFunc DepthFunc;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "StencilEnable")]
        public Silk.NET.Core.Bool32 StencilEnable;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "StencilReadMask")]
        public byte StencilReadMask;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "StencilWriteMask")]
        public byte StencilWriteMask;

        [NativeName("Type", "D3D11_DEPTH_STENCILOP_DESC")]
        [NativeName("Type.Name", "D3D11_DEPTH_STENCILOP_DESC")]
        [NativeName("Name", "FrontFace")]
        public DepthStencilopDesc FrontFace;

        [NativeName("Type", "D3D11_DEPTH_STENCILOP_DESC")]
        [NativeName("Type.Name", "D3D11_DEPTH_STENCILOP_DESC")]
        [NativeName("Name", "BackFace")]
        public DepthStencilopDesc BackFace;
    }
}
