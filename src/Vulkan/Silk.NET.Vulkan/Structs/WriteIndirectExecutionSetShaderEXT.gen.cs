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
    [NativeName("Name", "VkWriteIndirectExecutionSetShaderEXT")]
    public unsafe partial struct WriteIndirectExecutionSetShaderEXT : IChainable
    {
        public WriteIndirectExecutionSetShaderEXT
        (
            StructureType? sType = StructureType.WriteIndirectExecutionSetShaderExt,
            void* pNext = null,
            uint? index = null,
            ShaderEXT? shader = null
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

            if (index is not null)
            {
                Index = index.Value;
            }

            if (shader is not null)
            {
                Shader = shader.Value;
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
        [NativeName("Name", "index")]
        public uint Index;
/// <summary></summary>
        [NativeName("Type", "VkShaderEXT")]
        [NativeName("Type.Name", "VkShaderEXT")]
        [NativeName("Name", "shader")]
        public ShaderEXT Shader;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.WriteIndirectExecutionSetShaderExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
