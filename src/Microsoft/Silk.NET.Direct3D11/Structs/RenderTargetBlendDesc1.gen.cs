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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_RENDER_TARGET_BLEND_DESC1")]
    public unsafe partial struct RenderTargetBlendDesc1
    {
        public RenderTargetBlendDesc1
        (
            int blendEnable = default,
            int logicOpEnable = default,
            Blend srcBlend = default,
            Blend destBlend = default,
            BlendOp blendOp = default,
            Blend srcBlendAlpha = default,
            Blend destBlendAlpha = default,
            BlendOp blendOpAlpha = default,
            LogicOp logicOp = default,
            byte renderTargetWriteMask = default
        )
        {
            BlendEnable = blendEnable;
            LogicOpEnable = logicOpEnable;
            SrcBlend = srcBlend;
            DestBlend = destBlend;
            BlendOp = blendOp;
            SrcBlendAlpha = srcBlendAlpha;
            DestBlendAlpha = destBlendAlpha;
            BlendOpAlpha = blendOpAlpha;
            LogicOp = logicOp;
            RenderTargetWriteMask = renderTargetWriteMask;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "BlendEnable")]
        public int BlendEnable;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "LogicOpEnable")]
        public int LogicOpEnable;

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
