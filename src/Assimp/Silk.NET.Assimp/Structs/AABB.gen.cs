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

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiAABB")]
    public unsafe struct AABB
    {
        public AABB
        (
            System.Numerics.Vector3 mMin = default,
            System.Numerics.Vector3 mMax = default
        )
        {
           MMin = mMin;
           MMax = mMax;
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
