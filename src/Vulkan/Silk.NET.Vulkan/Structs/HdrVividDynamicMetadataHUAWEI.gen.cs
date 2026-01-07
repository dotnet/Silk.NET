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
    [NativeName("Name", "VkHdrVividDynamicMetadataHUAWEI")]
    public unsafe partial struct HdrVividDynamicMetadataHUAWEI : IExtendsChain<HdrMetadataEXT>
    {
        public HdrVividDynamicMetadataHUAWEI
        (
            StructureType? sType = StructureType.HdrVividDynamicMetadataHuawei,
            void* pNext = null,
            nuint? dynamicMetadataSize = null,
            void* pDynamicMetadata = null
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

            if (dynamicMetadataSize is not null)
            {
                DynamicMetadataSize = dynamicMetadataSize.Value;
            }

            if (pDynamicMetadata is not null)
            {
                PDynamicMetadata = pDynamicMetadata;
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
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "dynamicMetadataSize")]
        public nuint DynamicMetadataSize;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pDynamicMetadata")]
        public void* PDynamicMetadata;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.HdrVividDynamicMetadataHuawei;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
