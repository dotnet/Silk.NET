// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "aiLight")]
    public unsafe partial struct Light
    {
        public Light
        (
            AssimpString? mName = null,
            LightSourceType? mType = null,
            System.Numerics.Vector3? mPosition = null,
            System.Numerics.Vector3? mDirection = null,
            System.Numerics.Vector3? mUp = null,
            float? mAttenuationConstant = null,
            float? mAttenuationLinear = null,
            float? mAttenuationQuadratic = null,
            System.Numerics.Vector3? mColorDiffuse = null,
            System.Numerics.Vector3? mColorSpecular = null,
            System.Numerics.Vector3? mColorAmbient = null,
            float? mAngleInnerCone = null,
            float? mAngleOuterCone = null,
            System.Numerics.Vector2? mSize = null
        ) : this()
        {
            if (mName is not null)
            {
                MName = mName.Value;
            }

            if (mType is not null)
            {
                MType = mType.Value;
            }

            if (mPosition is not null)
            {
                MPosition = mPosition.Value;
            }

            if (mDirection is not null)
            {
                MDirection = mDirection.Value;
            }

            if (mUp is not null)
            {
                MUp = mUp.Value;
            }

            if (mAttenuationConstant is not null)
            {
                MAttenuationConstant = mAttenuationConstant.Value;
            }

            if (mAttenuationLinear is not null)
            {
                MAttenuationLinear = mAttenuationLinear.Value;
            }

            if (mAttenuationQuadratic is not null)
            {
                MAttenuationQuadratic = mAttenuationQuadratic.Value;
            }

            if (mColorDiffuse is not null)
            {
                MColorDiffuse = mColorDiffuse.Value;
            }

            if (mColorSpecular is not null)
            {
                MColorSpecular = mColorSpecular.Value;
            }

            if (mColorAmbient is not null)
            {
                MColorAmbient = mColorAmbient.Value;
            }

            if (mAngleInnerCone is not null)
            {
                MAngleInnerCone = mAngleInnerCone.Value;
            }

            if (mAngleOuterCone is not null)
            {
                MAngleOuterCone = mAngleOuterCone.Value;
            }

            if (mSize is not null)
            {
                MSize = mSize.Value;
            }
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
