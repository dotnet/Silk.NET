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
    [NativeName("Name", "D3D11_FEATURE_DATA_D3D9_OPTIONS1")]
    public unsafe partial struct FeatureDataD3D9Options1
    {
        public FeatureDataD3D9Options1
        (
            Silk.NET.Core.Bool32? fullNonPow2TextureSupported = null,
            Silk.NET.Core.Bool32? depthAsTextureWithLessEqualComparisonFilterSupported = null,
            Silk.NET.Core.Bool32? simpleInstancingSupported = null,
            Silk.NET.Core.Bool32? textureCubeFaceRenderTargetWithNonCubeDepthStencilSupported = null
        ) : this()
        {
            if (fullNonPow2TextureSupported is not null)
            {
                FullNonPow2TextureSupported = fullNonPow2TextureSupported.Value;
            }

            if (depthAsTextureWithLessEqualComparisonFilterSupported is not null)
            {
                DepthAsTextureWithLessEqualComparisonFilterSupported = depthAsTextureWithLessEqualComparisonFilterSupported.Value;
            }

            if (simpleInstancingSupported is not null)
            {
                SimpleInstancingSupported = simpleInstancingSupported.Value;
            }

            if (textureCubeFaceRenderTargetWithNonCubeDepthStencilSupported is not null)
            {
                TextureCubeFaceRenderTargetWithNonCubeDepthStencilSupported = textureCubeFaceRenderTargetWithNonCubeDepthStencilSupported.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "FullNonPow2TextureSupported")]
        public Silk.NET.Core.Bool32 FullNonPow2TextureSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DepthAsTextureWithLessEqualComparisonFilterSupported")]
        public Silk.NET.Core.Bool32 DepthAsTextureWithLessEqualComparisonFilterSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "SimpleInstancingSupported")]
        public Silk.NET.Core.Bool32 SimpleInstancingSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "TextureCubeFaceRenderTargetWithNonCubeDepthStencilSupported")]
        public Silk.NET.Core.Bool32 TextureCubeFaceRenderTargetWithNonCubeDepthStencilSupported;
    }
}
