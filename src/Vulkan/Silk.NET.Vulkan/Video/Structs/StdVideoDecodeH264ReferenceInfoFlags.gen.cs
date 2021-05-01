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
    [NativeName("Name", "StdVideoDecodeH264ReferenceInfoFlags")]
    public unsafe partial struct StdVideoDecodeH264ReferenceInfoFlags
    {
        public StdVideoDecodeH264ReferenceInfoFlags
        (
            uint? topFieldFlag = null,
            uint? bottomFieldFlag = null,
            uint? isLongTerm = null,
            uint? isNonExisting = null
        ) : this()
        {
            if (topFieldFlag is not null)
            {
                TopFieldFlag = topFieldFlag.Value;
            }

            if (bottomFieldFlag is not null)
            {
                BottomFieldFlag = bottomFieldFlag.Value;
            }

            if (isLongTerm is not null)
            {
                IsLongTerm = isLongTerm.Value;
            }

            if (isNonExisting is not null)
            {
                IsNonExisting = isNonExisting.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "top_field_flag")]
        public uint TopFieldFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bottom_field_flag")]
        public uint BottomFieldFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "is_long_term")]
        public uint IsLongTerm;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "is_non_existing")]
        public uint IsNonExisting;
    }
}
