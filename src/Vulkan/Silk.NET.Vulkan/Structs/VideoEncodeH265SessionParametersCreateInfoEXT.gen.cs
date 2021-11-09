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
    [NativeName("Name", "VkVideoEncodeH265SessionParametersCreateInfoEXT")]
    public unsafe partial struct VideoEncodeH265SessionParametersCreateInfoEXT : IExtendsChain<VideoSessionParametersCreateInfoKHR>
    {
        public VideoEncodeH265SessionParametersCreateInfoEXT
        (
            StructureType? sType = StructureType.VideoEncodeH265SessionParametersCreateInfoExt,
            void* pNext = null,
            uint? maxVpsStdCount = null,
            uint? maxSpsStdCount = null,
            uint? maxPpsStdCount = null,
            VideoEncodeH265SessionParametersAddInfoEXT* pParametersAddInfo = null
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

            if (maxVpsStdCount is not null)
            {
                MaxVpsStdCount = maxVpsStdCount.Value;
            }

            if (maxSpsStdCount is not null)
            {
                MaxSpsStdCount = maxSpsStdCount.Value;
            }

            if (maxPpsStdCount is not null)
            {
                MaxPpsStdCount = maxPpsStdCount.Value;
            }

            if (pParametersAddInfo is not null)
            {
                PParametersAddInfo = pParametersAddInfo;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxVpsStdCount")]
        public uint MaxVpsStdCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSpsStdCount")]
        public uint MaxSpsStdCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPpsStdCount")]
        public uint MaxPpsStdCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265SessionParametersAddInfoEXT*")]
        [NativeName("Type.Name", "VkVideoEncodeH265SessionParametersAddInfoEXT")]
        [NativeName("Name", "pParametersAddInfo")]
        public VideoEncodeH265SessionParametersAddInfoEXT* PParametersAddInfo;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH265SessionParametersCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
