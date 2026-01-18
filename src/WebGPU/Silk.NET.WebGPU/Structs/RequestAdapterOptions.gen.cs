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

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPURequestAdapterOptions")]
    public unsafe partial struct RequestAdapterOptions
    {
        public RequestAdapterOptions
        (
            ChainedStruct* nextInChain = null,
            FeatureLevel? featureLevel = null,
            PowerPreference? powerPreference = null,
            Silk.NET.Core.Bool32? forceFallbackAdapter = null,
            BackendType? backendType = null,
            Surface* compatibleSurface = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (featureLevel is not null)
            {
                FeatureLevel = featureLevel.Value;
            }

            if (powerPreference is not null)
            {
                PowerPreference = powerPreference.Value;
            }

            if (forceFallbackAdapter is not null)
            {
                ForceFallbackAdapter = forceFallbackAdapter.Value;
            }

            if (backendType is not null)
            {
                BackendType = backendType.Value;
            }

            if (compatibleSurface is not null)
            {
                CompatibleSurface = compatibleSurface;
            }
        }


        [NativeName("Type", "WGPUChainedStruct *")]
        [NativeName("Type.Name", "WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUFeatureLevel")]
        [NativeName("Type.Name", "WGPUFeatureLevel")]
        [NativeName("Name", "featureLevel")]
        public FeatureLevel FeatureLevel;

        [NativeName("Type", "WGPUPowerPreference")]
        [NativeName("Type.Name", "WGPUPowerPreference")]
        [NativeName("Name", "powerPreference")]
        public PowerPreference PowerPreference;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "forceFallbackAdapter")]
        public Silk.NET.Core.Bool32 ForceFallbackAdapter;

        [NativeName("Type", "WGPUBackendType")]
        [NativeName("Type.Name", "WGPUBackendType")]
        [NativeName("Name", "backendType")]
        public BackendType BackendType;

        [NativeName("Type", "WGPUSurface")]
        [NativeName("Type.Name", "WGPUSurface")]
        [NativeName("Name", "compatibleSurface")]
        public Surface* CompatibleSurface;
    }
}
