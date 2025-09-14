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
    [NativeName("Name", "VkClusterAccelerationStructureMoveObjectsInputNV")]
    public unsafe partial struct ClusterAccelerationStructureMoveObjectsInputNV : IChainable
    {
        public ClusterAccelerationStructureMoveObjectsInputNV
        (
            StructureType? sType = StructureType.ClusterAccelerationStructureMoveObjectsInputNV,
            void* pNext = null,
            ClusterAccelerationStructureTypeNV? type = null,
            Bool32? noMoveOverlap = null,
            ulong? maxMovedBytes = null
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

            if (type is not null)
            {
                Type = type.Value;
            }

            if (noMoveOverlap is not null)
            {
                NoMoveOverlap = noMoveOverlap.Value;
            }

            if (maxMovedBytes is not null)
            {
                MaxMovedBytes = maxMovedBytes.Value;
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
        [NativeName("Type", "VkClusterAccelerationStructureTypeNV")]
        [NativeName("Type.Name", "VkClusterAccelerationStructureTypeNV")]
        [NativeName("Name", "type")]
        public ClusterAccelerationStructureTypeNV Type;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "noMoveOverlap")]
        public Bool32 NoMoveOverlap;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "maxMovedBytes")]
        public ulong MaxMovedBytes;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ClusterAccelerationStructureMoveObjectsInputNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
