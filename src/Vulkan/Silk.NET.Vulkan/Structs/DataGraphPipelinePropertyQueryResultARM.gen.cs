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
    [NativeName("Name", "VkDataGraphPipelinePropertyQueryResultARM")]
    public unsafe partial struct DataGraphPipelinePropertyQueryResultARM : IChainable
    {
        public DataGraphPipelinePropertyQueryResultARM
        (
            StructureType? sType = StructureType.DataGraphPipelinePropertyQueryResultArm,
            void* pNext = null,
            DataGraphPipelinePropertyARM? property = null,
            Bool32? isText = null,
            nuint? dataSize = null,
            void* pData = null
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

            if (property is not null)
            {
                Property = property.Value;
            }

            if (isText is not null)
            {
                IsText = isText.Value;
            }

            if (dataSize is not null)
            {
                DataSize = dataSize.Value;
            }

            if (pData is not null)
            {
                PData = pData;
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
        [NativeName("Type", "VkDataGraphPipelinePropertyARM")]
        [NativeName("Type.Name", "VkDataGraphPipelinePropertyARM")]
        [NativeName("Name", "property")]
        public DataGraphPipelinePropertyARM Property;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "isText")]
        public Bool32 IsText;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "dataSize")]
        public nuint DataSize;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pData")]
        public void* PData;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DataGraphPipelinePropertyQueryResultArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
