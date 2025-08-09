// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_MEDIA_ENGINE_READY")]
    public enum MediaEngineReady : int
    {
        [NativeName("Name", "MF_MEDIA_ENGINE_READY_HAVE_NOTHING")]
        Nothing = 0x0,
        [NativeName("Name", "MF_MEDIA_ENGINE_READY_HAVE_METADATA")]
        Metadata = 0x1,
        [NativeName("Name", "MF_MEDIA_ENGINE_READY_HAVE_CURRENT_DATA")]
        CurrentData = 0x2,
        [NativeName("Name", "MF_MEDIA_ENGINE_READY_HAVE_FUTURE_DATA")]
        FutureData = 0x3,
        [NativeName("Name", "MF_MEDIA_ENGINE_READY_HAVE_ENOUGH_DATA")]
        EnoughData = 0x4,
    }
}
