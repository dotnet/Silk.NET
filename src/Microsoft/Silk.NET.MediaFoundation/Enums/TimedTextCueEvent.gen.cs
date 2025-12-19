// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_TIMED_TEXT_CUE_EVENT")]
    public enum TimedTextCueEvent : int
    {
        [NativeName("Name", "MF_TIMED_TEXT_CUE_EVENT_ACTIVE")]
        Active = 0x0,
        [NativeName("Name", "MF_TIMED_TEXT_CUE_EVENT_INACTIVE")]
        Inactive = 0x1,
        [NativeName("Name", "MF_TIMED_TEXT_CUE_EVENT_CLEAR")]
        Clear = 0x2,
    }
}
