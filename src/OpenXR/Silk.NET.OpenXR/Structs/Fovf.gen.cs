// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
    [NativeName("Name", "XrFovf")]
    public unsafe partial struct Fovf
    {
        public Fovf
        (
            float? angleLeft = null,
            float? angleRight = null,
            float? angleUp = null,
            float? angleDown = null
        ) : this()
        {
            if (angleLeft is not null)
            {
                AngleLeft = angleLeft.Value;
            }

            if (angleRight is not null)
            {
                AngleRight = angleRight.Value;
            }

            if (angleUp is not null)
            {
                AngleUp = angleUp.Value;
            }

            if (angleDown is not null)
            {
                AngleDown = angleDown.Value;
            }
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
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
