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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVAHD_STREAM_STATE_FRAME_FORMAT_DATA")]
    public unsafe partial struct HDStreamStateFrameFormatData
    {
        public HDStreamStateFrameFormatData
        (
            HDFrameFormat? frameFormat = null
        ) : this()
        {
            if (frameFormat is not null)
            {
                FrameFormat = frameFormat.Value;
            }
        }


        [NativeName("Type", "DXVAHD_FRAME_FORMAT")]
        [NativeName("Type.Name", "DXVAHD_FRAME_FORMAT")]
        [NativeName("Name", "FrameFormat")]
        public HDFrameFormat FrameFormat;
    }
}
