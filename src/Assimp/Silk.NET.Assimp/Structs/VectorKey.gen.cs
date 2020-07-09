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
    [NativeName("Name", "aiVectorKey")]
    public unsafe struct VectorKey
    {
        public VectorKey
        (
            double mTime = default,
            System.Numerics.Vector3 mValue = default
        )
        {
           MTime = mTime;
           MValue = mValue;
        }


        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "mTime")]
        public double MTime;

        [NativeName("Type", "aiVector3D")]
        [NativeName("Type.Name", "aiVector3D")]
        [NativeName("Name", "mValue")]
        public System.Numerics.Vector3 MValue;
    }
}
