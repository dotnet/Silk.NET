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
    [NativeName("Name", "VkPipelineLibraryCreateInfoKHR")]
    public unsafe partial struct PipelineLibraryCreateInfoKHR : IChainable
    {
        public PipelineLibraryCreateInfoKHR
        (
            StructureType? sType = StructureType.PipelineLibraryCreateInfoKhr,
            void* pNext = null,
            uint? libraryCount = null,
            Pipeline* pLibraries = null
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

            if (libraryCount is not null)
            {
                LibraryCount = libraryCount.Value;
            }

            if (pLibraries is not null)
            {
                PLibraries = pLibraries;
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
        [NativeName("Name", "libraryCount")]
        public uint LibraryCount;
/// <summary></summary>
        [NativeName("Type", "VkPipeline*")]
        [NativeName("Type.Name", "VkPipeline")]
        [NativeName("Name", "pLibraries")]
        public Pipeline* PLibraries;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineLibraryCreateInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
