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
    [NativeName("Name", "D3D11_RENDER_TARGET_BLEND_DESC1")]
    public unsafe partial struct RenderTargetBlendDesc1
    {
        public RenderTargetBlendDesc1
        (
            Silk.NET.Core.Bool32? blendEnable = null,
            Silk.NET.Core.Bool32? logicOpEnable = null,
            Blend? srcBlend = null,
            Blend? destBlend = null,
            BlendOp? blendOp = null,
            Blend? srcBlendAlpha = null,
            Blend? destBlendAlpha = null,
            BlendOp? blendOpAlpha = null,
            LogicOp? logicOp = null,
            byte? renderTargetWriteMask = null
        ) : this()
        {
            if (blendEnable is not null)
            {
                BlendEnable = blendEnable.Value;
            }

            if (logicOpEnable is not null)
            {
                LogicOpEnable = logicOpEnable.Value;
            }

            if (srcBlend is not null)
            {
                SrcBlend = srcBlend.Value;
            }

            if (destBlend is not null)
            {
                DestBlend = destBlend.Value;
            }

            if (blendOp is not null)
            {
                BlendOp = blendOp.Value;
            }

            if (srcBlendAlpha is not null)
            {
                SrcBlendAlpha = srcBlendAlpha.Value;
            }

            if (destBlendAlpha is not null)
            {
                DestBlendAlpha = destBlendAlpha.Value;
            }

            if (blendOpAlpha is not null)
            {
                BlendOpAlpha = blendOpAlpha.Value;
            }

            if (logicOp is not null)
            {
                LogicOp = logicOp.Value;
            }

            if (renderTargetWriteMask is not null)
            {
                RenderTargetWriteMask = renderTargetWriteMask.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "BlendEnable")]
        public Silk.NET.Core.Bool32 BlendEnable;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "LogicOpEnable")]
        public Silk.NET.Core.Bool32 LogicOpEnable;

        [NativeName("Type", "D3D11_BLEND")]
        [NativeName("Type.Name", "D3D11_BLEND")]
        [NativeName("Name", "SrcBlend")]
        public Blend SrcBlend;

        [NativeName("Type", "D3D11_BLEND")]
        [NativeName("Type.Name", "D3D11_BLEND")]
        [NativeName("Name", "DestBlend")]
        public Blend DestBlend;

        [NativeName("Type", "D3D11_BLEND_OP")]
        [NativeName("Type.Name", "D3D11_BLEND_OP")]
        [NativeName("Name", "BlendOp")]
        public BlendOp BlendOp;

        [NativeName("Type", "D3D11_BLEND")]
        [NativeName("Type.Name", "D3D11_BLEND")]
        [NativeName("Name", "SrcBlendAlpha")]
        public Blend SrcBlendAlpha;

        [NativeName("Type", "D3D11_BLEND")]
        [NativeName("Type.Name", "D3D11_BLEND")]
        [NativeName("Name", "DestBlendAlpha")]
        public Blend DestBlendAlpha;

        [NativeName("Type", "D3D11_BLEND_OP")]
        [NativeName("Type.Name", "D3D11_BLEND_OP")]
        [NativeName("Name", "BlendOpAlpha")]
        public BlendOp BlendOpAlpha;

        [NativeName("Type", "D3D11_LOGIC_OP")]
        [NativeName("Type.Name", "D3D11_LOGIC_OP")]
        [NativeName("Name", "LogicOp")]
        public LogicOp LogicOp;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "RenderTargetWriteMask")]
        public byte RenderTargetWriteMask;
    }
}
