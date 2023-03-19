// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiAnimBehaviour")]
    public enum AnimBehaviour : int
    {
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "aiAnimBehaviour_DEFAULT")]
        AnimBehaviourDefault = 0x0,
        [Obsolete("Deprecated in favour of \"Constant\"")]
        [NativeName("Name", "aiAnimBehaviour_CONSTANT")]
        AnimBehaviourConstant = 0x1,
        [Obsolete("Deprecated in favour of \"Linear\"")]
        [NativeName("Name", "aiAnimBehaviour_LINEAR")]
        AnimBehaviourLinear = 0x2,
        [Obsolete("Deprecated in favour of \"Repeat\"")]
        [NativeName("Name", "aiAnimBehaviour_REPEAT")]
        AnimBehaviourRepeat = 0x3,
        [NativeName("Name", "aiAnimBehaviour_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "aiAnimBehaviour_CONSTANT")]
        Constant = 0x1,
        [NativeName("Name", "aiAnimBehaviour_LINEAR")]
        Linear = 0x2,
        [NativeName("Name", "aiAnimBehaviour_REPEAT")]
        Repeat = 0x3,
    }
}
