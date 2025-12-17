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
    [NativeName("Name", "VkVideoEncodeAV1QuantizationMapCapabilitiesKHR")]
    public unsafe partial struct VideoEncodeAV1QuantizationMapCapabilitiesKHR : IExtendsChain<VideoCapabilitiesKHR>
    {
        public VideoEncodeAV1QuantizationMapCapabilitiesKHR
        (
            StructureType? sType = StructureType.VideoEncodeAV1QuantizationMapCapabilitiesKhr,
            void* pNext = null,
            int? minQIndexDelta = null,
            int? maxQIndexDelta = null
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

            if (minQIndexDelta is not null)
            {
                MinQIndexDelta = minQIndexDelta.Value;
            }

            if (maxQIndexDelta is not null)
            {
                MaxQIndexDelta = maxQIndexDelta.Value;
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
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "minQIndexDelta")]
        public int MinQIndexDelta;
/// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "maxQIndexDelta")]
        public int MaxQIndexDelta;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeAV1QuantizationMapCapabilitiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
