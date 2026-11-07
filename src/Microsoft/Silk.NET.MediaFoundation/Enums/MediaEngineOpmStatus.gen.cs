// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_MEDIA_ENGINE_OPM_STATUS")]
    public enum MediaEngineOpmStatus : int
    {
        [NativeName("Name", "MF_MEDIA_ENGINE_OPM_NOT_REQUESTED")]
        NotRequested = 0x0,
        [NativeName("Name", "MF_MEDIA_ENGINE_OPM_ESTABLISHED")]
        Established = 0x1,
        [NativeName("Name", "MF_MEDIA_ENGINE_OPM_FAILED_VM")]
        FailedVM = 0x2,
        [NativeName("Name", "MF_MEDIA_ENGINE_OPM_FAILED_BDA")]
        FailedBda = 0x3,
        [NativeName("Name", "MF_MEDIA_ENGINE_OPM_FAILED_UNSIGNED_DRIVER")]
        FailedUnsignedDriver = 0x4,
        [NativeName("Name", "MF_MEDIA_ENGINE_OPM_FAILED")]
        Failed = 0x5,
    }
}
