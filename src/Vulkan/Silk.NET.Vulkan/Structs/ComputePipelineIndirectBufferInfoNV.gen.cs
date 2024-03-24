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
    [NativeName("Name", "VkComputePipelineIndirectBufferInfoNV")]
    public unsafe partial struct ComputePipelineIndirectBufferInfoNV : IExtendsChain<ComputePipelineCreateInfo>
    {
        public ComputePipelineIndirectBufferInfoNV
        (
            StructureType? sType = StructureType.ComputePipelineIndirectBufferInfoNV,
            void* pNext = null,
            ulong? deviceAddress = null,
            ulong? size = null,
            ulong? pipelineDeviceAddressCaptureReplay = null
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

            if (deviceAddress is not null)
            {
                DeviceAddress = deviceAddress.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (pipelineDeviceAddressCaptureReplay is not null)
            {
                PipelineDeviceAddressCaptureReplay = pipelineDeviceAddressCaptureReplay.Value;
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
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "deviceAddress")]
        public ulong DeviceAddress;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "size")]
        public ulong Size;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "pipelineDeviceAddressCaptureReplay")]
        public ulong PipelineDeviceAddressCaptureReplay;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ComputePipelineIndirectBufferInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
