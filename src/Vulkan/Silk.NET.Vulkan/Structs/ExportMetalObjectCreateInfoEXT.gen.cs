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
    [NativeName("Name", "VkExportMetalObjectCreateInfoEXT")]
    public unsafe partial struct ExportMetalObjectCreateInfoEXT : IExtendsChain<InstanceCreateInfo>, IExtendsChain<MemoryAllocateInfo>, IExtendsChain<ImageCreateInfo>, IExtendsChain<ImageViewCreateInfo>, IExtendsChain<BufferViewCreateInfo>, IExtendsChain<SemaphoreCreateInfo>, IExtendsChain<EventCreateInfo>
    {
        public ExportMetalObjectCreateInfoEXT
        (
            StructureType? sType = StructureType.ExportMetalObjectCreateInfoExt,
            void* pNext = null,
            ExportMetalObjectTypeFlagsEXT? exportObjectType = null
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

            if (exportObjectType is not null)
            {
                ExportObjectType = exportObjectType.Value;
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
        [NativeName("Type", "VkExportMetalObjectTypeFlagBitsEXT")]
        [NativeName("Type.Name", "VkExportMetalObjectTypeFlagBitsEXT")]
        [NativeName("Name", "exportObjectType")]
        public ExportMetalObjectTypeFlagsEXT ExportObjectType;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ExportMetalObjectCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
