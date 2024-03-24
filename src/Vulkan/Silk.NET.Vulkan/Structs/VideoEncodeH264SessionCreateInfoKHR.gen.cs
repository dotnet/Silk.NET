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
    [NativeName("Name", "VkVideoEncodeH264SessionCreateInfoKHR")]
    public unsafe partial struct VideoEncodeH264SessionCreateInfoKHR : IExtendsChain<VideoSessionCreateInfoKHR>
    {
        public VideoEncodeH264SessionCreateInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeH264SessionCreateInfoKhr,
            void* pNext = null,
            Bool32? useMaxLevelIdc = null,
            Video.StdVideoH264LevelIdc? maxLevelIdc = null
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

            if (useMaxLevelIdc is not null)
            {
                UseMaxLevelIdc = useMaxLevelIdc.Value;
            }

            if (maxLevelIdc is not null)
            {
                MaxLevelIdc = maxLevelIdc.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "useMaxLevelIdc")]
        public Bool32 UseMaxLevelIdc;
/// <summary></summary>
        [NativeName("Type", "StdVideoH264LevelIdc")]
        [NativeName("Type.Name", "StdVideoH264LevelIdc")]
        [NativeName("Name", "maxLevelIdc")]
        public Video.StdVideoH264LevelIdc MaxLevelIdc;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264SessionCreateInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
