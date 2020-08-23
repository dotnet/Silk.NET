// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiMeshMorphAnim")]
    public unsafe partial struct MeshMorphAnim
    {
        public MeshMorphAnim
        (
            AssimpString mName = default,
            uint mNumKeys = default,
            MeshMorphKey* mKeys = default
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

        [NativeName("Type", "aiMeshMorphKey *")]
        [NativeName("Type.Name", "aiMeshMorphKey *")]
        [NativeName("Name", "mKeys")]
        public MeshMorphKey* MKeys;
    }
}
