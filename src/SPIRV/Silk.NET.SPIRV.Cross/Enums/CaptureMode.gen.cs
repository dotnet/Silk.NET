// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_capture_mode")]
    public enum CaptureMode : int
    {
        [NativeName("Name", "SPVC_CAPTURE_MODE_COPY")]
        Copy = 0x0,
        [NativeName("Name", "SPVC_CAPTURE_MODE_TAKE_OWNERSHIP")]
        TakeOwnership = 0x1,
        [NativeName("Name", "SPVC_CAPTURE_MODE_INT_MAX")]
        IntMax = 0x7FFFFFFF,
    }
}
