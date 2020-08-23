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
    [NativeName("Name", "aiNode")]
    public unsafe partial struct Node
    {
        public Node
        (
            AssimpString mName = default,
            System.Numerics.Matrix4x4 mTransformation = default,
            Node* mParent = default,
            uint mNumChildren = default,
            Node** mChildren = default,
            uint mNumMeshes = default,
            uint* mMeshes = default,
            Metadata* mMetaData = default
        )
        {
            MName = mName;
            MTransformation = mTransformation;
            MParent = mParent;
            MNumChildren = mNumChildren;
            MChildren = mChildren;
            MNumMeshes = mNumMeshes;
            MMeshes = mMeshes;
            MMetaData = mMetaData;
        }


        [NativeName("Type", "aiString")]
        [NativeName("Type.Name", "aiString")]
        [NativeName("Name", "mName")]
        public AssimpString MName;

        [NativeName("Type", "aiMatrix4x4")]
        [NativeName("Type.Name", "aiMatrix4x4")]
        [NativeName("Name", "mTransformation")]
        public System.Numerics.Matrix4x4 MTransformation;

        [NativeName("Type", "aiNode *")]
        [NativeName("Type.Name", "aiNode *")]
        [NativeName("Name", "mParent")]
        public Node* MParent;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumChildren")]
        public uint MNumChildren;

        [NativeName("Type", "aiNode **")]
        [NativeName("Type.Name", "aiNode **")]
        [NativeName("Name", "mChildren")]
        public Node** MChildren;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumMeshes")]
        public uint MNumMeshes;

        [NativeName("Type", "unsigned int *")]
        [NativeName("Type.Name", "unsigned int *")]
        [NativeName("Name", "mMeshes")]
        public uint* MMeshes;

        [NativeName("Type", "aiMetadata *")]
        [NativeName("Type.Name", "aiMetadata *")]
        [NativeName("Name", "mMetaData")]
        public Metadata* MMetaData;
    }
}
