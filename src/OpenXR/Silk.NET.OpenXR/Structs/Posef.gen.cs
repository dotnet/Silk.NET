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
    public unsafe struct Posef
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
        public Quaternionf Orientation;
/// <summary></summary>
        public Vector3f Position;
    }
}
