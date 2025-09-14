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
    [NativeName("Name", "VkDataGraphPipelineShaderModuleCreateInfoARM")]
    public unsafe partial struct DataGraphPipelineShaderModuleCreateInfoARM : IExtendsChain<DataGraphPipelineCreateInfoARM>
    {
        public DataGraphPipelineShaderModuleCreateInfoARM
        (
            StructureType? sType = StructureType.DataGraphPipelineShaderModuleCreateInfoArm,
            void* pNext = null,
            ShaderModule? module = null,
            byte* pName = null,
            SpecializationInfo* pSpecializationInfo = null,
            uint? constantCount = null,
            DataGraphPipelineConstantARM* pConstants = null
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

            if (module is not null)
            {
                Module = module.Value;
            }

            if (pName is not null)
            {
                PName = pName;
            }

            if (pSpecializationInfo is not null)
            {
                PSpecializationInfo = pSpecializationInfo;
            }

            if (constantCount is not null)
            {
                ConstantCount = constantCount.Value;
            }

            if (pConstants is not null)
            {
                PConstants = pConstants;
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
        [NativeName("Type", "VkShaderModule")]
        [NativeName("Type.Name", "VkShaderModule")]
        [NativeName("Name", "module")]
        public ShaderModule Module;
/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "pName")]
        public byte* PName;
/// <summary></summary>
        [NativeName("Type", "VkSpecializationInfo*")]
        [NativeName("Type.Name", "VkSpecializationInfo")]
        [NativeName("Name", "pSpecializationInfo")]
        public SpecializationInfo* PSpecializationInfo;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "constantCount")]
        public uint ConstantCount;
/// <summary></summary>
        [NativeName("Type", "VkDataGraphPipelineConstantARM*")]
        [NativeName("Type.Name", "VkDataGraphPipelineConstantARM")]
        [NativeName("Name", "pConstants")]
        public DataGraphPipelineConstantARM* PConstants;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DataGraphPipelineShaderModuleCreateInfoArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
