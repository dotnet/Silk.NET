// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_TIMED_TEXT_DISPLAY_ALIGNMENT")]
    public enum TimedTextDisplayAlignment : int
    {
        [NativeName("Name", "MF_TIMED_TEXT_DISPLAY_ALIGNMENT_BEFORE")]
        Before = 0x0,
        [NativeName("Name", "MF_TIMED_TEXT_DISPLAY_ALIGNMENT_AFTER")]
        After = 0x1,
        [NativeName("Name", "MF_TIMED_TEXT_DISPLAY_ALIGNMENT_CENTER")]
        Center = 0x2,
    }
}
