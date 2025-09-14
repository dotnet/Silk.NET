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
    [NativeName("Name", "VkPartitionedAccelerationStructureInstancesInputNV")]
    public unsafe partial struct PartitionedAccelerationStructureInstancesInputNV : IChainStart
    {
        public PartitionedAccelerationStructureInstancesInputNV
        (
            StructureType? sType = StructureType.PartitionedAccelerationStructureInstancesInputNV,
            void* pNext = null,
            BuildAccelerationStructureFlagsKHR? flags = null,
            uint? instanceCount = null,
            uint? maxInstancePerPartitionCount = null,
            uint? partitionCount = null,
            uint? maxInstanceInGlobalPartitionCount = null
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

            if (instanceCount is not null)
            {
                InstanceCount = instanceCount.Value;
            }

            if (maxInstancePerPartitionCount is not null)
            {
                MaxInstancePerPartitionCount = maxInstancePerPartitionCount.Value;
            }

            if (partitionCount is not null)
            {
                PartitionCount = partitionCount.Value;
            }

            if (maxInstanceInGlobalPartitionCount is not null)
            {
                MaxInstanceInGlobalPartitionCount = maxInstanceInGlobalPartitionCount.Value;
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
        [NativeName("Type", "VkBuildAccelerationStructureFlagsKHR")]
        [NativeName("Type.Name", "VkBuildAccelerationStructureFlagsKHR")]
        [NativeName("Name", "flags")]
        public BuildAccelerationStructureFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "instanceCount")]
        public uint InstanceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxInstancePerPartitionCount")]
        public uint MaxInstancePerPartitionCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "partitionCount")]
        public uint PartitionCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxInstanceInGlobalPartitionCount")]
        public uint MaxInstanceInGlobalPartitionCount;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PartitionedAccelerationStructureInstancesInputNV;
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
        public static unsafe ref PartitionedAccelerationStructureInstancesInputNV Chain(
            out PartitionedAccelerationStructureInstancesInputNV capture)
        {
            capture = new PartitionedAccelerationStructureInstancesInputNV(StructureType.PartitionedAccelerationStructureInstancesInputNV);
            return ref capture;
        }
    }
}
