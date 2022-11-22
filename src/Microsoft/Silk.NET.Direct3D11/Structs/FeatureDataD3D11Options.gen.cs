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
            Silk.NET.Core.Bool32? outputMergerLogicOp = null,
            Silk.NET.Core.Bool32? uAVOnlyRenderingForcedSampleCount = null,
            Silk.NET.Core.Bool32? discardAPIsSeenByDriver = null,
            Silk.NET.Core.Bool32? flagsForUpdateAndCopySeenByDriver = null,
            Silk.NET.Core.Bool32? clearView = null,
            Silk.NET.Core.Bool32? copyWithOverlap = null,
            Silk.NET.Core.Bool32? constantBufferPartialUpdate = null,
            Silk.NET.Core.Bool32? constantBufferOffsetting = null,
            Silk.NET.Core.Bool32? mapNoOverwriteOnDynamicConstantBuffer = null,
            Silk.NET.Core.Bool32? mapNoOverwriteOnDynamicBufferSRV = null,
            Silk.NET.Core.Bool32? multisampleRTVWithForcedSampleCountOne = null,
            Silk.NET.Core.Bool32? sAD4ShaderInstructions = null,
            Silk.NET.Core.Bool32? extendedDoublesShaderInstructions = null,
            Silk.NET.Core.Bool32? extendedResourceSharing = null
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
        public Silk.NET.Core.Bool32 OutputMergerLogicOp;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "UAVOnlyRenderingForcedSampleCount")]
        public Silk.NET.Core.Bool32 UAVOnlyRenderingForcedSampleCount;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DiscardAPIsSeenByDriver")]
        public Silk.NET.Core.Bool32 DiscardAPIsSeenByDriver;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "FlagsForUpdateAndCopySeenByDriver")]
        public Silk.NET.Core.Bool32 FlagsForUpdateAndCopySeenByDriver;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ClearView")]
        public Silk.NET.Core.Bool32 ClearView;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "CopyWithOverlap")]
        public Silk.NET.Core.Bool32 CopyWithOverlap;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ConstantBufferPartialUpdate")]
        public Silk.NET.Core.Bool32 ConstantBufferPartialUpdate;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ConstantBufferOffsetting")]
        public Silk.NET.Core.Bool32 ConstantBufferOffsetting;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MapNoOverwriteOnDynamicConstantBuffer")]
        public Silk.NET.Core.Bool32 MapNoOverwriteOnDynamicConstantBuffer;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MapNoOverwriteOnDynamicBufferSRV")]
        public Silk.NET.Core.Bool32 MapNoOverwriteOnDynamicBufferSRV;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MultisampleRTVWithForcedSampleCountOne")]
        public Silk.NET.Core.Bool32 MultisampleRTVWithForcedSampleCountOne;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "SAD4ShaderInstructions")]
        public Silk.NET.Core.Bool32 SAD4ShaderInstructions;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ExtendedDoublesShaderInstructions")]
        public Silk.NET.Core.Bool32 ExtendedDoublesShaderInstructions;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ExtendedResourceSharing")]
        public Silk.NET.Core.Bool32 ExtendedResourceSharing;
    }
}
