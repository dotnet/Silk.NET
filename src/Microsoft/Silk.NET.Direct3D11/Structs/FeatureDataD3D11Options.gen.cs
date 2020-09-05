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
    [NativeName("Name", "D3D11_FEATURE_DATA_D3D11_OPTIONS")]
    public unsafe partial struct FeatureDataD3D11Options
    {
        public FeatureDataD3D11Options
        (
            int outputMergerLogicOp = default,
            int uAVOnlyRenderingForcedSampleCount = default,
            int discardAPIsSeenByDriver = default,
            int flagsForUpdateAndCopySeenByDriver = default,
            int clearView = default,
            int copyWithOverlap = default,
            int constantBufferPartialUpdate = default,
            int constantBufferOffsetting = default,
            int mapNoOverwriteOnDynamicConstantBuffer = default,
            int mapNoOverwriteOnDynamicBufferSRV = default,
            int multisampleRTVWithForcedSampleCountOne = default,
            int sAD4ShaderInstructions = default,
            int extendedDoublesShaderInstructions = default,
            int extendedResourceSharing = default
        )
        {
            OutputMergerLogicOp = outputMergerLogicOp;
            UAVOnlyRenderingForcedSampleCount = uAVOnlyRenderingForcedSampleCount;
            DiscardAPIsSeenByDriver = discardAPIsSeenByDriver;
            FlagsForUpdateAndCopySeenByDriver = flagsForUpdateAndCopySeenByDriver;
            ClearView = clearView;
            CopyWithOverlap = copyWithOverlap;
            ConstantBufferPartialUpdate = constantBufferPartialUpdate;
            ConstantBufferOffsetting = constantBufferOffsetting;
            MapNoOverwriteOnDynamicConstantBuffer = mapNoOverwriteOnDynamicConstantBuffer;
            MapNoOverwriteOnDynamicBufferSRV = mapNoOverwriteOnDynamicBufferSRV;
            MultisampleRTVWithForcedSampleCountOne = multisampleRTVWithForcedSampleCountOne;
            SAD4ShaderInstructions = sAD4ShaderInstructions;
            ExtendedDoublesShaderInstructions = extendedDoublesShaderInstructions;
            ExtendedResourceSharing = extendedResourceSharing;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "OutputMergerLogicOp")]
        public int OutputMergerLogicOp;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "UAVOnlyRenderingForcedSampleCount")]
        public int UAVOnlyRenderingForcedSampleCount;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DiscardAPIsSeenByDriver")]
        public int DiscardAPIsSeenByDriver;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "FlagsForUpdateAndCopySeenByDriver")]
        public int FlagsForUpdateAndCopySeenByDriver;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ClearView")]
        public int ClearView;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "CopyWithOverlap")]
        public int CopyWithOverlap;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ConstantBufferPartialUpdate")]
        public int ConstantBufferPartialUpdate;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ConstantBufferOffsetting")]
        public int ConstantBufferOffsetting;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MapNoOverwriteOnDynamicConstantBuffer")]
        public int MapNoOverwriteOnDynamicConstantBuffer;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MapNoOverwriteOnDynamicBufferSRV")]
        public int MapNoOverwriteOnDynamicBufferSRV;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MultisampleRTVWithForcedSampleCountOne")]
        public int MultisampleRTVWithForcedSampleCountOne;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "SAD4ShaderInstructions")]
        public int SAD4ShaderInstructions;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ExtendedDoublesShaderInstructions")]
        public int ExtendedDoublesShaderInstructions;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ExtendedResourceSharing")]
        public int ExtendedResourceSharing;
    }
}
