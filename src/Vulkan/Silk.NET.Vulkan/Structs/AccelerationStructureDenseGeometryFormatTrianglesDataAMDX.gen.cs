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
    [NativeName("Name", "VkAccelerationStructureDenseGeometryFormatTrianglesDataAMDX")]
    public unsafe partial struct AccelerationStructureDenseGeometryFormatTrianglesDataAMDX : IChainStart, IExtendsChain<AccelerationStructureGeometryKHR>
    {
        public AccelerationStructureDenseGeometryFormatTrianglesDataAMDX
        (
            StructureType? sType = StructureType.AccelerationStructureDenseGeometryFormatTrianglesDataAmdx,
            void* pNext = null,
            DeviceOrHostAddressConstKHR? compressedData = null,
            ulong? dataSize = null,
            uint? numTriangles = null,
            uint? numVertices = null,
            uint? maxPrimitiveIndex = null,
            uint? maxGeometryIndex = null,
            CompressedTriangleFormatAMDX? format = null
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

            if (compressedData is not null)
            {
                CompressedData = compressedData.Value;
            }

            if (dataSize is not null)
            {
                DataSize = dataSize.Value;
            }

            if (numTriangles is not null)
            {
                NumTriangles = numTriangles.Value;
            }

            if (numVertices is not null)
            {
                NumVertices = numVertices.Value;
            }

            if (maxPrimitiveIndex is not null)
            {
                MaxPrimitiveIndex = maxPrimitiveIndex.Value;
            }

            if (maxGeometryIndex is not null)
            {
                MaxGeometryIndex = maxGeometryIndex.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
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
        [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Name", "compressedData")]
        public DeviceOrHostAddressConstKHR CompressedData;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "dataSize")]
        public ulong DataSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "numTriangles")]
        public uint NumTriangles;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "numVertices")]
        public uint NumVertices;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPrimitiveIndex")]
        public uint MaxPrimitiveIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxGeometryIndex")]
        public uint MaxGeometryIndex;
/// <summary></summary>
        [NativeName("Type", "VkCompressedTriangleFormatAMDX")]
        [NativeName("Type.Name", "VkCompressedTriangleFormatAMDX")]
        [NativeName("Name", "format")]
        public CompressedTriangleFormatAMDX Format;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.AccelerationStructureDenseGeometryFormatTrianglesDataAmdx;
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
        public static unsafe ref AccelerationStructureDenseGeometryFormatTrianglesDataAMDX Chain(
            out AccelerationStructureDenseGeometryFormatTrianglesDataAMDX capture)
        {
            capture = new AccelerationStructureDenseGeometryFormatTrianglesDataAMDX(StructureType.AccelerationStructureDenseGeometryFormatTrianglesDataAmdx);
            return ref capture;
        }
    }
}
