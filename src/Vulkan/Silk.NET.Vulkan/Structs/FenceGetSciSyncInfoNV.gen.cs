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
    [NativeName("Name", "VkFenceGetSciSyncInfoNV")]
    public unsafe partial struct FenceGetSciSyncInfoNV : IChainable
    {
        public FenceGetSciSyncInfoNV
        (
            StructureType? sType = StructureType.FenceGetSciSyncInfoNV,
            void* pNext = null,
            Fence? fence = null,
            ExternalFenceHandleTypeFlags? handleType = null
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

            if (fence is not null)
            {
                Fence = fence.Value;
            }

            if (handleType is not null)
            {
                HandleType = handleType.Value;
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
        [NativeName("Type", "VkFence")]
        [NativeName("Type.Name", "VkFence")]
        [NativeName("Name", "fence")]
        public Fence Fence;
/// <summary></summary>
        [NativeName("Type", "VkExternalFenceHandleTypeFlagBits")]
        [NativeName("Type.Name", "VkExternalFenceHandleTypeFlagBits")]
        [NativeName("Name", "handleType")]
        public ExternalFenceHandleTypeFlags HandleType;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.FenceGetSciSyncInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
