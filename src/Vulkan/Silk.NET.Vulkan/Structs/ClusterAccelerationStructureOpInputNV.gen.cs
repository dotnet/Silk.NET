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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "VkClusterAccelerationStructureOpInputNV")]
    public unsafe partial struct ClusterAccelerationStructureOpInputNV
    {
        public ClusterAccelerationStructureOpInputNV
        (
            ClusterAccelerationStructureClustersBottomLevelInputNV* pClustersBottomLevel = null,
            ClusterAccelerationStructureTriangleClusterInputNV* pTriangleClusters = null,
            ClusterAccelerationStructureMoveObjectsInputNV* pMoveObjects = null
        ) : this()
        {
            if (pClustersBottomLevel is not null)
            {
                PClustersBottomLevel = pClustersBottomLevel;
            }

            if (pTriangleClusters is not null)
            {
                PTriangleClusters = pTriangleClusters;
            }

            if (pMoveObjects is not null)
            {
                PMoveObjects = pMoveObjects;
            }
        }

/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkClusterAccelerationStructureClustersBottomLevelInputNV*")]
        [NativeName("Type.Name", "VkClusterAccelerationStructureClustersBottomLevelInputNV")]
        [NativeName("Name", "pClustersBottomLevel")]
        public ClusterAccelerationStructureClustersBottomLevelInputNV* PClustersBottomLevel;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkClusterAccelerationStructureTriangleClusterInputNV*")]
        [NativeName("Type.Name", "VkClusterAccelerationStructureTriangleClusterInputNV")]
        [NativeName("Name", "pTriangleClusters")]
        public ClusterAccelerationStructureTriangleClusterInputNV* PTriangleClusters;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkClusterAccelerationStructureMoveObjectsInputNV*")]
        [NativeName("Type.Name", "VkClusterAccelerationStructureMoveObjectsInputNV")]
        [NativeName("Name", "pMoveObjects")]
        public ClusterAccelerationStructureMoveObjectsInputNV* PMoveObjects;
    }
}
