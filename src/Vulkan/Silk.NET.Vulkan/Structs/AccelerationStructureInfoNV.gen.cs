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
    [NativeName("Name", "VkAccelerationStructureInfoNV")]
    public unsafe partial struct AccelerationStructureInfoNV : IChainable
    {
        public AccelerationStructureInfoNV
        (
            StructureType? sType = StructureType.AccelerationStructureInfoNV,
            void* pNext = null,
            AccelerationStructureTypeNV? type = null,
            BuildAccelerationStructureFlagsNV? flags = null,
            uint? instanceCount = null,
            uint? geometryCount = null,
            GeometryNV* pGeometries = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (instanceCount is not null)
            {
                InstanceCount = instanceCount.Value;
            }

            if (geometryCount is not null)
            {
                GeometryCount = geometryCount.Value;
            }

            if (pGeometries is not null)
            {
                PGeometries = pGeometries;
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
        [NativeName("Type", "VkAccelerationStructureTypeNV")]
        [NativeName("Type.Name", "VkAccelerationStructureTypeNV")]
        [NativeName("Name", "type")]
        public AccelerationStructureTypeNV Type;
/// <summary></summary>
        [NativeName("Type", "VkBuildAccelerationStructureFlagsNV")]
        [NativeName("Type.Name", "VkBuildAccelerationStructureFlagsNV")]
        [NativeName("Name", "flags")]
        public BuildAccelerationStructureFlagsNV Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "instanceCount")]
        public uint InstanceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "geometryCount")]
        public uint GeometryCount;
/// <summary></summary>
        [NativeName("Type", "VkGeometryNV*")]
        [NativeName("Type.Name", "VkGeometryNV")]
        [NativeName("Name", "pGeometries")]
        public GeometryNV* PGeometries;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.AccelerationStructureInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
