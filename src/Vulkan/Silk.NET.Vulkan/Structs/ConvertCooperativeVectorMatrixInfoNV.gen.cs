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
    [NativeName("Name", "VkConvertCooperativeVectorMatrixInfoNV")]
    public unsafe partial struct ConvertCooperativeVectorMatrixInfoNV : IChainable
    {
        public ConvertCooperativeVectorMatrixInfoNV
        (
            StructureType? sType = StructureType.ConvertCooperativeVectorMatrixInfoNV,
            void* pNext = null,
            nuint? srcSize = null,
            DeviceOrHostAddressConstKHR? srcData = null,
            nuint* pDstSize = null,
            DeviceOrHostAddressKHR? dstData = null,
            ComponentTypeKHR? srcComponentType = null,
            ComponentTypeKHR? dstComponentType = null,
            uint? numRows = null,
            uint? numColumns = null,
            CooperativeVectorMatrixLayoutNV? srcLayout = null,
            nuint? srcStride = null,
            CooperativeVectorMatrixLayoutNV? dstLayout = null,
            nuint? dstStride = null
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

            if (srcSize is not null)
            {
                SrcSize = srcSize.Value;
            }

            if (srcData is not null)
            {
                SrcData = srcData.Value;
            }

            if (pDstSize is not null)
            {
                PDstSize = pDstSize;
            }

            if (dstData is not null)
            {
                DstData = dstData.Value;
            }

            if (srcComponentType is not null)
            {
                SrcComponentType = srcComponentType.Value;
            }

            if (dstComponentType is not null)
            {
                DstComponentType = dstComponentType.Value;
            }

            if (numRows is not null)
            {
                NumRows = numRows.Value;
            }

            if (numColumns is not null)
            {
                NumColumns = numColumns.Value;
            }

            if (srcLayout is not null)
            {
                SrcLayout = srcLayout.Value;
            }

            if (srcStride is not null)
            {
                SrcStride = srcStride.Value;
            }

            if (dstLayout is not null)
            {
                DstLayout = dstLayout.Value;
            }

            if (dstStride is not null)
            {
                DstStride = dstStride.Value;
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
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "srcSize")]
        public nuint SrcSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Name", "srcData")]
        public DeviceOrHostAddressConstKHR SrcData;
/// <summary></summary>
        [NativeName("Type", "size_t*")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "pDstSize")]
        public nuint* PDstSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressKHR")]
        [NativeName("Name", "dstData")]
        public DeviceOrHostAddressKHR DstData;
/// <summary></summary>
        [NativeName("Type", "VkComponentTypeKHR")]
        [NativeName("Type.Name", "VkComponentTypeKHR")]
        [NativeName("Name", "srcComponentType")]
        public ComponentTypeKHR SrcComponentType;
/// <summary></summary>
        [NativeName("Type", "VkComponentTypeKHR")]
        [NativeName("Type.Name", "VkComponentTypeKHR")]
        [NativeName("Name", "dstComponentType")]
        public ComponentTypeKHR DstComponentType;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "numRows")]
        public uint NumRows;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "numColumns")]
        public uint NumColumns;
/// <summary></summary>
        [NativeName("Type", "VkCooperativeVectorMatrixLayoutNV")]
        [NativeName("Type.Name", "VkCooperativeVectorMatrixLayoutNV")]
        [NativeName("Name", "srcLayout")]
        public CooperativeVectorMatrixLayoutNV SrcLayout;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "srcStride")]
        public nuint SrcStride;
/// <summary></summary>
        [NativeName("Type", "VkCooperativeVectorMatrixLayoutNV")]
        [NativeName("Type.Name", "VkCooperativeVectorMatrixLayoutNV")]
        [NativeName("Name", "dstLayout")]
        public CooperativeVectorMatrixLayoutNV DstLayout;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "dstStride")]
        public nuint DstStride;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ConvertCooperativeVectorMatrixInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
