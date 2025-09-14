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
    [NativeName("Name", "VkPhysicalDeviceDescriptorBufferTensorPropertiesARM")]
    public unsafe partial struct PhysicalDeviceDescriptorBufferTensorPropertiesARM : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceDescriptorBufferTensorPropertiesARM
        (
            StructureType? sType = StructureType.PhysicalDeviceDescriptorBufferTensorPropertiesArm,
            void* pNext = null,
            nuint? tensorCaptureReplayDescriptorDataSize = null,
            nuint? tensorViewCaptureReplayDescriptorDataSize = null,
            nuint? tensorDescriptorSize = null
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

            if (tensorCaptureReplayDescriptorDataSize is not null)
            {
                TensorCaptureReplayDescriptorDataSize = tensorCaptureReplayDescriptorDataSize.Value;
            }

            if (tensorViewCaptureReplayDescriptorDataSize is not null)
            {
                TensorViewCaptureReplayDescriptorDataSize = tensorViewCaptureReplayDescriptorDataSize.Value;
            }

            if (tensorDescriptorSize is not null)
            {
                TensorDescriptorSize = tensorDescriptorSize.Value;
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
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "tensorCaptureReplayDescriptorDataSize")]
        public nuint TensorCaptureReplayDescriptorDataSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "tensorViewCaptureReplayDescriptorDataSize")]
        public nuint TensorViewCaptureReplayDescriptorDataSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "tensorDescriptorSize")]
        public nuint TensorDescriptorSize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceDescriptorBufferTensorPropertiesArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
