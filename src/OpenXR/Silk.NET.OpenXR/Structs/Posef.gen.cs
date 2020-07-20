// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPosef")]
    public unsafe partial struct Posef
    {
        public Posef
        (
            Quaternionf orientation = default,
            Vector3f position = default
        )
        {
            Orientation = orientation;
            Position = position;
        }

/// <summary></summary>
        [NativeName("Type", "XrQuaternionf")]
        [NativeName("Type.Name", "XrQuaternionf")]
        [NativeName("Name", "orientation")]
        public Quaternionf Orientation;
/// <summary></summary>
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "position")]
        public Vector3f Position;
    }
}
