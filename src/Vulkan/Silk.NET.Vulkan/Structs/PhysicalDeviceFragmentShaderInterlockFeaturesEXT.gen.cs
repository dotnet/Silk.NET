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
    [NativeName("Name", "VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceFragmentShaderInterlockFeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceFragmentShaderInterlockFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceFragmentShaderInterlockFeaturesExt,
            void* pNext = null,
            Bool32? fragmentShaderSampleInterlock = null,
            Bool32? fragmentShaderPixelInterlock = null,
            Bool32? fragmentShaderShadingRateInterlock = null
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

            if (fragmentShaderSampleInterlock is not null)
            {
                FragmentShaderSampleInterlock = fragmentShaderSampleInterlock.Value;
            }

            if (fragmentShaderPixelInterlock is not null)
            {
                FragmentShaderPixelInterlock = fragmentShaderPixelInterlock.Value;
            }

            if (fragmentShaderShadingRateInterlock is not null)
            {
                FragmentShaderShadingRateInterlock = fragmentShaderShadingRateInterlock.Value;
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
        [NativeName("Name", "fragmentShaderSampleInterlock")]
        public Bool32 FragmentShaderSampleInterlock;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentShaderPixelInterlock")]
        public Bool32 FragmentShaderPixelInterlock;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentShaderShadingRateInterlock")]
        public Bool32 FragmentShaderShadingRateInterlock;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceFragmentShaderInterlockFeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
