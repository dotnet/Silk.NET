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
    [NativeName("Name", "D3D11_RENDER_TARGET_BLEND_DESC")]
    public unsafe partial struct RenderTargetBlendDesc
    {
        public RenderTargetBlendDesc
        (
            Silk.NET.Core.Bool32? blendEnable = null,
            Blend? srcBlend = null,
            Blend? destBlend = null,
            BlendOp? blendOp = null,
            Blend? srcBlendAlpha = null,
            Blend? destBlendAlpha = null,
            BlendOp? blendOpAlpha = null,
            byte? renderTargetWriteMask = null
        ) : this()
        {
            if (blendEnable is not null)
            {
                BlendEnable = blendEnable.Value;
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

            if (renderTargetWriteMask is not null)
            {
                RenderTargetWriteMask = renderTargetWriteMask.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "BlendEnable")]
        public Silk.NET.Core.Bool32 BlendEnable;

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
