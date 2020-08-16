// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkValidationFeaturesEXT")]
    public unsafe partial struct ValidationFeaturesEXT
    {
        public ValidationFeaturesEXT
        (
            StructureType sType = StructureType.ValidationFeaturesExt,
            void* pNext = default,
            uint enabledValidationFeatureCount = default,
            ValidationFeatureEnableEXT* pEnabledValidationFeatures = default,
            uint disabledValidationFeatureCount = default,
            ValidationFeatureDisableEXT* pDisabledValidationFeatures = default
        )
        {
            SType = sType;
            PNext = pNext;
            EnabledValidationFeatureCount = enabledValidationFeatureCount;
            PEnabledValidationFeatures = pEnabledValidationFeatures;
            DisabledValidationFeatureCount = disabledValidationFeatureCount;
            PDisabledValidationFeatures = pDisabledValidationFeatures;
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
    }
}
