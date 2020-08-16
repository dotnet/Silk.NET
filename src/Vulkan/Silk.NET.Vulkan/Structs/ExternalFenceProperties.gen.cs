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
    [NativeName("Name", "VkExternalFenceProperties")]
    public unsafe partial struct ExternalFenceProperties
    {
        public ExternalFenceProperties
        (
            StructureType sType = StructureType.ExternalFenceProperties,
            void* pNext = default,
            ExternalFenceHandleTypeFlags exportFromImportedHandleTypes = default,
            ExternalFenceHandleTypeFlags compatibleHandleTypes = default,
            ExternalFenceFeatureFlags externalFenceFeatures = default
        )
        {
            SType = sType;
            PNext = pNext;
            ExportFromImportedHandleTypes = exportFromImportedHandleTypes;
            CompatibleHandleTypes = compatibleHandleTypes;
            ExternalFenceFeatures = externalFenceFeatures;
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
        [NativeName("Type", "VkExternalFenceHandleTypeFlags")]
        [NativeName("Type.Name", "VkExternalFenceHandleTypeFlags")]
        [NativeName("Name", "exportFromImportedHandleTypes")]
        public ExternalFenceHandleTypeFlags ExportFromImportedHandleTypes;
/// <summary></summary>
        [NativeName("Type", "VkExternalFenceHandleTypeFlags")]
        [NativeName("Type.Name", "VkExternalFenceHandleTypeFlags")]
        [NativeName("Name", "compatibleHandleTypes")]
        public ExternalFenceHandleTypeFlags CompatibleHandleTypes;
/// <summary></summary>
        [NativeName("Type", "VkExternalFenceFeatureFlags")]
        [NativeName("Type.Name", "VkExternalFenceFeatureFlags")]
        [NativeName("Name", "externalFenceFeatures")]
        public ExternalFenceFeatureFlags ExternalFenceFeatures;
    }
}
