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
    [NativeName("Name", "VkImportMemorySciBufInfoNV")]
    public unsafe partial struct ImportMemorySciBufInfoNV : IExtendsChain<MemoryAllocateInfo>
    {
        public ImportMemorySciBufInfoNV
        (
            StructureType? sType = StructureType.ImportMemorySciBufInfoNV,
            void* pNext = null,
            ExternalMemoryHandleTypeFlags? handleType = null,
            nint? handle = null
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

            if (handleType is not null)
            {
                HandleType = handleType.Value;
            }

            if (handle is not null)
            {
                Handle = handle.Value;
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
        [NativeName("Type", "VkExternalMemoryHandleTypeFlagBits")]
        [NativeName("Type.Name", "VkExternalMemoryHandleTypeFlagBits")]
        [NativeName("Name", "handleType")]
        public ExternalMemoryHandleTypeFlags HandleType;
/// <summary></summary>
        [NativeName("Type", "NvSciBufObj")]
        [NativeName("Type.Name", "NvSciBufObj")]
        [NativeName("Name", "handle")]
        public nint Handle;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImportMemorySciBufInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
