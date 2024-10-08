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
    [NativeName("Name", "VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR")]
    public unsafe partial struct PhysicalDeviceRayTracingMaintenance1FeaturesKHR : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceRayTracingMaintenance1FeaturesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceRayTracingMaintenance1FeaturesKhr,
            void* pNext = null,
            Bool32? rayTracingMaintenance1 = null,
            Bool32? rayTracingPipelineTraceRaysIndirect2 = null
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

            if (rayTracingMaintenance1 is not null)
            {
                RayTracingMaintenance1 = rayTracingMaintenance1.Value;
            }

            if (rayTracingPipelineTraceRaysIndirect2 is not null)
            {
                RayTracingPipelineTraceRaysIndirect2 = rayTracingPipelineTraceRaysIndirect2.Value;
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
        [NativeName("Name", "rayTracingMaintenance1")]
        public Bool32 RayTracingMaintenance1;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rayTracingPipelineTraceRaysIndirect2")]
        public Bool32 RayTracingPipelineTraceRaysIndirect2;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceRayTracingMaintenance1FeaturesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
