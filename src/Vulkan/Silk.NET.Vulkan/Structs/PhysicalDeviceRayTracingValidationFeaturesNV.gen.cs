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
    [NativeName("Name", "VkPhysicalDeviceRayTracingValidationFeaturesNV")]
    public unsafe partial struct PhysicalDeviceRayTracingValidationFeaturesNV : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceRayTracingValidationFeaturesNV
        (
            StructureType? sType = StructureType.PhysicalDeviceRayTracingValidationFeaturesNV,
            void* pNext = null,
            Bool32? rayTracingValidation = null
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

            if (rayTracingValidation is not null)
            {
                RayTracingValidation = rayTracingValidation.Value;
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
        [NativeName("Name", "rayTracingValidation")]
        public Bool32 RayTracingValidation;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceRayTracingValidationFeaturesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
