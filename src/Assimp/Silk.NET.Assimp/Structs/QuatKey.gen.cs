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
    [NativeName("Name", "aiQuatKey")]
    public unsafe partial struct QuatKey
    {
        public QuatKey
        (
            double? mTime = null,
            AssimpQuaternion? mValue = null,
            AnimInterpolation? mInterpolation = null
        ) : this()
        {
            if (mTime is not null)
            {
                MTime = mTime.Value;
            }

            if (mValue is not null)
            {
                MValue = mValue.Value;
            }

            if (mInterpolation is not null)
            {
                MInterpolation = mInterpolation.Value;
            }
        }


        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "mTime")]
        public double MTime;

        [NativeName("Type", "aiQuaternion")]
        [NativeName("Type.Name", "aiQuaternion")]
        [NativeName("Name", "mValue")]
        public AssimpQuaternion MValue;

        [NativeName("Type", "aiAnimInterpolation")]
        [NativeName("Type.Name", "aiAnimInterpolation")]
        [NativeName("Name", "mInterpolation")]
        public AnimInterpolation MInterpolation;
    }
}
