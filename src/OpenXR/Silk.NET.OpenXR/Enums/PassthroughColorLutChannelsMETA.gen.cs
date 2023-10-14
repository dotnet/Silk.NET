// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPassthroughColorLutChannelsMETA")]
    public enum PassthroughColorLutChannelsMETA : int
    {
        [Obsolete("Deprecated in favour of \"RgbMeta\"")]
        [NativeName("Name", "XR_PASSTHROUGH_COLOR_LUT_CHANNELS_RGB_META")]
        PassthroughColorLutChannelsRgbMeta = 1,
        [Obsolete("Deprecated in favour of \"RgbaMeta\"")]
        [NativeName("Name", "XR_PASSTHROUGH_COLOR_LUT_CHANNELS_RGBA_META")]
        PassthroughColorLutChannelsRgbaMeta = 2,
        [NativeName("Name", "XR_PASSTHROUGH_COLOR_LUT_CHANNELS_RGB_META")]
        RgbMeta = 1,
        [NativeName("Name", "XR_PASSTHROUGH_COLOR_LUT_CHANNELS_RGBA_META")]
        RgbaMeta = 2,
    }
}
