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
            byte? numRefIdxL1ActiveMinus1 = null,
            ushort? reserved1 = null,
            byte* pRefPicList0Entries = null,
            byte* pRefPicList1Entries = null,
            byte* pRefList0Modifications = null,
            byte* pRefList1Modifications = null
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

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (pRefPicList0Entries is not null)
            {
                PRefPicList0Entries = pRefPicList0Entries;
            }

            if (pRefPicList1Entries is not null)
            {
                PRefPicList1Entries = pRefPicList1Entries;
            }

            if (pRefList0Modifications is not null)
            {
                PRefList0Modifications = pRefList0Modifications;
            }

            if (pRefList1Modifications is not null)
            {
                PRefList1Modifications = pRefList1Modifications;
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

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "reserved1")]
        public ushort Reserved1;

        [NativeName("Type", "const uint8_t *")]
        [NativeName("Type.Name", "const uint8_t *")]
        [NativeName("Name", "pRefPicList0Entries")]
        public byte* PRefPicList0Entries;

        [NativeName("Type", "const uint8_t *")]
        [NativeName("Type.Name", "const uint8_t *")]
        [NativeName("Name", "pRefPicList1Entries")]
        public byte* PRefPicList1Entries;

        [NativeName("Type", "const uint8_t *")]
        [NativeName("Type.Name", "const uint8_t *")]
        [NativeName("Name", "pRefList0Modifications")]
        public byte* PRefList0Modifications;

        [NativeName("Type", "const uint8_t *")]
        [NativeName("Type.Name", "const uint8_t *")]
        [NativeName("Name", "pRefList1Modifications")]
        public byte* PRefList1Modifications;
    }
}
