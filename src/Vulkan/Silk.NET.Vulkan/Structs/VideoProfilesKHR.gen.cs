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
    [NativeName("Name", "VkVideoProfilesKHR")]
    public unsafe partial struct VideoProfilesKHR : IExtendsChain<FormatProperties2>, IExtendsChain<FormatProperties2KHR>, IExtendsChain<ImageCreateInfo>, IExtendsChain<ImageViewCreateInfo>, IExtendsChain<BufferCreateInfo>
    {
        public VideoProfilesKHR
        (
            StructureType? sType = StructureType.VideoProfilesKhr,
            void* pNext = null,
            uint? profileCount = null,
            VideoProfileKHR* pProfiles = null
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

            if (profileCount is not null)
            {
                ProfileCount = profileCount.Value;
            }

            if (pProfiles is not null)
            {
                PProfiles = pProfiles;
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
        [NativeName("Name", "profileCount")]
        public uint ProfileCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoProfileKHR*")]
        [NativeName("Type.Name", "VkVideoProfileKHR")]
        [NativeName("Name", "pProfiles")]
        public VideoProfileKHR* PProfiles;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoProfilesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
