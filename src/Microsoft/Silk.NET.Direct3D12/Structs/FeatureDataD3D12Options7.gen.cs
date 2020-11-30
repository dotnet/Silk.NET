// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS7")]
    public unsafe partial struct FeatureDataD3D12Options7
    {
        public FeatureDataD3D12Options7
        (
            MeshShaderTier? meshShaderTier = null,
            SamplerFeedbackTier? samplerFeedbackTier = null
        ) : this()
        {
            if (meshShaderTier is not null)
            {
                MeshShaderTier = meshShaderTier.Value;
            }

            if (samplerFeedbackTier is not null)
            {
                SamplerFeedbackTier = samplerFeedbackTier.Value;
            }
        }


        [NativeName("Type", "D3D12_MESH_SHADER_TIER")]
        [NativeName("Type.Name", "D3D12_MESH_SHADER_TIER")]
        [NativeName("Name", "MeshShaderTier")]
        public MeshShaderTier MeshShaderTier;

        [NativeName("Type", "D3D12_SAMPLER_FEEDBACK_TIER")]
        [NativeName("Type.Name", "D3D12_SAMPLER_FEEDBACK_TIER")]
        [NativeName("Name", "SamplerFeedbackTier")]
        public SamplerFeedbackTier SamplerFeedbackTier;
    }
}
