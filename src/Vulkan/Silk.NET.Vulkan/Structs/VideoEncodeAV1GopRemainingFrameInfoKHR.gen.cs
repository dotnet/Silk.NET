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
    [NativeName("Name", "VkVideoEncodeAV1GopRemainingFrameInfoKHR")]
    public unsafe partial struct VideoEncodeAV1GopRemainingFrameInfoKHR : IExtendsChain<VideoBeginCodingInfoKHR>
    {
        public VideoEncodeAV1GopRemainingFrameInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeAV1GopRemainingFrameInfoKhr,
            void* pNext = null,
            Bool32? useGopRemainingFrames = null,
            uint? gopRemainingIntra = null,
            uint? gopRemainingPredictive = null,
            uint? gopRemainingBipredictive = null
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

            if (gopRemainingIntra is not null)
            {
                GopRemainingIntra = gopRemainingIntra.Value;
            }

            if (gopRemainingPredictive is not null)
            {
                GopRemainingPredictive = gopRemainingPredictive.Value;
            }

            if (gopRemainingBipredictive is not null)
            {
                GopRemainingBipredictive = gopRemainingBipredictive.Value;
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
        [NativeName("Name", "gopRemainingIntra")]
        public uint GopRemainingIntra;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "gopRemainingPredictive")]
        public uint GopRemainingPredictive;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "gopRemainingBipredictive")]
        public uint GopRemainingBipredictive;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeAV1GopRemainingFrameInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
