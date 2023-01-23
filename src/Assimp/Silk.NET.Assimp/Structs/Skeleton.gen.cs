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
    [NativeName("Name", "aiSkeleton")]
    public unsafe partial struct Skeleton
    {
        public Skeleton
        (
            AssimpString? mName = null,
            uint? mNumBones = null,
            SkeletonBone** mBones = null
        ) : this()
        {
            if (mName is not null)
            {
                MName = mName.Value;
            }

            if (mNumBones is not null)
            {
                MNumBones = mNumBones.Value;
            }

            if (mBones is not null)
            {
                MBones = mBones;
            }
        }


        [NativeName("Type", "aiString")]
        [NativeName("Type.Name", "aiString")]
        [NativeName("Name", "mName")]
        public AssimpString MName;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumBones")]
        public uint MNumBones;

        [NativeName("Type", "aiSkeletonBone **")]
        [NativeName("Type.Name", "aiSkeletonBone **")]
        [NativeName("Name", "mBones")]
        public SkeletonBone** MBones;
    }
}
