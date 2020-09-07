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
    [NativeName("Name", "CD3D11_BLEND_DESC1")]
    public unsafe partial struct CD3D11BlendDesc1
    {
        public CD3D11BlendDesc1
        (
            int alphaToCoverageEnable = default,
            int independentBlendEnable = default
        )
        {
            AlphaToCoverageEnable = alphaToCoverageEnable;
            IndependentBlendEnable = independentBlendEnable;
           RenderTarget_0 = default;
           RenderTarget_1 = default;
           RenderTarget_2 = default;
           RenderTarget_3 = default;
           RenderTarget_4 = default;
           RenderTarget_5 = default;
           RenderTarget_6 = default;
           RenderTarget_7 = default;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AlphaToCoverageEnable")]
        public int AlphaToCoverageEnable;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "IndependentBlendEnable")]
        public int IndependentBlendEnable;
        
        [NativeName("Type", "D3D11_RENDER_TARGET_BLEND_DESC1 [8]")]
        [NativeName("Type.Name", "D3D11_RENDER_TARGET_BLEND_DESC1 [8]")]
        [NativeName("Name", "RenderTarget")]
        public RenderTargetBlendDesc1 RenderTarget_0;
        
        [NativeName("Type", "D3D11_RENDER_TARGET_BLEND_DESC1 [8]")]
        [NativeName("Type.Name", "D3D11_RENDER_TARGET_BLEND_DESC1 [8]")]
        [NativeName("Name", "RenderTarget")]
        public RenderTargetBlendDesc1 RenderTarget_1;
        
        [NativeName("Type", "D3D11_RENDER_TARGET_BLEND_DESC1 [8]")]
        [NativeName("Type.Name", "D3D11_RENDER_TARGET_BLEND_DESC1 [8]")]
        [NativeName("Name", "RenderTarget")]
        public RenderTargetBlendDesc1 RenderTarget_2;
        
        [NativeName("Type", "D3D11_RENDER_TARGET_BLEND_DESC1 [8]")]
        [NativeName("Type.Name", "D3D11_RENDER_TARGET_BLEND_DESC1 [8]")]
        [NativeName("Name", "RenderTarget")]
        public RenderTargetBlendDesc1 RenderTarget_3;
        
        [NativeName("Type", "D3D11_RENDER_TARGET_BLEND_DESC1 [8]")]
        [NativeName("Type.Name", "D3D11_RENDER_TARGET_BLEND_DESC1 [8]")]
        [NativeName("Name", "RenderTarget")]
        public RenderTargetBlendDesc1 RenderTarget_4;
        
        [NativeName("Type", "D3D11_RENDER_TARGET_BLEND_DESC1 [8]")]
        [NativeName("Type.Name", "D3D11_RENDER_TARGET_BLEND_DESC1 [8]")]
        [NativeName("Name", "RenderTarget")]
        public RenderTargetBlendDesc1 RenderTarget_5;
        
        [NativeName("Type", "D3D11_RENDER_TARGET_BLEND_DESC1 [8]")]
        [NativeName("Type.Name", "D3D11_RENDER_TARGET_BLEND_DESC1 [8]")]
        [NativeName("Name", "RenderTarget")]
        public RenderTargetBlendDesc1 RenderTarget_6;
        
        [NativeName("Type", "D3D11_RENDER_TARGET_BLEND_DESC1 [8]")]
        [NativeName("Type.Name", "D3D11_RENDER_TARGET_BLEND_DESC1 [8]")]
        [NativeName("Name", "RenderTarget")]
        public RenderTargetBlendDesc1 RenderTarget_7;
    }
}
