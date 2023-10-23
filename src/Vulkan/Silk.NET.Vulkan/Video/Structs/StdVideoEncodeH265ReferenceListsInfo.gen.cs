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
    [NativeName("Name", "StdVideoEncodeH265ReferenceListsInfo")]
    public unsafe partial struct StdVideoEncodeH265ReferenceListsInfo
    {
        public StdVideoEncodeH265ReferenceListsInfo
        (
            StdVideoEncodeH265ReferenceListsInfoFlags? flags = null,
            byte? numRefIdxL0ActiveMinus1 = null,
            byte? numRefIdxL1ActiveMinus1 = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (numRefIdxL0ActiveMinus1 is not null)
            {
                NumRefIdxL0ActiveMinus1 = numRefIdxL0ActiveMinus1.Value;
            }

            if (numRefIdxL1ActiveMinus1 is not null)
            {
                NumRefIdxL1ActiveMinus1 = numRefIdxL1ActiveMinus1.Value;
            }
        }


        [NativeName("Type", "StdVideoEncodeH265ReferenceListsInfoFlags")]
        [NativeName("Type.Name", "StdVideoEncodeH265ReferenceListsInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeH265ReferenceListsInfoFlags Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_ref_idx_l0_active_minus1")]
        public byte NumRefIdxL0ActiveMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_ref_idx_l1_active_minus1")]
        public byte NumRefIdxL1ActiveMinus1;
        [NativeName("Type", "uint8_t[15]")]
        [NativeName("Type.Name", "uint8_t[15]")]
        [NativeName("Name", "RefPicList0")]
        public fixed byte RefPicList0[15];
        [NativeName("Type", "uint8_t[15]")]
        [NativeName("Type.Name", "uint8_t[15]")]
        [NativeName("Name", "RefPicList1")]
        public fixed byte RefPicList1[15];
        [NativeName("Type", "uint8_t[15]")]
        [NativeName("Type.Name", "uint8_t[15]")]
        [NativeName("Name", "list_entry_l0")]
        public fixed byte ListEntryL0[15];
        [NativeName("Type", "uint8_t[15]")]
        [NativeName("Type.Name", "uint8_t[15]")]
        [NativeName("Name", "list_entry_l1")]
        public fixed byte ListEntryL1[15];
    }
}
