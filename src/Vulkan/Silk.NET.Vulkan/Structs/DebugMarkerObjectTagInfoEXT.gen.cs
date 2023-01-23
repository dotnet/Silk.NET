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
    [NativeName("Name", "VkDebugMarkerObjectTagInfoEXT")]
    public unsafe partial struct DebugMarkerObjectTagInfoEXT : IChainable
    {
        public DebugMarkerObjectTagInfoEXT
        (
            StructureType? sType = StructureType.DebugMarkerObjectTagInfoExt,
            void* pNext = null,
            DebugReportObjectTypeEXT? objectType = null,
            ulong? @object = null,
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

            if (objectType is not null)
            {
                ObjectType = objectType.Value;
            }

            if (@object is not null)
            {
                Object = @object.Value;
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
        [NativeName("Type", "VkDebugReportObjectTypeEXT")]
        [NativeName("Type.Name", "VkDebugReportObjectTypeEXT")]
        [NativeName("Name", "objectType")]
        public DebugReportObjectTypeEXT ObjectType;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "object")]
        public ulong Object;
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
            return SType = StructureType.DebugMarkerObjectTagInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
