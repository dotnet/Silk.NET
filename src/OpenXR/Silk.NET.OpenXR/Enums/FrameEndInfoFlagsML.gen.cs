// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrFrameEndInfoFlagsML")]
    public enum FrameEndInfoFlagsML : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ProtectedBitML\"")]
        [NativeName("Name", "XR_FRAME_END_INFO_PROTECTED_BIT_ML")]
        FrameEndInfoProtectedBitML = 1,
        [Obsolete("Deprecated in favour of \"VignetteBitML\"")]
        [NativeName("Name", "XR_FRAME_END_INFO_VIGNETTE_BIT_ML")]
        FrameEndInfoVignetteBitML = 2,
        [NativeName("Name", "XR_FRAME_END_INFO_PROTECTED_BIT_ML")]
        ProtectedBitML = 1,
        [NativeName("Name", "XR_FRAME_END_INFO_VIGNETTE_BIT_ML")]
        VignetteBitML = 2,
    }
}
