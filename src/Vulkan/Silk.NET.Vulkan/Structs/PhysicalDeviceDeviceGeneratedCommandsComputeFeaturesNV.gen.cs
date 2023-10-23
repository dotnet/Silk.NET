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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV")]
    public unsafe partial struct PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV
        (
            StructureType? sType = StructureType.PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV,
            void* pNext = null,
            Bool32? deviceGeneratedCompute = null,
            Bool32? deviceGeneratedComputePipelines = null,
            Bool32? deviceGeneratedComputeCaptureReplay = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (deviceGeneratedCompute is not null)
            {
                DeviceGeneratedCompute = deviceGeneratedCompute.Value;
            }

            if (deviceGeneratedComputePipelines is not null)
            {
                DeviceGeneratedComputePipelines = deviceGeneratedComputePipelines.Value;
            }

            if (deviceGeneratedComputeCaptureReplay is not null)
            {
                DeviceGeneratedComputeCaptureReplay = deviceGeneratedComputeCaptureReplay.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "deviceGeneratedCompute")]
        public Bool32 DeviceGeneratedCompute;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "deviceGeneratedComputePipelines")]
        public Bool32 DeviceGeneratedComputePipelines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "deviceGeneratedComputeCaptureReplay")]
        public Bool32 DeviceGeneratedComputeCaptureReplay;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
