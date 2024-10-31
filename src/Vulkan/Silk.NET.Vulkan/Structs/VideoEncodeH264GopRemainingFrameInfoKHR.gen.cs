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
    [NativeName("Name", "VkVideoEncodeH264GopRemainingFrameInfoKHR")]
    public unsafe partial struct VideoEncodeH264GopRemainingFrameInfoKHR : IExtendsChain<VideoBeginCodingInfoKHR>
    {
        public VideoEncodeH264GopRemainingFrameInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeH264GopRemainingFrameInfoKhr,
            void* pNext = null,
            Bool32? useGopRemainingFrames = null,
            uint? gopRemainingI = null,
            uint? gopRemainingP = null,
            uint? gopRemainingB = null
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

            if (useGopRemainingFrames is not null)
            {
                UseGopRemainingFrames = useGopRemainingFrames.Value;
            }

            if (gopRemainingI is not null)
            {
                GopRemainingI = gopRemainingI.Value;
            }

            if (gopRemainingP is not null)
            {
                GopRemainingP = gopRemainingP.Value;
            }

            if (gopRemainingB is not null)
            {
                GopRemainingB = gopRemainingB.Value;
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
        [NativeName("Name", "useGopRemainingFrames")]
        public Bool32 UseGopRemainingFrames;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "gopRemainingI")]
        public uint GopRemainingI;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "gopRemainingP")]
        public uint GopRemainingP;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "gopRemainingB")]
        public uint GopRemainingB;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264GopRemainingFrameInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
