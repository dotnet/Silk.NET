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
    [NativeName("Name", "VkTensorDescriptionARM")]
    public unsafe partial struct TensorDescriptionARM : IExtendsChain<DataGraphPipelineResourceInfoARM>, IExtendsChain<DataGraphPipelineConstantARM>
    {
        public TensorDescriptionARM
        (
            StructureType? sType = StructureType.TensorDescriptionArm,
            void* pNext = null,
            TensorTilingARM? tiling = null,
            Format? format = null,
            uint? dimensionCount = null,
            long* pDimensions = null,
            long* pStrides = null,
            TensorUsageFlagsARM? usage = null
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

            if (tiling is not null)
            {
                Tiling = tiling.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (dimensionCount is not null)
            {
                DimensionCount = dimensionCount.Value;
            }

            if (pDimensions is not null)
            {
                PDimensions = pDimensions;
            }

            if (pStrides is not null)
            {
                PStrides = pStrides;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
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
        [NativeName("Type", "VkTensorTilingARM")]
        [NativeName("Type.Name", "VkTensorTilingARM")]
        [NativeName("Name", "tiling")]
        public TensorTilingARM Tiling;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "format")]
        public Format Format;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dimensionCount")]
        public uint DimensionCount;
/// <summary></summary>
        [NativeName("Type", "int64_t*")]
        [NativeName("Type.Name", "int64_t")]
        [NativeName("Name", "pDimensions")]
        public long* PDimensions;
/// <summary></summary>
        [NativeName("Type", "int64_t*")]
        [NativeName("Type.Name", "int64_t")]
        [NativeName("Name", "pStrides")]
        public long* PStrides;
/// <summary></summary>
        [NativeName("Type", "VkTensorUsageFlagsARM")]
        [NativeName("Type.Name", "VkTensorUsageFlagsARM")]
        [NativeName("Name", "usage")]
        public TensorUsageFlagsARM Usage;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.TensorDescriptionArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
