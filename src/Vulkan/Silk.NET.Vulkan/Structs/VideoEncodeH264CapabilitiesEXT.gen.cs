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
    [NativeName("Name", "VkVideoEncodeH264CapabilitiesEXT")]
    public unsafe partial struct VideoEncodeH264CapabilitiesEXT : IExtendsChain<VideoCapabilitiesKHR>
    {
        public VideoEncodeH264CapabilitiesEXT
        (
            StructureType? sType = StructureType.VideoEncodeH264CapabilitiesExt,
            void* pNext = null,
            VideoEncodeH264CapabilityFlagsEXT? flags = null,
            uint? maxPPictureL0ReferenceCount = null,
            uint? maxBPictureL0ReferenceCount = null,
            uint? maxL1ReferenceCount = null,
            Bool32? motionVectorsOverPicBoundariesFlag = null,
            uint? maxBytesPerPicDenom = null,
            uint? maxBitsPerMbDenom = null,
            uint? log2MaxMvLengthHorizontal = null,
            uint? log2MaxMvLengthVertical = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (maxPPictureL0ReferenceCount is not null)
            {
                MaxPPictureL0ReferenceCount = maxPPictureL0ReferenceCount.Value;
            }

            if (maxBPictureL0ReferenceCount is not null)
            {
                MaxBPictureL0ReferenceCount = maxBPictureL0ReferenceCount.Value;
            }

            if (maxL1ReferenceCount is not null)
            {
                MaxL1ReferenceCount = maxL1ReferenceCount.Value;
            }

            if (motionVectorsOverPicBoundariesFlag is not null)
            {
                MotionVectorsOverPicBoundariesFlag = motionVectorsOverPicBoundariesFlag.Value;
            }

            if (maxBytesPerPicDenom is not null)
            {
                MaxBytesPerPicDenom = maxBytesPerPicDenom.Value;
            }

            if (maxBitsPerMbDenom is not null)
            {
                MaxBitsPerMbDenom = maxBitsPerMbDenom.Value;
            }

            if (log2MaxMvLengthHorizontal is not null)
            {
                Log2MaxMvLengthHorizontal = log2MaxMvLengthHorizontal.Value;
            }

            if (log2MaxMvLengthVertical is not null)
            {
                Log2MaxMvLengthVertical = log2MaxMvLengthVertical.Value;
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
        [NativeName("Type", "VkVideoEncodeH264CapabilityFlagsEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH264CapabilityFlagsEXT")]
        [NativeName("Name", "flags")]
        public VideoEncodeH264CapabilityFlagsEXT Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPPictureL0ReferenceCount")]
        public uint MaxPPictureL0ReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxBPictureL0ReferenceCount")]
        public uint MaxBPictureL0ReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxL1ReferenceCount")]
        public uint MaxL1ReferenceCount;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "motionVectorsOverPicBoundariesFlag")]
        public Bool32 MotionVectorsOverPicBoundariesFlag;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxBytesPerPicDenom")]
        public uint MaxBytesPerPicDenom;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxBitsPerMbDenom")]
        public uint MaxBitsPerMbDenom;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "log2MaxMvLengthHorizontal")]
        public uint Log2MaxMvLengthHorizontal;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "log2MaxMvLengthVertical")]
        public uint Log2MaxMvLengthVertical;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264CapabilitiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
