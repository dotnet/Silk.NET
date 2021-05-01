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
    [NativeName("Name", "StdVideoEncodeH264SliceHeaderFlags")]
    public unsafe partial struct StdVideoEncodeH264SliceHeaderFlags
    {
        public StdVideoEncodeH264SliceHeaderFlags
        (
            uint? idrFlag = null,
            uint? isReferenceFlag = null,
            uint? numRefIdxActiveOverrideFlag = null,
            uint? noOutputOfPriorPicsFlag = null,
            uint? longTermReferenceFlag = null,
            uint? adaptiveRefPicMarkingModeFlag = null,
            uint? noPriorReferencesAvailableFlag = null
        ) : this()
        {
            if (idrFlag is not null)
            {
                IdrFlag = idrFlag.Value;
            }

            if (isReferenceFlag is not null)
            {
                IsReferenceFlag = isReferenceFlag.Value;
            }

            if (numRefIdxActiveOverrideFlag is not null)
            {
                NumRefIdxActiveOverrideFlag = numRefIdxActiveOverrideFlag.Value;
            }

            if (noOutputOfPriorPicsFlag is not null)
            {
                NoOutputOfPriorPicsFlag = noOutputOfPriorPicsFlag.Value;
            }

            if (longTermReferenceFlag is not null)
            {
                LongTermReferenceFlag = longTermReferenceFlag.Value;
            }

            if (adaptiveRefPicMarkingModeFlag is not null)
            {
                AdaptiveRefPicMarkingModeFlag = adaptiveRefPicMarkingModeFlag.Value;
            }

            if (noPriorReferencesAvailableFlag is not null)
            {
                NoPriorReferencesAvailableFlag = noPriorReferencesAvailableFlag.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "idr_flag")]
        public uint IdrFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "is_reference_flag")]
        public uint IsReferenceFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "num_ref_idx_active_override_flag")]
        public uint NumRefIdxActiveOverrideFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "no_output_of_prior_pics_flag")]
        public uint NoOutputOfPriorPicsFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "long_term_reference_flag")]
        public uint LongTermReferenceFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "adaptive_ref_pic_marking_mode_flag")]
        public uint AdaptiveRefPicMarkingModeFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "no_prior_references_available_flag")]
        public uint NoPriorReferencesAvailableFlag;
    }
}
