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
    [NativeName("Name", "aiBone")]
    public unsafe partial struct Bone
    {
        public Bone
        (
            AssimpString? mName = null,
            uint? mNumWeights = null,
            Node* mArmature = null,
            Node* mNode = null,
            VertexWeight* mWeights = null,
            System.Numerics.Matrix4x4? mOffsetMatrix = null
        ) : this()
        {
            if (mName is not null)
            {
                MName = mName.Value;
            }

            if (mNumWeights is not null)
            {
                MNumWeights = mNumWeights.Value;
            }

            if (mArmature is not null)
            {
                MArmature = mArmature;
            }

            if (mNode is not null)
            {
                MNode = mNode;
            }

            if (mWeights is not null)
            {
                MWeights = mWeights;
            }

            if (mOffsetMatrix is not null)
            {
                MOffsetMatrix = mOffsetMatrix.Value;
            }
        }


        [NativeName("Type", "aiString")]
        [NativeName("Type.Name", "aiString")]
        [NativeName("Name", "mName")]
        public AssimpString MName;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumWeights")]
        public uint MNumWeights;

        [NativeName("Type", "aiNode *")]
        [NativeName("Type.Name", "aiNode *")]
        [NativeName("Name", "mArmature")]
        public Node* MArmature;

        [NativeName("Type", "aiNode *")]
        [NativeName("Type.Name", "aiNode *")]
        [NativeName("Name", "mNode")]
        public Node* MNode;

        [NativeName("Type", "aiVertexWeight *")]
        [NativeName("Type.Name", "aiVertexWeight *")]
        [NativeName("Name", "mWeights")]
        public VertexWeight* MWeights;

        [NativeName("Type", "aiMatrix4x4")]
        [NativeName("Type.Name", "aiMatrix4x4")]
        [NativeName("Name", "mOffsetMatrix")]
        public System.Numerics.Matrix4x4 MOffsetMatrix;
    }
}
