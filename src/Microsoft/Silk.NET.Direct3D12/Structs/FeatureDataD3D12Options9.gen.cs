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
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS9")]
    public unsafe partial struct FeatureDataD3D12Options9
    {
        public FeatureDataD3D12Options9
        (
            bool? meshShaderPipelineStatsSupported = null,
            bool? meshShaderSupportsFullRangeRenderTargetArrayIndex = null,
            bool? atomicInt64OnTypedResourceSupported = null,
            bool? atomicInt64OnGroupSharedSupported = null,
            bool? derivativesInMeshAndAmplificationShadersSupported = null,
            WaveMmaTier? waveMMATier = null
        ) : this()
        {
            if (meshShaderPipelineStatsSupported is not null)
            {
                MeshShaderPipelineStatsSupported = meshShaderPipelineStatsSupported.Value;
            }

            if (meshShaderSupportsFullRangeRenderTargetArrayIndex is not null)
            {
                MeshShaderSupportsFullRangeRenderTargetArrayIndex = meshShaderSupportsFullRangeRenderTargetArrayIndex.Value;
            }

            if (atomicInt64OnTypedResourceSupported is not null)
            {
                AtomicInt64OnTypedResourceSupported = atomicInt64OnTypedResourceSupported.Value;
            }

            if (atomicInt64OnGroupSharedSupported is not null)
            {
                AtomicInt64OnGroupSharedSupported = atomicInt64OnGroupSharedSupported.Value;
            }

            if (derivativesInMeshAndAmplificationShadersSupported is not null)
            {
                DerivativesInMeshAndAmplificationShadersSupported = derivativesInMeshAndAmplificationShadersSupported.Value;
            }

            if (waveMMATier is not null)
            {
                WaveMMATier = waveMMATier.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MeshShaderPipelineStatsSupported")]
        public bool MeshShaderPipelineStatsSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MeshShaderSupportsFullRangeRenderTargetArrayIndex")]
        public bool MeshShaderSupportsFullRangeRenderTargetArrayIndex;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AtomicInt64OnTypedResourceSupported")]
        public bool AtomicInt64OnTypedResourceSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AtomicInt64OnGroupSharedSupported")]
        public bool AtomicInt64OnGroupSharedSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DerivativesInMeshAndAmplificationShadersSupported")]
        public bool DerivativesInMeshAndAmplificationShadersSupported;

        [NativeName("Type", "D3D12_WAVE_MMA_TIER")]
        [NativeName("Type.Name", "D3D12_WAVE_MMA_TIER")]
        [NativeName("Name", "WaveMMATier")]
        public WaveMmaTier WaveMMATier;
    }
}
