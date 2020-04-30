// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct ValidationFeaturesEXT
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint EnabledValidationFeatureCount;
/// <summary></summary>
        public ValidationFeatureEnableEXT* PEnabledValidationFeatures;
/// <summary></summary>
        public uint DisabledValidationFeatureCount;
/// <summary></summary>
        public ValidationFeatureDisableEXT* PDisabledValidationFeatures;
    }
}
