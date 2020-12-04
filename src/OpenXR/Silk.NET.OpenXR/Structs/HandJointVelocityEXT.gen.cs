// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHandJointVelocityEXT")]
    public unsafe partial struct HandJointVelocityEXT
    {
        public HandJointVelocityEXT
        (
            SpaceVelocityFlags? velocityFlags = null,
            Vector3f? linearVelocity = null,
            Vector3f? angularVelocity = null
        ) : this()
        {
            if (velocityFlags is not null)
            {
                VelocityFlags = velocityFlags.Value;
            }

            if (linearVelocity is not null)
            {
                LinearVelocity = linearVelocity.Value;
            }

            if (angularVelocity is not null)
            {
                AngularVelocity = angularVelocity.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrSpaceVelocityFlags")]
        [NativeName("Type.Name", "XrSpaceVelocityFlags")]
        [NativeName("Name", "velocityFlags")]
        public SpaceVelocityFlags VelocityFlags;
/// <summary></summary>
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "linearVelocity")]
        public Vector3f LinearVelocity;
/// <summary></summary>
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "angularVelocity")]
        public Vector3f AngularVelocity;
    }
}
