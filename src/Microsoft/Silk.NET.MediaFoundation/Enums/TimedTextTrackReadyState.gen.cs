// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_TIMED_TEXT_TRACK_READY_STATE")]
    public enum TimedTextTrackReadyState : int
    {
        [NativeName("Name", "MF_TIMED_TEXT_TRACK_READY_STATE_NONE")]
        None = 0x0,
        [NativeName("Name", "MF_TIMED_TEXT_TRACK_READY_STATE_LOADING")]
        Loading = 0x1,
        [NativeName("Name", "MF_TIMED_TEXT_TRACK_READY_STATE_LOADED")]
        Loaded = 0x2,
        [NativeName("Name", "MF_TIMED_TEXT_TRACK_READY_STATE_ERROR")]
        Error = 0x3,
    }
}
