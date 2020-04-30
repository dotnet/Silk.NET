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
    public unsafe struct ExternalFenceProperties
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ExternalFenceHandleTypeFlags ExportFromImportedHandleTypes;
/// <summary></summary>
        public ExternalFenceHandleTypeFlags CompatibleHandleTypes;
/// <summary></summary>
        public ExternalFenceFeatureFlags ExternalFenceFeatures;
    }
}
