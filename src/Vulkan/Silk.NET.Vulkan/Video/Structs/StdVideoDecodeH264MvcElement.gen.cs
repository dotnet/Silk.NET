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
    [NativeName("Name", "StdVideoDecodeH264MvcElement")]
    public unsafe partial struct StdVideoDecodeH264MvcElement
    {
        public StdVideoDecodeH264MvcElement
        (
            StdVideoDecodeH264MvcElementFlags? flags = null,
            ushort? viewOrderIndex = null,
            ushort? viewId = null,
            ushort? temporalId = null,
            ushort? priorityId = null,
            ushort? numOfAnchorRefsInL0 = null,
            ushort? numOfAnchorRefsInL1 = null,
            ushort? numOfNonAnchorRefsInL0 = null,
            ushort? numOfNonAnchorRefsInL1 = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (viewOrderIndex is not null)
            {
                ViewOrderIndex = viewOrderIndex.Value;
            }

            if (viewId is not null)
            {
                ViewId = viewId.Value;
            }

            if (temporalId is not null)
            {
                TemporalId = temporalId.Value;
            }

            if (priorityId is not null)
            {
                PriorityId = priorityId.Value;
            }

            if (numOfAnchorRefsInL0 is not null)
            {
                NumOfAnchorRefsInL0 = numOfAnchorRefsInL0.Value;
            }

            if (numOfAnchorRefsInL1 is not null)
            {
                NumOfAnchorRefsInL1 = numOfAnchorRefsInL1.Value;
            }

            if (numOfNonAnchorRefsInL0 is not null)
            {
                NumOfNonAnchorRefsInL0 = numOfNonAnchorRefsInL0.Value;
            }

            if (numOfNonAnchorRefsInL1 is not null)
            {
                NumOfNonAnchorRefsInL1 = numOfNonAnchorRefsInL1.Value;
            }
        }


        [NativeName("Type", "StdVideoDecodeH264MvcElementFlags")]
        [NativeName("Type.Name", "StdVideoDecodeH264MvcElementFlags")]
        [NativeName("Name", "flags")]
        public StdVideoDecodeH264MvcElementFlags Flags;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "viewOrderIndex")]
        public ushort ViewOrderIndex;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "viewId")]
        public ushort ViewId;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "temporalId")]
        public ushort TemporalId;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "priorityId")]
        public ushort PriorityId;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "numOfAnchorRefsInL0")]
        public ushort NumOfAnchorRefsInL0;
        [NativeName("Type", "uint16_t[15]")]
        [NativeName("Type.Name", "uint16_t[15]")]
        [NativeName("Name", "viewIdOfAnchorRefsInL0")]
        public fixed ushort ViewIdOfAnchorRefsInL0[15];

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "numOfAnchorRefsInL1")]
        public ushort NumOfAnchorRefsInL1;
        [NativeName("Type", "uint16_t[15]")]
        [NativeName("Type.Name", "uint16_t[15]")]
        [NativeName("Name", "viewIdOfAnchorRefsInL1")]
        public fixed ushort ViewIdOfAnchorRefsInL1[15];

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "numOfNonAnchorRefsInL0")]
        public ushort NumOfNonAnchorRefsInL0;
        [NativeName("Type", "uint16_t[15]")]
        [NativeName("Type.Name", "uint16_t[15]")]
        [NativeName("Name", "viewIdOfNonAnchorRefsInL0")]
        public fixed ushort ViewIdOfNonAnchorRefsInL0[15];

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "numOfNonAnchorRefsInL1")]
        public ushort NumOfNonAnchorRefsInL1;
        [NativeName("Type", "uint16_t[15]")]
        [NativeName("Type.Name", "uint16_t[15]")]
        [NativeName("Name", "viewIdOfNonAnchorRefsInL1")]
        public fixed ushort ViewIdOfNonAnchorRefsInL1[15];
    }
}
