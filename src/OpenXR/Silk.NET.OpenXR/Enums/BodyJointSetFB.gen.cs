// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrBodyJointSetFB")]
    public enum BodyJointSetFB : int
    {
        [Obsolete("Deprecated in favour of \"DefaultFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_SET_DEFAULT_FB")]
        BodyJointSetDefaultFB = 0,
        [NativeName("Name", "XR_BODY_JOINT_SET_DEFAULT_FB")]
        DefaultFB = 0,
    }
}
