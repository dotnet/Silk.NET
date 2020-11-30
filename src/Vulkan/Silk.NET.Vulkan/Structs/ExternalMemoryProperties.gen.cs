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
    [NativeName("Name", "VkExternalMemoryProperties")]
    public unsafe partial struct ExternalMemoryProperties
    {
        public ExternalMemoryProperties
        (
            ExternalMemoryFeatureFlags? externalMemoryFeatures = null,
            ExternalMemoryHandleTypeFlags? exportFromImportedHandleTypes = null,
            ExternalMemoryHandleTypeFlags? compatibleHandleTypes = null
        ) : this()
        {
            if (externalMemoryFeatures is not null)
            {
                ExternalMemoryFeatures = externalMemoryFeatures.Value;
            }

            if (exportFromImportedHandleTypes is not null)
            {
                ExportFromImportedHandleTypes = exportFromImportedHandleTypes.Value;
            }

            if (compatibleHandleTypes is not null)
            {
                CompatibleHandleTypes = compatibleHandleTypes.Value;
            }
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
