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

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiAABB")]
    public unsafe partial struct Aabb
    {
        public Aabb
        (
            System.Numerics.Vector3? mMin = null,
            System.Numerics.Vector3? mMax = null
        ) : this()
        {
            if (mMin is not null)
            {
                MMin = mMin.Value;
            }

            if (mMax is not null)
            {
                MMax = mMax.Value;
            }
        }


        [NativeName("Type", "aiVector3D")]
        [NativeName("Type.Name", "aiVector3D")]
        [NativeName("Name", "mMin")]
        public System.Numerics.Vector3 MMin;

        [NativeName("Type", "aiVector3D")]
        [NativeName("Type.Name", "aiVector3D")]
        [NativeName("Name", "mMax")]
        public System.Numerics.Vector3 MMax;
    }
}
