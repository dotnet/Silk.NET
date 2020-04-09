// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct AabbPositionsKHR
    {
        public AabbPositionsKHR
        (
            float minX = default,
            float minY = default,
            float minZ = default,
            float maxX = default,
            float maxY = default,
            float maxZ = default
        )
        {
           MinX = minX;
           MinY = minY;
           MinZ = minZ;
           MaxX = maxX;
           MaxY = maxY;
           MaxZ = maxZ;
        }

/// <summary></summary>
        public float MinX;
/// <summary></summary>
        public float MinY;
/// <summary></summary>
        public float MinZ;
/// <summary></summary>
        public float MaxX;
/// <summary></summary>
        public float MaxY;
/// <summary></summary>
        public float MaxZ;
    }
}
