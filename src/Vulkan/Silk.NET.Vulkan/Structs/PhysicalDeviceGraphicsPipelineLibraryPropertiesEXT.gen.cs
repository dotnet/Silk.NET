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
    [NativeName("Name", "VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceGraphicsPipelineLibraryPropertiesEXT : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceGraphicsPipelineLibraryPropertiesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceGraphicsPipelineLibraryPropertiesExt,
            void* pNext = null,
            Bool32? graphicsPipelineLibraryFastLinking = null,
            Bool32? graphicsPipelineLibraryIndependentInterpolationDecoration = null
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

            if (graphicsPipelineLibraryFastLinking is not null)
            {
                GraphicsPipelineLibraryFastLinking = graphicsPipelineLibraryFastLinking.Value;
            }

            if (graphicsPipelineLibraryIndependentInterpolationDecoration is not null)
            {
                GraphicsPipelineLibraryIndependentInterpolationDecoration = graphicsPipelineLibraryIndependentInterpolationDecoration.Value;
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
        [NativeName("Name", "graphicsPipelineLibraryFastLinking")]
        public Bool32 GraphicsPipelineLibraryFastLinking;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "graphicsPipelineLibraryIndependentInterpolationDecoration")]
        public Bool32 GraphicsPipelineLibraryIndependentInterpolationDecoration;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceGraphicsPipelineLibraryPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
