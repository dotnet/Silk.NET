// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFovf")]
    public unsafe partial struct Fovf
    {
        public Fovf
        (
            float angleLeft = default,
            float angleRight = default,
            float angleUp = default,
            float angleDown = default
        )
        {
            AngleLeft = angleLeft;
            AngleRight = angleRight;
            AngleUp = angleUp;
            AngleDown = angleDown;
        }

/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "angleLeft")]
        public float AngleLeft;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "angleRight")]
        public float AngleRight;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "angleUp")]
        public float AngleUp;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "angleDown")]
        public float AngleDown;
    }
}
