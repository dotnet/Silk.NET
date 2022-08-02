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
    [NativeName("Name", "VkBaseOutStructure")]
    public unsafe partial struct BaseOutStructure : IChainable
    {
        public BaseOutStructure
        (
            StructureType? sType = null,
            BaseOutStructure* pNext = null
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
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "VkBaseOutStructure*")]
        [NativeName("Type.Name", "VkBaseOutStructure")]
        [NativeName("Name", "pNext")]
        public BaseOutStructure* PNext;

        /// <inheritdoc />
        /// <remarks>Note, there is no fixed value for this type.</remarks>
        StructureType IStructuredType.StructureType()
        {
            return SType;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = (BaseOutStructure*) value;
        }
    }
}
