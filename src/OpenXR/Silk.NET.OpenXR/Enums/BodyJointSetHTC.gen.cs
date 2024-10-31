// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrBodyJointSetHTC")]
    public enum BodyJointSetHTC : int
    {
        [Obsolete("Deprecated in favour of \"FullHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_SET_FULL_HTC")]
        BodyJointSetFullHtc = 0,
        [NativeName("Name", "XR_BODY_JOINT_SET_FULL_HTC")]
        FullHtc = 0,
    }
}
