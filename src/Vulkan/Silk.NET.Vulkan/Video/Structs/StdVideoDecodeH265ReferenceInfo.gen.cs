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
    [NativeName("Name", "StdVideoDecodeH265ReferenceInfo")]
    public unsafe partial struct StdVideoDecodeH265ReferenceInfo
    {
        public StdVideoDecodeH265ReferenceInfo
        (
            StdVideoDecodeH265ReferenceInfoFlags? flags = null,
            int? picOrderCntVal = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (picOrderCntVal is not null)
            {
                PicOrderCntVal = picOrderCntVal.Value;
            }
        }


        [NativeName("Type", "StdVideoDecodeH265ReferenceInfoFlags")]
        [NativeName("Type.Name", "StdVideoDecodeH265ReferenceInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoDecodeH265ReferenceInfoFlags Flags;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "PicOrderCntVal")]
        public int PicOrderCntVal;
    }
}
