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
    [NativeName("Name", "aiBone")]
    public unsafe partial struct Bone
    {
        public Bone
        (
            AssimpString mName = default,
            uint mNumWeights = default,
            VertexWeight* mWeights = default,
            System.Numerics.Matrix4x4 mOffsetMatrix = default
        )
        {
            MName = mName;
            MNumWeights = mNumWeights;
            MWeights = mWeights;
            MOffsetMatrix = mOffsetMatrix;
        }


        [NativeName("Type", "aiString")]
        [NativeName("Type.Name", "aiString")]
        [NativeName("Name", "mName")]
        public AssimpString MName;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumWeights")]
        public uint MNumWeights;

        [NativeName("Type", "aiVertexWeight *")]
        [NativeName("Type.Name", "aiVertexWeight *")]
        [NativeName("Name", "mWeights")]
        public VertexWeight* MWeights;

        [NativeName("Type", "aiMatrix4x4")]
        [NativeName("Type.Name", "aiMatrix4x4")]
        [NativeName("Name", "mOffsetMatrix")]
        public System.Numerics.Matrix4x4 MOffsetMatrix;
    }
}
