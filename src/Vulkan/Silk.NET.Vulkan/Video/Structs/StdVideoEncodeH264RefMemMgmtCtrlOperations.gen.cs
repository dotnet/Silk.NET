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
    [NativeName("Name", "StdVideoEncodeH264RefMemMgmtCtrlOperations")]
    public unsafe partial struct StdVideoEncodeH264RefMemMgmtCtrlOperations
    {
        public StdVideoEncodeH264RefMemMgmtCtrlOperations
        (
            StdVideoEncodeH264RefMgmtFlags? flags = null,
            byte? refList0ModOpCount = null,
            StdVideoEncodeH264RefListModEntry* pRefList0ModOperations = null,
            byte? refList1ModOpCount = null,
            StdVideoEncodeH264RefListModEntry* pRefList1ModOperations = null,
            byte? refPicMarkingOpCount = null,
            StdVideoEncodeH264RefPicMarkingEntry* pRefPicMarkingOperations = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (refList0ModOpCount is not null)
            {
                RefList0ModOpCount = refList0ModOpCount.Value;
            }

            if (pRefList0ModOperations is not null)
            {
                PRefList0ModOperations = pRefList0ModOperations;
            }

            if (refList1ModOpCount is not null)
            {
                RefList1ModOpCount = refList1ModOpCount.Value;
            }

            if (pRefList1ModOperations is not null)
            {
                PRefList1ModOperations = pRefList1ModOperations;
            }

            if (refPicMarkingOpCount is not null)
            {
                RefPicMarkingOpCount = refPicMarkingOpCount.Value;
            }

            if (pRefPicMarkingOperations is not null)
            {
                PRefPicMarkingOperations = pRefPicMarkingOperations;
            }
        }


        [NativeName("Type", "StdVideoEncodeH264RefMgmtFlags")]
        [NativeName("Type.Name", "StdVideoEncodeH264RefMgmtFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeH264RefMgmtFlags Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "refList0ModOpCount")]
        public byte RefList0ModOpCount;

        [NativeName("Type", "const StdVideoEncodeH264RefListModEntry *")]
        [NativeName("Type.Name", "const StdVideoEncodeH264RefListModEntry *")]
        [NativeName("Name", "pRefList0ModOperations")]
        public StdVideoEncodeH264RefListModEntry* PRefList0ModOperations;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "refList1ModOpCount")]
        public byte RefList1ModOpCount;

        [NativeName("Type", "const StdVideoEncodeH264RefListModEntry *")]
        [NativeName("Type.Name", "const StdVideoEncodeH264RefListModEntry *")]
        [NativeName("Name", "pRefList1ModOperations")]
        public StdVideoEncodeH264RefListModEntry* PRefList1ModOperations;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "refPicMarkingOpCount")]
        public byte RefPicMarkingOpCount;

        [NativeName("Type", "const StdVideoEncodeH264RefPicMarkingEntry *")]
        [NativeName("Type.Name", "const StdVideoEncodeH264RefPicMarkingEntry *")]
        [NativeName("Name", "pRefPicMarkingOperations")]
        public StdVideoEncodeH264RefPicMarkingEntry* PRefPicMarkingOperations;
    }
}
