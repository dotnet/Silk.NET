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
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS13")]
    public unsafe partial struct FeatureDataD3D12Options13
    {
        public FeatureDataD3D12Options13
        (
            bool? unrestrictedBufferTextureCopyPitchSupported = null,
            bool? unrestrictedVertexElementAlignmentSupported = null,
            bool? invertedViewportHeightFlipsYSupported = null,
            bool? invertedViewportDepthFlipsZSupported = null,
            bool? textureCopyBetweenDimensionsSupported = null,
            bool? alphaBlendFactorSupported = null
        ) : this()
        {
            if (unrestrictedBufferTextureCopyPitchSupported is not null)
            {
                UnrestrictedBufferTextureCopyPitchSupported = unrestrictedBufferTextureCopyPitchSupported.Value;
            }

            if (unrestrictedVertexElementAlignmentSupported is not null)
            {
                UnrestrictedVertexElementAlignmentSupported = unrestrictedVertexElementAlignmentSupported.Value;
            }

            if (invertedViewportHeightFlipsYSupported is not null)
            {
                InvertedViewportHeightFlipsYSupported = invertedViewportHeightFlipsYSupported.Value;
            }

            if (invertedViewportDepthFlipsZSupported is not null)
            {
                InvertedViewportDepthFlipsZSupported = invertedViewportDepthFlipsZSupported.Value;
            }

            if (textureCopyBetweenDimensionsSupported is not null)
            {
                TextureCopyBetweenDimensionsSupported = textureCopyBetweenDimensionsSupported.Value;
            }

            if (alphaBlendFactorSupported is not null)
            {
                AlphaBlendFactorSupported = alphaBlendFactorSupported.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "UnrestrictedBufferTextureCopyPitchSupported")]
        public bool UnrestrictedBufferTextureCopyPitchSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "UnrestrictedVertexElementAlignmentSupported")]
        public bool UnrestrictedVertexElementAlignmentSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "InvertedViewportHeightFlipsYSupported")]
        public bool InvertedViewportHeightFlipsYSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "InvertedViewportDepthFlipsZSupported")]
        public bool InvertedViewportDepthFlipsZSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "TextureCopyBetweenDimensionsSupported")]
        public bool TextureCopyBetweenDimensionsSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AlphaBlendFactorSupported")]
        public bool AlphaBlendFactorSupported;
    }
}
