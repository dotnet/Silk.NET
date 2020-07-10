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
    [NativeName("Name", "aiMeshAnim")]
    public unsafe partial struct MeshAnim
    {
        public MeshAnim
        (
            AssimpString mName = default,
            uint mNumKeys = default,
            MeshKey* mKeys = default
        )
        {
            MName = mName;
            MNumKeys = mNumKeys;
            MKeys = mKeys;
        }


        [NativeName("Type", "aiString")]
        [NativeName("Type.Name", "aiString")]
        [NativeName("Name", "mName")]
        public AssimpString MName;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumKeys")]
        public uint MNumKeys;

        [NativeName("Type", "aiMeshKey *")]
        [NativeName("Type.Name", "aiMeshKey *")]
        [NativeName("Name", "mKeys")]
        public MeshKey* MKeys;
    }
}
