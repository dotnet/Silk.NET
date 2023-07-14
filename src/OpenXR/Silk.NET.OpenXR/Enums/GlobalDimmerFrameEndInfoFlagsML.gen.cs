// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrGlobalDimmerFrameEndInfoFlagsML")]
    public enum GlobalDimmerFrameEndInfoFlagsML : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"EnabledBitML\"")]
        [NativeName("Name", "XR_GLOBAL_DIMMER_FRAME_END_INFO_ENABLED_BIT_ML")]
        GlobalDimmerFrameEndInfoEnabledBitML = 1,
        [NativeName("Name", "XR_GLOBAL_DIMMER_FRAME_END_INFO_ENABLED_BIT_ML")]
        EnabledBitML = 1,
    }
}
