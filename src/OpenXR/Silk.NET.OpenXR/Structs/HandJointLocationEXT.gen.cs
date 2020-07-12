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
    public unsafe struct HandJointLocationEXT
    {
        public HandJointLocationEXT
        (
            SpaceLocationFlags locationFlags = default,
            Posef pose = default,
            float radius = default
        )
        {
           LocationFlags = locationFlags;
           Pose = pose;
           Radius = radius;
        }

/// <summary></summary>
        public SpaceLocationFlags LocationFlags;
/// <summary></summary>
        public Posef Pose;
/// <summary></summary>
        public float Radius;
    }
}
