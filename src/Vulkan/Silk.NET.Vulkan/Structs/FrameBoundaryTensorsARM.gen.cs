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
    [NativeName("Name", "VkFrameBoundaryTensorsARM")]
    public unsafe partial struct FrameBoundaryTensorsARM : IExtendsChain<SubmitInfo>, IExtendsChain<SubmitInfo2>, IExtendsChain<SubmitInfo2KHR>, IExtendsChain<PresentInfoKHR>, IExtendsChain<BindSparseInfo>
    {
        public FrameBoundaryTensorsARM
        (
            StructureType? sType = StructureType.FrameBoundaryTensorsArm,
            void* pNext = null,
            uint? tensorCount = null,
            TensorARM* pTensors = null
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

            if (tensorCount is not null)
            {
                TensorCount = tensorCount.Value;
            }

            if (pTensors is not null)
            {
                PTensors = pTensors;
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
        [NativeName("Name", "tensorCount")]
        public uint TensorCount;
/// <summary></summary>
        [NativeName("Type", "VkTensorARM*")]
        [NativeName("Type.Name", "VkTensorARM")]
        [NativeName("Name", "pTensors")]
        public TensorARM* PTensors;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.FrameBoundaryTensorsArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
