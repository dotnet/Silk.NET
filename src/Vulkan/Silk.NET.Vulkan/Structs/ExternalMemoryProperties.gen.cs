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
    [NativeName("Name", "VkExternalMemoryProperties")]
    public unsafe partial struct ExternalMemoryProperties
    {
        public ExternalMemoryProperties
        (
            ExternalMemoryFeatureFlags externalMemoryFeatures = default,
            ExternalMemoryHandleTypeFlags exportFromImportedHandleTypes = default,
            ExternalMemoryHandleTypeFlags compatibleHandleTypes = default
        )
        {
            ExternalMemoryFeatures = externalMemoryFeatures;
            ExportFromImportedHandleTypes = exportFromImportedHandleTypes;
            CompatibleHandleTypes = compatibleHandleTypes;
        }

/// <summary></summary>
        [NativeName("Type", "VkExternalMemoryFeatureFlags")]
        [NativeName("Type.Name", "VkExternalMemoryFeatureFlags")]
        [NativeName("Name", "externalMemoryFeatures")]
        public ExternalMemoryFeatureFlags ExternalMemoryFeatures;
/// <summary></summary>
        [NativeName("Type", "VkExternalMemoryHandleTypeFlags")]
        [NativeName("Type.Name", "VkExternalMemoryHandleTypeFlags")]
        [NativeName("Name", "exportFromImportedHandleTypes")]
        public ExternalMemoryHandleTypeFlags ExportFromImportedHandleTypes;
/// <summary></summary>
        [NativeName("Type", "VkExternalMemoryHandleTypeFlags")]
        [NativeName("Type.Name", "VkExternalMemoryHandleTypeFlags")]
        [NativeName("Name", "compatibleHandleTypes")]
        public ExternalMemoryHandleTypeFlags CompatibleHandleTypes;
    }
}
