// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.XAudio
{
    [Flags]
    [NativeName("Name", "_AUDCLNT_SHAREMODE")]
    public enum AudclntSharemode : int
    {
        [NativeName("Name", "AUDCLNT_SHAREMODE_SHARED")]
        AudclntSharemodeShared = 0x0,
        [NativeName("Name", "AUDCLNT_SHAREMODE_EXCLUSIVE")]
        AudclntSharemodeExclusive = 0x1,
    }
}
