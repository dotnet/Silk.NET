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
    [NativeName("Name", "aiRay")]
    public unsafe struct Ray
    {
        public Ray
        (
            System.Numerics.Vector3 pos = default,
            System.Numerics.Vector3 dir = default
        )
        {
           Pos = pos;
           Dir = dir;
        }


        [NativeName("Type", "aiVector3D")]
        [NativeName("Type.Name", "aiVector3D")]
        [NativeName("Name", "pos")]
        public System.Numerics.Vector3 Pos;

        [NativeName("Type", "aiVector3D")]
        [NativeName("Type.Name", "aiVector3D")]
        [NativeName("Name", "dir")]
        public System.Numerics.Vector3 Dir;
    }
}
