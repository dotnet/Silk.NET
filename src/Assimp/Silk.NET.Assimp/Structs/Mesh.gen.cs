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
    [NativeName("Name", "aiMesh")]
    public unsafe struct Mesh
    {
        public Mesh
        (
            uint mPrimitiveTypes = default,
            uint mNumVertices = default,
            uint mNumFaces = default,
            System.Numerics.Vector3* mVertices = default,
            System.Numerics.Vector3* mNormals = default,
            System.Numerics.Vector3* mTangents = default,
            System.Numerics.Vector3* mBitangents = default,
            Face* mFaces = default,
            uint mNumBones = default,
            Bone** mBones = default,
            uint mMaterialIndex = default,
            AssimpString mName = default,
            uint mNumAnimMeshes = default,
            AnimMesh** mAnimMeshes = default,
            uint mMethod = default,
            AABB mAABB = default
        )
        {
           MPrimitiveTypes = mPrimitiveTypes;
           MNumVertices = mNumVertices;
           MNumFaces = mNumFaces;
           MVertices = mVertices;
           MNormals = mNormals;
           MTangents = mTangents;
           MBitangents = mBitangents;
           MColors_0 = default;
           MColors_1 = default;
           MColors_2 = default;
           MColors_3 = default;
           MColors_4 = default;
           MColors_5 = default;
           MColors_6 = default;
           MColors_7 = default;
           MTextureCoords_0 = default;
           MTextureCoords_1 = default;
           MTextureCoords_2 = default;
           MTextureCoords_3 = default;
           MTextureCoords_4 = default;
           MTextureCoords_5 = default;
           MTextureCoords_6 = default;
           MTextureCoords_7 = default;
           MFaces = mFaces;
           MNumBones = mNumBones;
           MBones = mBones;
           MMaterialIndex = mMaterialIndex;
           MName = mName;
           MNumAnimMeshes = mNumAnimMeshes;
           MAnimMeshes = mAnimMeshes;
           MMethod = mMethod;
           MAABB = mAABB;
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
        public System.Numerics.Vector4* MColors_0;
        
        [NativeName("Type", "aiColor4D *[8]")]
        [NativeName("Type.Name", "aiColor4D *[8]")]
        [NativeName("Name", "mColors")]
        public System.Numerics.Vector4* MColors_1;
        
        [NativeName("Type", "aiColor4D *[8]")]
        [NativeName("Type.Name", "aiColor4D *[8]")]
        [NativeName("Name", "mColors")]
        public System.Numerics.Vector4* MColors_2;
        
        [NativeName("Type", "aiColor4D *[8]")]
        [NativeName("Type.Name", "aiColor4D *[8]")]
        [NativeName("Name", "mColors")]
        public System.Numerics.Vector4* MColors_3;
        
        [NativeName("Type", "aiColor4D *[8]")]
        [NativeName("Type.Name", "aiColor4D *[8]")]
        [NativeName("Name", "mColors")]
        public System.Numerics.Vector4* MColors_4;
        
        [NativeName("Type", "aiColor4D *[8]")]
        [NativeName("Type.Name", "aiColor4D *[8]")]
        [NativeName("Name", "mColors")]
        public System.Numerics.Vector4* MColors_5;
        
        [NativeName("Type", "aiColor4D *[8]")]
        [NativeName("Type.Name", "aiColor4D *[8]")]
        [NativeName("Name", "mColors")]
        public System.Numerics.Vector4* MColors_6;
        
        [NativeName("Type", "aiColor4D *[8]")]
        [NativeName("Type.Name", "aiColor4D *[8]")]
        [NativeName("Name", "mColors")]
        public System.Numerics.Vector4* MColors_7;
        
        [NativeName("Type", "aiVector3D *[8]")]
        [NativeName("Type.Name", "aiVector3D *[8]")]
        [NativeName("Name", "mTextureCoords")]
        public System.Numerics.Vector3* MTextureCoords_0;
        
        [NativeName("Type", "aiVector3D *[8]")]
        [NativeName("Type.Name", "aiVector3D *[8]")]
        [NativeName("Name", "mTextureCoords")]
        public System.Numerics.Vector3* MTextureCoords_1;
        
        [NativeName("Type", "aiVector3D *[8]")]
        [NativeName("Type.Name", "aiVector3D *[8]")]
        [NativeName("Name", "mTextureCoords")]
        public System.Numerics.Vector3* MTextureCoords_2;
        
        [NativeName("Type", "aiVector3D *[8]")]
        [NativeName("Type.Name", "aiVector3D *[8]")]
        [NativeName("Name", "mTextureCoords")]
        public System.Numerics.Vector3* MTextureCoords_3;
        
        [NativeName("Type", "aiVector3D *[8]")]
        [NativeName("Type.Name", "aiVector3D *[8]")]
        [NativeName("Name", "mTextureCoords")]
        public System.Numerics.Vector3* MTextureCoords_4;
        
        [NativeName("Type", "aiVector3D *[8]")]
        [NativeName("Type.Name", "aiVector3D *[8]")]
        [NativeName("Name", "mTextureCoords")]
        public System.Numerics.Vector3* MTextureCoords_5;
        
        [NativeName("Type", "aiVector3D *[8]")]
        [NativeName("Type.Name", "aiVector3D *[8]")]
        [NativeName("Name", "mTextureCoords")]
        public System.Numerics.Vector3* MTextureCoords_6;
        
        [NativeName("Type", "aiVector3D *[8]")]
        [NativeName("Type.Name", "aiVector3D *[8]")]
        [NativeName("Name", "mTextureCoords")]
        public System.Numerics.Vector3* MTextureCoords_7;
        [NativeName("Type", "unsigned int [8]")]
        [NativeName("Type.Name", "unsigned int [8]")]
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

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mMethod")]
        public uint MMethod;

        [NativeName("Type", "aiAABB")]
        [NativeName("Type.Name", "aiAABB")]
        [NativeName("Name", "mAABB")]
        public AABB MAABB;
    }
}
