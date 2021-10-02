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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC")]
    public unsafe partial struct VideoProcessorOutputViewDesc
    {
        public VideoProcessorOutputViewDesc
        (
            VpovDimension? viewDimension = null
        ) : this()
        {
            if (viewDimension is not null)
            {
                ViewDimension = viewDimension.Value;
            }
        }


        [NativeName("Type", "D3D11_VPOV_DIMENSION")]
        [NativeName("Type.Name", "D3D11_VPOV_DIMENSION")]
        [NativeName("Name", "ViewDimension")]
        public VpovDimension ViewDimension;
    }
}
