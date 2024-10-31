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
    [NativeName("Name", "VkGeneratedCommandsShaderInfoEXT")]
    public unsafe partial struct GeneratedCommandsShaderInfoEXT : IExtendsChain<GeneratedCommandsInfoEXT>, IExtendsChain<GeneratedCommandsMemoryRequirementsInfoEXT>
    {
        public GeneratedCommandsShaderInfoEXT
        (
            StructureType? sType = StructureType.GeneratedCommandsShaderInfoExt,
            void* pNext = null,
            uint? shaderCount = null,
            ShaderEXT* pShaders = null
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

            if (shaderCount is not null)
            {
                ShaderCount = shaderCount.Value;
            }

            if (pShaders is not null)
            {
                PShaders = pShaders;
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
        [NativeName("Name", "shaderCount")]
        public uint ShaderCount;
/// <summary></summary>
        [NativeName("Type", "VkShaderEXT*")]
        [NativeName("Type.Name", "VkShaderEXT")]
        [NativeName("Name", "pShaders")]
        public ShaderEXT* PShaders;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.GeneratedCommandsShaderInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
