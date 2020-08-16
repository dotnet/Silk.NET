// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkShaderModuleCreateInfo")]
    public unsafe partial struct ShaderModuleCreateInfo
    {
        public ShaderModuleCreateInfo
        (
            StructureType sType = StructureType.ShaderModuleCreateInfo,
            void* pNext = default,
            ShaderModuleCreateFlags flags = default,
            UIntPtr codeSize = default,
            uint* pCode = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            CodeSize = codeSize;
            PCode = pCode;
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
        [NativeName("Type", "VkShaderModuleCreateFlags")]
        [NativeName("Type.Name", "VkShaderModuleCreateFlags")]
        [NativeName("Name", "flags")]
        public ShaderModuleCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "codeSize")]
        public UIntPtr CodeSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pCode")]
        public uint* PCode;
    }
}
