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
    [NativeName("Name", "VkExternalSemaphoreProperties")]
    [NativeName("Aliases", "VkExternalSemaphorePropertiesKHR")]
    public unsafe partial struct ExternalSemaphoreProperties : IChainable
    {
        public ExternalSemaphoreProperties
        (
            StructureType? sType = StructureType.ExternalSemaphoreProperties,
            void* pNext = null,
            ExternalSemaphoreHandleTypeFlags? exportFromImportedHandleTypes = null,
            ExternalSemaphoreHandleTypeFlags? compatibleHandleTypes = null,
            ExternalSemaphoreFeatureFlags? externalSemaphoreFeatures = null
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

            if (externalSemaphoreFeatures is not null)
            {
                ExternalSemaphoreFeatures = externalSemaphoreFeatures.Value;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ExternalSemaphoreProperties;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
