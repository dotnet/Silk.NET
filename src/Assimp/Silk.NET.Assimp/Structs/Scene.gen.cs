// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
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
            uint? mFlags = null,
            Node* mRootNode = null,
            uint? mNumMeshes = null,
            Mesh** mMeshes = null,
            uint? mNumMaterials = null,
            Material** mMaterials = null,
            uint? mNumAnimations = null,
            Animation** mAnimations = null,
            uint? mNumTextures = null,
            Texture** mTextures = null,
            uint? mNumLights = null,
            Light** mLights = null,
            uint? mNumCameras = null,
            Camera** mCameras = null,
            Metadata* mMetaData = null,
            AssimpString? mName = null,
            uint? mNumSkeletons = null,
            Skeleton** mSkeletons = null,
            void* mPrivate = null
        ) : this()
        {
            if (mFlags is not null)
            {
                MFlags = mFlags.Value;
            }

            if (mRootNode is not null)
            {
                MRootNode = mRootNode;
            }

            if (mNumMeshes is not null)
            {
                MNumMeshes = mNumMeshes.Value;
            }

            if (mMeshes is not null)
            {
                MMeshes = mMeshes;
            }

            if (mNumMaterials is not null)
            {
                MNumMaterials = mNumMaterials.Value;
            }

            if (mMaterials is not null)
            {
                MMaterials = mMaterials;
            }

            if (mNumAnimations is not null)
            {
                MNumAnimations = mNumAnimations.Value;
            }

            if (mAnimations is not null)
            {
                MAnimations = mAnimations;
            }

            if (mNumTextures is not null)
            {
                MNumTextures = mNumTextures.Value;
            }

            if (mTextures is not null)
            {
                MTextures = mTextures;
            }

            if (mNumLights is not null)
            {
                MNumLights = mNumLights.Value;
            }

            if (mLights is not null)
            {
                MLights = mLights;
            }

            if (mNumCameras is not null)
            {
                MNumCameras = mNumCameras.Value;
            }

            if (mCameras is not null)
            {
                MCameras = mCameras;
            }

            if (mMetaData is not null)
            {
                MMetaData = mMetaData;
            }

            if (mName is not null)
            {
                MName = mName.Value;
            }

            if (mNumSkeletons is not null)
            {
                MNumSkeletons = mNumSkeletons.Value;
            }

            if (mSkeletons is not null)
            {
                MSkeletons = mSkeletons;
            }

            if (mPrivate is not null)
            {
                MPrivate = mPrivate;
            }
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

        [NativeName("Type", "aiString")]
        [NativeName("Type.Name", "aiString")]
        [NativeName("Name", "mName")]
        public AssimpString MName;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumSkeletons")]
        public uint MNumSkeletons;

        [NativeName("Type", "aiSkeleton **")]
        [NativeName("Type.Name", "aiSkeleton **")]
        [NativeName("Name", "mSkeletons")]
        public Skeleton** MSkeletons;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "mPrivate")]
        public void* MPrivate;
    }
}
