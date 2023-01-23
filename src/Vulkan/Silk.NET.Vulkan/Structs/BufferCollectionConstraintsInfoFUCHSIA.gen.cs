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
    [NativeName("Name", "VkBufferCollectionConstraintsInfoFUCHSIA")]
    public unsafe partial struct BufferCollectionConstraintsInfoFUCHSIA : IChainable
    {
        public BufferCollectionConstraintsInfoFUCHSIA
        (
            StructureType? sType = StructureType.BufferCollectionConstraintsInfoFuchsia,
            void* pNext = null,
            uint? minBufferCount = null,
            uint? maxBufferCount = null,
            uint? minBufferCountForCamping = null,
            uint? minBufferCountForDedicatedSlack = null,
            uint? minBufferCountForSharedSlack = null
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

            if (minBufferCount is not null)
            {
                MinBufferCount = minBufferCount.Value;
            }

            if (maxBufferCount is not null)
            {
                MaxBufferCount = maxBufferCount.Value;
            }

            if (minBufferCountForCamping is not null)
            {
                MinBufferCountForCamping = minBufferCountForCamping.Value;
            }

            if (minBufferCountForDedicatedSlack is not null)
            {
                MinBufferCountForDedicatedSlack = minBufferCountForDedicatedSlack.Value;
            }

            if (minBufferCountForSharedSlack is not null)
            {
                MinBufferCountForSharedSlack = minBufferCountForSharedSlack.Value;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minBufferCount")]
        public uint MinBufferCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxBufferCount")]
        public uint MaxBufferCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minBufferCountForCamping")]
        public uint MinBufferCountForCamping;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minBufferCountForDedicatedSlack")]
        public uint MinBufferCountForDedicatedSlack;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minBufferCountForSharedSlack")]
        public uint MinBufferCountForSharedSlack;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.BufferCollectionConstraintsInfoFuchsia;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
