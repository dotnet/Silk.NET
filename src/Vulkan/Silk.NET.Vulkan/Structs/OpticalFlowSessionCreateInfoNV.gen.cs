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
    [NativeName("Name", "VkOpticalFlowSessionCreateInfoNV")]
    public unsafe partial struct OpticalFlowSessionCreateInfoNV : IChainStart
    {
        public OpticalFlowSessionCreateInfoNV
        (
            StructureType? sType = StructureType.OpticalFlowSessionCreateInfoNV,
            void* pNext = null,
            uint? width = null,
            uint? height = null,
            Format? imageFormat = null,
            Format? flowVectorFormat = null,
            Format? costFormat = null,
            OpticalFlowGridSizeFlagsNV? outputGridSize = null,
            OpticalFlowGridSizeFlagsNV? hintGridSize = null,
            OpticalFlowPerformanceLevelNV? performanceLevel = null,
            OpticalFlowSessionCreateFlagsNV? flags = null
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

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (imageFormat is not null)
            {
                ImageFormat = imageFormat.Value;
            }

            if (flowVectorFormat is not null)
            {
                FlowVectorFormat = flowVectorFormat.Value;
            }

            if (costFormat is not null)
            {
                CostFormat = costFormat.Value;
            }

            if (outputGridSize is not null)
            {
                OutputGridSize = outputGridSize.Value;
            }

            if (hintGridSize is not null)
            {
                HintGridSize = hintGridSize.Value;
            }

            if (performanceLevel is not null)
            {
                PerformanceLevel = performanceLevel.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "width")]
        public uint Width;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "height")]
        public uint Height;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "imageFormat")]
        public Format ImageFormat;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "flowVectorFormat")]
        public Format FlowVectorFormat;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "costFormat")]
        public Format CostFormat;
/// <summary></summary>
        [NativeName("Type", "VkOpticalFlowGridSizeFlagsNV")]
        [NativeName("Type.Name", "VkOpticalFlowGridSizeFlagsNV")]
        [NativeName("Name", "outputGridSize")]
        public OpticalFlowGridSizeFlagsNV OutputGridSize;
/// <summary></summary>
        [NativeName("Type", "VkOpticalFlowGridSizeFlagsNV")]
        [NativeName("Type.Name", "VkOpticalFlowGridSizeFlagsNV")]
        [NativeName("Name", "hintGridSize")]
        public OpticalFlowGridSizeFlagsNV HintGridSize;
/// <summary></summary>
        [NativeName("Type", "VkOpticalFlowPerformanceLevelNV")]
        [NativeName("Type.Name", "VkOpticalFlowPerformanceLevelNV")]
        [NativeName("Name", "performanceLevel")]
        public OpticalFlowPerformanceLevelNV PerformanceLevel;
/// <summary></summary>
        [NativeName("Type", "VkOpticalFlowSessionCreateFlagsNV")]
        [NativeName("Type.Name", "VkOpticalFlowSessionCreateFlagsNV")]
        [NativeName("Name", "flags")]
        public OpticalFlowSessionCreateFlagsNV Flags;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.OpticalFlowSessionCreateInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref OpticalFlowSessionCreateInfoNV Chain(
            out OpticalFlowSessionCreateInfoNV capture)
        {
            capture = new OpticalFlowSessionCreateInfoNV(StructureType.OpticalFlowSessionCreateInfoNV);
            return ref capture;
        }
    }
}
