// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_AABB")]
    public unsafe partial struct RaytracingAabb
    {
        public RaytracingAabb
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


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MinX")]
        public float MinX;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MinY")]
        public float MinY;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MinZ")]
        public float MinZ;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MaxX")]
        public float MaxX;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MaxY")]
        public float MaxY;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MaxZ")]
        public float MaxZ;
    }
}
