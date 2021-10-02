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
    [NativeName("Name", "StdVideoEncodeH264RefListModEntry")]
    public unsafe partial struct StdVideoEncodeH264RefListModEntry
    {
        public StdVideoEncodeH264RefListModEntry
        (
            StdVideoH264ModificationOfPicNumsIdc? modificationOfPicNumsIdc = null,
            ushort? absDiffPicNumMinus1 = null,
            ushort? longTermPicNum = null
        ) : this()
        {
            if (modificationOfPicNumsIdc is not null)
            {
                ModificationOfPicNumsIdc = modificationOfPicNumsIdc.Value;
            }

            if (absDiffPicNumMinus1 is not null)
            {
                AbsDiffPicNumMinus1 = absDiffPicNumMinus1.Value;
            }

            if (longTermPicNum is not null)
            {
                LongTermPicNum = longTermPicNum.Value;
            }
        }


        [NativeName("Type", "StdVideoH264ModificationOfPicNumsIdc")]
        [NativeName("Type.Name", "StdVideoH264ModificationOfPicNumsIdc")]
        [NativeName("Name", "modification_of_pic_nums_idc")]
        public StdVideoH264ModificationOfPicNumsIdc ModificationOfPicNumsIdc;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "abs_diff_pic_num_minus1")]
        public ushort AbsDiffPicNumMinus1;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "long_term_pic_num")]
        public ushort LongTermPicNum;
    }
}
