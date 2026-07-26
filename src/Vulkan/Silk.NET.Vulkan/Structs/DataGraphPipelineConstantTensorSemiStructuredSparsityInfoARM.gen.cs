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
    [NativeName("Name", "VkDataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM")]
    public unsafe partial struct DataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM : IExtendsChain<DataGraphPipelineConstantARM>
    {
        public DataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM
        (
            StructureType? sType = StructureType.DataGraphPipelineConstantTensorSemiStructuredSparsityInfoArm,
            void* pNext = null,
            uint? dimension = null,
            uint? zeroCount = null,
            uint? groupSize = null
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

            if (dimension is not null)
            {
                Dimension = dimension.Value;
            }

            if (zeroCount is not null)
            {
                ZeroCount = zeroCount.Value;
            }

            if (groupSize is not null)
            {
                GroupSize = groupSize.Value;
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
        [NativeName("Name", "dimension")]
        public uint Dimension;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "zeroCount")]
        public uint ZeroCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "groupSize")]
        public uint GroupSize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DataGraphPipelineConstantTensorSemiStructuredSparsityInfoArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
