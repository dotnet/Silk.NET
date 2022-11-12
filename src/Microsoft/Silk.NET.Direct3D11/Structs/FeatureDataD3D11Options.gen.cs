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
            bool? outputMergerLogicOp = null,
            bool? uAVOnlyRenderingForcedSampleCount = null,
            bool? discardAPIsSeenByDriver = null,
            bool? flagsForUpdateAndCopySeenByDriver = null,
            bool? clearView = null,
            bool? copyWithOverlap = null,
            bool? constantBufferPartialUpdate = null,
            bool? constantBufferOffsetting = null,
            bool? mapNoOverwriteOnDynamicConstantBuffer = null,
            bool? mapNoOverwriteOnDynamicBufferSRV = null,
            bool? multisampleRTVWithForcedSampleCountOne = null,
            bool? sAD4ShaderInstructions = null,
            bool? extendedDoublesShaderInstructions = null,
            bool? extendedResourceSharing = null
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
        public bool OutputMergerLogicOp;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "UAVOnlyRenderingForcedSampleCount")]
        public bool UAVOnlyRenderingForcedSampleCount;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DiscardAPIsSeenByDriver")]
        public bool DiscardAPIsSeenByDriver;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "FlagsForUpdateAndCopySeenByDriver")]
        public bool FlagsForUpdateAndCopySeenByDriver;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ClearView")]
        public bool ClearView;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "CopyWithOverlap")]
        public bool CopyWithOverlap;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ConstantBufferPartialUpdate")]
        public bool ConstantBufferPartialUpdate;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ConstantBufferOffsetting")]
        public bool ConstantBufferOffsetting;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MapNoOverwriteOnDynamicConstantBuffer")]
        public bool MapNoOverwriteOnDynamicConstantBuffer;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MapNoOverwriteOnDynamicBufferSRV")]
        public bool MapNoOverwriteOnDynamicBufferSRV;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MultisampleRTVWithForcedSampleCountOne")]
        public bool MultisampleRTVWithForcedSampleCountOne;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "SAD4ShaderInstructions")]
        public bool SAD4ShaderInstructions;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ExtendedDoublesShaderInstructions")]
        public bool ExtendedDoublesShaderInstructions;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ExtendedResourceSharing")]
        public bool ExtendedResourceSharing;
    }
}
