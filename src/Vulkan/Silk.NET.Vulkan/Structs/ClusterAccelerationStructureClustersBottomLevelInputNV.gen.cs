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
    [NativeName("Name", "VkClusterAccelerationStructureClustersBottomLevelInputNV")]
    public unsafe partial struct ClusterAccelerationStructureClustersBottomLevelInputNV : IChainable
    {
        public ClusterAccelerationStructureClustersBottomLevelInputNV
        (
            StructureType? sType = StructureType.ClusterAccelerationStructureClustersBottomLevelInputNV,
            void* pNext = null,
            uint? maxTotalClusterCount = null,
            uint? maxClusterCountPerAccelerationStructure = null
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

            if (maxTotalClusterCount is not null)
            {
                MaxTotalClusterCount = maxTotalClusterCount.Value;
            }

            if (maxClusterCountPerAccelerationStructure is not null)
            {
                MaxClusterCountPerAccelerationStructure = maxClusterCountPerAccelerationStructure.Value;
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
        [NativeName("Name", "maxTotalClusterCount")]
        public uint MaxTotalClusterCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxClusterCountPerAccelerationStructure")]
        public uint MaxClusterCountPerAccelerationStructure;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ClusterAccelerationStructureClustersBottomLevelInputNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
