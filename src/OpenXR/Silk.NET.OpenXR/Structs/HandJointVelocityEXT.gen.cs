// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public unsafe struct HandJointVelocityEXT
    {
        public HandJointVelocityEXT
        (
            SpaceVelocityFlags velocityFlags = default,
            Vector3f linearVelocity = default,
            Vector3f angularVelocity = default
        )
        {
           VelocityFlags = velocityFlags;
           LinearVelocity = linearVelocity;
           AngularVelocity = angularVelocity;
        }

/// <summary></summary>
        public SpaceVelocityFlags VelocityFlags;
/// <summary></summary>
        public Vector3f LinearVelocity;
/// <summary></summary>
        public Vector3f AngularVelocity;
    }
}
