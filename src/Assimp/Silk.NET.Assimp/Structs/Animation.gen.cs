// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiAnimation")]
    public unsafe partial struct Animation
    {
        public Animation
        (
            AssimpString? mName = null,
            double? mDuration = null,
            double? mTicksPerSecond = null,
            uint? mNumChannels = null,
            NodeAnim** mChannels = null,
            uint? mNumMeshChannels = null,
            MeshAnim** mMeshChannels = null,
            uint? mNumMorphMeshChannels = null,
            MeshMorphAnim** mMorphMeshChannels = null
        ) : this()
        {
            if (mName is not null)
            {
                MName = mName.Value;
            }

            if (mDuration is not null)
            {
                MDuration = mDuration.Value;
            }

            if (mTicksPerSecond is not null)
            {
                MTicksPerSecond = mTicksPerSecond.Value;
            }

            if (mNumChannels is not null)
            {
                MNumChannels = mNumChannels.Value;
            }

            if (mChannels is not null)
            {
                MChannels = mChannels;
            }

            if (mNumMeshChannels is not null)
            {
                MNumMeshChannels = mNumMeshChannels.Value;
            }

            if (mMeshChannels is not null)
            {
                MMeshChannels = mMeshChannels;
            }

            if (mNumMorphMeshChannels is not null)
            {
                MNumMorphMeshChannels = mNumMorphMeshChannels.Value;
            }

            if (mMorphMeshChannels is not null)
            {
                MMorphMeshChannels = mMorphMeshChannels;
            }
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
