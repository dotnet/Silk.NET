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
    [NativeName("Name", "StdVideoDecodeH264PictureInfoFlags")]
    public unsafe partial struct StdVideoDecodeH264PictureInfoFlags
    {
        public StdVideoDecodeH264PictureInfoFlags
        (
            uint? fieldPicFlag = null,
            uint? isIntra = null,
            uint? bottomFieldFlag = null,
            uint? isReference = null,
            uint? complementaryFieldPair = null
        ) : this()
        {
            if (fieldPicFlag is not null)
            {
                FieldPicFlag = fieldPicFlag.Value;
            }

            if (isIntra is not null)
            {
                IsIntra = isIntra.Value;
            }

            if (bottomFieldFlag is not null)
            {
                BottomFieldFlag = bottomFieldFlag.Value;
            }

            if (isReference is not null)
            {
                IsReference = isReference.Value;
            }

            if (complementaryFieldPair is not null)
            {
                ComplementaryFieldPair = complementaryFieldPair.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "field_pic_flag")]
        public uint FieldPicFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "is_intra")]
        public uint IsIntra;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bottom_field_flag")]
        public uint BottomFieldFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "is_reference")]
        public uint IsReference;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "complementary_field_pair")]
        public uint ComplementaryFieldPair;
    }
}
