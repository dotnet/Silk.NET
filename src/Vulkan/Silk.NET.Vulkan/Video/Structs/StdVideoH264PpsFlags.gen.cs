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
    [NativeName("Name", "StdVideoH264PpsFlags")]
    public unsafe partial struct StdVideoH264PpsFlags
    {
        public StdVideoH264PpsFlags
        (
            uint? transform8x8ModeFlag = null,
            uint? redundantPicCntPresentFlag = null,
            uint? constrainedIntraPredFlag = null,
            uint? deblockingFilterControlPresentFlag = null,
            uint? weightedBipredIdcFlag = null,
            uint? weightedPredFlag = null,
            uint? picOrderPresentFlag = null,
            uint? entropyCodingModeFlag = null,
            uint? scalingMatrixPresentFlag = null
        ) : this()
        {
            if (transform8x8ModeFlag is not null)
            {
                Transform8x8ModeFlag = transform8x8ModeFlag.Value;
            }

            if (redundantPicCntPresentFlag is not null)
            {
                RedundantPicCntPresentFlag = redundantPicCntPresentFlag.Value;
            }

            if (constrainedIntraPredFlag is not null)
            {
                ConstrainedIntraPredFlag = constrainedIntraPredFlag.Value;
            }

            if (deblockingFilterControlPresentFlag is not null)
            {
                DeblockingFilterControlPresentFlag = deblockingFilterControlPresentFlag.Value;
            }

            if (weightedBipredIdcFlag is not null)
            {
                WeightedBipredIdcFlag = weightedBipredIdcFlag.Value;
            }

            if (weightedPredFlag is not null)
            {
                WeightedPredFlag = weightedPredFlag.Value;
            }

            if (picOrderPresentFlag is not null)
            {
                PicOrderPresentFlag = picOrderPresentFlag.Value;
            }

            if (entropyCodingModeFlag is not null)
            {
                EntropyCodingModeFlag = entropyCodingModeFlag.Value;
            }

            if (scalingMatrixPresentFlag is not null)
            {
                ScalingMatrixPresentFlag = scalingMatrixPresentFlag.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "transform_8x8_mode_flag")]
        public uint Transform8x8ModeFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "redundant_pic_cnt_present_flag")]
        public uint RedundantPicCntPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "constrained_intra_pred_flag")]
        public uint ConstrainedIntraPredFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deblocking_filter_control_present_flag")]
        public uint DeblockingFilterControlPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "weighted_bipred_idc_flag")]
        public uint WeightedBipredIdcFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "weighted_pred_flag")]
        public uint WeightedPredFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pic_order_present_flag")]
        public uint PicOrderPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "entropy_coding_mode_flag")]
        public uint EntropyCodingModeFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "scaling_matrix_present_flag")]
        public uint ScalingMatrixPresentFlag;
    }
}
