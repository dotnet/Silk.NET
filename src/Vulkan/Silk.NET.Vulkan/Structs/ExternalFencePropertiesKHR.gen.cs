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
    [NativeName("Name", "VkExternalFencePropertiesKHR")]
    [NativeName("AliasOf", "VkExternalFenceProperties")]
    public unsafe partial struct ExternalFencePropertiesKHR : IChainable
    {
        public ExternalFencePropertiesKHR
        (
            StructureType? sType = StructureType.ExternalFenceProperties,
            void* pNext = null,
            ExternalFenceHandleTypeFlags? exportFromImportedHandleTypes = null,
            ExternalFenceHandleTypeFlags? compatibleHandleTypes = null,
            ExternalFenceFeatureFlags? externalFenceFeatures = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (exportFromImportedHandleTypes is not null)
            {
                ExportFromImportedHandleTypes = exportFromImportedHandleTypes.Value;
            }

            if (compatibleHandleTypes is not null)
            {
                CompatibleHandleTypes = compatibleHandleTypes.Value;
            }

            if (externalFenceFeatures is not null)
            {
                ExternalFenceFeatures = externalFenceFeatures.Value;
            }
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ExternalFenceProperties;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
