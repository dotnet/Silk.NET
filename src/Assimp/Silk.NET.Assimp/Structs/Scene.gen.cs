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
    [NativeName("Name", "aiScene")]
    public unsafe partial struct Scene
    {
        public Scene
        (
            uint mFlags = default,
            Node* mRootNode = default,
            uint mNumMeshes = default,
            Mesh** mMeshes = default,
            uint mNumMaterials = default,
            Material** mMaterials = default,
            uint mNumAnimations = default,
            Animation** mAnimations = default,
            uint mNumTextures = default,
            Texture** mTextures = default,
            uint mNumLights = default,
            Light** mLights = default,
            uint mNumCameras = default,
            Camera** mCameras = default,
            Metadata* mMetaData = default,
            void* mPrivate = default
        )
        {
            MFlags = mFlags;
            MRootNode = mRootNode;
            MNumMeshes = mNumMeshes;
            MMeshes = mMeshes;
            MNumMaterials = mNumMaterials;
            MMaterials = mMaterials;
            MNumAnimations = mNumAnimations;
            MAnimations = mAnimations;
            MNumTextures = mNumTextures;
            MTextures = mTextures;
            MNumLights = mNumLights;
            MLights = mLights;
            MNumCameras = mNumCameras;
            MCameras = mCameras;
            MMetaData = mMetaData;
            MPrivate = mPrivate;
        }


        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mFlags")]
        public uint MFlags;

        [NativeName("Type", "aiNode *")]
        [NativeName("Type.Name", "aiNode *")]
        [NativeName("Name", "mRootNode")]
        public Node* MRootNode;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumMeshes")]
        public uint MNumMeshes;

        [NativeName("Type", "aiMesh **")]
        [NativeName("Type.Name", "aiMesh **")]
        [NativeName("Name", "mMeshes")]
        public Mesh** MMeshes;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumMaterials")]
        public uint MNumMaterials;

        [NativeName("Type", "aiMaterial **")]
        [NativeName("Type.Name", "aiMaterial **")]
        [NativeName("Name", "mMaterials")]
        public Material** MMaterials;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumAnimations")]
        public uint MNumAnimations;

        [NativeName("Type", "aiAnimation **")]
        [NativeName("Type.Name", "aiAnimation **")]
        [NativeName("Name", "mAnimations")]
        public Animation** MAnimations;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumTextures")]
        public uint MNumTextures;

        [NativeName("Type", "aiTexture **")]
        [NativeName("Type.Name", "aiTexture **")]
        [NativeName("Name", "mTextures")]
        public Texture** MTextures;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumLights")]
        public uint MNumLights;

        [NativeName("Type", "aiLight **")]
        [NativeName("Type.Name", "aiLight **")]
        [NativeName("Name", "mLights")]
        public Light** MLights;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumCameras")]
        public uint MNumCameras;

        [NativeName("Type", "aiCamera **")]
        [NativeName("Type.Name", "aiCamera **")]
        [NativeName("Name", "mCameras")]
        public Camera** MCameras;

        [NativeName("Type", "aiMetadata *")]
        [NativeName("Type.Name", "aiMetadata *")]
        [NativeName("Name", "mMetaData")]
        public Metadata* MMetaData;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "mPrivate")]
        public void* MPrivate;
    }
}
