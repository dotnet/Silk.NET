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
    [NativeName("Name", "VkIndirectExecutionSetCreateInfoEXT")]
    public unsafe partial struct IndirectExecutionSetCreateInfoEXT : IChainable
    {
        public IndirectExecutionSetCreateInfoEXT
        (
            StructureType? sType = StructureType.IndirectExecutionSetCreateInfoExt,
            void* pNext = null,
            IndirectExecutionSetInfoTypeEXT? type = null,
            IndirectExecutionSetInfoEXT? info = null
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

            if (info is not null)
            {
                Info = info.Value;
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
        [NativeName("Type", "VkIndirectExecutionSetInfoTypeEXT")]
        [NativeName("Type.Name", "VkIndirectExecutionSetInfoTypeEXT")]
        [NativeName("Name", "type")]
        public IndirectExecutionSetInfoTypeEXT Type;
/// <summary></summary>
        [NativeName("Type", "VkIndirectExecutionSetInfoEXT")]
        [NativeName("Type.Name", "VkIndirectExecutionSetInfoEXT")]
        [NativeName("Name", "info")]
        public IndirectExecutionSetInfoEXT Info;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.IndirectExecutionSetCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
