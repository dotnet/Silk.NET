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
    [NativeName("Name", "VkPhysicalDeviceSparseProperties")]
    public unsafe partial struct PhysicalDeviceSparseProperties
    {
        public PhysicalDeviceSparseProperties
        (
            Bool32? residencyStandard2DBlockShape = null,
            Bool32? residencyStandard2DMultisampleBlockShape = null,
            Bool32? residencyStandard3DBlockShape = null,
            Bool32? residencyAlignedMipSize = null,
            Bool32? residencyNonResidentStrict = null
        ) : this()
        {
            if (residencyStandard2DBlockShape is not null)
            {
                ResidencyStandard2DBlockShape = residencyStandard2DBlockShape.Value;
            }

            if (residencyStandard2DMultisampleBlockShape is not null)
            {
                ResidencyStandard2DMultisampleBlockShape = residencyStandard2DMultisampleBlockShape.Value;
            }

            if (residencyStandard3DBlockShape is not null)
            {
                ResidencyStandard3DBlockShape = residencyStandard3DBlockShape.Value;
            }

            if (residencyAlignedMipSize is not null)
            {
                ResidencyAlignedMipSize = residencyAlignedMipSize.Value;
            }

            if (residencyNonResidentStrict is not null)
            {
                ResidencyNonResidentStrict = residencyNonResidentStrict.Value;
            }
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
