// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [Flags]
    [NativeName("Name", "MF_MEDIA_ENGINE_PROTECTION_FLAGS")]
    public enum MediaEngineProtectionFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "MF_MEDIA_ENGINE_ENABLE_PROTECTED_CONTENT")]
        EnableProtectedContent = 0x1,
        [NativeName("Name", "MF_MEDIA_ENGINE_USE_PMP_FOR_ALL_CONTENT")]
        UsePmpForAllContent = 0x2,
        [NativeName("Name", "MF_MEDIA_ENGINE_USE_UNPROTECTED_PMP")]
        UseUnprotectedPmp = 0x4,
    }
}
