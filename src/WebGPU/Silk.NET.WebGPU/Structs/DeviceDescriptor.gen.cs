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
    [NativeName("Name", "WGPUDeviceDescriptor")]
    public unsafe partial struct DeviceDescriptor
    {
        public DeviceDescriptor
        (
            ChainedStruct* nextInChain = null,
            byte* label = null,
            uint? requiredFeaturesCount = null,
            FeatureName* requiredFeatures = null,
            RequiredLimits* requiredLimits = null,
            QueueDescriptor? defaultQueue = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (label is not null)
            {
                Label = label;
            }

            if (requiredFeaturesCount is not null)
            {
                RequiredFeaturesCount = requiredFeaturesCount.Value;
            }

            if (requiredFeatures is not null)
            {
                RequiredFeatures = requiredFeatures;
            }

            if (requiredLimits is not null)
            {
                RequiredLimits = requiredLimits;
            }

            if (defaultQueue is not null)
            {
                DefaultQueue = defaultQueue.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "label")]
        public byte* Label;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "requiredFeaturesCount")]
        public uint RequiredFeaturesCount;

        [NativeName("Type", "const WGPUFeatureName *")]
        [NativeName("Type.Name", "const WGPUFeatureName *")]
        [NativeName("Name", "requiredFeatures")]
        public FeatureName* RequiredFeatures;

        [NativeName("Type", "const WGPURequiredLimits *")]
        [NativeName("Type.Name", "const WGPURequiredLimits *")]
        [NativeName("Name", "requiredLimits")]
        public RequiredLimits* RequiredLimits;

        [NativeName("Type", "WGPUQueueDescriptor")]
        [NativeName("Type.Name", "WGPUQueueDescriptor")]
        [NativeName("Name", "defaultQueue")]
        public QueueDescriptor DefaultQueue;
    }
}
