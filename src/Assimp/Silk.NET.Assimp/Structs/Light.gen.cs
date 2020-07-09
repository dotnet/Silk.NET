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
    [NativeName("Name", "aiLight")]
    public unsafe struct Light
    {
        public Light
        (
            AssimpString mName = default,
            LightSourceType mType = default,
            System.Numerics.Vector3 mPosition = default,
            System.Numerics.Vector3 mDirection = default,
            System.Numerics.Vector3 mUp = default,
            float mAttenuationConstant = default,
            float mAttenuationLinear = default,
            float mAttenuationQuadratic = default,
            System.Numerics.Vector3 mColorDiffuse = default,
            System.Numerics.Vector3 mColorSpecular = default,
            System.Numerics.Vector3 mColorAmbient = default,
            float mAngleInnerCone = default,
            float mAngleOuterCone = default,
            System.Numerics.Vector2 mSize = default
        )
        {
           MName = mName;
           MType = mType;
           MPosition = mPosition;
           MDirection = mDirection;
           MUp = mUp;
           MAttenuationConstant = mAttenuationConstant;
           MAttenuationLinear = mAttenuationLinear;
           MAttenuationQuadratic = mAttenuationQuadratic;
           MColorDiffuse = mColorDiffuse;
           MColorSpecular = mColorSpecular;
           MColorAmbient = mColorAmbient;
           MAngleInnerCone = mAngleInnerCone;
           MAngleOuterCone = mAngleOuterCone;
           MSize = mSize;
        }


        [NativeName("Type", "aiString")]
        [NativeName("Type.Name", "aiString")]
        [NativeName("Name", "mName")]
        public AssimpString MName;

        [NativeName("Type", "aiLightSourceType")]
        [NativeName("Type.Name", "aiLightSourceType")]
        [NativeName("Name", "mType")]
        public LightSourceType MType;

        [NativeName("Type", "aiVector3D")]
        [NativeName("Type.Name", "aiVector3D")]
        [NativeName("Name", "mPosition")]
        public System.Numerics.Vector3 MPosition;

        [NativeName("Type", "aiVector3D")]
        [NativeName("Type.Name", "aiVector3D")]
        [NativeName("Name", "mDirection")]
        public System.Numerics.Vector3 MDirection;

        [NativeName("Type", "aiVector3D")]
        [NativeName("Type.Name", "aiVector3D")]
        [NativeName("Name", "mUp")]
        public System.Numerics.Vector3 MUp;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "mAttenuationConstant")]
        public float MAttenuationConstant;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "mAttenuationLinear")]
        public float MAttenuationLinear;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "mAttenuationQuadratic")]
        public float MAttenuationQuadratic;

        [NativeName("Type", "aiColor3D")]
        [NativeName("Type.Name", "aiColor3D")]
        [NativeName("Name", "mColorDiffuse")]
        public System.Numerics.Vector3 MColorDiffuse;

        [NativeName("Type", "aiColor3D")]
        [NativeName("Type.Name", "aiColor3D")]
        [NativeName("Name", "mColorSpecular")]
        public System.Numerics.Vector3 MColorSpecular;

        [NativeName("Type", "aiColor3D")]
        [NativeName("Type.Name", "aiColor3D")]
        [NativeName("Name", "mColorAmbient")]
        public System.Numerics.Vector3 MColorAmbient;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "mAngleInnerCone")]
        public float MAngleInnerCone;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "mAngleOuterCone")]
        public float MAngleOuterCone;

        [NativeName("Type", "aiVector2D")]
        [NativeName("Type.Name", "aiVector2D")]
        [NativeName("Name", "mSize")]
        public System.Numerics.Vector2 MSize;
    }
}
