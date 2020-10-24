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
    [NativeName("Name", "aiNode")]
    public unsafe partial struct Node
    {
        public Node
        (
            AssimpString? mName = null,
            System.Numerics.Matrix4x4? mTransformation = null,
            Node* mParent = null,
            uint? mNumChildren = null,
            Node** mChildren = null,
            uint? mNumMeshes = null,
            uint* mMeshes = null,
            Metadata* mMetaData = null
        ) : this()
        {
            if (mName is not null)
            {
                MName = mName.Value;
            }

            if (mTransformation is not null)
            {
                MTransformation = mTransformation.Value;
            }

            if (mParent is not null)
            {
                MParent = mParent;
            }

            if (mNumChildren is not null)
            {
                MNumChildren = mNumChildren.Value;
            }

            if (mChildren is not null)
            {
                MChildren = mChildren;
            }

            if (mNumMeshes is not null)
            {
                MNumMeshes = mNumMeshes.Value;
            }

            if (mMeshes is not null)
            {
                MMeshes = mMeshes;
            }

            if (mMetaData is not null)
            {
                MMetaData = mMetaData;
            }
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
