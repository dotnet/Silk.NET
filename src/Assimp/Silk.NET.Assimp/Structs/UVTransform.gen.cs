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
    [NativeName("Name", "aiUVTransform")]
    public unsafe partial struct UVTransform
    {
        public UVTransform
        (
            System.Numerics.Vector2? mTranslation = null,
            System.Numerics.Vector2? mScaling = null,
            float? mRotation = null
        ) : this()
        {
            if (mTranslation is not null)
            {
                MTranslation = mTranslation.Value;
            }

            if (mScaling is not null)
            {
                MScaling = mScaling.Value;
            }

            if (mRotation is not null)
            {
                MRotation = mRotation.Value;
            }
        }


        [NativeName("Type", "aiVector2D")]
        [NativeName("Type.Name", "aiVector2D")]
        [NativeName("Name", "mTranslation")]
        public System.Numerics.Vector2 MTranslation;

        [NativeName("Type", "aiVector2D")]
        [NativeName("Type.Name", "aiVector2D")]
        [NativeName("Name", "mScaling")]
        public System.Numerics.Vector2 MScaling;

        [NativeName("Type", "ai_real")]
        [NativeName("Type.Name", "ai_real")]
        [NativeName("Name", "mRotation")]
        public float MRotation;
    }
}
