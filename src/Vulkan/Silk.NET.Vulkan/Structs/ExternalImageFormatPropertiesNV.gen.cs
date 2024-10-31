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
    [NativeName("Name", "VkExternalImageFormatPropertiesNV")]
    public unsafe partial struct ExternalImageFormatPropertiesNV
    {
        public ExternalImageFormatPropertiesNV
        (
            ImageFormatProperties? imageFormatProperties = null,
            ExternalMemoryFeatureFlagsNV? externalMemoryFeatures = null,
            ExternalMemoryHandleTypeFlagsNV? exportFromImportedHandleTypes = null,
            ExternalMemoryHandleTypeFlagsNV? compatibleHandleTypes = null
        ) : this()
        {
            if (imageFormatProperties is not null)
            {
                ImageFormatProperties = imageFormatProperties.Value;
            }

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
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
