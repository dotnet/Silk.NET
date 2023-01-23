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
    [NativeName("Name", "aiCamera")]
    public unsafe partial struct Camera
    {
        public Camera
        (
            AssimpString? mName = null,
            System.Numerics.Vector3? mPosition = null,
            System.Numerics.Vector3? mUp = null,
            System.Numerics.Vector3? mLookAt = null,
            float? mHorizontalFOV = null,
            float? mClipPlaneNear = null,
            float? mClipPlaneFar = null,
            float? mAspect = null,
            float? mOrthographicWidth = null
        ) : this()
        {
            if (mName is not null)
            {
                MName = mName.Value;
            }

            if (mPosition is not null)
            {
                MPosition = mPosition.Value;
            }

            if (mUp is not null)
            {
                MUp = mUp.Value;
            }

            if (mLookAt is not null)
            {
                MLookAt = mLookAt.Value;
            }

            if (mHorizontalFOV is not null)
            {
                MHorizontalFOV = mHorizontalFOV.Value;
            }

            if (mClipPlaneNear is not null)
            {
                MClipPlaneNear = mClipPlaneNear.Value;
            }

            if (mClipPlaneFar is not null)
            {
                MClipPlaneFar = mClipPlaneFar.Value;
            }

            if (mAspect is not null)
            {
                MAspect = mAspect.Value;
            }

            if (mOrthographicWidth is not null)
            {
                MOrthographicWidth = mOrthographicWidth.Value;
            }
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

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "mOrthographicWidth")]
        public float MOrthographicWidth;
    }
}
