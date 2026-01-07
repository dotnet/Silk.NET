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
    [NativeName("Name", "VkClusterAccelerationStructureInputInfoNV")]
    public unsafe partial struct ClusterAccelerationStructureInputInfoNV : IChainable
    {
        public ClusterAccelerationStructureInputInfoNV
        (
            StructureType? sType = StructureType.ClusterAccelerationStructureInputInfoNV,
            void* pNext = null,
            uint? maxAccelerationStructureCount = null,
            BuildAccelerationStructureFlagsKHR? flags = null,
            ClusterAccelerationStructureOpTypeNV? opType = null,
            ClusterAccelerationStructureOpModeNV? opMode = null,
            ClusterAccelerationStructureOpInputNV? opInput = null
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

            if (maxAccelerationStructureCount is not null)
            {
                MaxAccelerationStructureCount = maxAccelerationStructureCount.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (opType is not null)
            {
                OpType = opType.Value;
            }

            if (opMode is not null)
            {
                OpMode = opMode.Value;
            }

            if (opInput is not null)
            {
                OpInput = opInput.Value;
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
        [NativeName("Name", "maxAccelerationStructureCount")]
        public uint MaxAccelerationStructureCount;
/// <summary></summary>
        [NativeName("Type", "VkBuildAccelerationStructureFlagsKHR")]
        [NativeName("Type.Name", "VkBuildAccelerationStructureFlagsKHR")]
        [NativeName("Name", "flags")]
        public BuildAccelerationStructureFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "VkClusterAccelerationStructureOpTypeNV")]
        [NativeName("Type.Name", "VkClusterAccelerationStructureOpTypeNV")]
        [NativeName("Name", "opType")]
        public ClusterAccelerationStructureOpTypeNV OpType;
/// <summary></summary>
        [NativeName("Type", "VkClusterAccelerationStructureOpModeNV")]
        [NativeName("Type.Name", "VkClusterAccelerationStructureOpModeNV")]
        [NativeName("Name", "opMode")]
        public ClusterAccelerationStructureOpModeNV OpMode;
/// <summary></summary>
        [NativeName("Type", "VkClusterAccelerationStructureOpInputNV")]
        [NativeName("Type.Name", "VkClusterAccelerationStructureOpInputNV")]
        [NativeName("Name", "opInput")]
        public ClusterAccelerationStructureOpInputNV OpInput;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ClusterAccelerationStructureInputInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
