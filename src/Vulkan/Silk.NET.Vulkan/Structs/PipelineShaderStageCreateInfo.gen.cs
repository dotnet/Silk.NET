// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct PipelineShaderStageCreateInfo
    {
        public PipelineShaderStageCreateInfo
        (
            StructureType sType = StructureType.PipelineShaderStageCreateInfo,
            void* pNext = default,
            PipelineShaderStageCreateFlags flags = default,
            ShaderStageFlags stage = default,
            ShaderModule module = default,
            byte* pName = default,
            SpecializationInfo* pSpecializationInfo = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           Stage = stage;
           Module = module;
           PName = pName;
           PSpecializationInfo = pSpecializationInfo;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public PipelineShaderStageCreateFlags Flags;
/// <summary></summary>
        public ShaderStageFlags Stage;
/// <summary></summary>
        public ShaderModule Module;
/// <summary></summary>
        public byte* PName;
/// <summary></summary>
        public SpecializationInfo* PSpecializationInfo;
    }
}
