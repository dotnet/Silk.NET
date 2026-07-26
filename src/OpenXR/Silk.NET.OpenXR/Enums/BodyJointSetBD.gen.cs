// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrBodyJointSetBD")]
    public enum BodyJointSetBD : int
    {
        [Obsolete("Deprecated in favour of \"BodyWithoutArmBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_SET_BODY_WITHOUT_ARM_BD")]
        BodyJointSetBodyWithoutArmBD = 1,
        [Obsolete("Deprecated in favour of \"FullBodyJointsBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_SET_FULL_BODY_JOINTS_BD")]
        BodyJointSetFullBodyJointsBD = 2,
        [NativeName("Name", "XR_BODY_JOINT_SET_BODY_WITHOUT_ARM_BD")]
        BodyWithoutArmBD = 1,
        [NativeName("Name", "XR_BODY_JOINT_SET_FULL_BODY_JOINTS_BD")]
        FullBodyJointsBD = 2,
    }
}
