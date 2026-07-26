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
    [NativeName("Name", "VkClusterAccelerationStructureBuildClustersBottomLevelInfoNV")]
    public unsafe partial struct ClusterAccelerationStructureBuildClustersBottomLevelInfoNV
    {
        public ClusterAccelerationStructureBuildClustersBottomLevelInfoNV
        (
            uint? clusterReferencesCount = null,
            uint? clusterReferencesStride = null,
            ulong? clusterReferences = null
        ) : this()
        {
            if (clusterReferencesCount is not null)
            {
                ClusterReferencesCount = clusterReferencesCount.Value;
            }

            if (clusterReferencesStride is not null)
            {
                ClusterReferencesStride = clusterReferencesStride.Value;
            }

            if (clusterReferences is not null)
            {
                ClusterReferences = clusterReferences.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "clusterReferencesCount")]
        public uint ClusterReferencesCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "clusterReferencesStride")]
        public uint ClusterReferencesStride;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "clusterReferences")]
        public ulong ClusterReferences;
    }
}
