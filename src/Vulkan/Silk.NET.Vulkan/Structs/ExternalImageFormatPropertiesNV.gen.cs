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
    public unsafe struct ExternalImageFormatPropertiesNV
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
        public ImageFormatProperties ImageFormatProperties;
/// <summary></summary>
        public ExternalMemoryFeatureFlagsNV ExternalMemoryFeatures;
/// <summary></summary>
        public ExternalMemoryHandleTypeFlagsNV ExportFromImportedHandleTypes;
/// <summary></summary>
        public ExternalMemoryHandleTypeFlagsNV CompatibleHandleTypes;
    }
}
