// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkValidationCacheCreateInfoEXT")]
    public unsafe partial struct ValidationCacheCreateInfoEXT
    {
        public ValidationCacheCreateInfoEXT
        (
            StructureType? sType = StructureType.ValidationCacheCreateInfoExt,
            void* pNext = null,
            uint? flags = null,
            UIntPtr? initialDataSize = null,
            void* pInitialData = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (initialDataSize is not null)
            {
                InitialDataSize = initialDataSize.Value;
            }

            if (pInitialData is not null)
            {
                PInitialData = pInitialData;
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
        [NativeName("Type", "VkValidationCacheCreateFlagsEXT")]
        [NativeName("Type.Name", "VkValidationCacheCreateFlagsEXT")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "initialDataSize")]
        public UIntPtr InitialDataSize;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pInitialData")]
        public void* PInitialData;
    }
}
