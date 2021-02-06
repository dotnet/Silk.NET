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
    [NativeName("Name", "VkPhysicalDevicePortabilitySubsetFeaturesKHR")]
    public unsafe partial struct PhysicalDevicePortabilitySubsetFeaturesKHR
    {
        public PhysicalDevicePortabilitySubsetFeaturesKHR
        (
            StructureType? sType = StructureType.PhysicalDevicePortabilitySubsetFeaturesKhr,
            void* pNext = null,
            Bool32? constantAlphaColorBlendFactors = null,
            Bool32? events = null,
            Bool32? imageViewFormatReinterpretation = null,
            Bool32? imageViewFormatSwizzle = null,
            Bool32? imageView2DOn3DImage = null,
            Bool32? multisampleArrayImage = null,
            Bool32? mutableComparisonSamplers = null,
            Bool32? pointPolygons = null,
            Bool32? samplerMipLodBias = null,
            Bool32? separateStencilMaskRef = null,
            Bool32? shaderSampleRateInterpolationFunctions = null,
            Bool32? tessellationIsolines = null,
            Bool32? tessellationPointMode = null,
            Bool32? triangleFans = null,
            Bool32? vertexAttributeAccessBeyondStride = null
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

            if (constantAlphaColorBlendFactors is not null)
            {
                ConstantAlphaColorBlendFactors = constantAlphaColorBlendFactors.Value;
            }

            if (events is not null)
            {
                Events = events.Value;
            }

            if (imageViewFormatReinterpretation is not null)
            {
                ImageViewFormatReinterpretation = imageViewFormatReinterpretation.Value;
            }

            if (imageViewFormatSwizzle is not null)
            {
                ImageViewFormatSwizzle = imageViewFormatSwizzle.Value;
            }

            if (imageView2DOn3DImage is not null)
            {
                ImageView2DOn3DImage = imageView2DOn3DImage.Value;
            }

            if (multisampleArrayImage is not null)
            {
                MultisampleArrayImage = multisampleArrayImage.Value;
            }

            if (mutableComparisonSamplers is not null)
            {
                MutableComparisonSamplers = mutableComparisonSamplers.Value;
            }

            if (pointPolygons is not null)
            {
                PointPolygons = pointPolygons.Value;
            }

            if (samplerMipLodBias is not null)
            {
                SamplerMipLodBias = samplerMipLodBias.Value;
            }

            if (separateStencilMaskRef is not null)
            {
                SeparateStencilMaskRef = separateStencilMaskRef.Value;
            }

            if (shaderSampleRateInterpolationFunctions is not null)
            {
                ShaderSampleRateInterpolationFunctions = shaderSampleRateInterpolationFunctions.Value;
            }

            if (tessellationIsolines is not null)
            {
                TessellationIsolines = tessellationIsolines.Value;
            }

            if (tessellationPointMode is not null)
            {
                TessellationPointMode = tessellationPointMode.Value;
            }

            if (triangleFans is not null)
            {
                TriangleFans = triangleFans.Value;
            }

            if (vertexAttributeAccessBeyondStride is not null)
            {
                VertexAttributeAccessBeyondStride = vertexAttributeAccessBeyondStride.Value;
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
        [NativeName("Name", "constantAlphaColorBlendFactors")]
        public Bool32 ConstantAlphaColorBlendFactors;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "events")]
        public Bool32 Events;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "imageViewFormatReinterpretation")]
        public Bool32 ImageViewFormatReinterpretation;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "imageViewFormatSwizzle")]
        public Bool32 ImageViewFormatSwizzle;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "imageView2DOn3DImage")]
        public Bool32 ImageView2DOn3DImage;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "multisampleArrayImage")]
        public Bool32 MultisampleArrayImage;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "mutableComparisonSamplers")]
        public Bool32 MutableComparisonSamplers;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "pointPolygons")]
        public Bool32 PointPolygons;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "samplerMipLodBias")]
        public Bool32 SamplerMipLodBias;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "separateStencilMaskRef")]
        public Bool32 SeparateStencilMaskRef;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSampleRateInterpolationFunctions")]
        public Bool32 ShaderSampleRateInterpolationFunctions;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tessellationIsolines")]
        public Bool32 TessellationIsolines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tessellationPointMode")]
        public Bool32 TessellationPointMode;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "triangleFans")]
        public Bool32 TriangleFans;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "vertexAttributeAccessBeyondStride")]
        public Bool32 VertexAttributeAccessBeyondStride;
    }
}
