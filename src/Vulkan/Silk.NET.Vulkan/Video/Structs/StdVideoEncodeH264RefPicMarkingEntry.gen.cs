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
    [NativeName("Name", "StdVideoEncodeH264RefPicMarkingEntry")]
    public unsafe partial struct StdVideoEncodeH264RefPicMarkingEntry
    {
        public StdVideoEncodeH264RefPicMarkingEntry
        (
            StdVideoH264MemMgmtControlOp? memoryManagementControlOperation = null,
            ushort? differenceOfPicNumsMinus1 = null,
            ushort? longTermPicNum = null,
            ushort? longTermFrameIdx = null,
            ushort? maxLongTermFrameIdxPlus1 = null
        ) : this()
        {
            if (memoryManagementControlOperation is not null)
            {
                MemoryManagementControlOperation = memoryManagementControlOperation.Value;
            }

            if (differenceOfPicNumsMinus1 is not null)
            {
                DifferenceOfPicNumsMinus1 = differenceOfPicNumsMinus1.Value;
            }

            if (longTermPicNum is not null)
            {
                LongTermPicNum = longTermPicNum.Value;
            }

            if (longTermFrameIdx is not null)
            {
                LongTermFrameIdx = longTermFrameIdx.Value;
            }

            if (maxLongTermFrameIdxPlus1 is not null)
            {
                MaxLongTermFrameIdxPlus1 = maxLongTermFrameIdxPlus1.Value;
            }
        }


        [NativeName("Type", "StdVideoH264MemMgmtControlOp")]
        [NativeName("Type.Name", "StdVideoH264MemMgmtControlOp")]
        [NativeName("Name", "memory_management_control_operation")]
        public StdVideoH264MemMgmtControlOp MemoryManagementControlOperation;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "difference_of_pic_nums_minus1")]
        public ushort DifferenceOfPicNumsMinus1;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "long_term_pic_num")]
        public ushort LongTermPicNum;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "long_term_frame_idx")]
        public ushort LongTermFrameIdx;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "max_long_term_frame_idx_plus1")]
        public ushort MaxLongTermFrameIdxPlus1;
    }
}
