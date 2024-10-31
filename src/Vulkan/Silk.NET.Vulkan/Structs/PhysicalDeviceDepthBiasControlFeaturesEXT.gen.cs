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
    [NativeName("Name", "VkPhysicalDeviceDepthBiasControlFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceDepthBiasControlFeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceDepthBiasControlFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceDepthBiasControlFeaturesExt,
            void* pNext = null,
            Bool32? depthBiasControl = null,
            Bool32? leastRepresentableValueForceUnormRepresentation = null,
            Bool32? floatRepresentation = null,
            Bool32? depthBiasExact = null
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

            if (depthBiasControl is not null)
            {
                DepthBiasControl = depthBiasControl.Value;
            }

            if (leastRepresentableValueForceUnormRepresentation is not null)
            {
                LeastRepresentableValueForceUnormRepresentation = leastRepresentableValueForceUnormRepresentation.Value;
            }

            if (floatRepresentation is not null)
            {
                FloatRepresentation = floatRepresentation.Value;
            }

            if (depthBiasExact is not null)
            {
                DepthBiasExact = depthBiasExact.Value;
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
        [NativeName("Name", "depthBiasControl")]
        public Bool32 DepthBiasControl;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "leastRepresentableValueForceUnormRepresentation")]
        public Bool32 LeastRepresentableValueForceUnormRepresentation;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "floatRepresentation")]
        public Bool32 FloatRepresentation;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "depthBiasExact")]
        public Bool32 DepthBiasExact;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceDepthBiasControlFeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
