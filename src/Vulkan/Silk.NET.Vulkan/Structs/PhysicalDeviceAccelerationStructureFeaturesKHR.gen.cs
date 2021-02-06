// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkPhysicalDeviceAccelerationStructureFeaturesKHR")]
    public unsafe partial struct PhysicalDeviceAccelerationStructureFeaturesKHR
    {
        public PhysicalDeviceAccelerationStructureFeaturesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr,
            void* pNext = null,
            Bool32? accelerationStructure = null,
            Bool32? accelerationStructureCaptureReplay = null,
            Bool32? accelerationStructureIndirectBuild = null,
            Bool32? accelerationStructureHostCommands = null,
            Bool32? descriptorBindingAccelerationStructureUpdateAfterBind = null
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

            if (accelerationStructure is not null)
            {
                AccelerationStructure = accelerationStructure.Value;
            }

            if (accelerationStructureCaptureReplay is not null)
            {
                AccelerationStructureCaptureReplay = accelerationStructureCaptureReplay.Value;
            }

            if (accelerationStructureIndirectBuild is not null)
            {
                AccelerationStructureIndirectBuild = accelerationStructureIndirectBuild.Value;
            }

            if (accelerationStructureHostCommands is not null)
            {
                AccelerationStructureHostCommands = accelerationStructureHostCommands.Value;
            }

            if (descriptorBindingAccelerationStructureUpdateAfterBind is not null)
            {
                DescriptorBindingAccelerationStructureUpdateAfterBind = descriptorBindingAccelerationStructureUpdateAfterBind.Value;
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
        [NativeName("Name", "accelerationStructure")]
        public Bool32 AccelerationStructure;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "accelerationStructureCaptureReplay")]
        public Bool32 AccelerationStructureCaptureReplay;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "accelerationStructureIndirectBuild")]
        public Bool32 AccelerationStructureIndirectBuild;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "accelerationStructureHostCommands")]
        public Bool32 AccelerationStructureHostCommands;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "descriptorBindingAccelerationStructureUpdateAfterBind")]
        public Bool32 DescriptorBindingAccelerationStructureUpdateAfterBind;
    }
}
