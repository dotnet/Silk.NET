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
    [NativeName("Name", "D3D11_FEATURE_DATA_D3D9_OPTIONS1")]
    public unsafe partial struct FeatureDataD3D9Options1
    {
        public FeatureDataD3D9Options1
        (
            int fullNonPow2TextureSupported = default,
            int depthAsTextureWithLessEqualComparisonFilterSupported = default,
            int simpleInstancingSupported = default,
            int textureCubeFaceRenderTargetWithNonCubeDepthStencilSupported = default
        )
        {
            FullNonPow2TextureSupported = fullNonPow2TextureSupported;
            DepthAsTextureWithLessEqualComparisonFilterSupported = depthAsTextureWithLessEqualComparisonFilterSupported;
            SimpleInstancingSupported = simpleInstancingSupported;
            TextureCubeFaceRenderTargetWithNonCubeDepthStencilSupported = textureCubeFaceRenderTargetWithNonCubeDepthStencilSupported;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "FullNonPow2TextureSupported")]
        public int FullNonPow2TextureSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DepthAsTextureWithLessEqualComparisonFilterSupported")]
        public int DepthAsTextureWithLessEqualComparisonFilterSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "SimpleInstancingSupported")]
        public int SimpleInstancingSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "TextureCubeFaceRenderTargetWithNonCubeDepthStencilSupported")]
        public int TextureCubeFaceRenderTargetWithNonCubeDepthStencilSupported;
    }
}
