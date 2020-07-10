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
    [NativeName("Name", "aiAnimation")]
    public unsafe partial struct Animation
    {
        public Animation
        (
            AssimpString mName = default,
            double mDuration = default,
            double mTicksPerSecond = default,
            uint mNumChannels = default,
            NodeAnim** mChannels = default,
            uint mNumMeshChannels = default,
            MeshAnim** mMeshChannels = default,
            uint mNumMorphMeshChannels = default,
            MeshMorphAnim** mMorphMeshChannels = default
        )
        {
            MName = mName;
            MDuration = mDuration;
            MTicksPerSecond = mTicksPerSecond;
            MNumChannels = mNumChannels;
            MChannels = mChannels;
            MNumMeshChannels = mNumMeshChannels;
            MMeshChannels = mMeshChannels;
            MNumMorphMeshChannels = mNumMorphMeshChannels;
            MMorphMeshChannels = mMorphMeshChannels;
        }


        [NativeName("Type", "aiString")]
        [NativeName("Type.Name", "aiString")]
        [NativeName("Name", "mName")]
        public AssimpString MName;

        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "mDuration")]
        public double MDuration;

        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "mTicksPerSecond")]
        public double MTicksPerSecond;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumChannels")]
        public uint MNumChannels;

        [NativeName("Type", "aiNodeAnim **")]
        [NativeName("Type.Name", "aiNodeAnim **")]
        [NativeName("Name", "mChannels")]
        public NodeAnim** MChannels;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumMeshChannels")]
        public uint MNumMeshChannels;

        [NativeName("Type", "aiMeshAnim **")]
        [NativeName("Type.Name", "aiMeshAnim **")]
        [NativeName("Name", "mMeshChannels")]
        public MeshAnim** MMeshChannels;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumMorphMeshChannels")]
        public uint MNumMorphMeshChannels;

        [NativeName("Type", "aiMeshMorphAnim **")]
        [NativeName("Type.Name", "aiMeshMorphAnim **")]
        [NativeName("Name", "mMorphMeshChannels")]
        public MeshMorphAnim** MMorphMeshChannels;
    }
}
