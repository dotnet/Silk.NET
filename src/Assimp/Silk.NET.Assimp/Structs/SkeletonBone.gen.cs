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
    [NativeName("Name", "aiSkeletonBone")]
    public unsafe partial struct SkeletonBone
    {
        public SkeletonBone
        (
            int? mParent = null,
            Node* mArmature = null,
            Node* mNode = null,
            uint? mNumnWeights = null,
            Mesh* mMeshId = null,
            VertexWeight* mWeights = null,
            System.Numerics.Matrix4x4? mOffsetMatrix = null,
            System.Numerics.Matrix4x4? mLocalMatrix = null
        ) : this()
        {
            if (mParent is not null)
            {
                MParent = mParent.Value;
            }

            if (mArmature is not null)
            {
                MArmature = mArmature;
            }

            if (mNode is not null)
            {
                MNode = mNode;
            }

            if (mNumnWeights is not null)
            {
                MNumnWeights = mNumnWeights.Value;
            }

            if (mMeshId is not null)
            {
                MMeshId = mMeshId;
            }

            if (mWeights is not null)
            {
                MWeights = mWeights;
            }

            if (mOffsetMatrix is not null)
            {
                MOffsetMatrix = mOffsetMatrix.Value;
            }

            if (mLocalMatrix is not null)
            {
                MLocalMatrix = mLocalMatrix.Value;
            }
        }


        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "mParent")]
        public int MParent;

        [NativeName("Type", "aiNode *")]
        [NativeName("Type.Name", "aiNode *")]
        [NativeName("Name", "mArmature")]
        public Node* MArmature;

        [NativeName("Type", "aiNode *")]
        [NativeName("Type.Name", "aiNode *")]
        [NativeName("Name", "mNode")]
        public Node* MNode;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumnWeights")]
        public uint MNumnWeights;

        [NativeName("Type", "aiMesh *")]
        [NativeName("Type.Name", "aiMesh *")]
        [NativeName("Name", "mMeshId")]
        public Mesh* MMeshId;

        [NativeName("Type", "aiVertexWeight *")]
        [NativeName("Type.Name", "aiVertexWeight *")]
        [NativeName("Name", "mWeights")]
        public VertexWeight* MWeights;

        [NativeName("Type", "aiMatrix4x4")]
        [NativeName("Type.Name", "aiMatrix4x4")]
        [NativeName("Name", "mOffsetMatrix")]
        public System.Numerics.Matrix4x4 MOffsetMatrix;

        [NativeName("Type", "aiMatrix4x4")]
        [NativeName("Type.Name", "aiMatrix4x4")]
        [NativeName("Name", "mLocalMatrix")]
        public System.Numerics.Matrix4x4 MLocalMatrix;
    }
}
