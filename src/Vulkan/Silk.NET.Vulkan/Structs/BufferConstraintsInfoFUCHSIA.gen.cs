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
    [NativeName("Name", "VkBufferConstraintsInfoFUCHSIA")]
    public unsafe partial struct BufferConstraintsInfoFUCHSIA : IChainable
    {
        public BufferConstraintsInfoFUCHSIA
        (
            StructureType? sType = StructureType.BufferConstraintsInfoFuchsia,
            void* pNext = null,
            BufferCreateInfo? createInfo = null,
            FormatFeatureFlags? requiredFormatFeatures = null,
            BufferCollectionConstraintsInfoFUCHSIA? bufferCollectionConstraints = null
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

            if (createInfo is not null)
            {
                CreateInfo = createInfo.Value;
            }

            if (requiredFormatFeatures is not null)
            {
                RequiredFormatFeatures = requiredFormatFeatures.Value;
            }

            if (bufferCollectionConstraints is not null)
            {
                BufferCollectionConstraints = bufferCollectionConstraints.Value;
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
        [NativeName("Type", "VkBufferCreateInfo")]
        [NativeName("Type.Name", "VkBufferCreateInfo")]
        [NativeName("Name", "createInfo")]
        public BufferCreateInfo CreateInfo;
/// <summary></summary>
        [NativeName("Type", "VkFormatFeatureFlags")]
        [NativeName("Type.Name", "VkFormatFeatureFlags")]
        [NativeName("Name", "requiredFormatFeatures")]
        public FormatFeatureFlags RequiredFormatFeatures;
/// <summary></summary>
        [NativeName("Type", "VkBufferCollectionConstraintsInfoFUCHSIA")]
        [NativeName("Type.Name", "VkBufferCollectionConstraintsInfoFUCHSIA")]
        [NativeName("Name", "bufferCollectionConstraints")]
        public BufferCollectionConstraintsInfoFUCHSIA BufferCollectionConstraints;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.BufferConstraintsInfoFuchsia;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
