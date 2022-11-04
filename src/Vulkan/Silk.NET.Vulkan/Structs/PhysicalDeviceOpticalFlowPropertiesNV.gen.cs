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
    [NativeName("Name", "VkPhysicalDeviceOpticalFlowPropertiesNV")]
    public unsafe partial struct PhysicalDeviceOpticalFlowPropertiesNV : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceOpticalFlowPropertiesNV
        (
            StructureType? sType = StructureType.PhysicalDeviceOpticalFlowPropertiesNV,
            void* pNext = null,
            OpticalFlowGridSizeFlagsNV? supportedOutputGridSizes = null,
            OpticalFlowGridSizeFlagsNV? supportedHintGridSizes = null,
            Bool32? hintSupported = null,
            Bool32? costSupported = null,
            Bool32? bidirectionalFlowSupported = null,
            Bool32? globalFlowSupported = null,
            uint? minWidth = null,
            uint? minHeight = null,
            uint? maxWidth = null,
            uint? maxHeight = null,
            uint? maxNumRegionsOfInterest = null
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

            if (supportedOutputGridSizes is not null)
            {
                SupportedOutputGridSizes = supportedOutputGridSizes.Value;
            }

            if (supportedHintGridSizes is not null)
            {
                SupportedHintGridSizes = supportedHintGridSizes.Value;
            }

            if (hintSupported is not null)
            {
                HintSupported = hintSupported.Value;
            }

            if (costSupported is not null)
            {
                CostSupported = costSupported.Value;
            }

            if (bidirectionalFlowSupported is not null)
            {
                BidirectionalFlowSupported = bidirectionalFlowSupported.Value;
            }

            if (globalFlowSupported is not null)
            {
                GlobalFlowSupported = globalFlowSupported.Value;
            }

            if (minWidth is not null)
            {
                MinWidth = minWidth.Value;
            }

            if (minHeight is not null)
            {
                MinHeight = minHeight.Value;
            }

            if (maxWidth is not null)
            {
                MaxWidth = maxWidth.Value;
            }

            if (maxHeight is not null)
            {
                MaxHeight = maxHeight.Value;
            }

            if (maxNumRegionsOfInterest is not null)
            {
                MaxNumRegionsOfInterest = maxNumRegionsOfInterest.Value;
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
        [NativeName("Type", "VkOpticalFlowGridSizeFlagsNV")]
        [NativeName("Type.Name", "VkOpticalFlowGridSizeFlagsNV")]
        [NativeName("Name", "supportedOutputGridSizes")]
        public OpticalFlowGridSizeFlagsNV SupportedOutputGridSizes;
/// <summary></summary>
        [NativeName("Type", "VkOpticalFlowGridSizeFlagsNV")]
        [NativeName("Type.Name", "VkOpticalFlowGridSizeFlagsNV")]
        [NativeName("Name", "supportedHintGridSizes")]
        public OpticalFlowGridSizeFlagsNV SupportedHintGridSizes;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "hintSupported")]
        public Bool32 HintSupported;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "costSupported")]
        public Bool32 CostSupported;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "bidirectionalFlowSupported")]
        public Bool32 BidirectionalFlowSupported;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "globalFlowSupported")]
        public Bool32 GlobalFlowSupported;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minWidth")]
        public uint MinWidth;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minHeight")]
        public uint MinHeight;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxWidth")]
        public uint MaxWidth;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxHeight")]
        public uint MaxHeight;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxNumRegionsOfInterest")]
        public uint MaxNumRegionsOfInterest;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceOpticalFlowPropertiesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
