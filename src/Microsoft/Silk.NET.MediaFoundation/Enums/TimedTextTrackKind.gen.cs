// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_TIMED_TEXT_TRACK_KIND")]
    public enum TimedTextTrackKind : int
    {
        [NativeName("Name", "MF_TIMED_TEXT_TRACK_KIND_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "MF_TIMED_TEXT_TRACK_KIND_SUBTITLES")]
        Subtitles = 0x1,
        [NativeName("Name", "MF_TIMED_TEXT_TRACK_KIND_CAPTIONS")]
        Captions = 0x2,
        [NativeName("Name", "MF_TIMED_TEXT_TRACK_KIND_METADATA")]
        Metadata = 0x3,
    }
}
