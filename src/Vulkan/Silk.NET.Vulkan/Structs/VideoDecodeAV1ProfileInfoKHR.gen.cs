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
    [NativeName("Name", "VkVideoDecodeAV1ProfileInfoKHR")]
    public unsafe partial struct VideoDecodeAV1ProfileInfoKHR : IExtendsChain<VideoProfileInfoKHR>, IExtendsChain<QueryPoolCreateInfo>
    {
        public VideoDecodeAV1ProfileInfoKHR
        (
            StructureType? sType = StructureType.VideoDecodeAV1ProfileInfoKhr,
            void* pNext = null,
            Video.StdVideoAV1Profile? stdProfile = null,
            Bool32? filmGrainSupport = null
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

            if (stdProfile is not null)
            {
                StdProfile = stdProfile.Value;
            }

            if (filmGrainSupport is not null)
            {
                FilmGrainSupport = filmGrainSupport.Value;
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
        [NativeName("Type", "StdVideoAV1Profile")]
        [NativeName("Type.Name", "StdVideoAV1Profile")]
        [NativeName("Name", "stdProfile")]
        public Video.StdVideoAV1Profile StdProfile;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "filmGrainSupport")]
        public Bool32 FilmGrainSupport;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeAV1ProfileInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
