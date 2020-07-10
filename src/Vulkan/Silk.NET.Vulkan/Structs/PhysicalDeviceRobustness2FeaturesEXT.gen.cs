// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceRobustness2FeaturesEXT")]
    public unsafe partial struct PhysicalDeviceRobustness2FeaturesEXT
    {
        public PhysicalDeviceRobustness2FeaturesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceRobustness2FeaturesExt,
            void* pNext = default,
            Bool32 robustBufferAccess2 = default,
            Bool32 robustImageAccess2 = default,
            Bool32 nullDescriptor = default
        )
        {
            SType = sType;
            PNext = pNext;
            RobustBufferAccess2 = robustBufferAccess2;
            RobustImageAccess2 = robustImageAccess2;
            NullDescriptor = nullDescriptor;
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
        [NativeName("Name", "robustBufferAccess2")]
        public Bool32 RobustBufferAccess2;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "robustImageAccess2")]
        public Bool32 RobustImageAccess2;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "nullDescriptor")]
        public Bool32 NullDescriptor;
    }
}
