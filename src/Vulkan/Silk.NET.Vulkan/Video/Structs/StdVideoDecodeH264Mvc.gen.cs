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
    [NativeName("Name", "StdVideoDecodeH264Mvc")]
    public unsafe partial struct StdVideoDecodeH264Mvc
    {
        public StdVideoDecodeH264Mvc
        (
            uint? viewId0 = null,
            uint? mvcElementCount = null,
            StdVideoDecodeH264MvcElement* pMvcElements = null
        ) : this()
        {
            if (viewId0 is not null)
            {
                ViewId0 = viewId0.Value;
            }

            if (mvcElementCount is not null)
            {
                MvcElementCount = mvcElementCount.Value;
            }

            if (pMvcElements is not null)
            {
                PMvcElements = pMvcElements;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "viewId0")]
        public uint ViewId0;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "mvcElementCount")]
        public uint MvcElementCount;

        [NativeName("Type", "const StdVideoDecodeH264MvcElement *")]
        [NativeName("Type.Name", "const StdVideoDecodeH264MvcElement *")]
        [NativeName("Name", "pMvcElements")]
        public StdVideoDecodeH264MvcElement* PMvcElements;
    }
}
