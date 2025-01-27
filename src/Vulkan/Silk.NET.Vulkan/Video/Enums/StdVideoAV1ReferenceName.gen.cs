// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoAV1ReferenceName")]
    public enum StdVideoAV1ReferenceName : int
    {
        [Obsolete("Deprecated in favour of \"IntraFrame\"")]
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_INTRA_FRAME")]
        StdVideoAV1ReferenceNameIntraFrame = 0x0,
        [Obsolete("Deprecated in favour of \"LastFrame\"")]
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_LAST_FRAME")]
        StdVideoAV1ReferenceNameLastFrame = 0x1,
        [Obsolete("Deprecated in favour of \"Last2Frame\"")]
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_LAST2_FRAME")]
        StdVideoAV1ReferenceNameLast2Frame = 0x2,
        [Obsolete("Deprecated in favour of \"Last3Frame\"")]
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_LAST3_FRAME")]
        StdVideoAV1ReferenceNameLast3Frame = 0x3,
        [Obsolete("Deprecated in favour of \"GoldenFrame\"")]
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_GOLDEN_FRAME")]
        StdVideoAV1ReferenceNameGoldenFrame = 0x4,
        [Obsolete("Deprecated in favour of \"BwdrefFrame\"")]
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_BWDREF_FRAME")]
        StdVideoAV1ReferenceNameBwdrefFrame = 0x5,
        [Obsolete("Deprecated in favour of \"Altref2Frame\"")]
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_ALTREF2_FRAME")]
        StdVideoAV1ReferenceNameAltref2Frame = 0x6,
        [Obsolete("Deprecated in favour of \"AltrefFrame\"")]
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_ALTREF_FRAME")]
        StdVideoAV1ReferenceNameAltrefFrame = 0x7,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_INVALID")]
        StdVideoAV1ReferenceNameInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_MAX_ENUM")]
        StdVideoAV1ReferenceNameMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_INTRA_FRAME")]
        IntraFrame = 0x0,
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_LAST_FRAME")]
        LastFrame = 0x1,
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_LAST2_FRAME")]
        Last2Frame = 0x2,
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_LAST3_FRAME")]
        Last3Frame = 0x3,
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_GOLDEN_FRAME")]
        GoldenFrame = 0x4,
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_BWDREF_FRAME")]
        BwdrefFrame = 0x5,
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_ALTREF2_FRAME")]
        Altref2Frame = 0x6,
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_ALTREF_FRAME")]
        AltrefFrame = 0x7,
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_REFERENCE_NAME_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
