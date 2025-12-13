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
    [NativeName("Name", "VkCopyTensorInfoARM")]
    public unsafe partial struct CopyTensorInfoARM : IChainable
    {
        public CopyTensorInfoARM
        (
            StructureType? sType = StructureType.CopyTensorInfoArm,
            void* pNext = null,
            TensorARM? srcTensor = null,
            TensorARM? dstTensor = null,
            uint? regionCount = null,
            TensorCopyARM* pRegions = null
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

            if (srcTensor is not null)
            {
                SrcTensor = srcTensor.Value;
            }

            if (dstTensor is not null)
            {
                DstTensor = dstTensor.Value;
            }

            if (regionCount is not null)
            {
                RegionCount = regionCount.Value;
            }

            if (pRegions is not null)
            {
                PRegions = pRegions;
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
        [NativeName("Type", "VkTensorARM")]
        [NativeName("Type.Name", "VkTensorARM")]
        [NativeName("Name", "srcTensor")]
        public TensorARM SrcTensor;
/// <summary></summary>
        [NativeName("Type", "VkTensorARM")]
        [NativeName("Type.Name", "VkTensorARM")]
        [NativeName("Name", "dstTensor")]
        public TensorARM DstTensor;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "regionCount")]
        public uint RegionCount;
/// <summary></summary>
        [NativeName("Type", "VkTensorCopyARM*")]
        [NativeName("Type.Name", "VkTensorCopyARM")]
        [NativeName("Name", "pRegions")]
        public TensorCopyARM* PRegions;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CopyTensorInfoArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
