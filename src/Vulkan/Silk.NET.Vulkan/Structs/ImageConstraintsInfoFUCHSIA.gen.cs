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
    [NativeName("Name", "VkImageConstraintsInfoFUCHSIA")]
    public unsafe partial struct ImageConstraintsInfoFUCHSIA : IChainable
    {
        public ImageConstraintsInfoFUCHSIA
        (
            StructureType? sType = StructureType.ImageConstraintsInfoFuchsia,
            void* pNext = null,
            uint? formatConstraintsCount = null,
            ImageFormatConstraintsInfoFUCHSIA* pFormatConstraints = null,
            BufferCollectionConstraintsInfoFUCHSIA? bufferCollectionConstraints = null,
            ImageConstraintsInfoFlagsFUCHSIA? flags = null
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

            if (formatConstraintsCount is not null)
            {
                FormatConstraintsCount = formatConstraintsCount.Value;
            }

            if (pFormatConstraints is not null)
            {
                PFormatConstraints = pFormatConstraints;
            }

            if (bufferCollectionConstraints is not null)
            {
                BufferCollectionConstraints = bufferCollectionConstraints.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
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
        [NativeName("Name", "formatConstraintsCount")]
        public uint FormatConstraintsCount;
/// <summary></summary>
        [NativeName("Type", "VkImageFormatConstraintsInfoFUCHSIA*")]
        [NativeName("Type.Name", "VkImageFormatConstraintsInfoFUCHSIA")]
        [NativeName("Name", "pFormatConstraints")]
        public ImageFormatConstraintsInfoFUCHSIA* PFormatConstraints;
/// <summary></summary>
        [NativeName("Type", "VkBufferCollectionConstraintsInfoFUCHSIA")]
        [NativeName("Type.Name", "VkBufferCollectionConstraintsInfoFUCHSIA")]
        [NativeName("Name", "bufferCollectionConstraints")]
        public BufferCollectionConstraintsInfoFUCHSIA BufferCollectionConstraints;
/// <summary></summary>
        [NativeName("Type", "VkImageConstraintsInfoFlagsFUCHSIA")]
        [NativeName("Type.Name", "VkImageConstraintsInfoFlagsFUCHSIA")]
        [NativeName("Name", "flags")]
        public ImageConstraintsInfoFlagsFUCHSIA Flags;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImageConstraintsInfoFuchsia;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
