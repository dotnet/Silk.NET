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
    [NativeName("Name", "VkIndirectCommandsLayoutTokenEXT")]
    public unsafe partial struct IndirectCommandsLayoutTokenEXT : IChainable
    {
        public IndirectCommandsLayoutTokenEXT
        (
            StructureType? sType = StructureType.IndirectCommandsLayoutTokenExt,
            void* pNext = null,
            IndirectCommandsTokenTypeEXT? type = null,
            IndirectCommandsTokenDataEXT? data = null,
            uint? offset = null
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

            if (type is not null)
            {
                Type = type.Value;
            }

            if (data is not null)
            {
                Data = data.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
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
        [NativeName("Type", "VkIndirectCommandsTokenTypeEXT")]
        [NativeName("Type.Name", "VkIndirectCommandsTokenTypeEXT")]
        [NativeName("Name", "type")]
        public IndirectCommandsTokenTypeEXT Type;
/// <summary></summary>
        [NativeName("Type", "VkIndirectCommandsTokenDataEXT")]
        [NativeName("Type.Name", "VkIndirectCommandsTokenDataEXT")]
        [NativeName("Name", "data")]
        public IndirectCommandsTokenDataEXT Data;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "offset")]
        public uint Offset;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.IndirectCommandsLayoutTokenExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
