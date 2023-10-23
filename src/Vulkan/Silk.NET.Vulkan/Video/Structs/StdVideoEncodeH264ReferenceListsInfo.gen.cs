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
    [NativeName("Name", "StdVideoEncodeH264ReferenceListsInfo")]
    public unsafe partial struct StdVideoEncodeH264ReferenceListsInfo
    {
        public StdVideoEncodeH264ReferenceListsInfo
        (
            StdVideoEncodeH264ReferenceListsInfoFlags? flags = null,
            byte? numRefIdxL0ActiveMinus1 = null,
            byte? numRefIdxL1ActiveMinus1 = null,
            byte? refList0ModOpCount = null,
            byte? refList1ModOpCount = null,
            byte? refPicMarkingOpCount = null,
            StdVideoEncodeH264RefListModEntry* pRefList0ModOperations = null,
            StdVideoEncodeH264RefListModEntry* pRefList1ModOperations = null,
            StdVideoEncodeH264RefPicMarkingEntry* pRefPicMarkingOperations = null
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

            if (refList0ModOpCount is not null)
            {
                RefList0ModOpCount = refList0ModOpCount.Value;
            }

            if (refList1ModOpCount is not null)
            {
                RefList1ModOpCount = refList1ModOpCount.Value;
            }

            if (refPicMarkingOpCount is not null)
            {
                RefPicMarkingOpCount = refPicMarkingOpCount.Value;
            }

            if (pRefList0ModOperations is not null)
            {
                PRefList0ModOperations = pRefList0ModOperations;
            }

            if (pRefList1ModOperations is not null)
            {
                PRefList1ModOperations = pRefList1ModOperations;
            }

            if (pRefPicMarkingOperations is not null)
            {
                PRefPicMarkingOperations = pRefPicMarkingOperations;
            }
        }


        [NativeName("Type", "StdVideoEncodeH264ReferenceListsInfoFlags")]
        [NativeName("Type.Name", "StdVideoEncodeH264ReferenceListsInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeH264ReferenceListsInfoFlags Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_ref_idx_l0_active_minus1")]
        public byte NumRefIdxL0ActiveMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_ref_idx_l1_active_minus1")]
        public byte NumRefIdxL1ActiveMinus1;
        [NativeName("Type", "uint8_t[32]")]
        [NativeName("Type.Name", "uint8_t[32]")]
        [NativeName("Name", "RefPicList0")]
        public fixed byte RefPicList0[32];
        [NativeName("Type", "uint8_t[32]")]
        [NativeName("Type.Name", "uint8_t[32]")]
        [NativeName("Name", "RefPicList1")]
        public fixed byte RefPicList1[32];

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "refList0ModOpCount")]
        public byte RefList0ModOpCount;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "refList1ModOpCount")]
        public byte RefList1ModOpCount;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "refPicMarkingOpCount")]
        public byte RefPicMarkingOpCount;
        [NativeName("Type", "uint8_t[7]")]
        [NativeName("Type.Name", "uint8_t[7]")]
        [NativeName("Name", "reserved1")]
        public fixed byte Reserved1[7];

        [NativeName("Type", "const StdVideoEncodeH264RefListModEntry *")]
        [NativeName("Type.Name", "const StdVideoEncodeH264RefListModEntry *")]
        [NativeName("Name", "pRefList0ModOperations")]
        public StdVideoEncodeH264RefListModEntry* PRefList0ModOperations;

        [NativeName("Type", "const StdVideoEncodeH264RefListModEntry *")]
        [NativeName("Type.Name", "const StdVideoEncodeH264RefListModEntry *")]
        [NativeName("Name", "pRefList1ModOperations")]
        public StdVideoEncodeH264RefListModEntry* PRefList1ModOperations;

        [NativeName("Type", "const StdVideoEncodeH264RefPicMarkingEntry *")]
        [NativeName("Type.Name", "const StdVideoEncodeH264RefPicMarkingEntry *")]
        [NativeName("Name", "pRefPicMarkingOperations")]
        public StdVideoEncodeH264RefPicMarkingEntry* PRefPicMarkingOperations;
    }
}
