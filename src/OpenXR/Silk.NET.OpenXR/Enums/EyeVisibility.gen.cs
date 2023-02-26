// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrEyeVisibility")]
    public enum EyeVisibility : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "XR_EYE_VISIBILITY_BOTH")]
        Both = 0,
        [NativeName("Name", "XR_EYE_VISIBILITY_LEFT")]
        Left = 1,
        [NativeName("Name", "XR_EYE_VISIBILITY_RIGHT")]
        Right = 2,
    }
}
