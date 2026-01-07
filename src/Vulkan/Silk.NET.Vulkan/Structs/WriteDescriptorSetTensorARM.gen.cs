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
    [NativeName("Name", "VkWriteDescriptorSetTensorARM")]
    public unsafe partial struct WriteDescriptorSetTensorARM : IExtendsChain<WriteDescriptorSet>
    {
        public WriteDescriptorSetTensorARM
        (
            StructureType? sType = StructureType.WriteDescriptorSetTensorArm,
            void* pNext = null,
            uint? tensorViewCount = null,
            TensorViewARM* pTensorViews = null
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

            if (tensorViewCount is not null)
            {
                TensorViewCount = tensorViewCount.Value;
            }

            if (pTensorViews is not null)
            {
                PTensorViews = pTensorViews;
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
        [NativeName("Name", "tensorViewCount")]
        public uint TensorViewCount;
/// <summary></summary>
        [NativeName("Type", "VkTensorViewARM*")]
        [NativeName("Type.Name", "VkTensorViewARM")]
        [NativeName("Name", "pTensorViews")]
        public TensorViewARM* PTensorViews;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.WriteDescriptorSetTensorArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
