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
    [NativeName("Name", "VkPartitionedAccelerationStructureWritePartitionTranslationDataNV")]
    public unsafe partial struct PartitionedAccelerationStructureWritePartitionTranslationDataNV
    {
        public PartitionedAccelerationStructureWritePartitionTranslationDataNV
        (
            uint? partitionIndex = null
        ) : this()
        {
            if (partitionIndex is not null)
            {
                PartitionIndex = partitionIndex.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "partitionIndex")]
        public uint PartitionIndex;
        /// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "partitionTranslation")]
        public fixed float PartitionTranslation[3];
    }
}
