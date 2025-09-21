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
    [NativeName("Name", "VkDataGraphPipelineResourceInfoARM")]
    public unsafe partial struct DataGraphPipelineResourceInfoARM : IChainStart
    {
        public DataGraphPipelineResourceInfoARM
        (
            StructureType? sType = StructureType.DataGraphPipelineResourceInfoArm,
            void* pNext = null,
            uint? descriptorSet = null,
            uint? binding = null,
            uint? arrayElement = null
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

            if (descriptorSet is not null)
            {
                DescriptorSet = descriptorSet.Value;
            }

            if (binding is not null)
            {
                Binding = binding.Value;
            }

            if (arrayElement is not null)
            {
                ArrayElement = arrayElement.Value;
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
        [NativeName("Name", "descriptorSet")]
        public uint DescriptorSet;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "binding")]
        public uint Binding;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "arrayElement")]
        public uint ArrayElement;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DataGraphPipelineResourceInfoArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref DataGraphPipelineResourceInfoARM Chain(
            out DataGraphPipelineResourceInfoARM capture)
        {
            capture = new DataGraphPipelineResourceInfoARM(StructureType.DataGraphPipelineResourceInfoArm);
            return ref capture;
        }
    }
}
