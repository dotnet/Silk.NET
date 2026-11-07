// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_TIMED_TEXT_WRITING_MODE")]
    public enum TimedTextWritingMode : int
    {
        [NativeName("Name", "MF_TIMED_TEXT_WRITING_MODE_LRTB")]
        Lrtb = 0x0,
        [NativeName("Name", "MF_TIMED_TEXT_WRITING_MODE_RLTB")]
        Rltb = 0x1,
        [NativeName("Name", "MF_TIMED_TEXT_WRITING_MODE_TBRL")]
        Tbrl = 0x2,
        [NativeName("Name", "MF_TIMED_TEXT_WRITING_MODE_TBLR")]
        Tblr = 0x3,
        [NativeName("Name", "MF_TIMED_TEXT_WRITING_MODE_LR")]
        LR = 0x4,
        [NativeName("Name", "MF_TIMED_TEXT_WRITING_MODE_RL")]
        RL = 0x5,
        [NativeName("Name", "MF_TIMED_TEXT_WRITING_MODE_TB")]
        TB = 0x6,
    }
}
