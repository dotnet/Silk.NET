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
    [NativeName("Name", "VkTensorViewCreateInfoARM")]
    public unsafe partial struct TensorViewCreateInfoARM : IChainStart
    {
        public TensorViewCreateInfoARM
        (
            StructureType? sType = StructureType.TensorViewCreateInfoArm,
            void* pNext = null,
            TensorViewCreateFlagsARM? flags = null,
            TensorARM? tensor = null,
            Format? format = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (tensor is not null)
            {
                Tensor = tensor.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
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
        [NativeName("Type", "VkTensorViewCreateFlagsARM")]
        [NativeName("Type.Name", "VkTensorViewCreateFlagsARM")]
        [NativeName("Name", "flags")]
        public TensorViewCreateFlagsARM Flags;
/// <summary></summary>
        [NativeName("Type", "VkTensorARM")]
        [NativeName("Type.Name", "VkTensorARM")]
        [NativeName("Name", "tensor")]
        public TensorARM Tensor;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "format")]
        public Format Format;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.TensorViewCreateInfoArm;
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
        public static unsafe ref TensorViewCreateInfoARM Chain(
            out TensorViewCreateInfoARM capture)
        {
            capture = new TensorViewCreateInfoARM(StructureType.TensorViewCreateInfoArm);
            return ref capture;
        }
    }
}
