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
    [NativeName("Name", "VkFrameBoundaryEXT")]
    public unsafe partial struct FrameBoundaryEXT : IExtendsChain<SubmitInfo>, IExtendsChain<SubmitInfo2>, IExtendsChain<SubmitInfo2KHR>, IExtendsChain<PresentInfoKHR>, IExtendsChain<BindSparseInfo>
    {
        public FrameBoundaryEXT
        (
            StructureType? sType = StructureType.FrameBoundaryExt,
            void* pNext = null,
            FrameBoundaryFlagsEXT? flags = null,
            ulong? frameID = null,
            uint? imageCount = null,
            Image* pImages = null,
            uint? bufferCount = null,
            Buffer* pBuffers = null,
            ulong? tagName = null,
            nuint? tagSize = null,
            void* pTag = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (frameID is not null)
            {
                FrameID = frameID.Value;
            }

            if (imageCount is not null)
            {
                ImageCount = imageCount.Value;
            }

            if (pImages is not null)
            {
                PImages = pImages;
            }

            if (bufferCount is not null)
            {
                BufferCount = bufferCount.Value;
            }

            if (pBuffers is not null)
            {
                PBuffers = pBuffers;
            }

            if (tagName is not null)
            {
                TagName = tagName.Value;
            }

            if (tagSize is not null)
            {
                TagSize = tagSize.Value;
            }

            if (pTag is not null)
            {
                PTag = pTag;
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
        [NativeName("Type", "VkFrameBoundaryFlagsEXT")]
        [NativeName("Type.Name", "VkFrameBoundaryFlagsEXT")]
        [NativeName("Name", "flags")]
        public FrameBoundaryFlagsEXT Flags;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "frameID")]
        public ulong FrameID;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "imageCount")]
        public uint ImageCount;
/// <summary></summary>
        [NativeName("Type", "VkImage*")]
        [NativeName("Type.Name", "VkImage")]
        [NativeName("Name", "pImages")]
        public Image* PImages;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bufferCount")]
        public uint BufferCount;
/// <summary></summary>
        [NativeName("Type", "VkBuffer*")]
        [NativeName("Type.Name", "VkBuffer")]
        [NativeName("Name", "pBuffers")]
        public Buffer* PBuffers;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "tagName")]
        public ulong TagName;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "tagSize")]
        public nuint TagSize;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pTag")]
        public void* PTag;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.FrameBoundaryExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
