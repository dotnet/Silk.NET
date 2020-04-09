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
    public unsafe struct ExternalMemoryProperties
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
        public ExternalMemoryFeatureFlags ExternalMemoryFeatures;
/// <summary></summary>
        public ExternalMemoryHandleTypeFlags ExportFromImportedHandleTypes;
/// <summary></summary>
        public ExternalMemoryHandleTypeFlags CompatibleHandleTypes;
    }
}
