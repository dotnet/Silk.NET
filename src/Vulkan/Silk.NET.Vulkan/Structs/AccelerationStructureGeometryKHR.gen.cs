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
    [NativeName("Name", "VkAccelerationStructureGeometryKHR")]
    public unsafe partial struct AccelerationStructureGeometryKHR : IChainStart
    {
        public AccelerationStructureGeometryKHR
        (
            StructureType? sType = StructureType.AccelerationStructureGeometryKhr,
            void* pNext = null,
            GeometryTypeKHR? geometryType = null,
            AccelerationStructureGeometryDataKHR? geometry = null,
            GeometryFlagsKHR? flags = null
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

            if (geometryType is not null)
            {
                GeometryType = geometryType.Value;
            }

            if (geometry is not null)
            {
                Geometry = geometry.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
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
        [NativeName("Type", "VkGeometryTypeKHR")]
        [NativeName("Type.Name", "VkGeometryTypeKHR")]
        [NativeName("Name", "geometryType")]
        public GeometryTypeKHR GeometryType;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureGeometryDataKHR")]
        [NativeName("Type.Name", "VkAccelerationStructureGeometryDataKHR")]
        [NativeName("Name", "geometry")]
        public AccelerationStructureGeometryDataKHR Geometry;
/// <summary></summary>
        [NativeName("Type", "VkGeometryFlagsKHR")]
        [NativeName("Type.Name", "VkGeometryFlagsKHR")]
        [NativeName("Name", "flags")]
        public GeometryFlagsKHR Flags;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.AccelerationStructureGeometryKhr;
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
        public static unsafe ref AccelerationStructureGeometryKHR Chain(
            out AccelerationStructureGeometryKHR capture)
        {
            capture = new AccelerationStructureGeometryKHR(StructureType.AccelerationStructureGeometryKhr);
            return ref capture;
        }
    }
}
