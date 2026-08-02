// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [Flags]
    [NativeName("Name", "MF_MEDIA_ENGINE_CREATEFLAGS")]
    public enum MediaEngineCreateFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "MF_MEDIA_ENGINE_AUDIOONLY")]
        Audioonly = 0x1,
        [NativeName("Name", "MF_MEDIA_ENGINE_WAITFORSTABLE_STATE")]
        WaitforstableState = 0x2,
        [NativeName("Name", "MF_MEDIA_ENGINE_FORCEMUTE")]
        Forcemute = 0x4,
        [NativeName("Name", "MF_MEDIA_ENGINE_REAL_TIME_MODE")]
        RealTimeMode = 0x8,
        [NativeName("Name", "MF_MEDIA_ENGINE_DISABLE_LOCAL_PLUGINS")]
        DisableLocalPlugins = 0x10,
        [NativeName("Name", "MF_MEDIA_ENGINE_CREATEFLAGS_MASK")]
        CreateflagsMask = 0x1F,
    }
}
