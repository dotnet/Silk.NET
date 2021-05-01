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
    [NativeName("Name", "StdVideoDecodeH264MvcElementFlags")]
    public unsafe partial struct StdVideoDecodeH264MvcElementFlags
    {
        public StdVideoDecodeH264MvcElementFlags
        (
            uint? nonIdr = null,
            uint? anchorPic = null,
            uint? interView = null
        ) : this()
        {
            if (nonIdr is not null)
            {
                NonIdr = nonIdr.Value;
            }

            if (anchorPic is not null)
            {
                AnchorPic = anchorPic.Value;
            }

            if (interView is not null)
            {
                InterView = interView.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "non_idr")]
        public uint NonIdr;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "anchor_pic")]
        public uint AnchorPic;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "inter_view")]
        public uint InterView;
    }
}
