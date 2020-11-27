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
    [NativeName("Name", "aiMeshAnim")]
    public unsafe partial struct MeshAnim
    {
        public MeshAnim
        (
            AssimpString? mName = null,
            uint? mNumKeys = null,
            MeshKey* mKeys = null
        ) : this()
        {
            if (mName is not null)
            {
                MName = mName.Value;
            }

            if (mNumKeys is not null)
            {
                MNumKeys = mNumKeys.Value;
            }

            if (mKeys is not null)
            {
                MKeys = mKeys;
            }
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
