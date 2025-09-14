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
    [NativeName("Name", "XrSpatialBounded2DDataEXT")]
    public unsafe partial struct SpatialBounded2DDataEXT
    {
        public SpatialBounded2DDataEXT
        (
            Posef? center = null,
            Extent2Df? extents = null
        ) : this()
        {
            if (center is not null)
            {
                Center = center.Value;
            }

            if (extents is not null)
            {
                Extents = extents.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "center")]
        public Posef Center;
/// <summary></summary>
        [NativeName("Type", "XrExtent2Df")]
        [NativeName("Type.Name", "XrExtent2Df")]
        [NativeName("Name", "extents")]
        public Extent2Df Extents;
    }
}
