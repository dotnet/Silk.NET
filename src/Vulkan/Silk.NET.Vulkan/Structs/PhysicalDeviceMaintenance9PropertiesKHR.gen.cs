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
    [NativeName("Name", "VkPhysicalDeviceMaintenance9PropertiesKHR")]
    public unsafe partial struct PhysicalDeviceMaintenance9PropertiesKHR : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceMaintenance9PropertiesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceMaintenance9PropertiesKhr,
            void* pNext = null,
            Bool32? image2DViewOf3DSparse = null,
            DefaultVertexAttributeValueKHR? defaultVertexAttributeValue = null
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

            if (image2DViewOf3DSparse is not null)
            {
                Image2DViewOf3DSparse = image2DViewOf3DSparse.Value;
            }

            if (defaultVertexAttributeValue is not null)
            {
                DefaultVertexAttributeValue = defaultVertexAttributeValue.Value;
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
        [NativeName("Name", "image2DViewOf3DSparse")]
        public Bool32 Image2DViewOf3DSparse;
/// <summary></summary>
        [NativeName("Type", "VkDefaultVertexAttributeValueKHR")]
        [NativeName("Type.Name", "VkDefaultVertexAttributeValueKHR")]
        [NativeName("Name", "defaultVertexAttributeValue")]
        public DefaultVertexAttributeValueKHR DefaultVertexAttributeValue;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceMaintenance9PropertiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
