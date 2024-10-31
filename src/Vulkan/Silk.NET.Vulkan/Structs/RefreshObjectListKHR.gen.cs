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
    [NativeName("Name", "VkRefreshObjectListKHR")]
    public unsafe partial struct RefreshObjectListKHR : IChainable
    {
        public RefreshObjectListKHR
        (
            StructureType? sType = StructureType.RefreshObjectListKhr,
            void* pNext = null,
            uint? objectCount = null,
            RefreshObjectKHR* pObjects = null
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

            if (objectCount is not null)
            {
                ObjectCount = objectCount.Value;
            }

            if (pObjects is not null)
            {
                PObjects = pObjects;
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
        [NativeName("Name", "objectCount")]
        public uint ObjectCount;
/// <summary></summary>
        [NativeName("Type", "VkRefreshObjectKHR*")]
        [NativeName("Type.Name", "VkRefreshObjectKHR")]
        [NativeName("Name", "pObjects")]
        public RefreshObjectKHR* PObjects;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.RefreshObjectListKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
