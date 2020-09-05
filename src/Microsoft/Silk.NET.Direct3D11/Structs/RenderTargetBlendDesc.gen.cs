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
    [NativeName("Name", "D3D11_RENDER_TARGET_BLEND_DESC")]
    public unsafe partial struct RenderTargetBlendDesc
    {
        public RenderTargetBlendDesc
        (
            int blendEnable = default,
            Blend srcBlend = default,
            Blend destBlend = default,
            BlendOp blendOp = default,
            Blend srcBlendAlpha = default,
            Blend destBlendAlpha = default,
            BlendOp blendOpAlpha = default,
            byte renderTargetWriteMask = default
        )
        {
            BlendEnable = blendEnable;
            SrcBlend = srcBlend;
            DestBlend = destBlend;
            BlendOp = blendOp;
            SrcBlendAlpha = srcBlendAlpha;
            DestBlendAlpha = destBlendAlpha;
            BlendOpAlpha = blendOpAlpha;
            RenderTargetWriteMask = renderTargetWriteMask;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "BlendEnable")]
        public int BlendEnable;

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

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "RenderTargetWriteMask")]
        public byte RenderTargetWriteMask;
    }
}
