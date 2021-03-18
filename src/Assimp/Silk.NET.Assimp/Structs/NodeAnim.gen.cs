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
    [NativeName("Name", "aiNodeAnim")]
    public unsafe partial struct NodeAnim
    {
        public NodeAnim
        (
            AssimpString? mNodeName = null,
            uint? mNumPositionKeys = null,
            VectorKey* mPositionKeys = null,
            uint? mNumRotationKeys = null,
            QuatKey* mRotationKeys = null,
            uint? mNumScalingKeys = null,
            VectorKey* mScalingKeys = null,
            AnimBehaviour? mPreState = null,
            AnimBehaviour? mPostState = null
        ) : this()
        {
            if (mNodeName is not null)
            {
                MNodeName = mNodeName.Value;
            }

            if (mNumPositionKeys is not null)
            {
                MNumPositionKeys = mNumPositionKeys.Value;
            }

            if (mPositionKeys is not null)
            {
                MPositionKeys = mPositionKeys;
            }

            if (mNumRotationKeys is not null)
            {
                MNumRotationKeys = mNumRotationKeys.Value;
            }

            if (mRotationKeys is not null)
            {
                MRotationKeys = mRotationKeys;
            }

            if (mNumScalingKeys is not null)
            {
                MNumScalingKeys = mNumScalingKeys.Value;
            }

            if (mScalingKeys is not null)
            {
                MScalingKeys = mScalingKeys;
            }

            if (mPreState is not null)
            {
                MPreState = mPreState.Value;
            }

            if (mPostState is not null)
            {
                MPostState = mPostState.Value;
            }
        }


        [NativeName("Type", "aiString")]
        [NativeName("Type.Name", "aiString")]
        [NativeName("Name", "mNodeName")]
        public AssimpString MNodeName;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumPositionKeys")]
        public uint MNumPositionKeys;

        [NativeName("Type", "aiVectorKey *")]
        [NativeName("Type.Name", "aiVectorKey *")]
        [NativeName("Name", "mPositionKeys")]
        public VectorKey* MPositionKeys;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumRotationKeys")]
        public uint MNumRotationKeys;

        [NativeName("Type", "aiQuatKey *")]
        [NativeName("Type.Name", "aiQuatKey *")]
        [NativeName("Name", "mRotationKeys")]
        public QuatKey* MRotationKeys;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumScalingKeys")]
        public uint MNumScalingKeys;

        [NativeName("Type", "aiVectorKey *")]
        [NativeName("Type.Name", "aiVectorKey *")]
        [NativeName("Name", "mScalingKeys")]
        public VectorKey* MScalingKeys;

        [NativeName("Type", "aiAnimBehaviour")]
        [NativeName("Type.Name", "aiAnimBehaviour")]
        [NativeName("Name", "mPreState")]
        public AnimBehaviour MPreState;

        [NativeName("Type", "aiAnimBehaviour")]
        [NativeName("Type.Name", "aiAnimBehaviour")]
        [NativeName("Name", "mPostState")]
        public AnimBehaviour MPostState;
    }
}
