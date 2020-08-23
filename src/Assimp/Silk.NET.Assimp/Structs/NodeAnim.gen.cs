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
    [NativeName("Name", "aiNodeAnim")]
    public unsafe partial struct NodeAnim
    {
        public NodeAnim
        (
            AssimpString mNodeName = default,
            uint mNumPositionKeys = default,
            VectorKey* mPositionKeys = default,
            uint mNumRotationKeys = default,
            QuatKey* mRotationKeys = default,
            uint mNumScalingKeys = default,
            VectorKey* mScalingKeys = default,
            AnimBehaviour mPreState = default,
            AnimBehaviour mPostState = default
        )
        {
            MNodeName = mNodeName;
            MNumPositionKeys = mNumPositionKeys;
            MPositionKeys = mPositionKeys;
            MNumRotationKeys = mNumRotationKeys;
            MRotationKeys = mRotationKeys;
            MNumScalingKeys = mNumScalingKeys;
            MScalingKeys = mScalingKeys;
            MPreState = mPreState;
            MPostState = mPostState;
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
