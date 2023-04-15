// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.XAudio
{
    [NativeName("Name", "_AudioSessionState")]
    public enum AudioSessionState : int
    {
        [Obsolete("Deprecated in favour of \"Inactive\"")]
        [NativeName("Name", "AudioSessionStateInactive")]
        AudioSessionStateInactive = 0x0,
        [Obsolete("Deprecated in favour of \"Active\"")]
        [NativeName("Name", "AudioSessionStateActive")]
        AudioSessionStateActive = 0x1,
        [Obsolete("Deprecated in favour of \"Expired\"")]
        [NativeName("Name", "AudioSessionStateExpired")]
        AudioSessionStateExpired = 0x2,
        [NativeName("Name", "AudioSessionStateInactive")]
        Inactive = 0x0,
        [NativeName("Name", "AudioSessionStateActive")]
        Active = 0x1,
        [NativeName("Name", "AudioSessionStateExpired")]
        Expired = 0x2,
    }
}
