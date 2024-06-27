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
    [NativeName("Name", "XrColor3f")]
    [NativeName("Aliases", "XrColor3fKHR")]
    public unsafe partial struct Color3f
    {
        public Color3f
        (
            float? r = null,
            float? g = null,
            float? b = null
        ) : this()
        {
            if (r is not null)
            {
                R = r.Value;
            }

            if (g is not null)
            {
                G = g.Value;
            }

            if (b is not null)
            {
                B = b.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "r")]
        public float R;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "g")]
        public float G;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "b")]
        public float B;
    }
}
