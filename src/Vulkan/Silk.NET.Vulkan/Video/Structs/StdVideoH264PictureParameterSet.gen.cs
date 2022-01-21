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

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoH264PictureParameterSet")]
    public unsafe partial struct StdVideoH264PictureParameterSet
    {
        public StdVideoH264PictureParameterSet
        (
            byte? seqParameterSetId = null,
            byte? picParameterSetId = null,
            byte? numRefIdxL0DefaultActiveMinus1 = null,
            byte? numRefIdxL1DefaultActiveMinus1 = null,
            StdVideoH264WeightedBipredIdc? weightedBipredIdc = null,
            byte? picInitQpMinus26 = null,
            byte? picInitQsMinus26 = null,
            byte? chromaQpIndexOffset = null,
            byte? secondChromaQpIndexOffset = null,
            StdVideoH264PpsFlags? flags = null,
            StdVideoH264ScalingLists* pScalingLists = null
        ) : this()
        {
            if (seqParameterSetId is not null)
            {
                SeqParameterSetId = seqParameterSetId.Value;
            }

            if (picParameterSetId is not null)
            {
                PicParameterSetId = picParameterSetId.Value;
            }

            if (numRefIdxL0DefaultActiveMinus1 is not null)
            {
                NumRefIdxL0DefaultActiveMinus1 = numRefIdxL0DefaultActiveMinus1.Value;
            }

            if (numRefIdxL1DefaultActiveMinus1 is not null)
            {
                NumRefIdxL1DefaultActiveMinus1 = numRefIdxL1DefaultActiveMinus1.Value;
            }

            if (weightedBipredIdc is not null)
            {
                WeightedBipredIdc = weightedBipredIdc.Value;
            }

            if (picInitQpMinus26 is not null)
            {
                PicInitQpMinus26 = picInitQpMinus26.Value;
            }

            if (picInitQsMinus26 is not null)
            {
                PicInitQsMinus26 = picInitQsMinus26.Value;
            }

            if (chromaQpIndexOffset is not null)
            {
                ChromaQpIndexOffset = chromaQpIndexOffset.Value;
            }

            if (secondChromaQpIndexOffset is not null)
            {
                SecondChromaQpIndexOffset = secondChromaQpIndexOffset.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (pScalingLists is not null)
            {
                PScalingLists = pScalingLists;
            }
        }


        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "seq_parameter_set_id")]
        public byte SeqParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "pic_parameter_set_id")]
        public byte PicParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_ref_idx_l0_default_active_minus1")]
        public byte NumRefIdxL0DefaultActiveMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_ref_idx_l1_default_active_minus1")]
        public byte NumRefIdxL1DefaultActiveMinus1;

        [NativeName("Type", "StdVideoH264WeightedBipredIdc")]
        [NativeName("Type.Name", "StdVideoH264WeightedBipredIdc")]
        [NativeName("Name", "weighted_bipred_idc")]
        public StdVideoH264WeightedBipredIdc WeightedBipredIdc;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "pic_init_qp_minus26")]
        public byte PicInitQpMinus26;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "pic_init_qs_minus26")]
        public byte PicInitQsMinus26;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "chroma_qp_index_offset")]
        public byte ChromaQpIndexOffset;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "second_chroma_qp_index_offset")]
        public byte SecondChromaQpIndexOffset;

        [NativeName("Type", "StdVideoH264PpsFlags")]
        [NativeName("Type.Name", "StdVideoH264PpsFlags")]
        [NativeName("Name", "flags")]
        public StdVideoH264PpsFlags Flags;

        [NativeName("Type", "StdVideoH264ScalingLists *")]
        [NativeName("Type.Name", "StdVideoH264ScalingLists *")]
        [NativeName("Name", "pScalingLists")]
        public StdVideoH264ScalingLists* PScalingLists;
    }
}
