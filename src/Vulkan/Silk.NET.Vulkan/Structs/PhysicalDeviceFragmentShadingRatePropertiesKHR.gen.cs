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
    [NativeName("Name", "VkPhysicalDeviceFragmentShadingRatePropertiesKHR")]
    public unsafe partial struct PhysicalDeviceFragmentShadingRatePropertiesKHR
    {
        public PhysicalDeviceFragmentShadingRatePropertiesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceFragmentShadingRatePropertiesKhr,
            void* pNext = null,
            Extent2D? minFragmentShadingRateAttachmentTexelSize = null,
            Extent2D? maxFragmentShadingRateAttachmentTexelSize = null,
            uint? maxFragmentShadingRateAttachmentTexelSizeAspectRatio = null,
            Bool32? primitiveFragmentShadingRateWithMultipleViewports = null,
            Bool32? layeredShadingRateAttachments = null,
            Bool32? fragmentShadingRateNonTrivialCombinerOps = null,
            Extent2D? maxFragmentSize = null,
            uint? maxFragmentSizeAspectRatio = null,
            uint? maxFragmentShadingRateCoverageSamples = null,
            SampleCountFlags? maxFragmentShadingRateRasterizationSamples = null,
            Bool32? fragmentShadingRateWithShaderDepthStencilWrites = null,
            Bool32? fragmentShadingRateWithSampleMask = null,
            Bool32? fragmentShadingRateWithShaderSampleMask = null,
            Bool32? fragmentShadingRateWithConservativeRasterization = null,
            Bool32? fragmentShadingRateWithFragmentShaderInterlock = null,
            Bool32? fragmentShadingRateWithCustomSampleLocations = null,
            Bool32? fragmentShadingRateStrictMultiplyCombiner = null
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

            if (minFragmentShadingRateAttachmentTexelSize is not null)
            {
                MinFragmentShadingRateAttachmentTexelSize = minFragmentShadingRateAttachmentTexelSize.Value;
            }

            if (maxFragmentShadingRateAttachmentTexelSize is not null)
            {
                MaxFragmentShadingRateAttachmentTexelSize = maxFragmentShadingRateAttachmentTexelSize.Value;
            }

            if (maxFragmentShadingRateAttachmentTexelSizeAspectRatio is not null)
            {
                MaxFragmentShadingRateAttachmentTexelSizeAspectRatio = maxFragmentShadingRateAttachmentTexelSizeAspectRatio.Value;
            }

            if (primitiveFragmentShadingRateWithMultipleViewports is not null)
            {
                PrimitiveFragmentShadingRateWithMultipleViewports = primitiveFragmentShadingRateWithMultipleViewports.Value;
            }

            if (layeredShadingRateAttachments is not null)
            {
                LayeredShadingRateAttachments = layeredShadingRateAttachments.Value;
            }

            if (fragmentShadingRateNonTrivialCombinerOps is not null)
            {
                FragmentShadingRateNonTrivialCombinerOps = fragmentShadingRateNonTrivialCombinerOps.Value;
            }

            if (maxFragmentSize is not null)
            {
                MaxFragmentSize = maxFragmentSize.Value;
            }

            if (maxFragmentSizeAspectRatio is not null)
            {
                MaxFragmentSizeAspectRatio = maxFragmentSizeAspectRatio.Value;
            }

            if (maxFragmentShadingRateCoverageSamples is not null)
            {
                MaxFragmentShadingRateCoverageSamples = maxFragmentShadingRateCoverageSamples.Value;
            }

            if (maxFragmentShadingRateRasterizationSamples is not null)
            {
                MaxFragmentShadingRateRasterizationSamples = maxFragmentShadingRateRasterizationSamples.Value;
            }

            if (fragmentShadingRateWithShaderDepthStencilWrites is not null)
            {
                FragmentShadingRateWithShaderDepthStencilWrites = fragmentShadingRateWithShaderDepthStencilWrites.Value;
            }

            if (fragmentShadingRateWithSampleMask is not null)
            {
                FragmentShadingRateWithSampleMask = fragmentShadingRateWithSampleMask.Value;
            }

            if (fragmentShadingRateWithShaderSampleMask is not null)
            {
                FragmentShadingRateWithShaderSampleMask = fragmentShadingRateWithShaderSampleMask.Value;
            }

            if (fragmentShadingRateWithConservativeRasterization is not null)
            {
                FragmentShadingRateWithConservativeRasterization = fragmentShadingRateWithConservativeRasterization.Value;
            }

            if (fragmentShadingRateWithFragmentShaderInterlock is not null)
            {
                FragmentShadingRateWithFragmentShaderInterlock = fragmentShadingRateWithFragmentShaderInterlock.Value;
            }

            if (fragmentShadingRateWithCustomSampleLocations is not null)
            {
                FragmentShadingRateWithCustomSampleLocations = fragmentShadingRateWithCustomSampleLocations.Value;
            }

            if (fragmentShadingRateStrictMultiplyCombiner is not null)
            {
                FragmentShadingRateStrictMultiplyCombiner = fragmentShadingRateStrictMultiplyCombiner.Value;
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
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "minFragmentShadingRateAttachmentTexelSize")]
        public Extent2D MinFragmentShadingRateAttachmentTexelSize;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxFragmentShadingRateAttachmentTexelSize")]
        public Extent2D MaxFragmentShadingRateAttachmentTexelSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxFragmentShadingRateAttachmentTexelSizeAspectRatio")]
        public uint MaxFragmentShadingRateAttachmentTexelSizeAspectRatio;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "primitiveFragmentShadingRateWithMultipleViewports")]
        public Bool32 PrimitiveFragmentShadingRateWithMultipleViewports;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "layeredShadingRateAttachments")]
        public Bool32 LayeredShadingRateAttachments;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentShadingRateNonTrivialCombinerOps")]
        public Bool32 FragmentShadingRateNonTrivialCombinerOps;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxFragmentSize")]
        public Extent2D MaxFragmentSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxFragmentSizeAspectRatio")]
        public uint MaxFragmentSizeAspectRatio;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxFragmentShadingRateCoverageSamples")]
        public uint MaxFragmentShadingRateCoverageSamples;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlagBits")]
        [NativeName("Type.Name", "VkSampleCountFlagBits")]
        [NativeName("Name", "maxFragmentShadingRateRasterizationSamples")]
        public SampleCountFlags MaxFragmentShadingRateRasterizationSamples;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentShadingRateWithShaderDepthStencilWrites")]
        public Bool32 FragmentShadingRateWithShaderDepthStencilWrites;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentShadingRateWithSampleMask")]
        public Bool32 FragmentShadingRateWithSampleMask;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentShadingRateWithShaderSampleMask")]
        public Bool32 FragmentShadingRateWithShaderSampleMask;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentShadingRateWithConservativeRasterization")]
        public Bool32 FragmentShadingRateWithConservativeRasterization;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentShadingRateWithFragmentShaderInterlock")]
        public Bool32 FragmentShadingRateWithFragmentShaderInterlock;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentShadingRateWithCustomSampleLocations")]
        public Bool32 FragmentShadingRateWithCustomSampleLocations;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentShadingRateStrictMultiplyCombiner")]
        public Bool32 FragmentShadingRateStrictMultiplyCombiner;
    }
}
