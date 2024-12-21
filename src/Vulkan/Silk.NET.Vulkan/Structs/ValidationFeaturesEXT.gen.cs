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
    [NativeName("Name", "VkValidationFeaturesEXT")]
    public unsafe partial struct ValidationFeaturesEXT : IExtendsChain<InstanceCreateInfo>, IExtendsChain<ShaderModuleCreateInfo>, IExtendsChain<ShaderCreateInfoEXT>
    {
        public ValidationFeaturesEXT
        (
            StructureType? sType = StructureType.ValidationFeaturesExt,
            void* pNext = null,
            uint? enabledValidationFeatureCount = null,
            ValidationFeatureEnableEXT* pEnabledValidationFeatures = null,
            uint? disabledValidationFeatureCount = null,
            ValidationFeatureDisableEXT* pDisabledValidationFeatures = null
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

            if (enabledValidationFeatureCount is not null)
            {
                EnabledValidationFeatureCount = enabledValidationFeatureCount.Value;
            }

            if (pEnabledValidationFeatures is not null)
            {
                PEnabledValidationFeatures = pEnabledValidationFeatures;
            }

            if (disabledValidationFeatureCount is not null)
            {
                DisabledValidationFeatureCount = disabledValidationFeatureCount.Value;
            }

            if (pDisabledValidationFeatures is not null)
            {
                PDisabledValidationFeatures = pDisabledValidationFeatures;
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
        [NativeName("Name", "enabledValidationFeatureCount")]
        public uint EnabledValidationFeatureCount;
/// <summary></summary>
        [NativeName("Type", "VkValidationFeatureEnableEXT*")]
        [NativeName("Type.Name", "VkValidationFeatureEnableEXT")]
        [NativeName("Name", "pEnabledValidationFeatures")]
        public ValidationFeatureEnableEXT* PEnabledValidationFeatures;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "disabledValidationFeatureCount")]
        public uint DisabledValidationFeatureCount;
/// <summary></summary>
        [NativeName("Type", "VkValidationFeatureDisableEXT*")]
        [NativeName("Type.Name", "VkValidationFeatureDisableEXT")]
        [NativeName("Name", "pDisabledValidationFeatures")]
        public ValidationFeatureDisableEXT* PDisabledValidationFeatures;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ValidationFeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
