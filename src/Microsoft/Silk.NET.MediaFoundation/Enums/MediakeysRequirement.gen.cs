// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_MEDIAKEYS_REQUIREMENT")]
    public enum MediaKeysRequirement : int
    {
        [NativeName("Name", "MF_MEDIAKEYS_REQUIREMENT_REQUIRED")]
        Required = 0x1,
        [NativeName("Name", "MF_MEDIAKEYS_REQUIREMENT_OPTIONAL")]
        Optional = 0x2,
        [NativeName("Name", "MF_MEDIAKEYS_REQUIREMENT_NOT_ALLOWED")]
        NotAllowed = 0x3,
    }
}
