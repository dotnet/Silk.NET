// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_MEDIA_ENGINE_PRELOAD")]
    public enum MediaEnginePreload : int
    {
        [NativeName("Name", "MF_MEDIA_ENGINE_PRELOAD_MISSING")]
        Missing = 0x0,
        [NativeName("Name", "MF_MEDIA_ENGINE_PRELOAD_EMPTY")]
        Empty = 0x1,
        [NativeName("Name", "MF_MEDIA_ENGINE_PRELOAD_NONE")]
        None = 0x2,
        [NativeName("Name", "MF_MEDIA_ENGINE_PRELOAD_METADATA")]
        Metadata = 0x3,
        [NativeName("Name", "MF_MEDIA_ENGINE_PRELOAD_AUTOMATIC")]
        Automatic = 0x4,
    }
}
