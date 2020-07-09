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
    [NativeName("Name", "VkPhysicalDeviceSparseProperties")]
    public unsafe struct PhysicalDeviceSparseProperties
    {
        public PhysicalDeviceSparseProperties
        (
            Bool32 residencyStandard2DBlockShape = default,
            Bool32 residencyStandard2DMultisampleBlockShape = default,
            Bool32 residencyStandard3DBlockShape = default,
            Bool32 residencyAlignedMipSize = default,
            Bool32 residencyNonResidentStrict = default
        )
        {
           ResidencyStandard2DBlockShape = residencyStandard2DBlockShape;
           ResidencyStandard2DMultisampleBlockShape = residencyStandard2DMultisampleBlockShape;
           ResidencyStandard3DBlockShape = residencyStandard3DBlockShape;
           ResidencyAlignedMipSize = residencyAlignedMipSize;
           ResidencyNonResidentStrict = residencyNonResidentStrict;
        }

/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "residencyStandard2DBlockShape")]
        public Bool32 ResidencyStandard2DBlockShape;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "residencyStandard2DMultisampleBlockShape")]
        public Bool32 ResidencyStandard2DMultisampleBlockShape;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "residencyStandard3DBlockShape")]
        public Bool32 ResidencyStandard3DBlockShape;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "residencyAlignedMipSize")]
        public Bool32 ResidencyAlignedMipSize;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "residencyNonResidentStrict")]
        public Bool32 ResidencyNonResidentStrict;
    }
}
