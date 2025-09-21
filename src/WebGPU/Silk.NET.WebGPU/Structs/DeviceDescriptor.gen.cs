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
            StringView? label = null,
            nuint? requiredFeatureCount = null,
            FeatureName* requiredFeatures = null,
            Limits* requiredLimits = null,
            QueueDescriptor? defaultQueue = null,
            DeviceLostCallbackInfo? deviceLostCallbackInfo = null,
            UncapturedErrorCallbackInfo? uncapturedErrorCallbackInfo = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (label is not null)
            {
                Label = label.Value;
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

            if (defaultQueue is not null)
            {
                DefaultQueue = defaultQueue.Value;
            }

            if (deviceLostCallbackInfo is not null)
            {
                DeviceLostCallbackInfo = deviceLostCallbackInfo.Value;
            }

            if (uncapturedErrorCallbackInfo is not null)
            {
                UncapturedErrorCallbackInfo = uncapturedErrorCallbackInfo.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct *")]
        [NativeName("Type.Name", "WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUStringView")]
        [NativeName("Type.Name", "WGPUStringView")]
        [NativeName("Name", "label")]
        public StringView Label;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "requiredFeatureCount")]
        public nuint RequiredFeatureCount;

        [NativeName("Type", "const WGPUFeatureName *")]
        [NativeName("Type.Name", "const WGPUFeatureName *")]
        [NativeName("Name", "requiredFeatures")]
        public FeatureName* RequiredFeatures;

        [NativeName("Type", "const WGPULimits *")]
        [NativeName("Type.Name", "const WGPULimits *")]
        [NativeName("Name", "requiredLimits")]
        public Limits* RequiredLimits;

        [NativeName("Type", "WGPUQueueDescriptor")]
        [NativeName("Type.Name", "WGPUQueueDescriptor")]
        [NativeName("Name", "defaultQueue")]
        public QueueDescriptor DefaultQueue;

        [NativeName("Type", "WGPUDeviceLostCallbackInfo")]
        [NativeName("Type.Name", "WGPUDeviceLostCallbackInfo")]
        [NativeName("Name", "deviceLostCallbackInfo")]
        public DeviceLostCallbackInfo DeviceLostCallbackInfo;

        [NativeName("Type", "WGPUUncapturedErrorCallbackInfo")]
        [NativeName("Type.Name", "WGPUUncapturedErrorCallbackInfo")]
        [NativeName("Name", "uncapturedErrorCallbackInfo")]
        public UncapturedErrorCallbackInfo UncapturedErrorCallbackInfo;
    }
}
