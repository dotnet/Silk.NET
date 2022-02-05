// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrPassthroughFlagsFB")]
    public enum PassthroughFlagsFB : long
    {
        [NativeName("Name", "XR_PASSTHROUGH_IS_RUNNING_AT_CREATION_BIT_FB")]
        PassthroughIsRunningATCreationBitFB = 1,
    }
}
