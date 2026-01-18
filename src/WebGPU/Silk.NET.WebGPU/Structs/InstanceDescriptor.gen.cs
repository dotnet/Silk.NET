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
    [NativeName("Name", "WGPUInstanceDescriptor")]
    public unsafe partial struct InstanceDescriptor
    {
        public InstanceDescriptor
        (
            ChainedStruct* nextInChain = null,
            nuint? requiredFeatureCount = null,
            InstanceFeatureName* requiredFeatures = null,
            InstanceLimits* requiredLimits = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (requiredFeatureCount is not null)
            {
                RequiredFeatureCount = requiredFeatureCount.Value;
            }

            if (requiredFeatures is not null)
            {
                RequiredFeatures = requiredFeatures;
            }

            if (requiredLimits is not null)
            {
                RequiredLimits = requiredLimits;
            }
        }


        [NativeName("Type", "WGPUChainedStruct *")]
        [NativeName("Type.Name", "WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "requiredFeatureCount")]
        public nuint RequiredFeatureCount;

        [NativeName("Type", "const WGPUInstanceFeatureName *")]
        [NativeName("Type.Name", "const WGPUInstanceFeatureName *")]
        [NativeName("Name", "requiredFeatures")]
        public InstanceFeatureName* RequiredFeatures;

        [NativeName("Type", "const WGPUInstanceLimits *")]
        [NativeName("Type.Name", "const WGPUInstanceLimits *")]
        [NativeName("Name", "requiredLimits")]
        public InstanceLimits* RequiredLimits;
    }
}
