// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoVP9ReferenceName")]
    public enum StdVideoVP9ReferenceName : int
    {
        [Obsolete("Deprecated in favour of \"IntraFrame\"")]
        [NativeName("Name", "STD_VIDEO_VP9_REFERENCE_NAME_INTRA_FRAME")]
        StdVideoVP9ReferenceNameIntraFrame = 0x0,
        [Obsolete("Deprecated in favour of \"LastFrame\"")]
        [NativeName("Name", "STD_VIDEO_VP9_REFERENCE_NAME_LAST_FRAME")]
        StdVideoVP9ReferenceNameLastFrame = 0x1,
        [Obsolete("Deprecated in favour of \"GoldenFrame\"")]
        [NativeName("Name", "STD_VIDEO_VP9_REFERENCE_NAME_GOLDEN_FRAME")]
        StdVideoVP9ReferenceNameGoldenFrame = 0x2,
        [Obsolete("Deprecated in favour of \"AltrefFrame\"")]
        [NativeName("Name", "STD_VIDEO_VP9_REFERENCE_NAME_ALTREF_FRAME")]
        StdVideoVP9ReferenceNameAltrefFrame = 0x3,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_VP9_REFERENCE_NAME_INVALID")]
        StdVideoVP9ReferenceNameInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_VP9_REFERENCE_NAME_MAX_ENUM")]
        StdVideoVP9ReferenceNameMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_VP9_REFERENCE_NAME_INTRA_FRAME")]
        IntraFrame = 0x0,
        [NativeName("Name", "STD_VIDEO_VP9_REFERENCE_NAME_LAST_FRAME")]
        LastFrame = 0x1,
        [NativeName("Name", "STD_VIDEO_VP9_REFERENCE_NAME_GOLDEN_FRAME")]
        GoldenFrame = 0x2,
        [NativeName("Name", "STD_VIDEO_VP9_REFERENCE_NAME_ALTREF_FRAME")]
        AltrefFrame = 0x3,
        [NativeName("Name", "STD_VIDEO_VP9_REFERENCE_NAME_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_VP9_REFERENCE_NAME_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
