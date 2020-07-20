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
    [NativeName("Name", "aiCamera")]
    public unsafe partial struct Camera
    {
        public Camera
        (
            AssimpString mName = default,
            System.Numerics.Vector3 mPosition = default,
            System.Numerics.Vector3 mUp = default,
            System.Numerics.Vector3 mLookAt = default,
            float mHorizontalFOV = default,
            float mClipPlaneNear = default,
            float mClipPlaneFar = default,
            float mAspect = default
        )
        {
            MName = mName;
            MPosition = mPosition;
            MUp = mUp;
            MLookAt = mLookAt;
            MHorizontalFOV = mHorizontalFOV;
            MClipPlaneNear = mClipPlaneNear;
            MClipPlaneFar = mClipPlaneFar;
            MAspect = mAspect;
        }


        [NativeName("Type", "aiString")]
        [NativeName("Type.Name", "aiString")]
        [NativeName("Name", "mName")]
        public AssimpString MName;

        [NativeName("Type", "aiVector3D")]
        [NativeName("Type.Name", "aiVector3D")]
        [NativeName("Name", "mPosition")]
        public System.Numerics.Vector3 MPosition;

        [NativeName("Type", "aiVector3D")]
        [NativeName("Type.Name", "aiVector3D")]
        [NativeName("Name", "mUp")]
        public System.Numerics.Vector3 MUp;

        [NativeName("Type", "aiVector3D")]
        [NativeName("Type.Name", "aiVector3D")]
        [NativeName("Name", "mLookAt")]
        public System.Numerics.Vector3 MLookAt;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "mHorizontalFOV")]
        public float MHorizontalFOV;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "mClipPlaneNear")]
        public float MClipPlaneNear;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "mClipPlaneFar")]
        public float MClipPlaneFar;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "mAspect")]
        public float MAspect;
    }
}
