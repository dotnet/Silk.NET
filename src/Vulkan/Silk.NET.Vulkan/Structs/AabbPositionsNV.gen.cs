// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAabbPositionsNV")]
    public unsafe partial struct AabbPositionsNV
    {
        public AabbPositionsNV
        (
            float? minX = null,
            float? minY = null,
            float? minZ = null,
            float? maxX = null,
            float? maxY = null,
            float? maxZ = null
        ) : this()
        {
            if (minX is not null)
            {
                MinX = minX.Value;
            }

            if (minY is not null)
            {
                MinY = minY.Value;
            }

            if (minZ is not null)
            {
                MinZ = minZ.Value;
            }

            if (maxX is not null)
            {
                MaxX = maxX.Value;
            }

            if (maxY is not null)
            {
                MaxY = maxY.Value;
            }

            if (maxZ is not null)
            {
                MaxZ = maxZ.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "minX")]
        public float MinX;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "minY")]
        public float MinY;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "minZ")]
        public float MinZ;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxX")]
        public float MaxX;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxY")]
        public float MaxY;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxZ")]
        public float MaxZ;
    }
}
