// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiAnimBehaviour")]
    public enum AnimBehaviour
    {
        [NativeName("Name", "aiAnimBehaviour_DEFAULT")]
        AnimBehaviourDefault = 0x0,
        [NativeName("Name", "aiAnimBehaviour_CONSTANT")]
        AnimBehaviourConstant = 0x1,
        [NativeName("Name", "aiAnimBehaviour_LINEAR")]
        AnimBehaviourLinear = 0x2,
        [NativeName("Name", "aiAnimBehaviour_REPEAT")]
        AnimBehaviourRepeat = 0x3,
    }
}
