// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkExternalSemaphorePropertiesKHR")]
    public unsafe partial struct ExternalSemaphorePropertiesKHR
    {
        public ExternalSemaphorePropertiesKHR
        (
            StructureType sType = StructureType.ExternalSemaphoreProperties,
            void* pNext = default,
            ExternalSemaphoreHandleTypeFlags exportFromImportedHandleTypes = default,
            ExternalSemaphoreHandleTypeFlags compatibleHandleTypes = default,
            ExternalSemaphoreFeatureFlags externalSemaphoreFeatures = default
        )
        {
            SType = sType;
            PNext = pNext;
            ExportFromImportedHandleTypes = exportFromImportedHandleTypes;
            CompatibleHandleTypes = compatibleHandleTypes;
            ExternalSemaphoreFeatures = externalSemaphoreFeatures;
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
        [NativeName("Type", "VkExternalSemaphoreHandleTypeFlags")]
        [NativeName("Type.Name", "VkExternalSemaphoreHandleTypeFlags")]
        [NativeName("Name", "exportFromImportedHandleTypes")]
        public ExternalSemaphoreHandleTypeFlags ExportFromImportedHandleTypes;
/// <summary></summary>
        [NativeName("Type", "VkExternalSemaphoreHandleTypeFlags")]
        [NativeName("Type.Name", "VkExternalSemaphoreHandleTypeFlags")]
        [NativeName("Name", "compatibleHandleTypes")]
        public ExternalSemaphoreHandleTypeFlags CompatibleHandleTypes;
/// <summary></summary>
        [NativeName("Type", "VkExternalSemaphoreFeatureFlags")]
        [NativeName("Type.Name", "VkExternalSemaphoreFeatureFlags")]
        [NativeName("Name", "externalSemaphoreFeatures")]
        public ExternalSemaphoreFeatureFlags ExternalSemaphoreFeatures;
    }
}
