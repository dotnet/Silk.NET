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
    [NativeName("Name", "aiMesh")]
    public unsafe partial struct Mesh
    {
        public Mesh
        (
            uint? mPrimitiveTypes = null,
            uint? mNumVertices = null,
            uint? mNumFaces = null,
            System.Numerics.Vector3* mVertices = null,
            System.Numerics.Vector3* mNormals = null,
            System.Numerics.Vector3* mTangents = null,
            System.Numerics.Vector3* mBitangents = null,
            Face* mFaces = null,
            uint? mNumBones = null,
            Bone** mBones = null,
            uint? mMaterialIndex = null,
            AssimpString? mName = null,
            uint? mNumAnimMeshes = null,
            AnimMesh** mAnimMeshes = null,
            MorphingMethod? mMethod = null,
            Silk.NET.Maths.Box3D<float>? mAABB = null,
            AssimpString** mTextureCoordsNames = null
        ) : this()
        {
            if (mPrimitiveTypes is not null)
            {
                MPrimitiveTypes = mPrimitiveTypes.Value;
            }

            if (mNumVertices is not null)
            {
                MNumVertices = mNumVertices.Value;
            }

            if (mNumFaces is not null)
            {
                MNumFaces = mNumFaces.Value;
            }

            if (mVertices is not null)
            {
                MVertices = mVertices;
            }

            if (mNormals is not null)
            {
                MNormals = mNormals;
            }

            if (mTangents is not null)
            {
                MTangents = mTangents;
            }

            if (mBitangents is not null)
            {
                MBitangents = mBitangents;
            }

            if (mFaces is not null)
            {
                MFaces = mFaces;
            }

            if (mNumBones is not null)
            {
                MNumBones = mNumBones.Value;
            }

            if (mBones is not null)
            {
                MBones = mBones;
            }

            if (mMaterialIndex is not null)
            {
                MMaterialIndex = mMaterialIndex.Value;
            }

            if (mName is not null)
            {
                MName = mName.Value;
            }

            if (mNumAnimMeshes is not null)
            {
                MNumAnimMeshes = mNumAnimMeshes.Value;
            }

            if (mAnimMeshes is not null)
            {
                MAnimMeshes = mAnimMeshes;
            }

            if (mMethod is not null)
            {
                MMethod = mMethod.Value;
            }

            if (mAABB is not null)
            {
                MAABB = mAABB.Value;
            }

            if (mTextureCoordsNames is not null)
            {
                MTextureCoordsNames = mTextureCoordsNames;
            }
        }


        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mPrimitiveTypes")]
        public uint MPrimitiveTypes;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumVertices")]
        public uint MNumVertices;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumFaces")]
        public uint MNumFaces;

        [NativeName("Type", "aiVector3D *")]
        [NativeName("Type.Name", "aiVector3D *")]
        [NativeName("Name", "mVertices")]
        public System.Numerics.Vector3* MVertices;

        [NativeName("Type", "aiVector3D *")]
        [NativeName("Type.Name", "aiVector3D *")]
        [NativeName("Name", "mNormals")]
        public System.Numerics.Vector3* MNormals;

        [NativeName("Type", "aiVector3D *")]
        [NativeName("Type.Name", "aiVector3D *")]
        [NativeName("Name", "mTangents")]
        public System.Numerics.Vector3* MTangents;

        [NativeName("Type", "aiVector3D *")]
        [NativeName("Type.Name", "aiVector3D *")]
        [NativeName("Name", "mBitangents")]
        public System.Numerics.Vector3* MBitangents;
        
        [NativeName("Type", "aiColor4D *[8]")]
        [NativeName("Type.Name", "aiColor4D *[8]")]
        [NativeName("Name", "mColors")]
        public MColorsBuffer MColors;

        public struct MColorsBuffer
        {
            public System.Numerics.Vector4* Element0;
            public System.Numerics.Vector4* Element1;
            public System.Numerics.Vector4* Element2;
            public System.Numerics.Vector4* Element3;
            public System.Numerics.Vector4* Element4;
            public System.Numerics.Vector4* Element5;
            public System.Numerics.Vector4* Element6;
            public System.Numerics.Vector4* Element7;
            public ref System.Numerics.Vector4* this[int index]
            {
                get
                {
                    if (index > 7 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (System.Numerics.Vector4** ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }
        }

        
        [NativeName("Type", "aiVector3D *[8]")]
        [NativeName("Type.Name", "aiVector3D *[8]")]
        [NativeName("Name", "mTextureCoords")]
        public MTextureCoordsBuffer MTextureCoords;

        public struct MTextureCoordsBuffer
        {
            public System.Numerics.Vector3* Element0;
            public System.Numerics.Vector3* Element1;
            public System.Numerics.Vector3* Element2;
            public System.Numerics.Vector3* Element3;
            public System.Numerics.Vector3* Element4;
            public System.Numerics.Vector3* Element5;
            public System.Numerics.Vector3* Element6;
            public System.Numerics.Vector3* Element7;
            public ref System.Numerics.Vector3* this[int index]
            {
                get
                {
                    if (index > 7 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (System.Numerics.Vector3** ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }
        }

        [NativeName("Type", "unsigned int[8]")]
        [NativeName("Type.Name", "unsigned int[8]")]
        [NativeName("Name", "mNumUVComponents")]
        public fixed uint MNumUVComponents[8];

        [NativeName("Type", "aiFace *")]
        [NativeName("Type.Name", "aiFace *")]
        [NativeName("Name", "mFaces")]
        public Face* MFaces;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumBones")]
        public uint MNumBones;

        [NativeName("Type", "aiBone **")]
        [NativeName("Type.Name", "aiBone **")]
        [NativeName("Name", "mBones")]
        public Bone** MBones;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mMaterialIndex")]
        public uint MMaterialIndex;

        [NativeName("Type", "aiString")]
        [NativeName("Type.Name", "aiString")]
        [NativeName("Name", "mName")]
        public AssimpString MName;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumAnimMeshes")]
        public uint MNumAnimMeshes;

        [NativeName("Type", "aiAnimMesh **")]
        [NativeName("Type.Name", "aiAnimMesh **")]
        [NativeName("Name", "mAnimMeshes")]
        public AnimMesh** MAnimMeshes;

        [NativeName("Type", "enum aiMorphingMethod")]
        [NativeName("Type.Name", "enum aiMorphingMethod")]
        [NativeName("Name", "mMethod")]
        public MorphingMethod MMethod;

        [NativeName("Type", "aiAABB")]
        [NativeName("Type.Name", "aiAABB")]
        [NativeName("Name", "mAABB")]
        public Silk.NET.Maths.Box3D<float> MAABB;

        [NativeName("Type", "aiString **")]
        [NativeName("Type.Name", "aiString **")]
        [NativeName("Name", "mTextureCoordsNames")]
        public AssimpString** MTextureCoordsNames;
    }
}
