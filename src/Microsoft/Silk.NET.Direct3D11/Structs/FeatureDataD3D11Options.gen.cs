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
    [NativeName("Name", "D3D11_FEATURE_DATA_D3D11_OPTIONS")]
    public unsafe partial struct FeatureDataD3D11Options
    {
        public FeatureDataD3D11Options
        (
            int? outputMergerLogicOp = null,
            int? uAVOnlyRenderingForcedSampleCount = null,
            int? discardAPIsSeenByDriver = null,
            int? flagsForUpdateAndCopySeenByDriver = null,
            int? clearView = null,
            int? copyWithOverlap = null,
            int? constantBufferPartialUpdate = null,
            int? constantBufferOffsetting = null,
            int? mapNoOverwriteOnDynamicConstantBuffer = null,
            int? mapNoOverwriteOnDynamicBufferSRV = null,
            int? multisampleRTVWithForcedSampleCountOne = null,
            int? sAD4ShaderInstructions = null,
            int? extendedDoublesShaderInstructions = null,
            int? extendedResourceSharing = null
        ) : this()
        {
            if (outputMergerLogicOp is not null)
            {
                OutputMergerLogicOp = outputMergerLogicOp.Value;
            }

            if (uAVOnlyRenderingForcedSampleCount is not null)
            {
                UAVOnlyRenderingForcedSampleCount = uAVOnlyRenderingForcedSampleCount.Value;
            }

            if (discardAPIsSeenByDriver is not null)
            {
                DiscardAPIsSeenByDriver = discardAPIsSeenByDriver.Value;
            }

            if (flagsForUpdateAndCopySeenByDriver is not null)
            {
                FlagsForUpdateAndCopySeenByDriver = flagsForUpdateAndCopySeenByDriver.Value;
            }

            if (clearView is not null)
            {
                ClearView = clearView.Value;
            }

            if (copyWithOverlap is not null)
            {
                CopyWithOverlap = copyWithOverlap.Value;
            }

            if (constantBufferPartialUpdate is not null)
            {
                ConstantBufferPartialUpdate = constantBufferPartialUpdate.Value;
            }

            if (constantBufferOffsetting is not null)
            {
                ConstantBufferOffsetting = constantBufferOffsetting.Value;
            }

            if (mapNoOverwriteOnDynamicConstantBuffer is not null)
            {
                MapNoOverwriteOnDynamicConstantBuffer = mapNoOverwriteOnDynamicConstantBuffer.Value;
            }

            if (mapNoOverwriteOnDynamicBufferSRV is not null)
            {
                MapNoOverwriteOnDynamicBufferSRV = mapNoOverwriteOnDynamicBufferSRV.Value;
            }

            if (multisampleRTVWithForcedSampleCountOne is not null)
            {
                MultisampleRTVWithForcedSampleCountOne = multisampleRTVWithForcedSampleCountOne.Value;
            }

            if (sAD4ShaderInstructions is not null)
            {
                SAD4ShaderInstructions = sAD4ShaderInstructions.Value;
            }

            if (extendedDoublesShaderInstructions is not null)
            {
                ExtendedDoublesShaderInstructions = extendedDoublesShaderInstructions.Value;
            }

            if (extendedResourceSharing is not null)
            {
                ExtendedResourceSharing = extendedResourceSharing.Value;
            }
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
