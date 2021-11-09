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
    [NativeName("Name", "VkVertexInputBindingDescription2EXT")]
    public unsafe partial struct VertexInputBindingDescription2EXT : IChainable
    {
        public VertexInputBindingDescription2EXT
        (
            StructureType? sType = StructureType.VertexInputBindingDescription2Ext,
            void* pNext = null,
            uint? binding = null,
            uint? stride = null,
            VertexInputRate? inputRate = null,
            uint? divisor = null
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

            if (binding is not null)
            {
                Binding = binding.Value;
            }

            if (stride is not null)
            {
                Stride = stride.Value;
            }

            if (inputRate is not null)
            {
                InputRate = inputRate.Value;
            }

            if (divisor is not null)
            {
                Divisor = divisor.Value;
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
        [NativeName("Name", "binding")]
        public uint Binding;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stride")]
        public uint Stride;
/// <summary></summary>
        [NativeName("Type", "VkVertexInputRate")]
        [NativeName("Type.Name", "VkVertexInputRate")]
        [NativeName("Name", "inputRate")]
        public VertexInputRate InputRate;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "divisor")]
        public uint Divisor;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VertexInputBindingDescription2Ext;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
