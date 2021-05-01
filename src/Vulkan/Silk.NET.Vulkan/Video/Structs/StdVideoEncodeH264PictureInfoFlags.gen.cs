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
    [NativeName("Name", "StdVideoEncodeH264PictureInfoFlags")]
    public unsafe partial struct StdVideoEncodeH264PictureInfoFlags
    {
        public StdVideoEncodeH264PictureInfoFlags
        (
            uint? idrFlag = null,
            uint? isReferenceFlag = null,
            uint? longTermReferenceFlag = null
        ) : this()
        {
            if (idrFlag is not null)
            {
                IdrFlag = idrFlag.Value;
            }

            if (isReferenceFlag is not null)
            {
                IsReferenceFlag = isReferenceFlag.Value;
            }

            if (longTermReferenceFlag is not null)
            {
                LongTermReferenceFlag = longTermReferenceFlag.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "idr_flag")]
        public uint IdrFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "is_reference_flag")]
        public uint IsReferenceFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "long_term_reference_flag")]
        public uint LongTermReferenceFlag;
    }
}
