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
    [NativeName("Name", "VkBufferCollectionBufferCreateInfoFUCHSIA")]
    public unsafe partial struct BufferCollectionBufferCreateInfoFUCHSIA : IExtendsChain<BufferCreateInfo>
    {
        public BufferCollectionBufferCreateInfoFUCHSIA
        (
            StructureType? sType = StructureType.BufferCollectionBufferCreateInfoFuchsia,
            void* pNext = null,
            BufferCollectionFUCHSIA? collection = null,
            uint? index = null
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

            if (collection is not null)
            {
                Collection = collection.Value;
            }

            if (index is not null)
            {
                Index = index.Value;
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
        [NativeName("Type", "VkBufferCollectionFUCHSIA")]
        [NativeName("Type.Name", "VkBufferCollectionFUCHSIA")]
        [NativeName("Name", "collection")]
        public BufferCollectionFUCHSIA Collection;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "index")]
        public uint Index;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.BufferCollectionBufferCreateInfoFuchsia;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
