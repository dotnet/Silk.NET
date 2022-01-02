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
    [NativeName("Name", "VkVideoDecodeH264MvcEXT")]
    public unsafe partial struct VideoDecodeH264MvcEXT : IExtendsChain<VideoDecodeH264PictureInfoEXT>
    {
        public VideoDecodeH264MvcEXT
        (
            StructureType? sType = StructureType.VideoDecodeH264MvcExt,
            void* pNext = null,
            Video.StdVideoDecodeH264Mvc* pStdMvc = null
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

            if (pStdMvc is not null)
            {
                PStdMvc = pStdMvc;
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
        [NativeName("Type", "StdVideoDecodeH264Mvc*")]
        [NativeName("Type.Name", "StdVideoDecodeH264Mvc")]
        [NativeName("Name", "pStdMvc")]
        public Video.StdVideoDecodeH264Mvc* PStdMvc;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeH264MvcExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
