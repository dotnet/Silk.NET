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
    [NativeName("Name", "StdVideoDecodeH265PictureInfoFlags")]
    public unsafe partial struct StdVideoDecodeH265PictureInfoFlags
    {
        public StdVideoDecodeH265PictureInfoFlags
        (
            uint? irapPicFlag = null,
            uint? idrPicFlag = null,
            uint? isReference = null,
            uint? shortTermRefPicSetSpsFlag = null
        ) : this()
        {
            if (irapPicFlag is not null)
            {
                IrapPicFlag = irapPicFlag.Value;
            }

            if (idrPicFlag is not null)
            {
                IdrPicFlag = idrPicFlag.Value;
            }

            if (isReference is not null)
            {
                IsReference = isReference.Value;
            }

            if (shortTermRefPicSetSpsFlag is not null)
            {
                ShortTermRefPicSetSpsFlag = shortTermRefPicSetSpsFlag.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "IrapPicFlag")]
        public uint IrapPicFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "IdrPicFlag")]
        public uint IdrPicFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "IsReference")]
        public uint IsReference;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "short_term_ref_pic_set_sps_flag")]
        public uint ShortTermRefPicSetSpsFlag;
    }
}
