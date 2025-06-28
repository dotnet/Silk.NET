// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_MEDIA_ENGINE_NETWORK")]
    public enum MediaEngineNetwork : int
    {
        [NativeName("Name", "MF_MEDIA_ENGINE_NETWORK_EMPTY")]
        Empty = 0x0,
        [NativeName("Name", "MF_MEDIA_ENGINE_NETWORK_IDLE")]
        Idle = 0x1,
        [NativeName("Name", "MF_MEDIA_ENGINE_NETWORK_LOADING")]
        Loading = 0x2,
        [NativeName("Name", "MF_MEDIA_ENGINE_NETWORK_NO_SOURCE")]
        NoSource = 0x3,
    }
}
