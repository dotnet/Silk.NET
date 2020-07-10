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
    [NativeName("Name", "VkExternalImageFormatPropertiesNV")]
    public unsafe partial struct ExternalImageFormatPropertiesNV
    {
        public ExternalImageFormatPropertiesNV
        (
            ImageFormatProperties imageFormatProperties = default,
            ExternalMemoryFeatureFlagsNV externalMemoryFeatures = default,
            ExternalMemoryHandleTypeFlagsNV exportFromImportedHandleTypes = default,
            ExternalMemoryHandleTypeFlagsNV compatibleHandleTypes = default
        )
        {
            ImageFormatProperties = imageFormatProperties;
            ExternalMemoryFeatures = externalMemoryFeatures;
            ExportFromImportedHandleTypes = exportFromImportedHandleTypes;
            CompatibleHandleTypes = compatibleHandleTypes;
        }

/// <summary></summary>
        [NativeName("Type", "VkImageFormatProperties")]
        [NativeName("Type.Name", "VkImageFormatProperties")]
        [NativeName("Name", "imageFormatProperties")]
        public ImageFormatProperties ImageFormatProperties;
/// <summary></summary>
        [NativeName("Type", "VkExternalMemoryFeatureFlagsNV")]
        [NativeName("Type.Name", "VkExternalMemoryFeatureFlagsNV")]
        [NativeName("Name", "externalMemoryFeatures")]
        public ExternalMemoryFeatureFlagsNV ExternalMemoryFeatures;
/// <summary></summary>
        [NativeName("Type", "VkExternalMemoryHandleTypeFlagsNV")]
        [NativeName("Type.Name", "VkExternalMemoryHandleTypeFlagsNV")]
        [NativeName("Name", "exportFromImportedHandleTypes")]
        public ExternalMemoryHandleTypeFlagsNV ExportFromImportedHandleTypes;
/// <summary></summary>
        [NativeName("Type", "VkExternalMemoryHandleTypeFlagsNV")]
        [NativeName("Type.Name", "VkExternalMemoryHandleTypeFlagsNV")]
        [NativeName("Name", "compatibleHandleTypes")]
        public ExternalMemoryHandleTypeFlagsNV CompatibleHandleTypes;
    }
}
