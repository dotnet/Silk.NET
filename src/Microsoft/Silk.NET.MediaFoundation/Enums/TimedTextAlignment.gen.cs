// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_TIMED_TEXT_ALIGNMENT")]
    public enum TimedTextAlignment : int
    {
        [NativeName("Name", "MF_TIMED_TEXT_ALIGNMENT_START")]
        Start = 0x0,
        [NativeName("Name", "MF_TIMED_TEXT_ALIGNMENT_END")]
        End = 0x1,
        [NativeName("Name", "MF_TIMED_TEXT_ALIGNMENT_CENTER")]
        Center = 0x2,
    }
}
