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
    [NativeName("Name", "VkClusterAccelerationStructureInstantiateClusterInfoNV")]
    public unsafe partial struct ClusterAccelerationStructureInstantiateClusterInfoNV
    {
        public ClusterAccelerationStructureInstantiateClusterInfoNV
        (
            uint? clusterIdOffset = null,
            uint? geometryIndexOffset = null,
            uint? reserved = null,
            ulong? clusterTemplateAddress = null,
            StridedDeviceAddressNV? vertexBuffer = null
        ) : this()
        {
            if (clusterIdOffset is not null)
            {
                ClusterIdOffset = clusterIdOffset.Value;
            }

            if (geometryIndexOffset is not null)
            {
                GeometryIndexOffset = geometryIndexOffset.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }

            if (clusterTemplateAddress is not null)
            {
                ClusterTemplateAddress = clusterTemplateAddress.Value;
            }

            if (vertexBuffer is not null)
            {
                VertexBuffer = vertexBuffer.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "clusterIdOffset")]
        public uint ClusterIdOffset;

        private uint _bitfield1;

        public uint GeometryIndexOffset
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0xFFFFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0xFFFFFFu) | (uint)((uint)(value) & 0xFFFFFFu));
        }

        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 24) & 0xFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0xFFu << 24)) | (uint)(((uint)(value) & 0xFFu) << 24));
        }
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "clusterTemplateAddress")]
        public ulong ClusterTemplateAddress;
/// <summary></summary>
        [NativeName("Type", "VkStridedDeviceAddressNV")]
        [NativeName("Type.Name", "VkStridedDeviceAddressNV")]
        [NativeName("Name", "vertexBuffer")]
        public StridedDeviceAddressNV VertexBuffer;
    }
}
