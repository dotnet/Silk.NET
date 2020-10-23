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
    [NativeName("Name", "aiAnimMesh")]
    public unsafe partial struct AnimMesh
    {
        public AnimMesh
        (
            AssimpString? mName = null,
            System.Numerics.Vector3* mVertices = null,
            System.Numerics.Vector3* mNormals = null,
            System.Numerics.Vector3* mTangents = null,
            System.Numerics.Vector3* mBitangents = null,
            uint? mNumVertices = null,
            float? mWeight = null
        )
        {
            fixed (AnimMesh* @this = &this)
            {
                // all fields automatically initialized here
            }

            if (mName is not null)
            {
                MName = mName.Value;
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

            if (mNumVertices is not null)
            {
                MNumVertices = mNumVertices.Value;
            }

            if (mWeight is not null)
            {
                MWeight = mWeight.Value;
            }
        }


        [NativeName("Type", "aiString")]
        [NativeName("Type.Name", "aiString")]
        [NativeName("Name", "mName")]
        public AssimpString MName;

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

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumVertices")]
        public uint MNumVertices;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "mWeight")]
        public float MWeight;
    }
}
