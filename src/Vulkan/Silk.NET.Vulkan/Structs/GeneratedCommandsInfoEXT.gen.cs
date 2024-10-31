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
    [NativeName("Name", "VkGeneratedCommandsInfoEXT")]
    public unsafe partial struct GeneratedCommandsInfoEXT : IChainStart
    {
        public GeneratedCommandsInfoEXT
        (
            StructureType? sType = StructureType.GeneratedCommandsInfoExt,
            void* pNext = null,
            ShaderStageFlags? shaderStages = null,
            IndirectExecutionSetEXT? indirectExecutionSet = null,
            IndirectCommandsLayoutEXT? indirectCommandsLayout = null,
            ulong? indirectAddress = null,
            ulong? indirectAddressSize = null,
            ulong? preprocessAddress = null,
            ulong? preprocessSize = null,
            uint? maxSequenceCount = null,
            ulong? sequenceCountAddress = null,
            uint? maxDrawCount = null
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

            if (shaderStages is not null)
            {
                ShaderStages = shaderStages.Value;
            }

            if (indirectExecutionSet is not null)
            {
                IndirectExecutionSet = indirectExecutionSet.Value;
            }

            if (indirectCommandsLayout is not null)
            {
                IndirectCommandsLayout = indirectCommandsLayout.Value;
            }

            if (indirectAddress is not null)
            {
                IndirectAddress = indirectAddress.Value;
            }

            if (indirectAddressSize is not null)
            {
                IndirectAddressSize = indirectAddressSize.Value;
            }

            if (preprocessAddress is not null)
            {
                PreprocessAddress = preprocessAddress.Value;
            }

            if (preprocessSize is not null)
            {
                PreprocessSize = preprocessSize.Value;
            }

            if (maxSequenceCount is not null)
            {
                MaxSequenceCount = maxSequenceCount.Value;
            }

            if (sequenceCountAddress is not null)
            {
                SequenceCountAddress = sequenceCountAddress.Value;
            }

            if (maxDrawCount is not null)
            {
                MaxDrawCount = maxDrawCount.Value;
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
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "shaderStages")]
        public ShaderStageFlags ShaderStages;
/// <summary></summary>
        [NativeName("Type", "VkIndirectExecutionSetEXT")]
        [NativeName("Type.Name", "VkIndirectExecutionSetEXT")]
        [NativeName("Name", "indirectExecutionSet")]
        public IndirectExecutionSetEXT IndirectExecutionSet;
/// <summary></summary>
        [NativeName("Type", "VkIndirectCommandsLayoutEXT")]
        [NativeName("Type.Name", "VkIndirectCommandsLayoutEXT")]
        [NativeName("Name", "indirectCommandsLayout")]
        public IndirectCommandsLayoutEXT IndirectCommandsLayout;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "indirectAddress")]
        public ulong IndirectAddress;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "indirectAddressSize")]
        public ulong IndirectAddressSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "preprocessAddress")]
        public ulong PreprocessAddress;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "preprocessSize")]
        public ulong PreprocessSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSequenceCount")]
        public uint MaxSequenceCount;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "sequenceCountAddress")]
        public ulong SequenceCountAddress;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDrawCount")]
        public uint MaxDrawCount;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.GeneratedCommandsInfoExt;
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
        public static unsafe ref GeneratedCommandsInfoEXT Chain(
            out GeneratedCommandsInfoEXT capture)
        {
            capture = new GeneratedCommandsInfoEXT(StructureType.GeneratedCommandsInfoExt);
            return ref capture;
        }
    }
}
