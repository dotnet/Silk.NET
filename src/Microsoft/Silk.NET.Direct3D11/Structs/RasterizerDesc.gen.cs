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
    [NativeName("Name", "D3D11_RASTERIZER_DESC")]
    public unsafe partial struct RasterizerDesc
    {
        public RasterizerDesc
        (
            FillMode fillMode = default,
            CullMode cullMode = default,
            int frontCounterClockwise = default,
            int depthBias = default,
            float depthBiasClamp = default,
            float slopeScaledDepthBias = default,
            int depthClipEnable = default,
            int scissorEnable = default,
            int multisampleEnable = default,
            int antialiasedLineEnable = default
        )
        {
            FillMode = fillMode;
            CullMode = cullMode;
            FrontCounterClockwise = frontCounterClockwise;
            DepthBias = depthBias;
            DepthBiasClamp = depthBiasClamp;
            SlopeScaledDepthBias = slopeScaledDepthBias;
            DepthClipEnable = depthClipEnable;
            ScissorEnable = scissorEnable;
            MultisampleEnable = multisampleEnable;
            AntialiasedLineEnable = antialiasedLineEnable;
        }


        [NativeName("Type", "D3D11_FILL_MODE")]
        [NativeName("Type.Name", "D3D11_FILL_MODE")]
        [NativeName("Name", "FillMode")]
        public FillMode FillMode;

        [NativeName("Type", "D3D11_CULL_MODE")]
        [NativeName("Type.Name", "D3D11_CULL_MODE")]
        [NativeName("Name", "CullMode")]
        public CullMode CullMode;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "FrontCounterClockwise")]
        public int FrontCounterClockwise;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "DepthBias")]
        public int DepthBias;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "DepthBiasClamp")]
        public float DepthBiasClamp;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "SlopeScaledDepthBias")]
        public float SlopeScaledDepthBias;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DepthClipEnable")]
        public int DepthClipEnable;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ScissorEnable")]
        public int ScissorEnable;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MultisampleEnable")]
        public int MultisampleEnable;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AntialiasedLineEnable")]
        public int AntialiasedLineEnable;
    }
}
