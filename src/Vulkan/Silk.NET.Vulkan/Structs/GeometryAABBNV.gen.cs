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
    [NativeName("Name", "VkGeometryAABBNV")]
    public unsafe partial struct GeometryAABBNV : IChainable
    {
        public GeometryAABBNV
        (
            StructureType? sType = StructureType.GeometryAabbNV,
            void* pNext = null,
            Buffer? aabbData = null,
            uint? numAabbs = null,
            uint? stride = null,
            ulong? offset = null
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

            if (aabbData is not null)
            {
                AabbData = aabbData.Value;
            }

            if (numAabbs is not null)
            {
                NumAabbs = numAabbs.Value;
            }

            if (stride is not null)
            {
                Stride = stride.Value;
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
        [NativeName("Type", "VkBuffer")]
        [NativeName("Type.Name", "VkBuffer")]
        [NativeName("Name", "aabbData")]
        public Buffer AabbData;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "numAABBs")]
        public uint NumAabbs;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stride")]
        public uint Stride;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "offset")]
        public ulong Offset;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.GeometryAabbNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
