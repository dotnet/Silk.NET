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
    [NativeName("Name", "VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM")]
    [NativeName("AliasOf", "VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM
        (
            StructureType? sType = StructureType.PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesExt,
            void* pNext = null,
            Bool32? rasterizationOrderColorAttachmentAccess = null,
            Bool32? rasterizationOrderDepthAttachmentAccess = null,
            Bool32? rasterizationOrderStencilAttachmentAccess = null
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

            if (rasterizationOrderColorAttachmentAccess is not null)
            {
                RasterizationOrderColorAttachmentAccess = rasterizationOrderColorAttachmentAccess.Value;
            }

            if (rasterizationOrderDepthAttachmentAccess is not null)
            {
                RasterizationOrderDepthAttachmentAccess = rasterizationOrderDepthAttachmentAccess.Value;
            }

            if (rasterizationOrderStencilAttachmentAccess is not null)
            {
                RasterizationOrderStencilAttachmentAccess = rasterizationOrderStencilAttachmentAccess.Value;
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
        [NativeName("Name", "rasterizationOrderColorAttachmentAccess")]
        public Bool32 RasterizationOrderColorAttachmentAccess;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rasterizationOrderDepthAttachmentAccess")]
        public Bool32 RasterizationOrderDepthAttachmentAccess;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rasterizationOrderStencilAttachmentAccess")]
        public Bool32 RasterizationOrderStencilAttachmentAccess;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
