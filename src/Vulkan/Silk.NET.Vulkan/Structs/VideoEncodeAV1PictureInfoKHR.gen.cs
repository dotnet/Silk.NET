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
    [NativeName("Name", "VkVideoEncodeAV1PictureInfoKHR")]
    public unsafe partial struct VideoEncodeAV1PictureInfoKHR : IExtendsChain<VideoEncodeInfoKHR>
    {
        public VideoEncodeAV1PictureInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeAV1PictureInfoKhr,
            void* pNext = null,
            VideoEncodeAV1PredictionModeKHR? predictionMode = null,
            VideoEncodeAV1RateControlGroupKHR? rateControlGroup = null,
            uint? constantQIndex = null,
            StdVideoEncodeAV1PictureInfo* pStdPictureInfo = null,
            Bool32? primaryReferenceCdfOnly = null,
            Bool32? generateObuExtensionHeader = null
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

            if (predictionMode is not null)
            {
                PredictionMode = predictionMode.Value;
            }

            if (rateControlGroup is not null)
            {
                RateControlGroup = rateControlGroup.Value;
            }

            if (constantQIndex is not null)
            {
                ConstantQIndex = constantQIndex.Value;
            }

            if (pStdPictureInfo is not null)
            {
                PStdPictureInfo = pStdPictureInfo;
            }

            if (primaryReferenceCdfOnly is not null)
            {
                PrimaryReferenceCdfOnly = primaryReferenceCdfOnly.Value;
            }

            if (generateObuExtensionHeader is not null)
            {
                GenerateObuExtensionHeader = generateObuExtensionHeader.Value;
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
        [NativeName("Type", "VkVideoEncodeAV1PredictionModeKHR")]
        [NativeName("Type.Name", "VkVideoEncodeAV1PredictionModeKHR")]
        [NativeName("Name", "predictionMode")]
        public VideoEncodeAV1PredictionModeKHR PredictionMode;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeAV1RateControlGroupKHR")]
        [NativeName("Type.Name", "VkVideoEncodeAV1RateControlGroupKHR")]
        [NativeName("Name", "rateControlGroup")]
        public VideoEncodeAV1RateControlGroupKHR RateControlGroup;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "constantQIndex")]
        public uint ConstantQIndex;
/// <summary></summary>
        [NativeName("Type", "StdVideoEncodeAV1PictureInfo*")]
        [NativeName("Type.Name", "StdVideoEncodeAV1PictureInfo")]
        [NativeName("Name", "pStdPictureInfo")]
        public StdVideoEncodeAV1PictureInfo* PStdPictureInfo;
        /// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "referenceNameSlotIndices")]
        public fixed int ReferenceNameSlotIndices[7];
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "primaryReferenceCdfOnly")]
        public Bool32 PrimaryReferenceCdfOnly;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "generateObuExtensionHeader")]
        public Bool32 GenerateObuExtensionHeader;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeAV1PictureInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
